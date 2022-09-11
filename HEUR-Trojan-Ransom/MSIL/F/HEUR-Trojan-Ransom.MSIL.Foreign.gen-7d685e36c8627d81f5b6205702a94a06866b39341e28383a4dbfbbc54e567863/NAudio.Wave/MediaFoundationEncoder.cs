using System;
using System.Runtime.CompilerServices;
using _0005;
using _0011;
using NAudio.MediaFoundation;
using _0080;

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
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_0029: Incompatible stack heights: 0 vs 1
			_ = ((MediaType)/*Error near IL_0026: Stack underflow*/).SampleRate;
			int num = ((_0001)/*Error near IL_000b: Stack underflow*/)._0001;
			if ((int)/*Error near IL_000d: Stack underflow*/ == num)
			{
				return _0002.ChannelCount == this._0002;
			}
			return false;
		}
	}

	[CompilerGenerated]
	internal sealed class _0002
	{
		public global::_0005._0005 _0001;

		public int _0001;

		internal bool _0001(MediaType _0002)
		{
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0029: Incompatible stack heights: 0 vs 1
			//IL_0030: Incompatible stack heights: 0 vs 1
			//IL_0033: Incompatible stack heights: 0 vs 1
			_ = ((MediaType)/*Error near IL_0030: Stack underflow*/).SampleRate;
			int num = ((_0002)/*Error near IL_000b: Stack underflow*/)._0001._0001;
			if ((int)/*Error near IL_0012: Stack underflow*/ == num)
			{
				return _0002.ChannelCount == this._0001._0001;
			}
			return false;
		}

		internal _003C_003Ef__AnonymousType0<MediaType, int> _0001(MediaType _0002)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got Unknown
			//IL_001f: Incompatible stack heights: 0 vs 1
			//IL_0022: Incompatible stack heights: 0 vs 1
			//IL_0025: Incompatible stack heights: 0 vs 2
			_ = ((_0002)/*Error near IL_0009: Stack underflow*/)._0001;
			int num = ((MediaType)/*Error near IL_0010: Stack underflow*/).AverageBytesPerSecond;
			int delta = Math.Abs(/*Error near IL_0013: Stack underflow*/ - num * 8);
			return new
			{
				MediaType = (MediaType)/*Error near IL_001d: Stack underflow*/,
				Delta = delta
			};
		}
	}

	internal readonly MediaType _0001;

	private bool m__0001;

	public MediaFoundationEncoder(MediaType outputMediaType)
	{
		if (outputMediaType == null)
		{
			throw new ArgumentNullException(_0080._0014._0001(107389228));
		}
		this._0001 = outputMediaType;
	}

	public void _0001()
	{
		//IL_0026: Incompatible stack heights: 0 vs 1
		//IL_0029: Incompatible stack heights: 0 vs 1
		//IL_002c: Incompatible stack heights: 0 vs 1
		if (!((MediaFoundationEncoder)/*Error near IL_0007: Stack underflow*/).m__0001)
		{
			((MediaFoundationEncoder)/*Error near IL_0011: Stack underflow*/).m__0001 = true;
			_0011._0018._0001((MediaFoundationEncoder)/*Error near IL_0019: Stack underflow*/, true);
		}
		_0091_0002._009B_0005(this);
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
			_0011._0018._0001((MediaFoundationEncoder)/*Error near IL_000f: Stack underflow*/, false);
		}
		finally
		{
			global::_0008._009E(this);
		}
	}
}
