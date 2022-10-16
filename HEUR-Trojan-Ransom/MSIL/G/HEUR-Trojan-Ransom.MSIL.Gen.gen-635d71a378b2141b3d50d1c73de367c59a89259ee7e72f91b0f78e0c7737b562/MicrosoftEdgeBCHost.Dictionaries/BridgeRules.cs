using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BridgeRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeRules()
	{
		WriterPropertyProducer.ResolveStub();
		MoveMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveMessage()
	{
	}
}
