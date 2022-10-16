using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SerializerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerObject()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralOrder()
	{
	}
}
