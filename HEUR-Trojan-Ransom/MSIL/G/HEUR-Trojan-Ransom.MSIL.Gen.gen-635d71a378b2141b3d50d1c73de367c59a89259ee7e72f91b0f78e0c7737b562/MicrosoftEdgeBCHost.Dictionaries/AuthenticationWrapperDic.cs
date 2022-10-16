using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchImporter()
	{
	}
}
