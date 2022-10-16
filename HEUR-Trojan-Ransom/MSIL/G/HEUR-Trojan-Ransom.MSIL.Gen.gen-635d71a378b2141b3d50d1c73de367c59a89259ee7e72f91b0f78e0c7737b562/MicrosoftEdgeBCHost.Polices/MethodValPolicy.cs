using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MethodValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceAlgo()
	{
	}
}
