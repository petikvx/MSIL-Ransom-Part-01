using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseServer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralStrategy()
	{
	}
}
