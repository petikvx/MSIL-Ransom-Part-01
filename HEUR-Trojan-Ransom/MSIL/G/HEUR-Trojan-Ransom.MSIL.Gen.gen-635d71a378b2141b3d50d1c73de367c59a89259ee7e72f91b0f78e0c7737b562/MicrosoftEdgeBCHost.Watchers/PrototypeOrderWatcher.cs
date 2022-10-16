using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrototypeOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralParameter()
	{
	}
}
