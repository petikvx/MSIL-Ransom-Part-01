using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceModel()
	{
	}
}
