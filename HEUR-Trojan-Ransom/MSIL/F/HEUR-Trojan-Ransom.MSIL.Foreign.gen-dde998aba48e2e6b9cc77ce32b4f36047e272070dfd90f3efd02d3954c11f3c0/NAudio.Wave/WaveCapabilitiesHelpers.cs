using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal static class WaveCapabilitiesHelpers
{
	public static readonly Guid MicrosoftDefaultManufacturerId;

	public static readonly Guid DefaultWaveOutGuid;

	public static readonly Guid DefaultWaveInGuid;

	[NonSerialized]
	internal static GetString _0019;

	public static string GetNameFromGuid(Guid guid)
	{
		string result = null;
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_0019(107390542));
		using RegistryKey registryKey2 = registryKey.OpenSubKey(guid.ToString(_0019(107390477)));
		if (registryKey2 != null)
		{
			return registryKey2.GetValue(_0019(107390472)) as string;
		}
		return result;
	}

	static WaveCapabilitiesHelpers()
	{
		Strings.CreateGetStringDelegate(typeof(WaveCapabilitiesHelpers));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0019(107397827), _0019(107397790)).Replace(_0019(107397785), _0019(107397780)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0019(107397807)))
		{
			throw new SecurityException(_0019(107397750));
		}
		MicrosoftDefaultManufacturerId = new Guid(_0019(107390431));
		DefaultWaveOutGuid = new Guid(_0019(107390414));
		DefaultWaveInGuid = new Guid(_0019(107390333));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
