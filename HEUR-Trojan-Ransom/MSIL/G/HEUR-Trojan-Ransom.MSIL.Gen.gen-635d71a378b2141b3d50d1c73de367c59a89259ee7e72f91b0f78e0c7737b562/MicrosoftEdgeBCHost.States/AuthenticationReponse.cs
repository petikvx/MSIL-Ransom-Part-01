using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AuthenticationReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationReponse()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceMerchant()
	{
	}
}
