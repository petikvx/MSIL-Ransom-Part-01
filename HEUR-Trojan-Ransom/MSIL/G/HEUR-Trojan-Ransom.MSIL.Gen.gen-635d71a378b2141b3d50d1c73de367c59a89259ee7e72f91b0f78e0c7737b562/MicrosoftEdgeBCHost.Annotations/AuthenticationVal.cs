using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationVal()
	{
		WriterPropertyProducer.ResolveStub();
		CalculatePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculatePredicate()
	{
	}
}
