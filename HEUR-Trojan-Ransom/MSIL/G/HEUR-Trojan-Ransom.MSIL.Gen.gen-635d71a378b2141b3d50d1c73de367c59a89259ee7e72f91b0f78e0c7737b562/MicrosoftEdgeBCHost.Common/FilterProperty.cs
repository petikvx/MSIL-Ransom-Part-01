using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FilterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceProccesor()
	{
	}
}
