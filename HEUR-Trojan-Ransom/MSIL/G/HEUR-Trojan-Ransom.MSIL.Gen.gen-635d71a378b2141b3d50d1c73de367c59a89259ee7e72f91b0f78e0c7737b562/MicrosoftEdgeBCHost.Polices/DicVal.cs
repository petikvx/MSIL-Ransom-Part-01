using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicVal()
	{
		WriterPropertyProducer.ResolveStub();
		DefinePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefinePredicate()
	{
	}
}
