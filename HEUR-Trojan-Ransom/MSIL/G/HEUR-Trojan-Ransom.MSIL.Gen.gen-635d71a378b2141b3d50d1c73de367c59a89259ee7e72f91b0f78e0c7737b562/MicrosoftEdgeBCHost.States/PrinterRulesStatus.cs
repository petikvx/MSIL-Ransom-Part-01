using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrinterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceDispatcher()
	{
	}
}
