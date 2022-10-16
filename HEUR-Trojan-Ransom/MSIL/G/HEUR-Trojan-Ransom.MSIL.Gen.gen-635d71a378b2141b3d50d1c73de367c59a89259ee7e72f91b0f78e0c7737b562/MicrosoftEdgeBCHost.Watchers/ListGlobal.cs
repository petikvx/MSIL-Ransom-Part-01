using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceCandidate()
	{
	}
}
