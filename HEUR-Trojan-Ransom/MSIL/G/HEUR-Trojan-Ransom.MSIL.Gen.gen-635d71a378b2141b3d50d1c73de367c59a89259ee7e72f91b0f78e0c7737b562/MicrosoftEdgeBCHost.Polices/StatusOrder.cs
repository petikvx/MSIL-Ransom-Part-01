using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeReg()
	{
	}
}
