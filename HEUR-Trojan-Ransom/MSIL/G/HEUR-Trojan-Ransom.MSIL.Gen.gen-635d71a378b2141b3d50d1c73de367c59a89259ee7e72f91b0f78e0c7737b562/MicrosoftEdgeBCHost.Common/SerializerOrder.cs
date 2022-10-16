using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SerializerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareTokenizer()
	{
	}
}
