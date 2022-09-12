using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class BD2D940BA : BC94B3E09
{
	private BC94B3E09 C8C185C56;

	[CompilerGenerated]
	private readonly IJdwpClass C1DBB2B40;

	public IJdwpClass A2245337E
	{
		[CompilerGenerated]
		get
		{
			return C1DBB2B40;
		}
	}

	public BD2D940BA(IJdwpClass clss, BC94B3E09 obj)
	{
		C8C185C56 = obj;
		C1DBB2B40 = clss;
		if (C8C185C56 == null || obj == null)
		{
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
	}

	public override string BEF5131FA()
	{
		return ((IJdwpReferenceType)A2245337E).get_DisplaySignature() + C8C185C56.ToString();
	}

	public override Value C27B9913E(DD3247535 FF88E885D)
	{
		Value value = C8C185C56.A4BA9D8ED(FF88E885D);
		while (value != null && value is C4CC2394A)
		{
			C4CC2394A c4CC2394A = (C4CC2394A)value;
			if (c4CC2394A.F63D7E302() == A2245337E)
			{
				return value;
			}
			value = c4CC2394A.F4C1BB161("this$");
		}
		throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
	}

	public override FEC112558 E5A0D1B44(DD3247535 DFD34AAAE)
	{
		return new FEC112558(F18024EA9.Object, A2245337E);
	}
}
