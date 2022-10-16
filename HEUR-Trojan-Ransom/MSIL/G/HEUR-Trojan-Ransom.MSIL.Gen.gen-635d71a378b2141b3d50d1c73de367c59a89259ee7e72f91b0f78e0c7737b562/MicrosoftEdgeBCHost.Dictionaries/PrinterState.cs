using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterState()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceParam()
	{
	}
}
