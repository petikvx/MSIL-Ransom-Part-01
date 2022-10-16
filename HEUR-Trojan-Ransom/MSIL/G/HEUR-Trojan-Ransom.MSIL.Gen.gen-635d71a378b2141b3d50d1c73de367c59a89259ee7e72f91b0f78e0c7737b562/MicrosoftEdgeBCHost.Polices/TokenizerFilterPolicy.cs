using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyVal()
	{
	}
}
