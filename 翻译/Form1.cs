using System;
using System.Text;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Web;
using Newtonsoft.Json;

namespace 翻译
{
    public partial class Form1 : Form
    {
        private string lang = "zh";

        public Form1()
        {
            InitializeComponent();
        }

        public string trans(string input, string lang)
        {
            try
            {
                // 原文
                string q = input;
                // 源语言
                string from = "auto";
                // 目标语言
                string to = lang;
                // 改成您的APP ID
                string appId = "20200211000382774";
                Random rd = new Random();
                string salt = rd.Next(100000).ToString();
                // 改成您的密钥
                string secretKey = "b1imCNk_EdXIHM0zX2bD";
                string sign = EncryptString(appId + q + salt + secretKey);
                string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
                url += "q=" + HttpUtility.UrlEncode(q);
                url += "&from=" + from;
                url += "&to=" + to;
                url += "&appid=" + appId;
                url += "&salt=" + salt;
                url += "&sign=" + sign;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = null;
                request.Timeout = 6000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                JsonReader json = new JsonTextReader(new StringReader(retString));
                for (int i = 1; i <= 12; i++)
                {
                    json.Read();
                }
                if (json.Value == null)
                {
                    return "";
                }
                else
                {
                    string final = json.Value.ToString();
                    return final;
                }
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
                return e;
            }
        }

        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }

        private void zh_CheckedChanged(object sender, EventArgs e)
        {
            lang = "zh";
        }

        private void en_CheckedChanged(object sender, EventArgs e)
        {
            lang = "en";
        }

        private void yue_CheckedChanged(object sender, EventArgs e)
        {
            lang = "yue";
        }

        private void wyw_CheckedChanged(object sender, EventArgs e)
        {
            lang = "wyw";
        }

        private void jp_CheckedChanged(object sender, EventArgs e)
        {
            lang = "jp";
        }

        private void kor_CheckedChanged(object sender, EventArgs e)
        {
            lang = "kor";
        }

        private void fra_CheckedChanged(object sender, EventArgs e)
        {
            lang = "fra";
        }

        private void spa_CheckedChanged(object sender, EventArgs e)
        {
            lang = "spa";
        }

        private void th_CheckedChanged(object sender, EventArgs e)
        {
            lang = "th";
        }

        private void ara_CheckedChanged(object sender, EventArgs e)
        {
            lang = "ara";
        }

        private void ru_CheckedChanged(object sender, EventArgs e)
        {
            lang = "ru";
        }

        private void pt_CheckedChanged(object sender, EventArgs e)
        {
            lang = "pt";
        }

        private void de_CheckedChanged(object sender, EventArgs e)
        {
            lang = "de";
        }

        private void it_CheckedChanged(object sender, EventArgs e)
        {
            lang = "it";
        }

        private void el_CheckedChanged(object sender, EventArgs e)
        {
            lang = "el";
        }

        private void nl_CheckedChanged(object sender, EventArgs e)
        {
            lang = "nl";
        }

        private void dan_CheckedChanged(object sender, EventArgs e)
        {
            lang = "dan";
        }

        private void est_CheckedChanged(object sender, EventArgs e)
        {
            lang = "est";
        }

        private void bul_CheckedChanged(object sender, EventArgs e)
        {
            lang = "bul";
        }

        private void pl_CheckedChanged(object sender, EventArgs e)
        {
            lang = "pl";
        }

        private void fin_CheckedChanged(object sender, EventArgs e)
        {
            lang = "fin";
        }

        private void rom_CheckedChanged(object sender, EventArgs e)
        {
            lang = "rom";
        }

        private void cs_CheckedChanged(object sender, EventArgs e)
        {
            lang = "cs";
        }

        private void slo_CheckedChanged(object sender, EventArgs e)
        {
            lang = "slo";
        }

        private void swe_CheckedChanged(object sender, EventArgs e)
        {
            lang = "swe";
        }

        private void cht_CheckedChanged(object sender, EventArgs e)
        {
            lang = "cht";
        }

        private void hu_CheckedChanged(object sender, EventArgs e)
        {
            lang = "hu";
        }

        private void vie_CheckedChanged(object sender, EventArgs e)
        {
            lang = "vie";
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string input_text = input.Text.ToString();
            output.Text = "正在翻译...translating...";
            Refresh();
            string output_text = trans(input_text, lang);
            output.Text = output_text;
        }
    }
}