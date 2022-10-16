using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositorySerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositorySerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralAttribute()
	{
	}
}
