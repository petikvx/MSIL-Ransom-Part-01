using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralFactory()
	{
	}
}
