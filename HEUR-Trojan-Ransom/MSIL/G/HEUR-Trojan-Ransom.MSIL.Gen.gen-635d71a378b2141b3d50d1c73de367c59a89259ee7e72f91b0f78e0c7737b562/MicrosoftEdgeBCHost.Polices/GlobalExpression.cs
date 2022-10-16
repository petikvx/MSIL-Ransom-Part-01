using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalExpression()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralTest()
	{
	}
}
