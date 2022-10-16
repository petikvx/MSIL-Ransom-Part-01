using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeParameter()
	{
	}
}
