using System;
using System.Runtime.CompilerServices;
using _0013;
using _0018;
using NAudio.MediaFoundation;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MediaFoundationEncoder : IDisposable
{
	[CompilerGenerated]
	internal sealed class _0001
	{
		public int _0001;

		public int _0002;

		internal bool _0001(MediaType _0002)
		{
			//IL_000e: Invalid comparison between Unknown and I4
			//IL_001e: Invalid comparison between Unknown and I4
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_0037: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			while (true)
			{
				_ = ((MediaType)/*Error near IL_0031: Stack underflow*/).SampleRate;
				int num = ((_0001)/*Error near IL_000b: Stack underflow*/)._0001;
				while (true)
				{
					if (0 == 0)
					{
						if ((int)/*Error near IL_0010: Stack underflow*/ != num)
						{
							if (false)
							{
								break;
							}
							if (2u != 0)
							{
								return false;
							}
						}
						_ = ((MediaType)/*Error near IL_003e: Stack underflow*/).ChannelCount;
						num = ((_0001)/*Error near IL_001b: Stack underflow*/)._0002;
					}
					if (uint.MaxValue != 0)
					{
						return (int)/*Error near IL_0020: Stack underflow*/ == num;
					}
				}
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _0002
	{
		public _0013._0007 _0001;

		public int _0001;

		internal bool _0001(MediaType _0002)
		{
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0025: Invalid comparison between Unknown and I4
			//IL_0028: Incompatible stack heights: 0 vs 1
			//IL_0034: Incompatible stack heights: 0 vs 1
			//IL_003b: Incompatible stack heights: 0 vs 1
			//IL_003e: Incompatible stack heights: 0 vs 1
			//IL_0041: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_004b: Incompatible stack heights: 0 vs 1
			_ = ((MediaType)/*Error near IL_003b: Stack underflow*/).SampleRate;
			int num2;
			while (true)
			{
				int num = ((_0002)/*Error near IL_000b: Stack underflow*/)._0001._0001;
				if ((int)/*Error near IL_0012: Stack underflow*/ != num)
				{
					num2 = 0;
					if (num2 == 0 && num2 == 0)
					{
						break;
					}
					goto IL_0027;
				}
				_ = ((MediaType)/*Error near IL_0048: Stack underflow*/).ChannelCount;
				goto IL_0016;
				IL_0016:
				if (false)
				{
					continue;
				}
				short num3 = ((_0002)/*Error near IL_0020: Stack underflow*/)._0001._0001;
				num2 = (((int)/*Error near IL_0027: Stack underflow*/ == num3) ? 1 : 0);
				goto IL_0027;
				IL_0027:
				if (0 == 0)
				{
					return (byte)/*Error near IL_002b: Stack underflow*/ != 0;
				}
				goto IL_0016;
			}
			return (byte)num2 != 0;
		}

		internal _003C_003Ef__AnonymousType0<MediaType, int> _0001(MediaType _0002)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Incompatible stack heights: 0 vs 1
			//IL_0019: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 2
			//IL_0023: Incompatible stack heights: 0 vs 1
			//IL_002a: Expected I4, but got Unknown
			//IL_002a: Incompatible stack heights: 0 vs 1
			//IL_0031: Incompatible stack heights: 0 vs 1
			_ = ((_0002)/*Error near IL_0009: Stack underflow*/)._0001;
			_ = ((MediaType)/*Error near IL_0023: Stack underflow*/).AverageBytesPerSecond;
			_003F val = /*Error near IL_000f: Stack underflow*/* 8;
			Math.Abs(/*Error near IL_0010: Stack underflow*/ - val);
			_ = new
			{
				MediaType = (MediaType)/*Error near IL_0031: Stack underflow*/,
				Delta = (int)/*Error near IL_0031: Stack underflow*/
			};
			return (_003C_003Ef__AnonymousType0<MediaType, int>)/*Error near IL_0015: Stack underflow*/;
		}
	}

	internal readonly MediaType _0001;

	private bool m__0001;

	[NonSerialized]
	internal static GetString _0093;

	public MediaFoundationEncoder(MediaType outputMediaType)
	{
		if (outputMediaType == null)
		{
			throw new ArgumentNullException(_0093(107390731));
		}
		this._0001 = outputMediaType;
	}

	public void _0001()
	{
		//IL_0030: Incompatible stack heights: 0 vs 1
		//IL_0033: Incompatible stack heights: 0 vs 1
		//IL_0036: Incompatible stack heights: 0 vs 1
		//IL_0040: Incompatible stack heights: 0 vs 2
		while (8u != 0 && 5u != 0)
		{
			if (!((MediaFoundationEncoder)/*Error near IL_000d: Stack underflow*/).m__0001)
			{
				if (false)
				{
					continue;
				}
				((MediaFoundationEncoder)/*Error near IL_001a: Stack underflow*/).m__0001 = true;
				if (2u != 0)
				{
					if (3u != 0)
					{
						_0018._007F._0001((MediaFoundationEncoder)/*Error near IL_003d: Stack underflow*/, true);
					}
				}
			}
			_ = _0091_0002._009B_0005;
			/*Error near IL_0047: Stack underflow*/((object)/*Error near IL_0047: Stack underflow*/);
			break;
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 
		this._0001();
	}

	protected override void _0002()
	{
		//IL_0008: Incompatible stack heights: 0 vs 1
		try
		{
			_0018._007F._0001((MediaFoundationEncoder)/*Error near IL_000f: Stack underflow*/, false);
		}
		finally
		{
			global::_0008._009E(this);
		}
	}

	static MediaFoundationEncoder()
	{
		//IL_000f: Incompatible stack heights: 0 vs 1
		_ = typeof(MediaFoundationEncoder);
		Strings.CreateGetStringDelegate((Type)/*Error near IL_0016: Stack underflow*/);
	}
}
