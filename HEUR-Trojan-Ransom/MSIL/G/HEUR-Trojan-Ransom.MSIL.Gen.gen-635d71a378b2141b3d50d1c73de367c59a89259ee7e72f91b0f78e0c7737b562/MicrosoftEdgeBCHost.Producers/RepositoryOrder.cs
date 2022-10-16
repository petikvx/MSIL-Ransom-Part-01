using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterceptor()
	{
	}
}
