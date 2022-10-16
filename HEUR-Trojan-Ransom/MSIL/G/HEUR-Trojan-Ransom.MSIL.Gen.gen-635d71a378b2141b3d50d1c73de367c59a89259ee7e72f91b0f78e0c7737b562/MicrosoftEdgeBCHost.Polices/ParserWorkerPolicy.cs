using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParserWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceWrapper()
	{
	}
}
