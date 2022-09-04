using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using _0023p;

namespace _0023i;

internal class _0023h
{
	private static readonly string _00236D;

	private static readonly string _00237D;

	private static readonly byte[] _00238D;

	private static readonly Hashtable _00239D;

	private static readonly bool _0023aE;

	private static readonly int _0023Mv;

	public static string _0023g(int P_0)
	{
		int num5;
		int num3;
		while (true)
		{
			int num = P_0;
			int num9;
			do
			{
				int num2 = num - _0023Mv;
				if (6u != 0)
				{
					P_0 = num2;
				}
				while (_0023aE)
				{
					string obj = (string)_00239D[P_0];
					string text;
					if (5u != 0)
					{
						text = obj;
					}
					if (text == null)
					{
						break;
					}
					if (0 == 0)
					{
						return text;
					}
				}
				if (0 == 0)
				{
					num3 = 0;
				}
				int num4 = P_0;
				if (0 == 0)
				{
					num5 = num4;
				}
				byte[] array = _00238D;
				int num6 = num5;
				int num7 = num6 + 1;
				if (0 == 0)
				{
					num5 = num7;
				}
				byte num8 = array[num6];
				if (2u != 0)
				{
					num9 = num8;
				}
				num = num9 & 0x80;
			}
			while (false);
			if (num == 0)
			{
				num3 = num9;
				if (num3 != 0)
				{
					break;
				}
				if (0 == 0)
				{
					return string.Empty;
				}
				continue;
			}
			if ((num9 & 0x40) == 0)
			{
				int num10 = num9 & 0x3F;
				if (6u != 0)
				{
					num10 <<= 8;
				}
				num3 = num10 + _00238D[num5++];
				break;
			}
			int num11 = (num9 & 0x1F) << 24;
			byte num12 = _00238D[num5++];
			if (4u != 0)
			{
				num11 += num12 << 16;
				num12 = _00238D[num5++];
			}
			num3 = num11 + (num12 << 8) + _00238D[num5++];
			break;
		}
		try
		{
			byte[] array2 = Convert.FromBase64String(Encoding.UTF8.GetString(_00238D, num5, num3));
			string text2 = string.Intern(Encoding.UTF8.GetString(array2, 0, array2.Length));
			if (_0023aE)
			{
				try
				{
					_00239D.Add(P_0, text2);
				}
				catch
				{
				}
			}
			return text2;
		}
		catch
		{
			return null;
		}
	}

	static _0023h()
	{
		if (true)
		{
			_00236D = "1";
			goto IL_000d;
		}
		goto IL_0029;
		IL_000d:
		_00237D = "244";
		_00238D = null;
		_00239D = null;
		_0023aE = false;
		goto IL_0029;
		IL_0029:
		if (true)
		{
			_0023Mv = 0;
			Assembly assembly = default(Assembly);
			Stream stream = default(Stream);
			int num2 = default(int);
			byte[] array2 = default(byte[]);
			do
			{
				if (_00236D == "1")
				{
					_0023aE = true;
					_00239D = new Hashtable();
				}
				_0023Mv = Convert.ToInt32(_00237D);
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				if (0 == 0)
				{
					assembly = executingAssembly;
				}
				Stream? manifestResourceStream = assembly.GetManifestResourceStream("{2ae62d52-7f6c-4f82-ba80-1da6bf0b360b}");
				if (0 == 0)
				{
					stream = manifestResourceStream;
				}
				try
				{
					int num = Convert.ToInt32(stream.Length);
					if (0 == 0)
					{
						num2 = num;
					}
					byte[] array = new byte[num2];
					if (0 == 0)
					{
						array2 = array;
					}
					stream.Read(array2, 0, num2);
					_00238D = _0023u._0023t(array2);
					if (uint.MaxValue != 0)
					{
						array2 = null;
					}
					Stream stream2 = stream;
					if (7u != 0)
					{
						stream2.Close();
					}
				}
				finally
				{
					do
					{
						((IDisposable)stream)?.Dispose();
					}
					while (4 == 0);
				}
			}
			while (8 == 0);
			return;
		}
		goto IL_000d;
	}
}
