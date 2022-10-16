using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceProc()
	{
	}
}
