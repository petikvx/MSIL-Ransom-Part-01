using System.Runtime.InteropServices;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class AC89F237D : IDebugBreakpointResolution2
{
	private B92FAA9B7 CB9C6135B;

	private IJdwpCodeLocation EE340D48D;

	private F21674B78 F1DB385F0;

	public F21674B78 E281836D5 => F1DB385F0;

	public AC89F237D(B92FAA9B7 engine, IJdwpCodeLocation location, F21674B78 documentContext)
	{
		CB9C6135B = engine;
		EE340D48D = location;
		F1DB385F0 = documentContext;
	}

	private int FBC12A0DE(enum_BP_TYPE[] E8DD61A98)
	{
		E8DD61A98[0] = (enum_BP_TYPE)1;
		return 0;
	}

	private int BBFBFE961(enum_BPRESI_FIELDS CC33FE341, BP_RESOLUTION_INFO[] D1723EF3F)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if ((CC33FE341 & 1) != 0)
		{
			BP_RESOLUTION_LOCATION bpResLocation = default(BP_RESOLUTION_LOCATION);
			bpResLocation.bpType = 1u;
			E604AB64A e604AB64A = new E604AB64A(CB9C6135B, EE340D48D);
			e604AB64A.AFC7258C0((IDebugDocumentContext2)(object)F1DB385F0);
			bpResLocation.unionmember1 = Marshal.GetComInterfaceForObject(e604AB64A, typeof(IDebugCodeContext2));
			D1723EF3F[0].bpResLocation = bpResLocation;
			ref enum_BPRESI_FIELDS dwFields = ref D1723EF3F[0].dwFields;
			dwFields = (enum_BPRESI_FIELDS)((uint)dwFields | 1u);
		}
		if ((CC33FE341 & 2) != 0)
		{
			D1723EF3F[0].pProgram = (IDebugProgram2)(object)CB9C6135B;
			ref enum_BPRESI_FIELDS dwFields2 = ref D1723EF3F[0].dwFields;
			dwFields2 = (enum_BPRESI_FIELDS)((uint)dwFields2 | 2u);
		}
		return 0;
	}
}
