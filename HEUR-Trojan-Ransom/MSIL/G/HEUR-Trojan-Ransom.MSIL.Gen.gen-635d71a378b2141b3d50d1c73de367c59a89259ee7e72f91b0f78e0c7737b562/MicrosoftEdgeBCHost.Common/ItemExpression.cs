using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ItemExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralTests()
	{
	}
}
