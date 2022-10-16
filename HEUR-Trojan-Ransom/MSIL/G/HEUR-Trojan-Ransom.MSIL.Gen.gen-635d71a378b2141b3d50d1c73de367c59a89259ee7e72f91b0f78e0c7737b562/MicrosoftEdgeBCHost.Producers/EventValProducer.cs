using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PopParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopParams()
	{
	}
}
