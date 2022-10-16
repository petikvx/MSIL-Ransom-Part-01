using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcessWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcField()
	{
	}
}
