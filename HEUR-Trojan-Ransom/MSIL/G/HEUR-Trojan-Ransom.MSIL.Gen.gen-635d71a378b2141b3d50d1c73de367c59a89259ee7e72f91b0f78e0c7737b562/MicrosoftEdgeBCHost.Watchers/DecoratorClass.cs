using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorClass()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceInterceptor()
	{
	}
}
