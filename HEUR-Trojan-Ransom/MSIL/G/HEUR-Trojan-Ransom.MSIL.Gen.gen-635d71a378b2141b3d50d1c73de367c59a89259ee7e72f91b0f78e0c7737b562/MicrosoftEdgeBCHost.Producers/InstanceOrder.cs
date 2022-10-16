using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DisableReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableReg()
	{
	}
}
