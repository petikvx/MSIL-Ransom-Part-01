using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralParam()
	{
	}
}
