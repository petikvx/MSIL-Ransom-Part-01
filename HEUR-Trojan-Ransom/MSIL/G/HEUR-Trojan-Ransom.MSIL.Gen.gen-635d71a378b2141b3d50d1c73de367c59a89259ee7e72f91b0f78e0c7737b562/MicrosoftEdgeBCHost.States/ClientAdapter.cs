using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceCode()
	{
	}
}
