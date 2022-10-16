using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SingletonWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceImporter()
	{
	}
}
