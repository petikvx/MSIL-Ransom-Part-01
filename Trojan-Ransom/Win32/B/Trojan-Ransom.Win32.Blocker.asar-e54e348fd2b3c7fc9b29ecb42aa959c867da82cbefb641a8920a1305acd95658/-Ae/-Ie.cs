using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using _0023p;

namespace _0023Ae;

internal class _0023Ie
{
	internal struct _0023Le
	{
		public string _0023hF;

		public Version _0023Kv;

		public string _0023iF;

		public string _0023jF;

		public string _0023Je(bool _0023Ke)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2;
			if (5u != 0)
			{
				stringBuilder2 = stringBuilder;
			}
			stringBuilder2.Append(_0023hF);
			if (0 == 0)
			{
				bool num = _0023Ke;
				while (num)
				{
					num = _0023Kv != null;
					if (4u != 0)
					{
						if (num)
						{
							stringBuilder2.Append(", Version=");
							stringBuilder2.Append(_0023Kv);
						}
						break;
					}
				}
				stringBuilder2.Append(", Culture=");
			}
			if (8u != 0)
			{
				stringBuilder2.Append((_0023iF.Length == 0) ? "neutral" : _0023iF);
				stringBuilder2.Append(", PublicKeyToken=");
				stringBuilder2.Append((_0023jF.Length == 0) ? "null" : _0023jF);
			}
			return stringBuilder2.ToString();
		}

		public _0023Le(string assemblyFullName)
		{
			_0023Kv = null;
			_0023iF = string.Empty;
			_0023jF = string.Empty;
			_0023hF = string.Empty;
			string[] array = assemblyFullName.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith("Version="))
				{
					_0023Kv = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith("Culture="))
				{
					_0023iF = text2.Substring(8);
					if (_0023iF == "neutral")
					{
						_0023iF = string.Empty;
					}
				}
				else if (text2.StartsWith("PublicKeyToken="))
				{
					_0023jF = text2.Substring(15);
					if (_0023jF == "null")
					{
						_0023jF = string.Empty;
					}
				}
				else
				{
					_0023hF = text2;
				}
			}
		}
	}

	internal const string _0023fF = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int _0023gF = 4;

	private static Hashtable _00239D = new Hashtable();

	internal static bool IsWebApplication
	{
		get
		{
			bool result = default(bool);
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				string text2 = default(string);
				if (0 == 0)
				{
					text2 = text;
				}
				if (0 == 0)
				{
					bool num = text2 == "w3wp.exe";
					if (uint.MaxValue != 0)
					{
						if (num)
						{
							if (2u != 0)
							{
								result = true;
							}
							goto IL_0056;
						}
						num = text2 == "aspnet_wp.exe";
					}
					if (num)
					{
						if (0 == 0)
						{
							result = true;
						}
						goto IL_0056;
					}
				}
			}
			catch
			{
			}
			goto IL_0054;
			IL_0056:
			if (4u != 0)
			{
				return result;
			}
			goto IL_0054;
			IL_0054:
			return false;
		}
	}

	[DllImport("kernel32", EntryPoint = "MoveFileEx")]
	private static extern bool _0023Be(string _0023Ce, string _0023De, int _0023Ee);

	internal static void _0023Ge()
	{
		try
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			ResolveEventHandler value = _0023He;
			if (4u != 0)
			{
				currentDomain.AssemblyResolve += value;
			}
		}
		catch
		{
		}
	}

	internal static Assembly _0023He(object _0023ed, ResolveEventArgs _0023fd)
	{
		string name = _0023fd.Name;
		_0023Le _0023Le = default(_0023Le);
		if (0 == 0)
		{
			_0023Le = new _0023Le(name);
		}
		string text = _0023Le._0023Je(_0023Ke: false);
		string s;
		if (true)
		{
			s = text;
		}
		string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string text3 = default(string);
		if (0 == 0)
		{
			text3 = text2;
		}
		string[] array4 = default(string[]);
		if (uint.MaxValue != 0)
		{
			char[] array = new char[1];
			char[] array2;
			if (6u != 0)
			{
				array2 = array;
			}
			array2[0] = ',';
			string[] array3 = "ezZjMmRjYWExLTA2MGQtNDIwNi05NDJkLTI2NjllNjUzMTFiOX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{74c0bdf1-2ee1-481b-8de4-7fa45668fe24},ezZjMmRjYWExLTA2MGQtNDIwNi05NDJkLTI2NjllNjUzMTFiOX0=,[z]{74c0bdf1-2ee1-481b-8de4-7fa45668fe24}".Split(array2);
			if (0 == 0)
			{
				array4 = array3;
			}
		}
		string empty = string.Empty;
		string text4;
		if (5u != 0)
		{
			text4 = empty;
		}
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		while (true)
		{
			if (num < array4.Length - 1)
			{
				if (!(array4[num] == text3))
				{
					num += 2;
					continue;
				}
				goto IL_0082;
			}
			goto IL_009b;
			IL_00f6:
			if (text4.Length <= 0)
			{
				break;
			}
			if (text4[0] == '[')
			{
				int num2 = text4.IndexOf(']');
				string text5 = text4.Substring(1, num2 - 1);
				flag = text5.IndexOf('z') >= 0;
				flag2 = text5.IndexOf('t') >= 0;
				if (false)
				{
					goto IL_0082;
				}
				text4 = text4.Substring(num2 + 1);
			}
			lock (_00239D)
			{
				if (_00239D.ContainsKey(text4))
				{
					return (Assembly)_00239D[text4];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text4);
				if (manifestResourceStream == null)
				{
					break;
				}
				int num3 = (int)manifestResourceStream.Length;
				byte[] array5 = new byte[num3];
				manifestResourceStream.Read(array5, 0, num3);
				if (flag)
				{
					array5 = _0023u._0023t(array5);
				}
				Assembly assembly;
				do
				{
					assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array5);
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
					if (!flag2)
					{
						continue;
					}
					try
					{
						string text6 = $"{Path.GetTempPath()}{text4}\\";
						do
						{
							Directory.CreateDirectory(text6);
							string text7 = text6 + _0023Le._0023hF + ".dll";
							if (!File.Exists(text7))
							{
								FileStream fileStream = File.OpenWrite(text7);
								fileStream.Write(array5, 0, array5.Length);
								fileStream.Close();
								_0023Be(text7, null, 4);
								_0023Be(text6, null, 4);
							}
							assembly = Assembly.LoadFile(text7);
						}
						while (false);
					}
					catch
					{
					}
				}
				while (false);
				_00239D[text4] = assembly;
				return assembly;
			}
			IL_0082:
			text4 = array4[num + 1];
			goto IL_009b;
			IL_009b:
			int num4;
			if (text4.Length == 0 && _0023Le._0023jF.Length == 0)
			{
				text3 = Convert.ToBase64String(Encoding.UTF8.GetBytes(_0023Le._0023hF));
				num4 = 0;
				while (num4 < array4.Length - 1)
				{
					if (!(array4[num4] == text3))
					{
						num4 += 2;
						continue;
					}
					goto IL_00da;
				}
			}
			goto IL_00f6;
			IL_00da:
			text4 = array4[num4 + 1];
			if (false)
			{
				continue;
			}
			goto IL_00f6;
		}
		return null;
	}
}
