using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DecoratorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralObserver()
	{
	}
}
