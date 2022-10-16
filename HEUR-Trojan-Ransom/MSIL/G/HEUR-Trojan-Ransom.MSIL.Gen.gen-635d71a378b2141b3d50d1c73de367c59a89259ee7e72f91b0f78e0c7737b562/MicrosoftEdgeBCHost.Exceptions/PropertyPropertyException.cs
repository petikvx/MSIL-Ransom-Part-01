using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PropertyPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralAttr()
	{
	}
}
