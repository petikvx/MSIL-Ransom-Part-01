using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PublisherRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectStrategy()
	{
	}
}
