using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralCollection()
	{
	}
}
