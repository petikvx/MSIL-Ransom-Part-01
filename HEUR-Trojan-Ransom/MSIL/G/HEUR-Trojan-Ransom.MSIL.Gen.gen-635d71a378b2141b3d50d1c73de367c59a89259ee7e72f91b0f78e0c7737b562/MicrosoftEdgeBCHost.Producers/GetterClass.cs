using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GetterClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterClass()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceInterceptor()
	{
	}
}
