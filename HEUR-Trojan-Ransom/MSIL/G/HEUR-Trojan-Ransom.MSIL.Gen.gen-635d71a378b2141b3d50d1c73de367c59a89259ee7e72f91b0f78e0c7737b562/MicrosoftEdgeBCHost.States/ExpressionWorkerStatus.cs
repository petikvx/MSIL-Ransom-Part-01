using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralVisitor()
	{
	}
}
