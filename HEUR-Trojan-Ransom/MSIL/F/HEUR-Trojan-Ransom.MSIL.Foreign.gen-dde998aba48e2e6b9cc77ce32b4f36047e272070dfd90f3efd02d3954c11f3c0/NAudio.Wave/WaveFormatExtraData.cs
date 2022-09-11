using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class WaveFormatExtraData : WaveFormat
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
	private byte[] extraData = new byte[100];

	[NonSerialized]
	internal static GetString _0018;

	public byte[] ExtraData => extraData;

	internal WaveFormatExtraData()
	{
	}

	public WaveFormatExtraData(BinaryReader reader)
		: base(reader)
	{
		ReadExtraData(reader);
	}

	internal void ReadExtraData(BinaryReader reader)
	{
		if (extraSize > 0)
		{
			reader.Read(extraData, 0, extraSize);
		}
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		if (extraSize > 0)
		{
			writer.Write(extraData, 0, extraSize);
		}
	}

	static WaveFormatExtraData()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFormatExtraData));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107398092), _0018(107398055)), _0018(107398050), _0018(107398045)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107398072)))
		{
			return;
		}
		throw new SecurityException(_0018(107398015));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
