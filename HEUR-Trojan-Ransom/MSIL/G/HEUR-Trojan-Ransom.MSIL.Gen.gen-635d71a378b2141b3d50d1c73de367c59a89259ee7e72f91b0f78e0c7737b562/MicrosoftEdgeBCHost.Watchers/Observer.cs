using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Observer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Observer()
	{
		WriterPropertyProducer.ResolveStub();
		VisitIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitIdentifier()
	{
	}
}
