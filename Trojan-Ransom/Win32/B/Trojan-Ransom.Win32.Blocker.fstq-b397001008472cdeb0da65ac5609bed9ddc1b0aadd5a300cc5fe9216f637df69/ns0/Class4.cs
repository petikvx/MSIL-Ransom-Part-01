using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ns0;

internal class Class4
{
	private static readonly Hashtable hashtable_0 = new Hashtable();

	private static readonly Hashtable hashtable_1 = new Hashtable();

	internal static void smethod_0()
	{
		string text = default(string);
		char[] array = default(char[]);
		int i = default(int);
		char[] array2 = default(char[]);
		string[] array3 = default(string[]);
		int j = default(int);
		Assembly executingAssembly = default(Assembly);
		string text3 = default(string);
		string[] manifestResourceNames = default(string[]);
		int k = default(int);
		string text4 = default(string);
		Stream manifestResourceStream = default(Stream);
		byte[] array4 = default(byte[]);
		FileStream fileStream = default(FileStream);
		try
		{
			text = "";
			array = text.ToCharArray();
			for (i = 0; i < array.Length; i++)
			{
				array[i] = (char)(~(uint)array[i]);
			}
			text = new string(array);
			string text2 = text;
			array2 = new char[1] { '`' };
			array3 = text2.Split(array2);
			if (array3 != null && array3.Length >= 0)
			{
				for (j = 0; j < array3.Length; j += 2)
				{
					if (array3[j + 1].StartsWith("~"))
					{
						try
						{
							executingAssembly = Assembly.GetExecutingAssembly();
							text3 = Path.Combine(Path.GetDirectoryName(executingAssembly.Location), array3[j]);
							if (File.Exists(text3))
							{
								continue;
							}
							manifestResourceNames = executingAssembly.GetManifestResourceNames();
							for (k = 0; k < manifestResourceNames.Length; k++)
							{
								text4 = manifestResourceNames[k];
								if (text4 == array3[j + 1])
								{
									manifestResourceStream = executingAssembly.GetManifestResourceStream(text4);
									array4 = Class21.smethod_3(97L, manifestResourceStream);
									fileStream = new FileStream(text3, FileMode.Create, FileAccess.Write);
									try
									{
										fileStream.Write(array4, 0, array4.Length);
									}
									finally
									{
										((IDisposable)fileStream)?.Dispose();
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
						hashtable_1[array3[j]] = array3[j + 1];
					}
				}
			}
			AppDomain.CurrentDomain.AssemblyResolve += smethod_3;
		}
		catch (Exception exception_)
		{
			Class15.smethod_33(exception_, new object[14]
			{
				text, array, i, array3, j, executingAssembly, text3, text4, manifestResourceStream, array4,
				fileStream, array2, manifestResourceNames, k
			});
			throw;
		}
	}

	private static string smethod_1(byte[] byte_0, string string_0, string string_1, string string_2)
	{
		string text = default(string);
		FileStream fileStream = default(FileStream);
		try
		{
			string_0 = Path.Combine(Path.GetTempPath(), string_0);
			text = Path.Combine(string_0, string_1 + string_2);
			if (!File.Exists(text))
			{
				Directory.CreateDirectory(string_0);
				fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
				fileStream.Write(byte_0, 0, byte_0.Length);
				fileStream.Close();
			}
			return text;
		}
		catch (Exception exception_)
		{
			Class15.smethod_28(exception_, byte_0, string_0, string_1, string_2, text, fileStream);
			throw;
		}
	}

	private static bool smethod_2(string string_0, string string_1)
	{
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		char[] array3 = default(char[]);
		string[] array4 = default(string[]);
		int i = default(int);
		int j = default(int);
		string[] array5 = default(string[]);
		int num = default(int);
		string text = default(string);
		bool flag = default(bool);
		int k = default(int);
		bool flag2 = default(bool);
		try
		{
			try
			{
				array = new char[1] { ',' };
				array2 = string_0.Split(array);
				array3 = new char[1] { ',' };
				array4 = string_1.Split(array3);
				for (i = 0; i < array2.Length; i++)
				{
					array2[i] = array2[i].Trim();
				}
				for (j = 0; j < array4.Length; j++)
				{
					array4[j] = array4[j].Trim();
				}
				array5 = array2;
				num = 0;
				while (true)
				{
					if (num < array5.Length)
					{
						text = array5[num];
						flag = false;
						for (k = 0; k < array4.Length; k++)
						{
							if (string.Equals(text, array4[k], StringComparison.CurrentCultureIgnoreCase))
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
						num++;
						continue;
					}
					flag2 = true;
					return flag2;
				}
				flag2 = false;
				return flag2;
			}
			catch
			{
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class15.smethod_33(exception_, new object[14]
			{
				string_0, string_1, array2, array4, i, j, text, flag, k, flag2,
				array, array3, array5, num
			});
			throw;
		}
	}

	private static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Hashtable hashtable = default(Hashtable);
		Assembly assembly = default(Assembly);
		string name = default(string);
		string text = default(string);
		IEnumerator enumerator = default(IEnumerator);
		string text2 = default(string);
		Assembly assembly2 = default(Assembly);
		IDisposable disposable = default(IDisposable);
		Assembly executingAssembly = default(Assembly);
		string[] manifestResourceNames = default(string[]);
		int num = default(int);
		string text3 = default(string);
		Stream manifestResourceStream = default(Stream);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		string[] manifestResourceNames2 = default(string[]);
		int i = default(int);
		string text4 = default(string);
		Stream manifestResourceStream2 = default(Stream);
		bool flag = default(bool);
		string text5 = default(string);
		string text6 = default(string);
		try
		{
			Monitor.Enter(hashtable = hashtable_0);
			try
			{
				assembly = null;
				name = resolveEventArgs_0.Name;
				text = string.Empty;
				enumerator = hashtable_1.Keys.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						text2 = (string)enumerator.Current;
						if (smethod_2(name, text2))
						{
							assembly = hashtable_0[text2] as Assembly;
							if ((object)assembly != null)
							{
								assembly2 = assembly;
								return assembly2;
							}
							text = hashtable_1[text2] as string;
							break;
						}
					}
				}
				finally
				{
					disposable = enumerator as IDisposable;
					disposable?.Dispose();
				}
				if (text.Length == 0)
				{
					assembly2 = null;
					return assembly2;
				}
				executingAssembly = Assembly.GetExecutingAssembly();
				manifestResourceNames = executingAssembly.GetManifestResourceNames();
				num = 0;
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
					assembly2 = null;
					return assembly2;
				}
				manifestResourceStream = executingAssembly.GetManifestResourceStream(text3);
				array = Class21.smethod_3(97L, manifestResourceStream);
				array2 = null;
				try
				{
					text += "#";
					manifestResourceNames2 = executingAssembly.GetManifestResourceNames();
					for (i = 0; i < manifestResourceNames2.Length; i++)
					{
						text4 = manifestResourceNames2[i];
						if (text4 == text)
						{
							manifestResourceStream2 = executingAssembly.GetManifestResourceStream(text4);
							array2 = Class21.smethod_3(97L, manifestResourceStream2);
						}
					}
				}
				catch (Exception)
				{
				}
				flag = false;
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
					text5 = smethod_4(name);
					text6 = smethod_1(array, text, text5, ".dll");
					if (array2 != null)
					{
						smethod_1(array, text, text5, ".pdb");
					}
					assembly = Assembly.LoadFile(text6);
				}
				hashtable_0[name] = assembly;
				assembly2 = assembly;
				return assembly2;
			}
			finally
			{
				Monitor.Exit(hashtable);
			}
		}
		catch (Exception exception_)
		{
			Class15.smethod_33(exception_, new object[24]
			{
				object_0, resolveEventArgs_0, assembly, name, text, text2, executingAssembly, text3, manifestResourceStream, array,
				array2, text4, manifestResourceStream2, flag, text5, text6, assembly2, hashtable, enumerator, disposable,
				manifestResourceNames, num, manifestResourceNames2, i
			});
			throw;
		}
	}

	private static string smethod_4(string string_0)
	{
		int num = default(int);
		try
		{
			num = string_0.IndexOf(',');
			if (num >= 0)
			{
				string_0 = string_0.Substring(0, num);
			}
			return string_0;
		}
		catch (Exception exception_)
		{
			Class15.smethod_24(exception_, string_0, num);
			throw;
		}
	}
}
