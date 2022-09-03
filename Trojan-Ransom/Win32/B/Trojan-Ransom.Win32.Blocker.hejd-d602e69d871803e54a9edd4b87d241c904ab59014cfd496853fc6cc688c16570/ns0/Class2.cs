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
								byte[] array3 = Class7.smethod_0(manifestResourceStream);
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
		AppDomain.CurrentDomain.AssemblyResolve += smethod_1;
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly assembly = null;
		string name = resolveEventArgs_0.Name;
		string text = string.Empty;
		foreach (string key in hashtable_1.Keys)
		{
			if (key.StartsWith(name))
			{
				if (hashtable_0[key] is Assembly result)
				{
					return result;
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
		byte[] rawAssembly = Class7.smethod_0(manifestResourceStream);
		byte[] array = null;
		try
		{
			text += "#";
			string[] manifestResourceNames2 = executingAssembly.GetManifestResourceNames();
			foreach (string text4 in manifestResourceNames2)
			{
				if (text4 == text)
				{
					Stream manifestResourceStream2 = executingAssembly.GetManifestResourceStream(text4);
					array = Class7.smethod_0(manifestResourceStream2);
				}
			}
		}
		catch (Exception)
		{
		}
		if (array == null)
		{
			assembly = Assembly.Load(rawAssembly);
		}
		else
		{
			try
			{
				assembly = Assembly.Load(rawAssembly, array);
			}
			catch (Exception)
			{
				assembly = Assembly.Load(rawAssembly);
			}
		}
		hashtable_0[name] = assembly;
		return assembly;
	}
}
