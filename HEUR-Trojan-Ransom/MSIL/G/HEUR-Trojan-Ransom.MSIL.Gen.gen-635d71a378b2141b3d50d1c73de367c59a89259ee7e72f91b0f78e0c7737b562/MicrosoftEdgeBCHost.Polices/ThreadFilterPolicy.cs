using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortDefinition()
	{
	}
}
