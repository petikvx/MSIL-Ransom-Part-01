using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceSetter()
	{
	}
}
