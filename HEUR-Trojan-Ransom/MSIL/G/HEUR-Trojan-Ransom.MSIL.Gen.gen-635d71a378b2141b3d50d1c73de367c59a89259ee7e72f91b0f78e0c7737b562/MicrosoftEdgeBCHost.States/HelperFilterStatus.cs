using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceIterator()
	{
	}
}
