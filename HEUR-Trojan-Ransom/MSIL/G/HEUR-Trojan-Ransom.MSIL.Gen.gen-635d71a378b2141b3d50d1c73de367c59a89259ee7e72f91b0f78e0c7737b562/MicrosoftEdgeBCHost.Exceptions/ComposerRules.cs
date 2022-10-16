using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComposerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerRules()
	{
		WriterPropertyProducer.ResolveStub();
		NewOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewOrder()
	{
	}
}
