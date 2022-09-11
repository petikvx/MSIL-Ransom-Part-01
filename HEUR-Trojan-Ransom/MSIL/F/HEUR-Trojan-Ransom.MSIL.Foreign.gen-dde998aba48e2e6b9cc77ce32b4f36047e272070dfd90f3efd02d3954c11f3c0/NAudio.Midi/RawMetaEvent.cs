using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class RawMetaEvent : MetaEvent
{
	[NonSerialized]
	internal static GetString _0008;

	public byte[] Data { get; set; }

	public RawMetaEvent(MetaEventType metaEventType, long absoluteTime, byte[] data)
		: base(metaEventType, (data != null) ? data.Length : 0, absoluteTime)
	{
		Data = data;
	}

	public override MidiEvent Clone()
	{
		return new RawMetaEvent(base.MetaEventType, base.AbsoluteTime, (byte[])Data?.Clone());
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder().Append(base.ToString());
		byte[] data = Data;
		foreach (byte b in data)
		{
			stringBuilder.AppendFormat(_0008(107414408), b);
		}
		return stringBuilder.ToString();
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		if (Data != null)
		{
			writer.Write(Data, 0, Data.Length);
		}
	}

	static RawMetaEvent()
	{
		Strings.CreateGetStringDelegate(typeof(RawMetaEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0008(107399107), _0008(107399070)), _0008(107399065), _0008(107399060)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0008(107399087)))
		{
			return;
		}
		throw new SecurityException(_0008(107399030));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
