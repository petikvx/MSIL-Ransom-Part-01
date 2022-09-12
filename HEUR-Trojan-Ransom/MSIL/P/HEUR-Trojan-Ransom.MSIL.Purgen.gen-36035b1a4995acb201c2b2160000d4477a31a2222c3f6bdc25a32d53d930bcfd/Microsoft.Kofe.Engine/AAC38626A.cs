using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using C70E4DCD4;
using Microsoft.Kofe.IJDWP;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class AAC38626A : IDebugStackFrame2, IDebugExpressionContext2
{
	private readonly B92FAA9B7 C1E2C19B9;

	private readonly FE8030C1E D5FF5760A;

	private readonly IJdwpStackFrame F3C7ADD20;

	private IJdwpClass A9EAA4697;

	private IJdwpMethod DA1630840;

	private string E339C2D65;

	private int CD537BC28;

	private List<IJdwpVariable> EEAD4C256;

	private List<IJdwpVariable> A7693AB38;

	private DD3247535 C906FD859;

	private bool A7E6A7245;

	private string EE450A371;

	public AAC38626A(B92FAA9B7 engine, FE8030C1E thread, IJdwpStackFrame stackFrame)
	{
		C1E2C19B9 = engine;
		D5FF5760A = thread;
		F3C7ADD20 = stackFrame;
		A9EAA4697 = C1E2C19B9.B3E3893F5.GetClass(F3C7ADD20.get_Location().get_ClassID());
		E339C2D65 = C1E2C19B9.BEB396177.AEB742416(A9EAA4697);
		DA1630840 = A9EAA4697.GetMethod(F3C7ADD20.get_Location().get_MethodID());
		CD537BC28 = DA1630840.LineNumber(F3C7ADD20.get_Location().get_Index()) - 1;
		EEAD4C256 = new List<IJdwpVariable>();
		A7693AB38 = new List<IJdwpVariable>();
		C906FD859 = new DD3247535(C1E2C19B9.B3E3893F5, D5FF5760A.BAB7FF789(), F3C7ADD20);
		Array.ForEach(DA1630840.GetVariables(), delegate(IJdwpVariable ED39FD08C)
		{
			if (ED39FD08C.get_CodeIndex() == 0L && F3C7ADD20.get_Location().get_Index() < (ulong)ED39FD08C.get_Length())
			{
				EEAD4C256.Add(ED39FD08C);
			}
			else if ((ulong)ED39FD08C.get_CodeIndex() <= F3C7ADD20.get_Location().get_Index() && F3C7ADD20.get_Location().get_Index() < (ulong)(ED39FD08C.get_CodeIndex() + ED39FD08C.get_Length()))
			{
				A7693AB38.Add(ED39FD08C);
			}
		});
	}

	public AAC38626A(string annotation)
	{
		A7E6A7245 = true;
		EE450A371 = annotation;
	}

	public void B9DAA8335(enum_FRAMEINFO_FLAGS FB92F8D23, out FRAMEINFO F95A3E908)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		F95A3E908 = default(FRAMEINFO);
		if (A7E6A7245)
		{
			F95A3E908.m_bstrFuncName = EE450A371;
			ref enum_FRAMEINFO_FLAGS dwValidFields = ref F95A3E908.m_dwValidFields;
			dwValidFields = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields | 1u);
			F95A3E908.m_dwFlags = 1u;
			ref enum_FRAMEINFO_FLAGS dwValidFields2 = ref F95A3E908.m_dwValidFields;
			dwValidFields2 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields2 | 0x200u);
			return;
		}
		if ((FB92F8D23 & 1) != 0)
		{
			F95A3E908.m_bstrFuncName = "";
			if ((FB92F8D23 & 0x10000) != 0 && A9EAA4697 != null)
			{
				F95A3E908.m_bstrFuncName = A9EAA4697.get_Name() + ".";
			}
			F95A3E908.m_bstrFuncName += DA1630840.get_Name();
			if ((FB92F8D23 & 0x4000) != 0 && EEAD4C256.Count > 0)
			{
				F95A3E908.m_bstrFuncName += "(";
				int num = 0;
				BF602D4D0.E0EE62C88 = C1E2C19B9.C826EF455();
				foreach (IJdwpVariable item in EEAD4C256)
				{
					if (item.get_CodeIndex() != 0L || !(item.get_Name() != "this"))
					{
						continue;
					}
					if (num != 0)
					{
						F95A3E908.m_bstrFuncName += ", ";
					}
					if ((FB92F8D23 & 0x100000) != 0)
					{
						ref string bstrFuncName = ref F95A3E908.m_bstrFuncName;
						bstrFuncName = bstrFuncName + item.get_DisplaySignature() + " ";
					}
					if ((FB92F8D23 & 0x200000) != 0)
					{
						F95A3E908.m_bstrFuncName += item.get_Name();
					}
					if ((FB92F8D23 & 0x400000) != 0)
					{
						D85FA4443 d85FA = new D85FA4443(item, C906FD859);
						d85FA.D47B03E76(C1E2C19B9.B3E3893F5);
						if (!string.IsNullOrWhiteSpace(d85FA.FC3E9C6DA.DisplayValue))
						{
							ref string bstrFuncName2 = ref F95A3E908.m_bstrFuncName;
							bstrFuncName2 = bstrFuncName2 + "=" + d85FA.FC3E9C6DA.DisplayValue;
						}
					}
					num++;
				}
				F95A3E908.m_bstrFuncName += ")";
			}
			if ((FB92F8D23 & 0x20000) != 0 && CD537BC28 > -2)
			{
				ref string bstrFuncName3 = ref F95A3E908.m_bstrFuncName;
				bstrFuncName3 = bstrFuncName3 + " Line " + (CD537BC28 + 1).ToString(CultureInfo.InvariantCulture);
			}
			ref enum_FRAMEINFO_FLAGS dwValidFields3 = ref F95A3E908.m_dwValidFields;
			dwValidFields3 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields3 | 1u);
		}
		if ((FB92F8D23 & 0x10) != 0 && A9EAA4697 != null)
		{
			F95A3E908.m_bstrModule = A9EAA4697.get_Name();
			ref enum_FRAMEINFO_FLAGS dwValidFields4 = ref F95A3E908.m_dwValidFields;
			dwValidFields4 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields4 | 0x10u);
		}
		if ((FB92F8D23 & 0x20) != 0)
		{
			F95A3E908.m_addrMin = (ulong)DA1630840.get_StartIndex();
			F95A3E908.m_addrMax = (ulong)DA1630840.get_EndIndex();
			ref enum_FRAMEINFO_FLAGS dwValidFields5 = ref F95A3E908.m_dwValidFields;
			dwValidFields5 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields5 | 0x20u);
		}
		if ((FB92F8D23 & 0x40) != 0)
		{
			F95A3E908.m_pFrame = (IDebugStackFrame2)(object)this;
			ref enum_FRAMEINFO_FLAGS dwValidFields6 = ref F95A3E908.m_dwValidFields;
			dwValidFields6 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields6 | 0x40u);
		}
		if ((FB92F8D23 & 8) != 0)
		{
			F95A3E908.m_bstrLanguage = B0E4D9146.F720FB010;
			ref enum_FRAMEINFO_FLAGS dwValidFields7 = ref F95A3E908.m_dwValidFields;
			dwValidFields7 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields7 | 8u);
		}
		if ((FB92F8D23 & 0x80) != 0)
		{
			F95A3E908.m_fHasDebugInfo = ((A9EAA4697 != null && ((IJdwpReferenceType)A9EAA4697).get_SymbolsLoaded()) ? 1 : 0);
			ref enum_FRAMEINFO_FLAGS dwValidFields8 = ref F95A3E908.m_dwValidFields;
			dwValidFields8 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields8 | 0x80u);
		}
		if ((FB92F8D23 & 0x100) != 0)
		{
			F95A3E908.m_fStaleCode = 0;
			ref enum_FRAMEINFO_FLAGS dwValidFields9 = ref F95A3E908.m_dwValidFields;
			dwValidFields9 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields9 | 0x100u);
		}
		if ((FB92F8D23 & 0x400) != 0 && A9EAA4697 != null)
		{
			if (A9EAA4697.get_Client() == null)
			{
				A9EAA4697.set_Client((object)new E941D6CC6(A9EAA4697));
			}
			E941D6CC6 e941D6CC = (E941D6CC6)(object)(F95A3E908.m_pModule = (IDebugModule2)(object)(E941D6CC6)A9EAA4697.get_Client());
			ref enum_FRAMEINFO_FLAGS dwValidFields10 = ref F95A3E908.m_dwValidFields;
			dwValidFields10 = (enum_FRAMEINFO_FLAGS)((uint)dwValidFields10 | 0x400u);
		}
	}

	private CE6CCD2B7 DD2E2FFA9(enum_DEBUGPROP_INFO_FLAGS A17081D57, IJdwpVariable[] CB96E2D48)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		DEBUG_PROPERTY_INFO[] array = (DEBUG_PROPERTY_INFO[])(object)new DEBUG_PROPERTY_INFO[CB96E2D48.Length];
		if (CB96E2D48.Length != 0)
		{
			BF602D4D0.E0EE62C88 = C1E2C19B9.C826EF455();
			new DD3247535(C1E2C19B9.B3E3893F5, D5FF5760A.BAB7FF789(), F3C7ADD20);
			D85FA4443[] array2 = Array.ConvertAll(CB96E2D48, (IJdwpVariable B3FBC3A57) => new D85FA4443(B3FBC3A57, C906FD859));
			D85FA4443.EA2938E0A(C1E2C19B9.B3E3893F5, array2);
			int num = 0;
			D85FA4443[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				C3BBB6305 c3BBB = new C3BBB6305(array3[i]);
				array[num++] = c3BBB.C8A04EC89(A17081D57);
			}
		}
		return new CE6CCD2B7(array);
	}

	private void F5C52031E(enum_DEBUGPROP_INFO_FLAGS FE4943494, out uint E3737A014, out IEnumDebugPropertyInfo2 F0B2FD15B)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		E3737A014 = (uint)(A7693AB38.Count + EEAD4C256.Count);
		F0B2FD15B = (IEnumDebugPropertyInfo2)(object)DD2E2FFA9(FE4943494, EEAD4C256.Concat(A7693AB38).ToArray());
	}

	private void F90E18643(enum_DEBUGPROP_INFO_FLAGS BA6DF9688, out uint EB8F5F806, out IEnumDebugPropertyInfo2 BDFE74D58)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		EB8F5F806 = (uint)A7693AB38.Count;
		BDFE74D58 = (IEnumDebugPropertyInfo2)(object)DD2E2FFA9(BA6DF9688, A7693AB38.ToArray());
	}

	private void AA0C251C3(enum_DEBUGPROP_INFO_FLAGS DED5578B0, out uint DDC59E71A, out IEnumDebugPropertyInfo2 E8C8D8320)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DDC59E71A = (uint)EEAD4C256.Count;
		E8C8D8320 = (IEnumDebugPropertyInfo2)(object)DD2E2FFA9(DED5578B0, EEAD4C256.ToArray());
	}

	private int E93E2F0B6(enum_DEBUGPROP_INFO_FLAGS D80F99751, uint ECBF16566, ref Guid A34BCB4B0, uint A82371DA5, out uint A0A43FA50, out IEnumDebugPropertyInfo2 E31766BCF)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		A0A43FA50 = 0u;
		E31766BCF = null;
		try
		{
			if (A34BCB4B0 == EC594D2A3.ADBD5B3E1 || A34BCB4B0 == EC594D2A3.ABA2B0EF4 || A34BCB4B0 == EC594D2A3.E6A1E6BBC)
			{
				F5C52031E(D80F99751, out A0A43FA50, out E31766BCF);
				return 0;
			}
			if (A34BCB4B0 == EC594D2A3.C34EE4F4A)
			{
				F90E18643(D80F99751, out A0A43FA50, out E31766BCF);
				return 0;
			}
			if (A34BCB4B0 == EC594D2A3.A2267B562)
			{
				AA0C251C3(D80F99751, out A0A43FA50, out E31766BCF);
				return 0;
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

	private int FE4EEEB83(out IDebugCodeContext2 BFDEBEF5D)
	{
		//IL_0024: Expected O, but got Unknown
		BFDEBEF5D = null;
		try
		{
			BFDEBEF5D = (IDebugCodeContext2)(object)new E604AB64A(C1E2C19B9, F3C7ADD20.get_Location());
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

	private int B3C76DB57(out IDebugProperty2 D7F0EB90D)
	{
		throw new NotImplementedException();
	}

	private int BDB62AABF(out IDebugDocumentContext2 D4FC9A2F9)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		D4FC9A2F9 = null;
		try
		{
			if (A9EAA4697 != null && !string.IsNullOrWhiteSpace(E339C2D65))
			{
				TEXT_POSITION begPos = default(TEXT_POSITION);
				begPos.dwColumn = 0u;
				begPos.dwLine = (uint)CD537BC28;
				TEXT_POSITION endPos = default(TEXT_POSITION);
				endPos.dwColumn = 0u;
				endPos.dwLine = (uint)CD537BC28;
				D4FC9A2F9 = (IDebugDocumentContext2)(object)new F21674B78(E339C2D65, begPos, endPos, new E604AB64A(C1E2C19B9, F3C7ADD20.get_Location()));
				return 0;
			}
		}
		catch (ComponentException val)
		{
			return ((Exception)val).HResult;
		}
		catch (Exception a97A2962F)
		{
			return A09717160.ABD5D2EFF(a97A2962F);
		}
		return 1;
	}

	private int A75EFC43E(out IDebugExpressionContext2 F7C40691A)
	{
		F7C40691A = (IDebugExpressionContext2)(object)this;
		return 0;
	}

	private int FC398A33C(enum_FRAMEINFO_FLAGS CDCED79FC, uint CDE7F7038, FRAMEINFO[] CF4E78E29)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			B9DAA8335(CDCED79FC, out CF4E78E29[0]);
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

	private int AE88508CD(ref string EEB023DBC, ref Guid D992BFC10)
	{
		EEB023DBC = "Java";
		D992BFC10 = EC594D2A3.E0822BBCF;
		return 0;
	}

	private int A4E62F9CB(out string A841D4D0E)
	{
		//IL_0058: Expected O, but got Unknown
		A841D4D0E = null;
		try
		{
			A841D4D0E = A9EAA4697.get_Name() + "!" + DA1630840.get_Name() + "!" + ((object)F3C7ADD20.get_Location()).ToString();
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

	private int DD401BAF3(out ulong C6EF1D6FB, out ulong EF2431E42)
	{
		C6EF1D6FB = (ulong)DA1630840.get_StartIndex();
		EF2431E42 = (ulong)DA1630840.get_EndIndex();
		return 0;
	}

	private int EE52F5D5E(out IDebugThread2 D869BA4DD)
	{
		D869BA4DD = (IDebugThread2)(object)D5FF5760A;
		return 0;
	}

	private int F0CF681F1(out string F650E8084)
	{
		throw new NotImplementedException();
	}

	private int CBCC10611(string AE4F269C6, enum_PARSEFLAGS CBD7E8435, uint E26379F2F, out IDebugExpression2 E6443DAE8, out string B0625B50D, out uint D516A245B)
	{
		B0625B50D = null;
		D516A245B = 0u;
		DD3247535 cxt = new DD3247535(C1E2C19B9.B3E3893F5, D5FF5760A.BAB7FF789(), F3C7ADD20);
		ADB5C0658 aDB5C = new ADB5C0658(AE4F269C6, cxt);
		aDB5C.AF927A510();
		if (aDB5C.A0A6085FD)
		{
			E6443DAE8 = null;
			D516A245B = (uint)(B0625B50D = aDB5C.FC3E9C6DA.DisplayValue).Length;
			return 1;
		}
		E6443DAE8 = (IDebugExpression2)(object)new E0CF23B5F(aDB5C, C1E2C19B9);
		return 0;
	}

	[CompilerGenerated]
	private void B7A2D354D(IJdwpVariable ED39FD08C)
	{
		if (ED39FD08C.get_CodeIndex() == 0L && F3C7ADD20.get_Location().get_Index() < (ulong)ED39FD08C.get_Length())
		{
			EEAD4C256.Add(ED39FD08C);
		}
		else if ((ulong)ED39FD08C.get_CodeIndex() <= F3C7ADD20.get_Location().get_Index() && F3C7ADD20.get_Location().get_Index() < (ulong)(ED39FD08C.get_CodeIndex() + ED39FD08C.get_Length()))
		{
			A7693AB38.Add(ED39FD08C);
		}
	}

	[CompilerGenerated]
	private D85FA4443 E2F0C73AF(IJdwpVariable B3FBC3A57)
	{
		return new D85FA4443(B3FBC3A57, C906FD859);
	}
}
