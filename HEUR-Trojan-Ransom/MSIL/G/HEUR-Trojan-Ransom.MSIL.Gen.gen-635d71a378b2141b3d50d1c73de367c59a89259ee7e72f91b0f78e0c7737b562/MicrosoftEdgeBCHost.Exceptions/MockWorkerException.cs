using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CancelAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelAnnotation()
	{
	}
}
