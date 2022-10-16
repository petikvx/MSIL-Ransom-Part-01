using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcessClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessClass()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceItem()
	{
	}
}
