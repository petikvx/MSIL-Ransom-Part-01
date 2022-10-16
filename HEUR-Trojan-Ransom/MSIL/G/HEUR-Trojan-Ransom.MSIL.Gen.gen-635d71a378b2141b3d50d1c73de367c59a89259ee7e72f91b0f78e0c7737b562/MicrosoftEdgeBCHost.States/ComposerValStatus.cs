using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralProxy()
	{
	}
}
