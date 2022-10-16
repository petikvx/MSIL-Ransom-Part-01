using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InstanceWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptParameter()
	{
	}
}
