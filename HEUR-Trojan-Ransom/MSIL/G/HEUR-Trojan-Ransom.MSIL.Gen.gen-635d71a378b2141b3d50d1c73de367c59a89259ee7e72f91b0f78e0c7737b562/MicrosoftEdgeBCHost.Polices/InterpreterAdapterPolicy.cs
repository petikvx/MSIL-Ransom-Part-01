using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterpreterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralThread()
	{
	}
}
