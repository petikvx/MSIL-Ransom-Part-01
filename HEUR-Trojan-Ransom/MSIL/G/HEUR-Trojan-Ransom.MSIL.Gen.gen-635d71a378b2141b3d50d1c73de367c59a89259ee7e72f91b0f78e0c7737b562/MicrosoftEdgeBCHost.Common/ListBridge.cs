using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveStatus()
	{
	}
}
