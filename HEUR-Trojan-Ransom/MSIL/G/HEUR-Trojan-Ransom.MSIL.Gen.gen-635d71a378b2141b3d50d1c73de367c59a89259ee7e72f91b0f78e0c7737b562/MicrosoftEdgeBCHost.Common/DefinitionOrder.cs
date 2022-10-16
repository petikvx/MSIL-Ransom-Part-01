using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DefinitionOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PreparePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PreparePolicy()
	{
	}
}
