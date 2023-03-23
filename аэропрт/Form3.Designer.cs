
namespace аэропрт
{
    partial class User_Form
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
            this.Search_race = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Write_sentence = new System.Windows.Forms.Label();
            this.Poisk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_race
            // 
            this.Search_race.AllowDrop = true;
            this.Search_race.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_race.Font = new System.Drawing.Font("Play", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_race.Location = new System.Drawing.Point(238, 169);
            this.Search_race.Name = "Search_race";
            this.Search_race.Size = new System.Drawing.Size(297, 100);
            this.Search_race.TabIndex = 0;
            this.Search_race.Text = "Найти рейс";
            this.Search_race.UseVisualStyleBackColor = true;
            this.Search_race.Click += new System.EventHandler(this.Search_race_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(238, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Write_sentence
            // 
            this.Write_sentence.AutoSize = true;
            this.Write_sentence.Font = new System.Drawing.Font("Play", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Write_sentence.Location = new System.Drawing.Point(238, 169);
            this.Write_sentence.Name = "Write_sentence";
            this.Write_sentence.Size = new System.Drawing.Size(297, 34);
            this.Write_sentence.TabIndex = 2;
            this.Write_sentence.Text = "Введите номер рейса";
            // 
            // Poisk
            // 
            this.Poisk.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Poisk.Location = new System.Drawing.Point(311, 255);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(138, 46);
            this.Poisk.TabIndex = 3;
            this.Poisk.Text = "Найти";
            this.Poisk.UseVisualStyleBackColor = true;
            this.Poisk.Visible = false;
            this.Poisk.Click += new System.EventHandler(this.Poisk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.Write_sentence);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_race);
            this.Name = "User_Form";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.User_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_race;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Write_sentence;
        private System.Windows.Forms.Button Poisk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}