using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralTests()
	{
	}
}
