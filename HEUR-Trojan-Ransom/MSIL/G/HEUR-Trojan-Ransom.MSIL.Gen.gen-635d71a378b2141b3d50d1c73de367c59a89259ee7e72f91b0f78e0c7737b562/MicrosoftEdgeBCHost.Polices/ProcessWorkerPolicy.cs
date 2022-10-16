using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcessWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceAnnotation()
	{
	}
}
