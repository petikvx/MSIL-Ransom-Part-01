using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterceptor()
	{
	}
}
