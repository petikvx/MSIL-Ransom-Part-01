using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsExpression()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralParser()
	{
	}
}
