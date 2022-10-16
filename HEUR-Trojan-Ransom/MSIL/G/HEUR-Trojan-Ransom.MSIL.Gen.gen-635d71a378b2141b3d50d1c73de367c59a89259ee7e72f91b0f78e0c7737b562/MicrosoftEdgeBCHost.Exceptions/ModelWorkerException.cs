using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotProducer()
	{
	}
}
