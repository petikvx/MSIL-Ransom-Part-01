using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapHelper()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralHelper()
	{
	}
}
