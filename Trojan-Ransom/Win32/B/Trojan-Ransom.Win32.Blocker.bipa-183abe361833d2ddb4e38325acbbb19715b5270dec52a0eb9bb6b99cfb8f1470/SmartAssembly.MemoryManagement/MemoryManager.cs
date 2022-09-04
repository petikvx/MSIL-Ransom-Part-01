using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager
{
	private static MemoryManager m__0001;

	private long m__0001 = DateTime.Now.Ticks;

	[DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize")]
	private static extern int _0001(IntPtr _0002, int _0003, int _0004);

	private void _0001()
	{
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_0020: Incompatible stack heights: 0 vs 1
		//IL_0027: Incompatible stack heights: 0 vs 1
		//IL_003d: Incompatible stack heights: 0 vs 1
		try
		{
			Process.GetCurrentProcess();
			Process process = (Process)/*Error near IL_0040: Stack underflow*/;
			try
			{
				do
				{
					if (0 == 0 && 0 == 0)
					{
						_ = ((Process)/*Error near IL_0020: Stack underflow*/).Handle;
						_0001((IntPtr)/*Error near IL_0027: Stack underflow*/, -1, -1);
					}
				}
				while (4 == 0);
			}
			finally
			{
				if (5 == 0 || process != null)
				{
					((IDisposable)process).Dispose();
				}
			}
		}
		catch
		{
		}
	}

	private void _0001(object _0002, EventArgs _0003)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Incompatible stack heights: 0 vs 1
		//IL_0028: Invalid comparison between Unknown and I8
		//IL_0041: Incompatible stack heights: 0 vs 1
		//IL_004b: Incompatible stack heights: 0 vs 1
		//IL_0051: Incompatible stack heights: 0 vs 1
		//IL_0054: Incompatible stack heights: 0 vs 1
		//IL_0057: Incompatible stack heights: 0 vs 1
		//IL_005a: Incompatible stack heights: 0 vs 1
		//IL_005d: Incompatible stack heights: 0 vs 1
		try
		{
			if (false)
			{
				goto IL_0011;
			}
			_ = DateTime.Now;
			DateTime dateTime = default(DateTime);
			if (0 == 0)
			{
				dateTime = (DateTime)/*Error near IL_0044: Stack underflow*/;
			}
			_ = dateTime.Ticks;
			goto IL_004d;
			IL_0011:
			long num;
			if (uint.MaxValue != 0)
			{
				num = ((MemoryManager)/*Error near IL_001b: Stack underflow*/).m__0001;
				if (false)
				{
					goto IL_0028;
				}
				_ = /*Error near IL_001f: Stack underflow*/- num;
			}
			if (8 == 0)
			{
				goto IL_004d;
			}
			num = 10000000L;
			goto IL_0028;
			IL_0028:
			if ((long)/*Error near IL_002a: Stack underflow*/ > num)
			{
				((MemoryManager)/*Error near IL_0033: Stack underflow*/).m__0001 = (long)/*Error near IL_0033: Stack underflow*/;
				((MemoryManager)/*Error near IL_003a: Stack underflow*/)._0001();
			}
			return;
			IL_004d:
			long num2 = (long)/*Error near IL_004e: Stack underflow*/;
			goto IL_0011;
		}
		catch
		{
		}
	}

	private MemoryManager()
	{
		Application.add_Idle((EventHandler)_0001);
		this._0001();
	}

	public static void _0001()
	{
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_0023: Incompatible stack heights: 0 vs 1
		try
		{
			_ = Environment.OSVersion;
			_ = ((OperatingSystem)/*Error near IL_001c: Stack underflow*/).Platform;
			if ((int)/*Error near IL_0007: Stack underflow*/ == 2)
			{
				new MemoryManager();
				MemoryManager.m__0001 = (MemoryManager)/*Error near IL_000e: Stack underflow*/;
			}
		}
		catch
		{
		}
	}
}
