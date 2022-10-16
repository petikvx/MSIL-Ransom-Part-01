using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InstanceUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceAttr()
	{
	}
}
