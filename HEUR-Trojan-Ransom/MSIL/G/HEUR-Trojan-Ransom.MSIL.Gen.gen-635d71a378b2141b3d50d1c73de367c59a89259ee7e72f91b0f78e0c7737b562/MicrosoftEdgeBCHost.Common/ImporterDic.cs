using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ImporterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralDatabase()
	{
	}
}
