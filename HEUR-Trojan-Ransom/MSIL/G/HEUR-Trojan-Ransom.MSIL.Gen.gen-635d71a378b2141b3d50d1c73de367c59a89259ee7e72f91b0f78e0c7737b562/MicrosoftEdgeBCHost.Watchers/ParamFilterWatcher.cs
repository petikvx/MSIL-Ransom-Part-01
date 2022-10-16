using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintFacade()
	{
	}
}
