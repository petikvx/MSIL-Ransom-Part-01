using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace _0023ab;

internal class _00239
{
	public static class _0023db
	{
		public static string _00237(int _00238)
		{
			try
			{
				_00238 ^= 0x666BEEF;
				_00238 -= _0023g;
				if (!_0023f)
				{
					return _0023_0023._0023Wg(_00238);
				}
				return _0023_0023._0023Cg(_00238);
			}
			catch (Exception _0023hd)
			{
				_0023_0023._00232f(_0023hd, (object)_00238);
				throw;
			}
		}
	}

	private static readonly string _0023a;

	private static readonly string _0023b;

	internal static readonly byte[] _0023c;

	internal static readonly Dictionary<int, string> _0023d;

	internal static readonly object _0023e;

	internal static readonly bool _0023f;

	private static readonly int _0023g;

	public static string _00237(int _00238)
	{
		try
		{
			return _0023db._00237(_00238);
		}
		catch (Exception _0023hd)
		{
			_0023_0023._00232f(_0023hd, (object)_00238);
			throw;
		}
	}

	static _00239()
	{
		Stream manifestResourceStream = default(Stream);
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			_0023a = "0";
			_0023b = "247";
			_0023c = null;
			_0023e = new object();
			_0023f = false;
			_0023g = 0;
			if (_0023a == "1")
			{
				_0023f = true;
				_0023d = new Dictionary<int, string>();
			}
			_0023g = Convert.ToInt32(_0023b);
			manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{de50bd20-6197-49d8-be4e-16fbcec92901}");
			try
			{
				num = Convert.ToInt32(manifestResourceStream.Length);
				array = new byte[num];
				manifestResourceStream.Read(array, 0, num);
				_0023c = _0023_0023._0023cg(array);
				array = null;
			}
			finally
			{
				((IDisposable)manifestResourceStream)?.Dispose();
			}
		}
		catch (Exception _0023hd)
		{
			_0023_0023._0023fg(_0023hd, (object)manifestResourceStream, (object)num, (object)array);
			throw;
		}
	}
}
