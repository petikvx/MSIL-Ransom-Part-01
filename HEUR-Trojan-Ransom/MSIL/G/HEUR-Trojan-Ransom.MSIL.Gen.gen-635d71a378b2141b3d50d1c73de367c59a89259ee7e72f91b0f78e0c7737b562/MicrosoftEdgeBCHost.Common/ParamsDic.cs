using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsDic()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralInfo()
	{
	}
}
