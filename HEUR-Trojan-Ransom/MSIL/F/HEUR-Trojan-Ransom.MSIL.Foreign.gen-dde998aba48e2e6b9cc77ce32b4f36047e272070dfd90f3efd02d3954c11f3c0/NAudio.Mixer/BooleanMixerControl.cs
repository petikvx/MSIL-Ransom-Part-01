using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Mixer;

public sealed class BooleanMixerControl : MixerControl
{
	private MixerInterop.MIXERCONTROLDETAILS_BOOLEAN boolDetails;

	[NonSerialized]
	internal static GetString _008E;

	public bool Value
	{
		get
		{
			GetControlDetails();
			return boolDetails.fValue == 1;
		}
		set
		{
			boolDetails.fValue = (value ? 1 : 0);
			mixerControlDetails.paDetails = Marshal.AllocHGlobal(Marshal.SizeOf((object)boolDetails));
			Marshal.StructureToPtr((object)boolDetails, mixerControlDetails.paDetails, fDeleteOld: false);
			MmException.Try(MixerInterop.mixerSetControlDetails(mixerHandle, ref mixerControlDetails, MixerFlags.Mixer | mixerHandleType), _008E(107395633));
			Marshal.FreeHGlobal(mixerControlDetails.paDetails);
		}
	}

	internal BooleanMixerControl(MixerInterop.MIXERCONTROL mixerControl, IntPtr mixerHandle, MixerFlags mixerHandleType, int nChannels)
	{
		base.mixerControl = mixerControl;
		base.mixerHandle = mixerHandle;
		base.mixerHandleType = mixerHandleType;
		base.nChannels = nChannels;
		mixerControlDetails = default(MixerInterop.MIXERCONTROLDETAILS);
		GetControlDetails();
	}

	protected override void GetDetails(IntPtr pDetails)
	{
		boolDetails = (MixerInterop.MIXERCONTROLDETAILS_BOOLEAN)Marshal.PtrToStructure(pDetails, typeof(MixerInterop.MIXERCONTROLDETAILS_BOOLEAN));
	}

	static BooleanMixerControl()
	{
		Strings.CreateGetStringDelegate(typeof(BooleanMixerControl));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008E(107397028), _008E(107396991)), _008E(107396986), _008E(107396981)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008E(107397008)))
		{
			return;
		}
		throw new SecurityException(_008E(107396951));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
