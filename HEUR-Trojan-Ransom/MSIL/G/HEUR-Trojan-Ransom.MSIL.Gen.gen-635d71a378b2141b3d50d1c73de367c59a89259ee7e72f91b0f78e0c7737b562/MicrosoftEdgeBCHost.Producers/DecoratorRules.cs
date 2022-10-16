using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorRules()
	{
		WriterPropertyProducer.ResolveStub();
		MoveParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveParams()
	{
	}
}
