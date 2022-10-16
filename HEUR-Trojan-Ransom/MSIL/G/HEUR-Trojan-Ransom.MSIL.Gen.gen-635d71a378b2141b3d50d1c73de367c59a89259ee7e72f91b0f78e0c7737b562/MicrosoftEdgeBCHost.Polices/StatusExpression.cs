using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralParser()
	{
	}
}
