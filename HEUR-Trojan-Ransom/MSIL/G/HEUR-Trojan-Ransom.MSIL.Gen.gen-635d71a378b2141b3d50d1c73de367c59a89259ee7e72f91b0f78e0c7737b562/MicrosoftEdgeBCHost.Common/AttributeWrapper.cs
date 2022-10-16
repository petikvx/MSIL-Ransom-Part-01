using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttributeWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeRef()
	{
	}
}
