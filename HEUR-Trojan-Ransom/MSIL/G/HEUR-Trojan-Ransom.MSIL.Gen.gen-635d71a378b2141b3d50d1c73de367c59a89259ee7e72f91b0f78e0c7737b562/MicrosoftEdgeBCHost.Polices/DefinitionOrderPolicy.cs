using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DefinitionOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralObject()
	{
	}
}
