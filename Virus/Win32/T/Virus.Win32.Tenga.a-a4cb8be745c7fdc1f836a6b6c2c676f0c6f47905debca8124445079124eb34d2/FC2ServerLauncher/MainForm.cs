using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using FC2ServerLauncher.Properties;
using Microsoft.Win32;

namespace FC2ServerLauncher;

public class MainForm : Form
{
	private enum ECurrentSettings : byte
	{
		UNSET,
		DM,
		TDM,
		CTF,
		VIP,
		DMOnline,
		TDMOnline,
		CTFOnline,
		VIPOnline,
		DMRanked,
		TDMRanked,
		CTFRanked,
		VIPRanked
	}

	private delegate void ConsoleCallbackDelegate(string msg);

	private CommandHistory m_history = new CommandHistory();

	private Log m_log = new Log();

	private ECurrentSettings m_currentSetting;

	private ServerSettingsDM m_dmSettings = new ServerSettingsDM();

	private ServerSettingsTDM m_tdmSettings = new ServerSettingsTDM();

	private ServerSettingsCTF m_ctfSettings = new ServerSettingsCTF();

	private ServerSettingsVIP m_vipSettings = new ServerSettingsVIP();

	private ServerSettingsDMOnline m_dmSettingsOnline = new ServerSettingsDMOnline();

	private ServerSettingsTDMOnline m_tdmSettingsOnline = new ServerSettingsTDMOnline();

	private ServerSettingsCTFOnline m_ctfSettingsOnline = new ServerSettingsCTFOnline();

	private ServerSettingsVIPOnline m_vipSettingsOnline = new ServerSettingsVIPOnline();

	private ServerSettingsDMRanked m_dmSettingsRanked = new ServerSettingsDMRanked();

	private ServerSettingsTDMRanked m_tdmSettingsRanked = new ServerSettingsTDMRanked();

	private ServerSettingsCTFRanked m_ctfSettingsRanked = new ServerSettingsCTFRanked();

	private ServerSettingsVIPRanked m_vipSettingsRanked = new ServerSettingsVIPRanked();

	private string m_configFilePath = "";

	private Options m_options = new Options();

	private string m_optionFilePath = "";

	private static Dictionary<string, List<string>> m_playerChats = new Dictionary<string, List<string>>();

	private PlayerStats m_playerStats = new PlayerStats();

	private ListViewColumnSorter lvwColumnSorterPlayers = new ListViewColumnSorter();

	private ListViewColumnSorter lvwColumnSorterTeams = new ListViewColumnSorter();

	private string m_lastChat = "";

	private string m_lastAll = "";

	private static Dictionary<string, CMap> m_mapLocalized = new Dictionary<string, CMap>();

	private static MainForm s_instance;

	private bool m_updating;

	private IContainer components;

	private StatusStrip statusStripMain;

	private ToolStripStatusLabel toolStripStatusLabelMain;

	private MenuStrip menuStripMain;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem newConfigToolStripMenuItem;

	private ToolStripMenuItem loadConfigToolStripMenuItem;

	private ToolStripMenuItem saveConfigAsToolStripMenuItem;

	private ToolStripMenuItem saveConfigToolStripMenuItem;

	private ToolStripMenuItem exitToolStripMenuItem;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private DataGridViewTextBoxColumn ColumnTime;

	private DataGridViewTextBoxColumn ColumnScore;

	private DataGridViewTextBoxColumn ColumnPing;

	private DataGridViewTextBoxColumn ColumnPlayerName;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripStatusLabel toolStripStatusLabelLeft;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripSeparator toolStripSeparator2;

	private TabPage tabPageConfig;

	private PropertyGrid propertyGridConfig;

	private TextBox textBoxIp;

	private Button buttonStartServer;

	private Label labelIp;

	private Button buttonKillServer;

	private TabControl tabControlMain;

	private TabPage tabPageConsole;

	private Button buttonExecute;

	private TextBox textBoxExecute;

	private TextBox textBoxConsole;

	private TabPage tabPageOptions;

	private PropertyGrid propertyGridOptions;

	private ToolStripMenuItem recentConfigToolStripMenuItem;

	private Button buttonSave;

	private Button buttonLoad;

	private TabPage tabPagePlayers;

	private GroupBox groupBoxMatch;

	private GroupBox groupBoxPlayers;

	private TextBox textBoxTell;

	private Button buttonKick;

	private Button buttonTell;

	private Button buttonGoToLog;

	private Button buttonDeleteAll;

	private TextBox textBoxLogSize;

	private Label label5;

	private Button buttonSkipMap;

	private Button buttonShuffleTeams;

	private Button buttonExtendMatch;

	private Button buttonEndMatch;

	private Button buttonChangeVIP;

	private Button buttonRestartMatch;

	private ListView listViewTeams;

	private Button buttonSay;

	private TextBox textBoxSay;

	private PropertyGrid propertyGridPlayers;

	private ListViewImage listViewPlayers;

	private Label labelMatch;

	private TextBox textBoxChat;

	private Timer timerPlayersUpdate;

	private ColumnHeader columnHeaderTeamName;

	private ColumnHeader columnHeaderName;

	private ColumnHeader columnHeaderScore;

	private ColumnHeader columnHeaderTeamScore;

	private ColumnHeader columnHeaderTeam;

	private ColumnHeader columnHeaderVIP;

	private EmptyControl emptyControl;

	private ImageList imageListMulti;

	private Label label1;

	private Button buttonVote;

	private Button buttonVoteKick;

	private Label labelMap;

	private Label labelM;

	private Label labelState;

	private TextBox textBoxAll;

	private PictureBox pictureBoxTitle;

	private PictureBox pictureBoxFC2;

	public static Dictionary<string, CMap> Maps => m_mapLocalized;

	public static MainForm Instance => s_instance;

	public MainForm()
	{
		InitializeComponent();
		s_instance = this;
		((ListView)listViewPlayers).set_ListViewItemSorter((IComparer)lvwColumnSorterPlayers);
		listViewTeams.set_ListViewItemSorter((IComparer)lvwColumnSorterTeams);
		LoadMaps();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		((ToolStripItem)recentConfigToolStripMenuItem).set_Visible(false);
		LoadSettings();
		LoadOptions();
		propertyGridOptions.set_SelectedObject((object)m_options);
		SetDefaultSettings();
		LoadDefaultConfig();
		LoadLastConfig();
		SelectSettings();
		string hostName = Dns.GetHostName();
		IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
		IPAddress[] addressList = hostEntry.AddressList;
		IPAddress[] array = addressList;
		foreach (IPAddress iPAddress in array)
		{
			if (iPAddress.ToString().Contains("."))
			{
				((Control)textBoxIp).set_Text(iPAddress.ToString());
				break;
			}
		}
		UpdateLogSize();
		EnableUI(enable: true);
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		SaveSettings();
		SaveOptions();
		if (Game.Running)
		{
			DialogResult val = MessageBox.Show("Server will be stopped, are you sure?", "Far Cry® 2 Server Launcher", (MessageBoxButtons)1, (MessageBoxIcon)32);
			if ((int)val == 2)
			{
				((CancelEventArgs)(object)e).Cancel = true;
				return;
			}
			KillServer();
			Game.Shutdown();
		}
	}

	private void UpdateLogSize()
	{
		float num = 0f;
		DirectoryInfo directoryInfo = new DirectoryInfo(CUtils.GetFarCry2PersonalLogsFolder());
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			num += (float)fileInfo.Length / 1048576f;
		}
		((Control)textBoxLogSize).set_Text(num + " MB");
	}

	private void LoadMaps()
	{
		XmlDocument xmlDocument = new XmlDocument();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		xmlDocument.Load(executingAssembly.GetManifestResourceStream("FC2ServerLauncher.MultiplayerMaps.xml"));
		foreach (XmlNode childNode in xmlDocument.ChildNodes)
		{
			if (!(childNode.Name == "Maps"))
			{
				continue;
			}
			XmlNode xmlNode2 = childNode;
			foreach (XmlNode item in xmlNode2)
			{
				if (item.Name == "Map")
				{
					XmlNode mapNode = item;
					CMap cMap = new CMap();
					cMap.LoadHeader(mapNode);
					m_mapLocalized.Add(cMap.Localize, cMap);
				}
			}
		}
	}

	private RegistryKey GetRegistrySettings()
	{
		return Registry.CurrentUser.CreateSubKey("Software\\Ubisoft\\Far Cry 2\\ServerLauncher");
	}

	private int GetRegistryInt(RegistryKey key, string name, int defaultValue)
	{
		object value = key.GetValue(name);
		if (value is int)
		{
			return (int)value;
		}
		return defaultValue;
	}

	private void LoadSettings()
	{
		RegistryKey registrySettings = GetRegistrySettings();
		Rectangle rectangle = default(Rectangle);
		rectangle.X = GetRegistryInt(registrySettings, "MainFormX", ((Control)this).get_Bounds().X);
		rectangle.Y = GetRegistryInt(registrySettings, "MainFormY", ((Control)this).get_Bounds().Y);
		rectangle.Width = GetRegistryInt(registrySettings, "MainFormW", ((Control)this).get_Bounds().Width);
		rectangle.Height = GetRegistryInt(registrySettings, "MainFormH", ((Control)this).get_Bounds().Height);
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			if (val.get_Bounds().IntersectsWith(rectangle))
			{
				((Control)this).set_Bounds(rectangle);
				((Form)this).set_StartPosition((FormStartPosition)0);
				break;
			}
		}
		registrySettings.Close();
	}

	private void SaveSettings()
	{
		RegistryKey registrySettings = GetRegistrySettings();
		registrySettings.SetValue("MainFormX", ((Control)this).get_Bounds().X);
		registrySettings.SetValue("MainFormY", ((Control)this).get_Bounds().Y);
		registrySettings.SetValue("MainFormW", ((Control)this).get_Bounds().Width);
		registrySettings.SetValue("MainFormH", ((Control)this).get_Bounds().Height);
		registrySettings.Close();
	}

	private void LoadOptions()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		m_options.SetDefault(textBoxConsole);
		m_optionFilePath = CUtils.GetFarCry2PersonalServerFolder() + "\\server.xml";
		FileInfo fileInfo = new FileInfo(m_optionFilePath);
		if (!fileInfo.Exists)
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(m_optionFilePath);
		m_options.LoadFromXml(xmlDocument);
		((Control)textBoxConsole).set_BackColor(m_options.BackColor);
		((Control)textBoxExecute).set_BackColor(m_options.BackColor);
		((Control)textBoxConsole).set_ForeColor(m_options.ForeColor);
		((Control)textBoxExecute).set_ForeColor(m_options.ForeColor);
		((Control)textBoxConsole).set_Font(m_options.Font);
		((Control)textBoxExecute).set_Font(m_options.Font);
		if (m_options.RecentFiles.Count > 0)
		{
			((ToolStripItem)recentConfigToolStripMenuItem).set_Visible(true);
			foreach (string recentFile in m_options.RecentFiles)
			{
				((ToolStripDropDownItem)recentConfigToolStripMenuItem).get_DropDownItems().Add((ToolStripItem)new ToolStripMenuItem(recentFile, (Image)null, (EventHandler)recent_Click));
			}
		}
		m_configFilePath = m_options.LastFile;
	}

	private void SaveOptions()
	{
		XmlDocument xmldoc = new XmlDocument();
		m_options.SaveToXml(ref xmldoc);
		TextWriter textWriter = new StreamWriter(m_optionFilePath);
		XmlTextWriter xmlTextWriter = new XmlTextWriter(textWriter);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 4;
		xmldoc.WriteContentTo(xmlTextWriter);
		xmlTextWriter.Flush();
		textWriter.Close();
	}

	private void recent_Click(object sender, EventArgs e)
	{
		ToolStripMenuItem val = (ToolStripMenuItem)((sender is ToolStripMenuItem) ? sender : null);
		if (val != null)
		{
			m_configFilePath = ((ToolStripItem)val).get_Text();
			LoadConfig(rememberLastConfig: true);
		}
	}

	private void NewConfig()
	{
		m_configFilePath = "";
		SetDefaultSettings();
		SelectSettings();
	}

	private void LoadConfigAsk(bool rememberLastConfig)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(CUtils.GetFarCry2PersonalServerFolder());
		((FileDialog)val).set_Filter("Far Cry® 2 Server Settings (*.XML)|*.xml|All Files (*.*)|*.*");
		((FileDialog)val).set_FilterIndex(1);
		((FileDialog)val).set_RestoreDirectory(true);
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			m_configFilePath = ((FileDialog)val).get_FileName();
			LoadConfig(rememberLastConfig);
		}
	}

	private void LoadConfig(bool rememberLastConfig)
	{
		if (m_configFilePath.Length == 0)
		{
			LoadConfigAsk(rememberLastConfig);
			return;
		}
		FileInfo fileInfo = new FileInfo(m_configFilePath);
		if (fileInfo.Exists)
		{
			XmlDocument xmlDocument = new XmlDocument();
			TextReader textReader = new StreamReader(m_configFilePath);
			XmlTextReader reader = new XmlTextReader(textReader);
			xmlDocument.Load(reader);
			textReader.Close();
			LoadSettingsFromXml(xmlDocument);
			SelectSettings();
			if (rememberLastConfig)
			{
				SaveLastConfig();
			}
		}
		else
		{
			m_configFilePath = "";
			LoadConfigAsk(rememberLastConfig);
		}
	}

	private void LoadDefaultConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		xmlDocument.Load(executingAssembly.GetManifestResourceStream("FC2ServerLauncher.DefaultDedicatedServerConfig.xml"));
		LoadSettingsFromXml(xmlDocument);
		SelectSettings();
	}

	private void LoadLastConfig()
	{
		if (m_configFilePath != "")
		{
			LoadConfig(rememberLastConfig: true);
		}
	}

	private void SaveConfigAsk()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(CUtils.GetFarCry2PersonalServerFolder());
		((FileDialog)val).set_Filter("Far Cry® 2 Server Settings (*.XML)|*.xml|All Files (*.*)|*.*");
		((FileDialog)val).set_FilterIndex(1);
		((FileDialog)val).set_RestoreDirectory(true);
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			m_configFilePath = ((FileDialog)val).get_FileName();
			SaveConfig();
		}
	}

	private void SaveConfig()
	{
		if (m_configFilePath.Length == 0)
		{
			SaveConfigAsk();
			return;
		}
		XmlDocument xmldoc = new XmlDocument();
		SaveSettingsToXml(ref xmldoc);
		TextWriter textWriter = new StreamWriter(m_configFilePath);
		XmlTextWriter xmlTextWriter = new XmlTextWriter(textWriter);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 4;
		xmldoc.WriteContentTo(xmlTextWriter);
		xmlTextWriter.Flush();
		textWriter.Close();
		SaveLastConfig();
	}

	private void SaveLastConfig()
	{
		if (m_configFilePath.Length != 0)
		{
			m_options.LastFile = m_configFilePath;
			m_options.AddRecent(m_configFilePath);
			SaveOptions();
		}
	}

	private void buttonSave_Click(object sender, EventArgs e)
	{
		SaveConfig();
	}

	private void buttonLoad_Click(object sender, EventArgs e)
	{
		LoadConfigAsk(rememberLastConfig: true);
	}

	private void newConfigToolStripMenuItem_Click(object sender, EventArgs e)
	{
		NewConfig();
	}

	private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
	{
		LoadConfigAsk(rememberLastConfig: true);
	}

	private void saveConfigAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveConfigAsk();
	}

	private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveConfig();
	}

	private void exitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void buttonStartServer_Click(object sender, EventArgs e)
	{
		StartServer();
	}

	private void buttonKillServer_Click(object sender, EventArgs e)
	{
		KillServer();
	}

	private static string GetExecName()
	{
		return "farcry2.exe";
	}

	private string GetParamsString()
	{
		string text = "-silentmode -norender -host ";
		switch (GetSettingsGameMode())
		{
		case EGameMode.TeamDeathmatch:
			text += " -team";
			break;
		case EGameMode.CaptureTheDiamond:
			text += " -ctf";
			break;
		case EGameMode.Uprising:
			text += " -vip";
			break;
		}
		text += " -login ";
		text += "\"";
		text += GetSettingsName();
		text += "\"";
		if (IsOnlineSettings())
		{
			text += " -online";
			if (IsRankedSettingsSafe())
			{
				text += " -ranked";
			}
		}
		else
		{
			text += " -lan";
		}
		return text + " -dedicated Server\\server.cfg";
	}

	private void StartServer()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		SaveSettings();
		SaveOptions();
		WriteSettingsConsoleBatchFile();
		Cursor.set_Current(Cursors.get_WaitCursor());
		((ToolStripItem)toolStripStatusLabelLeft).set_Text("Loading...");
		if (Game.Start((Form)(object)this, (Control)(object)emptyControl, GetParamsString(), ConsoleCallback, MessageCallback))
		{
			EnableUI(enable: false);
			tabControlMain.SelectTab(tabPageConsole);
			((Control)textBoxConsole).set_Text("");
			if (m_options.File)
			{
				m_log.Init(m_options.Time);
			}
			if (m_options.PlayersStats)
			{
				timerPlayersUpdate.set_Enabled(true);
			}
			((Control)textBoxAll).set_Text("");
			switch (GetSettingsGameMode())
			{
			case EGameMode.Deathmatch:
				((Control)buttonChangeVIP).set_Enabled(false);
				((Control)buttonShuffleTeams).set_Enabled(false);
				break;
			case EGameMode.TeamDeathmatch:
				((Control)buttonChangeVIP).set_Enabled(false);
				break;
			case EGameMode.CaptureTheDiamond:
				((Control)buttonChangeVIP).set_Enabled(false);
				break;
			}
			Cursor.set_Current(Cursors.get_Default());
			((ToolStripItem)toolStripStatusLabelLeft).set_Text("Running");
			Game.Run();
		}
		else
		{
			MessageBox.Show("An error occurs during the initialisation of Dunia", "Far Cry® 2 Server Launcher", (MessageBoxButtons)0, (MessageBoxIcon)16);
			Cursor.set_Current(Cursors.get_Default());
			((ToolStripItem)toolStripStatusLabelLeft).set_Text("Ready");
		}
	}

	private void KillServer()
	{
		string paramsString = GetParamsString();
		paramsString = paramsString.Replace("-host", "-wait");
		Game.Stop(paramsString);
		((ToolStripItem)toolStripStatusLabelLeft).set_Text("Ready");
		EnableUI(enable: true);
		timerPlayersUpdate.set_Enabled(false);
		((ListView)listViewPlayers).get_Items().Clear();
		listViewTeams.get_Items().Clear();
		((Control)textBoxChat).set_Text("");
		m_playerChats.Clear();
		propertyGridPlayers.set_SelectedObject((object)null);
		UpdateLogSize();
	}

	private void EnableUI(bool enable)
	{
		((Control)propertyGridConfig).set_Enabled(enable);
		((Control)buttonStartServer).set_Enabled(enable);
		((Control)buttonKillServer).set_Enabled(!enable);
		((Control)buttonSave).set_Enabled(enable);
		((Control)buttonLoad).set_Enabled(enable);
		((Control)textBoxExecute).set_Enabled(!enable);
		((Control)buttonExecute).set_Enabled(!enable);
		((Control)buttonChangeVIP).set_Enabled(!enable);
		((Control)buttonExtendMatch).set_Enabled(!enable);
		((Control)buttonEndMatch).set_Enabled(!enable);
		((Control)buttonShuffleTeams).set_Enabled(!enable);
		((Control)buttonRestartMatch).set_Enabled(!enable);
		((Control)buttonVote).set_Enabled(!enable);
		((Control)buttonSkipMap).set_Enabled(!enable);
		((Control)textBoxAll).set_Enabled(!enable);
		((Control)buttonSay).set_Enabled(!enable);
		((Control)textBoxSay).set_Enabled(!enable);
		((Control)listViewPlayers).set_Enabled(!enable);
		((Control)listViewTeams).set_Enabled(!enable);
		((Control)buttonTell).set_Enabled(false);
		((Control)textBoxTell).set_Enabled(false);
		((Control)textBoxChat).set_Enabled(false);
		((Control)buttonKick).set_Enabled(false);
		((Control)buttonVoteKick).set_Enabled(false);
		((Control)propertyGridOptions).set_Enabled(enable);
		((Control)buttonGoToLog).set_Enabled(enable);
		((Control)buttonDeleteAll).set_Enabled(enable);
	}

	private void ConsoleCallbackMainThread(string output)
	{
		if (m_options.File)
		{
			m_log.WriteLine(output);
		}
		((TextBoxBase)textBoxConsole).AppendText(output);
		((TextBoxBase)textBoxConsole).AppendText(Environment.NewLine);
		if (((Control)textBoxConsole).get_Text().Length > ((TextBoxBase)textBoxConsole).get_MaxLength())
		{
			((Control)textBoxConsole).set_Text(((Control)textBoxConsole).get_Text().Remove(0, ((Control)textBoxConsole).get_Text().Length - ((TextBoxBase)textBoxConsole).get_MaxLength() - 3));
			((Control)textBoxConsole).set_Text(((Control)textBoxConsole).get_Text().Insert(0, "..."));
		}
		((TextBoxBase)textBoxConsole).set_SelectionStart(((Control)textBoxConsole).get_Text().Length);
		((TextBoxBase)textBoxConsole).ScrollToCaret();
	}

	private void ConsoleCallback(IntPtr msg)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		MethodInvoker val = null;
		string output = Marshal.PtrToStringUni(msg);
		if (((Control)textBoxConsole).get_InvokeRequired())
		{
			TextBox obj = textBoxConsole;
			if (val == null)
			{
				val = (MethodInvoker)delegate
				{
					ConsoleCallbackMainThread(output);
				};
			}
			((Control)obj).BeginInvoke((Delegate)(object)val);
		}
		else
		{
			ConsoleCallbackMainThread(output);
		}
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		AboutForm aboutForm = new AboutForm();
		((Form)aboutForm).ShowDialog((IWin32Window)(object)this);
		((Component)(object)aboutForm).Dispose();
	}

	private void buttonExecute_Click(object sender, EventArgs e)
	{
		m_history.Add(((Control)textBoxExecute).get_Text());
		Game.ExecuteCommand(((Control)textBoxExecute).get_Text());
		((Control)textBoxExecute).set_Text("");
	}

	private string ShowFormFind(TextBox box)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		FormFind formFind = new FormFind();
		formFind.ToFind = ((TextBoxBase)box).get_SelectedText();
		((Form)formFind).set_Location(Cursor.get_Position());
		((Form)formFind).set_StartPosition((FormStartPosition)0);
		((Form)formFind).ShowDialog((IWin32Window)(object)box);
		return formFind.ToFind;
	}

	private bool FindText(string find, TextBox box)
	{
		int length = find.Length;
		if (length > 0)
		{
			int num = ((TextBoxBase)box).get_SelectionStart() + length;
			if (num > ((Control)box).get_Text().Length)
			{
				num = 0;
			}
			int num2 = ((Control)box).get_Text().IndexOf(find, num);
			if (num2 != -1)
			{
				((TextBoxBase)box).Select(num2, length);
				((TextBoxBase)box).ScrollToCaret();
				return true;
			}
			if (num != 0)
			{
				num2 = ((Control)box).get_Text().IndexOf(find, 0);
				if (num2 != -1)
				{
					((TextBoxBase)box).Select(num2, length);
					((TextBoxBase)box).ScrollToCaret();
					return true;
				}
			}
		}
		return false;
	}

	private void textBoxExecute_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 40)
		{
			if (m_history.DoesNextCommandExist())
			{
				((Control)textBoxExecute).set_Text(m_history.GetNextCommand());
				((TextBoxBase)textBoxExecute).Select(((Control)textBoxExecute).get_Text().Length, 0);
				e.set_SuppressKeyPress(true);
			}
			e.set_Handled(true);
		}
		else if ((int)e.get_KeyCode() == 38)
		{
			if (m_history.DoesPreviousCommandExist())
			{
				((Control)textBoxExecute).set_Text(m_history.GetPreviousCommand());
				((TextBoxBase)textBoxExecute).Select(((Control)textBoxExecute).get_Text().Length, 0);
				e.set_SuppressKeyPress(true);
			}
			e.set_Handled(true);
		}
		else if ((int)e.get_KeyCode() == 9)
		{
			((Control)textBoxExecute).set_Text(Game.AutoCompleteCommand(((Control)textBoxExecute).get_Text(), e.get_Shift()));
			((TextBoxBase)textBoxExecute).Select(((Control)textBoxExecute).get_Text().Length, 0);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
		else if ((int)e.get_KeyCode() == 13)
		{
			buttonExecute_Click(null, null);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
		else if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			((TextBoxBase)textBoxExecute).Select(0, ((Control)textBoxExecute).get_Text().Length);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void textBoxConsole_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			((TextBoxBase)textBoxConsole).Select(0, ((Control)textBoxConsole).get_Text().Length);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
		else if (e.get_Control() && (int)e.get_KeyCode() == 70)
		{
			m_history.LastFind = ShowFormFind(textBoxConsole);
			if (FindText(m_history.LastFind, textBoxConsole))
			{
				e.set_Handled(true);
				e.set_SuppressKeyPress(true);
			}
		}
		else if (!string.IsNullOrEmpty(m_history.LastFind) && (int)e.get_KeyCode() == 114 && FindText(m_history.LastFind, textBoxConsole))
		{
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void propertyGridOptions_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
	{
		if (e.get_ChangedItem().get_Label() == "BackColor")
		{
			((Control)textBoxConsole).set_BackColor(m_options.BackColor);
			((Control)textBoxExecute).set_BackColor(m_options.BackColor);
		}
		else if (e.get_ChangedItem().get_Label() == "ForeColor")
		{
			((Control)textBoxConsole).set_ForeColor(m_options.ForeColor);
			((Control)textBoxExecute).set_ForeColor(m_options.ForeColor);
		}
		else if (e.get_ChangedItem().get_Label() == "Font")
		{
			((Control)textBoxConsole).set_Font(m_options.Font);
			((Control)textBoxExecute).set_Font(m_options.Font);
		}
	}

	private void buttonGoToLog_Click(object sender, EventArgs e)
	{
		Process.Start("explorer.exe", CUtils.GetFarCry2PersonalLogsFolder());
	}

	private void buttonDeleteAll_Click(object sender, EventArgs e)
	{
		Cursor.set_Current(Cursors.get_WaitCursor());
		DirectoryInfo directoryInfo = new DirectoryInfo(CUtils.GetFarCry2PersonalLogsFolder());
		FileInfo[] files = directoryInfo.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			fileInfo.Delete();
		}
		Cursor.set_Current(Cursors.get_Default());
	}

	private void buttonChangeVIP_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ContextMenu val = new ContextMenu();
		((Menu)val).get_MenuItems().Add("APR", (EventHandler)captain_PopUp);
		((Menu)val).get_MenuItems().Add("UFLL", (EventHandler)captain_PopUp);
		val.Show((Control)(object)this, ((Control)this).PointToClient(Cursor.get_Position()));
	}

	private void captain_PopUp(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		MenuItem val = (MenuItem)sender;
		string text = val.get_Text();
		if (text == "APR")
		{
			Game.ExecuteCommand("net_ChangeCaptain APR");
		}
		else if (text == "UFLL")
		{
			Game.ExecuteCommand("net_ChangeCaptain UFLL");
		}
		((Control)this).Invalidate();
	}

	private void buttonEndMatch_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("net_EndMatch");
	}

	private void buttonExtendMatch_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("net_ExtendMatch");
	}

	private void buttonRestartMatch_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("net_RestartMatch");
	}

	private void buttonShuffleTeams_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("net_ShuffleTeams");
	}

	private void buttonSkipMap_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("net_SkipMap");
	}

	private void buttonVote_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		ContextMenu val = new ContextMenu();
		if (vote_Enabled("Change Captain"))
		{
			MenuItem val2 = new MenuItem("Change Captain");
			((Menu)val).get_MenuItems().Add(val2);
			((Menu)val2).get_MenuItems().Add("APR", (EventHandler)vote_PopUp);
			((Menu)val2).get_MenuItems().Add("UFLL", (EventHandler)vote_PopUp);
		}
		if (vote_Enabled("Shuffle Teams"))
		{
			((Menu)val).get_MenuItems().Add("Shuffle Teams", (EventHandler)vote_PopUp);
		}
		if (vote_Enabled("Skip Map"))
		{
			((Menu)val).get_MenuItems().Add("Skip Map", (EventHandler)vote_PopUp);
		}
		if (vote_Enabled("End Match"))
		{
			((Menu)val).get_MenuItems().Add("End Match", (EventHandler)vote_PopUp);
		}
		if (vote_Enabled("Extend Match"))
		{
			((Menu)val).get_MenuItems().Add("Extend Match", (EventHandler)vote_PopUp);
		}
		if (vote_Enabled("Restart Match"))
		{
			((Menu)val).get_MenuItems().Add("Restart Match", (EventHandler)vote_PopUp);
		}
		if (((Menu)val).get_MenuItems().get_Count() == 0)
		{
			((Menu)val).get_MenuItems().Add("Cannot call vote at the moment");
		}
		val.Show((Control)(object)this, ((Control)this).PointToClient(Cursor.get_Position()));
	}

	private bool vote_Enabled(string item)
	{
		return item switch
		{
			"Change Captain" => Game.CanCallVote("call_vote_change_captain"), 
			"Shuffle Teams" => Game.CanCallVote("call_vote_shuffle_teams"), 
			"Skip Map" => Game.CanCallVote("call_vote_skip_map"), 
			"End Match" => Game.CanCallVote("call_vote_end_match"), 
			"Extend Match" => Game.CanCallVote("call_vote_extend_match"), 
			"Restart Match" => Game.CanCallVote("call_vote_restart_match"), 
			_ => false, 
		};
	}

	private void vote_PopUp(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		MenuItem val = (MenuItem)sender;
		switch (val.get_Text())
		{
		case "APR":
			Game.ExecuteCommand("call_vote_change_captain APR");
			break;
		case "UFLL":
			Game.ExecuteCommand("call_vote_change_captain UFLL");
			break;
		case "Shuffle Teams":
			Game.ExecuteCommand("call_vote_shuffle_teams");
			break;
		case "Skip Map":
			Game.ExecuteCommand("call_vote_skip_map");
			break;
		case "End Match":
			Game.ExecuteCommand("call_vote_end_match");
			break;
		case "Extend Match":
			Game.ExecuteCommand("call_vote_extend_match");
			break;
		case "Restart Match":
			Game.ExecuteCommand("call_vote_restart_match");
			break;
		}
		((Control)this).Invalidate();
	}

	private void MessageCallback(IntPtr dude, IntPtr msg)
	{
		string text = Marshal.PtrToStringUni(dude);
		string text2 = Marshal.PtrToStringUni(msg);
		if (!m_playerChats.TryGetValue(text, out var _))
		{
			m_playerChats.Add(text, new List<string>());
		}
		m_playerChats[text].Add(text2);
		if (((Control)textBoxAll).get_Text().Length > 0)
		{
			((TextBoxBase)textBoxAll).AppendText(Environment.NewLine);
		}
		string text3 = text + ": " + text2;
		((TextBoxBase)textBoxAll).AppendText(text3);
		if (((Control)textBoxAll).get_Text().Length > ((TextBoxBase)textBoxAll).get_MaxLength())
		{
			((Control)textBoxAll).set_Text(((Control)textBoxAll).get_Text().Remove(0, ((Control)textBoxAll).get_Text().Length - ((TextBoxBase)textBoxAll).get_MaxLength() - 3));
			((Control)textBoxAll).set_Text(((Control)textBoxAll).get_Text().Insert(0, "..."));
		}
		((TextBoxBase)textBoxAll).set_SelectionStart(((Control)textBoxAll).get_Text().Length);
		((TextBoxBase)textBoxAll).ScrollToCaret();
	}

	private void UpdatePlayersUI(GameStats stats)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		((Control)labelMatch).set_Text(stats.m_mode);
		((Control)labelMap).set_Text(stats.m_map);
		foreach (CMap value in m_mapLocalized.Values)
		{
			if (value.Name == stats.m_map)
			{
				((Control)labelMap).set_Text(value.Localize);
				break;
			}
		}
		ListViewItem val = null;
		foreach (PlayerScore player in stats.m_players)
		{
			bool flag = true;
			foreach (ListViewItem item in ((ListView)listViewPlayers).get_Items())
			{
				ListViewItem val2 = item;
				if (player.m_name.CompareTo(val2.get_Text()) == 0)
				{
					val = val2;
					flag = false;
					break;
				}
			}
			if (flag)
			{
				val = new ListViewItem(player.m_name);
				val.set_Name(player.m_name);
				val.get_SubItems().Add(player.m_score.ToString());
				val.get_SubItems().Add(player.m_team);
				if (player.m_isVIP)
				{
					val.get_SubItems().Add("Captain");
					if (player.m_team.Contains("APR"))
					{
						val.set_ImageIndex(4);
					}
					else if (player.m_team.Contains("UFLL"))
					{
						val.set_ImageIndex(5);
					}
					else
					{
						val.set_ImageIndex(3);
					}
				}
				else
				{
					val.get_SubItems().Add("");
					if (player.m_team.Contains("APR"))
					{
						val.set_ImageIndex(1);
					}
					else if (player.m_team.Contains("UFLL"))
					{
						val.set_ImageIndex(2);
					}
					else
					{
						val.set_ImageIndex(0);
					}
				}
				((ListView)listViewPlayers).get_Items().Add(val);
				continue;
			}
			val.set_Name(player.m_name);
			val.get_SubItems().get_Item(1).set_Text(player.m_score.ToString());
			val.get_SubItems().get_Item(2).set_Text(player.m_team);
			if (player.m_isVIP)
			{
				val.get_SubItems().get_Item(3).set_Text("Captain");
				if (player.m_team.Contains("APR"))
				{
					val.set_ImageIndex(4);
				}
				else if (player.m_team.Contains("UFLL"))
				{
					val.set_ImageIndex(5);
				}
				else
				{
					val.set_ImageIndex(3);
				}
			}
			else
			{
				val.get_SubItems().get_Item(3).set_Text("");
				if (player.m_team.Contains("APR"))
				{
					val.set_ImageIndex(1);
				}
				else if (player.m_team.Contains("UFLL"))
				{
					val.set_ImageIndex(2);
				}
				else
				{
					val.set_ImageIndex(0);
				}
			}
		}
		List<string> list = new List<string>();
		foreach (ListViewItem item2 in ((ListView)listViewPlayers).get_Items())
		{
			ListViewItem val3 = item2;
			bool flag2 = false;
			foreach (PlayerScore player2 in stats.m_players)
			{
				if (player2.m_name.CompareTo(val3.get_Text()) == 0)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				list.Add(val3.get_Text());
			}
		}
		foreach (string item3 in list)
		{
			((ListView)listViewPlayers).get_Items().RemoveByKey(item3);
		}
		foreach (TeamScore team in stats.m_teams)
		{
			bool flag3 = true;
			foreach (ListViewItem item4 in listViewTeams.get_Items())
			{
				ListViewItem val4 = item4;
				if (team.m_name.CompareTo(val4.get_Text()) == 0)
				{
					val = val4;
					flag3 = false;
					break;
				}
			}
			if (flag3)
			{
				val = new ListViewItem(team.m_name);
				val.set_Name(team.m_name);
				if (team.m_name.Contains("APR"))
				{
					val.set_ImageIndex(1);
				}
				else
				{
					val.set_ImageIndex(2);
				}
				val.get_SubItems().Add(team.m_score.ToString());
				listViewTeams.get_Items().Add(val);
			}
			else
			{
				val.set_Name(team.m_name);
				if (team.m_name.Contains("APR"))
				{
					val.set_ImageIndex(1);
				}
				else
				{
					val.set_ImageIndex(2);
				}
				val.get_SubItems().get_Item(1).set_Text(team.m_score.ToString());
			}
		}
		list = new List<string>();
		foreach (ListViewItem item5 in listViewTeams.get_Items())
		{
			ListViewItem val5 = item5;
			bool flag4 = false;
			foreach (TeamScore team2 in stats.m_teams)
			{
				if (team2.m_name.CompareTo(val5.get_Text()) == 0)
				{
					flag4 = true;
					break;
				}
			}
			if (!flag4)
			{
				list.Add(val5.get_Text());
			}
		}
		foreach (string item6 in list)
		{
			listViewTeams.get_Items().RemoveByKey(item6);
		}
	}

	private void timerPlayersUpdate_Tick(object sender, EventArgs e)
	{
		if (!m_updating)
		{
			GameStats gameStats = new GameStats();
			m_updating = true;
			IntPtr match = Game.FCS_Server_CreateMatchStats();
			for (int i = 0; i < Game.FCS_Server_GetMatchStats_PlayersCount(match); i++)
			{
				PlayerScore playerScore = new PlayerScore();
				playerScore.m_name = Marshal.PtrToStringUni(Game.FCS_Server_GetMatchStats_PlayerName(match, i));
				playerScore.m_score = Game.FCS_Server_GetMatchStats_PlayerScore(match, i);
				playerScore.m_team = Marshal.PtrToStringUni(Game.FCS_Server_GetMatchStats_PlayerTeam(match, i));
				playerScore.m_isVIP = Game.FCS_Server_GetMatchStats_PlayerVIP(match, i);
				gameStats.m_players.Add(playerScore);
			}
			for (int j = 0; j < Game.FCS_Server_GetMatchStats_TeamsCount(match); j++)
			{
				TeamScore teamScore = new TeamScore();
				teamScore.m_name = Marshal.PtrToStringUni(Game.FCS_Server_GetMatchStats_TeamName(match, j));
				teamScore.m_score = Game.FCS_Server_GetMatchStats_TeamScore(match, j);
				gameStats.m_teams.Add(teamScore);
			}
			gameStats.m_map = Marshal.PtrToStringUni(Game.FCS_Server_GetMatchStats_Map(match));
			gameStats.m_mode = Marshal.PtrToStringUni(Game.FCS_Server_GetMatchStats_Mode(match));
			Game.FCS_Server_DeleteMatchStats(match);
			UpdatePlayersUI(gameStats);
			m_updating = false;
		}
	}

	private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool flag = ((ListView)listViewPlayers).get_SelectedItems().get_Count() == 1;
		((Control)buttonTell).set_Enabled(flag);
		((Control)textBoxTell).set_Enabled(flag);
		((Control)textBoxChat).set_Enabled(flag);
		((Control)buttonKick).set_Enabled(flag);
		string text = (flag ? ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_SubItems()
			.get_Item(2)
			.get_Text() : "");
		if (string.IsNullOrEmpty(text))
		{
			bool flag2 = flag && Game.CanCallVote("call_vote_kick " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text());
			((Control)buttonVoteKick).set_Enabled(flag && flag2);
		}
		else
		{
			bool flag3 = flag && Game.CanCallVote("call_vote_kick " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text() + " " + text);
			((Control)buttonVoteKick).set_Enabled(flag && flag3);
		}
		if (!flag)
		{
			return;
		}
		IntPtr player = Game.FCS_Server_CreatePlayerStats(((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text());
		m_playerStats.Name = ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text();
		m_playerStats.Kills = Game.FCS_Server_GetPlayerStats_Kills(player);
		m_playerStats.Deaths = Game.FCS_Server_GetPlayerStats_Deaths(player);
		m_playerStats.Losses = Game.FCS_Server_GetPlayerStats_Losses(player);
		m_playerStats.Rank = Game.FCS_Server_GetPlayerStats_Rank(player);
		m_playerStats.Revives = Game.FCS_Server_GetPlayerStats_Revives(player);
		m_playerStats.Suicides = Game.FCS_Server_GetPlayerStats_Suicides(player);
		m_playerStats.TeamKills = Game.FCS_Server_GetPlayerStats_TeamKills(player);
		m_playerStats.Wins = Game.FCS_Server_GetPlayerStats_Wins(player);
		m_playerStats.XP = Game.FCS_Server_GetPlayerStats_Xp(player);
		Game.FCS_Server_DeletePlayerStats(player);
		propertyGridPlayers.set_SelectedObject((object)m_playerStats);
		((Control)textBoxChat).set_Text("");
		if (!m_playerChats.TryGetValue(m_playerStats.Name, out var value))
		{
			return;
		}
		foreach (string item in value)
		{
			TextBox obj = textBoxChat;
			((Control)obj).set_Text(((Control)obj).get_Text() + item);
			TextBox obj2 = textBoxChat;
			((Control)obj2).set_Text(((Control)obj2).get_Text() + Environment.NewLine);
		}
	}

	private void textBoxTell_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			buttonTell_Click(null, null);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void buttonTell_Click(object sender, EventArgs e)
	{
		if (((ListView)listViewPlayers).get_SelectedItems().get_Count() == 1)
		{
			Game.ExecuteCommand("tell " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text() + " " + ((Control)textBoxTell).get_Text());
			((Control)textBoxTell).set_Text("");
		}
	}

	private void buttonKick_Click(object sender, EventArgs e)
	{
		if (((ListView)listViewPlayers).get_SelectedItems().get_Count() == 1)
		{
			Game.ExecuteCommand("net_KickClient " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text());
		}
	}

	private void buttonVoteKick_Click(object sender, EventArgs e)
	{
		if (((ListView)listViewPlayers).get_SelectedItems().get_Count() == 1)
		{
			string text = ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text();
			if (string.IsNullOrEmpty(text))
			{
				Game.ExecuteCommand("call_vote_kick " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text());
			}
			else
			{
				Game.ExecuteCommand("call_vote_kick " + ((ListView)listViewPlayers).get_SelectedItems().get_Item(0).get_Text() + " " + text);
			}
		}
	}

	private void textBoxSay_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			buttonSay_Click(null, null);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void buttonSay_Click(object sender, EventArgs e)
	{
		Game.ExecuteCommand("say " + ((Control)textBoxSay).get_Text());
		((Control)textBoxSay).set_Text("");
	}

	private void listViewPlayers_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (e.get_Column() == lvwColumnSorterPlayers.SortColumn)
		{
			if ((int)lvwColumnSorterPlayers.Order == 1)
			{
				lvwColumnSorterPlayers.Order = (SortOrder)2;
			}
			else
			{
				lvwColumnSorterPlayers.Order = (SortOrder)1;
			}
		}
		else
		{
			lvwColumnSorterPlayers.SortColumn = e.get_Column();
			lvwColumnSorterPlayers.Order = (SortOrder)1;
		}
		((ListView)listViewPlayers).Sort();
	}

	private void listViewTeams_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		if (e.get_Column() == lvwColumnSorterTeams.SortColumn)
		{
			if ((int)lvwColumnSorterTeams.Order == 1)
			{
				lvwColumnSorterTeams.Order = (SortOrder)2;
			}
			else
			{
				lvwColumnSorterTeams.Order = (SortOrder)1;
			}
		}
		else
		{
			lvwColumnSorterTeams.SortColumn = e.get_Column();
			lvwColumnSorterTeams.Order = (SortOrder)1;
		}
		listViewTeams.Sort();
	}

	private void textBoxChat_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			((TextBoxBase)textBoxChat).Select(0, ((Control)textBoxChat).get_Text().Length);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
		else if (e.get_Control() && (int)e.get_KeyCode() == 70)
		{
			m_lastChat = ShowFormFind(textBoxChat);
			if (FindText(m_lastChat, textBoxChat))
			{
				e.set_Handled(true);
				e.set_SuppressKeyPress(true);
			}
		}
		else if (!string.IsNullOrEmpty(m_lastChat) && (int)e.get_KeyCode() == 114 && FindText(m_lastChat, textBoxChat))
		{
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void textBoxAll_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		if (e.get_Control() && (int)e.get_KeyCode() == 65)
		{
			((TextBoxBase)textBoxAll).Select(0, ((Control)textBoxAll).get_Text().Length);
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
		else if (e.get_Control() && (int)e.get_KeyCode() == 70)
		{
			m_lastAll = ShowFormFind(textBoxAll);
			if (FindText(m_lastAll, textBoxAll))
			{
				e.set_Handled(true);
				e.set_SuppressKeyPress(true);
			}
		}
		else if (!string.IsNullOrEmpty(m_lastAll) && (int)e.get_KeyCode() == 114 && FindText(m_lastAll, textBoxAll))
		{
			e.set_Handled(true);
			e.set_SuppressKeyPress(true);
		}
	}

	private void propertyGridConfig_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
	{
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_ChangedItem().get_Label().CompareTo("GameMode") == 0 || e.get_ChangedItem().get_Label().CompareTo("Ranked") == 0)
		{
			string text = "";
			List<string> list = new List<string>();
			foreach (string item in GetSettingsMapCycle())
			{
				list.Add(item);
				if (Maps.TryGetValue(item, out var value))
				{
					if (!FilterMapByGameMode(value))
					{
						if (text.Length > 0)
						{
							text += "\n";
						}
						list.Remove(item);
						text += value.Localize;
					}
					continue;
				}
				DirectoryInfo directoryInfo = new DirectoryInfo(CUtils.GetFarCry2PersonalUserMapsFolder());
				FileInfo[] files = directoryInfo.GetFiles(item + "*", SearchOption.AllDirectories);
				if (files.Length <= 0)
				{
					continue;
				}
				CMap cMap = new CMap();
				cMap.LoadHeader(files[0].FullName);
				if (!FilterMapByGameMode(cMap) || IsRankedSettings())
				{
					if (text.Length > 0)
					{
						text += "\n";
					}
					list.Remove(item);
					text += cMap.Localize;
				}
			}
			if (text.Length > 0)
			{
				SetSettingsMapCycle(list);
				string text2 = "The following maps have been removed from the map cycle.\n";
				if (e.get_ChangedItem().get_Label().CompareTo("GameMode") == 0)
				{
					text2 += "They aren't suported in ";
					text2 += e.get_ChangedItem().get_Value().ToString();
					text2 += ".\n\n";
				}
				else
				{
					text2 += "They aren't suported in Ranked mode.\n\n";
				}
				text2 += text;
				MessageBox.Show(text2, "Far Cry® 2 Server Launcher", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		SelectSettings();
	}

	public bool FilterMapByGameMode(CMap map)
	{
		switch (GetSettingsGameMode())
		{
		case EGameMode.Deathmatch:
			if (map.GameMode.Contains("DM"))
			{
				if (!map.GameMode.Contains("TDM"))
				{
					return true;
				}
				int num = map.GameMode.IndexOf("DM");
				int num2 = map.GameMode.IndexOf("TDM");
				if (num2 - num > 1)
				{
					return true;
				}
			}
			break;
		case EGameMode.TeamDeathmatch:
			if (map.GameMode.Contains("TDM"))
			{
				return true;
			}
			break;
		case EGameMode.CaptureTheDiamond:
			if (map.GameMode.Contains("CTD"))
			{
				return true;
			}
			break;
		case EGameMode.Uprising:
			if (map.GameMode.Contains("Uprising"))
			{
				return true;
			}
			break;
		}
		return false;
	}

	private void SetDefaultSettings()
	{
		m_currentSetting = ECurrentSettings.UNSET;
		m_dmSettings.SetDefault();
		m_tdmSettings.SetDefault();
		m_ctfSettings.SetDefault();
		m_vipSettings.SetDefault();
		m_dmSettingsOnline.SetDefault();
		m_tdmSettingsOnline.SetDefault();
		m_ctfSettingsOnline.SetDefault();
		m_vipSettingsOnline.SetDefault();
		m_dmSettingsRanked.SetDefault();
		m_tdmSettingsRanked.SetDefault();
		m_ctfSettingsRanked.SetDefault();
		m_vipSettingsRanked.SetDefault();
	}

	private void LoadSettingsFromXml(XmlDocument xmldoc)
	{
		m_currentSetting = ECurrentSettings.UNSET;
		m_dmSettings.LoadFromXml(xmldoc);
		m_tdmSettings.LoadFromXml(xmldoc);
		m_ctfSettings.LoadFromXml(xmldoc);
		m_vipSettings.LoadFromXml(xmldoc);
		m_dmSettingsOnline.LoadFromXml(xmldoc);
		m_tdmSettingsOnline.LoadFromXml(xmldoc);
		m_ctfSettingsOnline.LoadFromXml(xmldoc);
		m_vipSettingsOnline.LoadFromXml(xmldoc);
		m_dmSettingsRanked.LoadFromXml(xmldoc);
		m_tdmSettingsRanked.LoadFromXml(xmldoc);
		m_ctfSettingsRanked.LoadFromXml(xmldoc);
		m_vipSettingsRanked.LoadFromXml(xmldoc);
	}

	private void SaveSettingsToXml(ref XmlDocument xmldoc)
	{
		switch (m_currentSetting)
		{
		case ECurrentSettings.DM:
			m_dmSettings.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.TDM:
			m_tdmSettings.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.CTF:
			m_ctfSettings.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.VIP:
			m_vipSettings.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.DMOnline:
			m_dmSettingsOnline.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.TDMOnline:
			m_tdmSettingsOnline.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.CTFOnline:
			m_ctfSettingsOnline.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.VIPOnline:
			m_vipSettingsOnline.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.DMRanked:
			m_dmSettingsRanked.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.TDMRanked:
			m_tdmSettingsRanked.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.CTFRanked:
			m_ctfSettingsRanked.SaveToXml(ref xmldoc);
			break;
		case ECurrentSettings.VIPRanked:
			m_vipSettingsRanked.SaveToXml(ref xmldoc);
			break;
		}
	}

	private void WriteSettingsConsoleBatchFile()
	{
		switch (m_currentSetting)
		{
		case ECurrentSettings.DM:
			m_dmSettings.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.TDM:
			m_tdmSettings.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.CTF:
			m_ctfSettings.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.VIP:
			m_vipSettings.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.DMOnline:
			m_dmSettingsOnline.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.TDMOnline:
			m_tdmSettingsOnline.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.CTFOnline:
			m_ctfSettingsOnline.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.VIPOnline:
			m_vipSettingsOnline.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.DMRanked:
			m_dmSettingsRanked.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.TDMRanked:
			m_tdmSettingsRanked.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.CTFRanked:
			m_ctfSettingsRanked.WriteConsoleBatchFile();
			break;
		case ECurrentSettings.VIPRanked:
			m_vipSettingsRanked.WriteConsoleBatchFile();
			break;
		}
	}

	public string GetSettingsName()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => m_dmSettings.Name, 
			ECurrentSettings.TDM => m_tdmSettings.Name, 
			ECurrentSettings.CTF => m_ctfSettings.Name, 
			ECurrentSettings.VIP => m_vipSettings.Name, 
			ECurrentSettings.DMOnline => m_dmSettingsOnline.Name, 
			ECurrentSettings.TDMOnline => m_tdmSettingsOnline.Name, 
			ECurrentSettings.CTFOnline => m_ctfSettingsOnline.Name, 
			ECurrentSettings.VIPOnline => m_vipSettingsOnline.Name, 
			ECurrentSettings.DMRanked => m_dmSettingsRanked.Name, 
			ECurrentSettings.TDMRanked => m_tdmSettingsRanked.Name, 
			ECurrentSettings.CTFRanked => m_ctfSettingsRanked.Name, 
			ECurrentSettings.VIPRanked => m_vipSettingsRanked.Name, 
			_ => m_dmSettings.Name, 
		};
	}

	public EGameMode GetSettingsGameMode()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => m_dmSettings.m_gameMode, 
			ECurrentSettings.TDM => m_tdmSettings.m_gameMode, 
			ECurrentSettings.CTF => m_ctfSettings.m_gameMode, 
			ECurrentSettings.VIP => m_vipSettings.m_gameMode, 
			ECurrentSettings.DMOnline => m_dmSettingsOnline.m_gameMode, 
			ECurrentSettings.TDMOnline => m_tdmSettingsOnline.m_gameMode, 
			ECurrentSettings.CTFOnline => m_ctfSettingsOnline.m_gameMode, 
			ECurrentSettings.VIPOnline => m_vipSettingsOnline.m_gameMode, 
			ECurrentSettings.DMRanked => m_dmSettingsRanked.m_gameMode, 
			ECurrentSettings.TDMRanked => m_tdmSettingsRanked.m_gameMode, 
			ECurrentSettings.CTFRanked => m_ctfSettingsRanked.m_gameMode, 
			ECurrentSettings.VIPRanked => m_vipSettingsRanked.m_gameMode, 
			_ => m_dmSettings.m_gameMode, 
		};
	}

	public bool IsOnlineSettings()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => m_dmSettings.m_networkType == ENetworkType.Online, 
			ECurrentSettings.TDM => m_tdmSettings.m_networkType == ENetworkType.Online, 
			ECurrentSettings.CTF => m_ctfSettings.m_networkType == ENetworkType.Online, 
			ECurrentSettings.VIP => m_vipSettings.m_networkType == ENetworkType.Online, 
			ECurrentSettings.DMOnline => m_dmSettingsOnline.m_networkType == ENetworkType.Online, 
			ECurrentSettings.TDMOnline => m_tdmSettingsOnline.m_networkType == ENetworkType.Online, 
			ECurrentSettings.CTFOnline => m_ctfSettingsOnline.m_networkType == ENetworkType.Online, 
			ECurrentSettings.VIPOnline => m_vipSettingsOnline.m_networkType == ENetworkType.Online, 
			ECurrentSettings.DMRanked => m_dmSettingsRanked.m_networkType == ENetworkType.Online, 
			ECurrentSettings.TDMRanked => m_tdmSettingsRanked.m_networkType == ENetworkType.Online, 
			ECurrentSettings.CTFRanked => m_ctfSettingsRanked.m_networkType == ENetworkType.Online, 
			ECurrentSettings.VIPRanked => m_vipSettingsRanked.m_networkType == ENetworkType.Online, 
			_ => m_dmSettings.m_networkType == ENetworkType.Online, 
		};
	}

	public bool IsRankedSettings()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => m_dmSettings.m_ranked, 
			ECurrentSettings.TDM => m_tdmSettings.m_ranked, 
			ECurrentSettings.CTF => m_ctfSettings.m_ranked, 
			ECurrentSettings.VIP => m_vipSettings.m_ranked, 
			ECurrentSettings.DMOnline => m_dmSettingsOnline.m_ranked, 
			ECurrentSettings.TDMOnline => m_tdmSettingsOnline.m_ranked, 
			ECurrentSettings.CTFOnline => m_ctfSettingsOnline.m_ranked, 
			ECurrentSettings.VIPOnline => m_vipSettingsOnline.m_ranked, 
			ECurrentSettings.DMRanked => m_dmSettingsRanked.m_ranked, 
			ECurrentSettings.TDMRanked => m_tdmSettingsRanked.m_ranked, 
			ECurrentSettings.CTFRanked => m_ctfSettingsRanked.m_ranked, 
			ECurrentSettings.VIPRanked => m_vipSettingsRanked.m_ranked, 
			_ => m_dmSettings.m_ranked, 
		};
	}

	public bool IsRankedSettingsSafe()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => false, 
			ECurrentSettings.TDM => false, 
			ECurrentSettings.CTF => false, 
			ECurrentSettings.VIP => false, 
			ECurrentSettings.DMOnline => false, 
			ECurrentSettings.TDMOnline => false, 
			ECurrentSettings.CTFOnline => false, 
			ECurrentSettings.VIPOnline => false, 
			ECurrentSettings.DMRanked => true, 
			ECurrentSettings.TDMRanked => true, 
			ECurrentSettings.CTFRanked => true, 
			ECurrentSettings.VIPRanked => true, 
			_ => false, 
		};
	}

	public List<string> GetSettingsMapCycle()
	{
		return m_currentSetting switch
		{
			ECurrentSettings.DM => m_dmSettings.m_mapCycle, 
			ECurrentSettings.TDM => m_tdmSettings.m_mapCycle, 
			ECurrentSettings.CTF => m_ctfSettings.m_mapCycle, 
			ECurrentSettings.VIP => m_vipSettings.m_mapCycle, 
			ECurrentSettings.DMOnline => m_dmSettingsOnline.m_mapCycle, 
			ECurrentSettings.TDMOnline => m_tdmSettingsOnline.m_mapCycle, 
			ECurrentSettings.CTFOnline => m_ctfSettingsOnline.m_mapCycle, 
			ECurrentSettings.VIPOnline => m_vipSettingsOnline.m_mapCycle, 
			ECurrentSettings.DMRanked => m_dmSettingsRanked.m_mapCycle, 
			ECurrentSettings.TDMRanked => m_tdmSettingsRanked.m_mapCycle, 
			ECurrentSettings.CTFRanked => m_ctfSettingsRanked.m_mapCycle, 
			ECurrentSettings.VIPRanked => m_vipSettingsRanked.m_mapCycle, 
			_ => m_dmSettings.m_mapCycle, 
		};
	}

	public void SetSettingsMapCycle(List<string> maps)
	{
		switch (m_currentSetting)
		{
		case ECurrentSettings.DM:
			m_dmSettings.m_mapCycle = maps;
			break;
		case ECurrentSettings.TDM:
			m_tdmSettings.m_mapCycle = maps;
			break;
		case ECurrentSettings.CTF:
			m_ctfSettings.m_mapCycle = maps;
			break;
		case ECurrentSettings.VIP:
			m_vipSettings.m_mapCycle = maps;
			break;
		case ECurrentSettings.DMOnline:
			m_dmSettingsOnline.m_mapCycle = maps;
			break;
		case ECurrentSettings.TDMOnline:
			m_tdmSettingsOnline.m_mapCycle = maps;
			break;
		case ECurrentSettings.CTFOnline:
			m_ctfSettingsOnline.m_mapCycle = maps;
			break;
		case ECurrentSettings.VIPOnline:
			m_vipSettingsOnline.m_mapCycle = maps;
			break;
		case ECurrentSettings.DMRanked:
			m_dmSettingsRanked.m_mapCycle = maps;
			break;
		case ECurrentSettings.TDMRanked:
			m_tdmSettingsRanked.m_mapCycle = maps;
			break;
		case ECurrentSettings.CTFRanked:
			m_ctfSettingsRanked.m_mapCycle = maps;
			break;
		case ECurrentSettings.VIPRanked:
			m_vipSettingsRanked.m_mapCycle = maps;
			break;
		}
	}

	private void SelectSettings()
	{
		ECurrentSettings currentSetting = m_currentSetting;
		if (!IsOnlineSettings())
		{
			switch (GetSettingsGameMode())
			{
			case EGameMode.Deathmatch:
				m_currentSetting = ECurrentSettings.DM;
				break;
			case EGameMode.TeamDeathmatch:
				m_currentSetting = ECurrentSettings.TDM;
				break;
			case EGameMode.CaptureTheDiamond:
				m_currentSetting = ECurrentSettings.CTF;
				break;
			case EGameMode.Uprising:
				m_currentSetting = ECurrentSettings.VIP;
				break;
			}
		}
		else if (IsRankedSettings())
		{
			switch (GetSettingsGameMode())
			{
			case EGameMode.Deathmatch:
				m_currentSetting = ECurrentSettings.DMRanked;
				break;
			case EGameMode.TeamDeathmatch:
				m_currentSetting = ECurrentSettings.TDMRanked;
				break;
			case EGameMode.CaptureTheDiamond:
				m_currentSetting = ECurrentSettings.CTFRanked;
				break;
			case EGameMode.Uprising:
				m_currentSetting = ECurrentSettings.VIPRanked;
				break;
			}
		}
		else
		{
			switch (GetSettingsGameMode())
			{
			case EGameMode.Deathmatch:
				m_currentSetting = ECurrentSettings.DMOnline;
				break;
			case EGameMode.TeamDeathmatch:
				m_currentSetting = ECurrentSettings.TDMOnline;
				break;
			case EGameMode.CaptureTheDiamond:
				m_currentSetting = ECurrentSettings.CTFOnline;
				break;
			case EGameMode.Uprising:
				m_currentSetting = ECurrentSettings.VIPOnline;
				break;
			}
		}
		if (currentSetting != m_currentSetting)
		{
			Cursor.set_Current(Cursors.get_WaitCursor());
			switch (currentSetting)
			{
			case ECurrentSettings.DM:
				m_tdmSettings.CopyFrom(m_dmSettings);
				m_ctfSettings.CopyFrom(m_dmSettings);
				m_vipSettings.CopyFrom(m_dmSettings);
				m_dmSettingsOnline.CopyFrom(m_dmSettings);
				m_tdmSettingsOnline.CopyFrom(m_dmSettings);
				m_ctfSettingsOnline.CopyFrom(m_dmSettings);
				m_vipSettingsOnline.CopyFrom(m_dmSettings);
				m_dmSettingsRanked.CopyFrom(m_dmSettings);
				m_tdmSettingsRanked.CopyFrom(m_dmSettings);
				m_ctfSettingsRanked.CopyFrom(m_dmSettings);
				m_vipSettingsRanked.CopyFrom(m_dmSettings);
				break;
			case ECurrentSettings.TDM:
				m_dmSettings.CopyFrom(m_tdmSettings);
				m_ctfSettings.CopyFrom(m_tdmSettings);
				m_vipSettings.CopyFrom(m_tdmSettings);
				m_dmSettingsOnline.CopyFrom(m_tdmSettings);
				m_tdmSettingsOnline.CopyFrom(m_tdmSettings);
				m_ctfSettingsOnline.CopyFrom(m_tdmSettings);
				m_vipSettingsOnline.CopyFrom(m_tdmSettings);
				m_dmSettingsRanked.CopyFrom(m_tdmSettings);
				m_tdmSettingsRanked.CopyFrom(m_tdmSettings);
				m_ctfSettingsRanked.CopyFrom(m_tdmSettings);
				m_vipSettingsRanked.CopyFrom(m_tdmSettings);
				break;
			case ECurrentSettings.CTF:
				m_dmSettings.CopyFrom(m_ctfSettings);
				m_tdmSettings.CopyFrom(m_ctfSettings);
				m_vipSettings.CopyFrom(m_ctfSettings);
				m_dmSettingsOnline.CopyFrom(m_ctfSettings);
				m_tdmSettingsOnline.CopyFrom(m_ctfSettings);
				m_ctfSettingsOnline.CopyFrom(m_ctfSettings);
				m_vipSettingsOnline.CopyFrom(m_ctfSettings);
				m_dmSettingsRanked.CopyFrom(m_ctfSettings);
				m_tdmSettingsRanked.CopyFrom(m_ctfSettings);
				m_ctfSettingsRanked.CopyFrom(m_ctfSettings);
				m_vipSettingsRanked.CopyFrom(m_ctfSettings);
				break;
			case ECurrentSettings.VIP:
				m_dmSettings.CopyFrom(m_vipSettings);
				m_tdmSettings.CopyFrom(m_vipSettings);
				m_ctfSettings.CopyFrom(m_vipSettings);
				m_dmSettingsOnline.CopyFrom(m_vipSettings);
				m_tdmSettingsOnline.CopyFrom(m_vipSettings);
				m_ctfSettingsOnline.CopyFrom(m_vipSettings);
				m_vipSettingsOnline.CopyFrom(m_vipSettings);
				m_dmSettingsRanked.CopyFrom(m_vipSettings);
				m_tdmSettingsRanked.CopyFrom(m_vipSettings);
				m_ctfSettingsRanked.CopyFrom(m_vipSettings);
				m_vipSettingsRanked.CopyFrom(m_vipSettings);
				break;
			case ECurrentSettings.DMOnline:
				m_dmSettings.CopyFrom(m_dmSettingsOnline);
				m_tdmSettings.CopyFrom(m_dmSettingsOnline);
				m_ctfSettings.CopyFrom(m_dmSettingsOnline);
				m_vipSettings.CopyFrom(m_dmSettingsOnline);
				m_tdmSettingsOnline.CopyFrom(m_dmSettingsOnline);
				m_ctfSettingsOnline.CopyFrom(m_dmSettingsOnline);
				m_vipSettingsOnline.CopyFrom(m_dmSettingsOnline);
				m_dmSettingsRanked.CopyFrom(m_dmSettingsOnline);
				m_tdmSettingsRanked.CopyFrom(m_dmSettingsOnline);
				m_ctfSettingsRanked.CopyFrom(m_dmSettingsOnline);
				m_vipSettingsRanked.CopyFrom(m_dmSettingsOnline);
				break;
			case ECurrentSettings.TDMOnline:
				m_dmSettings.CopyFrom(m_tdmSettingsOnline);
				m_tdmSettings.CopyFrom(m_tdmSettingsOnline);
				m_ctfSettings.CopyFrom(m_tdmSettingsOnline);
				m_vipSettings.CopyFrom(m_tdmSettingsOnline);
				m_dmSettingsOnline.CopyFrom(m_tdmSettingsOnline);
				m_ctfSettingsOnline.CopyFrom(m_tdmSettingsOnline);
				m_vipSettingsOnline.CopyFrom(m_tdmSettingsOnline);
				m_dmSettingsRanked.CopyFrom(m_tdmSettingsOnline);
				m_tdmSettingsRanked.CopyFrom(m_tdmSettingsOnline);
				m_ctfSettingsRanked.CopyFrom(m_tdmSettingsOnline);
				m_vipSettingsRanked.CopyFrom(m_tdmSettingsOnline);
				break;
			case ECurrentSettings.CTFOnline:
				m_dmSettings.CopyFrom(m_ctfSettingsOnline);
				m_tdmSettings.CopyFrom(m_ctfSettingsOnline);
				m_ctfSettings.CopyFrom(m_ctfSettingsOnline);
				m_vipSettings.CopyFrom(m_ctfSettingsOnline);
				m_dmSettingsOnline.CopyFrom(m_ctfSettingsOnline);
				m_tdmSettingsOnline.CopyFrom(m_ctfSettingsOnline);
				m_vipSettingsOnline.CopyFrom(m_ctfSettingsOnline);
				m_dmSettingsRanked.CopyFrom(m_ctfSettingsOnline);
				m_tdmSettingsRanked.CopyFrom(m_ctfSettingsOnline);
				m_ctfSettingsRanked.CopyFrom(m_ctfSettingsOnline);
				m_vipSettingsRanked.CopyFrom(m_ctfSettingsOnline);
				break;
			case ECurrentSettings.VIPOnline:
				m_dmSettings.CopyFrom(m_vipSettingsOnline);
				m_tdmSettings.CopyFrom(m_vipSettingsOnline);
				m_ctfSettings.CopyFrom(m_vipSettingsOnline);
				m_vipSettings.CopyFrom(m_vipSettingsOnline);
				m_dmSettingsOnline.CopyFrom(m_vipSettingsOnline);
				m_tdmSettingsOnline.CopyFrom(m_vipSettingsOnline);
				m_ctfSettingsOnline.CopyFrom(m_vipSettingsOnline);
				m_dmSettingsRanked.CopyFrom(m_vipSettingsOnline);
				m_tdmSettingsRanked.CopyFrom(m_vipSettingsOnline);
				m_ctfSettingsRanked.CopyFrom(m_vipSettingsOnline);
				m_vipSettingsRanked.CopyFrom(m_vipSettingsOnline);
				break;
			case ECurrentSettings.DMRanked:
				m_dmSettings.CopyFrom(m_dmSettingsRanked);
				m_tdmSettings.CopyFrom(m_dmSettingsRanked);
				m_ctfSettings.CopyFrom(m_dmSettingsRanked);
				m_vipSettings.CopyFrom(m_dmSettingsRanked);
				m_dmSettingsOnline.CopyFrom(m_dmSettingsRanked);
				m_tdmSettingsOnline.CopyFrom(m_dmSettingsRanked);
				m_ctfSettingsOnline.CopyFrom(m_dmSettingsRanked);
				m_vipSettingsOnline.CopyFrom(m_dmSettingsRanked);
				m_tdmSettingsRanked.CopyFrom(m_dmSettingsRanked);
				m_ctfSettingsRanked.CopyFrom(m_dmSettingsRanked);
				m_vipSettingsRanked.CopyFrom(m_dmSettingsRanked);
				break;
			case ECurrentSettings.TDMRanked:
				m_dmSettings.CopyFrom(m_tdmSettingsRanked);
				m_tdmSettings.CopyFrom(m_tdmSettingsRanked);
				m_ctfSettings.CopyFrom(m_tdmSettingsRanked);
				m_vipSettings.CopyFrom(m_tdmSettingsRanked);
				m_dmSettingsOnline.CopyFrom(m_tdmSettingsRanked);
				m_tdmSettingsOnline.CopyFrom(m_tdmSettingsRanked);
				m_ctfSettingsOnline.CopyFrom(m_tdmSettingsRanked);
				m_vipSettingsOnline.CopyFrom(m_tdmSettingsRanked);
				m_dmSettingsRanked.CopyFrom(m_tdmSettingsRanked);
				m_ctfSettingsRanked.CopyFrom(m_tdmSettingsRanked);
				m_vipSettingsRanked.CopyFrom(m_tdmSettingsRanked);
				break;
			case ECurrentSettings.CTFRanked:
				m_dmSettings.CopyFrom(m_ctfSettingsRanked);
				m_tdmSettings.CopyFrom(m_ctfSettingsRanked);
				m_ctfSettings.CopyFrom(m_ctfSettingsRanked);
				m_vipSettings.CopyFrom(m_ctfSettingsRanked);
				m_dmSettingsOnline.CopyFrom(m_ctfSettingsRanked);
				m_tdmSettingsOnline.CopyFrom(m_ctfSettingsRanked);
				m_ctfSettingsOnline.CopyFrom(m_ctfSettingsRanked);
				m_vipSettingsOnline.CopyFrom(m_ctfSettingsRanked);
				m_dmSettingsRanked.CopyFrom(m_ctfSettingsRanked);
				m_tdmSettingsRanked.CopyFrom(m_ctfSettingsRanked);
				m_vipSettingsRanked.CopyFrom(m_ctfSettingsRanked);
				break;
			case ECurrentSettings.VIPRanked:
				m_dmSettings.CopyFrom(m_vipSettingsRanked);
				m_tdmSettings.CopyFrom(m_vipSettingsRanked);
				m_ctfSettings.CopyFrom(m_vipSettingsRanked);
				m_vipSettings.CopyFrom(m_vipSettingsRanked);
				m_dmSettingsOnline.CopyFrom(m_vipSettingsRanked);
				m_tdmSettingsOnline.CopyFrom(m_vipSettingsRanked);
				m_ctfSettingsOnline.CopyFrom(m_vipSettingsRanked);
				m_vipSettingsOnline.CopyFrom(m_vipSettingsRanked);
				m_dmSettingsRanked.CopyFrom(m_vipSettingsRanked);
				m_tdmSettingsRanked.CopyFrom(m_vipSettingsRanked);
				m_ctfSettingsRanked.CopyFrom(m_vipSettingsRanked);
				break;
			}
			switch (m_currentSetting)
			{
			case ECurrentSettings.DM:
				propertyGridConfig.set_SelectedObject((object)m_dmSettings);
				break;
			case ECurrentSettings.TDM:
				propertyGridConfig.set_SelectedObject((object)m_tdmSettings);
				break;
			case ECurrentSettings.CTF:
				propertyGridConfig.set_SelectedObject((object)m_ctfSettings);
				break;
			case ECurrentSettings.VIP:
				propertyGridConfig.set_SelectedObject((object)m_vipSettings);
				break;
			case ECurrentSettings.DMOnline:
				propertyGridConfig.set_SelectedObject((object)m_dmSettingsOnline);
				break;
			case ECurrentSettings.TDMOnline:
				propertyGridConfig.set_SelectedObject((object)m_tdmSettingsOnline);
				break;
			case ECurrentSettings.CTFOnline:
				propertyGridConfig.set_SelectedObject((object)m_ctfSettingsOnline);
				break;
			case ECurrentSettings.VIPOnline:
				propertyGridConfig.set_SelectedObject((object)m_vipSettingsOnline);
				break;
			case ECurrentSettings.DMRanked:
				propertyGridConfig.set_SelectedObject((object)m_dmSettingsRanked);
				break;
			case ECurrentSettings.TDMRanked:
				propertyGridConfig.set_SelectedObject((object)m_tdmSettingsRanked);
				break;
			case ECurrentSettings.CTFRanked:
				propertyGridConfig.set_SelectedObject((object)m_ctfSettingsRanked);
				break;
			case ECurrentSettings.VIPRanked:
				propertyGridConfig.set_SelectedObject((object)m_vipSettingsRanked);
				break;
			}
			Cursor.set_Current(Cursors.get_Default());
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected O, but got Unknown
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected O, but got Unknown
		//IL_159f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Expected O, but got Unknown
		//IL_15ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196c: Expected O, but got Unknown
		//IL_1ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ace: Expected O, but got Unknown
		//IL_1b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b19: Expected O, but got Unknown
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Expected O, but got Unknown
		//IL_1ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffd: Expected O, but got Unknown
		//IL_2168: Unknown result type (might be due to invalid IL or missing references)
		//IL_2172: Expected O, but got Unknown
		//IL_220a: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b3: Expected O, but got Unknown
		//IL_2732: Unknown result type (might be due to invalid IL or missing references)
		//IL_273c: Expected O, but got Unknown
		//IL_281b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2825: Expected O, but got Unknown
		//IL_284f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2859: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		statusStripMain = new StatusStrip();
		toolStripStatusLabelLeft = new ToolStripStatusLabel();
		toolStripStatusLabelMain = new ToolStripStatusLabel();
		menuStripMain = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		newConfigToolStripMenuItem = new ToolStripMenuItem();
		loadConfigToolStripMenuItem = new ToolStripMenuItem();
		recentConfigToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		saveConfigAsToolStripMenuItem = new ToolStripMenuItem();
		saveConfigToolStripMenuItem = new ToolStripMenuItem();
		toolStripSeparator2 = new ToolStripSeparator();
		exitToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		ColumnTime = new DataGridViewTextBoxColumn();
		ColumnScore = new DataGridViewTextBoxColumn();
		ColumnPing = new DataGridViewTextBoxColumn();
		ColumnPlayerName = new DataGridViewTextBoxColumn();
		tabPageConfig = new TabPage();
		buttonSave = new Button();
		buttonLoad = new Button();
		propertyGridConfig = new PropertyGrid();
		textBoxIp = new TextBox();
		buttonStartServer = new Button();
		labelIp = new Label();
		buttonKillServer = new Button();
		tabControlMain = new TabControl();
		tabPageConsole = new TabPage();
		buttonVote = new Button();
		buttonRestartMatch = new Button();
		buttonSkipMap = new Button();
		buttonShuffleTeams = new Button();
		buttonExtendMatch = new Button();
		buttonEndMatch = new Button();
		buttonChangeVIP = new Button();
		buttonExecute = new Button();
		textBoxExecute = new TextBox();
		textBoxConsole = new TextBox();
		tabPagePlayers = new TabPage();
		groupBoxMatch = new GroupBox();
		labelMap = new Label();
		labelM = new Label();
		labelState = new Label();
		textBoxAll = new TextBox();
		labelMatch = new Label();
		listViewTeams = new ListView();
		columnHeaderTeamName = new ColumnHeader();
		columnHeaderTeamScore = new ColumnHeader();
		imageListMulti = new ImageList(components);
		buttonSay = new Button();
		textBoxSay = new TextBox();
		groupBoxPlayers = new GroupBox();
		buttonKick = new Button();
		buttonVoteKick = new Button();
		label1 = new Label();
		textBoxChat = new TextBox();
		propertyGridPlayers = new PropertyGrid();
		buttonTell = new Button();
		textBoxTell = new TextBox();
		tabPageOptions = new TabPage();
		buttonGoToLog = new Button();
		buttonDeleteAll = new Button();
		textBoxLogSize = new TextBox();
		label5 = new Label();
		propertyGridOptions = new PropertyGrid();
		timerPlayersUpdate = new Timer(components);
		pictureBoxTitle = new PictureBox();
		pictureBoxFC2 = new PictureBox();
		emptyControl = new EmptyControl();
		listViewPlayers = new ListViewImage();
		columnHeaderName = new ColumnHeader();
		columnHeaderScore = new ColumnHeader();
		columnHeaderTeam = new ColumnHeader();
		columnHeaderVIP = new ColumnHeader();
		((Control)statusStripMain).SuspendLayout();
		((Control)menuStripMain).SuspendLayout();
		((Control)tabPageConfig).SuspendLayout();
		((Control)tabControlMain).SuspendLayout();
		((Control)tabPageConsole).SuspendLayout();
		((Control)tabPagePlayers).SuspendLayout();
		((Control)groupBoxMatch).SuspendLayout();
		((Control)groupBoxPlayers).SuspendLayout();
		((Control)tabPageOptions).SuspendLayout();
		((ISupportInitialize)pictureBoxTitle).BeginInit();
		((ISupportInitialize)pictureBoxFC2).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)statusStripMain).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabelLeft });
		((Control)statusStripMain).set_Location(new Point(0, 523));
		((Control)statusStripMain).set_Name("statusStripMain");
		((Control)statusStripMain).set_Size(new Size(729, 22));
		((Control)statusStripMain).set_TabIndex(5);
		((Control)statusStripMain).set_Text("statusStrip");
		((ToolStripItem)toolStripStatusLabelLeft).set_Name("toolStripStatusLabelLeft");
		((ToolStripItem)toolStripStatusLabelLeft).set_Size(new Size(38, 17));
		((ToolStripItem)toolStripStatusLabelLeft).set_Text("Ready");
		((ToolStripItem)toolStripStatusLabelMain).set_Name("toolStripStatusLabelMain");
		((ToolStripItem)toolStripStatusLabelMain).set_Size(new Size(38, 17));
		((ToolStripItem)toolStripStatusLabelMain).set_Text("Ready");
		((ToolStrip)menuStripMain).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((Control)menuStripMain).set_Location(new Point(0, 0));
		((Control)menuStripMain).set_Name("menuStripMain");
		((ToolStrip)menuStripMain).set_RenderMode((ToolStripRenderMode)1);
		((Control)menuStripMain).set_Size(new Size(729, 24));
		((Control)menuStripMain).set_TabIndex(6);
		((Control)menuStripMain).set_Text("menuStrip1");
		((ToolStripDropDownItem)fileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)newConfigToolStripMenuItem,
			(ToolStripItem)loadConfigToolStripMenuItem,
			(ToolStripItem)recentConfigToolStripMenuItem,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)saveConfigAsToolStripMenuItem,
			(ToolStripItem)saveConfigToolStripMenuItem,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)exitToolStripMenuItem
		});
		((ToolStripItem)fileToolStripMenuItem).set_Name("fileToolStripMenuItem");
		((ToolStripItem)fileToolStripMenuItem).set_Size(new Size(35, 20));
		((ToolStripItem)fileToolStripMenuItem).set_Text("File");
		((ToolStripItem)newConfigToolStripMenuItem).set_Name("newConfigToolStripMenuItem");
		((ToolStripItem)newConfigToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)newConfigToolStripMenuItem).set_Text("New config");
		((ToolStripItem)newConfigToolStripMenuItem).add_Click((EventHandler)newConfigToolStripMenuItem_Click);
		((ToolStripItem)loadConfigToolStripMenuItem).set_Name("loadConfigToolStripMenuItem");
		((ToolStripItem)loadConfigToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)loadConfigToolStripMenuItem).set_Text("Load config...");
		((ToolStripItem)loadConfigToolStripMenuItem).add_Click((EventHandler)loadConfigToolStripMenuItem_Click);
		((ToolStripItem)recentConfigToolStripMenuItem).set_Name("recentConfigToolStripMenuItem");
		((ToolStripItem)recentConfigToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)recentConfigToolStripMenuItem).set_Text("Recent config");
		((ToolStripItem)toolStripSeparator1).set_Name("toolStripSeparator1");
		((ToolStripItem)toolStripSeparator1).set_Size(new Size(164, 6));
		((ToolStripItem)saveConfigAsToolStripMenuItem).set_Name("saveConfigAsToolStripMenuItem");
		((ToolStripItem)saveConfigAsToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)saveConfigAsToolStripMenuItem).set_Text("Save config as...");
		((ToolStripItem)saveConfigAsToolStripMenuItem).add_Click((EventHandler)saveConfigAsToolStripMenuItem_Click);
		((ToolStripItem)saveConfigToolStripMenuItem).set_Name("saveConfigToolStripMenuItem");
		((ToolStripItem)saveConfigToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)saveConfigToolStripMenuItem).set_Text("Save config");
		((ToolStripItem)saveConfigToolStripMenuItem).add_Click((EventHandler)saveConfigToolStripMenuItem_Click);
		((ToolStripItem)toolStripSeparator2).set_Name("toolStripSeparator2");
		((ToolStripItem)toolStripSeparator2).set_Size(new Size(164, 6));
		((ToolStripItem)exitToolStripMenuItem).set_Name("exitToolStripMenuItem");
		((ToolStripItem)exitToolStripMenuItem).set_Size(new Size(167, 22));
		((ToolStripItem)exitToolStripMenuItem).set_Text("Exit");
		((ToolStripItem)exitToolStripMenuItem).add_Click((EventHandler)exitToolStripMenuItem_Click);
		((ToolStripDropDownItem)helpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)aboutToolStripMenuItem });
		((ToolStripItem)helpToolStripMenuItem).set_Name("helpToolStripMenuItem");
		((ToolStripItem)helpToolStripMenuItem).set_Size(new Size(40, 20));
		((ToolStripItem)helpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(126, 22));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About...");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((DataGridViewColumn)ColumnTime).set_HeaderText("Time");
		((DataGridViewColumn)ColumnTime).set_Name("ColumnTime");
		((DataGridViewBand)ColumnTime).set_ReadOnly(true);
		((DataGridViewColumn)ColumnScore).set_HeaderText("Score");
		((DataGridViewColumn)ColumnScore).set_Name("ColumnScore");
		((DataGridViewBand)ColumnScore).set_ReadOnly(true);
		((DataGridViewColumn)ColumnPing).set_HeaderText("Ping");
		((DataGridViewColumn)ColumnPing).set_Name("ColumnPing");
		((DataGridViewBand)ColumnPing).set_ReadOnly(true);
		((DataGridViewColumn)ColumnPlayerName).set_HeaderText("Player Name");
		((DataGridViewColumn)ColumnPlayerName).set_Name("ColumnPlayerName");
		((DataGridViewBand)ColumnPlayerName).set_ReadOnly(true);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)emptyControl);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)buttonSave);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)buttonLoad);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)propertyGridConfig);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)textBoxIp);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)buttonStartServer);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)labelIp);
		((Control)tabPageConfig).get_Controls().Add((Control)(object)buttonKillServer);
		tabPageConfig.set_Location(new Point(4, 22));
		((Control)tabPageConfig).set_Name("tabPageConfig");
		((Control)tabPageConfig).set_Padding(new Padding(3));
		((Control)tabPageConfig).set_Size(new Size(650, 467));
		tabPageConfig.set_TabIndex(0);
		((Control)tabPageConfig).set_Text("Server");
		tabPageConfig.set_UseVisualStyleBackColor(true);
		((Control)buttonSave).set_Anchor((AnchorStyles)9);
		((Control)buttonSave).set_Location(new Point(535, 178));
		((Control)buttonSave).set_Name("buttonSave");
		((Control)buttonSave).set_Size(new Size(92, 23));
		((Control)buttonSave).set_TabIndex(6);
		((Control)buttonSave).set_Text("Save config");
		((ButtonBase)buttonSave).set_UseVisualStyleBackColor(true);
		((Control)buttonSave).add_Click((EventHandler)buttonSave_Click);
		((Control)buttonLoad).set_Anchor((AnchorStyles)9);
		((Control)buttonLoad).set_Location(new Point(535, 207));
		((Control)buttonLoad).set_Name("buttonLoad");
		((Control)buttonLoad).set_Size(new Size(92, 23));
		((Control)buttonLoad).set_TabIndex(7);
		((Control)buttonLoad).set_Text("Load config");
		((ButtonBase)buttonLoad).set_UseVisualStyleBackColor(true);
		((Control)buttonLoad).add_Click((EventHandler)buttonLoad_Click);
		((Control)propertyGridConfig).set_Anchor((AnchorStyles)15);
		((Control)propertyGridConfig).set_Location(new Point(3, 3));
		((Control)propertyGridConfig).set_Name("propertyGridConfig");
		propertyGridConfig.set_PropertySort((PropertySort)2);
		((Control)propertyGridConfig).set_Size(new Size(513, 458));
		((Control)propertyGridConfig).set_TabIndex(0);
		propertyGridConfig.add_PropertyValueChanged(new PropertyValueChangedEventHandler(propertyGridConfig_PropertyValueChanged));
		((Control)textBoxIp).set_Anchor((AnchorStyles)9);
		((Control)textBoxIp).set_Location(new Point(535, 127));
		((Control)textBoxIp).set_Name("textBoxIp");
		((TextBoxBase)textBoxIp).set_ReadOnly(true);
		((Control)textBoxIp).set_Size(new Size(92, 20));
		((Control)textBoxIp).set_TabIndex(5);
		((Control)textBoxIp).set_Text("255.255.255.255");
		((Control)buttonStartServer).set_Anchor((AnchorStyles)9);
		((Control)buttonStartServer).set_Location(new Point(535, 27));
		((Control)buttonStartServer).set_Name("buttonStartServer");
		((Control)buttonStartServer).set_Size(new Size(92, 23));
		((Control)buttonStartServer).set_TabIndex(2);
		((Control)buttonStartServer).set_Text("Start");
		((ButtonBase)buttonStartServer).set_UseVisualStyleBackColor(true);
		((Control)buttonStartServer).add_Click((EventHandler)buttonStartServer_Click);
		((Control)labelIp).set_Anchor((AnchorStyles)9);
		((Control)labelIp).set_AutoSize(true);
		((Control)labelIp).set_Location(new Point(532, 111));
		((Control)labelIp).set_Name("labelIp");
		((Control)labelIp).set_Size(new Size(51, 13));
		((Control)labelIp).set_TabIndex(4);
		((Control)labelIp).set_Text("Server IP");
		((Control)buttonKillServer).set_Anchor((AnchorStyles)9);
		((Control)buttonKillServer).set_Enabled(false);
		((Control)buttonKillServer).set_Location(new Point(535, 56));
		((Control)buttonKillServer).set_Name("buttonKillServer");
		((Control)buttonKillServer).set_Size(new Size(92, 23));
		((Control)buttonKillServer).set_TabIndex(3);
		((Control)buttonKillServer).set_Text("Stop");
		((ButtonBase)buttonKillServer).set_UseVisualStyleBackColor(true);
		((Control)buttonKillServer).add_Click((EventHandler)buttonKillServer_Click);
		((Control)tabControlMain).set_Anchor((AnchorStyles)15);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPageConfig);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPageConsole);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPagePlayers);
		((Control)tabControlMain).get_Controls().Add((Control)(object)tabPageOptions);
		((Control)tabControlMain).set_Location(new Point(71, 27));
		((Control)tabControlMain).set_Name("tabControlMain");
		tabControlMain.set_SelectedIndex(0);
		((Control)tabControlMain).set_Size(new Size(658, 493));
		((Control)tabControlMain).set_TabIndex(4);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonVote);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonRestartMatch);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonSkipMap);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonShuffleTeams);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonExtendMatch);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonEndMatch);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonChangeVIP);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)buttonExecute);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)textBoxExecute);
		((Control)tabPageConsole).get_Controls().Add((Control)(object)textBoxConsole);
		tabPageConsole.set_Location(new Point(4, 22));
		((Control)tabPageConsole).set_Name("tabPageConsole");
		((Control)tabPageConsole).set_Padding(new Padding(3));
		((Control)tabPageConsole).set_Size(new Size(650, 467));
		tabPageConsole.set_TabIndex(1);
		((Control)tabPageConsole).set_Text("Console");
		tabPageConsole.set_UseVisualStyleBackColor(true);
		((Control)buttonVote).set_Anchor((AnchorStyles)9);
		((Control)buttonVote).set_Location(new Point(530, 180));
		((Control)buttonVote).set_Name("buttonVote");
		((Control)buttonVote).set_Size(new Size(102, 23));
		((Control)buttonVote).set_TabIndex(17);
		((Control)buttonVote).set_Text("Call Vote");
		((ButtonBase)buttonVote).set_UseVisualStyleBackColor(true);
		((Control)buttonVote).add_Click((EventHandler)buttonVote_Click);
		((Control)buttonRestartMatch).set_Anchor((AnchorStyles)9);
		((Control)buttonRestartMatch).set_Location(new Point(530, 151));
		((Control)buttonRestartMatch).set_Name("buttonRestartMatch");
		((Control)buttonRestartMatch).set_Size(new Size(102, 23));
		((Control)buttonRestartMatch).set_TabIndex(16);
		((Control)buttonRestartMatch).set_Text("Restart match");
		((ButtonBase)buttonRestartMatch).set_UseVisualStyleBackColor(true);
		((Control)buttonRestartMatch).add_Click((EventHandler)buttonRestartMatch_Click);
		((Control)buttonSkipMap).set_Anchor((AnchorStyles)9);
		((Control)buttonSkipMap).set_Location(new Point(530, 64));
		((Control)buttonSkipMap).set_Name("buttonSkipMap");
		((Control)buttonSkipMap).set_Size(new Size(102, 23));
		((Control)buttonSkipMap).set_TabIndex(13);
		((Control)buttonSkipMap).set_Text("Skip map");
		((ButtonBase)buttonSkipMap).set_UseVisualStyleBackColor(true);
		((Control)buttonSkipMap).add_Click((EventHandler)buttonSkipMap_Click);
		((Control)buttonShuffleTeams).set_Anchor((AnchorStyles)9);
		((Control)buttonShuffleTeams).set_Location(new Point(530, 35));
		((Control)buttonShuffleTeams).set_Name("buttonShuffleTeams");
		((Control)buttonShuffleTeams).set_Size(new Size(102, 23));
		((Control)buttonShuffleTeams).set_TabIndex(12);
		((Control)buttonShuffleTeams).set_Text("Shuffle teams");
		((ButtonBase)buttonShuffleTeams).set_UseVisualStyleBackColor(true);
		((Control)buttonShuffleTeams).add_Click((EventHandler)buttonShuffleTeams_Click);
		((Control)buttonExtendMatch).set_Anchor((AnchorStyles)9);
		((Control)buttonExtendMatch).set_Location(new Point(530, 122));
		((Control)buttonExtendMatch).set_Name("buttonExtendMatch");
		((Control)buttonExtendMatch).set_Size(new Size(102, 23));
		((Control)buttonExtendMatch).set_TabIndex(15);
		((Control)buttonExtendMatch).set_Text("Extend match");
		((ButtonBase)buttonExtendMatch).set_UseVisualStyleBackColor(true);
		((Control)buttonExtendMatch).add_Click((EventHandler)buttonExtendMatch_Click);
		((Control)buttonEndMatch).set_Anchor((AnchorStyles)9);
		((Control)buttonEndMatch).set_Location(new Point(530, 93));
		((Control)buttonEndMatch).set_Name("buttonEndMatch");
		((Control)buttonEndMatch).set_Size(new Size(102, 23));
		((Control)buttonEndMatch).set_TabIndex(14);
		((Control)buttonEndMatch).set_Text("End match");
		((ButtonBase)buttonEndMatch).set_UseVisualStyleBackColor(true);
		((Control)buttonEndMatch).add_Click((EventHandler)buttonEndMatch_Click);
		((Control)buttonChangeVIP).set_Anchor((AnchorStyles)9);
		((Control)buttonChangeVIP).set_Location(new Point(530, 6));
		((Control)buttonChangeVIP).set_Name("buttonChangeVIP");
		((Control)buttonChangeVIP).set_Size(new Size(102, 23));
		((Control)buttonChangeVIP).set_TabIndex(11);
		((Control)buttonChangeVIP).set_Text("Change Captain");
		((ButtonBase)buttonChangeVIP).set_UseVisualStyleBackColor(true);
		((Control)buttonChangeVIP).add_Click((EventHandler)buttonChangeVIP_Click);
		((Control)buttonExecute).set_Anchor((AnchorStyles)10);
		((Control)buttonExecute).set_Location(new Point(530, 438));
		((Control)buttonExecute).set_Name("buttonExecute");
		((Control)buttonExecute).set_Size(new Size(102, 23));
		((Control)buttonExecute).set_TabIndex(1);
		((Control)buttonExecute).set_Text("Send");
		((ButtonBase)buttonExecute).set_UseVisualStyleBackColor(true);
		((Control)buttonExecute).add_Click((EventHandler)buttonExecute_Click);
		textBoxExecute.set_AcceptsReturn(true);
		((TextBoxBase)textBoxExecute).set_AcceptsTab(true);
		((Control)textBoxExecute).set_Anchor((AnchorStyles)14);
		((Control)textBoxExecute).set_BackColor(Color.Black);
		((Control)textBoxExecute).set_ForeColor(Color.Tan);
		((Control)textBoxExecute).set_Location(new Point(8, 441));
		((TextBoxBase)textBoxExecute).set_Multiline(true);
		((Control)textBoxExecute).set_Name("textBoxExecute");
		((Control)textBoxExecute).set_Size(new Size(505, 20));
		((Control)textBoxExecute).set_TabIndex(0);
		((Control)textBoxExecute).add_KeyDown(new KeyEventHandler(textBoxExecute_KeyDown));
		((Control)textBoxConsole).set_Anchor((AnchorStyles)15);
		((Control)textBoxConsole).set_BackColor(Color.Black);
		((Control)textBoxConsole).set_ForeColor(Color.Tan);
		((Control)textBoxConsole).set_Location(new Point(8, 6));
		((TextBoxBase)textBoxConsole).set_Multiline(true);
		((Control)textBoxConsole).set_Name("textBoxConsole");
		((TextBoxBase)textBoxConsole).set_ReadOnly(true);
		textBoxConsole.set_ScrollBars((ScrollBars)2);
		((Control)textBoxConsole).set_Size(new Size(505, 429));
		((Control)textBoxConsole).set_TabIndex(2);
		((TextBoxBase)textBoxConsole).set_WordWrap(false);
		((Control)textBoxConsole).add_KeyDown(new KeyEventHandler(textBoxConsole_KeyDown));
		((Control)tabPagePlayers).get_Controls().Add((Control)(object)groupBoxMatch);
		((Control)tabPagePlayers).get_Controls().Add((Control)(object)groupBoxPlayers);
		tabPagePlayers.set_Location(new Point(4, 22));
		((Control)tabPagePlayers).set_Name("tabPagePlayers");
		((Control)tabPagePlayers).set_Padding(new Padding(3));
		((Control)tabPagePlayers).set_Size(new Size(650, 467));
		tabPagePlayers.set_TabIndex(3);
		((Control)tabPagePlayers).set_Text("Players");
		tabPagePlayers.set_UseVisualStyleBackColor(true);
		((Control)groupBoxMatch).set_Anchor((AnchorStyles)14);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)labelMap);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)labelM);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)labelState);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)textBoxAll);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)labelMatch);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)listViewTeams);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)buttonSay);
		((Control)groupBoxMatch).get_Controls().Add((Control)(object)textBoxSay);
		((Control)groupBoxMatch).set_Location(new Point(8, 329));
		((Control)groupBoxMatch).set_Name("groupBoxMatch");
		((Control)groupBoxMatch).set_Size(new Size(634, 135));
		((Control)groupBoxMatch).set_TabIndex(4);
		groupBoxMatch.set_TabStop(false);
		((Control)groupBoxMatch).set_Text("Match");
		((Control)labelMap).set_Anchor((AnchorStyles)10);
		((Control)labelMap).set_AutoSize(true);
		((Control)labelMap).set_Location(new Point(408, 40));
		((Control)labelMap).set_Name("labelMap");
		((Control)labelMap).set_Size(new Size(0, 13));
		((Control)labelMap).set_TabIndex(14);
		((Control)labelM).set_Anchor((AnchorStyles)10);
		((Control)labelM).set_AutoSize(true);
		((Control)labelM).set_Location(new Point(362, 40));
		((Control)labelM).set_Name("labelM");
		((Control)labelM).set_Size(new Size(43, 13));
		((Control)labelM).set_TabIndex(13);
		((Control)labelM).set_Text("Map    :");
		((Control)labelState).set_Anchor((AnchorStyles)10);
		((Control)labelState).set_AutoSize(true);
		((Control)labelState).set_Location(new Point(362, 22));
		((Control)labelState).set_Name("labelState");
		((Control)labelState).set_Size(new Size(43, 13));
		((Control)labelState).set_TabIndex(11);
		((Control)labelState).set_Text("Status :");
		((Control)textBoxAll).set_Anchor((AnchorStyles)14);
		((Control)textBoxAll).set_BackColor(SystemColors.Window);
		((Control)textBoxAll).set_ForeColor(SystemColors.WindowText);
		((Control)textBoxAll).set_Location(new Point(6, 19));
		((TextBoxBase)textBoxAll).set_Multiline(true);
		((Control)textBoxAll).set_Name("textBoxAll");
		((TextBoxBase)textBoxAll).set_ReadOnly(true);
		textBoxAll.set_ScrollBars((ScrollBars)2);
		((Control)textBoxAll).set_Size(new Size(346, 80));
		((Control)textBoxAll).set_TabIndex(8);
		((TextBoxBase)textBoxAll).set_WordWrap(false);
		((Control)textBoxAll).add_KeyDown(new KeyEventHandler(textBoxAll_KeyDown));
		((Control)labelMatch).set_Anchor((AnchorStyles)10);
		((Control)labelMatch).set_AutoSize(true);
		((Control)labelMatch).set_Location(new Point(408, 22));
		((Control)labelMatch).set_Name("labelMatch");
		((Control)labelMatch).set_Size(new Size(0, 13));
		((Control)labelMatch).set_TabIndex(12);
		listViewTeams.set_AllowColumnReorder(true);
		((Control)listViewTeams).set_Anchor((AnchorStyles)10);
		listViewTeams.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeaderTeamName, columnHeaderTeamScore });
		listViewTeams.set_FullRowSelect(true);
		listViewTeams.set_GridLines(true);
		((Control)listViewTeams).set_Location(new Point(362, 65));
		listViewTeams.set_MultiSelect(false);
		((Control)listViewTeams).set_Name("listViewTeams");
		listViewTeams.set_Scrollable(false);
		((Control)listViewTeams).set_Size(new Size(266, 60));
		listViewTeams.set_SmallImageList(imageListMulti);
		((Control)listViewTeams).set_TabIndex(15);
		listViewTeams.set_UseCompatibleStateImageBehavior(false);
		listViewTeams.set_View((View)1);
		listViewTeams.add_ColumnClick(new ColumnClickEventHandler(listViewTeams_ColumnClick));
		columnHeaderTeamName.set_Text("Team");
		columnHeaderTeamName.set_Width(135);
		columnHeaderTeamScore.set_Text("Score");
		imageListMulti.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("imageListMulti.ImageStream"));
		imageListMulti.set_TransparentColor(Color.Transparent);
		imageListMulti.get_Images().SetKeyName(0, "icon_ready.png");
		imageListMulti.get_Images().SetKeyName(1, "base_apr.png");
		imageListMulti.get_Images().SetKeyName(2, "base_ufll.png");
		imageListMulti.get_Images().SetKeyName(3, "star.png");
		imageListMulti.get_Images().SetKeyName(4, "star_apr.png");
		imageListMulti.get_Images().SetKeyName(5, "star_ufll.png");
		((Control)buttonSay).set_Anchor((AnchorStyles)10);
		((Control)buttonSay).set_Location(new Point(279, 103));
		((Control)buttonSay).set_Name("buttonSay");
		((Control)buttonSay).set_Size(new Size(75, 23));
		((Control)buttonSay).set_TabIndex(10);
		((Control)buttonSay).set_Text("Say");
		((ButtonBase)buttonSay).set_UseVisualStyleBackColor(true);
		((Control)buttonSay).add_Click((EventHandler)buttonSay_Click);
		((Control)textBoxSay).set_Anchor((AnchorStyles)14);
		((Control)textBoxSay).set_Location(new Point(6, 105));
		((Control)textBoxSay).set_Name("textBoxSay");
		((Control)textBoxSay).set_Size(new Size(267, 20));
		((Control)textBoxSay).set_TabIndex(9);
		((Control)textBoxSay).add_KeyDown(new KeyEventHandler(textBoxSay_KeyDown));
		((Control)groupBoxPlayers).set_Anchor((AnchorStyles)15);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)buttonKick);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)buttonVoteKick);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)label1);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)textBoxChat);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)propertyGridPlayers);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)buttonTell);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)listViewPlayers);
		((Control)groupBoxPlayers).get_Controls().Add((Control)(object)textBoxTell);
		((Control)groupBoxPlayers).set_Location(new Point(8, 6));
		((Control)groupBoxPlayers).set_Name("groupBoxPlayers");
		((Control)groupBoxPlayers).set_Size(new Size(634, 317));
		((Control)groupBoxPlayers).set_TabIndex(1);
		groupBoxPlayers.set_TabStop(false);
		((Control)groupBoxPlayers).set_Text("Players");
		((Control)buttonKick).set_Anchor((AnchorStyles)10);
		((Control)buttonKick).set_Location(new Point(553, 286));
		((Control)buttonKick).set_Name("buttonKick");
		((Control)buttonKick).set_Size(new Size(75, 23));
		((Control)buttonKick).set_TabIndex(7);
		((Control)buttonKick).set_Text("Kick");
		((ButtonBase)buttonKick).set_UseVisualStyleBackColor(true);
		((Control)buttonKick).add_Click((EventHandler)buttonKick_Click);
		((Control)buttonVoteKick).set_Anchor((AnchorStyles)10);
		((Control)buttonVoteKick).set_Location(new Point(472, 286));
		((Control)buttonVoteKick).set_Name("buttonVoteKick");
		((Control)buttonVoteKick).set_Size(new Size(75, 23));
		((Control)buttonVoteKick).set_TabIndex(6);
		((Control)buttonVoteKick).set_Text("Vote to Kick");
		((ButtonBase)buttonVoteKick).set_UseVisualStyleBackColor(true);
		((Control)buttonVoteKick).add_Click((EventHandler)buttonVoteKick_Click);
		((Control)label1).set_Anchor((AnchorStyles)9);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(359, 214));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(29, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Chat");
		((Control)textBoxChat).set_Anchor((AnchorStyles)11);
		((Control)textBoxChat).set_BackColor(SystemColors.Window);
		((Control)textBoxChat).set_ForeColor(SystemColors.WindowText);
		((Control)textBoxChat).set_Location(new Point(358, 231));
		((TextBoxBase)textBoxChat).set_Multiline(true);
		((Control)textBoxChat).set_Name("textBoxChat");
		((TextBoxBase)textBoxChat).set_ReadOnly(true);
		((Control)textBoxChat).set_Size(new Size(270, 52));
		((Control)textBoxChat).set_TabIndex(3);
		((TextBoxBase)textBoxChat).set_WordWrap(false);
		((Control)textBoxChat).add_KeyDown(new KeyEventHandler(textBoxChat_KeyDown));
		((Control)propertyGridPlayers).set_Anchor((AnchorStyles)9);
		propertyGridPlayers.set_HelpVisible(false);
		((Control)propertyGridPlayers).set_Location(new Point(358, 20));
		((Control)propertyGridPlayers).set_Name("propertyGridPlayers");
		propertyGridPlayers.set_PropertySort((PropertySort)2);
		((Control)propertyGridPlayers).set_Size(new Size(270, 190));
		((Control)propertyGridPlayers).set_TabIndex(1);
		propertyGridPlayers.set_ToolbarVisible(false);
		((Control)buttonTell).set_Anchor((AnchorStyles)10);
		((Control)buttonTell).set_Location(new Point(279, 287));
		((Control)buttonTell).set_Name("buttonTell");
		((Control)buttonTell).set_Size(new Size(73, 23));
		((Control)buttonTell).set_TabIndex(5);
		((Control)buttonTell).set_Text("Tell");
		((ButtonBase)buttonTell).set_UseVisualStyleBackColor(true);
		((Control)buttonTell).add_Click((EventHandler)buttonTell_Click);
		((Control)textBoxTell).set_Anchor((AnchorStyles)14);
		((Control)textBoxTell).set_Location(new Point(7, 289));
		((Control)textBoxTell).set_Name("textBoxTell");
		((Control)textBoxTell).set_Size(new Size(266, 20));
		((Control)textBoxTell).set_TabIndex(4);
		((Control)textBoxTell).add_KeyDown(new KeyEventHandler(textBoxTell_KeyDown));
		((Control)tabPageOptions).get_Controls().Add((Control)(object)buttonGoToLog);
		((Control)tabPageOptions).get_Controls().Add((Control)(object)buttonDeleteAll);
		((Control)tabPageOptions).get_Controls().Add((Control)(object)textBoxLogSize);
		((Control)tabPageOptions).get_Controls().Add((Control)(object)label5);
		((Control)tabPageOptions).get_Controls().Add((Control)(object)propertyGridOptions);
		tabPageOptions.set_Location(new Point(4, 22));
		((Control)tabPageOptions).set_Name("tabPageOptions");
		((Control)tabPageOptions).set_Padding(new Padding(3));
		((Control)tabPageOptions).set_Size(new Size(650, 467));
		tabPageOptions.set_TabIndex(2);
		((Control)tabPageOptions).set_Text("Options");
		tabPageOptions.set_UseVisualStyleBackColor(true);
		((Control)buttonGoToLog).set_Anchor((AnchorStyles)9);
		((Control)buttonGoToLog).set_Location(new Point(530, 29));
		((Control)buttonGoToLog).set_Name("buttonGoToLog");
		((Control)buttonGoToLog).set_Size(new Size(92, 23));
		((Control)buttonGoToLog).set_TabIndex(8);
		((Control)buttonGoToLog).set_Text("Go to logs");
		((ButtonBase)buttonGoToLog).set_UseVisualStyleBackColor(true);
		((Control)buttonGoToLog).add_Click((EventHandler)buttonGoToLog_Click);
		((Control)buttonDeleteAll).set_Anchor((AnchorStyles)9);
		((Control)buttonDeleteAll).set_Location(new Point(530, 123));
		((Control)buttonDeleteAll).set_Name("buttonDeleteAll");
		((Control)buttonDeleteAll).set_Size(new Size(92, 23));
		((Control)buttonDeleteAll).set_TabIndex(11);
		((Control)buttonDeleteAll).set_Text("Delete all");
		((ButtonBase)buttonDeleteAll).set_UseVisualStyleBackColor(true);
		((Control)buttonDeleteAll).add_Click((EventHandler)buttonDeleteAll_Click);
		((Control)textBoxLogSize).set_Anchor((AnchorStyles)9);
		((Control)textBoxLogSize).set_Location(new Point(530, 84));
		((Control)textBoxLogSize).set_Name("textBoxLogSize");
		((TextBoxBase)textBoxLogSize).set_ReadOnly(true);
		((Control)textBoxLogSize).set_Size(new Size(92, 20));
		((Control)textBoxLogSize).set_TabIndex(10);
		((Control)textBoxLogSize).set_Text("0 MB");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(527, 68));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(46, 13));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("Log files");
		((Control)propertyGridOptions).set_Anchor((AnchorStyles)15);
		((Control)propertyGridOptions).set_Location(new Point(3, 3));
		((Control)propertyGridOptions).set_Name("propertyGridOptions");
		((Control)propertyGridOptions).set_Size(new Size(500, 458));
		((Control)propertyGridOptions).set_TabIndex(0);
		propertyGridOptions.add_PropertyValueChanged(new PropertyValueChangedEventHandler(propertyGridOptions_PropertyValueChanged));
		timerPlayersUpdate.set_Interval(5000);
		timerPlayersUpdate.add_Tick((EventHandler)timerPlayersUpdate_Tick);
		((Control)pictureBoxTitle).set_Anchor((AnchorStyles)7);
		((Control)pictureBoxTitle).set_BackColor(Color.FromArgb(47, 47, 47));
		((Control)pictureBoxTitle).set_Location(new Point(0, 28));
		((Control)pictureBoxTitle).set_Name("pictureBoxTitle");
		((Control)pictureBoxTitle).set_Size(new Size(65, 492));
		pictureBoxTitle.set_TabIndex(7);
		pictureBoxTitle.set_TabStop(false);
		pictureBoxFC2.set_Image((Image)(object)Resources.title1);
		((Control)pictureBoxFC2).set_Location(new Point(0, 27));
		((Control)pictureBoxFC2).set_Name("pictureBoxFC2");
		((Control)pictureBoxFC2).set_Size(new Size(65, 241));
		pictureBoxFC2.set_TabIndex(8);
		pictureBoxFC2.set_TabStop(false);
		((Control)emptyControl).set_AutoSize(true);
		((Control)emptyControl).set_Location(new Point(588, 268));
		((Control)emptyControl).set_Name("emptyControl");
		((Control)emptyControl).set_Size(new Size(0, 13));
		((Control)emptyControl).set_TabIndex(8);
		((Control)emptyControl).set_Visible(false);
		((ListView)listViewPlayers).set_AllowColumnReorder(true);
		((Control)listViewPlayers).set_Anchor((AnchorStyles)15);
		((ListView)listViewPlayers).get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[4] { columnHeaderName, columnHeaderScore, columnHeaderTeam, columnHeaderVIP });
		((ListView)listViewPlayers).set_FullRowSelect(true);
		((ListView)listViewPlayers).set_GridLines(true);
		((ListView)listViewPlayers).set_HideSelection(false);
		((Control)listViewPlayers).set_Location(new Point(7, 20));
		((ListView)listViewPlayers).set_MultiSelect(false);
		((Control)listViewPlayers).set_Name("listViewPlayers");
		((Control)listViewPlayers).set_Size(new Size(345, 263));
		((ListView)listViewPlayers).set_SmallImageList(imageListMulti);
		((Control)listViewPlayers).set_TabIndex(0);
		((ListView)listViewPlayers).set_UseCompatibleStateImageBehavior(false);
		((ListView)listViewPlayers).set_View((View)1);
		((ListView)listViewPlayers).add_SelectedIndexChanged((EventHandler)listViewPlayers_SelectedIndexChanged);
		((ListView)listViewPlayers).add_ColumnClick(new ColumnClickEventHandler(listViewPlayers_ColumnClick));
		columnHeaderName.set_Text("Name");
		columnHeaderName.set_Width(120);
		columnHeaderScore.set_Text("Score");
		columnHeaderTeam.set_Text("Team");
		columnHeaderVIP.set_Text("Captain");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(729, 545));
		((Control)this).get_Controls().Add((Control)(object)pictureBoxFC2);
		((Control)this).get_Controls().Add((Control)(object)pictureBoxTitle);
		((Control)this).get_Controls().Add((Control)(object)statusStripMain);
		((Control)this).get_Controls().Add((Control)(object)menuStripMain);
		((Control)this).get_Controls().Add((Control)(object)tabControlMain);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuStripMain);
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("Far Cry® 2 Server Launcher");
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainForm_FormClosing));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)statusStripMain).ResumeLayout(false);
		((Control)statusStripMain).PerformLayout();
		((Control)menuStripMain).ResumeLayout(false);
		((Control)menuStripMain).PerformLayout();
		((Control)tabPageConfig).ResumeLayout(false);
		((Control)tabPageConfig).PerformLayout();
		((Control)tabControlMain).ResumeLayout(false);
		((Control)tabPageConsole).ResumeLayout(false);
		((Control)tabPageConsole).PerformLayout();
		((Control)tabPagePlayers).ResumeLayout(false);
		((Control)groupBoxMatch).ResumeLayout(false);
		((Control)groupBoxMatch).PerformLayout();
		((Control)groupBoxPlayers).ResumeLayout(false);
		((Control)groupBoxPlayers).PerformLayout();
		((Control)tabPageOptions).ResumeLayout(false);
		((Control)tabPageOptions).PerformLayout();
		((ISupportInitialize)pictureBoxTitle).EndInit();
		((ISupportInitialize)pictureBoxFC2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
