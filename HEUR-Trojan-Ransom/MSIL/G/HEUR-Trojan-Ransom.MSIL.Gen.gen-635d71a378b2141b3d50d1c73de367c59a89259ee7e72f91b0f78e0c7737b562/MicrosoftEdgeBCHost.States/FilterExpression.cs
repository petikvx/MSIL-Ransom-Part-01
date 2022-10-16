using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FilterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralTest()
	{
	}
}
