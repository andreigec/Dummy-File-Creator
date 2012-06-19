using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using ANDREICSLIB;

namespace DummyFileCreator
{
	public partial class Form1 : Form
	{
		[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
		out ulong lpFreeBytesAvailable,
		out ulong lpTotalNumberOfBytes,
		out ulong lpTotalNumberOfFreeBytes);

        #region licensing

        private const string AppTitle = "Dummy File Creator";
        private const double AppVersion = 2.2;
        private const String HelpString = "";

        private const String UpdatePath = "https://github.com/EvilSeven/Dummy-File-Creator/zipball/master";
        private const String VersionPath = "https://raw.github.com/EvilSeven/Dummy-File-Creator/master/INFO/version.txt";
        private const String ChangelogPath = "https://raw.github.com/EvilSeven/Dummy-File-Creator/master/INFO/changelog.txt";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
        #endregion

		public Form1()
		{
			InitializeComponent();
		}

		String kb = "";
		String mb = "";
		bool abort = false;
		bool running = false;
		String startstr = "Create File";
		String endstr = "Abort File Creation";


		private void sizecombo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 126))
				e.Handled = true;
		}

		private void browsebutton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog FBD = new FolderBrowserDialog();
			FBD.Description = "Select a folder to save file to";
			FBD.SelectedPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
			FBD.RootFolder = Environment.SpecialFolder.MyComputer;

			DialogResult DR = FBD.ShowDialog();
			if (DR == DialogResult.Cancel)
				return;

			filelocation.Text = FBD.SelectedPath;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			filelocation.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
			running = !running;
			toggleControls();

			ToolTip TT = new ToolTip();
			TT.SetToolTip(datarandom, "Will write every byte manually-I/O will be a bottleneck for file creation");

			TT = new ToolTip();
			TT.SetToolTip(maxsizebutton, "Will get the max space free on the hdd, then create a file that is that size-1mb");

            Licensing.CreateLicense(this, HelpString, AppTitle, AppVersion, OtherText, VersionPath, UpdatePath, ChangelogPath, menuStrip1);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void initData(bool random)
		{
			kb = "";
			mb = "";
			Random r = new Random();
			char c = ' ';
			for (int a = 0; a < 1024; a++)
			{
				c = (char)(33 + r.Next() % 93);
				if (random == false)
					kb = kb + "a";
				else
					kb = kb + c;
			}

			for (int a = 0; a < 1024; a++)
			{
				mb = mb + kb;
			}
		}

		private void progress(ulong current, ulong max)
		{
			lengthcurrent.Text = current.ToString();
			progbar.Maximum = (int)max;
			progbar.Minimum = 0;
			progbar.Value = (int)current;
			Application.DoEvents();
		}

		private void toggleControls()
		{
			running = !running;
			if (running)
			{
				createfilebutton.Text = endstr;
				browsebox.Enabled = false;
				optionbox.Enabled = false;
			}
			else
			{
				createfilebutton.Text = startstr;
				browsebox.Enabled = true;
				optionbox.Enabled = true;
				lengthcurrent.Text = "X";
				lengthmax.Text = "Y";
				progbar.Value = 0;
			}

		}

		private void createfilebutton_Click(object sender, EventArgs e)
		{
			if (running)
			{
				abort = true;
				return;
			}

			if (string.IsNullOrEmpty(sizecombo.Text) && maxsizebutton.Checked==false)
			{
				MessageBox.Show("Please enter a valid size for the file");
				return;
			}

			if (System.IO.Directory.Exists(filelocation.Text) == false)
			{
				MessageBox.Show("Please enter a valid directory");
				return;
			}

			initData(datarandom.Checked);

			String hard = "dummyfile";
			int counter = 0;

			while (System.IO.File.Exists(hard + counter.ToString() + ".txt"))
			{
				counter++;
			}

			System.IO.Directory.SetCurrentDirectory(filelocation.Text);
			System.IO.FileStream FS = null;

			try
			{
				FS = System.IO.File.Create(hard + counter.ToString() + ".txt");
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occured creating the file:" + ex.ToString());
				return;
			}

			toggleControls();
			abort = false;

			int size = 0;
			ulong kbsize=0;

			if (maxsizebutton.Checked == false)
			{
				size = int.Parse(sizecombo.Text);
				 kbsize = (ulong)size;
				if (mbswitch.Checked || gbswitch.Checked)
					kbsize *= 1024;
				if (gbswitch.Checked)
					kbsize *= 1024;
			}
			else
			{
				try
				{
					String current = System.IO.Directory.GetCurrentDirectory();
					ulong by1, by2 = 0;
					ulong freebytes = 0;
					GetDiskFreeSpaceEx(current, out by1, out by2, out freebytes);
					kbsize = freebytes /= 1024;
					//leave 1 free mb 
					kbsize -= 1024;
				}
				catch
				{
					MessageBox.Show("Error creating max size file");
					return;
				}
			}
			lengthmax.Text = kbsize.ToString();

			try
			{
				if (datarandom.Checked)
				{
					System.IO.StreamWriter SW = new System.IO.StreamWriter(FS);

					ulong a = 0;
					while (a < kbsize)
					{
						if (kbsize >= 1024)
						{
							SW.Write(mb);
							a += 1024;
							progress(a, kbsize);
						}
						else
						{
							SW.Write(kb);
							a++;
							progress(a, kbsize);
						}
						if (abort)
						{
							toggleControls();
							SW.Close();
							FS.Close();
							return;
						}
					}
					SW.Close();
				}
				else
				{
					//in bytes
					FS.SetLength((long)kbsize * 1024);
				}
			}
				//most likely no room left
			catch (Exception e1)
			{
				MessageBox.Show("Error:" + e1.ToString());
			}

			FS.Close();
			toggleControls();


		}

		private void maxsizebutton_CheckedChanged(object sender, EventArgs e)
		{
			if (maxsizebutton.Checked)
			{
				sizecombo.Hide();
				sizecombo.Enabled = false;
			}
			else
			{
				sizecombo.Enabled = true;
				sizecombo.Show();
			}
		}
	}
}
