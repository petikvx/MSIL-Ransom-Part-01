using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceExporter()
	{
	}
}
