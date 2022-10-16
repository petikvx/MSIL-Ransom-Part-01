using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReponseValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceAlgo()
	{
	}
}
