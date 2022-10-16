using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishClient()
	{
	}
}
