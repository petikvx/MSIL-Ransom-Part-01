using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceService()
	{
	}
}
