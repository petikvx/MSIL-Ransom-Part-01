using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CodeBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateRegistry()
	{
	}
}
