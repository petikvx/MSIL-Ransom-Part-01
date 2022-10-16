using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatAdvisor()
	{
	}
}
