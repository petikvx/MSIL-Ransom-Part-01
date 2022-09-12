using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal abstract class EA93D2578 : BC94B3E09
{
	[CompilerGenerated]
	private readonly IJdwpTypeField C45A2BC6F;

	public IJdwpTypeField D115297FA
	{
		[CompilerGenerated]
		get
		{
			return C45A2BC6F;
		}
	}

	public EA93D2578(IJdwpTypeField fld)
	{
		C45A2BC6F = fld;
	}

	public override FEC112558 D98224E04(DD3247535 ACD7A8304)
	{
		return FEC112558.B54D0B1CA(D115297FA.get_GenericSignature(), ACD7A8304);
	}
}
