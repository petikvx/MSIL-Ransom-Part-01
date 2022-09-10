using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class Utilities
{
	private static bool? isHttpApiLibAvailable;

	private static string localizedMyComputerString;

	internal static int OSMajor => Environment.OSVersion.Version.Major;

	internal static string LocalHostName
	{
		get
		{
			try
			{
				return Dns.GetHostName();
			}
			catch (SocketException)
			{
				return null;
			}
		}
	}

	internal static bool IsHttpApiLibAvailable
	{
		get
		{
			if (!isHttpApiLibAvailable.HasValue)
			{
				isHttpApiLibAvailable = IsHttpApiLibAvailableHelper();
			}
			return isHttpApiLibAvailable.Value;
		}
	}

	internal static void Log(string s)
	{
	}

	internal static bool SafeCompare(string s1, string s2)
	{
		return string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase) == 0;
	}

	internal static int GetOSMajor(string machineName)
	{
		if (IsLocalMachineName(machineName))
		{
			return OSMajor;
		}
		int result = 0;
		try
		{
			if (SafeNativeMethods.NetWkstaGetInfo("\\\\" + machineName, 100, out var bufptr) == 0)
			{
				if (bufptr != IntPtr.Zero)
				{
					try
					{
						result = ((SafeNativeMethods.WKSTA_INFO_100)Marshal.PtrToStructure(bufptr, typeof(SafeNativeMethods.WKSTA_INFO_100))).ver_major;
					}
					finally
					{
						int num = SafeNativeMethods.NetApiBufferFree(bufptr);
					}
					bufptr = IntPtr.Zero;
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception e)
		{
			if (IsCriticalException(e))
			{
				throw;
			}
			return result;
		}
	}

	internal static string GetEnabledStatusString(bool enabled)
	{
		if (!enabled)
		{
			return SR.GetString("ConfigStatusDiabled");
		}
		return SR.GetString("ConfigStatusEnabled");
	}

	internal static bool ParseSourceLevel(string levelString, out SourceLevels level)
	{
		level = SourceLevels.Off;
		if (SafeCompare(levelString, "Off"))
		{
			level = SourceLevels.Off;
		}
		else if (SafeCompare(levelString, "Error"))
		{
			level = SourceLevels.Error;
		}
		else if (SafeCompare(levelString, "Critical"))
		{
			level = SourceLevels.Critical;
		}
		else if (SafeCompare(levelString, "Warning"))
		{
			level = SourceLevels.Warning;
		}
		else if (SafeCompare(levelString, "Information"))
		{
			level = SourceLevels.Information;
		}
		else if (SafeCompare(levelString, "Verbose"))
		{
			level = SourceLevels.Verbose;
		}
		else
		{
			if (!SafeCompare(levelString, "All"))
			{
				return false;
			}
			level = SourceLevels.All;
		}
		return true;
	}

	internal static bool IsLocalMachineName(string machineName)
	{
		if (localizedMyComputerString == null)
		{
			localizedMyComputerString = "My Computer";
			IntPtr intPtr = SafeNativeMethods.LoadLibrary("ComRes.dll");
			if (intPtr != IntPtr.Zero)
			{
				int num = 16;
				int num2;
				do
				{
					StringBuilder stringBuilder = new StringBuilder(num);
					num2 = SafeNativeMethods.LoadString(intPtr, 1824u, stringBuilder, num);
					if (num2 <= 0 || num2 >= num)
					{
						num *= 2;
						continue;
					}
					localizedMyComputerString = stringBuilder.ToString();
					break;
				}
				while (num2 > 0);
				SafeNativeMethods.FreeLibrary(intPtr);
			}
		}
		if (!string.IsNullOrEmpty(machineName) && !SafeCompare(machineName, "localhost") && !SafeCompare(machineName, localizedMyComputerString))
		{
			return SafeCompare(machineName, LocalHostName);
		}
		return true;
	}

	private static bool IsHttpApiLibAvailableHelper()
	{
		bool flag = false;
		int num = 0;
		try
		{
			num = SafeNativeMethods.HttpInitialize(new HttpApiVersion(1, 0), 2, IntPtr.Zero);
			SafeNativeMethods.HttpTerminate(2, IntPtr.Zero);
			if (num != 0)
			{
				return false;
			}
			return true;
		}
		catch (FileNotFoundException)
		{
			return false;
		}
	}

	internal static bool IsCriticalException(Exception e)
	{
		if (!(e is AccessViolationException) && !(e is StackOverflowException) && !(e is OutOfMemoryException) && !(e is ExecutionEngineException))
		{
			return e is ThreadAbortException;
		}
		return true;
	}
}
