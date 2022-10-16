using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StateWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceInterpreter()
	{
	}
}
