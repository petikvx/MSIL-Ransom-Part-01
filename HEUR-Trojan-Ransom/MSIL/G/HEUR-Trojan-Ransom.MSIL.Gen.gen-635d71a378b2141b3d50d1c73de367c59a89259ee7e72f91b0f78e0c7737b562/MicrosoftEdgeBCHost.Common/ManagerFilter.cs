using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ManagerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CompareClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareClient()
	{
	}
}
