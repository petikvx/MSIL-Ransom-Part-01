using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoState()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceRecord()
	{
	}
}
