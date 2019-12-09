namespace Sieci1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powróToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieZProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 310);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 54);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(365, 405);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(419, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "wyślij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powróToolStripMenuItem,
            this.wylogujSięToolStripMenuItem,
            this.wyjścieZProgramuToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ustawieniaToolStripMenuItem.Text = "Opcje";
            // 
            // powróToolStripMenuItem
            // 
            this.powróToolStripMenuItem.Name = "powróToolStripMenuItem";
            this.powróToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.powróToolStripMenuItem.Text = "Powróć do Listy zanjomych";
            this.powróToolStripMenuItem.Click += new System.EventHandler(this.powróToolStripMenuItem_Click);
            // 
            // wylogujSięToolStripMenuItem
            // 
            this.wylogujSięToolStripMenuItem.Name = "wylogujSięToolStripMenuItem";
            this.wylogujSięToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.wylogujSięToolStripMenuItem.Text = "Wyloguj się";
            this.wylogujSięToolStripMenuItem.Click += new System.EventHandler(this.wylogujSięToolStripMenuItem_Click);
            // 
            // wyjścieZProgramuToolStripMenuItem
            // 
            this.wyjścieZProgramuToolStripMenuItem.Name = "wyjścieZProgramuToolStripMenuItem";
            this.wyjścieZProgramuToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.wyjścieZProgramuToolStripMenuItem.Text = "Zamknij program";
            this.wyjścieZProgramuToolStripMenuItem.Click += new System.EventHandler(this.wyjścieZProgramuToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(523, 260);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 417);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 28);
            this.textBox3.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Wpisz Nick znajomego, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "z którym chcesz rozmawiać";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(547, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunikator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powróToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieZProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujSięToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}