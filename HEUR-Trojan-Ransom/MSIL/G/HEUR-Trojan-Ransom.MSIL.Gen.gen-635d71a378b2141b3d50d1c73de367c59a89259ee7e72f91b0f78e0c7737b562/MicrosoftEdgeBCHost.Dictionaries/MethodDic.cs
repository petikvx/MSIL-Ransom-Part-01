using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MethodDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralAccount()
	{
	}
}
