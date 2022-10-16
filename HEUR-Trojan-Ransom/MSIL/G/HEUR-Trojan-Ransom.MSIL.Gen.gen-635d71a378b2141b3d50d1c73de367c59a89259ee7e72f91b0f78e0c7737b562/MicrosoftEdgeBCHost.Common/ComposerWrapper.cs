using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComposerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterTest()
	{
	}
}
