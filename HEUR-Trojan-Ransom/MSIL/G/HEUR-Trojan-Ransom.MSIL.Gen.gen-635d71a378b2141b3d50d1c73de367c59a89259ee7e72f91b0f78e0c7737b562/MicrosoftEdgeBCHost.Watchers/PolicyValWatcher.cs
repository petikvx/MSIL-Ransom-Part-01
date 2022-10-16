using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PolicyValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceAlgo()
	{
	}
}
