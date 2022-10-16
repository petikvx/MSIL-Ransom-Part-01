using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralIssuer()
	{
	}
}
