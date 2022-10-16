using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryUtils()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceAttr()
	{
	}
}
