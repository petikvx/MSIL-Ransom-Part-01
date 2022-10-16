using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceInfo()
	{
	}
}
