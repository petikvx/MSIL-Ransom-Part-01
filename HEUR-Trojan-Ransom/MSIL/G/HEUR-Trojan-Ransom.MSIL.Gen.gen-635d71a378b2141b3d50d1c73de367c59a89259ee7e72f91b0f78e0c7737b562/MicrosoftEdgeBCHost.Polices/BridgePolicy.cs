using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceAnnotation()
	{
	}
}
