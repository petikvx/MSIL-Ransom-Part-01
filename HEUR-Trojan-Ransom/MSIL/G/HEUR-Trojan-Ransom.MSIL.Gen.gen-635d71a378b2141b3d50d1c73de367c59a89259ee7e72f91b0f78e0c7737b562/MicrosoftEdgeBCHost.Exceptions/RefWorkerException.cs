using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RefWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		StartFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartFilter()
	{
	}
}
