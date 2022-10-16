using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GlobalUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceRef()
	{
	}
}
