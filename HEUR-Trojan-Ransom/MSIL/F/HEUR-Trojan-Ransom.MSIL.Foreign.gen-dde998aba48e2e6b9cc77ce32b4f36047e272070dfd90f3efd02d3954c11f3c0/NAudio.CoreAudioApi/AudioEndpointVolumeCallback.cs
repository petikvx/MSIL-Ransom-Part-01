using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

internal sealed class AudioEndpointVolumeCallback : IAudioEndpointVolumeCallback
{
	private readonly AudioEndpointVolume parent;

	[NonSerialized]
	internal static GetString _0086;

	internal AudioEndpointVolumeCallback(AudioEndpointVolume parent)
	{
		this.parent = parent;
	}

	public void OnNotify(IntPtr notifyData)
	{
		AudioVolumeNotificationDataStruct audioVolumeNotificationDataStruct = MarshalHelpers.PtrToStructure<AudioVolumeNotificationDataStruct>(notifyData);
		IntPtr intPtr = MarshalHelpers.OffsetOf<AudioVolumeNotificationDataStruct>(_0086(107404448));
		IntPtr pointer = (IntPtr)((long)notifyData + (long)intPtr);
		float[] array = new float[audioVolumeNotificationDataStruct.nChannels];
		for (int i = 0; i < audioVolumeNotificationDataStruct.nChannels; i++)
		{
			array[i] = MarshalHelpers.PtrToStructure<float>(pointer);
		}
		AudioVolumeNotificationData notificationData = new AudioVolumeNotificationData(audioVolumeNotificationDataStruct.guidEventContext, audioVolumeNotificationDataStruct.bMuted, audioVolumeNotificationDataStruct.fMasterVolume, array, audioVolumeNotificationDataStruct.guidEventContext);
		parent.FireNotification(notificationData);
	}

	static AudioEndpointVolumeCallback()
	{
		Strings.CreateGetStringDelegate(typeof(AudioEndpointVolumeCallback));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0086(107400072), _0086(107400035)), _0086(107400030), _0086(107400025)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0086(107400052)))
		{
			return;
		}
		throw new SecurityException(_0086(107399995));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
