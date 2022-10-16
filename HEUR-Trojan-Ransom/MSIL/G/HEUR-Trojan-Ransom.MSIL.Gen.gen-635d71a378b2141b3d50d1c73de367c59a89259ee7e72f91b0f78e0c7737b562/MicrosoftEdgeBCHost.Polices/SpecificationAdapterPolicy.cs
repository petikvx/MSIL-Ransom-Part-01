using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SpecificationAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralProducer()
	{
	}
}
