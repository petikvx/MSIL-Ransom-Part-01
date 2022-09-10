using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class DXUtil
{
	private static bool isTimerInitialized = false;

	private static bool m_bUsingQPF = false;

	private static bool m_bTimerStopped = true;

	private static long m_llQPFTicksPerSec = 0L;

	private static long m_llStopTime = 0L;

	private static long m_llLastElapsedTime = 0L;

	private static long m_llBaseTime = 0L;

	private static double m_fLastElapsedTime = 0.0;

	private static double m_fBaseTime = 0.0;

	private static double m_fStopTime = 0.0;

	private const string sdkPath = "Software\\Microsoft\\DirectX SDK";

	private const string sdkKey = "DX9SDK Samples Path";

	public static string SdkMediaPath
	{
		get
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\DirectX SDK");
			string text = string.Empty;
			if (registryKey != null)
			{
				text = StringType.FromObject(registryKey.GetValue("DX9SDK Samples Path"));
				registryKey.Close();
			}
			if (text != null)
			{
				return text + "\\Media\\";
			}
			return string.Empty;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool QueryPerformanceCounter(ref long PerformanceCount);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int timeGetTime();

	private DXUtil()
	{
	}

	public static float Timer(DirectXTimer command)
	{
		if (!isTimerInitialized)
		{
			isTimerInitialized = true;
			long PerformanceFrequency = 0L;
			m_bUsingQPF = QueryPerformanceFrequency(ref PerformanceFrequency);
			if (m_bUsingQPF)
			{
				m_llQPFTicksPerSec = PerformanceFrequency;
			}
		}
		if (m_bUsingQPF)
		{
			long PerformanceCount = 0L;
			if (m_llStopTime != 0L && command != DirectXTimer.Start && command != DirectXTimer.GetAbsoluteTime)
			{
				PerformanceCount = m_llStopTime;
			}
			else
			{
				QueryPerformanceCounter(ref PerformanceCount);
			}
			switch (command)
			{
			case DirectXTimer.GetElapsedTime:
			{
				double num3 = (double)(PerformanceCount - m_llLastElapsedTime) / (double)m_llQPFTicksPerSec;
				m_llLastElapsedTime = PerformanceCount;
				return (float)num3;
			}
			case DirectXTimer.GetApplicationTime:
			{
				double num2 = (double)(PerformanceCount - m_llBaseTime) / (double)m_llQPFTicksPerSec;
				return (float)num2;
			}
			case DirectXTimer.Reset:
				m_llBaseTime = PerformanceCount;
				m_llLastElapsedTime = PerformanceCount;
				m_llStopTime = 0L;
				m_bTimerStopped = false;
				return 0f;
			case DirectXTimer.Start:
				if (m_bTimerStopped)
				{
					m_llBaseTime += PerformanceCount - m_llStopTime;
				}
				m_llStopTime = 0L;
				m_llLastElapsedTime = PerformanceCount;
				m_bTimerStopped = false;
				return 0f;
			case DirectXTimer.Stop:
				if (!m_bTimerStopped)
				{
					m_llStopTime = PerformanceCount;
					m_llLastElapsedTime = PerformanceCount;
					m_bTimerStopped = true;
				}
				return 0f;
			case DirectXTimer.Advance:
				m_llStopTime = (long)Math.Round((double)m_llStopTime + (double)m_llQPFTicksPerSec / 10.0);
				return 0f;
			case DirectXTimer.GetAbsoluteTime:
			{
				double num = (double)PerformanceCount / (double)m_llQPFTicksPerSec;
				return (float)num;
			}
			default:
				return -1f;
			}
		}
		double num4 = ((!(m_fStopTime != 0.0 && command != DirectXTimer.Start && command != DirectXTimer.GetAbsoluteTime)) ? ((double)timeGetTime() * 0.001) : m_fStopTime);
		switch (command)
		{
		case DirectXTimer.GetElapsedTime:
		{
			double num5 = num4 - m_fLastElapsedTime;
			m_fLastElapsedTime = num4;
			return (float)num5;
		}
		case DirectXTimer.GetApplicationTime:
			return (float)(num4 - m_fBaseTime);
		case DirectXTimer.Reset:
			m_fBaseTime = num4;
			m_fLastElapsedTime = num4;
			m_fStopTime = 0.0;
			m_bTimerStopped = false;
			return 0f;
		case DirectXTimer.Start:
			if (m_bTimerStopped)
			{
				m_fBaseTime += num4 - m_fStopTime;
			}
			m_fStopTime = 0.0;
			m_fLastElapsedTime = num4;
			m_bTimerStopped = false;
			return 0f;
		case DirectXTimer.Stop:
			if (!m_bTimerStopped)
			{
				m_fStopTime = num4;
				m_fLastElapsedTime = num4;
				m_bTimerStopped = true;
			}
			return 0f;
		case DirectXTimer.Advance:
			m_fStopTime += 0.10000000149011612;
			return 0f;
		case DirectXTimer.GetAbsoluteTime:
			return (float)num4;
		default:
			return -1f;
		}
	}

	public static string FindMediaFile(string sPath, string sFilename)
	{
		if (sPath != null && File.Exists(AppendDirSep(sPath) + sFilename))
		{
			return AppendDirSep(sPath) + sFilename;
		}
		if (File.Exists(sFilename))
		{
			return AppendDirSep(Directory.GetCurrentDirectory()) + sFilename;
		}
		if (!File.Exists(AppendDirSep(SdkMediaPath) + sFilename))
		{
			throw new FileNotFoundException("Could not find this file.", sFilename);
		}
		return AppendDirSep(SdkMediaPath) + sFilename;
	}

	private static string AppendDirSep(string sFile)
	{
		if (!sFile.EndsWith("\\"))
		{
			return sFile + "\\";
		}
		return sFile;
	}
}
