using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralCustomer()
	{
	}
}
