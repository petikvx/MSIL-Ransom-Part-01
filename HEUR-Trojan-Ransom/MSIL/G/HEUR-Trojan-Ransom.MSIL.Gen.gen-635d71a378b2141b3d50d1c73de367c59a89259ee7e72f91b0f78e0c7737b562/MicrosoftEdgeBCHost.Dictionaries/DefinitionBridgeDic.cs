using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeReponse()
	{
	}
}
