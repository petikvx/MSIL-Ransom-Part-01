using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CallbackOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralPublisher()
	{
	}
}
