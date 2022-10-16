using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReponseAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralObserver()
	{
	}
}
