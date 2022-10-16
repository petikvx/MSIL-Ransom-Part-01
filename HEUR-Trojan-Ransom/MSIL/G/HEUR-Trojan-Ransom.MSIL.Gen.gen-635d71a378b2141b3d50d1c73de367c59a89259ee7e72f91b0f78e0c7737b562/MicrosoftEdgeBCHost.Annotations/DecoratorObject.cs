using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorObject()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralCandidate()
	{
	}
}
