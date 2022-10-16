using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CompareStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareStrategy()
	{
	}
}
