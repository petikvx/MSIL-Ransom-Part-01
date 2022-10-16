using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ResetWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetWatcher()
	{
	}
}
