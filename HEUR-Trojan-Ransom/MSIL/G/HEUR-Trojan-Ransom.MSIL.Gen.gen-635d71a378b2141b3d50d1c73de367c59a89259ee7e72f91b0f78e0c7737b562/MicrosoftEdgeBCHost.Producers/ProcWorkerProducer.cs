using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceDefinition()
	{
	}
}
