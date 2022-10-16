using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralTests()
	{
	}
}
