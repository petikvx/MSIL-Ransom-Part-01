using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrinterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterClass()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceRegistry()
	{
	}
}
