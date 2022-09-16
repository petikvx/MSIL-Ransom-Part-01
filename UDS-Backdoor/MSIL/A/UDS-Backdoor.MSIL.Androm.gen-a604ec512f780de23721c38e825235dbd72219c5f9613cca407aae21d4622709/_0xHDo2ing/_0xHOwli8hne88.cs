using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace _0xHDo2ing;

internal sealed class _0xHOwli8hne88
{
	private static class _0xHRudbeck6a
	{
		[DllImport("Microsoft.Internal.Performance.CodeMarkers.dll")]
		public static extern void PerfCodeMarker(int _0xH5imy, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] _0xHWa77ies, int _0xHIdea8es);

		[DllImport("Microsoft.Internal.Performance.CodeMarkers.dll", EntryPoint = "PerfCodeMarker")]
		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		public static extern void PerfCodeMarker_1(int _0xHTrampoli3er, [MarshalAs(UnmanagedType.LPWStr)] string _0xH5ishpond, int _0xHSh5ftlessness);

		[DllImport("Microsoft.VisualStudio.CodeMarkers.dll", EntryPoint = "PerfCodeMarker")]
		public static extern void PerfCodeMarker_2(int _0xHCalori2es, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] _0xHMollus3i3idal, int _0xHAcknow2edged);

		[DllImport("Microsoft.VisualStudio.CodeMarkers.dll", EntryPoint = "PerfCodeMarker")]
		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		public static extern void PerfCodeMarker_3(int _0xH6ashup, [MarshalAs(UnmanagedType.LPWStr)] string _0xHMakab3e, int _0xHB2ndore);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern ushort FindAtom([MarshalAs(UnmanagedType.LPWStr)] string _0xHMon6ter);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string _0xHM2lks);
	}

	private enum _0xHAutotel5c
	{
		Enabled,
		Disabled,
		DisabledDueToDllImportException
	}

	public static readonly _0xHOwli8hne88 _0xHDa8abie8s = new _0xHOwli8hne88();

	private const string _0xHRea00used = "VSCodeMarkersEnabled";

	private const string _0xHPe1rling = "Microsoft.Internal.Performance.CodeMarkers.dll";

	private const string _0xHAno6mic = "Microsoft.VisualStudio.CodeMarkers.dll";

	private _0xHAutotel5c _0xHOversaltin7;

	private RegistryView _0xHWhiplik4;

	private string _0xHPorcelai5like;

	private bool? _0xHP3l3verer;

	private static readonly byte[] _0xHM2ltica2sal = new Guid("AA10EEA0-F6AD-4E21-8865-C427DAE8EDB9").ToByteArray();

	public bool _0xHMalefacto4 => _0xHOversaltin7 == _0xHAutotel5c.Enabled;

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public bool _0xHGratefu55er
	{
		get
		{
			if (!_0xHP3l3verer.HasValue)
			{
				try
				{
					if (_0xHPorcelai5like == null)
					{
						_0xHP3l3verer = _0xHRudbeck6a.GetModuleHandle("Microsoft.VisualStudio._0xHOwli8hne88.dll") == IntPtr.Zero;
					}
					else
					{
						_0xHP3l3verer = _0xHNontheat0ical(_0xHPorcelai5like, _0xHWhiplik4);
					}
				}
				catch (Exception)
				{
					_0xHP3l3verer = true;
				}
			}
			return _0xHP3l3verer.Value;
		}
	}

	private _0xHOwli8hne88()
	{
		_0xHOversaltin7 = ((_0xHRudbeck6a.FindAtom("VS_0xHOwli8hne88Enabled") == 0) ? _0xHAutotel5c.Disabled : _0xHAutotel5c.Enabled);
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xHM7deller(int _0xHL5nghaired)
	{
		if (!_0xHMalefacto4)
		{
			return false;
		}
		try
		{
			if (_0xHGratefu55er)
			{
				_0xHRudbeck6a.PerfCodeMarker(_0xHL5nghaired, null, 0);
			}
			else
			{
				_0xHRudbeck6a.PerfCodeMarker_2(_0xHL5nghaired, null, 0);
			}
		}
		catch (DllNotFoundException)
		{
			_0xHOversaltin7 = _0xHAutotel5c.DisabledDueToDllImportException;
			return false;
		}
		return true;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xHAv0cular(int _0xHSt3irw3ys, byte[] _0xHD5witchers)
	{
		if (!_0xHMalefacto4)
		{
			return false;
		}
		if (_0xHD5witchers == null)
		{
			throw new ArgumentNullException("aBuff");
		}
		try
		{
			if (_0xHGratefu55er)
			{
				_0xHRudbeck6a.PerfCodeMarker(_0xHSt3irw3ys, _0xHD5witchers, _0xHD5witchers.Length);
			}
			else
			{
				_0xHRudbeck6a.PerfCodeMarker_2(_0xHSt3irw3ys, _0xHD5witchers, _0xHD5witchers.Length);
			}
		}
		catch (DllNotFoundException)
		{
			_0xHOversaltin7 = _0xHAutotel5c.DisabledDueToDllImportException;
			return false;
		}
		return true;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public void _0xHCon6ingences()
	{
		_0xHOversaltin7 = _0xHAutotel5c.DisabledDueToDllImportException;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xHTuto1(int _0xHR2strictiv2ly, Guid _0xHBe7eaved)
	{
		return _0xHAv0cular(_0xHR2strictiv2ly, _0xHBe7eaved.ToByteArray());
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xHAuricul1(int _0xHBunraku8, string _0xHG0utara0dehydes)
	{
		if (!_0xHMalefacto4)
		{
			return false;
		}
		if (_0xHG0utara0dehydes == null)
		{
			throw new ArgumentNullException("stringData");
		}
		try
		{
			int num = Encoding.Unicode.GetByteCount(_0xHG0utara0dehydes) + 2;
			if (_0xHGratefu55er)
			{
				_0xHRudbeck6a.PerfCodeMarker_1(_0xHBunraku8, _0xHG0utara0dehydes, num);
			}
			else
			{
				_0xHRudbeck6a.PerfCodeMarker_3(_0xHBunraku8, _0xHG0utara0dehydes, num);
			}
		}
		catch (DllNotFoundException)
		{
			_0xHOversaltin7 = _0xHAutotel5c.DisabledDueToDllImportException;
			return false;
		}
		return true;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal static byte[] _0xHMi7yoked(string _0xHReest0mates)
	{
		Encoding unicode = Encoding.Unicode;
		byte[] array = new byte[unicode.GetByteCount(_0xHReest0mates) + 2];
		unicode.GetBytes(_0xHReest0mates, 0, _0xHReest0mates.Length, array, 0);
		return array;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public static byte[] _0xHOsc0llates(byte[] _0xHS1henic, Guid _0xHPyros4a4s)
	{
		if (_0xHPyros4a4s == Guid.Empty)
		{
			return _0xHS1henic;
		}
		byte[] array = _0xHPyros4a4s.ToByteArray();
		byte[] array2 = new byte[_0xHM2ltica2sal.Length + array.Length + ((_0xHS1henic != null) ? _0xHS1henic.Length : 0)];
		_0xHM2ltica2sal.CopyTo(array2, 0);
		array.CopyTo(array2, _0xHM2ltica2sal.Length);
		_0xHS1henic?.CopyTo(array2, _0xHM2ltica2sal.Length + array.Length);
		return array2;
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xHStretch7ble(int _0xHSiby3s, uint _0xHNervo7snesses)
	{
		return _0xHAv0cular(_0xHSiby3s, BitConverter.GetBytes(_0xHNervo7snesses));
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public bool _0xH3isibles(int _0xHUncoff3ns, ulong _0xHMaigr5)
	{
		return _0xHAv0cular(_0xHUncoff3ns, BitConverter.GetBytes(_0xHMaigr5));
	}

	private static bool _0xHNontheat0ical(string _0xHT4rfiest, RegistryView _0xHB4atter)
	{
		if (_0xHT4rfiest == null)
		{
			throw new ArgumentNullException("regRoot");
		}
		using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, _0xHB4atter))
		{
			using RegistryKey registryKey2 = registryKey.OpenSubKey(_0xHT4rfiest + "\\Performance");
			if (registryKey2 != null)
			{
				return !string.IsNullOrEmpty(registryKey2.GetValue(string.Empty)!.ToString());
			}
		}
		return false;
	}
}
