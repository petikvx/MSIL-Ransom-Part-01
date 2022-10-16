using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GlobalWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RateRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateRecord()
	{
	}
}
