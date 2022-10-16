using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralStruct()
	{
	}
}
