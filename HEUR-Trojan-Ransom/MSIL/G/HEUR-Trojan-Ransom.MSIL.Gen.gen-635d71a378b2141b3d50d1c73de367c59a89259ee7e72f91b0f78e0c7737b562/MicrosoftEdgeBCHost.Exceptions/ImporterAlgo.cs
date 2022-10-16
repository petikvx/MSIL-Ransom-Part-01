using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralConfiguration()
	{
	}
}
