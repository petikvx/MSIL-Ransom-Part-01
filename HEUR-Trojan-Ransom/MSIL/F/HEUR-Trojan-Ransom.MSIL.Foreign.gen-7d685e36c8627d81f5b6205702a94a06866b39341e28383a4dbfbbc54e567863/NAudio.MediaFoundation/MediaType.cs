using System;
using System.Reflection;
using System.Security;
using _0004;
using _0005;
using _0011;
using _0019;
using _0080;

namespace NAudio.MediaFoundation;

public sealed class MediaType
{
	internal readonly _0019._0012 _0001;

	public int SampleRate
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._0089;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0004._0011._0089;
			((_0019._0012)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int ChannelCount
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._0088;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0004._0011._0088;
			((_0019._0012)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int BitsPerSample
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._008A;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0004._0011._008A;
			((_0019._0012)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (int)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public int AverageBytesPerSecond
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._0087;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (int)/*Error near IL_000a: Stack underflow*/;
		}
	}

	public Guid SubType
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._0084;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (Guid)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0004._0011._0084;
			((_0019._0012)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (Guid)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public Guid MajorType
	{
		get
		{
			//IL_000b: Incompatible stack heights: 0 vs 1
			//IL_0012: Incompatible stack heights: 0 vs 1
			Guid guid = _0004._0011._0083;
			_0011._0018._0001((MediaType)/*Error near IL_0012: Stack underflow*/, guid);
			return (Guid)/*Error near IL_000a: Stack underflow*/;
		}
		set
		{
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_0015: Incompatible stack heights: 0 vs 3
			_ = ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;
			_ = _0004._0011._0083;
			((_0019._0012)/*Error near IL_001c: Stack underflow*/)._0001((Guid)/*Error near IL_001c: Stack underflow*/, (Guid)/*Error near IL_001c: Stack underflow*/);
		}
	}

	public _0019._0012 MediaFoundationObject => ((MediaType)/*Error near IL_0007: Stack underflow*/)._0001;

	public MediaType(_0019._0012 mediaType)
	{
		_0001 = mediaType;
	}

	public MediaType()
	{
		_0001 = _0011._0018._0001();
	}

	public MediaType(global::_0005._0005 waveFormat)
	{
		_0001 = _0011._0018._0001(waveFormat);
	}

	static MediaType()
	{
		//IL_00bb: Incompatible stack heights: 0 vs 1
		bool flag = false;
		global::_0001._0001();
		Assembly assembly;
		if (true)
		{
			assembly = (Assembly)/*Error near IL_00c1: Stack underflow*/;
		}
		Uri uri = new Uri(global::_0003._007E_0080(global::_0003._007E_0080(global::_0002._007E_0002(assembly), _0080._0014._0001(107396751), _0080._0014._0001(107396746)), _0080._0014._0001(107396741), _0080._0014._0001(107396736)));
		if (_0011._0018._0001(global::_0002._007E_0003(uri), true, out flag) && flag && global::_0004._007E_0081(global::_0002._007E_0004(assembly), _0080._0014._0001(107396763)))
		{
			return;
		}
		throw new SecurityException(_0080._0014._0001(107396706));
	}
}
