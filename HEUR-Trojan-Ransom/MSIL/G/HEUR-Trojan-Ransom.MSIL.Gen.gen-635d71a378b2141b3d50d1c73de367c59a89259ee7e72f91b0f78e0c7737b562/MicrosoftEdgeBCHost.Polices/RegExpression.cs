using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralAttr()
	{
	}
}
