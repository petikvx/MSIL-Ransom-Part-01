using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DatabaseClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseClass()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceInterceptor()
	{
	}
}
