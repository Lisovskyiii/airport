
namespace аэропрт
{
    partial class Status
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
            this.list_status = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loading = new System.Windows.Forms.Button();
            this.Air = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_status
            // 
            this.list_status.HideSelection = false;
            this.list_status.Location = new System.Drawing.Point(59, 106);
            this.list_status.Name = "list_status";
            this.list_status.Size = new System.Drawing.Size(256, 226);
            this.list_status.TabIndex = 0;
            this.list_status.UseCompatibleStateImageBehavior = false;
            this.list_status.View = System.Windows.Forms.View.List;
            this.list_status.SelectedIndexChanged += new System.EventHandler(this.list_status_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Air);
            this.panel1.Controls.Add(this.loading);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(338, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 226);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рейсы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Изменить статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус рейса";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 5;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loading.Font = new System.Drawing.Font("Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loading.Location = new System.Drawing.Point(18, 126);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(112, 37);
            this.loading.TabIndex = 25;
            this.loading.Text = "В ожидании";
            this.loading.UseVisualStyleBackColor = false;
            this.loading.Click += new System.EventHandler(this.loading_Click);
            // 
            // Air
            // 
            this.Air.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Air.Font = new System.Drawing.Font("Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Air.Location = new System.Drawing.Point(136, 126);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(112, 37);
            this.Air.TabIndex = 26;
            this.Air.Text = "В воздухе";
            this.Air.UseVisualStyleBackColor = false;
            this.Air.Click += new System.EventHandler(this.Air_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(18, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Закончен";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.OrangeRed;
            this.Close.Font = new System.Drawing.Font("Play", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close.Location = new System.Drawing.Point(136, 169);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 37);
            this.Close.TabIndex = 28;
            this.Close.Text = "Отменить";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list_status);
            this.Name = "Status";
            this.Text = "Status";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Air;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.Button Close;
    }
}