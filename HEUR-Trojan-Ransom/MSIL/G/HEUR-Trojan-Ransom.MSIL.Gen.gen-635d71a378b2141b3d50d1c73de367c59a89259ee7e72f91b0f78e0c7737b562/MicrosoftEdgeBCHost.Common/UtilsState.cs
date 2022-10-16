using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsState()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceStatus()
	{
	}
}
