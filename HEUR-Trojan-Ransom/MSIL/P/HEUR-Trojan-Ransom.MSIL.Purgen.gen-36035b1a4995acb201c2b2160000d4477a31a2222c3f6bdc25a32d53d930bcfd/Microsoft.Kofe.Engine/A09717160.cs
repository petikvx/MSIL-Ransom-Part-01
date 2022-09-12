using System;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

public static class A09717160
{
	public static void BA0F763AF(int A5807A0FA)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (A5807A0FA != 0)
		{
			throw new ComponentException(A5807A0FA);
		}
	}

	public static void DEA99FC95(int F07BD531B)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (F07BD531B != 0)
		{
			throw new EngineException(F07BD531B);
		}
	}

	public static AD_PROCESS_ID AEB40F257(IDebugProcess2 B9629E7CC)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		AD_PROCESS_ID[] array = (AD_PROCESS_ID[])(object)new AD_PROCESS_ID[1];
		BA0F763AF(B9629E7CC.GetPhysicalProcessId(array));
		return array[0];
	}

	public static AD_PROCESS_ID FD33F459F(IDebugProgram2 BF4ED1B7C)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		IDebugProcess2 b9629E7CC = default(IDebugProcess2);
		BA0F763AF(BF4ED1B7C.GetProcess(ref b9629E7CC));
		return AEB40F257(b9629E7CC);
	}

	public static int ABD5D2EFF(Exception A97A2962F)
	{
		return 1;
	}

	internal static bool E5CC8D070(AD_PROCESS_ID EB5013784, AD_PROCESS_ID B888E87AF)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (EB5013784.ProcessIdType != B888E87AF.ProcessIdType)
		{
			return false;
		}
		if (EB5013784.ProcessIdType == 0)
		{
			return EB5013784.dwProcessId == B888E87AF.dwProcessId;
		}
		return EB5013784.guidProcessId == B888E87AF.guidProcessId;
	}
}
