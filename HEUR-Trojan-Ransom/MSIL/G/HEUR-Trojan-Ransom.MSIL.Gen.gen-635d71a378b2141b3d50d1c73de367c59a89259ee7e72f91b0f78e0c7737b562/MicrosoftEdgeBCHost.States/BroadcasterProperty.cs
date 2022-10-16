using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceDescriptor()
	{
	}
}
