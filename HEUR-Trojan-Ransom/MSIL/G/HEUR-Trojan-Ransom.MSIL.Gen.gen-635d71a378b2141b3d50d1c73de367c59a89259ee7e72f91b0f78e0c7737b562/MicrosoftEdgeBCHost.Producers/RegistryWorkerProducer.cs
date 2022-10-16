using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceError()
	{
	}
}
