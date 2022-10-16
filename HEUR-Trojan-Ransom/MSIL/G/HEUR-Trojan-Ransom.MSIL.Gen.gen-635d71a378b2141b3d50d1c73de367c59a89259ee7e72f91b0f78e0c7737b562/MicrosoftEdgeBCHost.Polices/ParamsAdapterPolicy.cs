using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralStrategy()
	{
	}
}
