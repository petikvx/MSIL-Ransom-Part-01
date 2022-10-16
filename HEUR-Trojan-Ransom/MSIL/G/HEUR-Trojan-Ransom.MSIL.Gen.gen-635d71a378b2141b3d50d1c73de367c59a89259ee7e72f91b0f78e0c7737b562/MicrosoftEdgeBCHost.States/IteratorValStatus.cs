using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IteratorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralPrinter()
	{
	}
}
