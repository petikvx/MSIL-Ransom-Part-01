using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IteratorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralInterpreter()
	{
	}
}
