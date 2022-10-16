using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralCustomer()
	{
	}
}
