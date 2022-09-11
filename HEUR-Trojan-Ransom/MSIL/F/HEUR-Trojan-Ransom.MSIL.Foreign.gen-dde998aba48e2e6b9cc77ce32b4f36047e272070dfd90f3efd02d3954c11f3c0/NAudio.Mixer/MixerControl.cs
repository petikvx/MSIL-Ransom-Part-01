using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Mixer;

public abstract class MixerControl
{
	internal MixerInterop.MIXERCONTROL mixerControl;

	internal MixerInterop.MIXERCONTROLDETAILS mixerControlDetails;

	protected IntPtr mixerHandle;

	protected int nChannels;

	protected MixerFlags mixerHandleType;

	[NonSerialized]
	internal static GetString _0001;

	public string Name => mixerControl.szName;

	public MixerControlType ControlType => mixerControl.dwControlType;

	public bool IsBoolean => IsControlBoolean(mixerControl.dwControlType);

	public bool IsListText => IsControlListText(mixerControl.dwControlType);

	public bool IsSigned => IsControlSigned(mixerControl.dwControlType);

	public bool IsUnsigned => IsControlUnsigned(mixerControl.dwControlType);

	public bool IsCustom => IsControlCustom(mixerControl.dwControlType);

	public static IList<MixerControl> GetMixerControls(IntPtr mixerHandle, MixerLine mixerLine, MixerFlags mixerHandleType)
	{
		List<MixerControl> list = new List<MixerControl>();
		if (mixerLine.ControlsCount > 0)
		{
			int num = Marshal.SizeOf(typeof(MixerInterop.MIXERCONTROL));
			MixerInterop.MIXERLINECONTROLS mixerLineControls = default(MixerInterop.MIXERLINECONTROLS);
			IntPtr intPtr = Marshal.AllocHGlobal(num * mixerLine.ControlsCount);
			mixerLineControls.cbStruct = Marshal.SizeOf((object)mixerLineControls);
			mixerLineControls.dwLineID = mixerLine.LineId;
			mixerLineControls.cControls = mixerLine.ControlsCount;
			mixerLineControls.pamxctrl = intPtr;
			mixerLineControls.cbmxctrl = Marshal.SizeOf(typeof(MixerInterop.MIXERCONTROL));
			try
			{
				MmResult mmResult = MixerInterop.mixerGetLineControls(mixerHandle, ref mixerLineControls, MixerFlags.Mixer | mixerHandleType);
				if (mmResult != 0)
				{
					throw new MmException(mmResult, _0001(107395515));
				}
				for (int i = 0; i < mixerLineControls.cControls; i++)
				{
					MixerControl item = GetMixerControl(controlId: ((MixerInterop.MIXERCONTROL)Marshal.PtrToStructure((IntPtr)(intPtr.ToInt64() + num * i), typeof(MixerInterop.MIXERCONTROL))).dwControlID, mixerHandle: mixerHandle, nLineID: mixerLine.LineId, nChannels: mixerLine.Channels, mixerFlags: mixerHandleType);
					list.Add(item);
				}
				return list;
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		return list;
	}

	public static MixerControl GetMixerControl(IntPtr mixerHandle, int nLineID, int controlId, int nChannels, MixerFlags mixerFlags)
	{
		MixerInterop.MIXERLINECONTROLS mixerLineControls = default(MixerInterop.MIXERLINECONTROLS);
		MixerInterop.MIXERCONTROL mIXERCONTROL = default(MixerInterop.MIXERCONTROL);
		IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)mIXERCONTROL));
		mixerLineControls.cbStruct = Marshal.SizeOf((object)mixerLineControls);
		mixerLineControls.cControls = 1;
		mixerLineControls.dwControlID = controlId;
		mixerLineControls.cbmxctrl = Marshal.SizeOf((object)mIXERCONTROL);
		mixerLineControls.pamxctrl = intPtr;
		mixerLineControls.dwLineID = nLineID;
		MmResult mmResult = MixerInterop.mixerGetLineControls(mixerHandle, ref mixerLineControls, MixerFlags.ListText | mixerFlags);
		if (mmResult != 0)
		{
			Marshal.FreeCoTaskMem(intPtr);
			throw new MmException(mmResult, _0001(107395515));
		}
		mIXERCONTROL = (MixerInterop.MIXERCONTROL)Marshal.PtrToStructure(mixerLineControls.pamxctrl, typeof(MixerInterop.MIXERCONTROL));
		Marshal.FreeCoTaskMem(intPtr);
		if (IsControlBoolean(mIXERCONTROL.dwControlType))
		{
			return new BooleanMixerControl(mIXERCONTROL, mixerHandle, mixerFlags, nChannels);
		}
		if (IsControlSigned(mIXERCONTROL.dwControlType))
		{
			return new SignedMixerControl(mIXERCONTROL, mixerHandle, mixerFlags, nChannels);
		}
		if (IsControlUnsigned(mIXERCONTROL.dwControlType))
		{
			return new UnsignedMixerControl(mIXERCONTROL, mixerHandle, mixerFlags, nChannels);
		}
		if (IsControlListText(mIXERCONTROL.dwControlType))
		{
			return new ListTextMixerControl(mIXERCONTROL, mixerHandle, mixerFlags, nChannels);
		}
		if (IsControlCustom(mIXERCONTROL.dwControlType))
		{
			return new CustomMixerControl(mIXERCONTROL, mixerHandle, mixerFlags, nChannels);
		}
		throw new InvalidOperationException(string.Format(_0001(107395486), mIXERCONTROL.dwControlType));
	}

	protected void GetControlDetails()
	{
		mixerControlDetails.cbStruct = Marshal.SizeOf((object)mixerControlDetails);
		mixerControlDetails.dwControlID = mixerControl.dwControlID;
		if (IsCustom)
		{
			mixerControlDetails.cChannels = 0;
		}
		else if ((mixerControl.fdwControl & (true ? 1u : 0u)) != 0)
		{
			mixerControlDetails.cChannels = 1;
		}
		else
		{
			mixerControlDetails.cChannels = nChannels;
		}
		if ((mixerControl.fdwControl & 2u) != 0)
		{
			mixerControlDetails.hwndOwner = (IntPtr)mixerControl.cMultipleItems;
		}
		else if (IsCustom)
		{
			mixerControlDetails.hwndOwner = IntPtr.Zero;
		}
		else
		{
			mixerControlDetails.hwndOwner = IntPtr.Zero;
		}
		if (IsBoolean)
		{
			mixerControlDetails.cbDetails = Marshal.SizeOf((object)default(MixerInterop.MIXERCONTROLDETAILS_BOOLEAN));
		}
		else if (IsListText)
		{
			mixerControlDetails.cbDetails = Marshal.SizeOf((object)default(MixerInterop.MIXERCONTROLDETAILS_LISTTEXT));
		}
		else if (IsSigned)
		{
			mixerControlDetails.cbDetails = Marshal.SizeOf((object)default(MixerInterop.MIXERCONTROLDETAILS_SIGNED));
		}
		else if (IsUnsigned)
		{
			mixerControlDetails.cbDetails = Marshal.SizeOf((object)default(MixerInterop.MIXERCONTROLDETAILS_UNSIGNED));
		}
		else
		{
			mixerControlDetails.cbDetails = mixerControl.Metrics.customData;
		}
		int num = mixerControlDetails.cbDetails * mixerControlDetails.cChannels;
		if ((mixerControl.fdwControl & 2u) != 0)
		{
			num *= (int)mixerControl.cMultipleItems;
		}
		IntPtr intPtr = Marshal.AllocCoTaskMem(num);
		mixerControlDetails.paDetails = intPtr;
		MmResult mmResult = MixerInterop.mixerGetControlDetails(mixerHandle, ref mixerControlDetails, MixerFlags.Mixer | mixerHandleType);
		if (mmResult == MmResult.NoError)
		{
			GetDetails(mixerControlDetails.paDetails);
		}
		Marshal.FreeCoTaskMem(intPtr);
		if (mmResult != 0)
		{
			throw new MmException(mmResult, _0001(107395477));
		}
	}

	protected abstract void GetDetails(IntPtr pDetails);

	private static bool IsControlBoolean(MixerControlType controlType)
	{
		switch (controlType)
		{
		case MixerControlType.BooleanMeter:
		case MixerControlType.Boolean:
		case MixerControlType.OnOff:
		case MixerControlType.Mute:
		case MixerControlType.Mono:
		case MixerControlType.Loudness:
		case MixerControlType.StereoEnhance:
		case MixerControlType.Button:
		case MixerControlType.SingleSelect:
		case MixerControlType.Mux:
		case MixerControlType.MultipleSelect:
		case MixerControlType.Mixer:
			return true;
		default:
			return false;
		}
	}

	private static bool IsControlListText(MixerControlType controlType)
	{
		switch (controlType)
		{
		case MixerControlType.Equalizer:
		case MixerControlType.SingleSelect:
		case MixerControlType.Mux:
		case MixerControlType.MultipleSelect:
		case MixerControlType.Mixer:
			return true;
		default:
			return false;
		}
	}

	private static bool IsControlSigned(MixerControlType controlType)
	{
		switch (controlType)
		{
		case MixerControlType.SignedMeter:
		case MixerControlType.PeakMeter:
		case MixerControlType.Signed:
		case MixerControlType.Decibels:
		case MixerControlType.Slider:
		case MixerControlType.Pan:
		case MixerControlType.QSoundPan:
			return true;
		default:
			return false;
		}
	}

	private static bool IsControlUnsigned(MixerControlType controlType)
	{
		switch (controlType)
		{
		case MixerControlType.UnsignedMeter:
		case MixerControlType.Unsigned:
		case MixerControlType.Percent:
		case MixerControlType.Fader:
		case MixerControlType.Volume:
		case MixerControlType.Bass:
		case MixerControlType.Treble:
		case MixerControlType.Equalizer:
		case MixerControlType.MicroTime:
		case MixerControlType.MilliTime:
			return true;
		default:
			return false;
		}
	}

	private static bool IsControlCustom(MixerControlType controlType)
	{
		return controlType == MixerControlType.Custom;
	}

	public override string ToString()
	{
		return string.Format(_0001(107395444), Name, ControlType);
	}

	static MixerControl()
	{
		Strings.CreateGetStringDelegate(typeof(MixerControl));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0001(107397034), _0001(107396997)), _0001(107396992), _0001(107396987)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0001(107397014)))
		{
			return;
		}
		throw new SecurityException(_0001(107396957));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
