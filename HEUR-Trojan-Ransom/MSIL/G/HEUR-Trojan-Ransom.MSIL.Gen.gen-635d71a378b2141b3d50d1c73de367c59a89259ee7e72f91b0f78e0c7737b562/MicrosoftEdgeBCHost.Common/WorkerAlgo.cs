using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WorkerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralVal()
	{
	}
}
