using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderObject()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralSchema()
	{
	}
}
