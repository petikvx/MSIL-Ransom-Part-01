using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceSystem()
	{
	}
}
