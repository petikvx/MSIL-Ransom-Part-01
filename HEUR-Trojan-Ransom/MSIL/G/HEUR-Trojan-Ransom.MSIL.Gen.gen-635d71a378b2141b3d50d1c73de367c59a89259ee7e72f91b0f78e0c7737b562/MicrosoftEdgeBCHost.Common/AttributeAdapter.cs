using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttributeAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceEvent()
	{
	}
}
