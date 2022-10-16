using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeObject()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralContext()
	{
	}
}
