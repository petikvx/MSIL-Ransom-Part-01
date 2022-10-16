using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class EventVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventVal()
	{
		WriterPropertyProducer.ResolveStub();
		FindProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindProducer()
	{
	}
}
