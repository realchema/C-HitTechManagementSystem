namespace Hi_TechManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.flatComboBoxLogin = new FlatUI.FlatComboBox();
            this.flatTextBoxlogin = new FlatUI.FlatTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.linkLabelNotSignin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatComboBoxLogin
            // 
            this.flatComboBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBoxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBoxLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBoxLogin.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBoxLogin.ForeColor = System.Drawing.Color.White;
            this.flatComboBoxLogin.FormattingEnabled = true;
            this.flatComboBoxLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBoxLogin.ItemHeight = 18;
            this.flatComboBoxLogin.Location = new System.Drawing.Point(244, 373);
            this.flatComboBoxLogin.Name = "flatComboBoxLogin";
            this.flatComboBoxLogin.Size = new System.Drawing.Size(251, 24);
            this.flatComboBoxLogin.TabIndex = 0;
            this.flatComboBoxLogin.SelectedIndexChanged += new System.EventHandler(this.flatComboBoxLogin_SelectedIndexChanged);
            // 
            // flatTextBoxlogin
            // 
            this.flatTextBoxlogin.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBoxlogin.FocusOnHover = false;
            this.flatTextBoxlogin.Location = new System.Drawing.Point(244, 496);
            this.flatTextBoxlogin.MaxLength = 32767;
            this.flatTextBoxlogin.Multiline = false;
            this.flatTextBoxlogin.Name = "flatTextBoxlogin";
            this.flatTextBoxlogin.ReadOnly = false;
            this.flatTextBoxlogin.Size = new System.Drawing.Size(251, 47);
            this.flatTextBoxlogin.TabIndex = 1;
            this.flatTextBoxlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBoxlogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBoxlogin.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(244, 608);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(251, 50);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "Login";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // linkLabelNotSignin
            // 
            this.linkLabelNotSignin.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelNotSignin.AutoSize = true;
            this.linkLabelNotSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelNotSignin.LinkColor = System.Drawing.Color.White;
            this.linkLabelNotSignin.Location = new System.Drawing.Point(239, 741);
            this.linkLabelNotSignin.Name = "linkLabelNotSignin";
            this.linkLabelNotSignin.Size = new System.Drawing.Size(259, 29);
            this.linkLabelNotSignin.TabIndex = 12;
            this.linkLabelNotSignin.TabStop = true;
            this.linkLabelNotSignin.Text = "Forgot your password?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 976);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelNotSignin);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flatTextBoxlogin);
            this.Controls.Add(this.flatComboBoxLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatComboBox flatComboBoxLogin;
        private FlatUI.FlatTextBox flatTextBoxlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.LinkLabel linkLabelNotSignin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}