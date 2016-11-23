using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace heigou
{
    public partial class Heigo : Form
    {
        public Heigo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DoMissions doMissions = null;
                string cookie = "";
                string userId = "";
                string defaultCardId = "";
                string defaultCardName = "";
                string userNickname = "";
                CookieContainer cookieContainer = null;
                this.result.AppendText("=====================欢迎使用黑狗自动化娱乐软件！=====================\r\n");
                foreach (string username in usernames.Lines)
                {
                    this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：手机号码为" + username + "！\r\n");
                    cookieContainer = new CookieContainer();
                    doMissions = new DoMissions();
                    Dictionary<string, string> responseMsg = doMissions.login(cookieContainer, username);
                    string loginResponse = "";
                    if (responseMsg.ContainsKey("response"))
                    {
                        loginResponse = responseMsg["response"];
                    }
                    // this.result.Text += loginResponse;
                    if (responseMsg.ContainsKey("cookie"))
                    {
                        cookie = responseMsg["cookie"]; // 获取cookie
                    }

                    // this.result.Text += loginResponse + "\r\n";
                    if (loginResponse.Contains("\"result\":0"))
                    {
                        this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：登陆成功！\r\n");
                        // this.result.Text += username + "：登陆成功！\r\n";
                        string[] data1s = loginResponse.Split('[')[1].Split(']')[0].Split(',');
                        foreach (string data1 in data1s)
                        {
                            if (data1.Contains("userId"))
                            {
                                userId = data1.Split(':')[1].Replace("\"", "");
                            }
                            else if (data1.Contains("defaultCardId"))
                            {
                                defaultCardId = data1.Split(':')[1].Replace("\"", "");
                            }
                            else if (data1.Contains("defaultCardName"))
                            {
                                defaultCardName = data1.Split(':')[1].Replace("\"", "");
                            }
                            else if (data1.Contains("userNickname"))
                            {
                                userNickname = data1.Split(':')[1].Replace("\"", "");
                            }
                        }
                    }

                    Random rd = new Random();
                    System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);

                    string[] moodConts = moodCont.Lines;
                    string content = moodConts[rd.Next(moodConts.Length - 1)];
                    // 吐槽一次
                    responseMsg = doMissions.shareMood(cookieContainer, userId, content);
                    if (responseMsg.ContainsKey("response"))
                    {
                        this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：吐槽一次！\r\n");
                        if (responseMsg.ContainsKey("shareMoodContent"))
                        {
                            this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：内容为\"" + content + "\"\r\n");
                        }
                    }

                    System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);
                    Int32 ifc = Int32.Parse(this.inviteFriendCount.Text);
                    // 邀请好友三次
                    for (int i = 0; i < ifc; i++)
                    {
                        if (i != 0)
                        {
                            System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);
                        }
                        responseMsg = doMissions.inviteFriend(cookieContainer, userId);
                        if (responseMsg.ContainsKey("response"))
                        {
                            // this.result.Text += responseMsg["response"] + "\r\n";
                            this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：第" + (i + 1) + "次邀请好友成功！\r\n");
                        }
                    }

                    System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);
                    Int32 scc = Int32.Parse(this.shareCJCount.Text);
                    // 分享三次
                    for (int i = 0; i < scc; i++)
                    {
                        if(i != 0)
                        {
                            System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);
                        }
                        responseMsg = doMissions.shareCJ(cookieContainer, userId);
                        if (responseMsg.ContainsKey("response"))
                        {
                            // this.result.Text += responseMsg["response"] + "\r\n";
                            this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：第" + (i + 1) + "次分享成就成功！\r\n");
                        }
                    }

                    System.Threading.Thread.Sleep(rd.Next(1, 3) * 1000);
                    // 抽奖一次
                    this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：抽奖开始！\r\n");
                    responseMsg = doMissions.lucky(cookieContainer, userId, userNickname, defaultCardId);
                    string luckyResponse = "";
                    if (responseMsg.ContainsKey("response"))
                    {
                        luckyResponse = responseMsg["response"];
                    }
                    string messageText = "";
                    if (luckyResponse != string.Empty && luckyResponse.Contains("\"result\":0"))
                    {
                        // this.result.Text += username + "：抽奖成功！\r\n";
                        this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：抽奖成功！\r\n");
                        string[] data1s = loginResponse.Split('[')[1].Split(']')[0].Split(',');
                        foreach (string data1 in data1s)
                        {
                            if (data1.Contains("messageText"))
                            {
                                messageText = data1.Split(':')[1].Replace("\"", "");
                                this.result.Text += messageText + "\r\n";
                            }
                        }
                    }else
                    {
                        this.result.AppendText(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss ") + "：抽奖失败！\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         *  获取设备ID方法
         *  1、自动生成设备ID并记录到软件所在目录下的loginDeviceId.txt文件里；
         *  2、存在文件则读取已经记录的设备ID；
         */
        public static string loadLoginDeviceId(string file, string mobile, FileProperties keys)
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.usernames.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.moodCont.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.result.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void moodCont_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
