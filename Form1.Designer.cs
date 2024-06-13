namespace ПР_2._2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTb = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbNumberOfEntries = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CLEARBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTb
            // 
            this.InputTb.BackColor = System.Drawing.Color.FloralWhite;
            this.InputTb.Location = new System.Drawing.Point(24, 145);
            this.InputTb.Multiline = true;
            this.InputTb.Name = "InputTb";
            this.InputTb.Size = new System.Drawing.Size(142, 68);
            this.InputTb.TabIndex = 0;
            this.InputTb.TextChanged += new System.EventHandler(this.InputTb_TextChanged);
            this.InputTb.MouseHover += new System.EventHandler(this.InputTb_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.справкаToolStripMenuItem.Image = global::ПР_2._2.Properties.Resources.circle_customer_help_info_information_service_support_icon_123208;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.выходToolStripMenuItem.Image = global::ПР_2._2.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ResultTb
            // 
            this.ResultTb.BackColor = System.Drawing.Color.FloralWhite;
            this.ResultTb.Location = new System.Drawing.Point(209, 145);
            this.ResultTb.Multiline = true;
            this.ResultTb.Name = "ResultTb";
            this.ResultTb.ReadOnly = true;
            this.ResultTb.Size = new System.Drawing.Size(142, 97);
            this.ResultTb.TabIndex = 2;
            this.ResultTb.TextChanged += new System.EventHandler(this.ResultTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество записей о покупках";
            // 
            // TbNumberOfEntries
            // 
            this.TbNumberOfEntries.BackColor = System.Drawing.Color.FloralWhite;
            this.TbNumberOfEntries.Location = new System.Drawing.Point(24, 68);
            this.TbNumberOfEntries.Multiline = true;
            this.TbNumberOfEntries.Name = "TbNumberOfEntries";
            this.TbNumberOfEntries.Size = new System.Drawing.Size(72, 25);
            this.TbNumberOfEntries.TabIndex = 5;
            this.TbNumberOfEntries.TextChanged += new System.EventHandler(this.TbNumberOfEntries_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите\r\nсписок покупок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод:";
            // 
            // CLEARBTN
            // 
            this.CLEARBTN.BackColor = System.Drawing.Color.Tomato;
            this.CLEARBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLEARBTN.Image = global::ПР_2._2.Properties.Resources.broom_38542__1_;
            this.CLEARBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CLEARBTN.Location = new System.Drawing.Point(292, 12);
            this.CLEARBTN.Name = "CLEARBTN";
            this.CLEARBTN.Size = new System.Drawing.Size(59, 56);
            this.CLEARBTN.TabIndex = 9;
            this.CLEARBTN.UseVisualStyleBackColor = false;
            this.CLEARBTN.Click += new System.EventHandler(this.CLEARBTN_Click);
            this.CLEARBTN.MouseEnter += new System.EventHandler(this.CLEARBTN_MouseEnter);
            this.CLEARBTN.MouseLeave += new System.EventHandler(this.CLEARBTN_MouseLeave);
            this.CLEARBTN.MouseHover += new System.EventHandler(this.CLEARBTN_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ПР_2._2.Properties.Resources.refresh_arrow_6296;
            this.pictureBox1.Location = new System.Drawing.Point(102, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ПР_2._2.Properties.Resources.sortamountdown_120336;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сортировка";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.CLEARBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbNumberOfEntries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultTb);
            this.Controls.Add(this.InputTb);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главный экран";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox ResultTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNumberOfEntries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CLEARBTN;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

