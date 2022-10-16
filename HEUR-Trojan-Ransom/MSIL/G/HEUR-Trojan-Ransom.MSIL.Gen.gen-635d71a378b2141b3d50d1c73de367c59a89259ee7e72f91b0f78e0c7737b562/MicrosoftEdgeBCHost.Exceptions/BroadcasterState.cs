using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterState()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceConfiguration()
	{
	}
}
