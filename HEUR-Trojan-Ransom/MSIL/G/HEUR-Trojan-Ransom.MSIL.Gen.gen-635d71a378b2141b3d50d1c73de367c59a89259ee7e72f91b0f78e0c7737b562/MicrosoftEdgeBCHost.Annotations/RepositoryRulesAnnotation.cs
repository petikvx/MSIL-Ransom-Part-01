using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostFilter()
	{
	}
}
