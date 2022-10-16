using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptReg()
	{
	}
}
