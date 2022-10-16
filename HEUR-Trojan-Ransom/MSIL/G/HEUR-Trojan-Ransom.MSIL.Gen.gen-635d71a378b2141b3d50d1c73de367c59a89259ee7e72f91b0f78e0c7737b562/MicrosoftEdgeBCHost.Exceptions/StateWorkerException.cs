using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StateWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeRecord()
	{
	}
}
