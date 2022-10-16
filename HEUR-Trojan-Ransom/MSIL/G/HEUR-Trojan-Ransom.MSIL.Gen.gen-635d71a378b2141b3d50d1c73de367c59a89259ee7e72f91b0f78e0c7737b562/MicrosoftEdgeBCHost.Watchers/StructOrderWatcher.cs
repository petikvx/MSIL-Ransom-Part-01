using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralMock()
	{
	}
}
