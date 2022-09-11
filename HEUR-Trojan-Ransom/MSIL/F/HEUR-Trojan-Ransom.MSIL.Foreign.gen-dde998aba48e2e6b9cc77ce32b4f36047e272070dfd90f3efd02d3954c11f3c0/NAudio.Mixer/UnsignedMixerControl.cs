using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Mixer;

public sealed class UnsignedMixerControl : MixerControl
{
	private MixerInterop.MIXERCONTROLDETAILS_UNSIGNED[] unsignedDetails;

	[NonSerialized]
	internal static GetString _009B;

	public uint Value
	{
		get
		{
			GetControlDetails();
			return unsignedDetails[0].dwValue;
		}
		set
		{
			int num = Marshal.SizeOf((object)unsignedDetails[0]);
			mixerControlDetails.paDetails = Marshal.AllocHGlobal(num * nChannels);
			for (int i = 0; i < nChannels; i++)
			{
				unsignedDetails[i].dwValue = value;
				long num2 = mixerControlDetails.paDetails.ToInt64() + num * i;
				Marshal.StructureToPtr((object)unsignedDetails[i], (IntPtr)num2, fDeleteOld: false);
			}
			MmException.Try(MixerInterop.mixerSetControlDetails(mixerHandle, ref mixerControlDetails, MixerFlags.Mixer | mixerHandleType), _009B(107395844));
			Marshal.FreeHGlobal(mixerControlDetails.paDetails);
		}
	}

	public uint MinValue => (uint)mixerControl.Bounds.minimum;

	public uint MaxValue => (uint)mixerControl.Bounds.maximum;

	public double Percent
	{
		get
		{
			return 100.0 * (double)(Value - MinValue) / (double)(MaxValue - MinValue);
		}
		set
		{
			Value = (uint)((double)MinValue + value / 100.0 * (double)(MaxValue - MinValue));
		}
	}

	internal UnsignedMixerControl(MixerInterop.MIXERCONTROL mixerControl, IntPtr mixerHandle, MixerFlags mixerHandleType, int nChannels)
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
		unsignedDetails = new MixerInterop.MIXERCONTROLDETAILS_UNSIGNED[nChannels];
		for (int i = 0; i < nChannels; i++)
		{
			unsignedDetails[i] = (MixerInterop.MIXERCONTROLDETAILS_UNSIGNED)Marshal.PtrToStructure(mixerControlDetails.paDetails, typeof(MixerInterop.MIXERCONTROLDETAILS_UNSIGNED));
		}
	}

	public override string ToString()
	{
		return string.Format(_009B(107395431), base.ToString(), Percent);
	}

	static UnsignedMixerControl()
	{
		Strings.CreateGetStringDelegate(typeof(UnsignedMixerControl));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009B(107397239), _009B(107397202)), _009B(107397197), _009B(107397192)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009B(107397219)))
		{
			return;
		}
		throw new SecurityException(_009B(107397162));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
