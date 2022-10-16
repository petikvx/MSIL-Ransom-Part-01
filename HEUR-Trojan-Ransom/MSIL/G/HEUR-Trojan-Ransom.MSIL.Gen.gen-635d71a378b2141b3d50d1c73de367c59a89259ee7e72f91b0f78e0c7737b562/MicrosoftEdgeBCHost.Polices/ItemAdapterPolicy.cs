using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ItemAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralPolicy()
	{
	}
}
