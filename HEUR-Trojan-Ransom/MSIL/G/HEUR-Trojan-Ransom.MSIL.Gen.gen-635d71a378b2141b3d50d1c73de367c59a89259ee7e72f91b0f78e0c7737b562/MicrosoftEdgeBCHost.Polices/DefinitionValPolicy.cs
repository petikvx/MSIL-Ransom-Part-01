using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DefinitionValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteReponse()
	{
	}
}
