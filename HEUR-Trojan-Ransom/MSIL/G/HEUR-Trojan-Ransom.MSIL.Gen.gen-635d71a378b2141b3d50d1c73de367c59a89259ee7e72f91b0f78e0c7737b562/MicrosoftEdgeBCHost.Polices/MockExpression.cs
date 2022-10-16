using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MockExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralPrototype()
	{
	}
}
