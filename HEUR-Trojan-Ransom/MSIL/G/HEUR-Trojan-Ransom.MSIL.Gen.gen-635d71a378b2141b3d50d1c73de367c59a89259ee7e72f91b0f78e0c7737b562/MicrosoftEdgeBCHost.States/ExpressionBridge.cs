using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriteAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteAdapter()
	{
	}
}
