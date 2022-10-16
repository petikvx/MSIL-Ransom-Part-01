using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralParams()
	{
	}
}
