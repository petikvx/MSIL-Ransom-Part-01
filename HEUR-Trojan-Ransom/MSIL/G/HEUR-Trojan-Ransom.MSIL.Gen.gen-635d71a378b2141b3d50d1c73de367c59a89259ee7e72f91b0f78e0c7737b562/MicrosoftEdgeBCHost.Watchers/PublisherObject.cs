using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherObject()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralSchema()
	{
	}
}
