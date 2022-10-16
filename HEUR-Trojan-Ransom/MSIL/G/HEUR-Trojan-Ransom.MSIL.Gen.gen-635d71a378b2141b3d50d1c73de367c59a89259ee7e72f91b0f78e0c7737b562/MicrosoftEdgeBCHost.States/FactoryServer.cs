using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FactoryServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryServer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralClient()
	{
	}
}
