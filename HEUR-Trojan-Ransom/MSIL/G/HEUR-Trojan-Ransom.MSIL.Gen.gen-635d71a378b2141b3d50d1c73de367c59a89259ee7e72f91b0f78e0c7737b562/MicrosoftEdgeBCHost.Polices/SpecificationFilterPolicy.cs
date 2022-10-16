using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectProxy()
	{
	}
}
