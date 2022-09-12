using System;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class AA6E8A8A4 : IDebugProgramNode2
{
	private readonly AD_PROCESS_ID A0A374144;

	private readonly string D4C1CC264;

	public AA6E8A8A4(AD_PROCESS_ID processId, string processName)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		A0A374144 = processId;
		D4C1CC264 = processName;
	}

	private int E255C8F21(out string FA4C22A18, out Guid B46CD02B4)
	{
		FA4C22A18 = B0E4D9146.E34BDB9D2;
		B46CD02B4 = new Guid("{029D0BD7-2382-44D7-BBE9-E45D5514E439}");
		return 0;
	}

	private int DF729474B(AD_PROCESS_ID[] E0B7A4DB0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		E0B7A4DB0[0] = A0A374144;
		return 0;
	}

	private int E736F9A89(enum_GETHOSTNAME_TYPE D76981DF3, out string A47952EE4)
	{
		A47952EE4 = D4C1CC264;
		return 0;
	}

	private int CE3B4B3EF(out string B9E489B13)
	{
		B9E489B13 = D4C1CC264;
		return 0;
	}

	private int A2B988CAB(IDebugProgram2 BC0ECF2A4, IDebugEventCallback2 D119AE37C, uint C6D1AB897)
	{
		return 1;
	}

	private int A49E5FC7D()
	{
		return 1;
	}

	private int AC970E247(out string EBEB656DD)
	{
		EBEB656DD = null;
		return 1;
	}
}
