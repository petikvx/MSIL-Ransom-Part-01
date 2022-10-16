using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WatcherValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceCreator()
	{
	}
}
