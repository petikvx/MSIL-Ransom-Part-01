using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttributeVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeVal()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyRepository()
	{
	}
}
