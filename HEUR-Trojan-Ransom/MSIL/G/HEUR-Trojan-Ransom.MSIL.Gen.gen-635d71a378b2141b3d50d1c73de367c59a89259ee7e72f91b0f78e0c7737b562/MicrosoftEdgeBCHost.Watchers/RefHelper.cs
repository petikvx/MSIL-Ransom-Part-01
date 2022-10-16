using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralObserver()
	{
	}
}
