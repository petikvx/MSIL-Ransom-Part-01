using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RepositoryRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryRules()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveOrder()
	{
	}
}
