using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceExporter()
	{
	}
}
