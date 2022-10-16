using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralTests()
	{
	}
}
