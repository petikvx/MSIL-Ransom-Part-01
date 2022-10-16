using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralPrototype()
	{
	}
}
