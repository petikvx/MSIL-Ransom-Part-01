using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfacePrototype()
	{
	}
}
