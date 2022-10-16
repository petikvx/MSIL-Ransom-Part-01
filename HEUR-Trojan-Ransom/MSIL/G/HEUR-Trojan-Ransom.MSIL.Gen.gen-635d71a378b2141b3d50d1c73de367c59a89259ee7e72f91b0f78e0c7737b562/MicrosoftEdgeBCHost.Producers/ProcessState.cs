using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessState()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceParam()
	{
	}
}
