using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcVal()
	{
	}
}
