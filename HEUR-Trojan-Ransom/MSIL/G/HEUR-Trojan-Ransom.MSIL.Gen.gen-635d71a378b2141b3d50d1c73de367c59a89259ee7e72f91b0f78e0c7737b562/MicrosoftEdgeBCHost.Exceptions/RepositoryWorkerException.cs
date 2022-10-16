using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchTask()
	{
	}
}
