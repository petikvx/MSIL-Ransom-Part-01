using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdapterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralMapper()
	{
	}
}
