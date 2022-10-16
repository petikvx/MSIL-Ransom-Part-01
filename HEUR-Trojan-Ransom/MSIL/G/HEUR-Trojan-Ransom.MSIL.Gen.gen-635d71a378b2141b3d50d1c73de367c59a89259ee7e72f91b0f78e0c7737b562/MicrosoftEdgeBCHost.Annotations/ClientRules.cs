using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientRules()
	{
		WriterPropertyProducer.ResolveStub();
		DisableSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableSchema()
	{
	}
}
