using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrototypeFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartTests()
	{
	}
}
