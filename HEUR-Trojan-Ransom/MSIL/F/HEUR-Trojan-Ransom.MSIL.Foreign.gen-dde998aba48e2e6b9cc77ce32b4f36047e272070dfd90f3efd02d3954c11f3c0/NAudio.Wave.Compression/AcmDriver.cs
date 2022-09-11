using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Compression;

public sealed class AcmDriver : IDisposable
{
	private static List<AcmDriver> drivers;

	private AcmDriverDetails details;

	private IntPtr driverId;

	private IntPtr driverHandle;

	private List<AcmFormatTag> formatTags;

	private List<AcmFormat> tempFormatsList;

	private IntPtr localDllHandle;

	[NonSerialized]
	internal static GetString _0006;

	public int MaxFormatSize
	{
		get
		{
			MmException.Try(AcmInterop.acmMetrics(driverHandle, AcmMetrics.MaxSizeFormat, out var output), _0006(107383285));
			return output;
		}
	}

	public string ShortName => details.shortName;

	public string LongName => details.longName;

	public IntPtr DriverId => driverId;

	public IEnumerable<AcmFormatTag> FormatTags
	{
		get
		{
			if (formatTags == null)
			{
				if (driverHandle == IntPtr.Zero)
				{
					throw new InvalidOperationException(_0006(107383222));
				}
				formatTags = new List<AcmFormatTag>();
				AcmFormatTagDetails formatTagDetails = default(AcmFormatTagDetails);
				formatTagDetails.structureSize = Marshal.SizeOf((object)formatTagDetails);
				MmException.Try(AcmInterop.acmFormatTagEnum(driverHandle, ref formatTagDetails, AcmFormatTagEnumCallback, IntPtr.Zero, 0), _0006(107383185));
			}
			return formatTags;
		}
	}

	public static bool IsCodecInstalled(string shortName)
	{
		foreach (AcmDriver item in EnumerateAcmDrivers())
		{
			if (item.ShortName == shortName)
			{
				return true;
			}
		}
		return false;
	}

	public static AcmDriver AddLocalDriver(string driverFile)
	{
		IntPtr intPtr = NativeMethods.LoadLibrary(driverFile);
		if (intPtr == IntPtr.Zero)
		{
			throw new ArgumentException(_0006(107383005));
		}
		IntPtr procAddress = NativeMethods.GetProcAddress(intPtr, _0006(107383000));
		if (procAddress == IntPtr.Zero)
		{
			NativeMethods.FreeLibrary(intPtr);
			throw new ArgumentException(_0006(107382951));
		}
		IntPtr hAcmDriver;
		MmResult mmResult = AcmInterop.acmDriverAdd(out hAcmDriver, intPtr, procAddress, 0, AcmDriverAddFlags.Function);
		if (mmResult != 0)
		{
			NativeMethods.FreeLibrary(intPtr);
			throw new MmException(mmResult, _0006(107382910));
		}
		AcmDriver acmDriver = new AcmDriver(hAcmDriver);
		if (string.IsNullOrEmpty(acmDriver.details.longName))
		{
			acmDriver.details.longName = _0006(107382925) + Path.GetFileName(driverFile);
			acmDriver.localDllHandle = intPtr;
		}
		return acmDriver;
	}

	public static void RemoveLocalDriver(AcmDriver localDriver)
	{
		if (localDriver.localDllHandle == IntPtr.Zero)
		{
			throw new ArgumentException(_0006(107382904));
		}
		MmResult result = AcmInterop.acmDriverRemove(localDriver.driverId, 0);
		NativeMethods.FreeLibrary(localDriver.localDllHandle);
		MmException.Try(result, _0006(107382783));
	}

	public static bool ShowFormatChooseDialog(IntPtr ownerWindowHandle, string windowTitle, AcmFormatEnumFlags enumFlags, WaveFormat enumFormat, out WaveFormat selectedFormat, out string selectedFormatDescription, out string selectedFormatTagDescription)
	{
		AcmFormatChoose formatChoose = default(AcmFormatChoose);
		formatChoose.structureSize = Marshal.SizeOf((object)formatChoose);
		formatChoose.styleFlags = AcmFormatChooseStyleFlags.None;
		formatChoose.ownerWindowHandle = ownerWindowHandle;
		int num = 200;
		formatChoose.selectedWaveFormatPointer = Marshal.AllocHGlobal(num);
		formatChoose.selectedWaveFormatByteSize = num;
		formatChoose.title = windowTitle;
		formatChoose.name = null;
		formatChoose.formatEnumFlags = enumFlags;
		formatChoose.waveFormatEnumPointer = IntPtr.Zero;
		if (enumFormat != null)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)enumFormat));
			Marshal.StructureToPtr((object)enumFormat, intPtr, fDeleteOld: false);
			formatChoose.waveFormatEnumPointer = intPtr;
		}
		formatChoose.instanceHandle = IntPtr.Zero;
		formatChoose.templateName = null;
		MmResult mmResult = AcmInterop.acmFormatChoose(ref formatChoose);
		selectedFormat = null;
		selectedFormatDescription = null;
		selectedFormatTagDescription = null;
		if (mmResult == MmResult.NoError)
		{
			selectedFormat = WaveFormat.MarshalFromPtr(formatChoose.selectedWaveFormatPointer);
			selectedFormatDescription = formatChoose.formatDescription;
			selectedFormatTagDescription = formatChoose.formatTagDescription;
		}
		Marshal.FreeHGlobal(formatChoose.waveFormatEnumPointer);
		Marshal.FreeHGlobal(formatChoose.selectedWaveFormatPointer);
		if (mmResult != MmResult.AcmCancelled && mmResult != 0)
		{
			throw new MmException(mmResult, _0006(107382794));
		}
		return mmResult == MmResult.NoError;
	}

	public static AcmDriver FindByShortName(string shortName)
	{
		foreach (AcmDriver item in EnumerateAcmDrivers())
		{
			if (item.ShortName == shortName)
			{
				return item;
			}
		}
		return null;
	}

	public static IEnumerable<AcmDriver> EnumerateAcmDrivers()
	{
		drivers = new List<AcmDriver>();
		MmException.Try(AcmInterop.acmDriverEnum(DriverEnumCallback, IntPtr.Zero, (AcmDriverEnumFlags)0), _0006(107383236));
		return drivers;
	}

	private static bool DriverEnumCallback(IntPtr hAcmDriver, IntPtr dwInstance, AcmDriverDetailsSupportFlags flags)
	{
		drivers.Add(new AcmDriver(hAcmDriver));
		return true;
	}

	private AcmDriver(IntPtr hAcmDriver)
	{
		driverId = hAcmDriver;
		details = default(AcmDriverDetails);
		details.structureSize = Marshal.SizeOf((object)details);
		MmException.Try(AcmInterop.acmDriverDetails(hAcmDriver, ref details, 0), _0006(107383247));
	}

	public override string ToString()
	{
		return LongName;
	}

	public IEnumerable<AcmFormat> GetFormats(AcmFormatTag formatTag)
	{
		if (driverHandle == IntPtr.Zero)
		{
			throw new InvalidOperationException(_0006(107383222));
		}
		tempFormatsList = new List<AcmFormat>();
		AcmFormatDetails formatDetails = default(AcmFormatDetails);
		formatDetails.structSize = Marshal.SizeOf((object)formatDetails);
		formatDetails.waveFormatByteSize = 1024;
		formatDetails.waveFormatPointer = Marshal.AllocHGlobal(formatDetails.waveFormatByteSize);
		formatDetails.formatTag = (int)formatTag.FormatTag;
		MmResult result = AcmInterop.acmFormatEnum(driverHandle, ref formatDetails, AcmFormatEnumCallback, IntPtr.Zero, AcmFormatEnumFlags.None);
		Marshal.FreeHGlobal(formatDetails.waveFormatPointer);
		MmException.Try(result, _0006(107383160));
		return tempFormatsList;
	}

	public void Open()
	{
		if (driverHandle == IntPtr.Zero)
		{
			MmException.Try(AcmInterop.acmDriverOpen(out driverHandle, DriverId, 0), _0006(107383107));
		}
	}

	public void Close()
	{
		if (driverHandle != IntPtr.Zero)
		{
			MmException.Try(AcmInterop.acmDriverClose(driverHandle, 0), _0006(107383118));
			driverHandle = IntPtr.Zero;
		}
	}

	private bool AcmFormatTagEnumCallback(IntPtr hAcmDriverId, ref AcmFormatTagDetails formatTagDetails, IntPtr dwInstance, AcmDriverDetailsSupportFlags flags)
	{
		formatTags.Add(new AcmFormatTag(formatTagDetails));
		return true;
	}

	private bool AcmFormatEnumCallback(IntPtr hAcmDriverId, ref AcmFormatDetails formatDetails, IntPtr dwInstance, AcmDriverDetailsSupportFlags flags)
	{
		tempFormatsList.Add(new AcmFormat(formatDetails));
		return true;
	}

	public void Dispose()
	{
		if (driverHandle != IntPtr.Zero)
		{
			Close();
			GC.SuppressFinalize(this);
		}
	}

	static AcmDriver()
	{
		Strings.CreateGetStringDelegate(typeof(AcmDriver));
	}
}
