using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateAccount()
	{
	}
}
