using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralConnection()
	{
	}
}
