using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MockOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceReg()
	{
	}
}
