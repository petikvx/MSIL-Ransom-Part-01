using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralAttr()
	{
	}
}
