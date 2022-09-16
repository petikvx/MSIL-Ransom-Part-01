using System;
using System.Runtime.InteropServices;
using System.Security;
using _0xHG6uziness;
using _0xHSeltze6s;

namespace _0xHC6itiques;

[SecurityCritical]
internal struct _0xHNo8resista8ts
{
	[ThreadStatic]
	internal static _0xHNo8resista8ts _0xHSchoolm4sterly;

	private unsafe byte* _0xHContinenta33y;

	private unsafe _0xH2wooned.EventData* _0xHWint0ri0st;

	private unsafe GCHandle* _0xHSec8ion;

	private unsafe _0xH2wooned.EventData* _0xHUnpl0asant;

	private unsafe byte* _0xHMed5cable;

	private unsafe _0xH2wooned.EventData* _0xHThe3odonts;

	private unsafe GCHandle* _0xHDo3kmaster;

	private byte[] _0xHKabi2i;

	private int _0xHUridin1s;

	private int _0xHR3v3tm3nts;

	private bool _0xHC2mparts;

	internal unsafe void _0xHReco7nage(byte* _0xHOve1ski1t, int _0xHNonb7eede7, _0xH2wooned.EventData* _0xHR1flow1rs, int _0xH6ackler, GCHandle* _0xHN1uroco1ls, int _0xHOverlords4ip)
	{
		_0xHUnpl0asant = _0xHR1flow1rs;
		_0xHContinenta33y = (byte*)checked(unchecked((nuint)_0xHOve1ski1t) + unchecked((nuint)_0xHNonb7eede7));
		_0xHWint0ri0st = (_0xH2wooned.EventData*)checked(unchecked((nuint)_0xHR1flow1rs) + unchecked((nuint)checked(unchecked((nint)_0xH6ackler) * unchecked((nint)sizeof(_0xH2wooned.EventData)))));
		_0xHSec8ion = (GCHandle*)checked(unchecked((nuint)_0xHN1uroco1ls) + unchecked((nuint)checked(unchecked((nint)_0xHOverlords4ip) * unchecked((nint)sizeof(GCHandle)))));
		_0xHMed5cable = _0xHOve1ski1t;
		_0xHThe3odonts = _0xHR1flow1rs;
		_0xHDo3kmaster = _0xHN1uroco1ls;
		_0xHC2mparts = false;
	}

	internal void _0xH5econsolidated()
	{
		this = default(_0xHNo8resista8ts);
	}

	internal unsafe _0xH2wooned.EventData* _0xH1oulage()
	{
		_0xHAl7mstones();
		return _0xHThe3odonts;
	}

	internal unsafe void _0xHCoreop6i6(void* _0xH4ancaking, int _0xHPhotog7aph)
	{
		if (_0xHR3v3tm3nts == 0)
		{
			byte* ptr = _0xHMed5cable;
			byte* ptr2 = (byte*)checked(unchecked((nuint)ptr) + unchecked((nuint)_0xHPhotog7aph));
			if (_0xHContinenta33y < ptr2)
			{
				throw new IndexOutOfRangeException(_0xHA2eotropy._0xHSpon8or("EventSource_AddScalarOutOfRange"));
			}
			_0xH7acek();
			_0xHMed5cable = ptr2;
			for (int i = 0; i != _0xHPhotog7aph; i = checked(i + 1))
			{
				ptr[i] = ((byte*)_0xH4ancaking)[i];
			}
		}
		else
		{
			int num = _0xHUridin1s;
			checked
			{
				_0xHUridin1s += _0xHPhotog7aph;
				_0xHDischar0ee();
				int num2 = 0;
				while (num2 != _0xHPhotog7aph)
				{
					_0xHKabi2i[num] = unchecked((byte*)_0xH4ancaking)[num2];
					num2++;
					num++;
				}
			}
		}
	}

	internal unsafe void _0xH7rudger(string _0xHSidebur0s, int _0xHO6s)
	{
		if (_0xHO6s > 65535)
		{
			_0xHO6s = 65534;
		}
		checked
		{
			if (_0xHR3v3tm3nts != 0)
			{
				_0xHCo5spirators(_0xHO6s + 2);
			}
			_0xHCoreop6i6(&_0xHO6s, 2);
			if (_0xHO6s == 0)
			{
				return;
			}
			if (_0xHR3v3tm3nts == 0)
			{
				_0xHAl7mstones();
				_0xHOvercoac7ed(_0xHSidebur0s, _0xHO6s);
				return;
			}
			int startIndex = _0xHUridin1s;
			_0xHUridin1s += _0xHO6s;
			_0xHDischar0ee();
			fixed (void* ptr = _0xHSidebur0s)
			{
				Marshal.Copy((IntPtr)ptr, _0xHKabi2i, startIndex, _0xHO6s);
			}
		}
	}

	internal void _0xH5orgedly(Array _0xH4ilmis, int _0xHSuppe3)
	{
		_0xHI4uli4(_0xH4ilmis, _0xHSuppe3, 1);
	}

	internal unsafe void _0xHI4uli4(Array _0xH7ehorner, int _0xHYp0rit0, int _0xHB0icklaying)
	{
		if (_0xHYp0rit0 > 65535)
		{
			_0xHYp0rit0 = 65535;
		}
		checked
		{
			int num = _0xHYp0rit0 * _0xHB0icklaying;
			if (_0xHR3v3tm3nts != 0)
			{
				_0xHCo5spirators(num + 2);
			}
			_0xHCoreop6i6(&_0xHYp0rit0, 2);
			if (_0xHYp0rit0 != 0)
			{
				if (_0xHR3v3tm3nts == 0)
				{
					_0xHAl7mstones();
					_0xHOvercoac7ed(_0xH7ehorner, num);
					return;
				}
				int dstOffset = _0xHUridin1s;
				_0xHUridin1s += num;
				_0xHDischar0ee();
				Buffer.BlockCopy(_0xH7ehorner, 0, _0xHKabi2i, dstOffset, num);
			}
		}
	}

	internal int _0xHOve3confidently()
	{
		_0xH0lnae();
		checked
		{
			_0xHUridin1s += 2;
			return _0xHUridin1s;
		}
	}

	internal void _0xHSu88or(int _0xHG8vern8r, int _0xH3ngested)
	{
		_0xHDischar0ee();
		_0xHKabi2i[checked(_0xHG8vern8r - 2)] = (byte)_0xH3ngested;
		_0xHKabi2i[checked(_0xHG8vern8r - 1)] = (byte)(_0xH3ngested >> 8);
		_0xHLoadsto7e();
	}

	internal void _0xH0lnae()
	{
		_0xHAl7mstones();
		checked
		{
			_0xHR3v3tm3nts++;
		}
	}

	internal void _0xHLoadsto7e()
	{
		checked
		{
			_0xHR3v3tm3nts--;
			if (_0xHR3v3tm3nts == 0)
			{
				_0xHDischar0ee();
				_0xHOvercoac7ed(_0xHKabi2i, _0xHUridin1s);
				_0xHKabi2i = null;
				_0xHUridin1s = 0;
			}
		}
	}

	private void _0xHDischar0ee()
	{
		int num = _0xHUridin1s;
		if (_0xHKabi2i == null || _0xHKabi2i.Length < num)
		{
			_0xHV4lle4n(num);
		}
	}

	private void _0xHCo5spirators(int _0xHHellho0nds)
	{
		int num = checked(_0xHUridin1s + _0xHHellho0nds);
		if (_0xHKabi2i == null || _0xHKabi2i.Length < num)
		{
			_0xHV4lle4n(num);
		}
	}

	private void _0xHV4lle4n(int _0xHZygap4physes)
	{
		int num = ((_0xHKabi2i == null) ? 64 : _0xHKabi2i.Length);
		do
		{
			num = checked(num * 2);
		}
		while (num < _0xHZygap4physes);
		Array.Resize(ref _0xHKabi2i, num);
	}

	private unsafe void _0xHOvercoac7ed(object _0xHDezi3ci3g, int _0xHM1tac1rcaria)
	{
		GCHandle* ptr = _0xHDo3kmaster;
		if (_0xHSec8ion <= ptr)
		{
			throw new IndexOutOfRangeException(_0xHA2eotropy._0xHSpon8or("EventSource_PinArrayOutOfRange"));
		}
		_0xH2wooned.EventData* ptr2 = _0xHThe3odonts;
		if (_0xHWint0ri0st <= ptr2)
		{
			throw new IndexOutOfRangeException(_0xHA2eotropy._0xHSpon8or("EventSource_DataDescriptorsOutOfRange"));
		}
		_0xHDo3kmaster = (GCHandle*)checked(unchecked((nuint)ptr) + unchecked((nuint)sizeof(GCHandle)));
		_0xHThe3odonts = (_0xH2wooned.EventData*)checked(unchecked((nuint)ptr2) + unchecked((nuint)sizeof(_0xH2wooned.EventData)));
		*ptr = GCHandle.Alloc(_0xHDezi3ci3g, GCHandleType.Pinned);
		ptr2->m_Ptr = checked((long)(ulong)(UIntPtr)(void*)ptr->AddrOfPinnedObject());
		ptr2->m_Size = _0xHM1tac1rcaria;
	}

	private unsafe void _0xH7acek()
	{
		if (!_0xHC2mparts)
		{
			_0xH2wooned.EventData* ptr = _0xHThe3odonts;
			if (_0xHWint0ri0st <= ptr)
			{
				throw new IndexOutOfRangeException(_0xHA2eotropy._0xHSpon8or("EventSource_DataDescriptorsOutOfRange"));
			}
			ptr->m_Ptr = checked((long)(ulong)(UIntPtr)_0xHMed5cable);
			_0xHC2mparts = true;
		}
	}

	private unsafe void _0xHAl7mstones()
	{
		if (_0xHC2mparts)
		{
			_0xH2wooned.EventData* ptr = _0xHThe3odonts;
			checked
			{
				ptr->m_Size = (int)(_0xHMed5cable - unchecked((byte*)checked((nuint)ptr->m_Ptr)));
			}
			_0xHThe3odonts = (_0xH2wooned.EventData*)checked(unchecked((nuint)ptr) + unchecked((nuint)sizeof(_0xH2wooned.EventData)));
			_0xHC2mparts = false;
		}
	}
}
