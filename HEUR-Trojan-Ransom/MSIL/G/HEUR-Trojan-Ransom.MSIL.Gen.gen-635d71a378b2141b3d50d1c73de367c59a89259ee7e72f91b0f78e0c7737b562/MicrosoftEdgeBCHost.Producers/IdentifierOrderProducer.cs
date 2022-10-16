using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceComposer()
	{
	}
}
