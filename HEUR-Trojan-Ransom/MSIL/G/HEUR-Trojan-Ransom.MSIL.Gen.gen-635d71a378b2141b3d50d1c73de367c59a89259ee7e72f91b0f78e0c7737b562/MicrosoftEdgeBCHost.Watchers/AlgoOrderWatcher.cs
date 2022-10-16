using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralVal()
	{
	}
}
