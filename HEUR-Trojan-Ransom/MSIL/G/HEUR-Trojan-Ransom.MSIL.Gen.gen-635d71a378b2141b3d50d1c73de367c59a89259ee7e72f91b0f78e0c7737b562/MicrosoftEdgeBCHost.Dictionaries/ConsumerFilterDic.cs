using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConsumerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralCustomer()
	{
	}
}
