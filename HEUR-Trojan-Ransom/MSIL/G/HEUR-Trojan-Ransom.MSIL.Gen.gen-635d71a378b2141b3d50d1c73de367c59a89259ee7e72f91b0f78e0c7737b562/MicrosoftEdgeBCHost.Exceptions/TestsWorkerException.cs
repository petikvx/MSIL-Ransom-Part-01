using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestsWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PostPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostPool()
	{
	}
}
