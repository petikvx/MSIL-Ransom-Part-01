using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class FE8030C1E : IDebugThread2, IDebugThread100
{
	private enum BD97424C0
	{
		Worker,
		UI,
		Main,
		RPC,
		Unknown
	}

	private readonly B92FAA9B7 C788475F8;

	private readonly IJdwpThread CB44DA434;

	private DC37350B4 AF11F68BB;

	internal B92FAA9B7 C11BEDF60 => C788475F8;

	public FE8030C1E(B92FAA9B7 engine, IJdwpThread thread)
	{
		C788475F8 = engine;
		CB44DA434 = thread;
		AF11F68BB = new DC37350B4(this);
		F76F8A933();
	}

	internal IJdwpThread BAB7FF789()
	{
		return CB44DA434;
	}

	internal void F76F8A933()
	{
		AF11F68BB.B9696FDB7();
	}

	internal void D869BD2AD(StepDepth DDA2D97BE, StepSize E91040BE1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		AF11F68BB.B9696FDB7();
		AF11F68BB.BF93FFDBD(DDA2D97BE, E91040BE1);
		C11BEDF60.B3E3893F5.Step(BAB7FF789(), E91040BE1, DDA2D97BE);
	}

	internal void A15ACDA04()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (!AF11F68BB.C521F9647(out var BCB57B))
		{
			C788475F8.B3E3893F5.Step(CB44DA434, (StepSize)1, BCB57B);
			return;
		}
		DDF412AD2 f07AE03F = new DDF412AD2();
		AF11F68BB.B9696FDB7();
		C788475F8.F4F01CC92.D14E82737((IDebugEvent2)(object)f07AE03F, "0f7f24c1-74d9-4ea6-a3ea-7edb2d81441d", (IDebugThread2)(object)this);
	}

	private int BE6DCFC82(IDebugStackFrame2 B514F573D, IDebugCodeContext2 A2314BD58)
	{
		return 1;
	}

	private int EE045998D(enum_FRAMEINFO_FLAGS DB3568E6D, uint FBA0ECE74, out IEnumDebugFrameInfo2 C8F5F6161)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		C8F5F6161 = null;
		try
		{
			IJdwpStackFrame[] array = (IJdwpStackFrame[])(object)new IJdwpStackFrame[0];
			try
			{
				array = C788475F8.B3E3893F5.GetStackFrames(CB44DA434);
			}
			catch (Exception ex)
			{
				C788475F8.F4F01CC92.AEEFE1C6A(string.Format(CultureInfo.CurrentCulture, B0E4D9146.F9F8D4179, new object[1] { ex.Message }));
				return -2147467259;
			}
			int num = array.Length;
			bool flag = false;
			if (array.Length > C788475F8.C58936D0E)
			{
				flag = true;
				num = C788475F8.C58936D0E;
			}
			FRAMEINFO[] array2 = (FRAMEINFO[])(object)new FRAMEINFO[num];
			for (int i = 0; i < num; i++)
			{
				new AAC38626A(C788475F8, this, array[i]).B9DAA8335(DB3568E6D, out array2[i]);
			}
			if (flag)
			{
				new AAC38626A(B0E4D9146.FF0762A3A).B9DAA8335(DB3568E6D, out var F95A3E);
				array2 = new List<FRAMEINFO>(array2).Concat((IEnumerable<FRAMEINFO>)(object)new FRAMEINFO[1] { F95A3E }).ToArray();
			}
			C8F5F6161 = (IEnumDebugFrameInfo2)(object)new D3A863627(array2);
			return 0;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception ex2)
		{
			C788475F8.F4F01CC92.AEEFE1C6A(string.Format(CultureInfo.CurrentCulture, B0E4D9146.F9F8D4179, new object[1] { ex2.Message }));
			return -2147467259;
		}
	}

	private int A542EE8F6(out string EBB20C416)
	{
		EBB20C416 = CB44DA434.get_Name();
		return 0;
	}

	private int B4851F662(out IDebugProgram2 B7D06FEEB)
	{
		B7D06FEEB = (IDebugProgram2)(object)C788475F8;
		return 0;
	}

	private int D675BA79F(out uint E97425022)
	{
		E97425022 = (uint)CB44DA434.get_Id();
		return 0;
	}

	private int BDA95A2DF(enum_THREADPROPERTY_FIELDS C17370E5F, THREADPROPERTIES[] CBA6CB741)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		try
		{
			THREADPROPERTIES val = default(THREADPROPERTIES);
			if ((C17370E5F & 1) != 0)
			{
				val.dwThreadId = (uint)CB44DA434.get_Id();
				ref enum_THREADPROPERTY_FIELDS dwFields = ref val.dwFields;
				dwFields = (enum_THREADPROPERTY_FIELDS)((uint)dwFields | 1u);
			}
			if ((C17370E5F & 2) != 0)
			{
				ref enum_THREADPROPERTY_FIELDS dwFields2 = ref val.dwFields;
				dwFields2 = (enum_THREADPROPERTY_FIELDS)((uint)dwFields2 | 2u);
			}
			if ((C17370E5F & 4) != 0)
			{
				val.dwThreadState = 1u;
				ref enum_THREADPROPERTY_FIELDS dwFields3 = ref val.dwFields;
				dwFields3 = (enum_THREADPROPERTY_FIELDS)((uint)dwFields3 | 4u);
			}
			if ((C17370E5F & 8) != 0)
			{
				val.bstrPriority = "Normal";
				ref enum_THREADPROPERTY_FIELDS dwFields4 = ref val.dwFields;
				dwFields4 = (enum_THREADPROPERTY_FIELDS)((uint)dwFields4 | 8u);
			}
			if ((C17370E5F & 0x10) != 0)
			{
				val.bstrName = CB44DA434.get_Name();
				ref enum_THREADPROPERTY_FIELDS dwFields5 = ref val.dwFields;
				dwFields5 = (enum_THREADPROPERTY_FIELDS)((uint)dwFields5 | 0x10u);
			}
			if ((C17370E5F & 0x20) != 0)
			{
				val.bstrLocation = "";
				ref enum_THREADPROPERTY_FIELDS dwFields6 = ref val.dwFields;
				dwFields6 = (enum_THREADPROPERTY_FIELDS)((uint)dwFields6 | 0x20u);
			}
			CBA6CB741[0] = val;
			return 0;
		}
		catch (ComponentException val2)
		{
			return ((Exception)val2).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
	}

	private int F86CB33EC(out uint C7E4EA542)
	{
		C7E4EA542 = 0u;
		return 1;
	}

	private int DC9278C8A(IDebugStackFrame2 D4DD4C11D, IDebugCodeContext2 B2182295C)
	{
		return 1;
	}

	private int C7FE074AD(out uint CD8E4E834)
	{
		CD8E4E834 = 0u;
		return 1;
	}

	private int FF39C86AC(string A74BC6429)
	{
		return 1;
	}

	private int EE0FE3EF9(out string BF96EB474)
	{
		BF96EB474 = string.Empty;
		return 1;
	}

	private int D77E3501C()
	{
		return 1;
	}

	private int F49B59675(uint F424E64AE)
	{
		return 1;
	}

	private int BB2D0E3C2(out uint E7A081B51)
	{
		E7A081B51 = 0u;
		return 1;
	}

	private int AE358B8EE(uint DD0533762, THREADPROPERTIES100[] D001929DA)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I4, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between I4 and Unknown
		THREADPROPERTIES[] array = (THREADPROPERTIES[])(object)new THREADPROPERTIES[1];
		enum_THREADPROPERTY_FIELDS val = (enum_THREADPROPERTY_FIELDS)(DD0533762 & 0x3F);
		int threadProperties = ((IDebugThread2)this).GetThreadProperties(val, array);
		D001929DA[0].bstrLocation = array[0].bstrLocation;
		D001929DA[0].bstrName = array[0].bstrName;
		D001929DA[0].bstrDisplayName = string.Empty;
		D001929DA[0].bstrPriority = array[0].bstrPriority;
		D001929DA[0].dwFields = (uint)(int)array[0].dwFields;
		D001929DA[0].dwSuspendCount = array[0].dwSuspendCount;
		D001929DA[0].dwThreadId = array[0].dwThreadId;
		D001929DA[0].dwThreadState = array[0].dwThreadState;
		if (threadProperties == 0 && DD0533762 != (uint)(int)val)
		{
			if ((DD0533762 & 0x40u) != 0)
			{
				D001929DA[0].bstrDisplayName = CB44DA434.get_Name();
				D001929DA[0].dwFields |= 64u;
				D001929DA[0].DisplayNamePriority = 10u;
				D001929DA[0].dwFields |= 128u;
			}
			if ((DD0533762 & 0x100u) != 0)
			{
				D001929DA[0].dwThreadCategory = (CB44DA434.get_IsMainThread() ? 2u : 0u);
				D001929DA[0].dwFields |= 256u;
			}
			if ((DD0533762 & 0x200u) != 0)
			{
				D001929DA[0].AffinityMask = 0uL;
				D001929DA[0].dwFields |= 512u;
			}
			if ((DD0533762 & 0x400u) != 0)
			{
				D001929DA[0].priorityId = 0;
				D001929DA[0].dwFields |= 1024u;
			}
		}
		return threadProperties;
	}

	private int E3EC552CF(IDebugStackFrame2 C4A112602, out IDebugLogicalThread2 C41FB42D7)
	{
		C41FB42D7 = null;
		return 1;
	}

	private int FF28A816B(string BE43F3A8A)
	{
		return 1;
	}
}
