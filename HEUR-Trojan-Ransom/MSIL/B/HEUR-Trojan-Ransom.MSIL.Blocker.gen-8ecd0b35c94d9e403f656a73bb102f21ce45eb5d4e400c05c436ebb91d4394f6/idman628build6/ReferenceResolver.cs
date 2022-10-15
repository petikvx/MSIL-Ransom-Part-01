using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace idman628build6;

internal class ReferenceResolver
{
	private static readonly Hashtable versionCollection = new Hashtable();

	private static readonly Hashtable previousData = new Hashtable();

	internal static void DisableDrive()
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
								byte[] array3 = AssistantTable.DisableDrive(97L, manifestResourceStream);
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
					previousData[array2[j]] = array2[j + 1];
				}
			}
		}
		AppDomain.CurrentDomain.AssemblyResolve += DisableDrive;
	}

	private static string DisableDrive(byte[] versionCollection, string previousData, string queryLength, string dataDisposed)
	{
		previousData = Path.Combine(Path.GetTempPath(), previousData);
		string text = Path.Combine(previousData, queryLength + dataDisposed);
		if (!File.Exists(text))
		{
			Directory.CreateDirectory(previousData);
			FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
			fileStream.Write(versionCollection, 0, versionCollection.Length);
			fileStream.Close();
		}
		return text;
	}

	private static Assembly DisableDrive(object versionCollection, ResolveEventArgs previousData)
	{
		lock (ReferenceResolver.versionCollection)
		{
			Assembly assembly = null;
			string name = previousData.Name;
			string text = string.Empty;
			foreach (string key in ReferenceResolver.previousData.Keys)
			{
				if (key.StartsWith(name))
				{
					assembly = ReferenceResolver.versionCollection[key] as Assembly;
					if ((object)assembly != null)
					{
						return assembly;
					}
					text = ReferenceResolver.previousData[key] as string;
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
			byte[] rawAssembly = AssistantTable.DisableDrive(97L, manifestResourceStream);
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
						array = AssistantTable.DisableDrive(97L, manifestResourceStream2);
					}
				}
			}
			catch (Exception)
			{
			}
			bool flag = false;
			try
			{
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
				string queryLength = DisableDrive(name);
				string path = DisableDrive(rawAssembly, text, queryLength, ".dll");
				if (array != null)
				{
					DisableDrive(rawAssembly, text, queryLength, ".pdb");
				}
				assembly = Assembly.LoadFile(path);
			}
			ReferenceResolver.versionCollection[name] = assembly;
			return assembly;
		}
	}

	private static string DisableDrive(string versionCollection)
	{
		int num = versionCollection.IndexOf(',');
		if (num >= 0)
		{
			versionCollection = versionCollection.Substring(0, num);
		}
		return versionCollection;
	}
}
