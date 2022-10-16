using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WriterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatClass()
	{
	}
}
