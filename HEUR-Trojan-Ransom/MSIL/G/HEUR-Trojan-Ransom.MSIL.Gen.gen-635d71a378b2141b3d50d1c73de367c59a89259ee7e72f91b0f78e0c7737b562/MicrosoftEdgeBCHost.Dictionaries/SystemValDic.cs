using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SystemValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralAnnotation()
	{
	}
}
