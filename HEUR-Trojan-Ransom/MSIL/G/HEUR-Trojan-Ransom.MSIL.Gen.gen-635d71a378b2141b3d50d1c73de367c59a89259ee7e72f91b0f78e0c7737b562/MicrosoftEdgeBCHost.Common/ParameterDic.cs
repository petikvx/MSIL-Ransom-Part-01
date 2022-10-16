using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParameterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralAccount()
	{
	}
}
