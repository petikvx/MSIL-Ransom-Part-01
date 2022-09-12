using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A745D5FD9 : EA93D2578
{
	[CompilerGenerated]
	private readonly BC94B3E09 E0E66E09C;

	public BC94B3E09 DC72E4CAA
	{
		[CompilerGenerated]
		get
		{
			return E0E66E09C;
		}
	}

	public A745D5FD9(IJdwpTypeField fld, BC94B3E09 obj)
		: base(fld)
	{
		E0E66E09C = obj;
	}

	public override Value FD0C3D4EB(DD3247535 A3736D250)
	{
		Value value = DC72E4CAA.A4BA9D8ED(A3736D250);
		if (value.Kind != F18024EA9.Object)
		{
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
		IJdwpValue[] instanceValues = A3736D250.D0308D65F.GetInstanceValues(((C4CC2394A)value).A5CC0F68A, new long[1] { base.D115297FA.get_ID() });
		if (instanceValues.Length != 1)
		{
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
		value = A002C58D2.A17FDB047(A3736D250.D0308D65F, instanceValues[0]);
		if (value is C4CC2394A)
		{
			((C4CC2394A)value).CE93796A6(base.D115297FA.get_DisplaySignature());
		}
		return value;
	}

	public override string B9A809D5E()
	{
		return DC72E4CAA.ToString() + "." + base.D115297FA.get_Name();
	}
}
