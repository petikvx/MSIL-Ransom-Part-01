using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetReg()
	{
	}
}
