using System.Runtime.InteropServices;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class B034EA488 : IDebugErrorBreakpointResolution2
{
	private string EF475735F;

	private enum_BP_ERROR_TYPE AE39BD5E0;

	private B92FAA9B7 E36995F14;

	private IJdwpCodeLocation E5C901848;

	private F21674B78 B2FA6DBD8;

	public B034EA488(B92FAA9B7 engine, IJdwpCodeLocation location, F21674B78 documentContext, string msg, enum_BP_ERROR_TYPE errorType = 117440513)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		E36995F14 = engine;
		E5C901848 = location;
		B2FA6DBD8 = documentContext;
		EF475735F = msg;
		AE39BD5E0 = errorType;
	}

	private int FB9FC03DA(enum_BP_TYPE[] CBB76484E)
	{
		CBB76484E[0] = (enum_BP_TYPE)1;
		return 0;
	}

	private int DAF5BDCA2(enum_BPERESI_FIELDS E8022A831, BP_ERROR_RESOLUTION_INFO[] F4089B0A2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		if ((E8022A831 & 1) != 0)
		{
			BP_RESOLUTION_LOCATION bpResLocation = default(BP_RESOLUTION_LOCATION);
			bpResLocation.bpType = 1u;
			E604AB64A e604AB64A = new E604AB64A(E36995F14, E5C901848);
			e604AB64A.AFC7258C0((IDebugDocumentContext2)(object)B2FA6DBD8);
			bpResLocation.unionmember1 = Marshal.GetComInterfaceForObject(e604AB64A, typeof(IDebugCodeContext2));
			F4089B0A2[0].bpResLocation = bpResLocation;
			ref enum_BPERESI_FIELDS dwFields = ref F4089B0A2[0].dwFields;
			dwFields = (enum_BPERESI_FIELDS)((uint)dwFields | 1u);
		}
		if ((E8022A831 & 2) != 0)
		{
			F4089B0A2[0].pProgram = (IDebugProgram2)(object)E36995F14;
			ref enum_BPERESI_FIELDS dwFields2 = ref F4089B0A2[0].dwFields;
			dwFields2 = (enum_BPERESI_FIELDS)((uint)dwFields2 | 2u);
		}
		_ = E8022A831 & 4;
		if ((E8022A831 & 8) != 0)
		{
			ref enum_BPERESI_FIELDS dwFields3 = ref F4089B0A2[0].dwFields;
			dwFields3 = (enum_BPERESI_FIELDS)((uint)dwFields3 | 8u);
			F4089B0A2[0].bstrMessage = EF475735F;
		}
		if ((E8022A831 & 0x10) != 0)
		{
			ref enum_BPERESI_FIELDS dwFields4 = ref F4089B0A2[0].dwFields;
			dwFields4 = (enum_BPERESI_FIELDS)((uint)dwFields4 | 0x10u);
			F4089B0A2[0].dwType = AE39BD5E0;
		}
		return 0;
	}
}
