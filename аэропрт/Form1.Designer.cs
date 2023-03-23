
namespace аэропрт
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
            this.hello = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("Play", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hello.Location = new System.Drawing.Point(235, 132);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(286, 35);
            this.hello.TabIndex = 0;
            this.hello.Text = "Добро пожаловать!";
            // 
            // Admin
            // 
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(121, 231);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(230, 79);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(403, 231);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(230, 79);
            this.User.TabIndex = 2;
            this.User.Text = "Пользователь";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button User;
    }
}

