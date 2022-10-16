using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SetterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceReg()
	{
	}
}
