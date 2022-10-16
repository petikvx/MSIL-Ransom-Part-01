using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderRules()
	{
		WriterPropertyProducer.ResolveStub();
		StopPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopPrinter()
	{
	}
}
