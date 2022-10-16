using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationRules()
	{
		WriterPropertyProducer.ResolveStub();
		CompareTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareTag()
	{
	}
}
