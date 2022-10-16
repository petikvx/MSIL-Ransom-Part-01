using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralTest()
	{
	}
}
