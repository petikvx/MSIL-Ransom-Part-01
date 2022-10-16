using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapContext()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfacePredicate()
	{
	}
}
