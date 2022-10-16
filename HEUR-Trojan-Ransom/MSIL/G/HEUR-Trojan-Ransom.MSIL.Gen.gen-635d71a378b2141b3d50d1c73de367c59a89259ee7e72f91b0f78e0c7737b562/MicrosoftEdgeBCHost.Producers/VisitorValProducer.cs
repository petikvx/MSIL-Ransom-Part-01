using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class VisitorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveTag()
	{
	}
}
