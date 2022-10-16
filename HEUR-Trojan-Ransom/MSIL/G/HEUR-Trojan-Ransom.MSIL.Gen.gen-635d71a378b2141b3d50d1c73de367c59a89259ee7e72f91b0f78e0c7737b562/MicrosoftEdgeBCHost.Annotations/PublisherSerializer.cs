using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralProccesor()
	{
	}
}
