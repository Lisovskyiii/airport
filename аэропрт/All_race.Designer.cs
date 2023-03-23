
namespace аэропрт
{
    partial class All_race
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_race = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Open_File = new System.Windows.Forms.Button();
            this.Seriliazation = new System.Windows.Forms.Button();
            this.Add_obj = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Range = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Passengers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Plane = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Ostanovka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Punct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Stuardesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pilot2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Pilot1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Kapitan = new System.Windows.Forms.TextBox();
            this.label_all_race = new System.Windows.Forms.Label();
            this.Information_all_race = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(291, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.status_race);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Open_File);
            this.panel1.Controls.Add(this.Seriliazation);
            this.panel1.Controls.Add(this.Add_obj);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_Range);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox_Weight);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_Passengers);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_Plane);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Ostanovka);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_Punct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_Stuardesa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Pilot2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_Pilot1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Kapitan);
            this.panel1.Location = new System.Drawing.Point(309, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 385);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // status_race
            // 
            this.status_race.AutoSize = true;
            this.status_race.Location = new System.Drawing.Point(114, 33);
            this.status_race.Name = "status_race";
            this.status_race.Size = new System.Drawing.Size(47, 20);
            this.status_race.TabIndex = 26;
            this.status_race.Text = "status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Play", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "Рейс";
            // 
            // Open_File
            // 
            this.Open_File.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Open_File.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Open_File.Location = new System.Drawing.Point(671, 324);
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(185, 40);
            this.Open_File.TabIndex = 24;
            this.Open_File.Text = "Открыть";
            this.Open_File.UseVisualStyleBackColor = false;
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // Seriliazation
            // 
            this.Seriliazation.BackColor = System.Drawing.Color.Yellow;
            this.Seriliazation.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seriliazation.Location = new System.Drawing.Point(468, 324);
            this.Seriliazation.Name = "Seriliazation";
            this.Seriliazation.Size = new System.Drawing.Size(185, 40);
            this.Seriliazation.TabIndex = 23;
            this.Seriliazation.Text = "Сохранить ";
            this.Seriliazation.UseVisualStyleBackColor = false;
            this.Seriliazation.Click += new System.EventHandler(this.Seriliazation_Click);
            // 
            // Add_obj
            // 
            this.Add_obj.BackColor = System.Drawing.Color.Lime;
            this.Add_obj.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_obj.Location = new System.Drawing.Point(660, 242);
            this.Add_obj.Name = "Add_obj";
            this.Add_obj.Size = new System.Drawing.Size(185, 40);
            this.Add_obj.TabIndex = 22;
            this.Add_obj.Text = "Добавить";
            this.Add_obj.UseVisualStyleBackColor = false;
            this.Add_obj.Click += new System.EventHandler(this.Add_obj_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Дальность полёта";
            // 
            // textBox_Range
            // 
            this.textBox_Range.Location = new System.Drawing.Point(650, 182);
            this.textBox_Range.Name = "textBox_Range";
            this.textBox_Range.Size = new System.Drawing.Size(206, 27);
            this.textBox_Range.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(650, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Загруженность";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(650, 111);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(206, 27);
            this.textBox_Weight.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(650, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Вместимость";
            // 
            // textBox_Passengers
            // 
            this.textBox_Passengers.Location = new System.Drawing.Point(650, 44);
            this.textBox_Passengers.Name = "textBox_Passengers";
            this.textBox_Passengers.Size = new System.Drawing.Size(206, 27);
            this.textBox_Passengers.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Самолёт";
            // 
            // textBox_Plane
            // 
            this.textBox_Plane.Location = new System.Drawing.Point(325, 252);
            this.textBox_Plane.Name = "textBox_Plane";
            this.textBox_Plane.Size = new System.Drawing.Size(206, 27);
            this.textBox_Plane.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Промежуточные пункты";
            // 
            // textBox_Ostanovka
            // 
            this.textBox_Ostanovka.Location = new System.Drawing.Point(325, 182);
            this.textBox_Ostanovka.Name = "textBox_Ostanovka";
            this.textBox_Ostanovka.Size = new System.Drawing.Size(206, 27);
            this.textBox_Ostanovka.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Точка назначения";
            // 
            // textBox_Punct
            // 
            this.textBox_Punct.Location = new System.Drawing.Point(325, 111);
            this.textBox_Punct.Name = "textBox_Punct";
            this.textBox_Punct.Size = new System.Drawing.Size(206, 27);
            this.textBox_Punct.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Стюардеса";
            // 
            // textBox_Stuardesa
            // 
            this.textBox_Stuardesa.Location = new System.Drawing.Point(325, 44);
            this.textBox_Stuardesa.Name = "textBox_Stuardesa";
            this.textBox_Stuardesa.Size = new System.Drawing.Size(206, 27);
            this.textBox_Stuardesa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пилот 2";
            // 
            // textBox_Pilot2
            // 
            this.textBox_Pilot2.Location = new System.Drawing.Point(13, 253);
            this.textBox_Pilot2.Name = "textBox_Pilot2";
            this.textBox_Pilot2.Size = new System.Drawing.Size(206, 27);
            this.textBox_Pilot2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пилот 1 ";
            // 
            // textBox_Pilot1
            // 
            this.textBox_Pilot1.Location = new System.Drawing.Point(13, 182);
            this.textBox_Pilot1.Name = "textBox_Pilot1";
            this.textBox_Pilot1.Size = new System.Drawing.Size(206, 27);
            this.textBox_Pilot1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Капитан бригады";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Kapitan
            // 
            this.textBox_Kapitan.Location = new System.Drawing.Point(13, 115);
            this.textBox_Kapitan.Name = "textBox_Kapitan";
            this.textBox_Kapitan.Size = new System.Drawing.Size(206, 27);
            this.textBox_Kapitan.TabIndex = 0;
            // 
            // label_all_race
            // 
            this.label_all_race.AutoSize = true;
            this.label_all_race.Location = new System.Drawing.Point(12, 22);
            this.label_all_race.Name = "label_all_race";
            this.label_all_race.Size = new System.Drawing.Size(52, 20);
            this.label_all_race.TabIndex = 0;
            this.label_all_race.Text = "Рейсы";
            // 
            // Information_all_race
            // 
            this.Information_all_race.AutoSize = true;
            this.Information_all_race.Location = new System.Drawing.Point(309, 22);
            this.Information_all_race.Name = "Information_all_race";
            this.Information_all_race.Size = new System.Drawing.Size(102, 20);
            this.Information_all_race.TabIndex = 2;
            this.Information_all_race.Text = "Информация";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // All_race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 450);
            this.Controls.Add(this.Information_all_race);
            this.Controls.Add(this.label_all_race);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "All_race";
            this.Text = "All_race";
            this.Load += new System.EventHandler(this.All_race_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Kapitan;
        private System.Windows.Forms.Label label_all_race;
        private System.Windows.Forms.Label Information_all_race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Stuardesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Pilot2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Pilot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Plane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Ostanovka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Punct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Range;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Passengers;
        private System.Windows.Forms.Button Add_obj;
        private System.Windows.Forms.Button Seriliazation;
        private System.Windows.Forms.Button Open_File;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label status_race;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}