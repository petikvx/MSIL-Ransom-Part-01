using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchParam()
	{
	}
}
