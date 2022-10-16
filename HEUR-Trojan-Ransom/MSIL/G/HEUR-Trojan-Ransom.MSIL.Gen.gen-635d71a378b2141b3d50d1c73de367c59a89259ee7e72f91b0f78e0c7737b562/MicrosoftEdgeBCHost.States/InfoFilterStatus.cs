using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InfoFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceStub()
	{
	}
}
