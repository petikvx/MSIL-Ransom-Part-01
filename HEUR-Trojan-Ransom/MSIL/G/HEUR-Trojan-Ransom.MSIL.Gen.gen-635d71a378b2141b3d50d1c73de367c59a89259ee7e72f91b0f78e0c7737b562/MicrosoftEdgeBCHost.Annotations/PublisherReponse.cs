using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherReponse()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralMethod()
	{
	}
}
