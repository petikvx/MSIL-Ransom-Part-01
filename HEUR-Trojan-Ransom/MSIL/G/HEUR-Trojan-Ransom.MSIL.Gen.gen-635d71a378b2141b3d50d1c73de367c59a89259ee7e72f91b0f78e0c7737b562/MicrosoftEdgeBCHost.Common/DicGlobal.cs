using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceParams()
	{
	}
}
