using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcessOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralAnnotation()
	{
	}
}
