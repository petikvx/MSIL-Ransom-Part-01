using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RepositoryState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryState()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceInitializer()
	{
	}
}
