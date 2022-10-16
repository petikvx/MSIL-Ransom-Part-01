using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateClient()
	{
	}
}
