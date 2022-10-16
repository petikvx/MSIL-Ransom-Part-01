using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateAnnotation()
	{
	}
}
