using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class OrderFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceProduct()
	{
	}
}
