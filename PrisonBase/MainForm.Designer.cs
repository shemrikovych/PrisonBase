namespace PrisonBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BaseMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrisonersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.законитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.TermLabel = new System.Windows.Forms.Label();
            this.PrisonDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RelativesLabel = new System.Windows.Forms.Label();
            this.CasteLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrisonerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BaseMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(-1, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 285);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // BaseMenu
            // 
            this.BaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.PrisonersToolStripMenuItem,
            this.ShowToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.BaseMenu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu.Name = "BaseMenu";
            this.BaseMenu.Size = new System.Drawing.Size(738, 24);
            this.BaseMenu.TabIndex = 5;
            this.BaseMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // PrisonersToolStripMenuItem
            // 
            this.PrisonersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.PrisonersToolStripMenuItem.Name = "PrisonersToolStripMenuItem";
            this.PrisonersToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.PrisonersToolStripMenuItem.Text = "Заключенные";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.ShowToolStripMenuItem.Text = "Показать информацию";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowInfoToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.StatsToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьРедактированиеToolStripMenuItem,
            this.законитьРедактированиеToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // начатьРедактированиеToolStripMenuItem
            // 
            this.начатьРедактированиеToolStripMenuItem.Name = "начатьРедактированиеToolStripMenuItem";
            this.начатьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.начатьРедактированиеToolStripMenuItem.Text = "Начать редактирование";
            this.начатьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.StartEditToolStripMenuItem_Click);
            // 
            // законитьРедактированиеToolStripMenuItem
            // 
            this.законитьРедактированиеToolStripMenuItem.Name = "законитьРедактированиеToolStripMenuItem";
            this.законитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.законитьРедактированиеToolStripMenuItem.Text = "Закончить редактирование";
            this.законитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.StopEditToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(106, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 1;
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(106, 47);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(0, 13);
            this.ArticleLabel.TabIndex = 2;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(106, 75);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(0, 13);
            this.RoomLabel.TabIndex = 3;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(106, 101);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 13);
            this.AgeLabel.TabIndex = 4;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Location = new System.Drawing.Point(106, 125);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(0, 13);
            this.TermLabel.TabIndex = 5;
            // 
            // PrisonDateLabel
            // 
            this.PrisonDateLabel.AutoSize = true;
            this.PrisonDateLabel.Location = new System.Drawing.Point(106, 152);
            this.PrisonDateLabel.Name = "PrisonDateLabel";
            this.PrisonDateLabel.Size = new System.Drawing.Size(0, 13);
            this.PrisonDateLabel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RelativesLabel);
            this.panel1.Controls.Add(this.CasteLabel);
            this.panel1.Controls.Add(this.CityLabel);
            this.panel1.Controls.Add(this.CharacterLabel);
            this.panel1.Controls.Add(this.PrisonDateLabel);
            this.panel1.Controls.Add(this.TermLabel);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.RoomLabel);
            this.panel1.Controls.Add(this.ArticleLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(364, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 285);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Родственники";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Каста";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Прописка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Характер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата взятия \r\nпод стражу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Срок заключения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Камера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Статья УК";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ф.И.О.";
            // 
            // RelativesLabel
            // 
            this.RelativesLabel.AutoSize = true;
            this.RelativesLabel.Location = new System.Drawing.Point(106, 263);
            this.RelativesLabel.Name = "RelativesLabel";
            this.RelativesLabel.Size = new System.Drawing.Size(0, 13);
            this.RelativesLabel.TabIndex = 10;
            // 
            // CasteLabel
            // 
            this.CasteLabel.AutoSize = true;
            this.CasteLabel.Location = new System.Drawing.Point(106, 241);
            this.CasteLabel.Name = "CasteLabel";
            this.CasteLabel.Size = new System.Drawing.Size(0, 13);
            this.CasteLabel.TabIndex = 9;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(106, 214);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(0, 13);
            this.CityLabel.TabIndex = 8;
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Location = new System.Drawing.Point(106, 190);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(0, 13);
            this.CharacterLabel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(738, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BaseMenu);
            this.MainMenuStrip = this.BaseMenu;
            this.Name = "MainForm";
            this.Text = "СИЗО \"Альбатрос\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BaseMenu.ResumeLayout(false);
            this.BaseMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip BaseMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem PrisonersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource PrisonerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.Label PrisonDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label RelativesLabel;
        private System.Windows.Forms.Label CasteLabel;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem законитьРедактированиеToolStripMenuItem;
    }
}

