using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInitializer()
	{
	}
}
