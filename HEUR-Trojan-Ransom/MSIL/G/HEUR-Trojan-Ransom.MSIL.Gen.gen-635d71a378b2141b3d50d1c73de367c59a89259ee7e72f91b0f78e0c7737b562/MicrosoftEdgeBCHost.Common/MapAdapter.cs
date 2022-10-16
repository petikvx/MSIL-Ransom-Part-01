using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceIssuer()
	{
	}
}
