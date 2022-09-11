using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Asio;

public sealed class AsioDriver
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	private sealed class AsioDriverVTable
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate int ASIOInit(IntPtr _pUnknown, IntPtr sysHandle);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void ASIOgetDriverName(IntPtr _pUnknown, StringBuilder name);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate int ASIOgetDriverVersion(IntPtr _pUnknown);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void ASIOgetErrorMessage(IntPtr _pUnknown, StringBuilder errorMessage);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOstart(IntPtr _pUnknown);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOstop(IntPtr _pUnknown);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetChannels(IntPtr _pUnknown, out int numInputChannels, out int numOutputChannels);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetLatencies(IntPtr _pUnknown, out int inputLatency, out int outputLatency);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetBufferSize(IntPtr _pUnknown, out int minSize, out int maxSize, out int preferredSize, out int granularity);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOcanSampleRate(IntPtr _pUnknown, double sampleRate);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetSampleRate(IntPtr _pUnknown, out double sampleRate);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOsetSampleRate(IntPtr _pUnknown, double sampleRate);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetClockSources(IntPtr _pUnknown, out long clocks, int numSources);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOsetClockSource(IntPtr _pUnknown, int reference);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetSamplePosition(IntPtr _pUnknown, out long samplePos, ref Asio64Bit timeStamp);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOgetChannelInfo(IntPtr _pUnknown, ref AsioChannelInfo info);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOcreateBuffers(IntPtr _pUnknown, IntPtr bufferInfos, int numChannels, int bufferSize, IntPtr callbacks);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOdisposeBuffers(IntPtr _pUnknown);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOcontrolPanel(IntPtr _pUnknown);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOfuture(IntPtr _pUnknown, int selector, IntPtr opt);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate AsioError ASIOoutputReady(IntPtr _pUnknown);

		public ASIOInit init;

		public ASIOgetDriverName getDriverName;

		public ASIOgetDriverVersion getDriverVersion;

		public ASIOgetErrorMessage getErrorMessage;

		public ASIOstart start;

		public ASIOstop stop;

		public ASIOgetChannels getChannels;

		public ASIOgetLatencies getLatencies;

		public ASIOgetBufferSize getBufferSize;

		public ASIOcanSampleRate canSampleRate;

		public ASIOgetSampleRate getSampleRate;

		public ASIOsetSampleRate setSampleRate;

		public ASIOgetClockSources getClockSources;

		public ASIOsetClockSource setClockSource;

		public ASIOgetSamplePosition getSamplePosition;

		public ASIOgetChannelInfo getChannelInfo;

		public ASIOcreateBuffers createBuffers;

		public ASIOdisposeBuffers disposeBuffers;

		public ASIOcontrolPanel controlPanel;

		public ASIOfuture future;

		public ASIOoutputReady outputReady;

		[NonSerialized]
		internal static GetString _0087;

		static AsioDriverVTable()
		{
			Strings.CreateGetStringDelegate(typeof(AsioDriverVTable));
			bool flag = false;
			Assembly assembly = global::_0005._001B();
			Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0087(107399002), _0087(107398965)), _0087(107398960), _0087(107398955)));
			if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0087(107398982)))
			{
				return;
			}
			throw new SecurityException(_0087(107398925));
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
	}

	private IntPtr pAsioComObject;

	private IntPtr pinnedcallbacks;

	private AsioDriverVTable asioDriverVTable;

	[NonSerialized]
	internal static GetString _009D;

	private AsioDriver()
	{
	}

	public static string[] GetAsioDriverNames()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_009D(107415291));
		string[] result = new string[0];
		if (registryKey != null)
		{
			result = registryKey.GetSubKeyNames();
			registryKey.Close();
		}
		return result;
	}

	public static AsioDriver GetAsioDriverByName(string name)
	{
		return GetAsioDriverByGuid(new Guid((Registry.LocalMachine.OpenSubKey(_009D(107415302) + name) ?? throw new ArgumentException(string.Format(_009D(107415281), name)))!.GetValue(_009D(107415752))!.ToString()));
	}

	public static AsioDriver GetAsioDriverByGuid(Guid guid)
	{
		AsioDriver asioDriver = new AsioDriver();
		asioDriver.InitFromGuid(guid);
		return asioDriver;
	}

	public bool Init(IntPtr sysHandle)
	{
		return asioDriverVTable.init(pAsioComObject, sysHandle) == 1;
	}

	public string GetDriverName()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		asioDriverVTable.getDriverName(pAsioComObject, stringBuilder);
		return stringBuilder.ToString();
	}

	public int GetDriverVersion()
	{
		return asioDriverVTable.getDriverVersion(pAsioComObject);
	}

	public string GetErrorMessage()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		asioDriverVTable.getErrorMessage(pAsioComObject, stringBuilder);
		return stringBuilder.ToString();
	}

	public void Start()
	{
		HandleException(asioDriverVTable.start(pAsioComObject), _009D(107415711));
	}

	public AsioError Stop()
	{
		return asioDriverVTable.stop(pAsioComObject);
	}

	public void GetChannels(out int numInputChannels, out int numOutputChannels)
	{
		HandleException(asioDriverVTable.getChannels(pAsioComObject, out numInputChannels, out numOutputChannels), _009D(107415702));
	}

	public AsioError GetLatencies(out int inputLatency, out int outputLatency)
	{
		return asioDriverVTable.getLatencies(pAsioComObject, out inputLatency, out outputLatency);
	}

	public void GetBufferSize(out int minSize, out int maxSize, out int preferredSize, out int granularity)
	{
		HandleException(asioDriverVTable.getBufferSize(pAsioComObject, out minSize, out maxSize, out preferredSize, out granularity), _009D(107415717));
	}

	public bool CanSampleRate(double sampleRate)
	{
		AsioError asioError = asioDriverVTable.canSampleRate(pAsioComObject, sampleRate);
		switch (asioError)
		{
		case AsioError.ASE_NoClock:
			return false;
		case AsioError.ASE_OK:
			return true;
		default:
			HandleException(asioError, _009D(107415696));
			return false;
		}
	}

	public double GetSampleRate()
	{
		HandleException(asioDriverVTable.getSampleRate(pAsioComObject, out var sampleRate), _009D(107415643));
		return sampleRate;
	}

	public void SetSampleRate(double sampleRate)
	{
		HandleException(asioDriverVTable.setSampleRate(pAsioComObject, sampleRate), _009D(107415654));
	}

	public void GetClockSources(out long clocks, int numSources)
	{
		HandleException(asioDriverVTable.getClockSources(pAsioComObject, out clocks, numSources), _009D(107415633));
	}

	public void SetClockSource(int reference)
	{
		HandleException(asioDriverVTable.setClockSource(pAsioComObject, reference), _009D(107415580));
	}

	public void GetSamplePosition(out long samplePos, ref Asio64Bit timeStamp)
	{
		HandleException(asioDriverVTable.getSamplePosition(pAsioComObject, out samplePos, ref timeStamp), _009D(107415591));
	}

	public AsioChannelInfo GetChannelInfo(int channelNumber, bool trueForInputInfo)
	{
		AsioChannelInfo asioChannelInfo = default(AsioChannelInfo);
		asioChannelInfo.channel = channelNumber;
		asioChannelInfo.isInput = trueForInputInfo;
		AsioChannelInfo info = asioChannelInfo;
		HandleException(asioDriverVTable.getChannelInfo(pAsioComObject, ref info), _009D(107415566));
		return info;
	}

	public void CreateBuffers(IntPtr bufferInfos, int numChannels, int bufferSize, ref AsioCallbacks callbacks)
	{
		pinnedcallbacks = Marshal.AllocHGlobal(Marshal.SizeOf((object)callbacks));
		Marshal.StructureToPtr((object)callbacks, pinnedcallbacks, fDeleteOld: false);
		HandleException(asioDriverVTable.createBuffers(pAsioComObject, bufferInfos, numChannels, bufferSize, pinnedcallbacks), _009D(107415513));
	}

	public AsioError DisposeBuffers()
	{
		AsioError result = asioDriverVTable.disposeBuffers(pAsioComObject);
		Marshal.FreeHGlobal(pinnedcallbacks);
		return result;
	}

	public void ControlPanel()
	{
		HandleException(asioDriverVTable.controlPanel(pAsioComObject), _009D(107415524));
	}

	public void Future(int selector, IntPtr opt)
	{
		HandleException(asioDriverVTable.future(pAsioComObject, selector, opt), _009D(107414963));
	}

	public AsioError OutputReady()
	{
		return asioDriverVTable.outputReady(pAsioComObject);
	}

	public void ReleaseComAsioDriver()
	{
		Marshal.Release(pAsioComObject);
	}

	private void HandleException(AsioError error, string methodName)
	{
		if (error != 0 && error != AsioError.ASE_SUCCESS)
		{
			throw new AsioException(string.Format(_009D(107414986), AsioException.getErrorName(error), methodName, GetErrorMessage()))
			{
				Error = error
			};
		}
	}

	private void InitFromGuid(Guid asioGuid)
	{
		int num = CoCreateInstance(ref asioGuid, IntPtr.Zero, 1u, ref asioGuid, out pAsioComObject);
		if (num != 0)
		{
			throw new COMException(_009D(107414881), num);
		}
		IntPtr ptr = Marshal.ReadIntPtr(pAsioComObject);
		asioDriverVTable = new AsioDriverVTable();
		FieldInfo[] fields = typeof(AsioDriverVTable).GetFields();
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo fieldInfo = fields[i];
			object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(ptr, (i + 3) * IntPtr.Size), fieldInfo.FieldType);
			fieldInfo.SetValue(asioDriverVTable, delegateForFunctionPointer);
		}
	}

	[DllImport("ole32.Dll")]
	private static extern int CoCreateInstance(ref Guid clsid, IntPtr inner, uint context, ref Guid uuid, out IntPtr rReturnedComObject);

	static AsioDriver()
	{
		Strings.CreateGetStringDelegate(typeof(AsioDriver));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009D(107398980), _009D(107398943)), _009D(107398938), _009D(107398933)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009D(107398960)))
		{
			return;
		}
		throw new SecurityException(_009D(107398903));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
