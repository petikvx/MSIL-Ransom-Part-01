using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RunReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunReponse()
	{
	}
}
