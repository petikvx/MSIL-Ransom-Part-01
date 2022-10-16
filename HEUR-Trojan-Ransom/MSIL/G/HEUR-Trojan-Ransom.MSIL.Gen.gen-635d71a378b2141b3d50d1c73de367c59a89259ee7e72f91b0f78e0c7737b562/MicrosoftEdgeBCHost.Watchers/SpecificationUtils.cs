using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfacePrototype()
	{
	}
}
