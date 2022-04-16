using System.Text;
using System.Diagnostics;
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
            Process cmd = new Process();
            cmd.StartInfo.FileName = @"api.exe";
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.WorkingDirectory = ".";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.Arguments = "\"" + input + "\" \"" + lang + "\"";
            cmd.Start();
            string outstr = cmd.StandardOutput.ReadToEnd();
            outstr.Replace("\n", " ");
            cmd.WaitForExit();
            cmd.Close();
            return outstr;
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