using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class GetterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralReg()
	{
	}
}
