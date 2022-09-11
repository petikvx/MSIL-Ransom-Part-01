using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class Generator
{
	private GeneratorEnum generatorType;

	private ushort rawAmount;

	private Instrument instrument;

	private SampleHeader sampleHeader;

	[NonSerialized]
	internal static GetString _0080;

	public GeneratorEnum GeneratorType
	{
		get
		{
			return generatorType;
		}
		set
		{
			generatorType = value;
		}
	}

	public ushort UInt16Amount
	{
		get
		{
			return rawAmount;
		}
		set
		{
			rawAmount = value;
		}
	}

	public short Int16Amount
	{
		get
		{
			return (short)rawAmount;
		}
		set
		{
			rawAmount = (ushort)value;
		}
	}

	public byte LowByteAmount
	{
		get
		{
			return (byte)(rawAmount & 0xFFu);
		}
		set
		{
			rawAmount &= 65280;
			rawAmount += value;
		}
	}

	public byte HighByteAmount
	{
		get
		{
			return (byte)((rawAmount & 0xFF00) >> 8);
		}
		set
		{
			rawAmount &= 255;
			rawAmount += (ushort)(value << 8);
		}
	}

	public Instrument Instrument
	{
		get
		{
			return instrument;
		}
		set
		{
			instrument = value;
		}
	}

	public SampleHeader SampleHeader
	{
		get
		{
			return sampleHeader;
		}
		set
		{
			sampleHeader = value;
		}
	}

	public override string ToString()
	{
		if (generatorType == GeneratorEnum.Instrument)
		{
			return string.Format(_0080(107394784), instrument.Name);
		}
		if (generatorType == GeneratorEnum.SampleID)
		{
			return string.Format(_0080(107394751), sampleHeader);
		}
		return string.Format(_0080(107394718), generatorType, rawAmount);
	}

	static Generator()
	{
		Strings.CreateGetStringDelegate(typeof(Generator));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0080(107397290), _0080(107397253)), _0080(107397248), _0080(107397243)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0080(107397270)))
		{
			return;
		}
		throw new SecurityException(_0080(107397213));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
