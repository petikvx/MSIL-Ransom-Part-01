using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrinterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceStruct()
	{
	}
}
