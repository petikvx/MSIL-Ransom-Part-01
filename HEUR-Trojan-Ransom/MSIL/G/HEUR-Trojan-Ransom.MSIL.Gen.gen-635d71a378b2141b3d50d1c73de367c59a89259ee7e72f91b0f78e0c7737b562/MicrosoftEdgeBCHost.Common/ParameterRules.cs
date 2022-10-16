using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParameterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterRules()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteSchema()
	{
	}
}
