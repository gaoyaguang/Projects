using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heigou
{
    public class Httpclient
    {
        public static Dictionary<string, string> post(string url, string param, string contentType, CookieContainer cookieContainer)
        {
            Stream dataStream = null;
            Dictionary<string,string> responseMsg = new Dictionary<string, string>();
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.Method = "POST";                            // 请求方法
                request.ProtocolVersion = new Version(1, 1);        // Http/1.1版本
                request.ContentType = contentType;// application/x-www-form-urlencoded
                byte[] reqBytes = Encoding.UTF8.GetBytes(param);
                request.CookieContainer = cookieContainer;
                request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                request.Headers.Add("Accept-Charset", "GBK,utf-8;q=0.7,*;q=0.3");
                using (dataStream = request.GetRequestStream())
                {
                    dataStream.Write(reqBytes, 0, reqBytes.Length);
                }
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                cookieContainer = request.CookieContainer; //保存cookies

                responseMsg.Add("cookie", "");

                string header = "";
                //Header
                foreach (var item in response.Headers)
                {
                    header += item.ToString() + ": " + response.GetResponseHeader(item.ToString()) + Environment.NewLine;
                }
                responseMsg.Add("header", header);
                //如果主体信息不为空，则接收主体信息内容
                if (response.ContentLength <= 0)
                    return responseMsg;
                //接收响应主体信息
                using (Stream stream = response.GetResponseStream())
                {
                    int totalLength = (int)response.ContentLength;
                    int numBytesRead = 0;
                    byte[] bytes = new byte[totalLength + 1024];
                    //通过一个循环读取流中的数据，读取完毕，跳出循环
                    while (numBytesRead < totalLength)
                    {
                        int num = stream.Read(bytes, numBytesRead, 1024);  //每次希望读取1024字节
                        if (num == 0)   //说明流中数据读取完毕
                            break;
                        numBytesRead += num;
                    }
                    //将接收到的主体数据显示到界面
                    string content = Encoding.UTF8.GetString(bytes);
                    responseMsg.Add("response", content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
            }
            return responseMsg;
        }
    }
}
