namespace DummyFileCreator
{
	partial class Form1
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
            this.optionbox = new System.Windows.Forms.GroupBox();
            this.maxsizebutton = new System.Windows.Forms.RadioButton();
            this.sizecombo = new System.Windows.Forms.TextBox();
            this.datarandom = new System.Windows.Forms.CheckBox();
            this.gbswitch = new System.Windows.Forms.RadioButton();
            this.mbswitch = new System.Windows.Forms.RadioButton();
            this.kbswitch = new System.Windows.Forms.RadioButton();
            this.filelocation = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.browsebox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createfilebutton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lengthcurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lengthmax = new System.Windows.Forms.ToolStripStatusLabel();
            this.optionbox.SuspendLayout();
            this.browsebox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionbox
            // 
            this.optionbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionbox.Controls.Add(this.maxsizebutton);
            this.optionbox.Controls.Add(this.sizecombo);
            this.optionbox.Controls.Add(this.datarandom);
            this.optionbox.Controls.Add(this.gbswitch);
            this.optionbox.Controls.Add(this.mbswitch);
            this.optionbox.Controls.Add(this.kbswitch);
            this.optionbox.Location = new System.Drawing.Point(12, 27);
            this.optionbox.Name = "optionbox";
            this.optionbox.Size = new System.Drawing.Size(339, 143);
            this.optionbox.TabIndex = 2;
            this.optionbox.TabStop = false;
            this.optionbox.Text = "Select the size of the dummy file to create:";
            // 
            // maxsizebutton
            // 
            this.maxsizebutton.AutoSize = true;
            this.maxsizebutton.Location = new System.Drawing.Point(6, 115);
            this.maxsizebutton.Name = "maxsizebutton";
            this.maxsizebutton.Size = new System.Drawing.Size(68, 17);
            this.maxsizebutton.TabIndex = 15;
            this.maxsizebutton.TabStop = true;
            this.maxsizebutton.Text = "Fill \'er Up";
            this.maxsizebutton.UseVisualStyleBackColor = true;
            this.maxsizebutton.CheckedChanged += new System.EventHandler(this.maxsizebutton_CheckedChanged);
            // 
            // sizecombo
            // 
            this.sizecombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizecombo.Location = new System.Drawing.Point(6, 19);
            this.sizecombo.Name = "sizecombo";
            this.sizecombo.Size = new System.Drawing.Size(327, 20);
            this.sizecombo.TabIndex = 14;
            // 
            // datarandom
            // 
            this.datarandom.AutoSize = true;
            this.datarandom.Location = new System.Drawing.Point(51, 47);
            this.datarandom.Name = "datarandom";
            this.datarandom.Size = new System.Drawing.Size(132, 17);
            this.datarandom.TabIndex = 13;
            this.datarandom.Text = "Random Values In File";
            this.datarandom.UseVisualStyleBackColor = true;
            // 
            // gbswitch
            // 
            this.gbswitch.AutoSize = true;
            this.gbswitch.Location = new System.Drawing.Point(6, 92);
            this.gbswitch.Name = "gbswitch";
            this.gbswitch.Size = new System.Drawing.Size(40, 17);
            this.gbswitch.TabIndex = 2;
            this.gbswitch.Text = "GB";
            this.gbswitch.UseVisualStyleBackColor = true;
            // 
            // mbswitch
            // 
            this.mbswitch.AutoSize = true;
            this.mbswitch.Location = new System.Drawing.Point(6, 69);
            this.mbswitch.Name = "mbswitch";
            this.mbswitch.Size = new System.Drawing.Size(41, 17);
            this.mbswitch.TabIndex = 1;
            this.mbswitch.Text = "MB";
            this.mbswitch.UseVisualStyleBackColor = true;
            // 
            // kbswitch
            // 
            this.kbswitch.AutoSize = true;
            this.kbswitch.Checked = true;
            this.kbswitch.Location = new System.Drawing.Point(6, 46);
            this.kbswitch.Name = "kbswitch";
            this.kbswitch.Size = new System.Drawing.Size(39, 17);
            this.kbswitch.TabIndex = 0;
            this.kbswitch.TabStop = true;
            this.kbswitch.Text = "KB";
            this.kbswitch.UseVisualStyleBackColor = true;
            // 
            // filelocation
            // 
            this.filelocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filelocation.Location = new System.Drawing.Point(6, 33);
            this.filelocation.Name = "filelocation";
            this.filelocation.Size = new System.Drawing.Size(272, 20);
            this.filelocation.TabIndex = 3;
            // 
            // browsebutton
            // 
            this.browsebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browsebutton.Location = new System.Drawing.Point(6, 59);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(272, 23);
            this.browsebutton.TabIndex = 4;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // browsebox
            // 
            this.browsebox.Controls.Add(this.filelocation);
            this.browsebox.Controls.Add(this.browsebutton);
            this.browsebox.Location = new System.Drawing.Point(13, 176);
            this.browsebox.Name = "browsebox";
            this.browsebox.Size = new System.Drawing.Size(284, 91);
            this.browsebox.TabIndex = 5;
            this.browsebox.TabStop = false;
            this.browsebox.Text = "Select folder to save file to:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createfilebutton
            // 
            this.createfilebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createfilebutton.Location = new System.Drawing.Point(12, 273);
            this.createfilebutton.Name = "createfilebutton";
            this.createfilebutton.Size = new System.Drawing.Size(339, 23);
            this.createfilebutton.TabIndex = 7;
            this.createfilebutton.Text = "Create File";
            this.createfilebutton.UseVisualStyleBackColor = true;
            this.createfilebutton.Click += new System.EventHandler(this.createfilebutton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progbar,
            this.lengthcurrent,
            this.toolStripStatusLabel2,
            this.lengthmax});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // progbar
            // 
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(100, 16);
            // 
            // lengthcurrent
            // 
            this.lengthcurrent.Name = "lengthcurrent";
            this.lengthcurrent.Size = new System.Drawing.Size(14, 17);
            this.lengthcurrent.Text = "X";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "/";
            // 
            // lengthmax
            // 
            this.lengthmax.Name = "lengthmax";
            this.lengthmax.Size = new System.Drawing.Size(14, 17);
            this.lengthmax.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 328);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.createfilebutton);
            this.Controls.Add(this.browsebox);
            this.Controls.Add(this.optionbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dummy File Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.optionbox.ResumeLayout(false);
            this.optionbox.PerformLayout();
            this.browsebox.ResumeLayout(false);
            this.browsebox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox optionbox;
		private System.Windows.Forms.RadioButton gbswitch;
		private System.Windows.Forms.RadioButton mbswitch;
		private System.Windows.Forms.RadioButton kbswitch;
		private System.Windows.Forms.TextBox filelocation;
		private System.Windows.Forms.Button browsebutton;
		private System.Windows.Forms.GroupBox browsebox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button createfilebutton;
		private System.Windows.Forms.CheckBox datarandom;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lengthcurrent;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel lengthmax;
		private System.Windows.Forms.ToolStripProgressBar progbar;
		private System.Windows.Forms.TextBox sizecombo;
		private System.Windows.Forms.RadioButton maxsizebutton;
	}
}

