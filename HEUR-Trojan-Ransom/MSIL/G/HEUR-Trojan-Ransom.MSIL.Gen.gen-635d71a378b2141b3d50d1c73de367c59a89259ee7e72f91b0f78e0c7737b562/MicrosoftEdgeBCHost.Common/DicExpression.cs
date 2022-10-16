using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicExpression()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralSetter()
	{
	}
}
