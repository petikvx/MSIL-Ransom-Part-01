using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RecordDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralToken()
	{
	}
}
