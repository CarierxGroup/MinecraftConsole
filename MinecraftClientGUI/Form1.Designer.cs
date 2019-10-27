namespace MinecraftClientGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.box_ip = new System.Windows.Forms.TextBox();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_Login = new System.Windows.Forms.TextBox();
            this.box_output = new System.Windows.Forms.RichTextBox();
            this.box_input = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Login.Controls.Add(this.label3);
            this.groupBox_Login.Controls.Add(this.label2);
            this.groupBox_Login.Controls.Add(this.label1);
            this.groupBox_Login.Controls.Add(this.btn_connect);
            this.groupBox_Login.Controls.Add(this.box_ip);
            this.groupBox_Login.Controls.Add(this.box_password);
            this.groupBox_Login.Controls.Add(this.box_Login);
            this.groupBox_Login.Location = new System.Drawing.Point(13, 11);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(564, 42);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login Details";
            this.groupBox_Login.Enter += new System.EventHandler(this.groupBox_Login_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(513, 14);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(40, 21);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Go!";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // box_ip
            // 
            this.box_ip.Location = new System.Drawing.Point(400, 16);
            this.box_ip.Name = "box_ip";
            this.box_ip.Size = new System.Drawing.Size(100, 21);
            this.box_ip.TabIndex = 5;
            this.box_ip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyUp);
            // 
            // box_password
            // 
            this.box_password.Location = new System.Drawing.Point(235, 16);
            this.box_password.Name = "box_password";
            this.box_password.PasswordChar = '•';
            this.box_password.Size = new System.Drawing.Size(100, 21);
            this.box_password.TabIndex = 3;
            this.box_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyUp);
            // 
            // box_Login
            // 
            this.box_Login.Location = new System.Drawing.Point(67, 16);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(100, 21);
            this.box_Login.TabIndex = 1;
            this.box_Login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyUp);
            // 
            // box_output
            // 
            this.box_output.Location = new System.Drawing.Point(13, 61);
            this.box_output.Name = "box_output";
            this.box_output.ReadOnly = true;
            this.box_output.Size = new System.Drawing.Size(564, 270);
            this.box_output.TabIndex = 1;
            this.box_output.Text = "";
            this.box_output.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LinkClicked);
            // 
            // box_input
            // 
            this.box_input.AcceptsTab = true;
            this.box_input.Location = new System.Drawing.Point(13, 337);
            this.box_input.MaxLength = 100;
            this.box_input.Multiline = true;
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(490, 19);
            this.box_input.TabIndex = 2;
            this.box_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(509, 336);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(40, 20);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(555, 336);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(22, 20);
            this.btn_about.TabIndex = 4;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Status
            // 
            this.Status.Enabled = true;
            this.Status.Interval = 500;
            this.Status.Tick += new System.EventHandler(this.Status_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(462, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Auto Reconnect";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 367);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.box_input);
            this.Controls.Add(this.box_output);
            this.Controls.Add(this.groupBox_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Console Client GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox box_ip;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.RichTextBox box_output;
        private System.Windows.Forms.TextBox box_input;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Timer Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

