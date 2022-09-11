using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class SequencerSpecificEvent : MetaEvent
{
	private byte[] data;

	[NonSerialized]
	internal static GetString _0013;

	public byte[] Data
	{
		get
		{
			return data;
		}
		set
		{
			data = value;
			metaDataLength = data.Length;
		}
	}

	public SequencerSpecificEvent(BinaryReader br, int length)
	{
		data = br.ReadBytes(length);
	}

	public SequencerSpecificEvent(byte[] data, long absoluteTime)
		: base(MetaEventType.SequencerSpecific, data.Length, absoluteTime)
	{
		this.data = data;
	}

	public override MidiEvent Clone()
	{
		return new SequencerSpecificEvent((byte[])data.Clone(), base.AbsoluteTime);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base.ToString());
		stringBuilder.Append(_0013(107409040));
		byte[] array = data;
		foreach (byte b in array)
		{
			stringBuilder.AppendFormat(_0013(107409035), b);
		}
		stringBuilder.Length--;
		return stringBuilder.ToString();
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(data);
	}

	static SequencerSpecificEvent()
	{
		Strings.CreateGetStringDelegate(typeof(SequencerSpecificEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0013(107399272), _0013(107399235)), _0013(107399230), _0013(107399225)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0013(107399252)))
		{
			return;
		}
		throw new SecurityException(_0013(107399195));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
