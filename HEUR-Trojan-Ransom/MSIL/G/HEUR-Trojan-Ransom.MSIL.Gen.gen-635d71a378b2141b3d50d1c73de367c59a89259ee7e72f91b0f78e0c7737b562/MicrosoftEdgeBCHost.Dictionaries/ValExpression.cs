using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralTest()
	{
	}
}
