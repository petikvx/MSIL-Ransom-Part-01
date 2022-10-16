using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralInfo()
	{
	}
}
