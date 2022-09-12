using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F2FBC13F2 : ADB5C0658
{
	private IJdwpClass C298A6153;

	public override string BB69234D1 => ((IJdwpReferenceType)C298A6153).get_DisplaySignature();

	public F2FBC13F2(IJdwpClass clss, C4CC2394A obj, ADB5C0658 context)
		: base("super", context.E5CC7F130, context)
	{
		C298A6153 = clss;
		base.FC3E9C6DA = new C4CC2394A(clss, obj);
	}

	public override void D0A11B596(IJDbg FA7E1986B)
	{
	}
}
