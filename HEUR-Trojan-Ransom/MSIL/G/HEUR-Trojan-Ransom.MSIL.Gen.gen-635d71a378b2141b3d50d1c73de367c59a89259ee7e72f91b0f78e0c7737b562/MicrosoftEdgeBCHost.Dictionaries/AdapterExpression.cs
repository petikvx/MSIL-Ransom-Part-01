using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralTest()
	{
	}
}
