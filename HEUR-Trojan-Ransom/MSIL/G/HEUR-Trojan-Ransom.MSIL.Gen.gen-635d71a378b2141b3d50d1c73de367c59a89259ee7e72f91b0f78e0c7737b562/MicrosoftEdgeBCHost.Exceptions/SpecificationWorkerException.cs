using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SpecificationWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterpreter()
	{
	}
}
