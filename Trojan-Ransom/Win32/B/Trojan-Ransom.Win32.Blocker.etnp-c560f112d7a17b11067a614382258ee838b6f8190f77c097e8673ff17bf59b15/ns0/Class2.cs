using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace ns0;

internal class Class2
{
	private static readonly Hashtable hashtable_0 = new Hashtable();

	private static readonly Hashtable hashtable_1 = new Hashtable();

	internal static void smethod_0()
	{
		string text = "";
		char[] array = text.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(~(uint)array[i]);
		}
		text = new string(array);
		string[] array2 = text.Split(new string[1] { "##" }, StringSplitOptions.RemoveEmptyEntries);
		if (array2 != null && array2.Length >= 0)
		{
			for (int j = 0; j < array2.Length; j += 2)
			{
				if (array2[j + 1].StartsWith("~"))
				{
					try
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						string path = Path.Combine(Path.GetDirectoryName(executingAssembly.Location), array2[j]);
						if (File.Exists(path))
						{
							continue;
						}
						string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
						foreach (string text2 in manifestResourceNames)
						{
							if (text2 == array2[j + 1])
							{
								Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text2);
								byte[] array3 = Class19.smethod_3(97L, manifestResourceStream);
								using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
								{
									fileStream.Write(array3, 0, array3.Length);
								}
								manifestResourceStream.Close();
							}
						}
					}
					catch
					{
					}
				}
				else
				{
					hashtable_1[array2[j]] = array2[j + 1];
				}
			}
		}
		AppDomain.CurrentDomain.AssemblyResolve += smethod_2;
	}

	private static string smethod_1(byte[] byte_0, string string_0, string string_1, string string_2)
	{
		string_0 = Path.Combine(Path.GetTempPath(), string_0);
		string text = Path.Combine(string_0, string_1 + string_2);
		if (!File.Exists(text))
		{
			Directory.CreateDirectory(string_0);
			FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Close();
		}
		return text;
	}

	private static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		lock (hashtable_0)
		{
			Assembly assembly = null;
			string name = resolveEventArgs_0.Name;
			string text = string.Empty;
			foreach (string key in hashtable_1.Keys)
			{
				if (key.StartsWith(name))
				{
					assembly = hashtable_0[key] as Assembly;
					if ((object)assembly != null)
					{
						return assembly;
					}
					text = hashtable_1[key] as string;
					break;
				}
			}
			if (text.Length == 0)
			{
				return null;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			int num = 0;
			string text3;
			while (true)
			{
				if (num < manifestResourceNames.Length)
				{
					text3 = manifestResourceNames[num];
					if (text3 == text)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text3);
			byte[] array = Class19.smethod_3(97L, manifestResourceStream);
			byte[] array2 = null;
			try
			{
				text += "#";
				string[] manifestResourceNames2 = executingAssembly.GetManifestResourceNames();
				foreach (string text4 in manifestResourceNames2)
				{
					if (text4 == text)
					{
						Stream manifestResourceStream2 = executingAssembly.GetManifestResourceStream(text4);
						array2 = Class19.smethod_3(97L, manifestResourceStream2);
					}
				}
			}
			catch (Exception)
			{
			}
			bool flag = false;
			try
			{
				if (array2 == null)
				{
					assembly = Assembly.Load(array);
				}
				else
				{
					try
					{
						assembly = Assembly.Load(array, array2);
					}
					catch (Exception)
					{
						assembly = Assembly.Load(array);
					}
				}
			}
			catch (FileLoadException)
			{
				flag = true;
			}
			catch (BadImageFormatException)
			{
				flag = true;
			}
			if (flag)
			{
				string string_ = smethod_3(name);
				string path = smethod_1(array, text, string_, ".dll");
				if (array2 != null)
				{
					smethod_1(array, text, string_, ".pdb");
				}
				assembly = Assembly.LoadFile(path);
			}
			hashtable_0[name] = assembly;
			return assembly;
		}
	}

	private static string smethod_3(string string_0)
	{
		int num = string_0.IndexOf(',');
		if (num >= 0)
		{
			string_0 = string_0.Substring(0, num);
		}
		return string_0;
	}
}
