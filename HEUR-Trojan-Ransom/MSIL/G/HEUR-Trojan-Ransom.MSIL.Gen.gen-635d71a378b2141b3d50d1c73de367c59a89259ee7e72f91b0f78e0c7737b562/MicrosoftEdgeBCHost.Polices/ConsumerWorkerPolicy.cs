using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConsumerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceProduct()
	{
	}
}
