using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttrOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceInterceptor()
	{
	}
}
