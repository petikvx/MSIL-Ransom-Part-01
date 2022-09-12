using System;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class BE52A5725 : IDebugBoundBreakpoint2
{
	private C1C0BFBF8 FFF5EEFEF;

	private AC89F237D BFAEB4B1E;

	private B92FAA9B7 AF8CB47D2;

	private IJdwpCodeLocation E7661992B;

	private BP_PASSCOUNT D84767B12;

	private BP_CONDITION F0C84D6F4;

	private string A29BB34A8;

	private ADB5C0658 D04BE1715;

	private uint EF0947E4D;

	private bool DEC432540;

	private bool CFC7B61C3;

	public BE52A5725(B92FAA9B7 engine, IJdwpCodeLocation location, C1C0BFBF8 pendingBreakpoint, AC89F237D breakpointResolution)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		AF8CB47D2 = engine;
		E7661992B = location;
		FFF5EEFEF = pendingBreakpoint;
		BFAEB4B1E = breakpointResolution;
		F0C84D6F4.styleCondition = (enum_BP_COND_STYLE)0;
		A29BB34A8 = null;
		EF0947E4D = 0u;
		DEC432540 = true;
		((IDebugBoundBreakpoint2)this).Enable(pendingBreakpoint.EEAC0C0DD ? 1 : 0);
		CFC7B61C3 = false;
	}

	private int B5704DD44()
	{
		if (!CFC7B61C3)
		{
			try
			{
				AF8CB47D2.B3E3893F5.RemoveBreakpoint(E7661992B, (object)this);
			}
			catch
			{
				return -2147467259;
			}
			CFC7B61C3 = true;
		}
		return 0;
	}

	private int B301ACA24(int D07391322)
	{
		bool flag = ((D07391322 != 0) ? true : false);
		if (DEC432540 != flag)
		{
			try
			{
				if (flag)
				{
					AF8CB47D2.B3E3893F5.SetBreakpoint(E7661992B, (object)this);
				}
				else
				{
					AF8CB47D2.B3E3893F5.RemoveBreakpoint(E7661992B, (object)this);
				}
			}
			catch
			{
				return -2147467259;
			}
		}
		DEC432540 = flag;
		return 0;
	}

	private int AB9E1F36A(out IDebugBreakpointResolution2 EB78A5C0F)
	{
		EB78A5C0F = (IDebugBreakpointResolution2)(object)BFAEB4B1E;
		return 0;
	}

	private int D24E32540(out IDebugPendingBreakpoint2 EC296BF02)
	{
		EC296BF02 = (IDebugPendingBreakpoint2)(object)FFF5EEFEF;
		return 0;
	}

	private int EE9F5E377(enum_BP_STATE[] CB683E404)
	{
		CB683E404[0] = (enum_BP_STATE)0;
		if (CFC7B61C3)
		{
			CB683E404[0] = (enum_BP_STATE)1;
		}
		else if (DEC432540)
		{
			CB683E404[0] = (enum_BP_STATE)3;
		}
		else if (!DEC432540)
		{
			CB683E404[0] = (enum_BP_STATE)2;
		}
		return 0;
	}

	private int F669FFF90(out uint A3EC9DEFC)
	{
		if (CFC7B61C3)
		{
			A3EC9DEFC = 0u;
			return -2147221408;
		}
		A3EC9DEFC = EF0947E4D;
		return 0;
	}

	private int FCECB446C(BP_CONDITION C9A8DFAA8)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		F0C84D6F4 = C9A8DFAA8;
		A29BB34A8 = null;
		if ((int)F0C84D6F4.styleCondition != 0)
		{
			D04BE1715 = new ADB5C0658(F0C84D6F4.bstrCondition, new DD3247535(AF8CB47D2.B3E3893F5, E7661992B));
			D04BE1715.AF927A510();
			if (D04BE1715.A0A6085FD)
			{
				FFF5EEFEF.AB1E81DA4(D04BE1715.FC3E9C6DA.DisplayValue, E7661992B, BFAEB4B1E.E281836D5, (enum_BP_ERROR_TYPE)2);
			}
		}
		return 0;
	}

	private int BEB90470D(uint A765A7411)
	{
		if (CFC7B61C3)
		{
			return -2147221408;
		}
		EF0947E4D = A765A7411;
		return 0;
	}

	private int FBEEC0DFF(BP_PASSCOUNT FB6BB27F7)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (CFC7B61C3)
		{
			return -2147221408;
		}
		D84767B12 = FB6BB27F7;
		return 0;
	}

	public bool CEC3DFA24(IJdwpThread D1710331A)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		enum_BP_PASSCOUNT_STYLE stylePassCount = D84767B12.stylePassCount;
		bool flag = (stylePassCount - 1) switch
		{
			0 => EF0947E4D == D84767B12.dwPassCount, 
			1 => EF0947E4D >= D84767B12.dwPassCount, 
			2 => EF0947E4D % D84767B12.dwPassCount == 0, 
			_ => true, 
		};
		if (flag && (int)F0C84D6F4.styleCondition != 0 && !D04BE1715.A0A6085FD)
		{
			D04BE1715.D6F9ACDFD = new DD3247535(AF8CB47D2.B3E3893F5, D1710331A, AF8CB47D2.B3E3893F5.GetTopStackFrame(D1710331A));
			D04BE1715.B6FE9B085();
			if (!D04BE1715.A0A6085FD)
			{
				if ((int)F0C84D6F4.styleCondition == 1)
				{
					flag = string.Compare(D04BE1715.FC3E9C6DA.DisplayValue, "true", StringComparison.OrdinalIgnoreCase) == 0;
				}
				else if (A29BB34A8 == null)
				{
					A29BB34A8 = D04BE1715.FC3E9C6DA.DisplayValue;
					flag = false;
				}
				else
				{
					flag = string.Compare(D04BE1715.FC3E9C6DA.DisplayValue, A29BB34A8, StringComparison.Ordinal) == 0;
				}
			}
		}
		return flag;
	}

	public IJdwpCodeLocation FF69D4640()
	{
		return E7661992B;
	}
}
