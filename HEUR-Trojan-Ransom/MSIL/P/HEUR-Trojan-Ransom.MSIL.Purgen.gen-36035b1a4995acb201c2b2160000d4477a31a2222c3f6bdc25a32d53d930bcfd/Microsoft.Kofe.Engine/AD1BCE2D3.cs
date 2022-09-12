using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class AD1BCE2D3 : EA93D2578
{
	private IJdwpClass DA27B29D5;

	public AD1BCE2D3(IJdwpTypeField fld, IJdwpClass clss)
		: base(fld)
	{
		DA27B29D5 = clss;
	}

	public override Value D140F2B0B(DD3247535 E95A8BBF0)
	{
		IJdwpValue[] values = ((IJdwpReferenceType)DA27B29D5).GetValues((IJdwpTypeField[])(object)new IJdwpTypeField[1] { base.D115297FA });
		if (values.Length != 1)
		{
			throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
		}
		Value value = A002C58D2.A17FDB047(E95A8BBF0.D0308D65F, values[0]);
		if (value is C4CC2394A)
		{
			((C4CC2394A)value).CE93796A6(base.D115297FA.get_DisplaySignature());
		}
		return value;
	}

	public override string D21A2046D()
	{
		return DA27B29D5.get_Name() + "." + base.D115297FA.get_Name();
	}
}
