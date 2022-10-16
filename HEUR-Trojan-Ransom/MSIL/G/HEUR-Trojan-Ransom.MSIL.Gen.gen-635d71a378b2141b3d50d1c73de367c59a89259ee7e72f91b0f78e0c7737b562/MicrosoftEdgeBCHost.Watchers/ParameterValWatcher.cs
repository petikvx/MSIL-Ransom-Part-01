using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParameterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceComparator()
	{
	}
}
