using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralAttribute()
	{
	}
}
