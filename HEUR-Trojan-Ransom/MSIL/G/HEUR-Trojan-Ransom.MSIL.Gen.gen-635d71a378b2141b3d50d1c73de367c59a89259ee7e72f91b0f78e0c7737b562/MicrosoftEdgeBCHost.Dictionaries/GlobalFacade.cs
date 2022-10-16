using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GlobalFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFacade()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralPolicy()
	{
	}
}
