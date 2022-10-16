using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RepositoryFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchTemplate()
	{
	}
}
