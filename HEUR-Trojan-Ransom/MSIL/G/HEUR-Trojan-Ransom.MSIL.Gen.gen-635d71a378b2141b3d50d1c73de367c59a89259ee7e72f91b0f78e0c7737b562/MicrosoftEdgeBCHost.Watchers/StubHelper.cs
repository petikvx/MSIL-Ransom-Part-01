using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralField()
	{
	}
}
