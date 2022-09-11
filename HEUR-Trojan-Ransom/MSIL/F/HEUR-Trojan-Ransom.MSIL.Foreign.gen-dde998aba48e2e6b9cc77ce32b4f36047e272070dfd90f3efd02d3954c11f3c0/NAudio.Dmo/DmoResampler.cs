using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

public sealed class DmoResampler : IDisposable
{
	private MediaObject mediaObject;

	private IPropertyStore propertyStoreInterface;

	private IWMResamplerProps resamplerPropsInterface;

	private ResamplerMediaComObject mediaComObject;

	[NonSerialized]
	internal static GetString _0093;

	public MediaObject MediaObject => mediaObject;

	public DmoResampler()
	{
		mediaComObject = new ResamplerMediaComObject();
		mediaObject = new MediaObject((IMediaObject)(object)mediaComObject);
		propertyStoreInterface = (IPropertyStore)(object)mediaComObject;
		resamplerPropsInterface = (IWMResamplerProps)(object)mediaComObject;
	}

	public void Dispose()
	{
		if (propertyStoreInterface != null)
		{
			Marshal.ReleaseComObject(propertyStoreInterface);
			propertyStoreInterface = null;
		}
		if (resamplerPropsInterface != null)
		{
			Marshal.ReleaseComObject(resamplerPropsInterface);
			resamplerPropsInterface = null;
		}
		if (mediaObject != null)
		{
			mediaObject.Dispose();
			mediaObject = null;
		}
		if (mediaComObject != null)
		{
			Marshal.ReleaseComObject(mediaComObject);
			mediaComObject = null;
		}
	}

	static DmoResampler()
	{
		Strings.CreateGetStringDelegate(typeof(DmoResampler));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0093(107397649), _0093(107397612)), _0093(107397607), _0093(107397602)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0093(107397629)))
		{
			return;
		}
		throw new SecurityException(_0093(107397572));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
