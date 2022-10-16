using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceInfo()
	{
	}
}
