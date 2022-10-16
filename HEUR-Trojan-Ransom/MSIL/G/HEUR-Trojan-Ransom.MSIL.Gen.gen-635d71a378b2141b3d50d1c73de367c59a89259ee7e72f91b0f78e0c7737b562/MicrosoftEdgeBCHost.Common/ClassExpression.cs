using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClassExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralTest()
	{
	}
}
