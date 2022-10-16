using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectAdvisor()
	{
	}
}
