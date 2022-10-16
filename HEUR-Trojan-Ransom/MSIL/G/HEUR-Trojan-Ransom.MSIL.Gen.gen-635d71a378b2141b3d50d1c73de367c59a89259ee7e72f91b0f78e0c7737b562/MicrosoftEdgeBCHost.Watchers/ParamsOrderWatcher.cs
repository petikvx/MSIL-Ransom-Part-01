using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParamsOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralContext()
	{
	}
}
