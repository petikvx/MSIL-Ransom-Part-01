using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyAuthentication()
	{
	}
}
