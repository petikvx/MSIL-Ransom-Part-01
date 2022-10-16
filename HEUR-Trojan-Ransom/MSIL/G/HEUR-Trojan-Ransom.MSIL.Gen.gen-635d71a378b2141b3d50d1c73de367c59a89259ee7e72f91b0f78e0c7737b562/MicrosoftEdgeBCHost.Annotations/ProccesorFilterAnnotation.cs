using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceOrder()
	{
	}
}
