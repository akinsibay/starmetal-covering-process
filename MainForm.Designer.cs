﻿namespace StarMetal
{
    partial class MainForm
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
            this.motorBaslatBtn = new System.Windows.Forms.Button();
            this.motorDurdurBtn = new System.Windows.Forms.Button();
            this.serialCombo = new System.Windows.Forms.ComboBox();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.motorStatusLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.göstergePaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriPortAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // motorBaslatBtn
            // 
            this.motorBaslatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.motorBaslatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorBaslatBtn.Location = new System.Drawing.Point(31, 110);
            this.motorBaslatBtn.Name = "motorBaslatBtn";
            this.motorBaslatBtn.Size = new System.Drawing.Size(387, 64);
            this.motorBaslatBtn.TabIndex = 3;
            this.motorBaslatBtn.Text = "Motor Başlat";
            this.motorBaslatBtn.UseVisualStyleBackColor = false;
            this.motorBaslatBtn.Click += new System.EventHandler(this.motorBaslatBtn_Click);
            // 
            // motorDurdurBtn
            // 
            this.motorDurdurBtn.BackColor = System.Drawing.Color.Red;
            this.motorDurdurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorDurdurBtn.Location = new System.Drawing.Point(31, 180);
            this.motorDurdurBtn.Name = "motorDurdurBtn";
            this.motorDurdurBtn.Size = new System.Drawing.Size(387, 64);
            this.motorDurdurBtn.TabIndex = 4;
            this.motorDurdurBtn.Text = "Motor Durdur";
            this.motorDurdurBtn.UseVisualStyleBackColor = false;
            this.motorDurdurBtn.Click += new System.EventHandler(this.motorDurdurBtn_Click);
            // 
            // serialCombo
            // 
            this.serialCombo.FormattingEnabled = true;
            this.serialCombo.Location = new System.Drawing.Point(31, 65);
            this.serialCombo.Margin = new System.Windows.Forms.Padding(2);
            this.serialCombo.Name = "serialCombo";
            this.serialCombo.Size = new System.Drawing.Size(139, 21);
            this.serialCombo.TabIndex = 6;
            this.serialCombo.SelectedIndexChanged += new System.EventHandler(this.serialCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARDUİNO BİLGİSİ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(552, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 238);
            this.listBox1.TabIndex = 8;
            // 
            // motorStatusLbl
            // 
            this.motorStatusLbl.AutoSize = true;
            this.motorStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorStatusLbl.Location = new System.Drawing.Point(12, 373);
            this.motorStatusLbl.Name = "motorStatusLbl";
            this.motorStatusLbl.Size = new System.Drawing.Size(85, 29);
            this.motorStatusLbl.TabIndex = 10;
            this.motorStatusLbl.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.göstergePaneliToolStripMenuItem,
            this.değerGToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // göstergePaneliToolStripMenuItem
            // 
            this.göstergePaneliToolStripMenuItem.Name = "göstergePaneliToolStripMenuItem";
            this.göstergePaneliToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.göstergePaneliToolStripMenuItem.Text = "Gösterge Paneli";
            this.göstergePaneliToolStripMenuItem.Click += new System.EventHandler(this.göstergePaneliToolStripMenuItem_Click);
            // 
            // değerGToolStripMenuItem
            // 
            this.değerGToolStripMenuItem.Name = "değerGToolStripMenuItem";
            this.değerGToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.değerGToolStripMenuItem.Text = "Değer Girişleri";
            this.değerGToolStripMenuItem.Click += new System.EventHandler(this.değerGToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriPortAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // seriPortAyarlarıToolStripMenuItem
            // 
            this.seriPortAyarlarıToolStripMenuItem.Name = "seriPortAyarlarıToolStripMenuItem";
            this.seriPortAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.seriPortAyarlarıToolStripMenuItem.Text = "Seri Port Ayarları";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 417);
            this.Controls.Add(this.motorStatusLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialCombo);
            this.Controls.Add(this.motorDurdurBtn);
            this.Controls.Add(this.motorBaslatBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button motorBaslatBtn;
        private System.Windows.Forms.Button motorDurdurBtn;
        private System.Windows.Forms.ComboBox serialCombo;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label motorStatusLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem göstergePaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriPortAyarlarıToolStripMenuItem;
    }
}