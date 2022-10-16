using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverExpression()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralAttr()
	{
	}
}
