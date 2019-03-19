namespace Hi_TechManagementSystem.GUI
{
    partial class Logout
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
            this.label1 = new System.Windows.Forms.Label();
            this.flatButtonYes = new FlatUI.FlatButton();
            this.flatButtonCancel = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to logout?";
            // 
            // flatButtonYes
            // 
            this.flatButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.flatButtonYes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButtonYes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButtonYes.Location = new System.Drawing.Point(222, 185);
            this.flatButtonYes.Name = "flatButtonYes";
            this.flatButtonYes.Rounded = false;
            this.flatButtonYes.Size = new System.Drawing.Size(156, 61);
            this.flatButtonYes.TabIndex = 1;
            this.flatButtonYes.Text = "Yes";
            this.flatButtonYes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButtonYes.Click += new System.EventHandler(this.flatButtonYes_Click);
            // 
            // flatButtonCancel
            // 
            this.flatButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.flatButtonCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButtonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButtonCancel.Location = new System.Drawing.Point(600, 185);
            this.flatButtonCancel.Name = "flatButtonCancel";
            this.flatButtonCancel.Rounded = false;
            this.flatButtonCancel.Size = new System.Drawing.Size(156, 61);
            this.flatButtonCancel.TabIndex = 2;
            this.flatButtonCancel.Text = "Cancel";
            this.flatButtonCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButtonCancel.Click += new System.EventHandler(this.flatButtonCancel_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 300);
            this.ControlBox = false;
            this.Controls.Add(this.flatButtonCancel);
            this.Controls.Add(this.flatButtonYes);
            this.Controls.Add(this.label1);
            this.Name = "Logout";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Logout";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FlatUI.FlatButton flatButtonYes;
        private FlatUI.FlatButton flatButtonCancel;
    }
}