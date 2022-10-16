using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PropertyFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralPolicy()
	{
	}
}
