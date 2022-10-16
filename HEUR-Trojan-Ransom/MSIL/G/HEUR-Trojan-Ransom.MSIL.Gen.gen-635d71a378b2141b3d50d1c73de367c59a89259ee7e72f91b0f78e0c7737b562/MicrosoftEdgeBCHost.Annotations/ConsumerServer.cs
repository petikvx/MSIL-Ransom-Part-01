using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerServer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralPublisher()
	{
	}
}
