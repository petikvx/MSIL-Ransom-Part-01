using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralProducer()
	{
	}
}
