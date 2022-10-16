using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Item
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Item()
	{
		WriterPropertyProducer.ResolveStub();
		ViewProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewProccesor()
	{
	}
}
