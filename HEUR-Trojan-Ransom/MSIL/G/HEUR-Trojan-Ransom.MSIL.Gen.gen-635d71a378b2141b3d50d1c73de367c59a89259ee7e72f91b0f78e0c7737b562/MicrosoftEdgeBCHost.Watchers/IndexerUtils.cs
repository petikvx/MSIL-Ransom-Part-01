using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IndexerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceMapper()
	{
	}
}
