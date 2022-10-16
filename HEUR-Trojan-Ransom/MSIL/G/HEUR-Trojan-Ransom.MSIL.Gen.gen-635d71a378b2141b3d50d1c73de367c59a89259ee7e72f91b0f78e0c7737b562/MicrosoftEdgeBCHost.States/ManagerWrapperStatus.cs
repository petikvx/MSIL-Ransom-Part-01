using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ManagerWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeAlgo()
	{
	}
}
