using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExceptionValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionValDic()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralExpression()
	{
	}
}
