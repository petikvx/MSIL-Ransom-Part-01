using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FactoryReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralMethod()
	{
	}
}
