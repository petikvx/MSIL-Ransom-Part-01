using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateState()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceStatus()
	{
	}
}
