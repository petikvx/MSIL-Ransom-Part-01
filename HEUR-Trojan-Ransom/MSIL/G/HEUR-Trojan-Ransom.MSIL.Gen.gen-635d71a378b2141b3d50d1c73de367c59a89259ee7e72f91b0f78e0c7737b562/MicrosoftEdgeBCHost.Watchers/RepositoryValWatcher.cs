using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceParams()
	{
	}
}
