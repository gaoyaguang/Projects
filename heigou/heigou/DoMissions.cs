using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace heigou
{
    /// <summary>
    /// 做任务
    /// </summary>
    public class DoMissions
    {
        private string root = System.Environment.CurrentDirectory;       // 文件执行的根路径

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="cookieContainer"></param>
        /// <param name="usename"></param>
        /// <returns></returns>
        public Dictionary<string, string> login(CookieContainer cookieContainer, string usename)
        {
            string url = "http://www.heigo.com.cn/map-web/servlet/Login2Servlet";

            String file = root + "\\loginDeviceId.properties";
            FileUtil.createFile(file);
            FileProperties keys = new FileProperties(file);

            string deviceId = loadLoginDeviceId(cookieContainer, file, usename, keys);

            //"req=[{"mobileNumber":"15811347006","password":"00B7691D86D96AEBD21DD9E138F90840","loginDeviceId":"B804D325-0EAE-4CBF-BFB4-804407C84488","isManual":"1"}]";
            string param = "req=[{\"mobileNumber\":\"" + usename + "\",\"password\":\"00B7691D86D96AEBD21DD9E138F90840\",\"loginDeviceId\":\"" + deviceId + "\",\"isManual\":\"1\"}]";
            param = UrlCode.UrlEncode(param);
            return Httpclient.post(url, param, "application/x-www-form-urlencoded", cookieContainer);
        }

        /**
         *  获取设备ID方法
         *  1、自动生成设备ID并记录到软件所在目录下的loginDeviceId.txt文件里；
         *  2、存在文件则读取已经记录的设备ID；
         */
        public static string loadLoginDeviceId(CookieContainer cookieContainer, string file, string mobile, FileProperties keys)
        {
            String key = (String)keys[mobile];
            if (key == string.Empty || key == null)
            {
                key = generateDeviceId(mobile);
                keys.Add(mobile, key);
                // 保存properties文件
                keys.save(file);
            }
            return key;
        }

        public static string generateDeviceId(string mobile)
        {
            return Guid.NewGuid().ToString().ToUpper(); // 生成设备ID
        }

        /// <summary>
        /// 吐槽
        /// </summary>
        /// <param name="cookies"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Dictionary<string, string> shareMood(CookieContainer cookieContainer, string userid, string content)
        {
            string url = "http://www.heigo.com.cn/map-web/servlet/SendBbsImageServlet";

            Random rd = new Random();
            string md5 = MD5Util.md5(rd.Next(1, 100).ToString()).Substring(8, 16).ToUpper();
            string boundary = "Boundary+" + md5;

            // string shareMoodContent = getShareMoodContent();

            string param = getShareMoodParam(boundary, userid, content);
            Dictionary<string, string> dictionary = Httpclient.post(url, param, "multipart/form-data; boundary=" + boundary, cookieContainer);
            dictionary.Add("shareMoodContent", content);
            return dictionary;
        }

        public string getShareMoodParam(string boundary, string userid, string content)
        {
            string param = "--" + boundary + "\r\n" +
            "Content-Disposition: form-data; name=\"bbsText\"\r\n" +
                    "\r\n" +
            content + "\r\n" +
            "--" + boundary + "\r\n" +
            "Content-Disposition: form-data; name=\"type\"\r\n" +
                    "\r\n" +
            "2\r\n" +
            "--" + boundary + "\r\n" +
            "Content-Disposition: form-data; name=\"userId\"\r\n" +
                    "\r\n" +
            userid + "\r\n" +
            "--" + boundary + "--\r\n" +
                    "\r\n";
            return param;
        }

        public string getShareMoodContent()
        {
            Random rd = new Random();
            string[] contents = {"额额不错!","嘻嘻嘻","哈哈哈哈","今天啦啦啦","太阳当空照","我来吐个槽", "希望中个奖", "娱乐新闻啊" ,"111", "晚上中奖率高吗", "嘻嘻嘻哈哈"};
            string content = "";
            if (content == string.Empty)
            {
                content = contents[rd.Next(contents.Length - 1)];
            }
            return content;
        }

        /// <summary>
        /// 邀请好友
        /// </summary>
        /// <param name="cookieContainer"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Dictionary<string, string> inviteFriend(CookieContainer cookieContainer, string userid)
        {
            string url = "http://www.heigo.com.cn/map-web/servlet/ShareOrInviteServlet";

            string param = "req=[{\"userId\":\"" + userid + "\",\"operationType\":\"1\"}]";
            return Httpclient.post(url, param, "application/x-www-form-urlencoded", cookieContainer);
        }

        /// <summary>
        /// 分享成就
        /// </summary>
        /// <param name="cookieContainer"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Dictionary<string, string> shareCJ(CookieContainer cookieContainer, string userid)
        {
            string url = "http://www.heigo.com.cn/map-web/servlet/ShareOrInviteServlet";

            string param = "req=[{\"userId\":\"" + userid + "\",\"operationType\":\"2\"}]";
            return Httpclient.post(url, param, "application/x-www-form-urlencoded", cookieContainer);
        }

        /// <summary>
        /// 抽奖
        /// </summary>
        /// <param name="cookieContainer"></param>
        /// <param name="userid"></param>
        /// <param name="userNickname"></param>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public Dictionary<string, string> lucky(CookieContainer cookieContainer, string userid, string userNickname, string cardId)
        {
            string url1 = "http://www.heigo.com.cn/map-web/servlet/EnterHomepageServlet";
            string param1 = "req=[{\"userId\":\"" + userid + "\"}]";
            Httpclient.post(url1, param1, "application/x-www-form-urlencoded", cookieContainer);

            string url2 = "http://www.heigo.com.cn/map-web/servlet/EnterLuckyServlet";
            string param2 = "req=[{\"userId\":\"" + userid + "\"}]";
            Httpclient.post(url2, param2, "application/x-www-form-urlencoded", cookieContainer);

            string url3 = "http://www.heigo.com.cn/map-web/servlet/StartLuckyServlet";
            string param3 = "req=[{\"userId\":\"" + userid + "\",\"userNickname\":\"" + userNickname + "\",\"cardId\":\"" + cardId + "\"}]";
            return Httpclient.post(url3, param3, "application/x-www-form-urlencoded", cookieContainer);
        }
    }

}
