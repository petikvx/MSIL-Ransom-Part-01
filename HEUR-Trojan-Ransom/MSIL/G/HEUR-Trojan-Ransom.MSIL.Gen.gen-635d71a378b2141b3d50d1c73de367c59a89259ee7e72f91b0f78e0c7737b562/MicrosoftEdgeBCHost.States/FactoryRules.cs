using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryRules()
	{
		WriterPropertyProducer.ResolveStub();
		SelectPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectPrinter()
	{
	}
}
