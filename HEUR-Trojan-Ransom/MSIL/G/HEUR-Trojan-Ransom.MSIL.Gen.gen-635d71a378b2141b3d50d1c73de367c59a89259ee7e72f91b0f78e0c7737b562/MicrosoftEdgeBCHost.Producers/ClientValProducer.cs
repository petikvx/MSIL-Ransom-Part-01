using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClientValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FlushSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushSingleton()
	{
	}
}
