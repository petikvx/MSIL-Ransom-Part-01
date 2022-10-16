using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerServer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralWatcher()
	{
	}
}
