using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

internal class Class2
{
	public static string smethod_0(string string_0)
	{
		string text = "";
		try
		{
			for (string text2 = smethod_4(ref string_0, " "); text2 != null; text2 = smethod_4(ref string_0, " "))
			{
				int num = int.Parse(text2);
				num = num / 3 - 7;
				text += (char)num;
			}
		}
		catch
		{
		}
		return text;
	}

	public static int smethod_1(string[,] string_0, string string_1)
	{
		try
		{
			int length = string_0.GetLength(0);
			int length2 = string_0.GetLength(1);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (string_0[i, j] == string_1)
					{
						return i;
					}
				}
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	public static string smethod_2(string string_0)
	{
		WebRequest webRequest = WebRequest.Create(string_0);
		WebResponse response = webRequest.GetResponse();
		Stream responseStream = response.GetResponseStream();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		StreamReader streamReader = new StreamReader(responseStream, encoding);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		response.Close();
		return result;
	}

	public static string smethod_3(string string_0, string string_1, string string_2)
	{
		if (string_0.Contains(string_1))
		{
			string_0 = string_0.Substring(string_0.IndexOf(string_1) + string_1.Length);
			if (string_0.Contains(string_2))
			{
				string_0 = string_0.Substring(0, string_0.IndexOf(string_2));
				return string_0;
			}
		}
		return "";
	}

	public static string smethod_4(ref string string_0, string string_1)
	{
		string result = string_0;
		try
		{
			result = string_0.Substring(0, string_0.IndexOf(string_1));
			string_0 = string_0.Substring(string_0.IndexOf(string_1) + string_1.Length);
		}
		catch
		{
		}
		return result;
	}

	public static int smethod_5(string string_0, string string_1)
	{
		int num = -1;
		int num2 = 0;
		for (num = string_0.IndexOf(string_1); num != -1; num = string_0.IndexOf(string_1))
		{
			num2++;
			string_0 = string_0.Substring(num + 1);
		}
		return num2;
	}

	public static bool smethod_6(string string_0)
	{
		int num = smethod_5(string_0, ".");
		if (num != 3)
		{
			return false;
		}
		if (string_0[string_0.Length - 1] == '.')
		{
			return false;
		}
		for (int i = 0; i < 3; i++)
		{
			try
			{
				num = Convert.ToInt32(smethod_4(ref string_0, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static bool smethod_7(string string_0)
	{
		try
		{
			Convert.ToInt32(string_0);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool smethod_8(string string_0)
	{
		if (string_0[string_0.Length - 1] == '.')
		{
			return false;
		}
		int num = smethod_5(string_0, ".");
		for (int i = 0; i < num; i++)
		{
			try
			{
				Convert.ToInt32(smethod_4(ref string_0, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static int smethod_9(ArrayList arrayList_0, string string_0)
	{
		if (!arrayList_0.Contains(string_0))
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < arrayList_0.Count)
			{
				if (arrayList_0[num]!.ToString() == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private static string smethod_10(int[] int_0)
	{
		return int_0[0].ToString() + '.' + int_0[1].ToString() + '.' + int_0[2].ToString() + '.' + int_0[3].ToString();
	}

	public static string smethod_11(string string_0)
	{
		int[] array = smethod_12(string_0);
		if (array[3] >= 255)
		{
			array[3] = 1;
			array[2]++;
			if (array[2] >= 255)
			{
				array[2] = 1;
				array[1]++;
				if (array[1] >= 255)
				{
					array[1] = 1;
					array[0]++;
				}
			}
		}
		else
		{
			array[3]++;
		}
		return smethod_10(array);
	}

	private static int[] smethod_12(string string_0)
	{
		string_0 += '.';
		int[] array = new int[4];
		int num = string_0.IndexOf('.');
		for (int i = 0; i < 4; i++)
		{
			array[i] = Convert.ToInt32(string_0.Substring(0, num));
			string_0 = string_0.Substring(num + 1);
			num = string_0.IndexOf('.');
		}
		return array;
	}

	public static bool smethod_13(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.StartsWith(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		process.Kill();
		return true;
	}

	public static bool smethod_14(string string_0)
	{
		bool flag = false;
		Process[] processesByName = Process.GetProcessesByName(string_0);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			flag = true;
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_15(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		Process[] array = processesByName;
		if (0 >= array.Length)
		{
			return false;
		}
		return true;
	}

	public static string smethod_16(string string_0)
	{
		int num = string_0.LastIndexOf('\\');
		if (num == -1)
		{
			return string_0;
		}
		string_0 = string_0.Substring(num + 1);
		if (string_0[string_0.Length - 4] == '.')
		{
			string_0 = string_0.Substring(0, string_0.Length - 4);
		}
		return string_0;
	}
}
