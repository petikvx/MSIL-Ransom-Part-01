using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Compression;

internal sealed class AcmInterop
{
	public delegate bool AcmDriverEnumCallback(IntPtr hAcmDriverId, IntPtr instance, AcmDriverDetailsSupportFlags flags);

	public delegate bool AcmFormatEnumCallback(IntPtr hAcmDriverId, ref AcmFormatDetails formatDetails, IntPtr dwInstance, AcmDriverDetailsSupportFlags flags);

	public delegate bool AcmFormatTagEnumCallback(IntPtr hAcmDriverId, ref AcmFormatTagDetails formatTagDetails, IntPtr dwInstance, AcmDriverDetailsSupportFlags flags);

	public delegate bool AcmFormatChooseHookProc(IntPtr windowHandle, int message, IntPtr wParam, IntPtr lParam);

	[NonSerialized]
	internal static GetString _0018;

	[DllImport("msacm32.dll")]
	public static extern MmResult acmDriverAdd(out IntPtr driverHandle, IntPtr driverModule, IntPtr driverFunctionAddress, int priority, AcmDriverAddFlags flags);

	[DllImport("msacm32.dll")]
	public static extern MmResult acmDriverRemove(IntPtr driverHandle, int removeFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmDriverClose(IntPtr hAcmDriver, int closeFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmDriverEnum(AcmDriverEnumCallback fnCallback, IntPtr dwInstance, AcmDriverEnumFlags flags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmDriverDetails(IntPtr hAcmDriver, ref AcmDriverDetails driverDetails, int reserved);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmDriverOpen(out IntPtr pAcmDriver, IntPtr hAcmDriverId, int openFlags);

	[DllImport("Msacm32.dll", EntryPoint = "acmFormatChooseW")]
	public static extern MmResult acmFormatChoose(ref AcmFormatChoose formatChoose);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmFormatEnum(IntPtr hAcmDriver, ref AcmFormatDetails formatDetails, AcmFormatEnumCallback callback, IntPtr instance, AcmFormatEnumFlags flags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmFormatSuggest(IntPtr hAcmDriver, [In][MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "NAudio.Wave.WaveFormatCustomMarshaler")] WaveFormat sourceFormat, [In][Out][MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "NAudio.Wave.WaveFormatCustomMarshaler")] WaveFormat destFormat, int sizeDestFormat, AcmFormatSuggestFlags suggestFlags);

	[DllImport("Msacm32.dll", EntryPoint = "acmFormatSuggest")]
	public static extern MmResult acmFormatSuggest2(IntPtr hAcmDriver, IntPtr sourceFormatPointer, IntPtr destFormatPointer, int sizeDestFormat, AcmFormatSuggestFlags suggestFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmFormatTagEnum(IntPtr hAcmDriver, ref AcmFormatTagDetails formatTagDetails, AcmFormatTagEnumCallback callback, IntPtr instance, int reserved);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmMetrics(IntPtr hAcmObject, AcmMetrics metric, out int output);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamOpen(out IntPtr hAcmStream, IntPtr hAcmDriver, [In][MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "NAudio.Wave.WaveFormatCustomMarshaler")] WaveFormat sourceFormat, [In][MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "NAudio.Wave.WaveFormatCustomMarshaler")] WaveFormat destFormat, [In] WaveFilter waveFilter, IntPtr callback, IntPtr instance, AcmStreamOpenFlags openFlags);

	[DllImport("Msacm32.dll", EntryPoint = "acmStreamOpen")]
	public static extern MmResult acmStreamOpen2(out IntPtr hAcmStream, IntPtr hAcmDriver, IntPtr sourceFormatPointer, IntPtr destFormatPointer, [In] WaveFilter waveFilter, IntPtr callback, IntPtr instance, AcmStreamOpenFlags openFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamClose(IntPtr hAcmStream, int closeFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamConvert(IntPtr hAcmStream, [In][Out] AcmStreamHeaderStruct streamHeader, AcmStreamConvertFlags streamConvertFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamPrepareHeader(IntPtr hAcmStream, [In][Out] AcmStreamHeaderStruct streamHeader, int prepareFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamReset(IntPtr hAcmStream, int resetFlags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamSize(IntPtr hAcmStream, int inputBufferSize, out int outputBufferSize, AcmStreamSizeFlags flags);

	[DllImport("Msacm32.dll")]
	public static extern MmResult acmStreamUnprepareHeader(IntPtr hAcmStream, [In][Out] AcmStreamHeaderStruct streamHeader, int flags);

	static AcmInterop()
	{
		Strings.CreateGetStringDelegate(typeof(AcmInterop));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107398856), _0018(107398819)), _0018(107398814), _0018(107398809)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107398836)))
		{
			return;
		}
		throw new SecurityException(_0018(107398779));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
