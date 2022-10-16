using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceWatcher()
	{
	}
}
