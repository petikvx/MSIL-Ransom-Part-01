using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IteratorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceWriter()
	{
	}
}
