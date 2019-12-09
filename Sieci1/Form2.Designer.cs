namespace Sieci1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZnajomegoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista znajomych";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.dodajZnajomegoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyToolStripMenuItem,
            this.wylogujSięToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.ustawieniaToolStripMenuItem.Text = "ustawienia";
            // 
            // wyToolStripMenuItem
            // 
            this.wyToolStripMenuItem.Name = "wyToolStripMenuItem";
            this.wyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.wyToolStripMenuItem.Text = "wyloguj się";
            this.wyToolStripMenuItem.Click += new System.EventHandler(this.wyToolStripMenuItem_Click);
            // 
            // wylogujSięToolStripMenuItem
            // 
            this.wylogujSięToolStripMenuItem.Name = "wylogujSięToolStripMenuItem";
            this.wylogujSięToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.wylogujSięToolStripMenuItem.Text = "zamknij program";
            this.wylogujSięToolStripMenuItem.Click += new System.EventHandler(this.wylogujSięToolStripMenuItem_Click);
            // 
            // dodajZnajomegoToolStripMenuItem1
            // 
            this.dodajZnajomegoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.toolStripMenuItem1});
            this.dodajZnajomegoToolStripMenuItem1.Name = "dodajZnajomegoToolStripMenuItem1";
            this.dodajZnajomegoToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.dodajZnajomegoToolStripMenuItem1.Text = "dodaj znajomego";
            this.dodajZnajomegoToolStripMenuItem1.Click += new System.EventHandler(this.dodajZnajomegoToolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(236, 26);
            this.toolStripTextBox1.Text = "Podaj Imię";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(170, 27);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(236, 26);
            this.toolStripTextBox3.Text = "Podaj Nazwisko";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(170, 27);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem1.Text = "Dodaj";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(233, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Przejdź do konwersacji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 305);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 543);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór znajomych";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujSięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem dodajZnajomegoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}