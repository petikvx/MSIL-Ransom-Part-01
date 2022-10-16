using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralAccount()
	{
	}
}
