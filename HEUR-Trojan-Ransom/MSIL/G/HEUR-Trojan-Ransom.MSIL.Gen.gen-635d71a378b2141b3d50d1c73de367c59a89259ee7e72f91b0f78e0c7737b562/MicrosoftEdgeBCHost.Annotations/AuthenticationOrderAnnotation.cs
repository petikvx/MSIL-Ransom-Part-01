using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralReponse()
	{
	}
}
