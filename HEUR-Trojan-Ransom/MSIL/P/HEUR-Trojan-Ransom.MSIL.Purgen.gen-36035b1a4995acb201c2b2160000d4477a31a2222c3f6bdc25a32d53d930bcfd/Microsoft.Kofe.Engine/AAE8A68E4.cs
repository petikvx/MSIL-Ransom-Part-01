using System;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class AAE8A68E4 : BE9A0B98B, IDebugExceptionEvent2
{
	private IDebugProgram2 EB49AE451;

	private string FE2B16F73;

	private uint F8C54478B;

	private string CABCDF522;

	private bool FF9FFEEC5;

	private bool E22FF3B58;

	public const string E4A44C5D3 = "51a94113-8788-4a54-ae15-08b74ff922d0";

	public AAE8A68E4(IDebugProgram2 program, string exceptionName, uint exceptionCode, string description, bool firstChance)
	{
		EB49AE451 = program;
		FE2B16F73 = exceptionName;
		CABCDF522 = description;
		F8C54478B = exceptionCode;
		FF9FFEEC5 = false;
		E22FF3B58 = firstChance;
	}

	public int B0F732A0F(EXCEPTION_INFO[] CEA34F0FE)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		CEA34F0FE[0].bstrExceptionName = FE2B16F73;
		EB49AE451.GetName(ref CEA34F0FE[0].bstrProgramName);
		CEA34F0FE[0].dwCode = F8C54478B;
		CEA34F0FE[0].dwState = (enum_EXCEPTION_STATE)(E22FF3B58 ? 1 : 2);
		CEA34F0FE[0].pProgram = EB49AE451;
		CEA34F0FE[0].guidType = new Guid("{029D0BD7-2382-44D7-BBE9-E45D5514E439}");
		return 0;
	}

	public int D6DA4E1E0(out string E5A296689)
	{
		E5A296689 = CABCDF522;
		return 0;
	}

	public int E675023FA()
	{
		if (!FF9FFEEC5)
		{
			return 1;
		}
		return 0;
	}

	public int E06A23591(int FF38471E4)
	{
		return 0;
	}
}
