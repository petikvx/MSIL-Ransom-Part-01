using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FactoryExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralMap()
	{
	}
}
