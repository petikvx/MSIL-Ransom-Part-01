using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceCollection()
	{
	}
}
