using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AuthenticationAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralOrder()
	{
	}
}
