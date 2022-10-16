using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralServer()
	{
	}
}
