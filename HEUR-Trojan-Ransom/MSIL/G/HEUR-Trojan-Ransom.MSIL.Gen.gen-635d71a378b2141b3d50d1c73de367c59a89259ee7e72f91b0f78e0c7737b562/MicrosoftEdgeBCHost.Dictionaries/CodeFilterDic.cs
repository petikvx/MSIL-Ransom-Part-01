using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CodeFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralProccesor()
	{
	}
}
