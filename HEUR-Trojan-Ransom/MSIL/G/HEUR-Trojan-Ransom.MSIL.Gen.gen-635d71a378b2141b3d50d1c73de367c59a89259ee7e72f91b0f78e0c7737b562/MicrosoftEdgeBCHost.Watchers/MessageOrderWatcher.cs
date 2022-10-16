using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralDispatcher()
	{
	}
}
