using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceSchema()
	{
	}
}
