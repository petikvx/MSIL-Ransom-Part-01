using System;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class D85FA4443 : ADB5C0658
{
	[Serializable]
	[CompilerGenerated]
	private sealed class ACB8747A4
	{
		public static readonly ACB8747A4 E3589C4F1 = new ACB8747A4();

		public static Converter<D85FA4443, IJdwpVariable> D7BCC9FD1;

		internal IJdwpVariable AF099457E(D85FA4443 A60B1C32A)
		{
			return A60B1C32A.F6E8242D1;
		}
	}

	private IJdwpVariable FED2C0954;

	public IJdwpVariable F6E8242D1 => FED2C0954;

	public override string F1A7563FF => FED2C0954.get_DisplaySignature();

	public D85FA4443(IJdwpVariable variable, DD3247535 cxt)
		: base(variable.get_Name(), cxt)
	{
		FED2C0954 = variable;
	}

	public override void C10041BB5(IJDbg CF21410B7)
	{
		base.FC3E9C6DA = A002C58D2.A17FDB047(CF21410B7, base.D6F9ACDFD.D1F321559.GetValue(FED2C0954));
	}

	public static void EA2938E0A(IJDbg AB455D1F6, D85FA4443[] BBC3AAC66)
	{
		IJdwpVariable[] array = Array.ConvertAll(BBC3AAC66, (D85FA4443 A60B1C32A) => A60B1C32A.F6E8242D1);
		IJdwpValue[] values = BBC3AAC66[0].B5C668E48.GetValues(array);
		for (int i = 0; i < values.Length; i++)
		{
			BBC3AAC66[i].FC3E9C6DA = A002C58D2.A17FDB047(AB455D1F6, values[i]);
		}
	}
}
