using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseExpression()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralTests()
	{
	}
}
