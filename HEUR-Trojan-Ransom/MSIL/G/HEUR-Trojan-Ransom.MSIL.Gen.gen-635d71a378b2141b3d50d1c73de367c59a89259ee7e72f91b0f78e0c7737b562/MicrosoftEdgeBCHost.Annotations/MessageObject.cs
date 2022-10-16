using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageObject()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralSchema()
	{
	}
}
