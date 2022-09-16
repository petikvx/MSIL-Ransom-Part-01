using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using _0xH1hamo;
using _0xH2asconaders;
using _0xH5ondollar;
using _0xH5rivatises;
using _0xH6recede;
using _0xHA2te22as;
using _0xHAccelero7eter;
using _0xHAdject8val;
using _0xHB4ngos;
using _0xHC6itiques;
using _0xHCabba8ey;
using _0xHD2ves;
using _0xHDaphn6s;
using _0xHE5faced;
using _0xHEy3ies;
using _0xHFou1thly;
using _0xHG8stur8rs;
using _0xHHypoderm7c;
using _0xHI3dustriously;
using _0xHImmu5oreactive;
using _0xHIn7eigler;
using _0xHLazil4;
using _0xHLognorma2ity;
using _0xHMal7dict7d;
using _0xHMisd1er;
using _0xHOppor4unis4;
using _0xHP3obe3s;
using _0xHPolygam7z7ng;
using _0xHPra6erfull6;
using _0xHPul5erize;
using _0xHS3ar3;
using _0xHScornin0;
using _0xHSeltze6s;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHSwansk8ns;
using _0xHTrammeler7;
using _0xHW4tans;
using _0xHWrathe6;

namespace _0xHG6uziness;

public class _0xH2wooned : IDisposable
{
	protected internal struct EventData
	{
		internal long m_Ptr;

		internal int m_Size;

		internal int m_Reserved;

		public IntPtr DataPointer
		{
			get
			{
				return (IntPtr)m_Ptr;
			}
			set
			{
				m_Ptr = (long)value;
			}
		}

		public int Size
		{
			get
			{
				return m_Size;
			}
			set
			{
				m_Size = value;
			}
		}

		[SecurityCritical]
		internal unsafe void SetMetadata(byte* pointer, int size, int reserved)
		{
			m_Ptr = checked((long)(ulong)(UIntPtr)pointer);
			m_Size = size;
			m_Reserved = reserved;
		}
	}

	private struct _0xHTro1hes
	{
		private long _0xHAlt7rnativ7n7ss;

		private uint[] _0xHSial5id;

		private int _0xH5renow;

		public void _0xHO22ult()
		{
			if (_0xHSial5id == null)
			{
				_0xHSial5id = new uint[85];
			}
			_0xHAlt7rnativ7n7ss = 0L;
			_0xH5renow = 0;
			_0xHSial5id[80] = 1732584193u;
			_0xHSial5id[81] = 4023233417u;
			_0xHSial5id[82] = 2562383102u;
			_0xHSial5id[83] = 271733878u;
			_0xHSial5id[84] = 3285377520u;
		}

		public void _0xHWat3rproofn3ss(byte _0xH0rawnwork)
		{
			_0xHSial5id[_0xH5renow / 4] = (_0xHSial5id[_0xH5renow / 4] << 8) | _0xH0rawnwork;
			if (64 == checked(++_0xH5renow))
			{
				_0xHCorrec0ional();
			}
		}

		public void _0xHBieldi2g(byte[] _0xHRes3ted)
		{
			foreach (byte _0xH0rawnwork in _0xHRes3ted)
			{
				_0xHWat3rproofn3ss(_0xH0rawnwork);
			}
		}

		public void _0xHTonearm3(byte[] _0xHRe5mpos5t5ons)
		{
			long num = checked(_0xHAlt7rnativ7n7ss + 8 * _0xH5renow);
			_0xHWat3rproofn3ss(128);
			while (_0xH5renow != 56)
			{
				_0xHWat3rproofn3ss(0);
			}
			_0xHWat3rproofn3ss((byte)(num >> 56));
			_0xHWat3rproofn3ss((byte)(num >> 48));
			_0xHWat3rproofn3ss((byte)(num >> 40));
			_0xHWat3rproofn3ss((byte)(num >> 32));
			_0xHWat3rproofn3ss((byte)(num >> 24));
			_0xHWat3rproofn3ss((byte)(num >> 16));
			_0xHWat3rproofn3ss((byte)(num >> 8));
			_0xHWat3rproofn3ss((byte)num);
			int num2 = ((_0xHRe5mpos5t5ons.Length < 20) ? _0xHRe5mpos5t5ons.Length : 20);
			for (int i = 0; i != num2; i++)
			{
				uint num3 = _0xHSial5id[80 + i / 4];
				_0xHRe5mpos5t5ons[i] = (byte)(num3 >> 24);
				_0xHSial5id[80 + i / 4] = num3 << 8;
			}
		}

		private void _0xHCorrec0ional()
		{
			uint num;
			uint num2;
			uint num3;
			uint num4;
			uint num5;
			checked
			{
				for (int i = 16; i != 80; i++)
				{
					_0xHSial5id[i] = _0xHF7ontie7(_0xHSial5id[i - 3] ^ _0xHSial5id[i - 8] ^ _0xHSial5id[i - 14] ^ _0xHSial5id[i - 16]);
				}
				num = _0xHSial5id[80];
				num2 = _0xHSial5id[81];
				num3 = _0xHSial5id[82];
				num4 = _0xHSial5id[83];
				num5 = _0xHSial5id[84];
			}
			for (int j = 0; j != 20; j++)
			{
				uint num6 = (num2 & num3) | (~num2 & num4);
				uint num7 = _0xHHaul1rs(num) + num6 + num5 + 1518500249 + _0xHSial5id[j];
				num5 = num4;
				num4 = num3;
				num3 = _0xHBr6stl6er(num2);
				num2 = num;
				num = num7;
			}
			for (int k = 20; k != 40; k++)
			{
				uint num8 = num2 ^ num3 ^ num4;
				uint num9 = _0xHHaul1rs(num) + num8 + num5 + 1859775393 + _0xHSial5id[k];
				num5 = num4;
				num4 = num3;
				num3 = _0xHBr6stl6er(num2);
				num2 = num;
				num = num9;
			}
			for (int l = 40; l != 60; l++)
			{
				uint num10 = (num2 & num3) | (num2 & num4) | (num3 & num4);
				uint num11 = (uint)((int)(_0xHHaul1rs(num) + num10 + num5) + -1894007588) + _0xHSial5id[l];
				num5 = num4;
				num4 = num3;
				num3 = _0xHBr6stl6er(num2);
				num2 = num;
				num = num11;
			}
			for (int m = 60; m != 80; m++)
			{
				uint num12 = num2 ^ num3 ^ num4;
				uint num13 = (uint)((int)(_0xHHaul1rs(num) + num12 + num5) + -899497514) + _0xHSial5id[m];
				num5 = num4;
				num4 = num3;
				num3 = _0xHBr6stl6er(num2);
				num2 = num;
				num = num13;
			}
			_0xHSial5id[80] += num;
			_0xHSial5id[81] += num2;
			_0xHSial5id[82] += num3;
			_0xHSial5id[83] += num4;
			_0xHSial5id[84] += num5;
			checked
			{
				_0xHAlt7rnativ7n7ss += 512L;
				_0xH5renow = 0;
			}
		}

		private static uint _0xHF7ontie7(uint _0xHTrothpl1ghted)
		{
			return (_0xHTrothpl1ghted << 1) | (_0xHTrothpl1ghted >> 31);
		}

		private static uint _0xHHaul1rs(uint _0xHRak7h7ll)
		{
			return (_0xHRak7h7ll << 5) | (_0xHRak7h7ll >> 27);
		}

		private static uint _0xHBr6stl6er(uint _0xHPat3ns)
		{
			return (_0xHPat3ns << 30) | (_0xHPat3ns >> 2);
		}
	}

	private class _0xHC2urant2s : _0xHRi3u3e3
	{
		private _0xH2wooned _0xHOve7dosing;

		public _0xHC2urant2s(_0xH2wooned eventSource)
		{
			_0xHOve7dosing = eventSource;
		}

		protected override void OnControllerCommand(_0xHL1nt1n command, IDictionary<string, string> arguments, int perEventSourceSessionId, int etwSessionId)
		{
			_0xHBelletri8t _0xHAbsolu6is6s = null;
			_0xHOve7dosing._0xHMechan4sts(_0xHAbsolu6is6s, perEventSourceSessionId, etwSessionId, (_0xHNonequa5)command, _0xHSubm0ttal(), base._0xHDoo6oos, base._0xHPs4cholog4, arguments);
		}
	}

	internal struct _0xHDecl7nat7onal
	{
		public _0xHMonocrac1es _0xHOmn4vorous;

		public _0xHParam0t0riz0 _0xHSepta1ia;

		public bool _0xH7in;

		public bool _0xHLutefis2s;

		public bool _0xH5aludism;

		public byte _0xHD7spatched;

		public string _0xHChol3nes;

		public string _0xHDel4e;

		public ParameterInfo[] _0xHP4nst4r;

		public _0xHOffscouri5gs _0xH2axers;

		public _0xHHyp2ra2sth2sia _0xHBe0hout0;
	}

	internal const string _0xHDi1traction = "Start";

	internal const string _0xH0uscovado = "Stop";

	private string _0xHFil4ture;

	internal int _0xHLut3sts;

	private Guid _0xHOpaquin4;

	internal volatile _0xHDecl7nat7onal[] _0xHTran3udation3;

	private volatile byte[] _0xHCei3i;

	private EventHandler<_0xHEcholocat3ons> _0xHP7onologies;

	private _0xHOvera2e _0xH4nlooker;

	private bool _0xH5alitosis;

	internal _0xHFire0ots _0xH7dvections;

	internal _0xHSov8r8ignti8s _0xHTransversel4;

	internal volatile _0xHGh0bl0 _0xHInc4nerat4on;

	private volatile _0xHC2urant2s _0xHU3derli3i3g;

	private bool _0xHExp7nentiati7n;

	private Exception _0xHArr4y4;

	private byte _0xHS6phon;

	private _0xHEcholocat3ons _0xHLumpis2;

	private string[] _0xHOverde1ign;

	internal static uint _0xHExplorator8;

	[ThreadStatic]
	private static byte _0xHNo3cultivatio3 = 0;

	internal volatile ulong[] _0xHSuperm4l4tants;

	private _0xH7emmying _0xHNewsdea0ers;

	private static readonly byte[] _0xHAnos1atic = new byte[16]
	{
		72, 44, 45, 178, 195, 144, 71, 200, 135, 248,
		26, 21, 191, 193, 48, 251
	};

	private byte[] _0xHU5dreamed;

	public string _0xHAs2ribed => _0xHFil4ture;

	public Guid _0xHZo2al => _0xHOpaquin4;

	public _0xHOvera2e _0xHUte6ine => _0xH4nlooker;

	public static Guid _0xHSuper1odels
	{
		[SecuritySafeCritical]
		get
		{
			Guid _0xHSkir4ed = default(Guid);
			_0xH7ozier._0xHR7sum7d.EventActivityIdControl(_0xH7ozier._0xHR7sum7d._0xHDisb4rse.EVENT_ACTIVITY_CTRL_GET_ID, ref _0xHSkir4ed);
			return _0xHSkir4ed;
		}
	}

	public Exception _0xHMo2ster => _0xHArr4y4;

	private bool _0xH7rill
	{
		get
		{
			if (_0xHU3derli3i3g != null)
			{
				return _0xHU3derli3i3g._0xHToga5;
			}
			return true;
		}
	}

	private bool _0xHMo1thily
	{
		get
		{
			return (_0xH4nlooker & _0xHOvera2e.ThrowOnEventWriteErrors) != 0;
		}
		set
		{
			if (value)
			{
				_0xH4nlooker |= _0xHOvera2e.ThrowOnEventWriteErrors;
			}
			else
			{
				_0xH4nlooker &= ~_0xHOvera2e.ThrowOnEventWriteErrors;
			}
		}
	}

	private bool _0xHUng3nt33l
	{
		get
		{
			return (_0xH4nlooker & _0xHOvera2e.EtwSelfDescribingEventFormat) != 0;
		}
		set
		{
			if (!value)
			{
				_0xH4nlooker |= _0xHOvera2e.EtwManifestEventFormat;
				_0xH4nlooker &= ~_0xHOvera2e.EtwSelfDescribingEventFormat;
			}
			else
			{
				_0xH4nlooker |= _0xHOvera2e.EtwSelfDescribingEventFormat;
				_0xH4nlooker &= ~_0xHOvera2e.EtwManifestEventFormat;
			}
		}
	}

	public event EventHandler<_0xHEcholocat3ons> _0xH8ateaux
	{
		add
		{
			lock (this)
			{
				_0xHP7onologies = (EventHandler<_0xHEcholocat3ons>)Delegate.Combine(_0xHP7onologies, value);
			}
			for (_0xHEcholocat3ons _0xHE0itomising = _0xHLumpis2; _0xHE0itomising != null; _0xHE0itomising = _0xHE0itomising._0xHE0itomising)
			{
				value(this, _0xHE0itomising);
			}
		}
		remove
		{
			lock (this)
			{
				_0xHP7onologies = (EventHandler<_0xHEcholocat3ons>)Delegate.Remove(_0xHP7onologies, value);
			}
		}
	}

	public bool _0xHS8umbler()
	{
		return _0xH5alitosis;
	}

	public bool _0xHPreacc4se(_0xHFire0ots _0xHQursh2s, _0xHSov8r8ignti8s _0xHGa00ed)
	{
		return _0xHReacc2imatizing(_0xHQursh2s, _0xHGa00ed, _0xHSummar4ses.None);
	}

	public bool _0xHReacc2imatizing(_0xHFire0ots _0xH0oodboxes, _0xHSov8r8ignti8s _0xHMas6ica6ed, _0xHSummar4ses _0xH4oes)
	{
		if (!_0xH5alitosis)
		{
			return false;
		}
		if (!_0xHRemappe8(_0xH5alitosis, _0xH7dvections, _0xHTransversel4, _0xH0oodboxes, _0xHMas6ica6ed, _0xH4oes))
		{
			return false;
		}
		return true;
	}

	public static Guid _0xHRo88icking(Type _0xHOnei8ically)
	{
		if (_0xHOnei8ically == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		_0xHHelilift6 _0xHHelilift = (_0xHHelilift6)_0xHCompa7atist(_0xHOnei8ically, typeof(_0xHHelilift6));
		string text = _0xHOnei8ically.Name;
		if (_0xHHelilift != null)
		{
			if (_0xHHelilift._0xHRigori8tic != null)
			{
				Guid result = Guid.Empty;
				if (Guid.TryParse(_0xHHelilift._0xHRigori8tic, out result))
				{
					return result;
				}
			}
			if (_0xHHelilift._0xHFuchs3nes != null)
			{
				text = _0xHHelilift._0xHFuchs3nes;
			}
		}
		if (text == null)
		{
			throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("Argument_InvalidTypeName"), "eventSourceType");
		}
		return _0xHHulloe3(text.ToUpperInvariant());
	}

	public static string _0xHCeb0d(Type _0xHF8ats)
	{
		return _0xHIrri8a8ion(_0xHF8ats, _0xHAquapla5er.None);
	}

	public static string _0xHSpac7bands(Type _0xHSnow7ank, string _0xHCu5verin)
	{
		return _0xHG6ethites(_0xHSnow7ank, _0xHCu5verin, _0xHAquapla5er.None);
	}

	public static string _0xHG6ethites(Type _0xH7pods, string _0xHAe6og6am, _0xHAquapla5er _0xHNeutra00y)
	{
		if (_0xH7pods == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		byte[] array = _0xH4ampness(_0xH7pods, _0xHAe6og6am, null, _0xHNeutra00y);
		if (array != null)
		{
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}
		return null;
	}

	public static IEnumerable<_0xH2wooned> _0xHLoppin4()
	{
		List<_0xH2wooned> list = new List<_0xH2wooned>();
		lock (_0xHBelletri8t._0xHL0ticifers)
		{
			foreach (WeakReference _0xH6iscomfort in _0xHBelletri8t._0xH6iscomforts)
			{
				if (_0xH6iscomfort.Target is _0xH2wooned _0xH2wooned2 && !_0xH2wooned2._0xH7rill)
				{
					list.Add(_0xH2wooned2);
				}
			}
			return list;
		}
	}

	public static void _0xHO3tstretched(_0xH2wooned _0xHHe7stitcher, _0xHNonequa5 _0xHAman8adines, IDictionary<string, string> _0xHE5troverted)
	{
		if (_0xHHe7stitcher == null)
		{
			throw new ArgumentNullException("eventSource");
		}
		if (_0xHAman8adines <= _0xHNonequa5.Update && _0xHAman8adines != _0xHNonequa5.SendManifest)
		{
			throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_InvalidCommand"), "command");
		}
		_0xHHe7stitcher._0xHMechan4sts(null, 0, 0, _0xHAman8adines, _0xHEx8cut8s: true, _0xHFire0ots.LogAlways, _0xHSov8r8ignti8s.None, _0xHE5troverted);
	}

	[SecuritySafeCritical]
	public static void _0xHEmblaz7ner(Guid _0xHTachist7sc7pe)
	{
		if (_0xHSwallow8ng._0xHNichin4 != null)
		{
			_0xHSwallow8ng._0xHNichin4._0xHObje6tivisti6(_0xHTachist7sc7pe);
		}
		_0xH7ozier._0xHR7sum7d.EventActivityIdControl(_0xH7ozier._0xHR7sum7d._0xHDisb4rse.EVENT_ACTIVITY_CTRL_GET_SET_ID, ref _0xHTachist7sc7pe);
	}

	[SecuritySafeCritical]
	public static void _0xHSw00nier(Guid _0xHCred3tor, out Guid _0xH3limy)
	{
		_0xH3limy = _0xHCred3tor;
		_0xH7ozier._0xHR7sum7d.EventActivityIdControl(_0xH7ozier._0xHR7sum7d._0xHDisb4rse.EVENT_ACTIVITY_CTRL_GET_SET_ID, ref _0xH3limy);
		if (_0xHSwallow8ng._0xHNichin4 != null)
		{
			_0xHSwallow8ng._0xHNichin4._0xHObje6tivisti6(_0xHCred3tor);
		}
	}

	public string _0xHHel4otrop4sm(string _0xHSubj5ctiviti5s)
	{
		checked
		{
			if (_0xHOverde1ign != null)
			{
				for (int i = 0; i < _0xHOverde1ign.Length - 1; i += 2)
				{
					if (_0xHOverde1ign[i] == _0xHSubj5ctiviti5s)
					{
						return _0xHOverde1ign[i + 1];
					}
				}
			}
			return null;
		}
	}

	public override string _0xHEx3losively()
	{
		return _0xHA2eotropy._0xHSpon8or("_0xH2wooned_ToString", _0xHAs2ribed, _0xHZo2al);
	}

	protected _0xH2wooned()
		: this(_0xHOvera2e.EtwManifestEventFormat)
	{
	}

	protected _0xH2wooned(bool throwOnEventWriteErrors)
		: this(_0xHOvera2e.EtwManifestEventFormat | (throwOnEventWriteErrors ? _0xHOvera2e.ThrowOnEventWriteErrors : _0xHOvera2e.Default))
	{
	}

	protected _0xH2wooned(_0xHOvera2e settings)
		: this(settings, (string[])null)
	{
	}

	protected _0xH2wooned(_0xHOvera2e settings, params string[] traits)
	{
		_0xH4nlooker = _0xHShive1(settings);
		Type type = GetType();
		_0xHAnti0ogarithms(_0xHRo88icking(type), _0xHCeb0d(type), traits);
	}

	protected virtual void OnEventCommand(_0xHEcholocat3ons command)
	{
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId)
	{
		WriteEventCore(eventId, 0, null);
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, int arg1)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[1];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			WriteEventCore(eventId, 1, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, int arg1, int arg2)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[2];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			WriteEventCore(eventId, 2, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, int arg1, int arg2, int arg3)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[3];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 4;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->DataPointer = (IntPtr)(&arg3);
			((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->Size = 4;
			WriteEventCore(eventId, 3, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, long arg1)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[1];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			WriteEventCore(eventId, 1, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, long arg1, long arg2)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[2];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 8;
			WriteEventCore(eventId, 2, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, long arg1, long arg2, long arg3)
	{
		if (_0xH5alitosis)
		{
			EventData* ptr = stackalloc EventData[3];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 8;
			((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->DataPointer = (IntPtr)(&arg3);
			((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->Size = 8;
			WriteEventCore(eventId, 3, ptr);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1)
	{
		if (_0xH5alitosis)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr2 = arg1)
			{
				EventData* ptr = stackalloc EventData[1];
				ptr->DataPointer = (IntPtr)ptr2;
				ptr->Size = checked((arg1.Length + 1) * 2);
				WriteEventCore(eventId, 1, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1, string arg2)
	{
		if (!_0xH5alitosis)
		{
			return;
		}
		if (arg1 == null)
		{
			arg1 = "";
		}
		if (arg2 == null)
		{
			arg2 = "";
		}
		checked
		{
			fixed (char* ptr2 = arg1)
			{
				fixed (char* ptr3 = arg2)
				{
					EventData* ptr = stackalloc EventData[2];
					ptr->DataPointer = (IntPtr)ptr2;
					ptr->Size = (arg1.Length + 1) * 2;
					ptr[1].DataPointer = (IntPtr)ptr3;
					ptr[1].Size = (arg2.Length + 1) * 2;
					WriteEventCore(eventId, 2, ptr);
				}
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
	{
		if (!_0xH5alitosis)
		{
			return;
		}
		if (arg1 == null)
		{
			arg1 = "";
		}
		if (arg2 == null)
		{
			arg2 = "";
		}
		if (arg3 == null)
		{
			arg3 = "";
		}
		fixed (char* ptr2 = arg1)
		{
			fixed (char* ptr3 = arg2)
			{
				fixed (char* ptr4 = arg3)
				{
					EventData* ptr = stackalloc EventData[3];
					ptr->DataPointer = (IntPtr)ptr2;
					checked
					{
						ptr->Size = (arg1.Length + 1) * 2;
						ptr[1].DataPointer = (IntPtr)ptr3;
						ptr[1].Size = (arg2.Length + 1) * 2;
					}
					((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->DataPointer = (IntPtr)ptr4;
					((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->Size = checked((arg3.Length + 1) * 2);
					WriteEventCore(eventId, 3, ptr);
				}
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1, int arg2)
	{
		if (_0xH5alitosis)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr2 = arg1)
			{
				EventData* ptr = stackalloc EventData[2];
				ptr->DataPointer = (IntPtr)ptr2;
				ptr->Size = checked((arg1.Length + 1) * 2);
				ptr[1].DataPointer = (IntPtr)(&arg2);
				ptr[1].Size = 4;
				WriteEventCore(eventId, 2, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1, int arg2, int arg3)
	{
		if (_0xH5alitosis)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr2 = arg1)
			{
				EventData* ptr = stackalloc EventData[3];
				ptr->DataPointer = (IntPtr)ptr2;
				ptr->Size = checked((arg1.Length + 1) * 2);
				ptr[1].DataPointer = (IntPtr)(&arg2);
				ptr[1].Size = 4;
				((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->DataPointer = (IntPtr)(&arg3);
				((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->Size = 4;
				WriteEventCore(eventId, 3, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, string arg1, long arg2)
	{
		if (_0xH5alitosis)
		{
			if (arg1 == null)
			{
				arg1 = "";
			}
			fixed (char* ptr2 = arg1)
			{
				EventData* ptr = stackalloc EventData[2];
				ptr->DataPointer = (IntPtr)ptr2;
				ptr->Size = checked((arg1.Length + 1) * 2);
				ptr[1].DataPointer = (IntPtr)(&arg2);
				ptr[1].Size = 8;
				WriteEventCore(eventId, 2, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, long arg1, string arg2)
	{
		if (_0xH5alitosis)
		{
			if (arg2 == null)
			{
				arg2 = "";
			}
			fixed (char* ptr2 = arg2)
			{
				EventData* ptr = stackalloc EventData[2];
				ptr->DataPointer = (IntPtr)(&arg1);
				ptr->Size = 8;
				ptr[1].DataPointer = (IntPtr)ptr2;
				ptr[1].Size = checked((arg2.Length + 1) * 2);
				WriteEventCore(eventId, 2, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, int arg1, string arg2)
	{
		if (_0xH5alitosis)
		{
			if (arg2 == null)
			{
				arg2 = "";
			}
			fixed (char* ptr2 = arg2)
			{
				EventData* ptr = stackalloc EventData[2];
				ptr->DataPointer = (IntPtr)(&arg1);
				ptr->Size = 4;
				ptr[1].DataPointer = (IntPtr)ptr2;
				ptr[1].Size = checked((arg2.Length + 1) * 2);
				WriteEventCore(eventId, 2, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, byte[] arg1)
	{
		if (_0xH5alitosis)
		{
			if (arg1 == null)
			{
				arg1 = new byte[0];
			}
			int size = arg1.Length;
			fixed (byte* ptr2 = &arg1[0])
			{
				EventData* ptr = stackalloc EventData[2];
				ptr->DataPointer = (IntPtr)(&size);
				ptr->Size = 4;
				ptr[1].DataPointer = (IntPtr)ptr2;
				ptr[1].Size = size;
				WriteEventCore(eventId, 2, ptr);
			}
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, long arg1, byte[] arg2)
	{
		if (_0xH5alitosis)
		{
			if (arg2 == null)
			{
				arg2 = new byte[0];
			}
			int size = arg2.Length;
			fixed (byte* ptr2 = &arg2[0])
			{
				EventData* ptr = stackalloc EventData[3];
				ptr->DataPointer = (IntPtr)(&arg1);
				ptr->Size = 8;
				ptr[1].DataPointer = (IntPtr)(&size);
				ptr[1].Size = 4;
				((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->DataPointer = (IntPtr)ptr2;
				((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->Size = size;
				WriteEventCore(eventId, 3, ptr);
			}
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventData* data)
	{
		WriteEventWithRelatedActivityIdCore(eventId, null, eventDataCount, data);
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventData* data)
	{
		if (!_0xH5alitosis)
		{
			return;
		}
		try
		{
			if (relatedActivityId != null)
			{
				_0xHPillo0ing(ref _0xHTran3udation3[eventId]);
			}
			_0xHK7z7tsky _0xHS0lfinpyrazone = (_0xHK7z7tsky)_0xHTran3udation3[eventId]._0xHOmn4vorous._0xHS0lfinpyrazone;
			_0xHHyp2ra2sth2sia _0xHBe0hout = _0xHTran3udation3[eventId]._0xHBe0hout0;
			Guid* ptr = null;
			Guid _0xHPe77etizer = Guid.Empty;
			Guid _0xHSco1tmasters = Guid.Empty;
			if (_0xHS0lfinpyrazone != 0 && relatedActivityId == null && (_0xHBe0hout & _0xHHyp2ra2sth2sia.Disable) == 0)
			{
				switch (_0xHS0lfinpyrazone)
				{
				case _0xHK7z7tsky.Start:
					_0xHNewsdea0ers._0xH0holos(_0xHFil4ture, _0xHTran3udation3[eventId]._0xHChol3nes, _0xHTran3udation3[eventId]._0xHOmn4vorous._0xHMun6c6pal, ref _0xHPe77etizer, ref _0xHSco1tmasters, _0xHTran3udation3[eventId]._0xHBe0hout0);
					break;
				case _0xHK7z7tsky.Stop:
					_0xHNewsdea0ers._0xHCarho7s(_0xHFil4ture, _0xHTran3udation3[eventId]._0xHChol3nes, _0xHTran3udation3[eventId]._0xHOmn4vorous._0xHMun6c6pal, ref _0xHPe77etizer);
					break;
				}
				if (_0xHPe77etizer != Guid.Empty)
				{
					ptr = &_0xHPe77etizer;
				}
				if (_0xHSco1tmasters != Guid.Empty)
				{
					relatedActivityId = &_0xHSco1tmasters;
				}
			}
			if (!_0xHUng3nt33l)
			{
				if (!_0xHU3derli3i3g._0xHPote5t(ref _0xHTran3udation3[eventId]._0xHOmn4vorous, ptr, relatedActivityId, eventDataCount, (IntPtr)data))
				{
					_0xHThicke6();
				}
			}
			else
			{
				_0xHOffscouri5gs _0xHOffscouri5gs = _0xHTran3udation3[eventId]._0xH2axers;
				if (_0xHOffscouri5gs == null)
				{
					_0xHOffscouri5gs = new _0xHOffscouri5gs(_0xHTran3udation3[eventId]._0xHChol3nes, _0xHTran3udation3[eventId]._0xHSepta1ia, _0xHTran3udation3[eventId]._0xHP4nst4r);
					Interlocked.CompareExchange(ref _0xHTran3udation3[eventId]._0xH2axers, _0xHOffscouri5gs, null);
				}
				_0xHDenotab4e _0xHDenotab4e = default(_0xHDenotab4e);
				_0xHDenotab4e._0xHOe0ophagu0 = (_0xHSov8r8ignti8s)_0xHTran3udation3[eventId]._0xHOmn4vorous._0xHM5rc5tos;
				_0xHDenotab4e._0xHPo7ularising = (_0xHFire0ots)_0xHTran3udation3[eventId]._0xHOmn4vorous._0xHPu4posefully;
				_0xHDenotab4e._0xHEne2gumen = (_0xHK7z7tsky)_0xHTran3udation3[eventId]._0xHOmn4vorous._0xHS0lfinpyrazone;
				_0xHDenotab4e _0xHTailo1ing = _0xHDenotab4e;
				_0xHB0rliest(_0xHTran3udation3[eventId]._0xHChol3nes, ref _0xHTailo1ing, _0xHOffscouri5gs, ptr, relatedActivityId, data);
			}
			if (_0xHInc4nerat4on != null && _0xHTran3udation3[eventId]._0xH7in)
			{
				_0xHMi6inter(eventId, relatedActivityId, eventDataCount, data);
			}
		}
		catch (Exception ex)
		{
			if (ex is _0xHSupersurgeo7)
			{
				throw;
			}
			_0xHThicke6(ex);
		}
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEvent(int eventId, params object[] args)
	{
		_0xHCorp2lencies(eventId, null, args);
	}

	[SecuritySafeCritical]
	protected unsafe void WriteEventWithRelatedActivityId(int eventId, Guid relatedActivityId, params object[] args)
	{
		_0xHCorp2lencies(eventId, &relatedActivityId, args);
	}

	public void _0xHKron0()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (_0xH5alitosis)
			{
				try
				{
					_0xHBedu5ns(_0xHCei3i);
				}
				catch (Exception)
				{
				}
				_0xH5alitosis = false;
			}
			if (_0xHU3derli3i3g != null)
			{
				_0xHU3derli3i3g._0xHAta7hans();
				_0xHU3derli3i3g = null;
			}
		}
		_0xH5alitosis = false;
	}

	~_0xH2wooned()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private unsafe void _0xHS7l7cos7s(ref _0xHMonocrac1es _0xHSavour8ng, Guid* _0xHDena5i, Guid* _0xHSolg0l, int _0xHCyto4ine, IntPtr _0xHLi5ter)
	{
		if (_0xHU3derli3i3g == null)
		{
			_0xHThicke6();
		}
		else if (!_0xHU3derli3i3g._0xHAnviltop5(ref _0xHSavour8ng, _0xHDena5i, _0xHSolg0l, _0xHCyto4ine, _0xHLi5ter))
		{
			_0xHThicke6();
		}
	}

	internal _0xH2wooned(Guid eventSourceGuid, string eventSourceName)
		: this(eventSourceGuid, eventSourceName, _0xHOvera2e.EtwManifestEventFormat)
	{
	}

	internal _0xH2wooned(Guid eventSourceGuid, string eventSourceName, _0xHOvera2e settings, string[] traits = null)
	{
		_0xH4nlooker = _0xHShive1(settings);
		_0xHAnti0ogarithms(eventSourceGuid, eventSourceName, traits);
	}

	[SecuritySafeCritical]
	private unsafe void _0xHAnti0ogarithms(Guid _0xHInfli5ht, string _0xHInl7cing, string[] _0xHAntita4)
	{
		try
		{
			_0xHOverde1ign = _0xHAntita4;
			if (_0xHOverde1ign != null && _0xHOverde1ign.Length % 2 != 0)
			{
				throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("TraitEven"), "traits");
			}
			if (_0xHInfli5ht == Guid.Empty)
			{
				throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NeedGuid"));
			}
			if (_0xHInl7cing == null)
			{
				throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NeedName"));
			}
			_0xHFil4ture = _0xHInl7cing;
			_0xHOpaquin4 = _0xHInfli5ht;
			_0xHNewsdea0ers = _0xH7emmying._0xH6ennel;
			_0xHCh3c3latiers();
			_0xHC2urant2s _0xHC2urant2s = new _0xHC2urant2s(this);
			_0xHC2urant2s._0xHH77kah(_0xHInfli5ht);
			_0xHBelletri8t._0xHInter8orly(this);
			_0xHU3derli3i3g = _0xHC2urant2s;
			try
			{
				fixed (IntPtr* _0xHTr8nquil = _0xHU5dreamed)
				{
					_0xHU3derli3i3g._0xHSneeze0eeds(_0xH7ozier._0xHR7sum7d._0xHC6bernetical.SetTraits, _0xHTr8nquil, _0xHU5dreamed.Length);
				}
			}
			finally
			{
			}
			_0xHExp7nentiati7n = true;
		}
		catch (Exception ex)
		{
			if (_0xHArr4y4 == null)
			{
				_0xHArr4y4 = ex;
			}
			_0xHZ8mbi("ERROR: Exception during construction of _0xH2wooned " + _0xHAs2ribed + ": " + ex.Message, _0xHReu3e: true);
		}
		lock (_0xHBelletri8t._0xHL0ticifers)
		{
			for (_0xHEcholocat3ons _0xHE0itomising = _0xHLumpis2; _0xHE0itomising != null; _0xHE0itomising = _0xHE0itomising._0xHE0itomising)
			{
				_0xHAmbi4nt(_0xHE0itomising);
			}
		}
	}

	private static string _0xHIrri8a8ion(Type _0xH0hy, _0xHAquapla5er _0xHDo7os)
	{
		if (_0xH0hy == null)
		{
			throw new ArgumentNullException("eventSourceType");
		}
		_0xHHelilift6 _0xHHelilift = (_0xHHelilift6)_0xHCompa7atist(_0xH0hy, typeof(_0xHHelilift6), _0xHDo7os);
		if (_0xHHelilift != null && _0xHHelilift._0xHFuchs3nes != null)
		{
			return _0xHHelilift._0xHFuchs3nes;
		}
		return _0xH0hy.Name;
	}

	private static Guid _0xHHulloe3(string _0xHR0f00ds)
	{
		byte[] array = Encoding.BigEndianUnicode.GetBytes(_0xHR0f00ds);
		_0xHTro1hes _0xHTro1hes = default(_0xHTro1hes);
		_0xHTro1hes._0xHO22ult();
		_0xHTro1hes._0xHBieldi2g(_0xHAnos1atic);
		_0xHTro1hes._0xHBieldi2g(array);
		Array.Resize(ref array, 16);
		_0xHTro1hes._0xHTonearm3(array);
		array[7] = (byte)((array[7] & 0xFu) | 0x50u);
		return new Guid(array);
	}

	[SecurityCritical]
	private unsafe object _0xHJ66p(int _0xHApp7ndag7s, int _0xHSqua4derers, ref EventData* _0xHWar6resses)
	{
		IntPtr dataPointer = _0xHWar6resses->DataPointer;
		Type type;
		checked
		{
			_0xHWar6resses++;
			type = _0xHTran3udation3[_0xHApp7ndag7s]._0xHP4nst4r[_0xHSqua4derers].ParameterType;
		}
		while (true)
		{
			if (!(type == typeof(IntPtr)))
			{
				if (!(type == typeof(int)))
				{
					if (!(type == typeof(uint)))
					{
						if (!(type == typeof(long)))
						{
							if (!(type == typeof(ulong)))
							{
								if (!(type == typeof(byte)))
								{
									if (!(type == typeof(sbyte)))
									{
										if (!(type == typeof(short)))
										{
											if (!(type == typeof(ushort)))
											{
												if (!(type == typeof(float)))
												{
													if (!(type == typeof(double)))
													{
														if (!(type == typeof(decimal)))
														{
															if (!(type == typeof(bool)))
															{
																if (!(type == typeof(Guid)))
																{
																	if (!(type == typeof(char)))
																	{
																		if (!(type == typeof(DateTime)))
																		{
																			if (!(type == typeof(byte[])))
																			{
																				if (!(type == typeof(byte*)))
																				{
																					if (!type._0xH6igout())
																					{
																						break;
																					}
																					type = Enum.GetUnderlyingType(type);
																					continue;
																				}
																				return null;
																			}
																			int num = *(int*)(void*)dataPointer;
																			byte[] array = new byte[num];
																			dataPointer = _0xHWar6resses->DataPointer;
																			checked
																			{
																				_0xHWar6resses++;
																				for (int i = 0; i < num; i++)
																				{
																					array[i] = *unchecked((byte*)(void*)dataPointer);
																				}
																				return array;
																			}
																		}
																		long fileTime = *(long*)(void*)dataPointer;
																		return DateTime.FromFileTimeUtc(fileTime);
																	}
																	return *(char*)(void*)dataPointer;
																}
																return *(Guid*)(void*)dataPointer;
															}
															if (*(int*)(void*)dataPointer == 1)
															{
																return true;
															}
															return false;
														}
														return *(decimal*)(void*)dataPointer;
													}
													return *(double*)(void*)dataPointer;
												}
												return *(float*)(void*)dataPointer;
											}
											return *(ushort*)(void*)dataPointer;
										}
										return *(short*)(void*)dataPointer;
									}
									return *(sbyte*)(void*)dataPointer;
								}
								return *(byte*)(void*)dataPointer;
							}
							return *(ulong*)(void*)dataPointer;
						}
						return *(long*)(void*)dataPointer;
					}
					return *(uint*)(void*)dataPointer;
				}
				return *(int*)(void*)dataPointer;
			}
			return *(IntPtr*)(void*)dataPointer;
		}
		return Marshal.PtrToStringUni(dataPointer);
	}

	private _0xHGh0bl0 _0xHCl2morer(_0xHBelletri8t _0xHB6heas)
	{
		_0xHGh0bl0 _0xHCraftin0ss = _0xHInc4nerat4on;
		while (true)
		{
			if (_0xHCraftin0ss != null)
			{
				if (_0xHCraftin0ss._0xHBac5shores == _0xHB6heas)
				{
					break;
				}
				_0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss;
				continue;
			}
			return _0xHCraftin0ss;
		}
		return _0xHCraftin0ss;
	}

	[SecurityCritical]
	private unsafe void _0xHCorp2lencies(int _0xHBo5rns, Guid* _0xHK8t8s, object[] _0xHRetre3ds)
	{
		if (!_0xH5alitosis)
		{
			return;
		}
		try
		{
			if (_0xHK8t8s != null)
			{
				_0xHPillo0ing(ref _0xHTran3udation3[_0xHBo5rns]);
				if (!_0xHTran3udation3[_0xHBo5rns]._0xH5aludism)
				{
					throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NoRelatedActivityId"));
				}
			}
			_0xHPreele8tri8(_0xHTran3udation3[_0xHBo5rns]._0xHP4nst4r, _0xHRetre3ds);
			Guid* ptr = null;
			Guid _0xHPe77etizer = Guid.Empty;
			Guid _0xHSco1tmasters = Guid.Empty;
			_0xHK7z7tsky _0xHS0lfinpyrazone = (_0xHK7z7tsky)_0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHS0lfinpyrazone;
			_0xHHyp2ra2sth2sia _0xHBe0hout = _0xHTran3udation3[_0xHBo5rns]._0xHBe0hout0;
			if (_0xHK8t8s == null && (_0xHBe0hout & _0xHHyp2ra2sth2sia.Disable) == 0)
			{
				switch (_0xHS0lfinpyrazone)
				{
				case _0xHK7z7tsky.Start:
					_0xHNewsdea0ers._0xH0holos(_0xHFil4ture, _0xHTran3udation3[_0xHBo5rns]._0xHChol3nes, _0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHMun6c6pal, ref _0xHPe77etizer, ref _0xHSco1tmasters, _0xHTran3udation3[_0xHBo5rns]._0xHBe0hout0);
					break;
				case _0xHK7z7tsky.Stop:
					_0xHNewsdea0ers._0xHCarho7s(_0xHFil4ture, _0xHTran3udation3[_0xHBo5rns]._0xHChol3nes, _0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHMun6c6pal, ref _0xHPe77etizer);
					break;
				}
				if (_0xHPe77etizer != Guid.Empty)
				{
					ptr = &_0xHPe77etizer;
				}
				if (_0xHSco1tmasters != Guid.Empty)
				{
					_0xHK8t8s = &_0xHSco1tmasters;
				}
			}
			if (!_0xHUng3nt33l)
			{
				if (!_0xHU3derli3i3g._0xHBully2agged(ref _0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous, ptr, _0xHK8t8s, _0xHRetre3ds))
				{
					_0xHThicke6();
				}
			}
			else
			{
				_0xHOffscouri5gs _0xHOffscouri5gs = _0xHTran3udation3[_0xHBo5rns]._0xH2axers;
				if (_0xHOffscouri5gs == null)
				{
					_0xHOffscouri5gs = new _0xHOffscouri5gs(_0xHTran3udation3[_0xHBo5rns]._0xHChol3nes, _0xHParam0t0riz0.None, _0xHTran3udation3[_0xHBo5rns]._0xHP4nst4r);
					Interlocked.CompareExchange(ref _0xHTran3udation3[_0xHBo5rns]._0xH2axers, _0xHOffscouri5gs, null);
				}
				_0xHDenotab4e _0xHDenotab4e = default(_0xHDenotab4e);
				_0xHDenotab4e._0xHOe0ophagu0 = (_0xHSov8r8ignti8s)_0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHM5rc5tos;
				_0xHDenotab4e._0xHPo7ularising = (_0xHFire0ots)_0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHPu4posefully;
				_0xHDenotab4e._0xHEne2gumen = (_0xHK7z7tsky)_0xHTran3udation3[_0xHBo5rns]._0xHOmn4vorous._0xHS0lfinpyrazone;
				_0xHDenotab4e _0xHCoc4aded = _0xHDenotab4e;
				_0xHRa6ier(_0xHTran3udation3[_0xHBo5rns]._0xHChol3nes, ref _0xHCoc4aded, _0xHOffscouri5gs, ptr, _0xHK8t8s, _0xHRetre3ds);
			}
			if (_0xHInc4nerat4on != null && _0xHTran3udation3[_0xHBo5rns]._0xH7in)
			{
				object[] _0xHOv6r6xp6ctation = _0xHRa0e(_0xHBo5rns, _0xHRetre3ds);
				_0xHBar5stormers(_0xHBo5rns, _0xHK8t8s, _0xHOv6r6xp6ctation);
			}
		}
		catch (Exception ex)
		{
			if (ex is _0xHSupersurgeo7)
			{
				throw;
			}
			_0xHThicke6(ex);
		}
	}

	[SecurityCritical]
	private object[] _0xHRa0e(int _0xHNative7, object[] _0xHCarpetweed1)
	{
		_0xHOffscouri5gs _0xHOffscouri5gs = _0xHTran3udation3[_0xHNative7]._0xH2axers;
		if (_0xHOffscouri5gs == null)
		{
			_0xHOffscouri5gs = new _0xHOffscouri5gs(_0xHTran3udation3[_0xHNative7]._0xHChol3nes, _0xHParam0t0riz0.None, _0xHTran3udation3[_0xHNative7]._0xHP4nst4r);
			Interlocked.CompareExchange(ref _0xHTran3udation3[_0xHNative7]._0xH2axers, _0xHOffscouri5gs, null);
		}
		object[] array = new object[_0xHOffscouri5gs._0xHScruffi7esses.Length];
		for (int i = 0; i < _0xHOffscouri5gs._0xHScruffi7esses.Length; i = checked(i + 1))
		{
			array[i] = _0xHOffscouri5gs._0xHScruffi7esses[i]._0xHAm7nd7rs(_0xHCarpetweed1[i]);
		}
		return array;
	}

	private void _0xHPreele8tri8(ParameterInfo[] _0xHLaminat6d, object[] _0xH0rilling)
	{
		bool flag = _0xH0rilling.Length == _0xHLaminat6d.Length;
		int num = 0;
		while (flag && num < _0xH0rilling.Length)
		{
			Type parameterType = _0xHLaminat6d[num].ParameterType;
			if ((_0xH0rilling[num] == null || !(_0xH0rilling[num].GetType() != parameterType)) && (_0xH0rilling[num] != null || (parameterType.IsGenericType && parameterType.GetGenericTypeDefinition() == typeof(Nullable<>))))
			{
				num = checked(num + 1);
				continue;
			}
			flag = false;
			break;
		}
		if (!flag)
		{
			Debugger.Log(0, null, _0xHA2eotropy._0xHSpon8or("_0xH2wooned_VarArgsParameterMismatch") + "\r\n");
		}
	}

	[SecurityCritical]
	private unsafe void _0xHMi6inter(int _0xHPantot1enate, Guid* _0xHSe2syns, int _0xHCiner5ri5s, EventData* _0xH7noring)
	{
		int num = _0xHTran3udation3[_0xHPantot1enate]._0xHP4nst4r.Length;
		if (_0xHCiner5ri5s != num)
		{
			_0xHZ8mbi(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventParametersMismatch", _0xHPantot1enate, _0xHCiner5ri5s, num), _0xHReu3e: true);
			num = Math.Min(num, _0xHCiner5ri5s);
		}
		object[] array = new object[num];
		EventData* _0xHWar6resses = _0xH7noring;
		for (int i = 0; i < num; i = checked(i + 1))
		{
			array[i] = _0xHJ66p(_0xHPantot1enate, i, ref _0xHWar6resses);
		}
		_0xHBar5stormers(_0xHPantot1enate, _0xHSe2syns, array);
	}

	[SecurityCritical]
	private unsafe void _0xHBar5stormers(int _0xHPillb3xes, Guid* _0xHLeaver1, params object[] _0xHOv6r6xp6ctation)
	{
		_0xHMercif4lnesses _0xHMercif4lnesses = new _0xHMercif4lnesses(this);
		_0xHMercif4lnesses._0xHL1bs = _0xHPillb3xes;
		if (_0xHLeaver1 != null)
		{
			_0xHMercif4lnesses._0xH2rahma = *_0xHLeaver1;
		}
		_0xHMercif4lnesses._0xHSaur5an = _0xHTran3udation3[_0xHPillb3xes]._0xHChol3nes;
		_0xHMercif4lnesses._0xH3rubbiness = _0xHTran3udation3[_0xHPillb3xes]._0xHDel4e;
		_0xHMercif4lnesses._0xHC4mer4men = new ReadOnlyCollection<object>(_0xHOv6r6xp6ctation);
		_0xHFerroele5tri5s(_0xHPillb3xes, _0xHLeaver1, _0xHMercif4lnesses);
	}

	[SecurityCritical]
	private unsafe void _0xHFerroele5tri5s(int _0xH1unbath, Guid* _0xHT2r2ids, _0xHMercif4lnesses _0xH1owdier)
	{
		Exception ex = null;
		for (_0xHGh0bl0 _0xHCraftin0ss = _0xHInc4nerat4on; _0xHCraftin0ss != null; _0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss)
		{
			if (_0xH1unbath == -1 || _0xHCraftin0ss._0xHShe7terbe7t[_0xH1unbath])
			{
				try
				{
					_0xHCraftin0ss._0xHBac5shores._0xHTorn8llos(_0xH1owdier);
				}
				catch (Exception ex2)
				{
					_0xHZ8mbi("ERROR: Exception during _0xH2wooned.OnEventWritten: " + ex2.Message, _0xHReu3e: false);
					ex = ex2;
				}
			}
		}
		if (ex != null)
		{
			throw new _0xHSupersurgeo7(ex);
		}
	}

	[SecuritySafeCritical]
	private unsafe void _0xHSupercoo5ed(_0xHFire0ots _0xHNecessitate3, long _0xHNonnati4e, string _0xHCocu5tured)
	{
		if (_0xHU3derli3i3g == null)
		{
			return;
		}
		string text = "_0xH2woonedMessage";
		if (_0xHUng3nt33l)
		{
			_0xHDenotab4e _0xHDenotab4e = default(_0xHDenotab4e);
			_0xHDenotab4e._0xHOe0ophagu0 = (_0xHSov8r8ignti8s)_0xHNonnati4e;
			_0xHDenotab4e._0xHPo7ularising = _0xHNecessitate3;
			_0xHDenotab4e _0xHP1id = _0xHDenotab4e;
			var anon = new
			{
				message = _0xHCocu5tured
			};
			_0xHOffscouri5gs _0xHTa7ny = new _0xHOffscouri5gs(text, _0xHParam0t0riz0.None, anon.GetType());
			_0xH2ungs(text, ref _0xHP1id, _0xHTa7ny, null, null, anon);
			return;
		}
		if (_0xHCei3i == null && _0xHS6phon == 1)
		{
			_0xHDevotion3lly _0xHDevotion3lly = new _0xHDevotion3lly(_0xHAs2ribed, _0xHZo2al, _0xHAs2ribed, null, _0xHAquapla5er.None);
			_0xHDevotion3lly._0xHU2size(text, new _0xHSkiff4ed(0)
			{
				_0xHPas6eurizers = _0xHFire0ots.LogAlways,
				_0xHCha00elizes = (_0xHIn1lows)65534
			});
			_0xHDevotion3lly._0xHTam3s(typeof(string), "message");
			_0xHDevotion3lly._0xHDeclina6ions();
			_0xHBedu5ns(_0xHDevotion3lly._0xHC6nstructi6ns());
		}
		fixed (char* ptr = _0xHCocu5tured)
		{
			_0xHMonocrac1es _0xHD5mur5ly = new _0xHMonocrac1es(0, 0, 0, checked((byte)_0xHNecessitate3), 0, 0, _0xHNonnati4e);
			_0xHRi3u3e3._0xHImme1sing _0xHImme1sing = default(_0xHRi3u3e3._0xHImme1sing);
			_0xHImme1sing._0xHLam7nt7r = (ulong)ptr;
			_0xHImme1sing._0xHMult6p6ston = checked((uint)(2 * (_0xHCocu5tured.Length + 1)));
			_0xHImme1sing._0xHRail2ays = 0u;
			_0xHU3derli3i3g._0xHPote5t(ref _0xHD5mur5ly, null, null, 1, (IntPtr)(&_0xHImme1sing));
		}
	}

	private void _0xHAntich4or(string _0xH3efrigerate, string _0xH0immers)
	{
		_0xHMercif4lnesses _0xHMercif4lnesses = new _0xHMercif4lnesses(this);
		_0xHMercif4lnesses._0xHL1bs = 0;
		_0xHMercif4lnesses._0xH3rubbiness = _0xH0immers;
		_0xHMercif4lnesses._0xHC4mer4men = new ReadOnlyCollection<object>(new List<object> { _0xH0immers });
		_0xHMercif4lnesses._0xH1etalware = new ReadOnlyCollection<string>(new List<string> { "message" });
		_0xHMercif4lnesses._0xHSaur5an = _0xH3efrigerate;
		for (_0xHGh0bl0 _0xHCraftin0ss = _0xHInc4nerat4on; _0xHCraftin0ss != null; _0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss)
		{
			bool flag = false;
			if (_0xHCraftin0ss._0xHShe7terbe7t == null)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < _0xHCraftin0ss._0xHShe7terbe7t.Length; i = checked(i + 1))
				{
					if (_0xHCraftin0ss._0xHShe7terbe7t[i])
					{
						flag = true;
						break;
					}
				}
			}
			try
			{
				if (flag)
				{
					_0xHCraftin0ss._0xHBac5shores._0xHTorn8llos(_0xHMercif4lnesses);
				}
			}
			catch
			{
			}
		}
	}

	private bool _0xHInter6ector(int _0xHPo33ling, bool _0xHIodize7, _0xHFire0ots _0xHLu1acies, _0xHSov8r8ignti8s _0xHLope7s)
	{
		if (!_0xHIodize7)
		{
			return false;
		}
		_0xHFire0ots _0xHPu4posefully = (_0xHFire0ots)_0xHTran3udation3[_0xHPo33ling]._0xHOmn4vorous._0xHPu4posefully;
		_0xHSov8r8ignti8s _0xHVic0imiza0ions = (_0xHSov8r8ignti8s)(_0xHTran3udation3[_0xHPo33ling]._0xHOmn4vorous._0xHM5rc5tos & (long)(~_0xHEggb4at4rs._0xHIn1pect1._0xHBulla5e()));
		_0xHSummar4ses _0xHAbste2tio = (_0xHSummar4ses)_0xHTran3udation3[_0xHPo33ling]._0xHOmn4vorous._0xHAbste2tio2;
		return _0xHRemappe8(_0xHIodize7, _0xHLu1acies, _0xHLope7s, _0xHPu4posefully, _0xHVic0imiza0ions, _0xHAbste2tio);
	}

	private bool _0xHRemappe8(bool _0xH5ushed, _0xHFire0ots _0xHD1viationist, _0xHSov8r8ignti8s _0xHAfflictio3s, _0xHFire0ots _0xHPa1thenogenesis, _0xHSov8r8ignti8s _0xHVic0imiza0ions, _0xHSummar4ses _0xHCh2rr)
	{
		if (!_0xH5ushed)
		{
			return false;
		}
		if (_0xHD1viationist != 0 && _0xHD1viationist < _0xHPa1thenogenesis)
		{
			return false;
		}
		if (_0xHAfflictio3s != _0xHSov8r8ignti8s.None && _0xHVic0imiza0ions != _0xHSov8r8ignti8s.None)
		{
			if (_0xHCh2rr != 0 && _0xHSuperm4l4tants != null && _0xHSuperm4l4tants.Length > (int)_0xHCh2rr)
			{
				_0xHSov8r8ignti8s _0xHSov8r8ignti8s = (_0xHSov8r8ignti8s)((long)_0xHSuperm4l4tants[(uint)_0xHCh2rr] | (long)_0xHVic0imiza0ions);
				if (_0xHSov8r8ignti8s != _0xHSov8r8ignti8s.None && (_0xHSov8r8ignti8s & _0xHAfflictio3s) == _0xHSov8r8ignti8s.None)
				{
					return false;
				}
			}
			else if ((_0xHVic0imiza0ions & _0xHAfflictio3s) == _0xHSov8r8ignti8s.None)
			{
				return false;
			}
		}
		return true;
	}

	private void _0xHThicke6(Exception _0xHW8adwaxen = null)
	{
		if (_0xHNo3cultivatio3 > 0)
		{
			return;
		}
		checked
		{
			try
			{
				_0xHNo3cultivatio3 = (byte)unchecked((int)checked(unchecked((uint)_0xHNo3cultivatio3) + 1u));
				switch (_0xHRi3u3e3._0xHReus4bles())
				{
				case _0xHRi3u3e3._0xH3earlessly.NoFreeBuffers:
					_0xHZ8mbi("_0xH2woonedException: " + _0xHA2eotropy._0xHSpon8or("_0xH2wooned_NoFreeBuffers"), _0xHReu3e: true);
					if (_0xHMo1thily)
					{
						throw new _0xHSupersurgeo7(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NoFreeBuffers"), _0xHW8adwaxen);
					}
					return;
				case _0xHRi3u3e3._0xH3earlessly.EventTooBig:
					_0xHZ8mbi("_0xH2woonedException: " + _0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventTooBig"), _0xHReu3e: true);
					if (_0xHMo1thily)
					{
						throw new _0xHSupersurgeo7(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventTooBig"), _0xHW8adwaxen);
					}
					return;
				case _0xHRi3u3e3._0xH3earlessly.NullInput:
					_0xHZ8mbi("_0xH2woonedException: " + _0xHA2eotropy._0xHSpon8or("_0xH2wooned_NullInput"), _0xHReu3e: true);
					if (_0xHMo1thily)
					{
						throw new _0xHSupersurgeo7(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NullInput"), _0xHW8adwaxen);
					}
					return;
				case _0xHRi3u3e3._0xH3earlessly.TooManyArgs:
					_0xHZ8mbi("_0xH2woonedException: " + _0xHA2eotropy._0xHSpon8or("_0xH2wooned_TooManyArgs"), _0xHReu3e: true);
					if (_0xHMo1thily)
					{
						throw new _0xHSupersurgeo7(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_TooManyArgs"), _0xHW8adwaxen);
					}
					return;
				}
				if (_0xHW8adwaxen != null)
				{
					_0xHZ8mbi(string.Concat("_0xH2woonedException: ", _0xHW8adwaxen.GetType(), ":", _0xHW8adwaxen.Message), _0xHReu3e: true);
				}
				else
				{
					_0xHZ8mbi("_0xH2woonedException", _0xHReu3e: true);
				}
				if (_0xHMo1thily)
				{
					throw new _0xHSupersurgeo7(_0xHW8adwaxen);
				}
			}
			finally
			{
				_0xHNo3cultivatio3 = (byte)unchecked((int)checked(unchecked((uint)_0xHNo3cultivatio3) - 1u));
			}
		}
	}

	private void _0xHPillo0ing(ref _0xHDecl7nat7onal _0xHHemich8rdate)
	{
		if (_0xHHemich8rdate._0xHOmn4vorous._0xHS0lfinpyrazone != 9 && _0xHHemich8rdate._0xHOmn4vorous._0xHS0lfinpyrazone != 240 && _0xHHemich8rdate._0xHOmn4vorous._0xHS0lfinpyrazone != 1)
		{
			_0xHThicke6();
		}
	}

	internal static _0xHK7z7tsky _0xHPros1lytis1(_0xHK7z7tsky _0xHG8abe88a, string _0xHGu2dewords)
	{
		if (_0xHG8abe88a == _0xHK7z7tsky.Info && _0xHGu2dewords != null)
		{
			if (_0xHGu2dewords.EndsWith("Start"))
			{
				return _0xHK7z7tsky.Start;
			}
			if (_0xHGu2dewords.EndsWith("Stop"))
			{
				return _0xHK7z7tsky.Stop;
			}
		}
		return _0xHG8abe88a;
	}

	internal void _0xHMechan4sts(_0xHBelletri8t _0xHAbsolu6is6s, int _0xHReconcil0bility, int _0xHB3re, _0xHNonequa5 _0xHM0l00, bool _0xHEx8cut8s, _0xHFire0ots _0xHRati4ned, _0xHSov8r8ignti8s _0xHButtin2ki2, IDictionary<string, string> _0xHMislea1)
	{
		_0xHEcholocat3ons _0xHEcholocat3ons = new _0xHEcholocat3ons(_0xHM0l00, _0xHMislea1, this, _0xHAbsolu6is6s, _0xHReconcil0bility, _0xHB3re, _0xHEx8cut8s, _0xHRati4ned, _0xHButtin2ki2);
		lock (_0xHBelletri8t._0xHL0ticifers)
		{
			if (_0xHExp7nentiati7n)
			{
				_0xHLumpis2 = null;
				_0xHAmbi4nt(_0xHEcholocat3ons);
			}
			else
			{
				_0xHEcholocat3ons._0xHE0itomising = _0xHLumpis2;
				_0xHLumpis2 = _0xHEcholocat3ons;
			}
		}
	}

	internal void _0xHAmbi4nt(_0xHEcholocat3ons _0xHBosu1s)
	{
		if (_0xHU3derli3i3g == null)
		{
			return;
		}
		_0xHS6phon = 0;
		if (_0xHBosu1s._0xHSarcoma8a > 0)
		{
		}
		checked
		{
			try
			{
				_0xH8uoy();
				_0xHBosu1s._0xHKoi4e = _0xHCl2morer(_0xHBosu1s._0xHR0chann0ls);
				if (_0xHBosu1s._0xHKoi4e == null && _0xHBosu1s._0xHR0chann0ls != null)
				{
					throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_ListenerNotFound"));
				}
				if (_0xHBosu1s._0xH5btundent == null)
				{
					_0xHBosu1s._0xH5btundent = new Dictionary<string, string>();
				}
				if (_0xHBosu1s._0xHGno2obio2ic == _0xHNonequa5.Update)
				{
					for (int i = 0; i < _0xHTran3udation3.Length; i++)
					{
						_0xHWi2try(_0xHBosu1s._0xHKoi4e, i, _0xHInter6ector(i, _0xHBosu1s._0xHT0los, _0xHBosu1s._0xHW0terweed, _0xHBosu1s._0xHPapist1y));
					}
					if (_0xHBosu1s._0xHT0los)
					{
						if (!_0xH5alitosis)
						{
							_0xH7dvections = _0xHBosu1s._0xHW0terweed;
							_0xHTransversel4 = _0xHBosu1s._0xHPapist1y;
						}
						else
						{
							if (_0xHBosu1s._0xHW0terweed > _0xH7dvections)
							{
								_0xH7dvections = _0xHBosu1s._0xHW0terweed;
							}
							if (_0xHBosu1s._0xHPapist1y == _0xHSov8r8ignti8s.None)
							{
								_0xHTransversel4 = _0xHSov8r8ignti8s.None;
							}
							else if (_0xHTransversel4 != _0xHSov8r8ignti8s.None)
							{
								_0xHTransversel4 |= _0xHBosu1s._0xHPapist1y;
							}
						}
					}
					bool flag = _0xHBosu1s._0xHSarcoma8a >= 0;
					if (_0xHBosu1s._0xHSarcoma8a == 0 && !_0xHBosu1s._0xHT0los)
					{
						flag = false;
					}
					if (_0xHBosu1s._0xHR0chann0ls == null)
					{
						if (!flag)
						{
							_0xHBosu1s._0xHSarcoma8a = -_0xHBosu1s._0xHSarcoma8a;
						}
						_0xHBosu1s._0xHSarcoma8a--;
					}
					_0xHBosu1s._0xHGno2obio2ic = (flag ? _0xHNonequa5.Enable : _0xHNonequa5.Disable);
					if (flag && _0xHBosu1s._0xHKoi4e == null && !_0xHUng3nt33l)
					{
						_0xHBedu5ns(_0xHCei3i);
					}
					if (_0xHBosu1s._0xHT0los)
					{
						_0xH5alitosis = true;
					}
					OnEventCommand(_0xHBosu1s);
					_0xHP7onologies?.Invoke(this, _0xHBosu1s);
					if (_0xHBosu1s._0xHT0los)
					{
						return;
					}
					for (int j = 0; j < _0xHTran3udation3.Length; j++)
					{
						bool _0xH7in = false;
						_0xHGh0bl0 _0xHCraftin0ss = _0xHInc4nerat4on;
						while (_0xHCraftin0ss != null)
						{
							if (!_0xHCraftin0ss._0xHShe7terbe7t[j])
							{
								_0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss;
								continue;
							}
							_0xH7in = true;
							break;
						}
						_0xHTran3udation3[j]._0xH7in = _0xH7in;
					}
					if (!_0xHM1tot1c())
					{
						_0xH7dvections = _0xHFire0ots.LogAlways;
						_0xHTransversel4 = _0xHSov8r8ignti8s.None;
						_0xH5alitosis = false;
					}
				}
				else
				{
					if (_0xHBosu1s._0xHGno2obio2ic == _0xHNonequa5.SendManifest && _0xHCei3i != null)
					{
						_0xHBedu5ns(_0xHCei3i);
					}
					OnEventCommand(_0xHBosu1s);
					_0xHP7onologies?.Invoke(this, _0xHBosu1s);
				}
			}
			catch (Exception ex)
			{
				_0xHZ8mbi("ERROR: Exception in Command Processing for _0xH2wooned " + _0xHAs2ribed + ": " + ex.Message, _0xHReu3e: true);
			}
		}
	}

	internal bool _0xHWi2try(_0xHGh0bl0 _0xHDevelope2, int _0xHCypre11e1, bool _0xHBe1fellows)
	{
		if (_0xHDevelope2 == null)
		{
			if (_0xHCypre11e1 >= _0xHTran3udation3.Length)
			{
				return false;
			}
			if (_0xHU3derli3i3g != null)
			{
				_0xHTran3udation3[_0xHCypre11e1]._0xHLutefis2s = _0xHBe1fellows;
			}
		}
		else
		{
			if (_0xHCypre11e1 >= _0xHDevelope2._0xHShe7terbe7t.Length)
			{
				return false;
			}
			_0xHDevelope2._0xHShe7terbe7t[_0xHCypre11e1] = _0xHBe1fellows;
			if (_0xHBe1fellows)
			{
				_0xHTran3udation3[_0xHCypre11e1]._0xH7in = true;
			}
		}
		return true;
	}

	private bool _0xHM1tot1c()
	{
		int num = 0;
		while (true)
		{
			if (num < _0xHTran3udation3.Length)
			{
				if (_0xHTran3udation3[num]._0xHLutefis2s || _0xHTran3udation3[num]._0xH7in)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	private void _0xH8uoy()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		if (_0xHTran3udation3 == null)
		{
			_0xHCei3i = _0xH4ampness(GetType(), _0xHAs2ribed, this);
			foreach (WeakReference _0xH6iscomfort in _0xHBelletri8t._0xH6iscomforts)
			{
				if (_0xH6iscomfort.Target is _0xH2wooned _0xH2wooned2 && _0xH2wooned2._0xHZo2al == _0xHOpaquin4 && !_0xH2wooned2._0xH7rill && _0xH2wooned2 != this)
				{
					throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned__0xH2woonedGuidInUse", _0xHOpaquin4));
				}
			}
			for (_0xHGh0bl0 _0xHCraftin0ss = _0xHInc4nerat4on; _0xHCraftin0ss != null; _0xHCraftin0ss = _0xHCraftin0ss._0xHCraftin0ss)
			{
				if (_0xHCraftin0ss._0xHShe7terbe7t == null)
				{
					_0xHCraftin0ss._0xHShe7terbe7t = new bool[_0xHTran3udation3.Length];
				}
			}
		}
		if (_0xHExplorator8 == 0)
		{
			((CodeAccessPermission)new SecurityPermission(PermissionState.Unrestricted)).Assert();
			_0xHExplorator8 = _0xHAna7reonti7.GetCurrentProcessId();
		}
	}

	[SecuritySafeCritical]
	private unsafe bool _0xHBedu5ns(byte[] _0xHSojo0rning)
	{
		bool result = true;
		if (_0xHSojo0rning == null)
		{
			return false;
		}
		fixed (byte* ptr2 = _0xHSojo0rning)
		{
			_0xHMonocrac1es _0xHD5mur5ly = new _0xHMonocrac1es(65534, 1, 0, 0, 254, 65534, 72057594037927935L);
			_0xHN6cres _0xHN6cres = default(_0xHN6cres);
			_0xHN6cres._0xHIron4zed = _0xHN6cres._0xHWa55oped.SimpleXmlFormat;
			_0xHN6cres._0xHRev8luti8nists = 1;
			_0xHN6cres._0xHThala3i = 0;
			_0xHN6cres._0xHObs2rv2d = 91;
			int num = _0xHSojo0rning.Length;
			_0xHN6cres._0xHC1ackling = 0;
			_0xHRi3u3e3._0xHImme1sing* ptr = stackalloc _0xHRi3u3e3._0xHImme1sing[2];
			ptr->_0xHLam7nt7r = (ulong)(&_0xHN6cres);
			ptr->_0xHMult6p6ston = checked((uint)sizeof(_0xHN6cres));
			ptr->_0xHRail2ays = 0u;
			ptr[1]._0xHLam7nt7r = (ulong)ptr2;
			ptr[1]._0xHRail2ays = 0u;
			int num2 = 65280;
			while (true)
			{
				checked
				{
					_0xHN6cres._0xHScap4la = (ushort)unchecked(checked(num + (num2 - 1)) / num2);
					while (true)
					{
						if (num > 0)
						{
							ptr[1]._0xHMult6p6ston = (uint)Math.Min(num, num2);
							if (_0xHU3derli3i3g != null && !_0xHU3derli3i3g._0xHPote5t(ref _0xHD5mur5ly, null, null, 2, (IntPtr)ptr))
							{
								break;
							}
							num -= num2;
							ptr[1]._0xHLam7nt7r += (uint)num2;
							_0xHN6cres._0xHC1ackling = (ushort)unchecked((int)checked(unchecked((uint)_0xHN6cres._0xHC1ackling) + 1u));
							continue;
						}
						return result;
					}
					if (_0xHRi3u3e3._0xHReus4bles() != _0xHRi3u3e3._0xH3earlessly.EventTooBig || _0xHN6cres._0xHC1ackling != 0 || num2 <= 256)
					{
						break;
					}
				}
				num2 /= 2;
			}
			result = false;
			if (_0xHMo1thily)
			{
				_0xHThicke6();
				return result;
			}
			return result;
		}
	}

	internal static Attribute _0xHCompa7atist(MemberInfo _0xHMunt8ak, Type _0xHLethall5, _0xHAquapla5er _0xHCl4me = _0xHAquapla5er.None)
	{
		if (!_0xHMunt8ak.Module.Assembly._0xHRebe4() && (_0xHCl4me & _0xHAquapla5er.AllowEventSourceOverride) == 0)
		{
			Attribute result = null;
			object[] customAttributes = _0xHMunt8ak.GetCustomAttributes(_0xHLethall5, inherit: false);
			int num = 0;
			if (0 < customAttributes.Length)
			{
				object obj = customAttributes[num];
				result = (Attribute)obj;
			}
			return result;
		}
		_ = _0xHLethall5.FullName;
		foreach (CustomAttributeData customAttribute in CustomAttributeData.GetCustomAttributes(_0xHMunt8ak))
		{
			if (!_0xH7eances(_0xHLethall5, customAttribute.Constructor.ReflectedType))
			{
				continue;
			}
			Attribute attribute = null;
			if (customAttribute.ConstructorArguments.Count == 1)
			{
				attribute = (Attribute)Activator.CreateInstance(_0xHLethall5, customAttribute.ConstructorArguments[0].Value);
			}
			else if (customAttribute.ConstructorArguments.Count == 0)
			{
				attribute = (Attribute)Activator.CreateInstance(_0xHLethall5);
			}
			if (attribute == null)
			{
				continue;
			}
			Type type = attribute.GetType();
			foreach (CustomAttributeNamedArgument namedArgument in customAttribute.NamedArguments)
			{
				PropertyInfo property = type.GetProperty(namedArgument.MemberInfo.Name, BindingFlags.Instance | BindingFlags.Public);
				object obj2 = namedArgument.TypedValue.Value;
				if (property.PropertyType.IsEnum)
				{
					obj2 = Enum.Parse(property.PropertyType, obj2.ToString());
				}
				property.SetValue(attribute, obj2, null);
			}
			return attribute;
		}
		return null;
	}

	private static bool _0xH7eances(Type _0xHOutt5rown, Type _0xH2raptolites)
	{
		if (!(_0xHOutt5rown == _0xH2raptolites) && !string.Equals(_0xHOutt5rown.FullName, _0xH2raptolites.FullName, StringComparison.Ordinal))
		{
			if (string.Equals(_0xHOutt5rown.Name, _0xH2raptolites.Name, StringComparison.Ordinal) && _0xHOutt5rown.Namespace!.EndsWith("Diagnostics.Tracing"))
			{
				return _0xH2raptolites.Namespace!.EndsWith("Diagnostics.Tracing");
			}
			return false;
		}
		return true;
	}

	private static Type _0xHBuntin6(Type _0xHAntacid4, bool _0xH0utlead, bool _0xHO8scurely)
	{
		if (_0xHAntacid4._0xHF3nks() == null)
		{
			return null;
		}
		do
		{
			_0xHAntacid4 = _0xHAntacid4._0xHF3nks();
		}
		while (_0xHAntacid4 != null && _0xHAntacid4._0xHDo11ybird());
		if (_0xHAntacid4 != null)
		{
			if (!_0xH0utlead)
			{
				if ((_0xHO8scurely && _0xHAntacid4.FullName != typeof(_0xH2wooned).FullName) || (!_0xHO8scurely && _0xHAntacid4 != typeof(_0xH2wooned)))
				{
					return null;
				}
			}
			else if (_0xHAntacid4.Name != "_0xH2wooned")
			{
				return null;
			}
		}
		return _0xHAntacid4;
	}

	private static byte[] _0xH4ampness(Type _0xHIgua2id, string _0xHCric2tid, _0xH2wooned _0xHOffi5ialism, _0xHAquapla5er _0xHP8op8iocepto8 = _0xHAquapla5er.None)
	{
		_0xHDevotion3lly _0xHDevotion3lly = null;
		bool flag = _0xHOffi5ialism == null || !_0xHOffi5ialism._0xHUng3nt33l;
		Exception ex = null;
		byte[] result = null;
		if (_0xHIgua2id._0xHDo11ybird() && (_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) == 0)
		{
			return null;
		}
		checked
		{
			try
			{
				MethodInfo[] methods = _0xHIgua2id.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				int num = 1;
				_0xHDecl7nat7onal[] _0xHOwli0hne = null;
				Dictionary<string, string> _0xHE6bay6ents = null;
				if (_0xHOffi5ialism != null || (_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) != 0)
				{
					_0xHOwli0hne = new _0xHDecl7nat7onal[methods.Length + 1];
					_0xHOwli0hne[0]._0xHChol3nes = "";
				}
				ResourceManager resources = null;
				_0xHHelilift6 _0xHHelilift = (_0xHHelilift6)_0xHCompa7atist(_0xHIgua2id, typeof(_0xHHelilift6), _0xHP8op8iocepto8);
				if (_0xHHelilift != null && _0xHHelilift._0xHV1ttle != null)
				{
					resources = new ResourceManager(_0xHHelilift._0xHV1ttle, _0xHIgua2id._0xHM0n0ge());
				}
				_0xHDevotion3lly = new _0xHDevotion3lly(_0xHIrri8a8ion(_0xHIgua2id, _0xHP8op8iocepto8), _0xHRo88icking(_0xHIgua2id), _0xHCric2tid, resources, _0xHP8op8iocepto8);
				_0xHDevotion3lly._0xHU2size("_0xH2woonedMessage", new _0xHSkiff4ed(0)
				{
					_0xHPas6eurizers = _0xHFire0ots.LogAlways,
					_0xHCha00elizes = (_0xHIn1lows)65534
				});
				_0xHDevotion3lly._0xHTam3s(typeof(string), "message");
				_0xHDevotion3lly._0xHDeclina6ions();
				if ((_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) != 0)
				{
					if (!(_0xHBuntin6(_0xHIgua2id, (_0xHP8op8iocepto8 & _0xHAquapla5er.AllowEventSourceOverride) != 0, _0xHIgua2id._0xHM0n0ge()._0xHRebe4()) != null))
					{
						_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_TypeMustDeriveFrom_0xH2wooned"));
					}
					if (!_0xHIgua2id._0xHDo11ybird() && !_0xHIgua2id._0xHB1mir1s())
					{
						_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_TypeMustBeSealedOrAbstract"));
					}
				}
				string[] array = new string[3] { "Keywords", "Tasks", "Opcodes" };
				foreach (string text in array)
				{
					Type nestedType = _0xHIgua2id.GetNestedType(text);
					if (!(nestedType != null))
					{
						continue;
					}
					if (_0xHIgua2id._0xHDo11ybird())
					{
						_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_AbstractMustNotDeclareKTOC", nestedType.Name));
						continue;
					}
					FieldInfo[] fields = nestedType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					foreach (FieldInfo _0xHHarump in fields)
					{
						_0xH4ange(_0xHDevotion3lly, _0xHHarump, text);
					}
				}
				_0xHDevotion3lly._0xHMiddlin4ly("Session3", 17592186044416uL);
				_0xHDevotion3lly._0xHMiddlin4ly("Session2", 35184372088832uL);
				_0xHDevotion3lly._0xHMiddlin4ly("Session1", 70368744177664uL);
				_0xHDevotion3lly._0xHMiddlin4ly("Session0", 140737488355328uL);
				if (_0xHIgua2id != typeof(_0xH2wooned))
				{
					foreach (MethodInfo methodInfo in methods)
					{
						ParameterInfo[] _0xHW3av3rbirds = methodInfo.GetParameters();
						_0xHSkiff4ed _0xHSkiff4ed = (_0xHSkiff4ed)_0xHCompa7atist(methodInfo, typeof(_0xHSkiff4ed), _0xHP8op8iocepto8);
						if (methodInfo.IsStatic)
						{
							continue;
						}
						if (_0xHIgua2id._0xHDo11ybird())
						{
							if (_0xHSkiff4ed != null)
							{
								_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_AbstractMustNotDeclareEventMethods", methodInfo.Name, _0xHSkiff4ed._0xHC0t0es));
							}
							continue;
						}
						if (_0xHSkiff4ed == null)
						{
							if (methodInfo.ReturnType != typeof(void) || methodInfo.IsVirtual || _0xHCompa7atist(methodInfo, typeof(_0xHPlan4s4l), _0xHP8op8iocepto8) != null)
							{
								continue;
							}
							_0xHSkiff4ed _0xHSkiff4ed2 = new _0xHSkiff4ed(num);
							_0xHSkiff4ed = _0xHSkiff4ed2;
						}
						else if (_0xHSkiff4ed._0xHC0t0es <= 0)
						{
							_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_NeedPositiveId", methodInfo.Name), _0xHHea4tie4: true);
							continue;
						}
						if (methodInfo.Name.LastIndexOf('.') >= 0)
						{
							_0xHDevotion3lly._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventMustNotBeExplicitImplementation", methodInfo.Name, _0xHSkiff4ed._0xHC0t0es));
						}
						num++;
						string name = methodInfo.Name;
						if (_0xHSkiff4ed._0xHV1n1n1s == _0xHK7z7tsky.Info)
						{
							bool flag2;
							unchecked
							{
								if (flag2 = _0xHSkiff4ed._0xHCha00elizes == _0xHIn1lows.None)
								{
									_0xHSkiff4ed._0xHCha00elizes = (_0xHIn1lows)checked(65534 - _0xHSkiff4ed._0xHC0t0es);
								}
								if (!_0xHSkiff4ed._0xH5icellar)
								{
									_0xHSkiff4ed._0xHV1n1n1s = _0xHPros1lytis1(_0xHK7z7tsky.Info, name);
								}
							}
							if (flag2)
							{
								if (_0xHSkiff4ed._0xHV1n1n1s == _0xHK7z7tsky.Start)
								{
									string text2 = name.Substring(0, name.Length - "Start".Length);
									if (string.Compare(name, 0, text2, 0, text2.Length) == 0 && string.Compare(name, text2.Length, "Start", 0, Math.Max(name.Length - text2.Length, "Start".Length)) == 0)
									{
										_0xHDevotion3lly._0xHMobilization2(text2, unchecked((int)_0xHSkiff4ed._0xHCha00elizes));
									}
								}
								else if (_0xHSkiff4ed._0xHV1n1n1s == _0xHK7z7tsky.Stop)
								{
									int num2 = _0xHSkiff4ed._0xHC0t0es - 1;
									if (_0xHOwli0hne != null && num2 < _0xHOwli0hne.Length)
									{
										_0xHDecl7nat7onal _0xHDecl7nat7onal = _0xHOwli0hne[num2];
										string text3 = name.Substring(0, name.Length - "Stop".Length);
										if (_0xHDecl7nat7onal._0xHOmn4vorous._0xHS0lfinpyrazone == 1 && string.Compare(_0xHDecl7nat7onal._0xHChol3nes, 0, text3, 0, text3.Length) == 0 && string.Compare(_0xHDecl7nat7onal._0xHChol3nes, text3.Length, "Start", 0, Math.Max(_0xHDecl7nat7onal._0xHChol3nes.Length - text3.Length, "Start".Length)) == 0)
										{
											_0xHSkiff4ed._0xHCha00elizes = unchecked((_0xHIn1lows)_0xHDecl7nat7onal._0xHOmn4vorous._0xHMun6c6pal);
											flag2 = false;
										}
									}
									if (flag2 && (_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) != 0)
									{
										throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_StopsFollowStarts"));
									}
								}
							}
						}
						bool _0xHMult5t5ered = _0xHCoe1amor(ref _0xHW3av3rbirds);
						if (_0xHOffi5ialism == null || !_0xHOffi5ialism._0xHUng3nt33l)
						{
							_0xHDevotion3lly._0xHU2size(name, _0xHSkiff4ed);
							for (int l = 0; l < _0xHW3av3rbirds.Length; l++)
							{
								_0xHDevotion3lly._0xHTam3s(_0xHW3av3rbirds[l].ParameterType, _0xHW3av3rbirds[l].Name);
							}
							_0xHDevotion3lly._0xHDeclina6ions();
						}
						if (_0xHOffi5ialism != null || (_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) != 0)
						{
							_0xHF7age77ation(ref _0xHE6bay6ents, _0xHOwli0hne, methodInfo, _0xHSkiff4ed, _0xHDevotion3lly, _0xHP8op8iocepto8);
							if (_0xHSkiff4ed._0xHP6ddlebo6t != 0)
							{
								_0xHSkiff4ed._0xHR0modify |= unchecked((_0xHSov8r8ignti8s)_0xHDevotion3lly._0xH2uteo(_0xHSkiff4ed._0xHP6ddlebo6t));
							}
							string _0xHHi0pling = "event_" + name;
							string text4 = _0xHDevotion3lly._0xHRa6ionalis6(_0xHHi0pling, CultureInfo.CurrentUICulture, _0xHNonint1r1st: false);
							if (text4 != null)
							{
								_0xHSkiff4ed._0xHSpeedba11ed = text4;
							}
							_0xHLi0ns(ref _0xHOwli0hne, name, _0xHSkiff4ed, _0xHW3av3rbirds, _0xHMult5t5ered);
						}
					}
				}
				_0xH0yssops._0xHBellwet7ers(num);
				if (_0xHOffi5ialism != null)
				{
					_0xHUngi6ted(ref _0xHOwli0hne);
					_0xHOffi5ialism._0xHTran3udation3 = _0xHOwli0hne;
					_0xHOffi5ialism._0xHSuperm4l4tants = _0xHDevotion3lly._0xHWint8ri8st();
				}
				if (!_0xHIgua2id._0xHDo11ybird() && (_0xHOffi5ialism == null || !_0xHOffi5ialism._0xHUng3nt33l))
				{
					if (!(flag = (_0xHP8op8iocepto8 & _0xHAquapla5er.OnlyIfNeededForRegistration) == 0 || _0xHDevotion3lly._0xHWint8ri8st().Length > 0) && (_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) == 0)
					{
						return null;
					}
					result = _0xHDevotion3lly._0xHC6nstructi6ns();
				}
			}
			catch (Exception ex2)
			{
				if ((_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) == 0)
				{
					throw;
				}
				ex = ex2;
			}
			if ((_0xHP8op8iocepto8 & _0xHAquapla5er.Strict) != 0 && (_0xHDevotion3lly._0xHL0ngu0ne.Count > 0 || ex != null))
			{
				string text5 = string.Empty;
				if (_0xHDevotion3lly._0xHL0ngu0ne.Count > 0)
				{
					bool flag3 = true;
					foreach (string item in _0xHDevotion3lly._0xHL0ngu0ne)
					{
						if (!flag3)
						{
							text5 += _0xHA2eotropy._0xHSubrouti0es;
						}
						flag3 = false;
						text5 += item;
					}
				}
				else
				{
					text5 = "Unexpected error: " + ex.Message;
				}
				throw new ArgumentException(text5, ex);
			}
			if (!flag)
			{
				return null;
			}
			return result;
		}
	}

	private static bool _0xHCoe1amor(ref ParameterInfo[] _0xHW3av3rbirds)
	{
		checked
		{
			if (_0xHW3av3rbirds.Length > 0 && _0xHW3av3rbirds[0].ParameterType == typeof(Guid) && string.Compare(_0xHW3av3rbirds[0].Name, "relatedActivityId", StringComparison.OrdinalIgnoreCase) == 0)
			{
				ParameterInfo[] array = new ParameterInfo[_0xHW3av3rbirds.Length - 1];
				Array.Copy(_0xHW3av3rbirds, 1, array, 0, _0xHW3av3rbirds.Length - 1);
				_0xHW3av3rbirds = array;
				return true;
			}
			return false;
		}
	}

	private static void _0xH4ange(_0xHDevotion3lly _0xHCan7hi, FieldInfo _0xHHarump8, string _0xHLou3es)
	{
		bool flag = _0xHHarump8.Module.Assembly._0xHRebe4();
		Type fieldType = _0xHHarump8.FieldType;
		if ((!flag && fieldType == typeof(_0xHK7z7tsky)) || _0xH7eances(fieldType, typeof(_0xHK7z7tsky)))
		{
			if (!(_0xHLou3es != "Opcodes"))
			{
				int _0xHReb7its = (int)_0xHHarump8.GetRawConstantValue();
				_0xHCan7hi._0xH6nnumerably(_0xHHarump8.Name, _0xHReb7its);
				return;
			}
		}
		else if ((!flag && fieldType == typeof(_0xHIn1lows)) || _0xH7eances(fieldType, typeof(_0xHIn1lows)))
		{
			if (!(_0xHLou3es != "Tasks"))
			{
				int _0xHLif7l7ssn7ss = (int)_0xHHarump8.GetRawConstantValue();
				_0xHCan7hi._0xHMobilization2(_0xHHarump8.Name, _0xHLif7l7ssn7ss);
				return;
			}
		}
		else
		{
			if ((flag || !(fieldType == typeof(_0xHSov8r8ignti8s))) && !_0xH7eances(fieldType, typeof(_0xHSov8r8ignti8s)))
			{
				return;
			}
			if (!(_0xHLou3es != "Keywords"))
			{
				ulong _0xHSe3es = (ulong)(long)_0xHHarump8.GetRawConstantValue();
				_0xHCan7hi._0xHMiddlin4ly(_0xHHarump8.Name, _0xHSe3es);
				return;
			}
		}
		_0xHCan7hi._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EnumKindMismatch", _0xHHarump8.Name, _0xHHarump8.FieldType.Name, _0xHLou3es));
	}

	private static void _0xHLi0ns(ref _0xHDecl7nat7onal[] _0xH7bony, string _0xHI4ebox, _0xHSkiff4ed _0xHA5da5tes, ParameterInfo[] _0xHCard5othorac5c, bool _0xHMult5t5ered)
	{
		if (_0xH7bony == null || _0xH7bony.Length <= _0xHA5da5tes._0xHC0t0es)
		{
			_0xHDecl7nat7onal[] array = new _0xHDecl7nat7onal[checked(Math.Max(_0xH7bony.Length + 16, _0xHA5da5tes._0xHC0t0es + 1))];
			Array.Copy(_0xH7bony, array, _0xH7bony.Length);
			_0xH7bony = array;
		}
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHOmn4vorous = new _0xHMonocrac1es(_0xHA5da5tes._0xHC0t0es, _0xHA5da5tes._0xHCoheire66, (byte)_0xHA5da5tes._0xHP6ddlebo6t, checked((byte)_0xHA5da5tes._0xHPas6eurizers), checked((byte)_0xHA5da5tes._0xHV1n1n1s), (int)_0xHA5da5tes._0xHCha00elizes, (long)_0xHA5da5tes._0xHR0modify | (long)_0xHEggb4at4rs._0xHIn1pect1._0xHBulla5e());
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHSepta1ia = _0xHA5da5tes._0xH8xyhemoglobins;
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHChol3nes = _0xHI4ebox;
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHP4nst4r = _0xHCard5othorac5c;
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHDel4e = _0xHA5da5tes._0xHSpeedba11ed;
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xHBe0hout0 = _0xHA5da5tes._0xHChar8er;
		_0xH7bony[_0xHA5da5tes._0xHC0t0es]._0xH5aludism = _0xHMult5t5ered;
	}

	private static void _0xHUngi6ted(ref _0xHDecl7nat7onal[] _0xHOwli0hne00)
	{
		int num = _0xHOwli0hne00.Length;
		checked
		{
			while (0 < num)
			{
				num--;
				if (_0xHOwli0hne00[num]._0xHOmn4vorous._0xHEmer0encies != 0)
				{
					break;
				}
			}
			if (_0xHOwli0hne00.Length - num > 2)
			{
				_0xHDecl7nat7onal[] array = new _0xHDecl7nat7onal[num + 1];
				Array.Copy(_0xHOwli0hne00, array, array.Length);
				_0xHOwli0hne00 = array;
			}
		}
	}

	internal void _0xHAu1iphone(_0xHBelletri8t _0xHIt6nerat6on)
	{
		lock (_0xHBelletri8t._0xHL0ticifers)
		{
			bool[] eventEnabled = null;
			if (_0xHTran3udation3 != null)
			{
				eventEnabled = new bool[_0xHTran3udation3.Length];
			}
			_0xHInc4nerat4on = new _0xHGh0bl0(_0xHInc4nerat4on, eventEnabled, _0xHIt6nerat6on);
			_0xHIt6nerat6on._0xHSynaes1hesis(this);
		}
	}

	private static void _0xHF7age77ation(ref Dictionary<string, string> _0xHE6bay6ents, _0xHDecl7nat7onal[] _0xHWomanline22, MethodInfo _0xHFantast2cat2ng, _0xHSkiff4ed _0xHTrac4eop4yte, _0xHDevotion3lly _0xHSubstatio1, _0xHAquapla5er _0xHCrusad3s)
	{
		int _0xHC0t0es = _0xHTrac4eop4yte._0xHC0t0es;
		string name = _0xHFantast2cat2ng.Name;
		int num = _0xHIdio8ism(_0xHFantast2cat2ng);
		if (num >= 0 && _0xHC0t0es != num)
		{
			_0xHSubstatio1._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_MismatchIdToWriteEvent", name, _0xHC0t0es, num), _0xHHea4tie4: true);
		}
		if (_0xHC0t0es < _0xHWomanline22.Length && _0xHWomanline22[_0xHC0t0es]._0xHOmn4vorous._0xHEmer0encies != 0)
		{
			_0xHSubstatio1._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventIdReused", name, _0xHC0t0es, _0xHWomanline22[_0xHC0t0es]._0xHChol3nes), _0xHHea4tie4: true);
		}
		for (int i = 0; i < _0xHWomanline22.Length; i = checked(i + 1))
		{
			if (_0xHWomanline22[i]._0xHChol3nes != null && _0xHWomanline22[i]._0xHOmn4vorous._0xHMun6c6pal == (int)_0xHTrac4eop4yte._0xHCha00elizes && (_0xHK7z7tsky)_0xHWomanline22[i]._0xHOmn4vorous._0xHS0lfinpyrazone == _0xHTrac4eop4yte._0xHV1n1n1s)
			{
				_0xHSubstatio1._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_TaskOpcodePairReused", name, _0xHC0t0es, _0xHWomanline22[i]._0xHChol3nes, i));
				if ((_0xHCrusad3s & _0xHAquapla5er.Strict) == 0)
				{
					break;
				}
			}
		}
		if (_0xHTrac4eop4yte._0xHV1n1n1s != 0)
		{
			bool flag = false;
			if (_0xHTrac4eop4yte._0xHCha00elizes == _0xHIn1lows.None)
			{
				flag = true;
			}
			else
			{
				_0xHIn1lows _0xHIn1lows = (_0xHIn1lows)checked(65534 - _0xHC0t0es);
				if (_0xHTrac4eop4yte._0xHV1n1n1s != _0xHK7z7tsky.Start && _0xHTrac4eop4yte._0xHV1n1n1s != _0xHK7z7tsky.Stop && _0xHTrac4eop4yte._0xHCha00elizes == _0xHIn1lows)
				{
					flag = true;
				}
			}
			if (flag)
			{
				_0xHSubstatio1._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventMustHaveTaskIfNonDefaultOpcode", name, _0xHC0t0es));
			}
		}
		if (_0xHE6bay6ents == null)
		{
			_0xHE6bay6ents = new Dictionary<string, string>();
		}
		if (_0xHE6bay6ents.ContainsKey(name))
		{
			_0xHSubstatio1._0xHForr7t(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_EventNameReused", name), _0xHHea4tie4: true);
		}
		_0xHE6bay6ents[name] = name;
	}

	[SecuritySafeCritical]
	private static int _0xHIdio8ism(MethodInfo _0xHPintsiz0d)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((CodeAccessPermission)new ReflectionPermission((ReflectionPermissionFlag)2)).Assert();
		byte[] iLAsByteArray = _0xHPintsiz0d.GetMethodBody()!.GetILAsByteArray();
		int num = -1;
		int num2 = 0;
		checked
		{
			while (true)
			{
				if (num2 < iLAsByteArray.Length)
				{
					switch (iLAsByteArray[num2])
					{
					case 14:
					case 16:
						num2++;
						goto IL_020e;
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
					case 30:
						if (num2 > 0 && iLAsByteArray[num2 - 1] == 2)
						{
							num = unchecked((int)iLAsByteArray[num2]) - 22;
						}
						goto IL_020e;
					case 31:
						if (num2 > 0 && iLAsByteArray[num2 - 1] == 2)
						{
							num = iLAsByteArray[num2 + 1];
						}
						num2++;
						goto IL_020e;
					case 32:
						num2 += 4;
						goto IL_020e;
					case 40:
						num2 += 4;
						if (num >= 0)
						{
							for (int i = num2 + 1; i < iLAsByteArray.Length; i++)
							{
								if (iLAsByteArray[i] != 42)
								{
									if (iLAsByteArray[i] != 0)
									{
										break;
									}
									continue;
								}
								return num;
							}
						}
						num = -1;
						goto IL_020e;
					case 44:
					case 45:
						num = -1;
						num2++;
						goto IL_020e;
					case 57:
					case 58:
						num = -1;
						num2 += 4;
						goto IL_020e;
					case 254:
						num2++;
						if (num2 < iLAsByteArray.Length && iLAsByteArray[num2] < 6)
						{
							goto IL_020e;
						}
						break;
					case 140:
					case 141:
						num2 += 4;
						goto IL_020e;
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 20:
					case 37:
					case 103:
					case 104:
					case 105:
					case 106:
					case 109:
					case 110:
					case 162:
						goto IL_020e;
					}
					break;
				}
				return -1;
				IL_020e:
				num2++;
			}
			return -1;
		}
	}

	internal void _0xHZ8mbi(string _0xHReconfinin3, bool _0xHReu3e)
	{
		checked
		{
			try
			{
				Debugger.Log(0, null, _0xHReconfinin3 + "\r\n");
				if (_0xHS6phon < 15)
				{
					_0xHS6phon = (byte)unchecked((int)checked(unchecked((uint)_0xHS6phon) + 1u));
				}
				else
				{
					if (_0xHS6phon == 16)
					{
						return;
					}
					_0xHS6phon = 16;
					_0xHReconfinin3 = "Reached message limit.   End of _0xH2wooned error messages.";
				}
				_0xHSupercoo5ed(_0xHFire0ots.LogAlways, -1L, _0xHReconfinin3);
				_0xHAntich4or("_0xH2woonedMessage", _0xHReconfinin3);
			}
			catch (Exception)
			{
			}
		}
	}

	private _0xHOvera2e _0xHShive1(_0xHOvera2e _0xHSpicin4ss4s)
	{
		_0xHOvera2e _0xHOvera2e = _0xHOvera2e.EtwManifestEventFormat | _0xHOvera2e.EtwSelfDescribingEventFormat;
		if ((_0xHSpicin4ss4s & (_0xHOvera2e.EtwManifestEventFormat | _0xHOvera2e.EtwSelfDescribingEventFormat)) == (_0xHOvera2e.EtwManifestEventFormat | _0xHOvera2e.EtwSelfDescribingEventFormat))
		{
			throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("_0xH2wooned_InvalidEventFormat"), "settings");
		}
		if ((_0xHSpicin4ss4s & _0xHOvera2e) == 0)
		{
			_0xHSpicin4ss4s |= _0xHOvera2e.EtwSelfDescribingEventFormat;
		}
		return _0xHSpicin4ss4s;
	}

	public _0xH2wooned(string eventSourceName)
		: this(eventSourceName, _0xHOvera2e.EtwSelfDescribingEventFormat)
	{
	}

	public _0xH2wooned(string eventSourceName, _0xHOvera2e config)
		: this(eventSourceName, config, (string[])null)
	{
	}

	public _0xH2wooned(string eventSourceName, _0xHOvera2e config, params string[] traits)
		: this((eventSourceName == null) ? default(Guid) : _0xHHulloe3(eventSourceName.ToUpperInvariant()), eventSourceName, config, traits)
	{
		if (eventSourceName == null)
		{
			throw new ArgumentNullException("eventSourceName");
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHEmer0t0(string _0xHInsobrie7ies)
	{
		if (_0xHInsobrie7ies == null)
		{
			throw new ArgumentNullException("eventName");
		}
		if (_0xHS8umbler())
		{
			_0xHDenotab4e _0xHM8colog = default(_0xHDenotab4e);
			_0xHUnravish5d _0xH5linkers = default(_0xHUnravish5d);
			_0xHFaithl3ssn3ss(_0xHInsobrie7ies, ref _0xHM8colog, ref _0xH5linkers, null, null);
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHLa2kadaisi2al(string _0xHUsu8ructuary, _0xHDenotab4e _0xHDundr4ari4s)
	{
		if (_0xHUsu8ructuary == null)
		{
			throw new ArgumentNullException("eventName");
		}
		if (_0xHS8umbler())
		{
			_0xHUnravish5d _0xH5linkers = default(_0xHUnravish5d);
			_0xHFaithl3ssn3ss(_0xHUsu8ructuary, ref _0xHDundr4ari4s, ref _0xH5linkers, null, null);
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHStri2kle<T>(string _0xHPretext6, T _0xHHeli5ad)
	{
		if (_0xHS8umbler())
		{
			_0xHDenotab4e _0xHM8colog = default(_0xHDenotab4e);
			_0xHFaithl3ssn3ss(_0xHPretext6, ref _0xHM8colog, ref _0xHHeli5ad, null, null);
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHT8icepses<T>(string _0xH1rainchildren, _0xHDenotab4e _0xHAnti2acisms, T _0xH8huya)
	{
		if (_0xHS8umbler())
		{
			_0xHFaithl3ssn3ss(_0xH1rainchildren, ref _0xHAnti2acisms, ref _0xH8huya, null, null);
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHT1rbeths<T>(string _0xHDo0bt, ref _0xHDenotab4e _0xHOpportunene66e6, ref T _0xHHead7aiter)
	{
		if (_0xHS8umbler())
		{
			_0xHFaithl3ssn3ss(_0xHDo0bt, ref _0xHOpportunene66e6, ref _0xHHead7aiter, null, null);
		}
	}

	[SecuritySafeCritical]
	public unsafe void _0xHTo2y2<T>(string _0xHS5owplows, ref _0xHDenotab4e _0xHSurrogat0s, ref Guid _0xHIntr4g4l4ctic, ref Guid _0xHSte1ilized, ref T _0xHCleveres7)
	{
		if (!_0xHS8umbler())
		{
			return;
		}
		fixed (Guid* _0xHLor7al = &_0xHIntr4g4l4ctic)
		{
			fixed (Guid* ptr = &_0xHSte1ilized)
			{
				_0xHFaithl3ssn3ss(_0xHS5owplows, ref _0xHSurrogat0s, ref _0xHCleveres7, _0xHLor7al, (_0xHSte1ilized == Guid.Empty) ? null : ptr);
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void _0xHRa6ier(string _0xHOutsiz3, ref _0xHDenotab4e _0xHCoc4aded, _0xHOffscouri5gs _0xHPolitici7ed, Guid* _0xHTetr6cid, Guid* _0xHCo0servatism, params object[] _0xHT1unnels)
	{
		if (_0xHS8umbler())
		{
			byte _0xHQursh2s = (((_0xHCoc4aded._0xHSacc7arin & 4u) != 0) ? _0xHCoc4aded._0xH6urbidity : _0xHPolitici7ed._0xHBu1dle);
			_0xHSov8r8ignti8s _0xHGa00ed = ((((uint)_0xHCoc4aded._0xHSacc7arin & (true ? 1u : 0u)) != 0) ? _0xHCoc4aded._0xHEndo2copy : _0xHPolitici7ed._0xHUngain4iness);
			if (_0xHPreacc4se((_0xHFire0ots)_0xHQursh2s, _0xHGa00ed))
			{
				_0xH2ungs(_0xHOutsiz3, ref _0xHCoc4aded, _0xHPolitici7ed, _0xHTetr6cid, _0xHCo0servatism, _0xHT1unnels);
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void _0xH2ungs(string _0xHThe6rems, ref _0xHDenotab4e _0xHP1id, _0xHOffscouri5gs _0xHTa7ny, Guid* _0xHSowa1s, Guid* _0xHAnti0ers0irant, params object[] _0xHSn6wb6und)
	{
		int num = 0;
		byte level = (((_0xHP1id._0xHSacc7arin & 4u) != 0) ? _0xHP1id._0xH6urbidity : _0xHTa7ny._0xHBu1dle);
		byte opcode = (((_0xHP1id._0xHSacc7arin & 8u) != 0) ? _0xHP1id._0xHMed1cos : _0xHTa7ny._0xHDar1i1g);
		_0xHParam0t0riz0 _0xHWoodr8ffs = (((_0xHP1id._0xHSacc7arin & 2u) != 0) ? _0xHP1id._0xHVe4nacles : _0xHTa7ny._0xHC5llulit5s);
		_0xHSov8r8ignti8s keywords = ((((uint)_0xHP1id._0xHSacc7arin & (true ? 1u : 0u)) != 0) ? _0xHP1id._0xHEndo2copy : _0xHTa7ny._0xHUngain4iness);
		_0xH0yssops _0xH0yssops = _0xHTa7ny._0xHA22emble(_0xHThe6rems ?? _0xHTa7ny._0xHL0ngridge, _0xHWoodr8ffs);
		if (_0xH0yssops == null)
		{
			return;
		}
		num = _0xH0yssops._0xHFoo8;
		_0xHMonocrac1es _0xHSavour8ng = new _0xHMonocrac1es(num, level, opcode, (long)keywords);
		int _0xHUn8ined = _0xHTa7ny._0xHUn8ined;
		byte* _0xHOve1ski1t = stackalloc byte[(int)(uint)_0xHTa7ny._0xHUpscalin3];
		EventData* ptr = stackalloc EventData[checked(_0xHTa7ny._0xHFri6ged + 3)];
		GCHandle* ptr2 = stackalloc GCHandle[_0xHUn8ined];
		fixed (byte* pointer = _0xHU5dreamed)
		{
			fixed (byte* pointer2 = _0xH0yssops._0xHDeadheadin4)
			{
				fixed (byte* pointer3 = _0xHTa7ny._0xHUnabashed3y)
				{
					ptr->SetMetadata(pointer, _0xHU5dreamed.Length, 2);
					ptr[1].SetMetadata(pointer2, _0xH0yssops._0xHDeadheadin4.Length, 1);
					((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->SetMetadata(pointer3, _0xHTa7ny._0xHUnabashed3y.Length, 1);
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
						_0xHNo8resista8ts._0xHSchoolm4sterly._0xHReco7nage(_0xHOve1ski1t, _0xHTa7ny._0xHUpscalin3, (EventData*)checked(unchecked((nuint)ptr) + unchecked((nuint)checked((nint)3 * unchecked((nint)sizeof(EventData))))), _0xHTa7ny._0xHFri6ged, ptr2, _0xHUn8ined);
						checked
						{
							for (int i = 0; i < _0xHTa7ny._0xHScruffi7esses.Length; i++)
							{
								_0xHTa7ny._0xHScruffi7esses[i]._0xHInosin1s(_0xHFlag4llat4s._0xHResolut4ons, _0xHSn6wb6und[i]);
							}
							_0xHS7l7cos7s(ref _0xHSavour8ng, _0xHSowa1s, _0xHAnti0ers0irant, (int)(_0xHNo8resista8ts._0xHSchoolm4sterly._0xH1oulage() - ptr), (IntPtr)ptr);
						}
					}
					finally
					{
						_0xHRe4iscovers(ptr2, _0xHUn8ined);
					}
				}
			}
		}
	}

	[SecuritySafeCritical]
	internal unsafe void _0xHB0rliest(string _0xHDebr8ise, ref _0xHDenotab4e _0xHTailo1ing, _0xHOffscouri5gs _0xHAna6yzabi6ities, Guid* _0xH3ooftah, Guid* _0xHMaplel4ke, EventData* _0xHRecr0wns)
	{
		if (!_0xHS8umbler())
		{
			return;
		}
		_0xHMonocrac1es _0xHDelinea8ing;
		_0xH0yssops _0xH0yssops = _0xHFeli0ely(_0xHDebr8ise, _0xHAna6yzabi6ities, ref _0xHTailo1ing, out _0xHDelinea8ing);
		if (_0xH0yssops == null)
		{
			return;
		}
		EventData* ptr = stackalloc EventData[checked(_0xHAna6yzabi6ities._0xHFri6ged + _0xHAna6yzabi6ities._0xHScruffi7esses.Length * 2 + 3)];
		fixed (byte* pointer = _0xHU5dreamed)
		{
			fixed (byte* pointer2 = _0xH0yssops._0xHDeadheadin4)
			{
				fixed (byte* pointer3 = _0xHAna6yzabi6ities._0xHUnabashed3y)
				{
					ptr->SetMetadata(pointer, _0xHU5dreamed.Length, 2);
					ptr[1].SetMetadata(pointer2, _0xH0yssops._0xHDeadheadin4.Length, 1);
					((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->SetMetadata(pointer3, _0xHAna6yzabi6ities._0xHUnabashed3y.Length, 1);
					int num = 3;
					for (int i = 0; i < _0xHAna6yzabi6ities._0xHScruffi7esses.Length; i = checked(i + 1))
					{
						if (_0xHAna6yzabi6ities._0xHScruffi7esses[i]._0xH1egronis == typeof(string))
						{
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Ptr = checked((long)(&unchecked((EventData*)((byte*)ptr + checked(unchecked((nint)checked(num + 1)) * unchecked((nint)sizeof(EventData)))))->m_Size));
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Size = 2;
							num = checked(num + 1);
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Ptr = ((EventData*)((byte*)_0xHRecr0wns + checked(unchecked((nint)i) * unchecked((nint)sizeof(EventData)))))->m_Ptr;
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Size = checked(unchecked((EventData*)((byte*)_0xHRecr0wns + checked(unchecked((nint)i) * unchecked((nint)sizeof(EventData)))))->m_Size - 2);
							num = checked(num + 1);
						}
						else
						{
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Ptr = ((EventData*)((byte*)_0xHRecr0wns + checked(unchecked((nint)i) * unchecked((nint)sizeof(EventData)))))->m_Ptr;
							((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Size = ((EventData*)((byte*)_0xHRecr0wns + checked(unchecked((nint)i) * unchecked((nint)sizeof(EventData)))))->m_Size;
							if (((EventData*)((byte*)_0xHRecr0wns + checked(unchecked((nint)i) * unchecked((nint)sizeof(EventData)))))->m_Size == 4 && _0xHAna6yzabi6ities._0xHScruffi7esses[i]._0xH1egronis == typeof(bool))
							{
								((EventData*)((byte*)ptr + checked(unchecked((nint)num) * unchecked((nint)sizeof(EventData)))))->m_Size = 1;
							}
							num = checked(num + 1);
						}
					}
					_0xHS7l7cos7s(ref _0xHDelinea8ing, _0xH3ooftah, _0xHMaplel4ke, num, (IntPtr)ptr);
				}
			}
		}
	}

	[SecuritySafeCritical]
	private unsafe void _0xHFaithl3ssn3ss<T>(string _0xH7esternisations, ref _0xHDenotab4e _0xHM8colog8, ref T _0xH5linkers, Guid* _0xHLor7al, Guid* _0xHConcret8zes)
	{
		try
		{
			_0xHAdject8val._0xHMesqu6te<T> _0xHT0tradrachms = _0xHAdject8val._0xHMesqu6te<T>._0xHT0tradrachms;
			_0xHM8colog8._0xHEne2gumen = (_0xHM8colog8._0xHCounterm2th ? _0xHM8colog8._0xHEne2gumen : _0xHPros1lytis1(_0xHM8colog8._0xHEne2gumen, _0xH7esternisations));
			_0xHMonocrac1es _0xHDelinea8ing;
			_0xH0yssops _0xH0yssops = _0xHFeli0ely(_0xH7esternisations, _0xHT0tradrachms, ref _0xHM8colog8, out _0xHDelinea8ing);
			if (_0xH0yssops == null)
			{
				return;
			}
			int _0xHUn8ined = _0xHT0tradrachms._0xHUn8ined;
			byte* _0xHOve1ski1t = stackalloc byte[(int)(uint)_0xHT0tradrachms._0xHUpscalin3];
			EventData* ptr = stackalloc EventData[checked(_0xHT0tradrachms._0xHFri6ged + 3)];
			GCHandle* ptr2 = stackalloc GCHandle[_0xHUn8ined];
			fixed (byte* pointer = _0xHU5dreamed)
			{
				fixed (byte* pointer2 = _0xH0yssops._0xHDeadheadin4)
				{
					fixed (byte* pointer3 = _0xHT0tradrachms._0xHUnabashed3y)
					{
						ptr->SetMetadata(pointer, _0xHU5dreamed.Length, 2);
						ptr[1].SetMetadata(pointer2, _0xH0yssops._0xHDeadheadin4.Length, 1);
						((EventData*)((byte*)ptr + checked((nint)2 * unchecked((nint)sizeof(EventData)))))->SetMetadata(pointer3, _0xHT0tradrachms._0xHUnabashed3y.Length, 1);
						RuntimeHelpers.PrepareConstrainedRegions();
						_0xHK7z7tsky _0xHS0lfinpyrazone = (_0xHK7z7tsky)_0xHDelinea8ing._0xHS0lfinpyrazone;
						Guid _0xHPe77etizer = Guid.Empty;
						Guid _0xHSco1tmasters = Guid.Empty;
						if (_0xHLor7al == null && _0xHConcret8zes == null && (_0xHM8colog8._0xHAsphyx4as & _0xHHyp2ra2sth2sia.Disable) == 0)
						{
							switch (_0xHS0lfinpyrazone)
							{
							case _0xHK7z7tsky.Start:
								_0xHNewsdea0ers._0xH0holos(_0xHFil4ture, _0xH7esternisations, 0, ref _0xHPe77etizer, ref _0xHSco1tmasters, _0xHM8colog8._0xHAsphyx4as);
								break;
							case _0xHK7z7tsky.Stop:
								_0xHNewsdea0ers._0xHCarho7s(_0xHFil4ture, _0xH7esternisations, 0, ref _0xHPe77etizer);
								break;
							}
							if (_0xHPe77etizer != Guid.Empty)
							{
								_0xHLor7al = &_0xHPe77etizer;
							}
							if (_0xHSco1tmasters != Guid.Empty)
							{
								_0xHConcret8zes = &_0xHSco1tmasters;
							}
						}
						try
						{
							_0xHNo8resista8ts._0xHSchoolm4sterly._0xHReco7nage(_0xHOve1ski1t, _0xHT0tradrachms._0xHUpscalin3, (EventData*)checked(unchecked((nuint)ptr) + unchecked((nuint)checked((nint)3 * unchecked((nint)sizeof(EventData))))), _0xHT0tradrachms._0xHFri6ged, ptr2, _0xHUn8ined);
							_0xHT0tradrachms.typeInfo.WriteData(_0xHFlag4llat4s._0xHResolut4ons, ref _0xH5linkers);
							_0xHS7l7cos7s(ref _0xHDelinea8ing, _0xHLor7al, _0xHConcret8zes, checked((int)(_0xHNo8resista8ts._0xHSchoolm4sterly._0xH1oulage() - ptr)), (IntPtr)ptr);
							if (_0xHInc4nerat4on != null)
							{
								_0xHS8del8ne _0xHRavish3d = (_0xHS8del8ne)_0xHT0tradrachms.typeInfo._0xHAm7nd7rs(_0xH5linkers);
								_0xHProtei6ic(_0xH7esternisations, ref _0xHDelinea8ing, _0xH0yssops._0xHPot5hotting, _0xHLor7al, _0xHRavish3d);
							}
						}
						catch (Exception ex)
						{
							if (ex is _0xHSupersurgeo7)
							{
								throw;
							}
							_0xHThicke6(ex);
						}
						finally
						{
							_0xHRe4iscovers(ptr2, _0xHUn8ined);
						}
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (ex2 is _0xHSupersurgeo7)
			{
				throw;
			}
			_0xHThicke6(ex2);
		}
	}

	[SecurityCritical]
	private unsafe void _0xHProtei6ic(string _0xHWholis1s, ref _0xHMonocrac1es _0xH6hoky, _0xHParam0t0riz0 _0xHScra55liest, Guid* _0xHN1naffiliated, _0xHS8del8ne _0xHRavish3d)
	{
		_0xHMercif4lnesses _0xHMercif4lnesses = new _0xHMercif4lnesses(this);
		_0xHMercif4lnesses._0xHSaur5an = _0xHWholis1s;
		_0xHMercif4lnesses._0xHBe3lics = (_0xHFire0ots)_0xH6hoky._0xHPu4posefully;
		_0xHMercif4lnesses._0xHKera5o5ic = (_0xHSov8r8ignti8s)_0xH6hoky._0xHM5rc5tos;
		_0xHMercif4lnesses._0xHT4agi = (_0xHK7z7tsky)_0xH6hoky._0xHS0lfinpyrazone;
		_0xHMercif4lnesses._0xH5leeker = _0xHScra55liest;
		_0xHMercif4lnesses._0xHL1bs = -1;
		if (_0xHN1naffiliated != null)
		{
			_0xHMercif4lnesses._0xH2rahma = *_0xHN1naffiliated;
		}
		if (_0xHRavish3d != null)
		{
			_0xHMercif4lnesses._0xHC4mer4men = new ReadOnlyCollection<object>((IList<object>)_0xHRavish3d.Values);
			_0xHMercif4lnesses._0xH1etalware = new ReadOnlyCollection<string>((IList<string>)_0xHRavish3d.Keys);
		}
		_0xHFerroele5tri5s(-1, _0xHN1naffiliated, _0xHMercif4lnesses);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[_0xHPlan4s4l]
	private unsafe void _0xHRe4iscovers(GCHandle* _0xHC4axer, int _0xHElegize1)
	{
		_0xHNo8resista8ts._0xHSchoolm4sterly._0xH5econsolidated();
		for (int i = 0; i != _0xHElegize1; i = checked(i + 1))
		{
			if (IntPtr.Zero != (IntPtr)(*(GCHandle*)((byte*)_0xHC4axer + checked(unchecked((nint)i) * unchecked((nint)sizeof(GCHandle))))))
			{
				((GCHandle*)((byte*)_0xHC4axer + checked(unchecked((nint)i) * unchecked((nint)sizeof(GCHandle)))))->Free();
			}
		}
	}

	private void _0xHCh3c3latiers()
	{
		checked
		{
			if (_0xHOverde1ign != null)
			{
				List<byte> list = new List<byte>(100);
				int num = 0;
				string text;
				while (true)
				{
					if (num < _0xHOverde1ign.Length - 1)
					{
						if (_0xHOverde1ign[num].StartsWith("ETW_"))
						{
							text = _0xHOverde1ign[num].Substring(4);
							if (!byte.TryParse(text, out var result))
							{
								if (!(text == "GROUP"))
								{
									break;
								}
								result = 1;
							}
							string _0xHEar8hquakes = _0xHOverde1ign[num + 1];
							int count = list.Count;
							list.Add(0);
							list.Add(0);
							list.Add(result);
							int num2 = _0xHMega0aryocytes(list, _0xHEar8hquakes) + 3;
							list[count] = unchecked((byte)num2);
							list[count + 1] = unchecked((byte)(num2 >> 8));
						}
						num += 2;
						continue;
					}
					_0xHU5dreamed = _0xHHy4ercriticisms._0xHCotton5(_0xHAs2ribed, 0, list.Count, 0);
					int num3 = _0xHU5dreamed.Length - list.Count;
					foreach (byte item in list)
					{
						_0xHU5dreamed[num3++] = item;
					}
					return;
				}
				throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("UnknownEtwTrait", text), "traits");
			}
			_0xHU5dreamed = _0xHHy4ercriticisms._0xHCotton5(_0xHAs2ribed, 0, 0, 0);
		}
	}

	private static int _0xHMega0aryocytes(List<byte> _0xH7isallot, string _0xHEar8hquakes)
	{
		if (_0xHEar8hquakes.Length == 0)
		{
			return 0;
		}
		int count = _0xH7isallot.Count;
		char c = _0xHEar8hquakes[0];
		checked
		{
			switch (c)
			{
			case '@':
				_0xH7isallot.AddRange(Encoding.UTF8.GetBytes(_0xHEar8hquakes.Substring(1)));
				break;
			case '{':
				_0xH7isallot.AddRange(new Guid(_0xHEar8hquakes).ToByteArray());
				break;
			case '#':
			{
				for (int i = 1; i < _0xHEar8hquakes.Length; i++)
				{
					if (_0xHEar8hquakes[i] != ' ')
					{
						if (i + 1 >= _0xHEar8hquakes.Length)
						{
							throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("EvenHexDigits"), "traits");
						}
						_0xH7isallot.Add((byte)(_0xHCoercivi8y(_0xHEar8hquakes[i]) * 16 + _0xHCoercivi8y(_0xHEar8hquakes[i + 1])));
						i++;
					}
				}
				break;
			}
			default:
				if ('A' > c && ' ' != c)
				{
					throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("IllegalValue", _0xHEar8hquakes), "traits");
				}
				_0xH7isallot.AddRange(Encoding.UTF8.GetBytes(_0xHEar8hquakes));
				break;
			}
			return _0xH7isallot.Count - count;
		}
	}

	private static int _0xHCoercivi8y(char _0xHC5mpensati5nal)
	{
		checked
		{
			if ('0' <= _0xHC5mpensati5nal && _0xHC5mpensati5nal <= '9')
			{
				return unchecked((int)_0xHC5mpensati5nal) - 48;
			}
			if ('a' <= _0xHC5mpensati5nal)
			{
				_0xHC5mpensati5nal = unchecked((char)(_0xHC5mpensati5nal - 32));
			}
			if ('A' > _0xHC5mpensati5nal || _0xHC5mpensati5nal > 'F')
			{
				throw new ArgumentException(_0xHA2eotropy._0xHSpon8or("BadHexDigit", _0xHC5mpensati5nal), "traits");
			}
			return unchecked((int)_0xHC5mpensati5nal) - 65 + 10;
		}
	}

	private _0xH0yssops _0xHFeli0ely(string _0xHInsti77, _0xHOffscouri5gs _0xHHie4a4chizing, ref _0xHDenotab4e _0xHIncu3uses, out _0xHMonocrac1es _0xHDelinea8ing)
	{
		_0xH0yssops _0xH0yssops = null;
		int traceloggingId = 0;
		byte b = (((_0xHIncu3uses._0xHSacc7arin & 4u) != 0) ? _0xHIncu3uses._0xH6urbidity : _0xHHie4a4chizing._0xHBu1dle);
		byte opcode = (((_0xHIncu3uses._0xHSacc7arin & 8u) != 0) ? _0xHIncu3uses._0xHMed1cos : _0xHHie4a4chizing._0xHDar1i1g);
		_0xHParam0t0riz0 _0xHWoodr8ffs = (((_0xHIncu3uses._0xHSacc7arin & 2u) != 0) ? _0xHIncu3uses._0xHVe4nacles : _0xHHie4a4chizing._0xHC5llulit5s);
		_0xHSov8r8ignti8s _0xHSov8r8ignti8s = ((((uint)_0xHIncu3uses._0xHSacc7arin & (true ? 1u : 0u)) != 0) ? _0xHIncu3uses._0xHEndo2copy : _0xHHie4a4chizing._0xHUngain4iness);
		if (_0xHPreacc4se((_0xHFire0ots)b, _0xHSov8r8ignti8s))
		{
			_0xH0yssops = _0xHHie4a4chizing._0xHA22emble(_0xHInsti77 ?? _0xHHie4a4chizing._0xHL0ngridge, _0xHWoodr8ffs);
			traceloggingId = _0xH0yssops._0xHFoo8;
		}
		_0xHDelinea8ing = new _0xHMonocrac1es(traceloggingId, b, opcode, (long)_0xHSov8r8ignti8s);
		return _0xH0yssops;
	}
}
