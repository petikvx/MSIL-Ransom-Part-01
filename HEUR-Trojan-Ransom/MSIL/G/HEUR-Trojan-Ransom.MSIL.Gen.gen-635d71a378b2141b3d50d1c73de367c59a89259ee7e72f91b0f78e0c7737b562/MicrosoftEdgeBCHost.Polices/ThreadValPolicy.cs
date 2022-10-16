using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageMerchant()
	{
	}
}
