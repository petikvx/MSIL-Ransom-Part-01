using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class2
{
	internal struct Struct0
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool bool_0)
		{
			StringBuilder stringBuilder = default(StringBuilder);
			try
			{
				stringBuilder = new StringBuilder();
				stringBuilder.Append(string_0);
				if (bool_0 && version_0 != null)
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException3(exception_, stringBuilder, this, bool_0);
				throw;
			}
		}

		public Struct0(string string_3)
		{
			char[] array = default(char[]);
			string[] array2 = default(string[]);
			int i = default(int);
			string text = default(string);
			string text2 = default(string);
			try
			{
				version_0 = null;
				string_1 = string.Empty;
				string_2 = string.Empty;
				string_0 = string.Empty;
				array = new char[1] { ',' };
				array2 = string_3.Split(array);
				for (i = 0; i < array2.Length; i++)
				{
					text = array2[i];
					text2 = text.Trim();
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException7(exception_, text, text2, array, array2, i, this, string_3);
				throw;
			}
		}
	}

	private static Hashtable hashtable_0;

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	internal static void smethod_0()
	{
		try
		{
			try
			{
				AppDomain.CurrentDomain.AssemblyResolve += smethod_1;
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Struct0 @struct = default(Struct0);
		string text = default(string);
		string text2 = default(string);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		string text3 = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int i = default(int);
		int j = default(int);
		int num = default(int);
		string text4 = default(string);
		Hashtable hashtable = default(Hashtable);
		Assembly assembly = default(Assembly);
		Stream manifestResourceStream = default(Stream);
		int num2 = default(int);
		byte[] array3 = default(byte[]);
		Assembly assembly2 = default(Assembly);
		string text5 = default(string);
		string text6 = default(string);
		FileStream fileStream = default(FileStream);
		try
		{
			@struct = new Struct0(resolveEventArgs_0.Name);
			text = @struct.method_0(bool_0: false);
			text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
			array = new char[1] { ',' };
			array2 = "ezY0MjY3N2YzLWFlZmUtNDVjMC05ZjFmLTQ1ZTM4OTVlZTI0Y30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{642677f3-aefe-45c0-9f1f-45e3895ee24c}".Split(array);
			text3 = string.Empty;
			flag = false;
			flag2 = false;
			for (i = 0; i < array2.Length - 1; i += 2)
			{
				if (array2[i] == text2)
				{
					text3 = array2[i + 1];
					break;
				}
			}
			if (text3.Length == 0 && @struct.string_2.Length == 0)
			{
				text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
				for (j = 0; j < array2.Length - 1; j += 2)
				{
					if (array2[j] == text2)
					{
						text3 = array2[j + 1];
						break;
					}
				}
			}
			if (text3.Length > 0)
			{
				if (text3[0] == '[')
				{
					num = text3.IndexOf(']');
					text4 = text3.Substring(1, num - 1);
					flag = text4.IndexOf('z') >= 0;
					flag2 = text4.IndexOf('t') >= 0;
					text3 = text3.Substring(num + 1);
				}
				Monitor.Enter(hashtable = hashtable_0);
				try
				{
					if (hashtable_0.ContainsKey(text3))
					{
						assembly = (Assembly)hashtable_0[text3];
						return assembly;
					}
					manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text3);
					if (manifestResourceStream != null)
					{
						num2 = (int)manifestResourceStream.Length;
						array3 = new byte[num2];
						manifestResourceStream.Read(array3, 0, num2);
						if (flag)
						{
							array3 = SimpleZip.Unzip(array3);
						}
						assembly2 = null;
						if (!flag2)
						{
							try
							{
								assembly2 = Assembly.Load(array3);
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
								text5 = $"{Path.GetTempPath()}{text3}\\";
								Directory.CreateDirectory(text5);
								text6 = text5 + @struct.string_0 + ".dll";
								if (!File.Exists(text6))
								{
									fileStream = File.OpenWrite(text6);
									fileStream.Write(array3, 0, array3.Length);
									fileStream.Close();
									MoveFileEx(text6, null, 4);
									MoveFileEx(text5, null, 4);
								}
								assembly2 = Assembly.LoadFile(text6);
							}
							catch
							{
							}
						}
						hashtable_0[text3] = assembly2;
						assembly = assembly2;
						return assembly;
					}
				}
				finally
				{
					Monitor.Exit(hashtable);
				}
			}
			return null;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[23]
			{
				@struct, text, text2, array2, text3, flag, flag2, i, j, num,
				text4, manifestResourceStream, num2, array3, assembly2, text5, text6, fileStream, assembly, array,
				hashtable, object_0, resolveEventArgs_0
			});
			throw;
		}
	}

	public Class2()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	static Class2()
	{
		try
		{
			hashtable_0 = new Hashtable();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}
}
