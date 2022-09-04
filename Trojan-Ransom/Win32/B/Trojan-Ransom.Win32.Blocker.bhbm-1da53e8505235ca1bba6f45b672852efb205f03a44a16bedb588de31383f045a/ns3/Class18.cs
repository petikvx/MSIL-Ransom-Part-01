using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ns7;

namespace ns3;

internal class Class18
{
	internal struct Struct17
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool includeVersion)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			if (includeVersion && version_0 != null)
			{
				stringBuilder.Append(", Version=");
				stringBuilder.Append(version_0);
			}
			stringBuilder.Append(", Culture=");
			stringBuilder.Append((string_1.Length == 0) ? "neutral" : string_1);
			stringBuilder.Append(", PublicKeyToken=");
			stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
			return stringBuilder.ToString();
		}

		public Struct17(string assemblyFullName)
		{
			version_0 = null;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_0 = string.Empty;
			string[] array = assemblyFullName.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith("Version="))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith("Culture="))
				{
					string_1 = text2.Substring(8);
					if (string_1 == "neutral")
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith("PublicKeyToken="))
				{
					string_2 = text2.Substring(15);
					if (string_2 == "null")
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text2;
				}
			}
		}
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int int_0 = 4;

	private static Hashtable hashtable_0 = new Hashtable();

	internal static bool IsWebApplication
	{
		get
		{
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == "w3wp.exe")
				{
					return true;
				}
				if (text == "aspnet_wp.exe")
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}
	}

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += smethod_1;
		}
		catch
		{
		}
	}

	internal static Assembly smethod_1(object sender, ResolveEventArgs e)
	{
		Struct17 @struct = new Struct17(e.Name);
		string s = @struct.method_0(includeVersion: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2QxNWQ5YmYwLTVmMWEtNDVkNC1hMzkxLTRlMTJhMDRlMTVkM30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{7f3fc4a5-70f1-4d06-9253-97479e58b748}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (hashtable_0)
			{
				if (hashtable_0.ContainsKey(text2))
				{
					return (Assembly)hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class24.smethod_1(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								MoveFileEx(text5, null, 4);
								MoveFileEx(text4, null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}
}
