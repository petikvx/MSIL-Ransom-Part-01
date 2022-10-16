using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceSchema()
	{
	}
}
