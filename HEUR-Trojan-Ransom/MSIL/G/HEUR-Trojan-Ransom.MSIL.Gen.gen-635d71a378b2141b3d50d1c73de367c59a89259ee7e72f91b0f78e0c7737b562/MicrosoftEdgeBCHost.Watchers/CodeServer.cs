using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeServer()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralPublisher()
	{
	}
}
