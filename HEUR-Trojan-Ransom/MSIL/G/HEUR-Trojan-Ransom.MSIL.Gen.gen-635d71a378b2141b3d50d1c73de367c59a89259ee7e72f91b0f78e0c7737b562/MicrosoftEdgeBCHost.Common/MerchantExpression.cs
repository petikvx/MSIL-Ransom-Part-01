using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralRef()
	{
	}
}
