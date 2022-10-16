using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeProxy()
	{
	}
}
