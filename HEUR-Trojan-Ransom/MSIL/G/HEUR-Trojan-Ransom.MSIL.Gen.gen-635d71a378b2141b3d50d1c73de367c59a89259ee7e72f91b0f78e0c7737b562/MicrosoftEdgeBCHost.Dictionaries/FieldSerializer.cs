using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FieldSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralDescriptor()
	{
	}
}
