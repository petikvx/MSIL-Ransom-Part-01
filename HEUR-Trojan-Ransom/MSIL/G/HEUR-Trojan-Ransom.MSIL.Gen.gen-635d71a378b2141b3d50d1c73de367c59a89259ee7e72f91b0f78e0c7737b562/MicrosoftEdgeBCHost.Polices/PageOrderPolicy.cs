using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PageOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralTests()
	{
	}
}
