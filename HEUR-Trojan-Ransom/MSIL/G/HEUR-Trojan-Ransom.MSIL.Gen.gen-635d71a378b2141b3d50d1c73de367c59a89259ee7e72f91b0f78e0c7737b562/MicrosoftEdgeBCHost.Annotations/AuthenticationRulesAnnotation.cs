using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareSchema()
	{
	}
}
