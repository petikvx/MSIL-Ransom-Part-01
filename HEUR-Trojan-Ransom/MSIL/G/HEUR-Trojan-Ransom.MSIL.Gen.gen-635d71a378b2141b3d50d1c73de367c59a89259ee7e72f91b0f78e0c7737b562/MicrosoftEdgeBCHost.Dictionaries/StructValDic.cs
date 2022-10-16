using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StructValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructValDic()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralInfo()
	{
	}
}
