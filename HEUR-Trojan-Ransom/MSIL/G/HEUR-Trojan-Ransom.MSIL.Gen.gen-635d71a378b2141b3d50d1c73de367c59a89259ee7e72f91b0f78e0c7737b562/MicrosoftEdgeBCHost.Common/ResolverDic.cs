using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralAccount()
	{
	}
}
