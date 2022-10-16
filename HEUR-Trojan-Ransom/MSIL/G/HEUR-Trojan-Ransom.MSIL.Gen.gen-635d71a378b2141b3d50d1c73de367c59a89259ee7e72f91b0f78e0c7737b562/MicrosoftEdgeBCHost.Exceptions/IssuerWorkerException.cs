using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IssuerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeTask()
	{
	}
}
