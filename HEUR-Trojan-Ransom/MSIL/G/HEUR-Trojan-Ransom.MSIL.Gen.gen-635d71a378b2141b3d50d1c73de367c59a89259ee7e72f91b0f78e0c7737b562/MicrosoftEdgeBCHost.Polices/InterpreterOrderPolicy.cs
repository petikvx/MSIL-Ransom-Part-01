using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterpreterOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralRecord()
	{
	}
}
