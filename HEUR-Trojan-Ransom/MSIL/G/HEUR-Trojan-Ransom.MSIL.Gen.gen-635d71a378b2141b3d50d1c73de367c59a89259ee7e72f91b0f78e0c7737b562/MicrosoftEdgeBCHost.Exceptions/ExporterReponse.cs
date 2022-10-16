using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralIdentifier()
	{
	}
}
