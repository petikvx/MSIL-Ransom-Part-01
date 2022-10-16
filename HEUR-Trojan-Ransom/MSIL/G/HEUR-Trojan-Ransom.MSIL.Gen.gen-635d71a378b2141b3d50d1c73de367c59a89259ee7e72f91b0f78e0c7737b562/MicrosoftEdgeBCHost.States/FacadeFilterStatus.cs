using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FacadeFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceIterator()
	{
	}
}
