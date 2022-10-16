using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExporterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptProc()
	{
	}
}
