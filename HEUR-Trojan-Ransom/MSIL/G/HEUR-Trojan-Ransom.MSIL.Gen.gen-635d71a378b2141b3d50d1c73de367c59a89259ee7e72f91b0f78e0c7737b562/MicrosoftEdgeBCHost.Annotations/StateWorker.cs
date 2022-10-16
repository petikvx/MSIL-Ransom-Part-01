using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PushProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushProcess()
	{
	}
}
