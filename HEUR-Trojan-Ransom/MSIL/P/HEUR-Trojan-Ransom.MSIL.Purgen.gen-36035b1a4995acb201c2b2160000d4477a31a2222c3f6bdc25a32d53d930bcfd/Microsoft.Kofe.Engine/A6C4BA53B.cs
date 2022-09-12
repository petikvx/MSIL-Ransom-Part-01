using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A6C4BA53B : BC94B3E09
{
	private BC94B3E09 A916AF713;

	[CompilerGenerated]
	private readonly IJdwpClass DFD8E6FD1;

	public IJdwpClass A5B91504E
	{
		[CompilerGenerated]
		get
		{
			return DFD8E6FD1;
		}
	}

	public A6C4BA53B(IJdwpClass clss, BC94B3E09 obj)
	{
		A916AF713 = obj;
		DFD8E6FD1 = clss;
		if (A916AF713 == null || obj == null)
		{
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
	}

	public override string B3E104294()
	{
		return "(" + ((IJdwpReferenceType)A5B91504E).get_DisplaySignature() + ")" + A916AF713.ToString();
	}

	public override Value DF17A5E6A(DD3247535 A6BFF4B40)
	{
		Value value = A916AF713.A4BA9D8ED(A6BFF4B40);
		if (value is C4CC2394A)
		{
			return new C4CC2394A(A5B91504E, value as C4CC2394A);
		}
		return value;
	}

	public override FEC112558 CD8AD8884(DD3247535 E60397436)
	{
		return new FEC112558(F18024EA9.Object, A5B91504E);
	}
}
