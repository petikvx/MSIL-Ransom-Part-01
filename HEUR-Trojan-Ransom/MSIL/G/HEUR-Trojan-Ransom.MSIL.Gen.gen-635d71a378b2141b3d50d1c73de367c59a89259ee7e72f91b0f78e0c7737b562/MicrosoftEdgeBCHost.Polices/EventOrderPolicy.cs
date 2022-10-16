using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralMapping()
	{
	}
}
