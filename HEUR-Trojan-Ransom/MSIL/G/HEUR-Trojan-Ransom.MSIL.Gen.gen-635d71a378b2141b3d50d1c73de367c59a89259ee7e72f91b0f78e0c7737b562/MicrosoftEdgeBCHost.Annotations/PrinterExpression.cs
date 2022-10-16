using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralPrototype()
	{
	}
}
