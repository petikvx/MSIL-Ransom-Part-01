using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralMethod()
	{
	}
}
