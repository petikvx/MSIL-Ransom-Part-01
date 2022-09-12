using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

public class A002C58D2
{
	[Serializable]
	[CompilerGenerated]
	private sealed class AD1832C36
	{
		public static readonly AD1832C36 FA2841249 = new AD1832C36();

		public static Func<IJdwpTypeField, bool> CF50054D1;

		internal bool E605A68AF(IJdwpTypeField DAFD490BE)
		{
			return DAFD490BE.get_Name() == "value";
		}
	}

	public static Value B59263B5F(IJDbg B451A6C0D, IJdwpValue CB8DEDD14, IJdwpReferenceType C183B14DD)
	{
		IJdwpTypeField val = C183B14DD.GetFields().First((IJdwpTypeField DAFD490BE) => DAFD490BE.get_Name() == "value");
		if (val != null)
		{
			IJdwpValue[] instanceValues = B451A6C0D.GetInstanceValues(CB8DEDD14.AsClassObject(), new long[1] { val.get_ID() });
			if (instanceValues.Length == 1)
			{
				return A17FDB047(B451A6C0D, instanceValues[0]);
			}
		}
		return new C4CC2394A(B451A6C0D, CB8DEDD14, C183B14DD);
	}

	public static Value A17FDB047(IJDbg FC484AA91, IJdwpValue E771BCD48)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		if (BF602D4D0.F16904B4A(E771BCD48.get_Tag()))
		{
			return new BF602D4D0(E771BCD48);
		}
		if (F34C80160.E15EA7742(E771BCD48.get_Tag()))
		{
			return new F34C80160(FC484AA91, E771BCD48);
		}
		IJdwpReferenceType referenceType;
		if (C4CC2394A.A671369C6(E771BCD48.get_Tag()))
		{
			if (E771BCD48.AsObject() == 0L)
			{
				return new CC18CEB1F();
			}
			referenceType = FC484AA91.GetReferenceType(E771BCD48.AsObject());
			string displaySignature = referenceType.get_DisplaySignature();
			uint num = EF83A0392.B0B7CE4F9(displaySignature);
			if (num <= 1257827573)
			{
				if (num <= 932999589)
				{
					if (num != 702526120)
					{
						if (num == 932999589 && displaySignature == "java.lang.Float")
						{
							goto IL_0141;
						}
					}
					else if (displaySignature == "java.lang.Double")
					{
						goto IL_0141;
					}
				}
				else if (num != 1186593727)
				{
					if (num == 1257827573 && displaySignature == "java.lang.Short")
					{
						goto IL_0141;
					}
				}
				else if (displaySignature == "java.lang.Byte")
				{
					goto IL_0141;
				}
			}
			else if (num <= 1594990303)
			{
				if (num != 1277538149)
				{
					if (num == 1594990303 && displaySignature == "java.lang.Boolean")
					{
						goto IL_0141;
					}
				}
				else if (displaySignature == "java.lang.Integer")
				{
					goto IL_0141;
				}
			}
			else if (num != 3239311091u)
			{
				if (num == 3692021808u && displaySignature == "java.lang.Character")
				{
					goto IL_0141;
				}
			}
			else if (displaySignature == "java.lang.Long")
			{
				goto IL_0141;
			}
			return new C4CC2394A(FC484AA91, E771BCD48, referenceType);
		}
		if (C61B1F4EE.BECBAF04D(E771BCD48.get_Tag()))
		{
			return new C61B1F4EE(FC484AA91, E771BCD48);
		}
		return null;
		IL_0141:
		return B59263B5F(FC484AA91, E771BCD48, referenceType);
	}

	public static string CEEAA6689(JdwpValueTag BE1B01111)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected I4, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		if ((int)BE1B01111 <= 91)
		{
			if ((int)BE1B01111 <= 83)
			{
				switch (BE1B01111 - 66)
				{
				default:
					if ((int)BE1B01111 != 83)
					{
						break;
					}
					return "short";
				case 0:
					return "byte";
				case 1:
					return "char";
				case 10:
					return "Object";
				case 4:
					return "float";
				case 2:
					return "double";
				case 7:
					return "int";
				case 8:
					return "long";
				case 3:
				case 5:
				case 6:
				case 9:
					break;
				}
			}
			else
			{
				if ((int)BE1B01111 == 86)
				{
					return "void";
				}
				if ((int)BE1B01111 == 90)
				{
					return "boolean";
				}
				if ((int)BE1B01111 == 91)
				{
					return "[]";
				}
			}
			goto IL_00ca;
		}
		if ((int)BE1B01111 <= 103)
		{
			if ((int)BE1B01111 != 99 && (int)BE1B01111 != 103)
			{
				goto IL_00ca;
			}
		}
		else if ((int)BE1B01111 != 108)
		{
			if ((int)BE1B01111 == 115)
			{
				return "String";
			}
			if ((int)BE1B01111 != 116)
			{
				goto IL_00ca;
			}
		}
		return "";
		IL_00ca:
		return "";
	}
}
