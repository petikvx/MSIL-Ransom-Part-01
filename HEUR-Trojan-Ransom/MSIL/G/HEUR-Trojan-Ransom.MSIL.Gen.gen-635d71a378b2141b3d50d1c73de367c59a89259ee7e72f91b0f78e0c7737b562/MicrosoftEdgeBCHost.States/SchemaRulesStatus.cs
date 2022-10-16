using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SchemaRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceCollection()
	{
	}
}
