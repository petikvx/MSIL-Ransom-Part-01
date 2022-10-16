using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DefinitionBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionBridge()
	{
		WriterPropertyProducer.ResolveStub();
		EnableTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableTests()
	{
	}
}
