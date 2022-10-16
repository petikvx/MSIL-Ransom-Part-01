using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapperOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralInvocation()
	{
	}
}
