using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VaultMirror;

public class Form1 : Form, IStatusDisplay
{
	private enum Commands
	{
		UNKNOWN,
		FULL_MIRROR,
		PARTIAL_MIRROR
	}

	private GroupBox groupBox1;

	private Label label3;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label5;

	private TextBox m_usernameTextBox;

	private TextBox m_passwordTextBox;

	private TextBox m_serverTextBox;

	private TextBox m_vaultTextBox;

	private Button m_fullMirrorButton;

	private Button m_partialMirrorButton;

	private Button m_exitButton;

	private Container components;

	private DateTime m_lastSyncTime;

	private StatusBar m_statusBar;

	private MainMenu mainMenu1;

	private MenuItem menuItem1;

	private MenuItem menuItem2;

	private TextBox m_mirrorFolderTextBox;

	private static bool m_silentMode;

	private static StreamWriter m_logFileStream;

	public Form1()
	{
		InitializeComponent();
		LoadSettings();
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		groupBox1 = new GroupBox();
		m_mirrorFolderTextBox = new TextBox();
		m_vaultTextBox = new TextBox();
		m_serverTextBox = new TextBox();
		m_passwordTextBox = new TextBox();
		m_usernameTextBox = new TextBox();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		m_fullMirrorButton = new Button();
		m_partialMirrorButton = new Button();
		m_exitButton = new Button();
		m_statusBar = new StatusBar();
		mainMenu1 = new MainMenu();
		menuItem1 = new MenuItem();
		menuItem2 = new MenuItem();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).set_Anchor((AnchorStyles)13);
		((Control)groupBox1).get_Controls().Add((Control)(object)m_mirrorFolderTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)m_vaultTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)m_serverTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)m_passwordTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)m_usernameTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(8, 8));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(392, 144));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Settings");
		((Control)m_mirrorFolderTextBox).set_Anchor((AnchorStyles)13);
		((Control)m_mirrorFolderTextBox).set_Location(new Point(136, 112));
		((Control)m_mirrorFolderTextBox).set_Name("m_mirrorFolderTextBox");
		((Control)m_mirrorFolderTextBox).set_Size(new Size(248, 20));
		((Control)m_mirrorFolderTextBox).set_TabIndex(12);
		((Control)m_mirrorFolderTextBox).set_Text("");
		((Control)m_vaultTextBox).set_Anchor((AnchorStyles)13);
		((Control)m_vaultTextBox).set_Location(new Point(136, 88));
		((Control)m_vaultTextBox).set_Name("m_vaultTextBox");
		((Control)m_vaultTextBox).set_Size(new Size(248, 20));
		((Control)m_vaultTextBox).set_TabIndex(11);
		((Control)m_vaultTextBox).set_Text("");
		((Control)m_serverTextBox).set_Anchor((AnchorStyles)13);
		((Control)m_serverTextBox).set_Location(new Point(136, 64));
		((Control)m_serverTextBox).set_Name("m_serverTextBox");
		((Control)m_serverTextBox).set_Size(new Size(248, 20));
		((Control)m_serverTextBox).set_TabIndex(10);
		((Control)m_serverTextBox).set_Text("");
		((Control)m_passwordTextBox).set_Anchor((AnchorStyles)13);
		((Control)m_passwordTextBox).set_Location(new Point(136, 40));
		((Control)m_passwordTextBox).set_Name("m_passwordTextBox");
		m_passwordTextBox.set_PasswordChar('*');
		((Control)m_passwordTextBox).set_Size(new Size(248, 20));
		((Control)m_passwordTextBox).set_TabIndex(9);
		((Control)m_passwordTextBox).set_Text("");
		((Control)m_usernameTextBox).set_Anchor((AnchorStyles)13);
		((Control)m_usernameTextBox).set_Location(new Point(136, 16));
		((Control)m_usernameTextBox).set_Name("m_usernameTextBox");
		((Control)m_usernameTextBox).set_Size(new Size(248, 20));
		((Control)m_usernameTextBox).set_TabIndex(8);
		((Control)m_usernameTextBox).set_Text("");
		((Control)label5).set_Location(new Point(8, 120));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(112, 16));
		((Control)label5).set_TabIndex(7);
		((Control)label5).set_Text("Mirror Folder:");
		((Control)label4).set_Location(new Point(8, 96));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(112, 16));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Vault:");
		((Control)label3).set_Location(new Point(8, 72));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(112, 16));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Server:");
		((Control)label2).set_Location(new Point(8, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(112, 16));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Password:");
		((Control)label1).set_Location(new Point(8, 24));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(112, 16));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Username:");
		((Control)m_fullMirrorButton).set_Location(new Point(8, 160));
		((Control)m_fullMirrorButton).set_Name("m_fullMirrorButton");
		((Control)m_fullMirrorButton).set_Size(new Size(120, 24));
		((Control)m_fullMirrorButton).set_TabIndex(1);
		((Control)m_fullMirrorButton).set_Text("Run Full Mirror");
		((Control)m_fullMirrorButton).add_Click((EventHandler)m_fullMirrorButton_Click);
		((Control)m_partialMirrorButton).set_Location(new Point(144, 160));
		((Control)m_partialMirrorButton).set_Name("m_partialMirrorButton");
		((Control)m_partialMirrorButton).set_Size(new Size(120, 24));
		((Control)m_partialMirrorButton).set_TabIndex(2);
		((Control)m_partialMirrorButton).set_Text("Run Partial Mirror");
		((Control)m_partialMirrorButton).add_Click((EventHandler)m_partialMirrorButton_Click);
		m_exitButton.set_DialogResult((DialogResult)2);
		((Control)m_exitButton).set_Location(new Point(280, 160));
		((Control)m_exitButton).set_Name("m_exitButton");
		((Control)m_exitButton).set_Size(new Size(120, 24));
		((Control)m_exitButton).set_TabIndex(3);
		((Control)m_exitButton).set_Text("Exit");
		((Control)m_exitButton).add_Click((EventHandler)m_exitButton_Click);
		((Control)m_statusBar).set_Location(new Point(0, 212));
		((Control)m_statusBar).set_Name("m_statusBar");
		((Control)m_statusBar).set_Size(new Size(408, 16));
		((Control)m_statusBar).set_TabIndex(4);
		((Menu)mainMenu1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[1] { menuItem1 });
		menuItem1.set_Index(0);
		((Menu)menuItem1).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[1] { menuItem2 });
		menuItem1.set_Text("Help");
		menuItem2.set_Index(0);
		menuItem2.set_Text("About ...");
		menuItem2.add_Click((EventHandler)menuItem2_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(408, 228));
		((Control)this).get_Controls().Add((Control)(object)m_statusBar);
		((Control)this).get_Controls().Add((Control)(object)m_exitButton);
		((Control)this).get_Controls().Add((Control)(object)m_partialMirrorButton);
		((Control)this).get_Controls().Add((Control)(object)m_fullMirrorButton);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).set_MaximumSize(new Size(1416, 275));
		((Form)this).set_Menu(mainMenu1);
		((Control)this).set_MinimumSize(new Size(416, 275));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Vault Mirror");
		((Form)this).add_Closing((CancelEventHandler)Form1_Closing);
		((Control)groupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main()
	{
		bool createdNew = false;
		string name = Assembly.GetEntryAssembly()!.GetName().Name;
		using (new Mutex(initiallyOwned: true, name, out createdNew))
		{
			if (!createdNew)
			{
				Environment.Exit(0);
			}
			new Form1();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			Commands commands = Commands.UNKNOWN;
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			string text5 = null;
			string text6 = null;
			if (commandLineArgs != null && commandLineArgs.Length > 1)
			{
				m_silentMode = true;
				for (int i = 1; i < commandLineArgs.Length; i++)
				{
					if (string.Compare(commandLineArgs[i], "-PartialMirror", ignoreCase: true) == 0)
					{
						switch (commands)
						{
						case Commands.UNKNOWN:
							commands = Commands.PARTIAL_MIRROR;
							break;
						case Commands.FULL_MIRROR:
							PrintErrorAndExit("Cannot use both -FullMirror and -PartialMirror");
							break;
						}
					}
					else if (string.Compare(commandLineArgs[i], "-FullMirror", ignoreCase: true) == 0)
					{
						switch (commands)
						{
						case Commands.UNKNOWN:
							commands = Commands.FULL_MIRROR;
							break;
						case Commands.PARTIAL_MIRROR:
							PrintErrorAndExit("Cannot use both -FullMirror and -PartialMirror");
							break;
						}
					}
					else if (string.Compare(commandLineArgs[i], "-U", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no username specified");
						}
						text = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-P", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no password specified");
						}
						text2 = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-S", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no server specified");
						}
						text3 = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-V", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no vault specified");
						}
						text4 = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-L", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no logfile specified");
						}
						text5 = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-F", ignoreCase: true) == 0)
					{
						if (commandLineArgs.Length <= i + 1)
						{
							PrintErrorAndExit("no mirror folder specified");
						}
						text6 = commandLineArgs[++i];
					}
					else if (string.Compare(commandLineArgs[i], "-?", ignoreCase: true) == 0)
					{
						PrintUsageAndExit();
					}
					else
					{
						PrintUsageAndExit();
					}
				}
				try
				{
					if (text5 != null)
					{
						m_logFileStream = new StreamWriter(text5, append: true);
						m_logFileStream.WriteLine("----------------------");
						m_logFileStream.WriteLine(DateTime.Now.ToString());
					}
				}
				catch (Exception ex)
				{
					PrintErrorAndExit(ex.Message);
				}
				if (commands == Commands.UNKNOWN)
				{
					PrintErrorAndExit("Must use either -FullMirror and -PartialMirror");
				}
				Settings settings = Settings.LoadSettings();
				if (text3 == null)
				{
					if (text4 != null)
					{
						PrintErrorAndExit("The -V parameter must be used with -S");
					}
					Login onlyLogin = settings.GetOnlyLogin();
					if (onlyLogin == null)
					{
						PrintErrorAndExit("Use -S and -V to specify the server and vault name respectively.");
					}
					text3 = onlyLogin.Server;
					text4 = onlyLogin.Vault;
					if (text == null)
					{
						text = onlyLogin.Username;
					}
					if (text2 == null)
					{
						text2 = onlyLogin.Password;
					}
					if (text6 == null)
					{
						text6 = onlyLogin.MirrorFolder;
					}
				}
				else
				{
					if (text4 == null)
					{
						PrintErrorAndExit("The -S parameter must be used with -V");
					}
					if (text == null)
					{
						Login login = settings.GetLogin(text3, text4);
						if (login == null)
						{
							PrintErrorAndExit("Use -U and -P to specify the username and password respectively.");
						}
						text = login.Username;
						text2 = login.Password;
						if (text6 == null)
						{
							text6 = login.MirrorFolder;
						}
					}
					if (text2 == null)
					{
						text2 = "";
					}
				}
				if (text6 == null)
				{
					PrintErrorAndExit("Use -F to specify the mirror (output) folder.");
				}
				try
				{
					DateTime now = DateTime.Now;
					switch (commands)
					{
					case Commands.PARTIAL_MIRROR:
					{
						DateTime lastSyncTime = DateTime.MinValue;
						Login login2 = settings.GetLogin(text3, text4);
						if (login2 != null)
						{
							lastSyncTime = login2.LastSyncTime;
						}
						PartialMirrorCommand partialMirrorCommand = new PartialMirrorCommand(text, text2, text3, text4, text6, lastSyncTime);
						partialMirrorCommand.Execute();
						Print("Partial Mirror complete", "Success");
						break;
					}
					case Commands.FULL_MIRROR:
					{
						FullMirrorCommand fullMirrorCommand = new FullMirrorCommand(text, text2, text3, text4, text6);
						fullMirrorCommand.Execute();
						Print("Full Mirror complete", "Success");
						break;
					}
					default:
						Print("Error:  Invalid command", "Error");
						break;
					}
					settings.AddLogin(new Login(text, text2, text3, text4, text6, now));
					settings.SaveSettings();
				}
				catch (Exception ex2)
				{
					Print(ex2.ToString(), "Error");
				}
			}
			else
			{
				Application.Run((Form)(object)new Form1());
			}
			Cleanup();
		}
	}

	private static void Cleanup()
	{
		if (m_logFileStream != null)
		{
			m_logFileStream.Close();
		}
	}

	private static void PrintUsageAndExit()
	{
		Print("Usage:  VaultMirror [-PartialMirror | -FullMirror]", "Error");
		Print("\t [-U user] [-P pass] [-S server] [-V vault] [-L logfile]", "Error");
		Cleanup();
		Environment.Exit(0);
	}

	private static void PrintErrorAndExit(string msg)
	{
		Print("Error: " + msg, "Error");
		Cleanup();
		Environment.Exit(0);
	}

	private void LoadSettings()
	{
		Settings settings = Settings.LoadSettings();
		Login onlyLogin = settings.GetOnlyLogin();
		if (onlyLogin != null)
		{
			((Control)m_usernameTextBox).set_Text(onlyLogin.Username);
			((Control)m_passwordTextBox).set_Text(onlyLogin.Password);
			((Control)m_serverTextBox).set_Text(onlyLogin.Server);
			((Control)m_vaultTextBox).set_Text(onlyLogin.Vault);
			((Control)m_mirrorFolderTextBox).set_Text(onlyLogin.MirrorFolder);
			m_lastSyncTime = onlyLogin.LastSyncTime;
		}
	}

	private void SaveSettings()
	{
		Settings settings = Settings.LoadSettings();
		settings.AddLogin(new Login(((Control)m_usernameTextBox).get_Text(), ((Control)m_passwordTextBox).get_Text(), ((Control)m_serverTextBox).get_Text(), ((Control)m_vaultTextBox).get_Text(), ((Control)m_mirrorFolderTextBox).get_Text(), m_lastSyncTime));
		settings.SaveSettings();
	}

	private void Form1_Closing(object sender, CancelEventArgs e)
	{
		SaveSettings();
	}

	private void m_fullMirrorButton_Click(object sender, EventArgs e)
	{
		SetEnabled(enabled: false);
		SaveSettings();
		DateTime lastSyncTime = m_lastSyncTime;
		m_lastSyncTime = DateTime.Now;
		try
		{
			ServiceManager.LogOut();
			FullMirrorCommand fullMirrorCommand = new FullMirrorCommand(((Control)m_usernameTextBox).get_Text(), ((Control)m_passwordTextBox).get_Text(), ((Control)m_serverTextBox).get_Text(), ((Control)m_vaultTextBox).get_Text(), ((Control)m_mirrorFolderTextBox).get_Text());
			fullMirrorCommand.Display = this;
			fullMirrorCommand.Execute();
			Print("Full scan completed", "Operation Completed");
		}
		catch (Exception ex)
		{
			m_lastSyncTime = lastSyncTime;
			Print(ex.Message, "Error");
		}
		SetEnabled(enabled: true);
	}

	private void m_partialMirrorButton_Click(object sender, EventArgs e)
	{
		SetEnabled(enabled: false);
		SaveSettings();
		DateTime lastSyncTime = m_lastSyncTime;
		m_lastSyncTime = DateTime.Now;
		try
		{
			ServiceManager.LogOut();
			PartialMirrorCommand partialMirrorCommand = new PartialMirrorCommand(((Control)m_usernameTextBox).get_Text(), ((Control)m_passwordTextBox).get_Text(), ((Control)m_serverTextBox).get_Text(), ((Control)m_vaultTextBox).get_Text(), ((Control)m_mirrorFolderTextBox).get_Text(), lastSyncTime);
			partialMirrorCommand.Display = this;
			partialMirrorCommand.Execute();
			Print("Partial scan completed", "Operation Completed");
		}
		catch (Exception ex)
		{
			m_lastSyncTime = lastSyncTime;
			Print(ex.Message, "Error");
		}
		SetEnabled(enabled: true);
	}

	public void ChangeStatusMessage(string message)
	{
		((Control)m_statusBar).set_Text(message);
	}

	private void SetEnabled(bool enabled)
	{
		((Control)m_fullMirrorButton).set_Enabled(enabled);
		((Control)m_partialMirrorButton).set_Enabled(enabled);
	}

	private void m_exitButton_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)2);
		((Form)this).Close();
	}

	public static void Print(string msg, string title)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (m_silentMode)
		{
			Console.WriteLine(msg);
			if (m_logFileStream != null)
			{
				m_logFileStream.WriteLine(msg);
			}
		}
		else
		{
			MessageBox.Show(msg, title);
		}
	}

	private void menuItem2_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Aboutbox aboutbox = new Aboutbox();
		((Form)aboutbox).ShowDialog();
	}
}
