namespace 翻译
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zh = new System.Windows.Forms.RadioButton();
            this.en = new System.Windows.Forms.RadioButton();
            this.yue = new System.Windows.Forms.RadioButton();
            this.wyw = new System.Windows.Forms.RadioButton();
            this.jp = new System.Windows.Forms.RadioButton();
            this.kor = new System.Windows.Forms.RadioButton();
            this.fra = new System.Windows.Forms.RadioButton();
            this.spa = new System.Windows.Forms.RadioButton();
            this.pt = new System.Windows.Forms.RadioButton();
            this.ru = new System.Windows.Forms.RadioButton();
            this.ara = new System.Windows.Forms.RadioButton();
            this.th = new System.Windows.Forms.RadioButton();
            this.nl = new System.Windows.Forms.RadioButton();
            this.el = new System.Windows.Forms.RadioButton();
            this.it = new System.Windows.Forms.RadioButton();
            this.de = new System.Windows.Forms.RadioButton();
            this.dan = new System.Windows.Forms.RadioButton();
            this.est = new System.Windows.Forms.RadioButton();
            this.bul = new System.Windows.Forms.RadioButton();
            this.pl = new System.Windows.Forms.RadioButton();
            this.slo = new System.Windows.Forms.RadioButton();
            this.rom = new System.Windows.Forms.RadioButton();
            this.cs = new System.Windows.Forms.RadioButton();
            this.fin = new System.Windows.Forms.RadioButton();
            this.vie = new System.Windows.Forms.RadioButton();
            this.cht = new System.Windows.Forms.RadioButton();
            this.hu = new System.Windows.Forms.RadioButton();
            this.swe = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 49);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(776, 30);
            this.input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入一句话/单词";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择语言";
            // 
            // zh
            // 
            this.zh.AutoSize = true;
            this.zh.Location = new System.Drawing.Point(13, 135);
            this.zh.Name = "zh";
            this.zh.Size = new System.Drawing.Size(71, 28);
            this.zh.TabIndex = 3;
            this.zh.TabStop = true;
            this.zh.Text = "中文";
            this.zh.UseVisualStyleBackColor = true;
            this.zh.CheckedChanged += new System.EventHandler(this.zh_CheckedChanged);
            // 
            // en
            // 
            this.en.AutoSize = true;
            this.en.Location = new System.Drawing.Point(13, 183);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(71, 28);
            this.en.TabIndex = 4;
            this.en.TabStop = true;
            this.en.Text = "英语";
            this.en.UseVisualStyleBackColor = true;
            this.en.CheckedChanged += new System.EventHandler(this.en_CheckedChanged);
            // 
            // yue
            // 
            this.yue.AutoSize = true;
            this.yue.Location = new System.Drawing.Point(13, 231);
            this.yue.Name = "yue";
            this.yue.Size = new System.Drawing.Size(71, 28);
            this.yue.TabIndex = 5;
            this.yue.TabStop = true;
            this.yue.Text = "粤语";
            this.yue.UseVisualStyleBackColor = true;
            this.yue.CheckedChanged += new System.EventHandler(this.yue_CheckedChanged);
            // 
            // wyw
            // 
            this.wyw.AutoSize = true;
            this.wyw.Location = new System.Drawing.Point(13, 277);
            this.wyw.Name = "wyw";
            this.wyw.Size = new System.Drawing.Size(89, 28);
            this.wyw.TabIndex = 6;
            this.wyw.TabStop = true;
            this.wyw.Text = "文言文";
            this.wyw.UseVisualStyleBackColor = true;
            this.wyw.CheckedChanged += new System.EventHandler(this.wyw_CheckedChanged);
            // 
            // jp
            // 
            this.jp.AutoSize = true;
            this.jp.Location = new System.Drawing.Point(102, 135);
            this.jp.Name = "jp";
            this.jp.Size = new System.Drawing.Size(71, 28);
            this.jp.TabIndex = 7;
            this.jp.TabStop = true;
            this.jp.Text = "日语";
            this.jp.UseVisualStyleBackColor = true;
            this.jp.CheckedChanged += new System.EventHandler(this.jp_CheckedChanged);
            // 
            // kor
            // 
            this.kor.AutoSize = true;
            this.kor.Location = new System.Drawing.Point(102, 183);
            this.kor.Name = "kor";
            this.kor.Size = new System.Drawing.Size(71, 28);
            this.kor.TabIndex = 8;
            this.kor.TabStop = true;
            this.kor.Text = "韩语";
            this.kor.UseVisualStyleBackColor = true;
            this.kor.CheckedChanged += new System.EventHandler(this.kor_CheckedChanged);
            // 
            // fra
            // 
            this.fra.AutoSize = true;
            this.fra.Location = new System.Drawing.Point(102, 231);
            this.fra.Name = "fra";
            this.fra.Size = new System.Drawing.Size(71, 28);
            this.fra.TabIndex = 9;
            this.fra.TabStop = true;
            this.fra.Text = "法语";
            this.fra.UseVisualStyleBackColor = true;
            this.fra.CheckedChanged += new System.EventHandler(this.fra_CheckedChanged);
            // 
            // spa
            // 
            this.spa.AutoSize = true;
            this.spa.Location = new System.Drawing.Point(102, 277);
            this.spa.Name = "spa";
            this.spa.Size = new System.Drawing.Size(107, 28);
            this.spa.TabIndex = 10;
            this.spa.TabStop = true;
            this.spa.Text = "西班牙语";
            this.spa.UseVisualStyleBackColor = true;
            this.spa.CheckedChanged += new System.EventHandler(this.spa_CheckedChanged);
            // 
            // pt
            // 
            this.pt.AutoSize = true;
            this.pt.Location = new System.Drawing.Point(210, 277);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(107, 28);
            this.pt.TabIndex = 14;
            this.pt.TabStop = true;
            this.pt.Text = "葡萄牙语";
            this.pt.UseVisualStyleBackColor = true;
            this.pt.CheckedChanged += new System.EventHandler(this.pt_CheckedChanged);
            // 
            // ru
            // 
            this.ru.AutoSize = true;
            this.ru.Location = new System.Drawing.Point(210, 231);
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(71, 28);
            this.ru.TabIndex = 13;
            this.ru.TabStop = true;
            this.ru.Text = "俄语";
            this.ru.UseVisualStyleBackColor = true;
            this.ru.CheckedChanged += new System.EventHandler(this.ru_CheckedChanged);
            // 
            // ara
            // 
            this.ara.AutoSize = true;
            this.ara.Location = new System.Drawing.Point(210, 183);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(107, 28);
            this.ara.TabIndex = 12;
            this.ara.TabStop = true;
            this.ara.Text = "阿拉伯语";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.CheckedChanged += new System.EventHandler(this.ara_CheckedChanged);
            // 
            // th
            // 
            this.th.AutoSize = true;
            this.th.Location = new System.Drawing.Point(210, 135);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(71, 28);
            this.th.TabIndex = 11;
            this.th.TabStop = true;
            this.th.Text = "泰语";
            this.th.UseVisualStyleBackColor = true;
            this.th.CheckedChanged += new System.EventHandler(this.th_CheckedChanged);
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.Location = new System.Drawing.Point(313, 277);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(89, 28);
            this.nl.TabIndex = 18;
            this.nl.TabStop = true;
            this.nl.Text = "荷兰语";
            this.nl.UseVisualStyleBackColor = true;
            this.nl.CheckedChanged += new System.EventHandler(this.nl_CheckedChanged);
            // 
            // el
            // 
            this.el.AutoSize = true;
            this.el.Location = new System.Drawing.Point(313, 231);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(89, 28);
            this.el.TabIndex = 17;
            this.el.TabStop = true;
            this.el.Text = "希腊语";
            this.el.UseVisualStyleBackColor = true;
            this.el.CheckedChanged += new System.EventHandler(this.el_CheckedChanged);
            // 
            // it
            // 
            this.it.AutoSize = true;
            this.it.Location = new System.Drawing.Point(313, 183);
            this.it.Name = "it";
            this.it.Size = new System.Drawing.Size(107, 28);
            this.it.TabIndex = 16;
            this.it.TabStop = true;
            this.it.Text = "意大利语";
            this.it.UseVisualStyleBackColor = true;
            this.it.CheckedChanged += new System.EventHandler(this.it_CheckedChanged);
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Location = new System.Drawing.Point(313, 135);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(71, 28);
            this.de.TabIndex = 15;
            this.de.TabStop = true;
            this.de.Text = "德语";
            this.de.UseVisualStyleBackColor = true;
            this.de.CheckedChanged += new System.EventHandler(this.de_CheckedChanged);
            // 
            // dan
            // 
            this.dan.AutoSize = true;
            this.dan.Location = new System.Drawing.Point(416, 277);
            this.dan.Name = "dan";
            this.dan.Size = new System.Drawing.Size(89, 28);
            this.dan.TabIndex = 22;
            this.dan.TabStop = true;
            this.dan.Text = "丹麦语";
            this.dan.UseVisualStyleBackColor = true;
            this.dan.CheckedChanged += new System.EventHandler(this.dan_CheckedChanged);
            // 
            // est
            // 
            this.est.AutoSize = true;
            this.est.Location = new System.Drawing.Point(416, 231);
            this.est.Name = "est";
            this.est.Size = new System.Drawing.Size(125, 28);
            this.est.TabIndex = 21;
            this.est.TabStop = true;
            this.est.Text = "爱沙尼亚语";
            this.est.UseVisualStyleBackColor = true;
            this.est.CheckedChanged += new System.EventHandler(this.est_CheckedChanged);
            // 
            // bul
            // 
            this.bul.AutoSize = true;
            this.bul.Location = new System.Drawing.Point(416, 183);
            this.bul.Name = "bul";
            this.bul.Size = new System.Drawing.Size(125, 28);
            this.bul.TabIndex = 20;
            this.bul.TabStop = true;
            this.bul.Text = "保加利亚语";
            this.bul.UseVisualStyleBackColor = true;
            this.bul.CheckedChanged += new System.EventHandler(this.bul_CheckedChanged);
            // 
            // pl
            // 
            this.pl.AutoSize = true;
            this.pl.Location = new System.Drawing.Point(416, 135);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(89, 28);
            this.pl.TabIndex = 19;
            this.pl.TabStop = true;
            this.pl.Text = "波兰语";
            this.pl.UseVisualStyleBackColor = true;
            this.pl.CheckedChanged += new System.EventHandler(this.pl_CheckedChanged);
            // 
            // slo
            // 
            this.slo.AutoSize = true;
            this.slo.Location = new System.Drawing.Point(539, 277);
            this.slo.Name = "slo";
            this.slo.Size = new System.Drawing.Size(143, 28);
            this.slo.TabIndex = 26;
            this.slo.TabStop = true;
            this.slo.Text = "斯洛文尼亚语";
            this.slo.UseVisualStyleBackColor = true;
            this.slo.CheckedChanged += new System.EventHandler(this.slo_CheckedChanged);
            // 
            // rom
            // 
            this.rom.AutoSize = true;
            this.rom.Location = new System.Drawing.Point(539, 231);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(125, 28);
            this.rom.TabIndex = 25;
            this.rom.TabStop = true;
            this.rom.Text = "罗马尼亚语";
            this.rom.UseVisualStyleBackColor = true;
            this.rom.CheckedChanged += new System.EventHandler(this.rom_CheckedChanged);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(539, 183);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(89, 28);
            this.cs.TabIndex = 24;
            this.cs.TabStop = true;
            this.cs.Text = "捷克语";
            this.cs.UseVisualStyleBackColor = true;
            this.cs.CheckedChanged += new System.EventHandler(this.cs_CheckedChanged);
            // 
            // fin
            // 
            this.fin.AutoSize = true;
            this.fin.Location = new System.Drawing.Point(539, 135);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(89, 28);
            this.fin.TabIndex = 23;
            this.fin.TabStop = true;
            this.fin.Text = "芬兰语";
            this.fin.UseVisualStyleBackColor = true;
            this.fin.CheckedChanged += new System.EventHandler(this.fin_CheckedChanged);
            // 
            // vie
            // 
            this.vie.AutoSize = true;
            this.vie.Location = new System.Drawing.Point(678, 277);
            this.vie.Name = "vie";
            this.vie.Size = new System.Drawing.Size(89, 28);
            this.vie.TabIndex = 30;
            this.vie.TabStop = true;
            this.vie.Text = "越南语";
            this.vie.UseVisualStyleBackColor = true;
            this.vie.CheckedChanged += new System.EventHandler(this.vie_CheckedChanged);
            // 
            // cht
            // 
            this.cht.AutoSize = true;
            this.cht.Location = new System.Drawing.Point(678, 231);
            this.cht.Name = "cht";
            this.cht.Size = new System.Drawing.Size(107, 28);
            this.cht.TabIndex = 29;
            this.cht.TabStop = true;
            this.cht.Text = "繁体中文";
            this.cht.UseVisualStyleBackColor = true;
            this.cht.CheckedChanged += new System.EventHandler(this.cht_CheckedChanged);
            // 
            // hu
            // 
            this.hu.AutoSize = true;
            this.hu.Location = new System.Drawing.Point(678, 183);
            this.hu.Name = "hu";
            this.hu.Size = new System.Drawing.Size(107, 28);
            this.hu.TabIndex = 28;
            this.hu.TabStop = true;
            this.hu.Text = "匈牙利语";
            this.hu.UseVisualStyleBackColor = true;
            this.hu.CheckedChanged += new System.EventHandler(this.hu_CheckedChanged);
            // 
            // swe
            // 
            this.swe.AutoSize = true;
            this.swe.Location = new System.Drawing.Point(678, 135);
            this.swe.Name = "swe";
            this.swe.Size = new System.Drawing.Size(89, 28);
            this.swe.TabIndex = 27;
            this.swe.TabStop = true;
            this.swe.Text = "瑞典语";
            this.swe.UseVisualStyleBackColor = true;
            this.swe.CheckedChanged += new System.EventHandler(this.swe_CheckedChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(9, 408);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(776, 30);
            this.output.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "翻译结果";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(323, 320);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 34);
            this.ok.TabIndex = 33;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.vie);
            this.Controls.Add(this.cht);
            this.Controls.Add(this.hu);
            this.Controls.Add(this.swe);
            this.Controls.Add(this.slo);
            this.Controls.Add(this.rom);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.dan);
            this.Controls.Add(this.est);
            this.Controls.Add(this.bul);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.nl);
            this.Controls.Add(this.el);
            this.Controls.Add(this.it);
            this.Controls.Add(this.de);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.ru);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.th);
            this.Controls.Add(this.spa);
            this.Controls.Add(this.fra);
            this.Controls.Add(this.kor);
            this.Controls.Add(this.jp);
            this.Controls.Add(this.wyw);
            this.Controls.Add(this.yue);
            this.Controls.Add(this.en);
            this.Controls.Add(this.zh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "翻译";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input;
        private Label label1;
        private Label label2;
        private RadioButton zh;
        private RadioButton en;
        private RadioButton yue;
        private RadioButton wyw;
        private RadioButton jp;
        private RadioButton kor;
        private RadioButton fra;
        private RadioButton spa;
        private RadioButton pt;
        private RadioButton ru;
        private RadioButton ara;
        private RadioButton th;
        private RadioButton nl;
        private RadioButton el;
        private RadioButton it;
        private RadioButton de;
        private RadioButton dan;
        private RadioButton est;
        private RadioButton bul;
        private RadioButton pl;
        private RadioButton slo;
        private RadioButton rom;
        private RadioButton cs;
        private RadioButton fin;
        private RadioButton vie;
        private RadioButton cht;
        private RadioButton hu;
        private RadioButton swe;
        private TextBox output;
        private Label label3;
        private Button ok;
    }
}