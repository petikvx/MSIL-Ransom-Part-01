using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public static class PropertyKeys
{
	public static readonly PropertyKey PKEY_DeviceInterface_FriendlyName;

	public static readonly PropertyKey PKEY_AudioEndpoint_FormFactor;

	public static readonly PropertyKey PKEY_AudioEndpoint_ControlPanelPageProvider;

	public static readonly PropertyKey PKEY_AudioEndpoint_Association;

	public static readonly PropertyKey PKEY_AudioEndpoint_PhysicalSpeakers;

	public static readonly PropertyKey PKEY_AudioEndpoint_GUID;

	public static readonly PropertyKey PKEY_AudioEndpoint_Disable_SysFx;

	public static readonly PropertyKey PKEY_AudioEndpoint_FullRangeSpeakers;

	public static readonly PropertyKey PKEY_AudioEndpoint_Supports_EventDriven_Mode;

	public static readonly PropertyKey PKEY_AudioEndpoint_JackSubType;

	public static readonly PropertyKey PKEY_AudioEngine_DeviceFormat;

	public static readonly PropertyKey PKEY_AudioEngine_OEMFormat;

	public static readonly PropertyKey PKEY_Device_FriendlyName;

	public static readonly PropertyKey PKEY_Device_IconPath;

	[NonSerialized]
	internal static GetString _0001;

	static PropertyKeys()
	{
		Strings.CreateGetStringDelegate(typeof(PropertyKeys));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0001(107400152), _0001(107400115)).Replace(_0001(107400110), _0001(107400105)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0001(107400132)))
		{
			throw new SecurityException(_0001(107400075));
		}
		PKEY_DeviceInterface_FriendlyName = new PropertyKey(new Guid(40784238, -18412, 16715, 131, 205, 133, 109, 111, 239, 72, 34), 2);
		PKEY_AudioEndpoint_FormFactor = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 0);
		PKEY_AudioEndpoint_ControlPanelPageProvider = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 1);
		PKEY_AudioEndpoint_Association = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 2);
		PKEY_AudioEndpoint_PhysicalSpeakers = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 3);
		PKEY_AudioEndpoint_GUID = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 4);
		PKEY_AudioEndpoint_Disable_SysFx = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 5);
		PKEY_AudioEndpoint_FullRangeSpeakers = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 6);
		PKEY_AudioEndpoint_Supports_EventDriven_Mode = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 7);
		PKEY_AudioEndpoint_JackSubType = new PropertyKey(new Guid(497408003, -11118, 20189, 140, 35, 224, 192, byte.MaxValue, 238, 127, 14), 8);
		PKEY_AudioEngine_DeviceFormat = new PropertyKey(new Guid(-241236403, 2092, 20007, 188, 115, 104, 130, 161, 187, 142, 76), 0);
		PKEY_AudioEngine_OEMFormat = new PropertyKey(new Guid(-460911066, 15557, 19666, 186, 70, 202, 10, 154, 112, 237, 4), 3);
		PKEY_Device_FriendlyName = new PropertyKey(new Guid(-1537465010, -8420, 20221, 128, 32, 103, 209, 70, 168, 80, 224), 14);
		PKEY_Device_IconPath = new PropertyKey(new Guid(630898684, 20647, 18382, 175, 8, 104, 201, 167, 215, 51, 102), 12);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
