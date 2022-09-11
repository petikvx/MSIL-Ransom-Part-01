using System;
using System.Reflection;
using System.Security;
using _0010;
using _0012;
using _0013;
using _0018;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public sealed class MediaType
{
	internal readonly _0012._0013 _0001;

	[NonSerialized]
	internal static GetString _0094;

	public int SampleRate
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 2
			//IL_0012: Incompatible stack heights: 0 vs 1
			_ = _0010._0012._0089;
			_0018._007F._0001((Guid)/*Error near IL_0012: Stack underflow*/, (MediaType)/*Error near IL_0012: Stack underflow*/);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0010._0012._0089;
			((_0012._0013)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int ChannelCount
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 2
			//IL_0012: Incompatible stack heights: 0 vs 1
			_ = _0010._0012._0088;
			_0018._007F._0001((Guid)/*Error near IL_0012: Stack underflow*/, (MediaType)/*Error near IL_0012: Stack underflow*/);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0010._0012._0088;
			((_0012._0013)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int BitsPerSample
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 2
			//IL_0012: Incompatible stack heights: 0 vs 1
			_ = _0010._0012._008A;
			_0018._007F._0001((Guid)/*Error near IL_0012: Stack underflow*/, (MediaType)/*Error near IL_0012: Stack underflow*/);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0010._0012._008A;
			((_0012._0013)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int AverageBytesPerSecond
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 2
			//IL_0012: Incompatible stack heights: 0 vs 1
			_ = _0010._0012._0087;
			_0018._007F._0001((Guid)/*Error near IL_0012: Stack underflow*/, (MediaType)/*Error near IL_0012: Stack underflow*/);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
	}

	public Guid SubType
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0010._0012._0084;
			_0018._007F._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (Guid)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0010._0012._0084;
			((_0012._0013)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (Guid)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public Guid MajorType
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0010._0012._0083;
			_0018._007F._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (Guid)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0010._0012._0083;
			((_0012._0013)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (Guid)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public _0012._0013 MediaFoundationObject => ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;

	public MediaType(_0012._0013 mediaType)
	{
		_0001 = mediaType;
	}

	public MediaType()
	{
		_0001 = _0018._007F._0001();
	}

	public MediaType(_0013._0007 waveFormat)
	{
		_0001 = _0018._007F._0001(waveFormat);
	}

	static MediaType()
	{
		//IL_00f3: Incompatible stack heights: 0 vs 1
		//IL_010d: Incompatible stack heights: 0 vs 1
		//IL_0119: Incompatible stack heights: 0 vs 4
		//IL_0123: Incompatible stack heights: 0 vs 1
		//IL_012d: Incompatible stack heights: 0 vs 1
		//IL_0137: Incompatible stack heights: 0 vs 1
		_ = typeof(MediaType);
		Strings.CreateGetStringDelegate((Type)/*Error near IL_00fd: Stack underflow*/);
		int num = 0;
		Assembly assembly = default(Assembly);
		if (num == 0)
		{
			bool flag = (byte)num != 0;
			if (true)
			{
				global::_0001._0001();
				assembly = (Assembly)/*Error near IL_0113: Stack underflow*/;
				_ = global::_0003._007E_0080;
				_ = global::_0003._007E_0080;
				_ = global::_0002._007E_0002;
				/*Error near IL_0123: Stack underflow*/((object)/*Error near IL_0123: Stack underflow*/);
				_0094(107400015);
				_0094(107400042);
				string text = /*Error near IL_006c: Stack underflow*/((object)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/, (string)/*Error near IL_006c: Stack underflow*/);
				string text2 = _0094(107400037);
				string text3 = _0094(107400032);
				Uri uri = new Uri(/*Error near IL_008f: Stack underflow*/(text, text2, text3));
				num = (_0018._007F._0001(global::_0002._007E_0003(uri), true, out flag) ? 1 : 0);
				if (false)
				{
					goto IL_00ae;
				}
				if (num == 0)
				{
					goto IL_00d8;
				}
			}
			num = (flag ? 1 : 0);
		}
		goto IL_00ae;
		IL_00d8:
		throw new SecurityException(_0094(107400002));
		IL_00ae:
		if (num != 0 && global::_0004._007E_0081(global::_0002._007E_0004(assembly), _0094(107400027)))
		{
			return;
		}
		goto IL_00d8;
	}
}
