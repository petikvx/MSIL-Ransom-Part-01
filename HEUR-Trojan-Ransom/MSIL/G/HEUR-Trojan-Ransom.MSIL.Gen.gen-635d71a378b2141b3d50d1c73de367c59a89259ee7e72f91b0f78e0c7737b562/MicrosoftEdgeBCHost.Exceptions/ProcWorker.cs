using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RunSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunSerializer()
	{
	}
}
