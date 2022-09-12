using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class B8C70FA7A : BC94B3E09
{
	[CompilerGenerated]
	private readonly IJdwpClass DC07210C1;

	public IJdwpClass F803F696F
	{
		[CompilerGenerated]
		get
		{
			return DC07210C1;
		}
	}

	public B8C70FA7A(IJdwpClass clss)
	{
		DC07210C1 = clss;
	}

	public override Value A7F25AAC5(DD3247535 C72C8B752)
	{
		throw new EEA8EDD4A(B0E4D9146.A1ECE95BF);
	}

	public override string CE60318B4()
	{
		return F803F696F.get_Name();
	}
}
