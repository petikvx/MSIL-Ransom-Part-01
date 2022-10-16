using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IdentifierValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralMock()
	{
	}
}
