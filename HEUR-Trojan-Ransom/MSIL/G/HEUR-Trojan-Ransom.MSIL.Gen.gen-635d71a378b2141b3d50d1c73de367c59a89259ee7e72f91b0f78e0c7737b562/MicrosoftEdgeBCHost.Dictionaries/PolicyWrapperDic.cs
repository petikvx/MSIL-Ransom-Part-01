using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PolicyWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitCustomer()
	{
	}
}
