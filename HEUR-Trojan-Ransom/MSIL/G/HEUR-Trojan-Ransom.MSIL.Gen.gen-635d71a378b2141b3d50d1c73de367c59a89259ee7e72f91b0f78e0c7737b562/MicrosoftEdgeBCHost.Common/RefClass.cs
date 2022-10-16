using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RefClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefClass()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceInterceptor()
	{
	}
}
