using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralFacade()
	{
	}
}
