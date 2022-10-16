using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BaseVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseVal()
	{
		WriterPropertyProducer.ResolveStub();
		ViewSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewSingleton()
	{
	}
}
