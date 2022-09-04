using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

internal static class _003F72_003F
{
	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
	private static extern int _003F154_003F(IntPtr _003F168_003F, int _003F169_003F, byte[] _003F170_003F, uint _003F171_003F, out int _003F172_003F);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "NtSetInformationProcess", SetLastError = true)]
	private static extern uint _003F155_003F(IntPtr _003F168_003F, int _003F169_003F, byte[] _003F170_003F, uint _003F171_003F);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
	private static extern bool _003F156_003F(IntPtr _003F173_003F);

	[DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent")]
	private static extern bool _003F157_003F();

	[DllImport("kernel32.dll", EntryPoint = "OutputDebugString")]
	private static extern int _003F158_003F(string _003F174_003F);

	public static void _003F159_003F()
	{
		//IL_004d: Incompatible stack heights: 0 vs 1
		if (Environment.GetEnvironmentVariable(_003F176_003F._003F177_003F("WŜɀ\u034eѕՁ\u064fݏࡀ\u094e\u0a55\u0b59ౚ\u0d48เཌ၈ᅊቌፆ")) == null)
		{
			Environment.GetEnvironmentVariable(_003F176_003F._003F177_003F("Ońɘ\u0356јՕى\u0743ࡍ\u094f\u0a47\u0b53"));
			if ((int)/*Error near IL_0057: Stack underflow*/ == 0)
			{
				goto IL_0028;
			}
		}
		Environment.FailFast(_003F176_003F._003F177_003F("AŢɠ\u0368Ѥՠٮݸ\u0829६\u0a62୲ౠ൧\u0e77ཧၥ"));
		goto IL_0028;
		IL_0028:
		Thread thread = new Thread(_003F160_003F);
		thread.IsBackground = true;
		thread.Start(null);
	}

	private static void _003F160_003F(object _003F175_003F)
	{
		//IL_0078: Incompatible stack heights: 0 vs 1
		//IL_0087: Incompatible stack heights: 0 vs 1
		Thread thread = _003F175_003F as Thread;
		if (thread == null)
		{
			new ParameterizedThreadStart(_003F160_003F);
			thread = new Thread((ParameterizedThreadStart)/*Error near IL_0012: Stack underflow*/);
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		while (true)
		{
			if (!Debugger.IsAttached)
			{
				Debugger.IsLogging();
				if ((int)/*Error near IL_0091: Stack underflow*/ == 0)
				{
					goto IL_004d;
				}
			}
			Environment.FailFast(_003F176_003F._003F177_003F("_ſɻ\u036dѰձ\u0670ݦ࠳ॶੴ\u0b64౪൭\u0e79ཀྵၯᄪሡፅᑦᕨᙤᝣᡦᥦᨨ"));
			goto IL_004d;
			IL_004d:
			if (!thread.IsAlive)
			{
				Environment.FailFast(_003F176_003F._003F177_003F("Gťɦ\u0378Чդٷݫࡨ१੯"));
			}
			Thread.Sleep(1000);
		}
	}
}
