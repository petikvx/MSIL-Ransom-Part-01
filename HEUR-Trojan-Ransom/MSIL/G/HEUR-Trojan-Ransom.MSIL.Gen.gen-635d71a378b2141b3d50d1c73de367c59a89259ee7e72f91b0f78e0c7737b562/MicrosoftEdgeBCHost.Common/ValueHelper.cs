using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ValueHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueHelper()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralList()
	{
	}
}
