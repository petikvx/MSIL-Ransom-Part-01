using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProcObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcObject()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralExpression()
	{
	}
}
