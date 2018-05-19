namespace ServerConn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMaHoa = new System.Windows.Forms.GroupBox();
            this.textBox_IV = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.grbGiaima = new System.Windows.Forms.GroupBox();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txtGiaima = new System.Windows.Forms.TextBox();
            this.lblGiaima = new System.Windows.Forms.Label();
            this.txtchatformClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_sendPublickeyN = new System.Windows.Forms.TextBox();
            this.textBox_SendPublickeyE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.textbox_PrivateKeyD = new System.Windows.Forms.TextBox();
            this.textbox_PublicKeyN = new System.Windows.Forms.TextBox();
            this.textbox_PublicKeyE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendNoise = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbMaHoa.SuspendLayout();
            this.grbGiaima.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message from Client:";
            // 
            // grbMaHoa
            // 
            this.grbMaHoa.Controls.Add(this.textBox_IV);
            this.grbMaHoa.Controls.Add(this.btnMaHoa);
            this.grbMaHoa.Controls.Add(this.txtMaHoa);
            this.grbMaHoa.Controls.Add(this.label2);
            this.grbMaHoa.Controls.Add(this.btnSend);
            this.grbMaHoa.Controls.Add(this.txtChat);
            this.grbMaHoa.Controls.Add(this.lblMess);
            this.grbMaHoa.Location = new System.Drawing.Point(12, 155);
            this.grbMaHoa.Name = "grbMaHoa";
            this.grbMaHoa.Size = new System.Drawing.Size(295, 200);
            this.grbMaHoa.TabIndex = 4;
            this.grbMaHoa.TabStop = false;
            this.grbMaHoa.Text = "Mã Hóa";
            // 
            // textBox_IV
            // 
            this.textBox_IV.Location = new System.Drawing.Point(6, 169);
            this.textBox_IV.Name = "textBox_IV";
            this.textBox_IV.ReadOnly = true;
            this.textBox_IV.Size = new System.Drawing.Size(100, 20);
            this.textBox_IV.TabIndex = 17;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(214, 45);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 4;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Location = new System.Drawing.Point(6, 84);
            this.txtMaHoa.Multiline = true;
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(283, 78);
            this.txtMaHoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuỗi mã hóa:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(112, 169);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 20);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(78, 19);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(211, 20);
            this.txtChat.TabIndex = 4;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Location = new System.Drawing.Point(6, 22);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(75, 13);
            this.lblMess.TabIndex = 4;
            this.lblMess.Text = "nội dung chat:";
            // 
            // grbGiaima
            // 
            this.grbGiaima.Controls.Add(this.btnGiaiMa);
            this.grbGiaima.Controls.Add(this.txtGiaima);
            this.grbGiaima.Controls.Add(this.lblGiaima);
            this.grbGiaima.Controls.Add(this.txtchatformClient);
            this.grbGiaima.Controls.Add(this.label4);
            this.grbGiaima.Location = new System.Drawing.Point(313, 155);
            this.grbGiaima.Name = "grbGiaima";
            this.grbGiaima.Size = new System.Drawing.Size(295, 168);
            this.grbGiaima.TabIndex = 6;
            this.grbGiaima.TabStop = false;
            this.grbGiaima.Text = "Giải mã";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(214, 45);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 4;
            this.btnGiaiMa.Text = "giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txtGiaima
            // 
            this.txtGiaima.Location = new System.Drawing.Point(6, 84);
            this.txtGiaima.Multiline = true;
            this.txtGiaima.Name = "txtGiaima";
            this.txtGiaima.Size = new System.Drawing.Size(283, 78);
            this.txtGiaima.TabIndex = 4;
            // 
            // lblGiaima
            // 
            this.lblGiaima.AutoSize = true;
            this.lblGiaima.Location = new System.Drawing.Point(6, 68);
            this.lblGiaima.Name = "lblGiaima";
            this.lblGiaima.Size = new System.Drawing.Size(73, 13);
            this.lblGiaima.TabIndex = 4;
            this.lblGiaima.Text = "Chuỗi giải mã:";
            // 
            // txtchatformClient
            // 
            this.txtchatformClient.Location = new System.Drawing.Point(78, 19);
            this.txtchatformClient.Name = "txtchatformClient";
            this.txtchatformClient.Size = new System.Drawing.Size(211, 20);
            this.txtchatformClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "nội dung chat:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(590, 108);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_sendPublickeyN);
            this.groupBox3.Controls.Add(this.textBox_SendPublickeyE);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(608, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 73);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khóa gửi đến";
            // 
            // textbox_sendPublickeyN
            // 
            this.textbox_sendPublickeyN.Location = new System.Drawing.Point(35, 41);
            this.textbox_sendPublickeyN.Name = "textbox_sendPublickeyN";
            this.textbox_sendPublickeyN.ReadOnly = true;
            this.textbox_sendPublickeyN.Size = new System.Drawing.Size(100, 20);
            this.textbox_sendPublickeyN.TabIndex = 8;
            // 
            // textBox_SendPublickeyE
            // 
            this.textBox_SendPublickeyE.Location = new System.Drawing.Point(35, 19);
            this.textBox_SendPublickeyE.Name = "textBox_SendPublickeyE";
            this.textBox_SendPublickeyE.ReadOnly = true;
            this.textBox_SendPublickeyE.Size = new System.Drawing.Size(100, 20);
            this.textBox_SendPublickeyE.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "N =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "E =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateKey);
            this.groupBox2.Controls.Add(this.textbox_PrivateKeyD);
            this.groupBox2.Controls.Add(this.textbox_PublicKeyN);
            this.groupBox2.Controls.Add(this.textbox_PublicKeyE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(608, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo khóa";
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(9, 88);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(126, 23);
            this.btnCreateKey.TabIndex = 13;
            this.btnCreateKey.Text = "Tạo khóa ngẫu nhiên";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // textbox_PrivateKeyD
            // 
            this.textbox_PrivateKeyD.Location = new System.Drawing.Point(35, 62);
            this.textbox_PrivateKeyD.Name = "textbox_PrivateKeyD";
            this.textbox_PrivateKeyD.ReadOnly = true;
            this.textbox_PrivateKeyD.Size = new System.Drawing.Size(100, 20);
            this.textbox_PrivateKeyD.TabIndex = 5;
            // 
            // textbox_PublicKeyN
            // 
            this.textbox_PublicKeyN.Location = new System.Drawing.Point(35, 39);
            this.textbox_PublicKeyN.Name = "textbox_PublicKeyN";
            this.textbox_PublicKeyN.ReadOnly = true;
            this.textbox_PublicKeyN.Size = new System.Drawing.Size(100, 20);
            this.textbox_PublicKeyN.TabIndex = 4;
            // 
            // textbox_PublicKeyE
            // 
            this.textbox_PublicKeyE.Location = new System.Drawing.Point(35, 17);
            this.textbox_PublicKeyE.Name = "textbox_PublicKeyE";
            this.textbox_PublicKeyE.ReadOnly = true;
            this.textbox_PublicKeyE.Size = new System.Drawing.Size(100, 20);
            this.textbox_PublicKeyE.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "D =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "N =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E =";
            // 
            // btnSendNoise
            // 
            this.btnSendNoise.Location = new System.Drawing.Point(317, 323);
            this.btnSendNoise.Name = "btnSendNoise";
            this.btnSendNoise.Size = new System.Drawing.Size(75, 20);
            this.btnSendNoise.TabIndex = 16;
            this.btnSendNoise.Text = "SendNoise";
            this.btnSendNoise.UseVisualStyleBackColor = true;
            this.btnSendNoise.Click += new System.EventHandler(this.btnSendNoise_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 370);
            this.Controls.Add(this.btnSendNoise);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grbGiaima);
            this.Controls.Add(this.grbMaHoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMaHoa.ResumeLayout(false);
            this.grbMaHoa.PerformLayout();
            this.grbGiaima.ResumeLayout(false);
            this.grbGiaima.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbMaHoa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.GroupBox grbGiaima;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.TextBox txtGiaima;
        private System.Windows.Forms.Label lblGiaima;
        private System.Windows.Forms.TextBox txtchatformClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textbox_sendPublickeyN;
        private System.Windows.Forms.TextBox textBox_SendPublickeyE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.TextBox textbox_PrivateKeyD;
        private System.Windows.Forms.TextBox textbox_PublicKeyN;
        private System.Windows.Forms.TextBox textbox_PublicKeyE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendNoise;
        private System.Windows.Forms.TextBox textBox_IV;
        private System.Windows.Forms.Timer timer1;
    }
}

