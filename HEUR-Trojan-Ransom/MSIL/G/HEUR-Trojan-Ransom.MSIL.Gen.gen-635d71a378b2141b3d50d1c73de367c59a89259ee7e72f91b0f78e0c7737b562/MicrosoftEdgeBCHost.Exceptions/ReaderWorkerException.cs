using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReaderWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckContext()
	{
	}
}
