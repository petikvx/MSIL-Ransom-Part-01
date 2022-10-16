using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralAccount()
	{
	}
}
