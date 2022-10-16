using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeAttribute()
	{
	}
}
