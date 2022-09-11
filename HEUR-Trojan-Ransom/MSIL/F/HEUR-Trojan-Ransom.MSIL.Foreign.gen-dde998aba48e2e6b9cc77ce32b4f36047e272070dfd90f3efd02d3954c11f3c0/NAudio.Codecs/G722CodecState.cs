using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Codecs;

public sealed class G722CodecState
{
	[NonSerialized]
	internal static GetString _0003;

	public bool ItuTestMode { get; set; }

	public bool Packed { get; private set; }

	public bool EncodeFrom8000Hz { get; private set; }

	public int BitsPerSample { get; private set; }

	public int[] QmfSignalHistory { get; private set; }

	public Band[] Band { get; private set; }

	public uint InBuffer { get; internal set; }

	public int InBits { get; internal set; }

	public uint OutBuffer { get; internal set; }

	public int OutBits { get; internal set; }

	public G722CodecState(int rate, G722Flags options)
	{
		Band = new Band[2]
		{
			new Band(),
			new Band()
		};
		QmfSignalHistory = new int[24];
		ItuTestMode = false;
		switch (rate)
		{
		case 48000:
			BitsPerSample = 6;
			break;
		case 56000:
			BitsPerSample = 7;
			break;
		case 64000:
			BitsPerSample = 8;
			break;
		default:
			throw new ArgumentException(_0003(107403706));
		}
		if ((options & G722Flags.SampleRate8000) == G722Flags.SampleRate8000)
		{
			EncodeFrom8000Hz = true;
		}
		if ((options & G722Flags.Packed) == G722Flags.Packed && BitsPerSample != 8)
		{
			Packed = true;
		}
		else
		{
			Packed = false;
		}
		Band[0].det = 32;
		Band[1].det = 8;
	}

	static G722CodecState()
	{
		Strings.CreateGetStringDelegate(typeof(G722CodecState));
	}
}
