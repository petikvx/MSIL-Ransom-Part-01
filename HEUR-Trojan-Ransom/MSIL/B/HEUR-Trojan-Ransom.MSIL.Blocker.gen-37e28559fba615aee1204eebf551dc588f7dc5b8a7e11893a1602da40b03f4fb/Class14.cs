using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

internal class Class14
{
	private static Hashtable hashtable_0;

	private static Hashtable hashtable_1;

	private static bool bool_0;

	internal static void lLHifFIsCLsZtjvFfN0i()
	{
		if (!bool_0)
		{
			bool_0 = true;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += smethod_0;
		}
	}

	private static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		lock (hashtable_0)
		{
			string text = resolveEventArgs_0.Name.Trim();
			object obj = hashtable_0[text];
			if (obj == null)
			{
				try
				{
					string text2 = smethod_1(text);
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					Assembly[] array = assemblies;
					foreach (Assembly assembly in array)
					{
						if (assembly.GetName().Name!.ToUpper() == text2.ToUpper())
						{
							return assembly;
						}
					}
				}
				catch
				{
				}
			}
			if (obj == null)
			{
				try
				{
					RSACryptoServiceProvider.UseMachineKeyStore = true;
					string text3 = smethod_1(text);
					byte[] bytes = Encoding.Unicode.GetBytes(text3);
					string text4 = "b0494a1f-4bd3-" + Convert.ToBase64String(Class10.smethod_9(bytes));
					Stream manifestResourceStream = typeof(Class14).Assembly.GetManifestResourceStream(text4);
					if (manifestResourceStream != null)
					{
						try
						{
							BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
							binaryReader.BaseStream.Position = 0L;
							byte[] array2 = new byte[manifestResourceStream.Length];
							binaryReader.Read(array2, 0, array2.Length);
							binaryReader.Close();
							bool flag = false;
							Assembly assembly2 = null;
							try
							{
								assembly2 = Assembly.Load(array2);
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
								string path = Path.Combine(Path.GetTempPath(), text4);
								string text5 = Path.Combine(path, text3 + ".dll");
								if (!File.Exists(text5) || !hashtable_1.ContainsKey(text5))
								{
									try
									{
										hashtable_1[text5] = null;
										if (!Directory.Exists(Path.GetDirectoryName(text5)))
										{
											Directory.CreateDirectory(Path.GetDirectoryName(text5));
										}
										FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
										fileStream.Write(array2, 0, array2.Length);
										fileStream.Close();
									}
									catch
									{
									}
								}
								assembly2 = Assembly.LoadFile(text5);
								hashtable_0.Add(text, assembly2);
							}
							else
							{
								hashtable_0.Add(text, assembly2);
							}
							return assembly2;
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				return null;
			}
			return (Assembly)obj;
		}
	}

	private static string smethod_1(string string_0)
	{
		string text = string_0.Trim();
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	static Class14()
	{
		hashtable_0 = new Hashtable();
		hashtable_1 = new Hashtable();
		bool_0 = false;
	}
}
