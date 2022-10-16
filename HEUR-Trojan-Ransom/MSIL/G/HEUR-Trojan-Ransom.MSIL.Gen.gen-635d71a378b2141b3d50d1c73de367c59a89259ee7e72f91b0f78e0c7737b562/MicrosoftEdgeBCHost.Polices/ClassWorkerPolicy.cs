using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceExporter()
	{
	}
}
