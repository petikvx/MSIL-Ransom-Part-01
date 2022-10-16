using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallMap()
	{
	}
}
