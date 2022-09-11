using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class MidiEventComparer : IComparer<MidiEvent>
{
	[NonSerialized]
	internal static GetString _0018;

	public int Compare(MidiEvent x, MidiEvent y)
	{
		long num = x.AbsoluteTime;
		long num2 = y.AbsoluteTime;
		if (num == num2)
		{
			MetaEvent metaEvent = x as MetaEvent;
			MetaEvent metaEvent2 = y as MetaEvent;
			if (metaEvent != null)
			{
				num = ((metaEvent.MetaEventType != MetaEventType.EndTrack) ? long.MinValue : long.MaxValue);
			}
			if (metaEvent2 != null)
			{
				num2 = ((metaEvent2.MetaEventType != MetaEventType.EndTrack) ? long.MinValue : long.MaxValue);
			}
		}
		return num.CompareTo(num2);
	}

	static MidiEventComparer()
	{
		Strings.CreateGetStringDelegate(typeof(MidiEventComparer));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107399182), _0018(107399145)), _0018(107399140), _0018(107399135)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107399162)))
		{
			return;
		}
		throw new SecurityException(_0018(107399105));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
