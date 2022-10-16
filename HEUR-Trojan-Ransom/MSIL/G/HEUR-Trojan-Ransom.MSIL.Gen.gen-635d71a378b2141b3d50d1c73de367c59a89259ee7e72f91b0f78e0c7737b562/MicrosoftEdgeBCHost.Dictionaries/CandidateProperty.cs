using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CandidateProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceTest()
	{
	}
}
