using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class ChannelAfterTouchEvent : MidiEvent
{
	private byte afterTouchPressure;

	[NonSerialized]
	internal static GetString _0015;

	public int AfterTouchPressure
	{
		get
		{
			return afterTouchPressure;
		}
		set
		{
			if (value < 0 || value > 127)
			{
				throw new ArgumentOutOfRangeException(_0015(107392349), _0015(107414851));
			}
			afterTouchPressure = (byte)value;
		}
	}

	public ChannelAfterTouchEvent(BinaryReader br)
	{
		afterTouchPressure = br.ReadByte();
		if ((afterTouchPressure & 0x80u) != 0)
		{
			throw new FormatException(_0015(107414376));
		}
	}

	public ChannelAfterTouchEvent(long absoluteTime, int channel, int afterTouchPressure)
		: base(absoluteTime, channel, MidiCommandCode.ChannelAfterTouch)
	{
		AfterTouchPressure = afterTouchPressure;
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(afterTouchPressure);
	}

	static ChannelAfterTouchEvent()
	{
		Strings.CreateGetStringDelegate(typeof(ChannelAfterTouchEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107399120), _0015(107399083)), _0015(107399078), _0015(107399073)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107399100)))
		{
			return;
		}
		throw new SecurityException(_0015(107399043));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
