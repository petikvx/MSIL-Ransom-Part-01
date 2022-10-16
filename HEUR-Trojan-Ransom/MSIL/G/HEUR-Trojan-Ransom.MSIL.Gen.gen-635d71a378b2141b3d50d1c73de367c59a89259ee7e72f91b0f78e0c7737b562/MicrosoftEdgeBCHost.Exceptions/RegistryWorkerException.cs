using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegistryWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryMock()
	{
	}
}
