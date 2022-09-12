using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F5E653472
{
	private delegate BC94B3E09 A3AFBF877();

	[CompilerGenerated]
	private sealed class CE11E24ED
	{
		public string D194AA3DF;

		public Predicate<IJdwpTypeField> D439A43A0;

		internal bool FA13E2DBE(IJdwpTypeField E4F0CD076)
		{
			return E4F0CD076.get_Name() == D194AA3DF;
		}
	}

	[CompilerGenerated]
	private sealed class A8B76CCCD
	{
		public string C67718B94;

		public Predicate<IJdwpTypeField> C5892433B;

		internal bool A104349F1(IJdwpTypeField A8626E1DE)
		{
			return A8626E1DE.get_Name() == C67718B94;
		}
	}

	[CompilerGenerated]
	private sealed class BC612416F
	{
		public string FB8DE2F14;
	}

	[CompilerGenerated]
	private sealed class F18BB9751
	{
		public ulong C67D78F54;

		public BC612416F DF9576A0C;

		internal bool E23AFB12B(IJdwpVariable BBA457547)
		{
			if (BBA457547.get_Name() == DF9576A0C.FB8DE2F14 && (ulong)BBA457547.get_CodeIndex() <= C67D78F54)
			{
				return C67D78F54 < (ulong)(BBA457547.get_CodeIndex() + (uint)BBA457547.get_Length());
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class C5980CBA3
	{
		public static readonly C5980CBA3 AB1FC55B9 = new C5980CBA3();

		public static Predicate<IJdwpVariable> D07F2ECCD;

		internal bool E36713727(IJdwpVariable BFE970EA2)
		{
			return BFE970EA2.get_Name() == "this";
		}
	}

	private A28774298 BA4431EC0;

	private ADB5C0658 B8C781105;

	private C032C68FF D56BD05EC;

	private DD3247535 A78A1A818;

	private Stack<C032C68FF> DD1623E54;

	private C032C68FF C225E37E8 => D56BD05EC;

	public BC94B3E09 A44AB4074(ADB5C0658 A2EC77344)
	{
		B8C781105 = A2EC77344;
		BA4431EC0 = new A28774298(A2EC77344.E5CC7F130);
		A78A1A818 = A2EC77344.D6F9ACDFD;
		DD1623E54 = new Stack<C032C68FF>();
		BC94B3E09 bC94B3E = null;
		try
		{
			E5C18A3C9();
			bC94B3E = CAE53E674();
			if (C225E37E8.F45FA6838 != DF0AD6554.End)
			{
				DBD582E1E(B0E4D9146.DFD1CEA29);
				return bC94B3E;
			}
			return bC94B3E;
		}
		catch (ED27ADBE9 eD27ADBE)
		{
			return new CA49CB647(eD27ADBE.Message);
		}
	}

	private static IJdwpClass A16EEEE28(string EC7EE4BF3, IJdwpClass D5246439E)
	{
		while (D5246439E != null)
		{
			if (EC7EE4BF3 == D5246439E.get_Name())
			{
				return D5246439E;
			}
			D5246439E = D5246439E.GetSuperclass();
		}
		return null;
	}

	private static BC94B3E09 EE79685B4(string BBC208E3E, IJdwpClass E4FD5C81A, DD3247535 BC2DD37B4, BC94B3E09 FBC46B64E)
	{
		while (E4FD5C81A != null)
		{
			IJdwpTypeField[] fields = ((IJdwpReferenceType)E4FD5C81A).GetFields();
			if (fields != null)
			{
				IJdwpTypeField val = Array.Find(fields, (IJdwpTypeField E4F0CD076) => E4F0CD076.get_Name() == BBC208E3E);
				if (val != null && (val.get_Modifiers() & 8) == 0)
				{
					return new A745D5FD9(val, FBC46B64E);
				}
			}
			E4FD5C81A = E4FD5C81A.GetSuperclass();
		}
		return new D15C16564(BBC208E3E);
	}

	private static BC94B3E09 F5AFE0D4B(string D46232302, IJdwpClass CA13574FD, DD3247535 E307134BB, BC94B3E09 F9F74A74B)
	{
		while (CA13574FD != null)
		{
			IJdwpTypeField[] fields = ((IJdwpReferenceType)CA13574FD).GetFields();
			if (fields != null)
			{
				IJdwpTypeField val = Array.Find(fields, (IJdwpTypeField A8626E1DE) => A8626E1DE.get_Name() == D46232302);
				if (val != null)
				{
					if (((uint)val.get_Modifiers() & 8u) != 0)
					{
						return new AD1BCE2D3(val, CA13574FD);
					}
					if (F9F74A74B != null)
					{
						return new A745D5FD9(val, F9F74A74B);
					}
				}
			}
			IJdwpMethod[] methods = ((IJdwpReferenceType)CA13574FD).GetMethods();
			if (methods != null)
			{
				IJdwpMethod[] array = methods;
				foreach (IJdwpMethod val2 in array)
				{
					if (val2.get_Name() == D46232302)
					{
						return new F7A3383DF(val2);
					}
				}
			}
			IJdwpReferenceType[] nestedTypes = ((IJdwpReferenceType)CA13574FD).GetNestedTypes();
			if (nestedTypes != null)
			{
				IJdwpReferenceType[] array2 = nestedTypes;
				for (int i = 0; i < array2.Length; i++)
				{
					long classObjectId = array2[i].GetClassObjectId();
					IJdwpClass @class = E307134BB.D0308D65F.GetClass(classObjectId);
					if (@class != null && @class.get_Name() == D46232302)
					{
						return new B8C70FA7A(@class);
					}
				}
			}
			CA13574FD = CA13574FD.GetSuperclass();
		}
		return null;
	}

	public static string C12F7DBBE(IJdwpClass C7E0EB087)
	{
		string text = ((IJdwpReferenceType)C7E0EB087).get_DisplaySignature();
		int num = text.IndexOf('<');
		if (num != -1)
		{
			text = text.Substring(0, num);
		}
		num = text.LastIndexOf('.');
		if (num != -1)
		{
			return text.Substring(0, num);
		}
		return string.Empty;
	}

	public static BC94B3E09 E29EB7461(string C0E6A0A12, DD3247535 A02A8CA40)
	{
		IJdwpVariable[] variables = A02A8CA40.A9709830E.GetVariables();
		if (variables != null)
		{
			ulong C67D78F54 = A02A8CA40.FDB714162.get_Index();
			IJdwpVariable val = Array.Find(variables, (IJdwpVariable BBA457547) => BBA457547.get_Name() == C0E6A0A12 && (ulong)BBA457547.get_CodeIndex() <= C67D78F54 && C67D78F54 < (ulong)(BBA457547.get_CodeIndex() + (uint)BBA457547.get_Length()));
			if (val != null)
			{
				return new F5599FF1B(val);
			}
		}
		IJdwpVariable val2 = Array.Find(variables, (IJdwpVariable BFE970EA2) => BFE970EA2.get_Name() == "this");
		BC94B3E09 bC94B3E = F5AFE0D4B(C0E6A0A12, A02A8CA40.EE8318026, A02A8CA40, (val2 != null) ? new F5599FF1B(val2) : null);
		if (bC94B3E == null)
		{
			IJdwpClass @class = A02A8CA40.D0308D65F.GetClass(C0E6A0A12);
			if (@class == null)
			{
				string text = C12F7DBBE(A02A8CA40.EE8318026);
				@class = A02A8CA40.D0308D65F.GetClass(text + "." + C0E6A0A12);
			}
			bC94B3E = ((@class == null) ? ((BC94B3E09)new D15C16564(C0E6A0A12)) : ((BC94B3E09)new B8C70FA7A(@class)));
		}
		return bC94B3E;
	}

	public static bool EE3ACD4F7(IJdwpClass BDBA5DA4A, BC94B3E09 A927B3A66, DD3247535 EFA303B5F)
	{
		IJdwpClass @class = A927B3A66.A7C3DB421(EFA303B5F).D60DB5B8A;
		if (@class != null)
		{
			string displaySignature = ((IJdwpReferenceType)@class).get_DisplaySignature();
			string displaySignature2 = ((IJdwpReferenceType)BDBA5DA4A).get_DisplaySignature();
			if (displaySignature.IndexOf(displaySignature2 + "$", StringComparison.Ordinal) != 0)
			{
				return displaySignature == displaySignature2;
			}
			return true;
		}
		return false;
	}

	public static bool C8C02FB0F(IJdwpClass C152764EC, BC94B3E09 FDBFE64F3, DD3247535 F852F446B)
	{
		for (IJdwpClass val = FDBFE64F3.A7C3DB421(F852F446B).D60DB5B8A; val != null; val = val.GetSuperclass())
		{
			if (C152764EC == val)
			{
				return true;
			}
		}
		return false;
	}

	private IJdwpClass FD73A9EBF(string CCA3CFD5A)
	{
		return A78A1A818.D0308D65F.GetClass(CCA3CFD5A);
	}

	private void E5C18A3C9()
	{
		if (DD1623E54.Count > 0)
		{
			D56BD05EC = DD1623E54.Pop();
		}
		else
		{
			D56BD05EC = BA4431EC0.DE1EC29F7();
		}
	}

	private void A35F1B04E(C032C68FF E487178C8)
	{
		DD1623E54.Push(D56BD05EC);
		D56BD05EC = E487178C8;
	}

	private void DBD582E1E(string B481F62D9)
	{
		BA4431EC0.ECCD44FDC(B481F62D9);
	}

	private BC94B3E09 FDA19DBBA()
	{
		BC94B3E09 bC94B3E = null;
		if (C225E37E8.F45FA6838 == DF0AD6554.Identifier)
		{
			bC94B3E = E29EB7461(C225E37E8.DD7E3AFEE, A78A1A818);
			E5C18A3C9();
			bC94B3E = DAD383210(bC94B3E);
		}
		if (bC94B3E is D15C16564)
		{
			DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { ((D15C16564)bC94B3E).E89BBFF51 }));
		}
		return bC94B3E;
	}

	private BC94B3E09 A8D78A244(BC94B3E09 D3F043450, string BC2019FF9)
	{
		BC94B3E09 bC94B3E = null;
		if (D3F043450 is D15C16564)
		{
			string text = ((D15C16564)D3F043450).E89BBFF51 + "." + BC2019FF9;
			IJdwpClass @class = A78A1A818.D0308D65F.GetClass(text);
			bC94B3E = ((@class == null) ? ((BC94B3E09)new D15C16564(text)) : ((BC94B3E09)new B8C70FA7A(@class)));
		}
		else if (D3F043450 is B8C70FA7A)
		{
			B8C70FA7A b8C70FA7A = (B8C70FA7A)D3F043450;
			bC94B3E = F5AFE0D4B(BC2019FF9, b8C70FA7A.F803F696F, A78A1A818, D3F043450);
		}
		else if (D3F043450 is EA93D2578)
		{
			EA93D2578 eA93D = (EA93D2578)D3F043450;
			IJdwpClass class2 = A78A1A818.D0308D65F.GetClass(eA93D.D115297FA.get_DisplaySignature());
			if (class2 != null)
			{
				bC94B3E = EE79685B4(BC2019FF9, class2, A78A1A818, D3F043450);
			}
		}
		else if (D3F043450 is F5599FF1B)
		{
			F5599FF1B f5599FF1B = (F5599FF1B)D3F043450;
			IJdwpClass class3 = A78A1A818.D0308D65F.GetClass(f5599FF1B.D3765E677.get_DisplaySignature());
			if (class3 != null)
			{
				bC94B3E = EE79685B4(BC2019FF9, class3, A78A1A818, D3F043450);
			}
		}
		else
		{
			FEC112558 fEC = D3F043450.A7C3DB421(A78A1A818);
			if (fEC.C4D58B9F7 == F18024EA9.Object)
			{
				bC94B3E = EE79685B4(BC2019FF9, fEC.D60DB5B8A, A78A1A818, D3F043450);
			}
		}
		if (bC94B3E == null)
		{
			bC94B3E = new D15C16564(BC2019FF9);
		}
		return bC94B3E;
	}

	private BC94B3E09 DAD383210(BC94B3E09 FE075F72C)
	{
		BC94B3E09 result = FE075F72C;
		if (C225E37E8.F45FA6838 == DF0AD6554.Dot)
		{
			C032C68FF peek = C225E37E8;
			E5C18A3C9();
			if (C225E37E8.F45FA6838 != DF0AD6554.Identifier)
			{
				A35F1B04E(peek);
				return result;
			}
			result = A8D78A244(FE075F72C, C225E37E8.DD7E3AFEE);
			E5C18A3C9();
			result = DAD383210(result);
		}
		return result;
	}

	private BC94B3E09 F7C19F9D3()
	{
		return FDA19DBBA();
	}

	private BC94B3E09 CAE53E674()
	{
		return DA31B2711();
	}

	private BC94B3E09 C1B854A20()
	{
		BC94B3E09 bC94B3E = null;
		switch (C225E37E8.F45FA6838)
		{
		case DF0AD6554.IntegerLiteral:
		case DF0AD6554.FloatingLiteral:
		case DF0AD6554.BooleanLiteral:
		case DF0AD6554.CharacterLiteral:
			bC94B3E = new A7A57D16F(C225E37E8.F45FA6838, C225E37E8.C398153CC);
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		case DF0AD6554.StringLiteral:
		case DF0AD6554.NullLiteral:
			bC94B3E = new A7A57D16F(C225E37E8.F45FA6838, C225E37E8.C398153CC);
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		case DF0AD6554.LeftParen:
			E5C18A3C9();
			bC94B3E = CAE53E674();
			if (bC94B3E == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			if (C225E37E8.F45FA6838 != DF0AD6554.RightParen)
			{
				DBD582E1E(B0E4D9146.A4AB5A5CF);
			}
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		case DF0AD6554.This:
			bC94B3E = E29EB7461("this", A78A1A818);
			if (bC94B3E == null)
			{
				DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "this" }));
			}
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		case DF0AD6554.Super:
		{
			BC94B3E09 bC94B3E4 = E29EB7461("this", A78A1A818);
			if (bC94B3E4 == null)
			{
				DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "super" }));
			}
			bC94B3E = new A6C4BA53B(A78A1A818.EE8318026.GetSuperclass(), bC94B3E4);
			E5C18A3C9();
			if (C225E37E8.F45FA6838 == DF0AD6554.Dot)
			{
				E5C18A3C9();
				if (C225E37E8.F45FA6838 != DF0AD6554.Identifier)
				{
					DBD582E1E(B0E4D9146.CC83C7A43);
				}
				bC94B3E = A8D78A244(bC94B3E, C225E37E8.DD7E3AFEE);
				E5C18A3C9();
				bC94B3E = B3CED7278(bC94B3E);
			}
			break;
		}
		case DF0AD6554.Identifier:
			bC94B3E = FDA19DBBA();
			if (C225E37E8.F45FA6838 == DF0AD6554.Dot)
			{
				E5C18A3C9();
				if (C225E37E8.F45FA6838 == DF0AD6554.Super)
				{
					BC94B3E09 bC94B3E2 = E29EB7461("this", A78A1A818);
					if (!(bC94B3E is B8C70FA7A) || bC94B3E2 == null)
					{
						DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "super" }));
					}
					IJdwpClass @class = ((B8C70FA7A)bC94B3E).F803F696F;
					if (!EE3ACD4F7(@class, bC94B3E2, A78A1A818))
					{
						DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "super" }));
					}
					bC94B3E = new A6C4BA53B(@class.GetSuperclass(), new BD2D940BA(@class, bC94B3E2));
					E5C18A3C9();
					if (C225E37E8.F45FA6838 != DF0AD6554.Dot)
					{
						DBD582E1E(B0E4D9146.CC83C7A43);
					}
					E5C18A3C9();
					if (C225E37E8.F45FA6838 != DF0AD6554.Identifier)
					{
						DBD582E1E(B0E4D9146.CC83C7A43);
					}
					bC94B3E = A8D78A244(bC94B3E, C225E37E8.DD7E3AFEE);
				}
				else if (C225E37E8.F45FA6838 == DF0AD6554.This)
				{
					BC94B3E09 bC94B3E3 = E29EB7461("this", A78A1A818);
					if (!(bC94B3E is B8C70FA7A) || bC94B3E3 == null)
					{
						DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "this" }));
					}
					IJdwpClass class2 = ((B8C70FA7A)bC94B3E).F803F696F;
					if (!EE3ACD4F7(class2, bC94B3E3, A78A1A818))
					{
						DBD582E1E(string.Format(CultureInfo.CurrentCulture, B0E4D9146.DC584465A, new object[1] { "this" }));
					}
					bC94B3E = new BD2D940BA(class2, bC94B3E3);
				}
				else
				{
					DBD582E1E(B0E4D9146.CC83C7A43);
				}
				E5C18A3C9();
				bC94B3E = B3CED7278(bC94B3E);
			}
			else if (C225E37E8.F45FA6838 == DF0AD6554.LeftBrace)
			{
				E5C18A3C9();
				BC94B3E09 i = CAE53E674();
				if (C225E37E8.F45FA6838 != DF0AD6554.RightBrace)
				{
					DBD582E1E(B0E4D9146.CC83C7A43);
				}
				bC94B3E = new EC93968E2(bC94B3E, i);
				E5C18A3C9();
				bC94B3E = B3CED7278(bC94B3E);
			}
			else
			{
				bC94B3E = B3CED7278(bC94B3E);
			}
			break;
		default:
			bC94B3E = null;
			break;
		}
		return bC94B3E;
	}

	private BC94B3E09 B3CED7278(BC94B3E09 F962759B2)
	{
		BC94B3E09 bC94B3E = F962759B2;
		switch (C225E37E8.F45FA6838)
		{
		case DF0AD6554.Dot:
			E5C18A3C9();
			if (C225E37E8.F45FA6838 != DF0AD6554.Identifier)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			bC94B3E = A8D78A244(F962759B2, C225E37E8.DD7E3AFEE);
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		case DF0AD6554.LeftBrace:
		{
			E5C18A3C9();
			BC94B3E09 i = CAE53E674();
			if (C225E37E8.F45FA6838 != DF0AD6554.RightBrace)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			bC94B3E = new EC93968E2(bC94B3E, i);
			E5C18A3C9();
			bC94B3E = B3CED7278(bC94B3E);
			break;
		}
		}
		return bC94B3E;
	}

	private BC94B3E09 D5AB95658()
	{
		return C1B854A20();
	}

	private BC94B3E09 F0E8E8FF0()
	{
		BC94B3E09 result = null;
		switch (C225E37E8.F45FA6838)
		{
		case DF0AD6554.Boolean:
		case DF0AD6554.Byte:
		case DF0AD6554.Short:
		case DF0AD6554.Int:
		case DF0AD6554.Long:
		case DF0AD6554.Char:
		case DF0AD6554.Float:
		case DF0AD6554.Double:
			result = new D63D3432B(C225E37E8.F45FA6838);
			E5C18A3C9();
			break;
		}
		return result;
	}

	private BC94B3E09 B7ADCE0EA()
	{
		BC94B3E09 bC94B3E = null;
		switch (C225E37E8.F45FA6838)
		{
		case DF0AD6554.Plus:
			E5C18A3C9();
			bC94B3E = B7ADCE0EA();
			if (bC94B3E == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			return new A9991B2DB(bC94B3E, new D688EC2D2());
		case DF0AD6554.Minus:
			E5C18A3C9();
			bC94B3E = B7ADCE0EA();
			if (bC94B3E == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			return new A9991B2DB(bC94B3E, new DAE3CE88E());
		case DF0AD6554.UnaryComplement:
			E5C18A3C9();
			bC94B3E = B7ADCE0EA();
			if (bC94B3E == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			return new A9991B2DB(bC94B3E, new CDE2BBE62());
		case DF0AD6554.UnaryNot:
			E5C18A3C9();
			bC94B3E = B7ADCE0EA();
			if (bC94B3E == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			return new A9991B2DB(bC94B3E, new C56A2C1A7());
		case DF0AD6554.LeftParen:
		{
			C032C68FF peek = C225E37E8;
			E5C18A3C9();
			bC94B3E = F0E8E8FF0();
			if (bC94B3E == null)
			{
				A35F1B04E(peek);
				break;
			}
			if (C225E37E8.F45FA6838 != DF0AD6554.RightParen)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			E5C18A3C9();
			BC94B3E09 bC94B3E2 = CAE53E674();
			if (bC94B3E2 == null)
			{
				DBD582E1E(B0E4D9146.CC83C7A43);
			}
			return new A9E43674E(bC94B3E2, bC94B3E);
		}
		}
		return D5AB95658();
	}

	private BC94B3E09 D3F7241D8()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = B7ADCE0EA();
		return FE08FD088(B7ADCE0EA, new DF0AD6554[3]
		{
			DF0AD6554.Times,
			DF0AD6554.Divide,
			DF0AD6554.Modulus
		}, bC94B3E);
	}

	private BC94B3E09 EC8A9D97E()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = D3F7241D8();
		return FE08FD088(D3F7241D8, new DF0AD6554[2]
		{
			DF0AD6554.Plus,
			DF0AD6554.Minus
		}, bC94B3E);
	}

	private BC94B3E09 E27214BCB()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = EC8A9D97E();
		return FE08FD088(EC8A9D97E, new DF0AD6554[3]
		{
			DF0AD6554.LeftShift,
			DF0AD6554.RightShift,
			DF0AD6554.UnsignedRightShift
		}, bC94B3E);
	}

	private BC94B3E09 A909AD23E()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = E27214BCB();
		return FE08FD088(E27214BCB, new DF0AD6554[4]
		{
			DF0AD6554.LessThan,
			DF0AD6554.GreaterThan,
			DF0AD6554.LessThanOrEqual,
			DF0AD6554.GreaterThanOrEqual
		}, bC94B3E);
	}

	private BC94B3E09 A034AFAAC()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = A909AD23E();
		return FE08FD088(A909AD23E, new DF0AD6554[2]
		{
			DF0AD6554.Equals,
			DF0AD6554.NotEqual
		}, bC94B3E);
	}

	private BC94B3E09 C77D6E3C3()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = A034AFAAC();
		return FE08FD088(A034AFAAC, new DF0AD6554[1] { DF0AD6554.BitwiseAnd }, bC94B3E);
	}

	private BC94B3E09 CAF5E547D()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = C77D6E3C3();
		return FE08FD088(C77D6E3C3, new DF0AD6554[1] { DF0AD6554.BitwiseExclusiveOr }, bC94B3E);
	}

	private BC94B3E09 F6BC0F14F()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = CAF5E547D();
		return FE08FD088(CAF5E547D, new DF0AD6554[1] { DF0AD6554.BitwiseOr }, bC94B3E);
	}

	private BC94B3E09 A26248B74()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = F6BC0F14F();
		return FE08FD088(F6BC0F14F, new DF0AD6554[1] { DF0AD6554.And }, bC94B3E);
	}

	private BC94B3E09 DA31B2711()
	{
		BC94B3E09 bC94B3E = null;
		bC94B3E = A26248B74();
		return FE08FD088(A26248B74, new DF0AD6554[1] { DF0AD6554.Or }, bC94B3E);
	}

	private BC94B3E09 FE08FD088(A3AFBF877 FB9F5EABB, DF0AD6554[] E504245B1, BC94B3E09 DCDEB4E3F)
	{
		BC94B3E09 result = DCDEB4E3F;
		foreach (DF0AD6554 dF0AD in E504245B1)
		{
			if (C225E37E8.F45FA6838 == dF0AD)
			{
				E5C18A3C9();
				result = FB9F5EABB();
				result = new F288880FB(DCDEB4E3F, result, dF0AD);
				result = FE08FD088(FB9F5EABB, E504245B1, result);
				break;
			}
		}
		return result;
	}
}
