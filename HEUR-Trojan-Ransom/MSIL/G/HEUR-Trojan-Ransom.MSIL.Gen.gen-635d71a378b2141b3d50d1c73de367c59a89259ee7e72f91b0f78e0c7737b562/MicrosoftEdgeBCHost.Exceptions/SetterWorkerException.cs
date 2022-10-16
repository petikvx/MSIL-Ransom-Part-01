using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SetterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		RunWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunWatcher()
	{
	}
}
