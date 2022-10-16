using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralDescriptor()
	{
	}
}
