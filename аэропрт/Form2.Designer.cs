
namespace аэропрт
{
    partial class Admin_form
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
            this.All_race = new System.Windows.Forms.Button();
            this.Disp_punkt = new System.Windows.Forms.Button();
            this.Status_race = new System.Windows.Forms.Button();
            this.Menu_Admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // All_race
            // 
            this.All_race.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.All_race.Location = new System.Drawing.Point(312, 125);
            this.All_race.Name = "All_race";
            this.All_race.Size = new System.Drawing.Size(177, 65);
            this.All_race.TabIndex = 0;
            this.All_race.Text = "Рейсы";
            this.All_race.UseVisualStyleBackColor = true;
            this.All_race.Click += new System.EventHandler(this.button1_Click);
            // 
            // Disp_punkt
            // 
            this.Disp_punkt.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Disp_punkt.Location = new System.Drawing.Point(312, 208);
            this.Disp_punkt.Name = "Disp_punkt";
            this.Disp_punkt.Size = new System.Drawing.Size(177, 65);
            this.Disp_punkt.TabIndex = 1;
            this.Disp_punkt.Text = "Диспетчерские пункты";
            this.Disp_punkt.UseVisualStyleBackColor = true;
            this.Disp_punkt.Click += new System.EventHandler(this.Disp_punkt_Click);
            // 
            // Status_race
            // 
            this.Status_race.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status_race.Location = new System.Drawing.Point(312, 293);
            this.Status_race.Name = "Status_race";
            this.Status_race.Size = new System.Drawing.Size(177, 60);
            this.Status_race.TabIndex = 2;
            this.Status_race.Text = "Статусы";
            this.Status_race.UseVisualStyleBackColor = true;
            this.Status_race.Click += new System.EventHandler(this.Status_race_Click);
            // 
            // Menu_Admin
            // 
            this.Menu_Admin.AutoSize = true;
            this.Menu_Admin.Font = new System.Drawing.Font("Play", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menu_Admin.Location = new System.Drawing.Point(355, 78);
            this.Menu_Admin.Name = "Menu_Admin";
            this.Menu_Admin.Size = new System.Drawing.Size(96, 35);
            this.Menu_Admin.TabIndex = 3;
            this.Menu_Admin.Text = "Меню";
            this.Menu_Admin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_Admin);
            this.Controls.Add(this.Status_race);
            this.Controls.Add(this.Disp_punkt);
            this.Controls.Add(this.All_race);
            this.Name = "Admin_form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button All_race;
        private System.Windows.Forms.Button Disp_punkt;
        private System.Windows.Forms.Button Status_race;
        private System.Windows.Forms.Label Menu_Admin;
    }
}