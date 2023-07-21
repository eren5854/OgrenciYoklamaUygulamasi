namespace OgrenciYoklamaUygulamasi
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
            panel1 = new Panel();
            label11 = new Label();
            ghstBtn = new Button();
            panel4 = new Panel();
            panel8 = new Panel();
            maxBtn = new Button();
            panel3 = new Panel();
            closeBtn = new Button();
            panel2 = new Panel();
            yoklamaBtn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ogrSave = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ogrListBtn = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            listBox1 = new ListBox();
            ogrListPanel = new Panel();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            ogrKayitPanel = new Panel();
            label8 = new Label();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ogrNoTxt = new TextBox();
            ogrSoyadTxt = new TextBox();
            ogrAdTxt = new TextBox();
            ogrYoklamaPanel = new Panel();
            label10 = new Label();
            yokBtn = new Button();
            varBtn = new Button();
            listBox4 = new ListBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ogrListPanel.SuspendLayout();
            ogrKayitPanel.SuspendLayout();
            ogrYoklamaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 173, 181);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(ghstBtn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(closeBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(34, 40, 49);
            label11.Location = new Point(3, 2);
            label11.Name = "label11";
            label11.Size = new Size(212, 20);
            label11.TabIndex = 4;
            label11.Text = "Öğrenci Yoklama Uygulaması";
            // 
            // ghstBtn
            // 
            ghstBtn.BackColor = Color.Transparent;
            ghstBtn.BackgroundImage = (Image)resources.GetObject("ghstBtn.BackgroundImage");
            ghstBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ghstBtn.Dock = DockStyle.Right;
            ghstBtn.FlatAppearance.BorderSize = 0;
            ghstBtn.FlatStyle = FlatStyle.Flat;
            ghstBtn.Location = new Point(730, 0);
            ghstBtn.Name = "ghstBtn";
            ghstBtn.Size = new Size(20, 25);
            ghstBtn.TabIndex = 2;
            ghstBtn.UseVisualStyleBackColor = false;
            ghstBtn.Click += ghstBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(750, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 25);
            panel4.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 25);
            panel8.TabIndex = 4;
            // 
            // maxBtn
            // 
            maxBtn.BackColor = Color.Transparent;
            maxBtn.BackgroundImage = (Image)resources.GetObject("maxBtn.BackgroundImage");
            maxBtn.BackgroundImageLayout = ImageLayout.Zoom;
            maxBtn.Dock = DockStyle.Right;
            maxBtn.FlatAppearance.BorderSize = 0;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Location = new Point(755, 0);
            maxBtn.Name = "maxBtn";
            maxBtn.Size = new Size(20, 25);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += maxBtn_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(775, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 25);
            panel3.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundImage = (Image)resources.GetObject("closeBtn.BackgroundImage");
            closeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            closeBtn.Dock = DockStyle.Right;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(780, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 25);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 62, 70);
            panel2.Controls.Add(yoklamaBtn);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(ogrSave);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(ogrListBtn);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 425);
            panel2.TabIndex = 1;
            // 
            // yoklamaBtn
            // 
            yoklamaBtn.BackColor = Color.FromArgb(0, 173, 181);
            yoklamaBtn.Dock = DockStyle.Top;
            yoklamaBtn.FlatStyle = FlatStyle.Flat;
            yoklamaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            yoklamaBtn.Location = new Point(0, 153);
            yoklamaBtn.Name = "yoklamaBtn";
            yoklamaBtn.Size = new Size(125, 23);
            yoklamaBtn.TabIndex = 5;
            yoklamaBtn.Text = "Yoklama Al";
            yoklamaBtn.UseVisualStyleBackColor = false;
            yoklamaBtn.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 128);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(125, 25);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // ogrSave
            // 
            ogrSave.BackColor = Color.FromArgb(0, 173, 181);
            ogrSave.Dock = DockStyle.Top;
            ogrSave.FlatStyle = FlatStyle.Flat;
            ogrSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ogrSave.Location = new Point(0, 103);
            ogrSave.Name = "ogrSave";
            ogrSave.Size = new Size(125, 25);
            ogrSave.TabIndex = 4;
            ogrSave.Text = "Öğrenci Kaydet";
            ogrSave.UseVisualStyleBackColor = false;
            ogrSave.Click += ogrSave_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(125, 25);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // ogrListBtn
            // 
            ogrListBtn.BackColor = Color.FromArgb(0, 173, 181);
            ogrListBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ogrListBtn.Dock = DockStyle.Top;
            ogrListBtn.FlatAppearance.BorderSize = 0;
            ogrListBtn.FlatStyle = FlatStyle.Flat;
            ogrListBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ogrListBtn.ForeColor = Color.Black;
            ogrListBtn.Location = new Point(0, 53);
            ogrListBtn.Name = "ogrListBtn";
            ogrListBtn.Size = new Size(125, 25);
            ogrListBtn.TabIndex = 0;
            ogrListBtn.Text = "Öğrenci Listesi";
            ogrListBtn.UseVisualStyleBackColor = false;
            ogrListBtn.Click += ogrListBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 53);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(34, 166, 153);
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 1;
            label1.Text = "MENÜ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(40, 33);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(125, 20);
            panel7.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "010- Arda Güler", "022- Serdar Dursun", "067- Zehra Güneş", "087- Gizem Örge", "088- Saliha Şahin", "128- Ferdi Kadioğlu", "139- Hande Baladın", "160- İrfan Kahveci", "187- Emre Mor", "191- Ebrar Karakurt" });
            listBox1.Location = new Point(99, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(131, 169);
            listBox1.TabIndex = 2;
            // 
            // ogrListPanel
            // 
            ogrListPanel.Controls.Add(label9);
            ogrListPanel.Controls.Add(label4);
            ogrListPanel.Controls.Add(label3);
            ogrListPanel.Controls.Add(label2);
            ogrListPanel.Controls.Add(listBox3);
            ogrListPanel.Controls.Add(listBox2);
            ogrListPanel.Controls.Add(listBox1);
            ogrListPanel.Dock = DockStyle.Left;
            ogrListPanel.Location = new Point(125, 25);
            ogrListPanel.Name = "ogrListPanel";
            ogrListPanel.Size = new Size(325, 425);
            ogrListPanel.TabIndex = 3;
            ogrListPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(60, 11);
            label9.Name = "label9";
            label9.Size = new Size(215, 30);
            label9.TabIndex = 12;
            label9.Text = "Öğrenci Listesi Paneli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(187, 261);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Derse Gelmeyenler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 261);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Derse Gelenler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Tüm Liste";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(187, 279);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(131, 124);
            listBox3.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 279);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(131, 124);
            listBox2.TabIndex = 3;
            // 
            // ogrKayitPanel
            // 
            ogrKayitPanel.Controls.Add(label8);
            ogrKayitPanel.Controls.Add(button1);
            ogrKayitPanel.Controls.Add(label7);
            ogrKayitPanel.Controls.Add(label6);
            ogrKayitPanel.Controls.Add(label5);
            ogrKayitPanel.Controls.Add(ogrNoTxt);
            ogrKayitPanel.Controls.Add(ogrSoyadTxt);
            ogrKayitPanel.Controls.Add(ogrAdTxt);
            ogrKayitPanel.Dock = DockStyle.Left;
            ogrKayitPanel.Location = new Point(750, 25);
            ogrKayitPanel.Name = "ogrKayitPanel";
            ogrKayitPanel.Size = new Size(30, 425);
            ogrKayitPanel.TabIndex = 4;
            ogrKayitPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(60, 11);
            label8.Name = "label8";
            label8.Size = new Size(205, 30);
            label8.TabIndex = 11;
            label8.Text = "Öğrenci Kayıt Paneli";
            // 
            // button1
            // 
            button1.Location = new Point(140, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 135);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 9;
            label7.Text = "Öğrenci Numarası:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 106);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 8;
            label6.Text = "Öğrenci Soyadı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 77);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Öğrenci Adı:";
            // 
            // ogrNoTxt
            // 
            ogrNoTxt.Location = new Point(129, 132);
            ogrNoTxt.Name = "ogrNoTxt";
            ogrNoTxt.Size = new Size(100, 23);
            ogrNoTxt.TabIndex = 2;
            // 
            // ogrSoyadTxt
            // 
            ogrSoyadTxt.Location = new Point(129, 103);
            ogrSoyadTxt.Name = "ogrSoyadTxt";
            ogrSoyadTxt.Size = new Size(100, 23);
            ogrSoyadTxt.TabIndex = 1;
            // 
            // ogrAdTxt
            // 
            ogrAdTxt.Location = new Point(129, 74);
            ogrAdTxt.Name = "ogrAdTxt";
            ogrAdTxt.Size = new Size(100, 23);
            ogrAdTxt.TabIndex = 0;
            // 
            // ogrYoklamaPanel
            // 
            ogrYoklamaPanel.Controls.Add(label10);
            ogrYoklamaPanel.Controls.Add(yokBtn);
            ogrYoklamaPanel.Controls.Add(varBtn);
            ogrYoklamaPanel.Controls.Add(listBox4);
            ogrYoklamaPanel.Dock = DockStyle.Left;
            ogrYoklamaPanel.Location = new Point(450, 25);
            ogrYoklamaPanel.Name = "ogrYoklamaPanel";
            ogrYoklamaPanel.Size = new Size(300, 425);
            ogrYoklamaPanel.TabIndex = 5;
            ogrYoklamaPanel.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(33, 11);
            label10.Name = "label10";
            label10.Size = new Size(238, 30);
            label10.TabIndex = 13;
            label10.Text = "Öğrenci Yoklama Paneli";
            // 
            // yokBtn
            // 
            yokBtn.Location = new Point(181, 297);
            yokBtn.Name = "yokBtn";
            yokBtn.Size = new Size(75, 23);
            yokBtn.TabIndex = 5;
            yokBtn.Text = "Yok";
            yokBtn.UseVisualStyleBackColor = true;
            yokBtn.Click += yokBtn_Click;
            // 
            // varBtn
            // 
            varBtn.Location = new Point(57, 297);
            varBtn.Name = "varBtn";
            varBtn.Size = new Size(75, 23);
            varBtn.TabIndex = 4;
            varBtn.Text = "Var";
            varBtn.UseVisualStyleBackColor = true;
            varBtn.Click += varBtn_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "010- Arda Güler", "022- Serdar Dursun", "067- Zehra Güneş", "087- Gizem Örge", "088- Saliha Şahin", "128- Ferdi Kadioğlu", "139- Hande Baladın", "160- İrfan Kahveci", "187- Emre Mor", "191- Ebrar Karakurt" });
            listBox4.Location = new Point(94, 81);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(131, 169);
            listBox4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(ogrKayitPanel);
            Controls.Add(ogrYoklamaPanel);
            Controls.Add(ogrListPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ogrListPanel.ResumeLayout(false);
            ogrListPanel.PerformLayout();
            ogrKayitPanel.ResumeLayout(false);
            ogrKayitPanel.PerformLayout();
            ogrYoklamaPanel.ResumeLayout(false);
            ogrYoklamaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button closeBtn;
        private Panel panel2;
        private Button ghstBtn;
        private Button maxBtn;
        private Panel panel4;
        private Panel panel3;
        private Button ogrListBtn;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Button ogrSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button yoklamaBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private ListBox listBox1;
        private Panel ogrListPanel;
        private Panel ogrKayitPanel;
        private ListBox listBox3;
        private ListBox listBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox ogrNoTxt;
        private TextBox ogrSoyadTxt;
        private TextBox ogrAdTxt;
        private Label label9;
        private Label label8;
        private Panel ogrYoklamaPanel;
        private Label label10;
        private Button yokBtn;
        private Button varBtn;
        private ListBox listBox4;
        private Label label11;
    }
}