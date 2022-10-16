using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AuthenticationHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationHelper()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralAdvisor()
	{
	}
}
