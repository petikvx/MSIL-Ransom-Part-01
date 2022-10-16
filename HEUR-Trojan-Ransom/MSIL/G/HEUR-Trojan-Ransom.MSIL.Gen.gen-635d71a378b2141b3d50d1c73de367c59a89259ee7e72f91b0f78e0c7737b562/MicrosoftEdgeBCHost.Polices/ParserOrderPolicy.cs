using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParserOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralParser()
	{
	}
}
