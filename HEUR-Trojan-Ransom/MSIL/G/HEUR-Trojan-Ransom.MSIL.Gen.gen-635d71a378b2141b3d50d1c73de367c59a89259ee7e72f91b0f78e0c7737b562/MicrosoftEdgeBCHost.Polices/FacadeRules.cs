using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeRules()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateTag()
	{
	}
}
