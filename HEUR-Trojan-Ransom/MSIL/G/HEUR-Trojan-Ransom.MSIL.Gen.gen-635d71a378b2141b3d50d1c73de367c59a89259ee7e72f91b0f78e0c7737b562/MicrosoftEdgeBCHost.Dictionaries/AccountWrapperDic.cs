using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertParam()
	{
	}
}
