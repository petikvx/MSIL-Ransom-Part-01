using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class EventServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventServer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralPublisher()
	{
	}
}
