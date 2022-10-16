using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class OrderWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceMap()
	{
	}
}
