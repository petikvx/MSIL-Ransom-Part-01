using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ImporterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceBroadcaster()
	{
	}
}
