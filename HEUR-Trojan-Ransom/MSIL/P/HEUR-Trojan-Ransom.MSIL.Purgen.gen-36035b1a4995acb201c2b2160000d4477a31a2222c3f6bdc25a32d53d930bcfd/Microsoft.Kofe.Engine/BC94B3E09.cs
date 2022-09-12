using System.Collections.Generic;

namespace Microsoft.Kofe.Engine;

internal class BC94B3E09
{
	public enum F91E2B378
	{
		None,
		Simple,
		Reference,
		Ambiguous
	}

	private List<BC94B3E09> B4138102B;

	public BC94B3E09 D81BCD871;

	public BC94B3E09[] DB0339934 => B4138102B.ToArray();

	public BC94B3E09()
	{
		B4138102B = new List<BC94B3E09>();
	}

	public void AAB60E08B(BC94B3E09 FD4AB8248)
	{
		FD4AB8248.D81BCD871 = this;
		B4138102B.Add(FD4AB8248);
	}

	public override string CFAA78C40()
	{
		return base.ToString();
	}

	public virtual Value A4BA9D8ED(DD3247535 F58C8DD97)
	{
		throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
	}

	public virtual FEC112558 A7C3DB421(DD3247535 B2DCF267B)
	{
		throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
	}
}
