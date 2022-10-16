using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientServer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralWrapper()
	{
	}
}
