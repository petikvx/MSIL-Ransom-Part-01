using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceInitializer()
	{
	}
}
