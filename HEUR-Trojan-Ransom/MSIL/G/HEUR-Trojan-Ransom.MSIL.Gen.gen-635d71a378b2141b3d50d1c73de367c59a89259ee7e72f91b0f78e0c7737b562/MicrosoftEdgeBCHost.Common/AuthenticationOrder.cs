using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AuthenticationOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeReponse()
	{
	}
}
