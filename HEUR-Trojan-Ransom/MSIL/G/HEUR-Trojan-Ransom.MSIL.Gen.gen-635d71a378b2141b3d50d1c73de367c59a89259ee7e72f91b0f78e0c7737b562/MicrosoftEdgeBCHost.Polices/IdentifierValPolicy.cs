using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortAdvisor()
	{
	}
}
