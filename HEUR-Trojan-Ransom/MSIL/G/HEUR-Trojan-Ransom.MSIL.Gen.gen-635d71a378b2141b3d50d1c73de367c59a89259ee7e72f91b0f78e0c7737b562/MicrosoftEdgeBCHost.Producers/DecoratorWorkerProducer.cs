using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceTests()
	{
	}
}
