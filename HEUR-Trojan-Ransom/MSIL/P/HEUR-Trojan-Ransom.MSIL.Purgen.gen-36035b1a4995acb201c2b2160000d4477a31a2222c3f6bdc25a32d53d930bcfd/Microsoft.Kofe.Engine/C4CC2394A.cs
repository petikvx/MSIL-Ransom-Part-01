using System;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class C4CC2394A : FD2C728AB, ParentValue
{
	[CompilerGenerated]
	private sealed class B4013E55C
	{
		public string E94347787;

		internal bool BAD113DA4(IJdwpTypeField BF4494486)
		{
			if (((uint)BF4494486.get_Modifiers() & 0x1000u) != 0)
			{
				return BF4494486.get_Name().IndexOf(E94347787, StringComparison.Ordinal) == 0;
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B31313306
	{
		public static readonly B31313306 E96260E58 = new B31313306();

		public static Predicate<IJdwpTypeField> FE2E15794;

		public static Predicate<IJdwpTypeField> C862B0159;

		public static Predicate<IJdwpTypeField> D58094B27;

		public static Converter<IJdwpTypeField, long> EF67A7767;

		internal bool D7115B5E0(IJdwpTypeField ABBF4CD79)
		{
			return (ABBF4CD79.get_Modifiers() & 0x1000) == 0;
		}

		internal bool FB4971411(IJdwpTypeField B8A34F62F)
		{
			return (B8A34F62F.get_Modifiers() & 8) != 0;
		}

		internal bool E3BD95501(IJdwpTypeField F6FA8E3D4)
		{
			return (F6FA8E3D4.get_Modifiers() & 8) == 0;
		}

		internal long AEE923EAE(IJdwpTypeField C9D18D6E4)
		{
			return C9D18D6E4.get_ID();
		}
	}

	[CompilerGenerated]
	private sealed class A46E69CA4
	{
		public string DB3CD3F88;

		internal bool B3CF75A72(IJdwpTypeField F6D7B30A4)
		{
			return DB3CD3F88 == F6D7B30A4.get_Name();
		}
	}

	public const string E805CF767 = "{...}";

	private ADB5C0658 EC245FC0D(ADB5C0658 FE4395B32)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (F63D7E302() is IJdwpClass)
		{
			IJdwpClass superclass = ((IJdwpClass)F63D7E302()).GetSuperclass();
			if (superclass != null && superclass != _jdbg.GetClass("java.lang.Object"))
			{
				return new F2FBC13F2(superclass, this, FE4395B32);
			}
		}
		return null;
	}

	public Value F4C1BB161(string DA87BA782)
	{
		IJdwpTypeField val = Array.Find(F63D7E302().GetFields(), (IJdwpTypeField BF4494486) => ((uint)BF4494486.get_Modifiers() & 0x1000u) != 0 && BF4494486.get_Name().IndexOf(DA87BA782, StringComparison.Ordinal) == 0);
		if (val != null)
		{
			IJdwpValue[] instanceValues = _jdbg.GetInstanceValues(base.CF06FB109.AsObject(), new long[1] { val.get_ID() });
			if (instanceValues.Length != 0)
			{
				return A002C58D2.A17FDB047(_jdbg, instanceValues[0]);
			}
		}
		return null;
	}

	private IJdwpTypeField[] DAF706C0E()
	{
		return Array.FindAll(F63D7E302().GetFields(), (IJdwpTypeField ABBF4CD79) => (ABBF4CD79.get_Modifiers() & 0x1000) == 0);
	}

	public ADB5C0658[] CFA9B9773(ADB5C0658 B40024060)
	{
		IJdwpTypeField[] array = DAF706C0E();
		IJdwpTypeField[] array2 = Array.FindAll(array, (IJdwpTypeField B8A34F62F) => (B8A34F62F.get_Modifiers() & 8) != 0);
		IJdwpValue[] values = F63D7E302().GetValues(array2);
		IJdwpTypeField[] array3 = Array.FindAll(array, (IJdwpTypeField F6FA8E3D4) => (F6FA8E3D4.get_Modifiers() & 8) == 0);
		IJdwpValue[] instanceValues = _jdbg.GetInstanceValues(base.CF06FB109.AsObject(), Array.ConvertAll(array3, (IJdwpTypeField C9D18D6E4) => C9D18D6E4.get_ID()));
		ADB5C0658 aDB5C = EC245FC0D(B40024060);
		ADB5C0658[] array4 = new ADB5C0658[array2.Length + array3.Length + ((aDB5C != null) ? 1 : 0)];
		int num = 0;
		if (aDB5C != null)
		{
			array4[num] = aDB5C;
			num++;
		}
		int num2 = 0;
		while (num2 < array2.Length)
		{
			array4[num] = new F8EDDC856(array2[num2], F63D7E302().get_ID(), B40024060);
			array4[num].FC3E9C6DA = A002C58D2.A17FDB047(_jdbg, values[num2]);
			num2++;
			num++;
		}
		int num3 = 0;
		while (num3 < array3.Length)
		{
			array4[num] = new F8EDDC856(array3[num3], base.CF06FB109.AsObject(), B40024060);
			array4[num].FC3E9C6DA = A002C58D2.A17FDB047(_jdbg, instanceValues[num3]);
			num3++;
			num++;
		}
		return array4;
	}

	public ADB5C0658 CC2F964D2(string F11C2A5DC, ADB5C0658 C6F56DBC8)
	{
		IJdwpTypeField val = Array.Find(F63D7E302().GetFields(), (IJdwpTypeField F6D7B30A4) => F11C2A5DC == F6D7B30A4.get_Name());
		if (val == null)
		{
			return null;
		}
		return new F8EDDC856(val, ((val.get_Modifiers() & 8) == 0) ? base.CF06FB109.AsObject() : F63D7E302().get_ID(), C6F56DBC8);
	}

	public static bool A671369C6(JdwpValueTag E988923E7)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		return (int)E988923E7 == 76;
	}

	public C4CC2394A(IJDbg jdbg, IJdwpValue value, IJdwpReferenceType type)
		: base(jdbg, value)
	{
		SetReferenceType(type);
		base.C78736E72 = "{" + F63D7E302().get_DisplaySignature() + "}";
	}

	public C4CC2394A(IJdwpClass clss, C4CC2394A obj)
		: this(obj._jdbg, obj.CF06FB109, (IJdwpReferenceType)(object)clss)
	{
	}
}
