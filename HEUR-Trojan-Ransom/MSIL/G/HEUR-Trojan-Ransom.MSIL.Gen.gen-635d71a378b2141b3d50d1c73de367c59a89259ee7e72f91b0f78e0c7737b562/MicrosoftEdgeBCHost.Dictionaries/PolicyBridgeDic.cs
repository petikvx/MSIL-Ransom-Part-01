using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PolicyBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineAnnotation()
	{
	}
}
