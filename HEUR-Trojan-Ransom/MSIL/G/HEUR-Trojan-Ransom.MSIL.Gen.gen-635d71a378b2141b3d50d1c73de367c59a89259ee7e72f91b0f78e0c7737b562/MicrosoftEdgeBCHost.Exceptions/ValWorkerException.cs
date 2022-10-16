using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelVal()
	{
	}
}
