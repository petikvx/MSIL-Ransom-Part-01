using System;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class E604AB64A : IDebugCodeContext2, IDebugMemoryContext2, IDebugCodeContext100
{
	private readonly B92FAA9B7 E8AB5DB32;

	private readonly IJdwpCodeLocation C8A45663B;

	private IDebugDocumentContext2 CBDEC15D8;

	public E604AB64A(B92FAA9B7 engine, IJdwpCodeLocation location)
	{
		E8AB5DB32 = engine;
		C8A45663B = location;
	}

	public void AFC7258C0(IDebugDocumentContext2 BA930E5FB)
	{
		CBDEC15D8 = BA930E5FB;
	}

	public int E6C55B141(ulong AA1235BDF, out IDebugMemoryContext2 FD789DE2E)
	{
		FD789DE2E = (IDebugMemoryContext2)(object)new E604AB64A(E8AB5DB32, C8A45663B.Add(AA1235BDF));
		return 0;
	}

	public int F65D9DB9A(enum_CONTEXT_COMPARE BE2E4D5B3, IDebugMemoryContext2[] E42D1C81C, uint CA163C66B, out uint F3329C9B9)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_0271: Expected O, but got Unknown
		F3329C9B9 = uint.MaxValue;
		try
		{
			for (uint num = 0u; num < CA163C66B; num++)
			{
				if (E42D1C81C[num] is E604AB64A e604AB64A && E8AB5DB32 == e604AB64A.E8AB5DB32)
				{
					bool flag;
					switch (BE2E4D5B3 - 1)
					{
					case 0:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID() && C8A45663B.get_Index() == e604AB64A.C8A45663B.get_Index();
						break;
					case 1:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID() && C8A45663B.get_Index() < e604AB64A.C8A45663B.get_Index();
						break;
					case 2:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID() && C8A45663B.get_Index() > e604AB64A.C8A45663B.get_Index();
						break;
					case 3:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID() && C8A45663B.get_Index() <= e604AB64A.C8A45663B.get_Index();
						break;
					case 4:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID() && C8A45663B.get_Index() >= e604AB64A.C8A45663B.get_Index();
						break;
					case 5:
					case 6:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID() && C8A45663B.get_MethodID() == e604AB64A.C8A45663B.get_MethodID();
						break;
					case 7:
						flag = C8A45663B.get_ClassID() == e604AB64A.C8A45663B.get_ClassID();
						break;
					case 8:
						flag = true;
						break;
					default:
						return 1;
					}
					if (flag)
					{
						F3329C9B9 = num;
						return 0;
					}
				}
			}
			return 1;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
	}

	public int AA4FCF2C5(enum_CONTEXT_INFO_FIELDS BA1C97D38, CONTEXT_INFO[] ADB30D24D)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		try
		{
			ADB30D24D[0].dwFields = (enum_CONTEXT_INFO_FIELDS)0;
			if ((BA1C97D38 & 8) != 0)
			{
				ADB30D24D[0].bstrAddress = ((object)C8A45663B).ToString();
				ref enum_CONTEXT_INFO_FIELDS dwFields = ref ADB30D24D[0].dwFields;
				dwFields = (enum_CONTEXT_INFO_FIELDS)((uint)dwFields | 8u);
			}
			if ((BA1C97D38 & 2) != 0)
			{
				IJdwpClass @class = E8AB5DB32.B3E3893F5.GetClass(C8A45663B.get_ClassID());
				if (@class != null)
				{
					IJdwpMethod method = @class.GetMethod(C8A45663B.get_MethodID());
					ADB30D24D[0].bstrFunction = method.GetDisplayName();
					ref enum_CONTEXT_INFO_FIELDS dwFields2 = ref ADB30D24D[0].dwFields;
					dwFields2 = (enum_CONTEXT_INFO_FIELDS)((uint)dwFields2 | 2u);
				}
			}
			_ = BA1C97D38 & 0x10;
			_ = BA1C97D38 & 0x20;
			_ = BA1C97D38 & 1;
			_ = BA1C97D38 & 2;
			_ = BA1C97D38 & 4;
			return 0;
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
	}

	public int CDC2E9A7E(out string BBC9132F5)
	{
		throw new NotImplementedException();
	}

	public int B4EB0B585(ulong B246D3053, out IDebugMemoryContext2 EA9BDB215)
	{
		EA9BDB215 = (IDebugMemoryContext2)(object)new E604AB64A(E8AB5DB32, C8A45663B.Subtract(B246D3053));
		return 0;
	}

	public int A63FE2300(out IDebugDocumentContext2 E37B067FB)
	{
		E37B067FB = CBDEC15D8;
		return 0;
	}

	public int A941DA318(ref string BA64F9E7E, ref Guid BDF5060C0)
	{
		if (CBDEC15D8 != null)
		{
			CBDEC15D8.GetLanguageInfo(ref BA64F9E7E, ref BDF5060C0);
			return 0;
		}
		return 1;
	}

	private int ABCBE8782(out IDebugProgram2 DBC6059F1)
	{
		DBC6059F1 = (IDebugProgram2)(object)E8AB5DB32;
		return 0;
	}
}
