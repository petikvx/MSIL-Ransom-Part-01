using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestExpression()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralRef()
	{
	}
}
