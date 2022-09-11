using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Mixer;

internal sealed class MixerInterop
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
	public struct MIXERCONTROLDETAILS
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public IntPtr hwndOwner;

		public int cbDetails;

		public IntPtr paDetails;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MIXERCAPS
	{
		public ushort wMid;

		public ushort wPid;

		public uint vDriverVersion;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;

		public uint fdwSupport;

		public uint cDestinations;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MIXERLINECONTROLS
	{
		public int cbStruct;

		public int dwLineID;

		public int dwControlID;

		public int cControls;

		public int cbmxctrl;

		public IntPtr pamxctrl;
	}

	[Flags]
	public enum MIXERLINE_LINEF
	{
		MIXERLINE_LINEF_ACTIVE = 1,
		MIXERLINE_LINEF_DISCONNECTED = 0x8000,
		MIXERLINE_LINEF_SOURCE = int.MinValue
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MIXERLINE
	{
		public int cbStruct;

		public int dwDestination;

		public int dwSource;

		public int dwLineID;

		public MIXERLINE_LINEF fdwLine;

		public IntPtr dwUser;

		public MixerLineComponentType dwComponentType;

		public int cChannels;

		public int cConnections;

		public int cControls;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string szShortName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;

		public uint dwType;

		public uint dwDeviceID;

		public ushort wMid;

		public ushort wPid;

		public uint vDriverVersion;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string szPname;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Bounds
	{
		public int minimum;

		public int maximum;

		public int reserved2;

		public int reserved3;

		public int reserved4;

		public int reserved5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Metrics
	{
		public int step;

		public int customData;

		public int reserved2;

		public int reserved3;

		public int reserved4;

		public int reserved5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MIXERCONTROL
	{
		public uint cbStruct;

		public int dwControlID;

		public MixerControlType dwControlType;

		public uint fdwControl;

		public uint cMultipleItems;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string szShortName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;

		public Bounds Bounds;

		public Metrics Metrics;
	}

	public struct MIXERCONTROLDETAILS_BOOLEAN
	{
		public int fValue;
	}

	public struct MIXERCONTROLDETAILS_SIGNED
	{
		public int lValue;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MIXERCONTROLDETAILS_LISTTEXT
	{
		public uint dwParam1;

		public uint dwParam2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string szName;
	}

	public struct MIXERCONTROLDETAILS_UNSIGNED
	{
		public uint dwValue;
	}

	public const uint MIXERCONTROL_CONTROLF_UNIFORM = 1u;

	public const uint MIXERCONTROL_CONTROLF_MULTIPLE = 2u;

	public const uint MIXERCONTROL_CONTROLF_DISABLED = 2147483648u;

	public const int MAXPNAMELEN = 32;

	public const int MIXER_SHORT_NAME_CHARS = 16;

	public const int MIXER_LONG_NAME_CHARS = 64;

	[NonSerialized]
	internal static GetString _0007;

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern int mixerGetNumDevs();

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerOpen(out IntPtr hMixer, int uMxId, IntPtr dwCallback, IntPtr dwInstance, MixerFlags dwOpenFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerClose(IntPtr hMixer);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerGetControlDetails(IntPtr hMixer, ref MIXERCONTROLDETAILS mixerControlDetails, MixerFlags dwDetailsFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerGetDevCaps(IntPtr nMixerID, ref MIXERCAPS mixerCaps, int mixerCapsSize);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerGetID(IntPtr hMixer, out int mixerID, MixerFlags dwMixerIDFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerGetLineControls(IntPtr hMixer, ref MIXERLINECONTROLS mixerLineControls, MixerFlags dwControlFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerGetLineInfo(IntPtr hMixer, ref MIXERLINE mixerLine, MixerFlags dwInfoFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerMessage(IntPtr hMixer, uint nMessage, IntPtr dwParam1, IntPtr dwParam2);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi)]
	public static extern MmResult mixerSetControlDetails(IntPtr hMixer, ref MIXERCONTROLDETAILS mixerControlDetails, MixerFlags dwDetailsFlags);

	static MixerInterop()
	{
		Strings.CreateGetStringDelegate(typeof(MixerInterop));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(global::_0007._007E_0087(global::_0007._007E_0087(_0006._007E_001C(assembly), _0007(107397147), _0007(107397110)), _0007(107397105), _0007(107397100)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0007(107397127)))
		{
			return;
		}
		throw new SecurityException(_0007(107397070));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
