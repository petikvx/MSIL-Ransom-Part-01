using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class SysexEvent : MidiEvent
{
	private byte[] data;

	[NonSerialized]
	internal static GetString _001A;

	public static SysexEvent ReadSysexEvent(BinaryReader br)
	{
		SysexEvent sysexEvent = new SysexEvent();
		List<byte> list = new List<byte>();
		bool flag = true;
		while (flag)
		{
			byte b = br.ReadByte();
			if (b == 247)
			{
				flag = false;
			}
			else
			{
				list.Add(b);
			}
		}
		sysexEvent.data = list.ToArray();
		return sysexEvent;
	}

	public override MidiEvent Clone()
	{
		return new SysexEvent
		{
			data = (byte[])data?.Clone()
		};
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = data;
		foreach (byte b in array)
		{
			stringBuilder.AppendFormat(_001A(107409043), b);
		}
		return string.Format(_001A(107408900), base.AbsoluteTime, data.Length, stringBuilder.ToString());
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(data, 0, data.Length);
		writer.Write((byte)247);
	}

	static SysexEvent()
	{
		Strings.CreateGetStringDelegate(typeof(SysexEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001A(107399280), _001A(107399243)), _001A(107399238), _001A(107399233)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001A(107399260)))
		{
			return;
		}
		throw new SecurityException(_001A(107399203));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
