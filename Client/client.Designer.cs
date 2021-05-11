
namespace Client
{
    partial class client
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
            this.txtHash = new System.Windows.Forms.TextBox();
            this.plainText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lvMessage = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Create_Key = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSNT_Q = new System.Windows.Forms.TextBox();
            this.txtSNT_P = new System.Windows.Forms.TextBox();
            this.btnSNT = new System.Windows.Forms.Button();
            this.Chat = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtCheckKeyN = new System.Windows.Forms.TextBox();
            this.txtCheckKeyE = new System.Windows.Forms.TextBox();
            this.txtCheckToken = new System.Windows.Forms.TextBox();
            this.txtCheckPlaintext = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_Create_Key.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Chat.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(17, 250);
            this.txtHash.Name = "txtHash";
            this.txtHash.PlaceholderText = "Bản băm";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(390, 23);
            this.txtHash.TabIndex = 0;
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(17, 221);
            this.plainText.Name = "plainText";
            this.plainText.PlaceholderText = "Content";
            this.plainText.Size = new System.Drawing.Size(288, 23);
            this.plainText.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(311, 192);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lvMessage
            // 
            this.lvMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvMessage.HideSelection = false;
            this.lvMessage.Location = new System.Drawing.Point(17, 17);
            this.lvMessage.MultiSelect = false;
            this.lvMessage.Name = "lvMessage";
            this.lvMessage.Size = new System.Drawing.Size(390, 161);
            this.lvMessage.TabIndex = 2;
            this.lvMessage.UseCompatibleStateImageBehavior = false;
            this.lvMessage.View = System.Windows.Forms.View.Details;
            this.lvMessage.SelectedIndexChanged += new System.EventHandler(this.lvMessage_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 192);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(288, 23);
            this.txtName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Create_Key);
            this.tabControl1.Controls.Add(this.Chat);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 499);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tab_Create_Key
            // 
            this.Tab_Create_Key.Controls.Add(this.groupBox2);
            this.Tab_Create_Key.Controls.Add(this.groupBox1);
            this.Tab_Create_Key.Location = new System.Drawing.Point(4, 24);
            this.Tab_Create_Key.Name = "Tab_Create_Key";
            this.Tab_Create_Key.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Create_Key.Size = new System.Drawing.Size(425, 471);
            this.Tab_Create_Key.TabIndex = 1;
            this.Tab_Create_Key.Text = "Create Key";
            this.Tab_Create_Key.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTinh);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 228);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính các giá trị";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(105, 147);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(176, 55);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtN);
            this.groupBox5.Controls.Add(this.txtE);
            this.groupBox5.Location = new System.Drawing.Point(7, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 116);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Khóa công khai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "N";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "E";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(103, 60);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(63, 23);
            this.txtN.TabIndex = 1;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(13, 60);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(63, 23);
            this.txtE.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtN1);
            this.groupBox4.Controls.Add(this.txtD);
            this.groupBox4.Location = new System.Drawing.Point(215, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 116);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khóa bí mật";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "D";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(100, 60);
            this.txtN1.Name = "txtN1";
            this.txtN1.ReadOnly = true;
            this.txtN1.Size = new System.Drawing.Size(63, 23);
            this.txtN1.TabIndex = 1;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(13, 60);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(64, 23);
            this.txtD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-186, -62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "N";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSNT_Q);
            this.groupBox1.Controls.Add(this.txtSNT_P);
            this.groupBox1.Controls.Add(this.btnSNT);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn số nguyên tố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SNT thứ hai (Q)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SNT thứ nhất (P)";
            // 
            // txtSNT_Q
            // 
            this.txtSNT_Q.Location = new System.Drawing.Point(131, 60);
            this.txtSNT_Q.Name = "txtSNT_Q";
            this.txtSNT_Q.ReadOnly = true;
            this.txtSNT_Q.Size = new System.Drawing.Size(112, 23);
            this.txtSNT_Q.TabIndex = 1;
            // 
            // txtSNT_P
            // 
            this.txtSNT_P.Location = new System.Drawing.Point(131, 31);
            this.txtSNT_P.Name = "txtSNT_P";
            this.txtSNT_P.ReadOnly = true;
            this.txtSNT_P.Size = new System.Drawing.Size(112, 23);
            this.txtSNT_P.TabIndex = 1;
            // 
            // btnSNT
            // 
            this.btnSNT.Location = new System.Drawing.Point(272, 31);
            this.btnSNT.Name = "btnSNT";
            this.btnSNT.Size = new System.Drawing.Size(95, 52);
            this.btnSNT.TabIndex = 0;
            this.btnSNT.Text = "Tạo SNT";
            this.btnSNT.UseVisualStyleBackColor = true;
            this.btnSNT.Click += new System.EventHandler(this.btnSNT_Click);
            // 
            // Chat
            // 
            this.Chat.Controls.Add(this.groupBox6);
            this.Chat.Controls.Add(this.lvMessage);
            this.Chat.Controls.Add(this.txtToken);
            this.Chat.Controls.Add(this.txtHash);
            this.Chat.Controls.Add(this.btnSend);
            this.Chat.Controls.Add(this.plainText);
            this.Chat.Controls.Add(this.txtName);
            this.Chat.Location = new System.Drawing.Point(4, 24);
            this.Chat.Name = "Chat";
            this.Chat.Padding = new System.Windows.Forms.Padding(3);
            this.Chat.Size = new System.Drawing.Size(425, 471);
            this.Chat.TabIndex = 0;
            this.Chat.Text = "Chat";
            this.Chat.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.txtCheckToken);
            this.groupBox6.Controls.Add(this.txtCheckPlaintext);
            this.groupBox6.Location = new System.Drawing.Point(17, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 116);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kiểm tra chữ ký";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnKiemTra);
            this.groupBox7.Controls.Add(this.txtCheckKeyN);
            this.groupBox7.Controls.Add(this.txtCheckKeyE);
            this.groupBox7.Location = new System.Drawing.Point(222, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(162, 97);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Khóa công khai";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(7, 55);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(149, 36);
            this.btnKiemTra.TabIndex = 1;
            this.btnKiemTra.Text = "Kiêm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtCheckKeyN
            // 
            this.txtCheckKeyN.Location = new System.Drawing.Point(88, 25);
            this.txtCheckKeyN.Name = "txtCheckKeyN";
            this.txtCheckKeyN.PlaceholderText = "N";
            this.txtCheckKeyN.Size = new System.Drawing.Size(68, 23);
            this.txtCheckKeyN.TabIndex = 0;
            // 
            // txtCheckKeyE
            // 
            this.txtCheckKeyE.Location = new System.Drawing.Point(6, 25);
            this.txtCheckKeyE.Name = "txtCheckKeyE";
            this.txtCheckKeyE.PlaceholderText = "E";
            this.txtCheckKeyE.Size = new System.Drawing.Size(68, 23);
            this.txtCheckKeyE.TabIndex = 0;
            // 
            // txtCheckToken
            // 
            this.txtCheckToken.Location = new System.Drawing.Point(6, 71);
            this.txtCheckToken.Multiline = true;
            this.txtCheckToken.Name = "txtCheckToken";
            this.txtCheckToken.PlaceholderText = "Chữ ký";
            this.txtCheckToken.ReadOnly = true;
            this.txtCheckToken.Size = new System.Drawing.Size(210, 39);
            this.txtCheckToken.TabIndex = 0;
            // 
            // txtCheckPlaintext
            // 
            this.txtCheckPlaintext.Location = new System.Drawing.Point(6, 22);
            this.txtCheckPlaintext.Multiline = true;
            this.txtCheckPlaintext.Name = "txtCheckPlaintext";
            this.txtCheckPlaintext.PlaceholderText = "Văn bản";
            this.txtCheckPlaintext.ReadOnly = true;
            this.txtCheckPlaintext.Size = new System.Drawing.Size(210, 39);
            this.txtCheckPlaintext.TabIndex = 0;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(17, 279);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.PlaceholderText = "Chữ ký số";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(390, 67);
            this.txtToken.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(14, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "label1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(143, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(143, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // client
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "client";
            this.Text = "client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.client_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Create_Key.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Chat.ResumeLayout(false);
            this.Chat.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lvMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Chat;
        private System.Windows.Forms.TabPage Tab_Create_Key;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNT_Q;
        private System.Windows.Forms.TextBox txtSNT_P;
        private System.Windows.Forms.Button btnSNT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtCheckKeyN;
        private System.Windows.Forms.TextBox txtCheckKeyE;
        private System.Windows.Forms.TextBox txtCheckToken;
        private System.Windows.Forms.TextBox txtCheckPlaintext;
    }
}