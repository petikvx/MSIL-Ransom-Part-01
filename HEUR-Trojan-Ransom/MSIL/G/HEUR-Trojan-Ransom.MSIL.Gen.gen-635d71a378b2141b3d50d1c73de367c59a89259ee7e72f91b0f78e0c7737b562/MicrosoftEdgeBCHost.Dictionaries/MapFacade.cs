using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFacade()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralItem()
	{
	}
}
