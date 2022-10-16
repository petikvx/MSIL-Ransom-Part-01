using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralRef()
	{
	}
}
