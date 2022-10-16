using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralSingleton()
	{
	}
}
