using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32;

namespace _0xHPuls0s;

internal abstract class _0xHFa0ci0t
{
	protected abstract string _0xHSu1dered { get; }

	protected abstract string _0xHK3r3tes { get; }

	internal T _0xH5rumbliness<T>(string _0xHDre66y, T _0xH0askmaster)
	{
		return _0xHApprisi2g(string.Empty, _0xHDre66y, _0xH0askmaster);
	}

	internal T _0xHApprisi2g<T>(string _0xH1alvific, string _0xHSonne11ing, T _0xHNak6d6r)
	{
		bool _0xHAr3eries;
		T result = _0xHSurf7oards(_0xHEq3als: false, _0xH1alvific, _0xHSonne11ing, _0xHNak6d6r, out _0xHAr3eries);
		if (!_0xHAr3eries)
		{
			return _0xHSurf7oards(_0xHEq3als: true, _0xH1alvific, _0xHSonne11ing, _0xHNak6d6r, out _0xHAr3eries);
		}
		return result;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Called in other assemblies this file is linked into.")]
	internal bool _0xHCooeein5(string _0xHV7tr7c, bool _0xHSubcategor3es)
	{
		if (!bool.TryParse(_0xH5rumbliness(_0xHV7tr7c, _0xHSubcategor3es.ToString()), out var result))
		{
			return _0xHSubcategor3es;
		}
		return result;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "This method is called in some of the assemblies this file is linked into, and not in others.")]
	internal void _0xHDud77n<T>(string _0xHOb8lizing, T _0xHRegin6s, bool _0xHMusk6ts = false)
	{
		using RegistryKey registryKey = _0xH1inusoidally(_0xHMusk6ts, _0xHI7sculps: true);
		registryKey.SetValue(_0xHOb8lizing, _0xHRegin6s);
	}

	private T _0xHSurf7oards<T>(bool _0xHEq3als, string _0xH1ewan, string _0xHAutoga6y, T _0xH1andier, out bool _0xHAr3eries)
	{
		object obj = null;
		_0xHAr3eries = false;
		using (RegistryKey registryKey = _0xH1inusoidally(_0xHEq3als))
		{
			if (registryKey != null)
			{
				if (!string.IsNullOrEmpty(_0xH1ewan))
				{
					using RegistryKey registryKey2 = registryKey.OpenSubKey(_0xH1ewan);
					if (registryKey2 != null)
					{
						obj = registryKey2.GetValue(_0xHAutoga6y);
					}
				}
				else
				{
					obj = registryKey.GetValue(_0xHAutoga6y);
				}
			}
		}
		if (obj != null && obj is T)
		{
			_0xHAr3eries = true;
		}
		else
		{
			obj = _0xH1andier;
		}
		return (T)obj;
	}

	private RegistryKey _0xH1inusoidally(bool _0xHPractic2ms, bool _0xHI7sculps = false)
	{
		RegistryKey registryKey = ((!_0xHPractic2ms) ? Registry.CurrentUser : Registry.LocalMachine);
		string text = ((Environment.Is64BitOperatingSystem && _0xHPractic2ms) ? _0xHK3r3tes : _0xHSu1dered);
		if (!_0xHI7sculps)
		{
			return registryKey.OpenSubKey(text);
		}
		return registryKey.CreateSubKey(text);
	}
}
