using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager
{
	private static MemoryManager Cii2rZHWEp;

	private long uaZ2BFpkuR;

	[DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize")]
	private static extern int fuA2WTxUDV(IntPtr _0020, int _0020, int _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rKH200ieqO()
	{
		Process currentProcess = default(Process);
		try
		{
			try
			{
				currentProcess = Process.GetCurrentProcess();
				try
				{
					fuA2WTxUDV(currentProcess.Handle, -1, -1);
				}
				finally
				{
					((IDisposable)currentProcess)?.Dispose();
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.v3OTTS85dg(ex, currentProcess, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TbD2mp1Fbj(object _0020, EventArgs _0020)
	{
		DateTime now = default(DateTime);
		long ticks = default(long);
		try
		{
			try
			{
				now = DateTime.Now;
				ticks = now.Ticks;
				if (ticks - uaZ2BFpkuR > 10000000)
				{
					uaZ2BFpkuR = ticks;
					rKH200ieqO();
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.akITQBYJ2K(ex, ticks, now, this, _0020, _0020);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MemoryManager()
	{
		//Discarded unreachable code: IL_0036
		int num = 3;
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				base._002Ector();
				num = 5;
				break;
			case 0:
			case 1:
				now = DateTime.Now;
				uaZ2BFpkuR = now.Ticks;
				goto case 2;
			default:
				num = 4;
				break;
			case 3:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num = 0;
				if (pyIh2CKIJUHpEBHPuv())
				{
				}
				break;
			case 5:
				try
				{
					Application.add_Idle((EventHandler)TbD2mp1Fbj);
					rKH200ieqO();
					return;
				}
				catch (Exception ex)
				{
					pptnOHLG0SvOsuFuFDn.v3OTTS85dg(ex, now, this);
					throw;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _0001()
	{
		try
		{
			try
			{
				if (Environment.OSVersion.Platform == PlatformID.Win32NT)
				{
					Cii2rZHWEp = new MemoryManager();
				}
			}
			catch
			{
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.i0gTDRVccZ(ex);
			throw;
		}
	}

	internal static bool GM225o1cUbfdnvr2dP()
	{
		return true;
	}

	internal static bool pyIh2CKIJUHpEBHPuv()
	{
		return false;
	}
}
