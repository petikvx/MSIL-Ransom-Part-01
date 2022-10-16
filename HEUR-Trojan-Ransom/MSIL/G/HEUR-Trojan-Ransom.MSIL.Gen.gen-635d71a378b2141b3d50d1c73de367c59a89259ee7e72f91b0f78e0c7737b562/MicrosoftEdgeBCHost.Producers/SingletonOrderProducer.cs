using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SingletonOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceHelper()
	{
	}
}
