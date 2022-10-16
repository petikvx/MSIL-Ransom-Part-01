using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceConnection()
	{
	}
}
