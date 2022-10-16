using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralQueue()
	{
	}
}
