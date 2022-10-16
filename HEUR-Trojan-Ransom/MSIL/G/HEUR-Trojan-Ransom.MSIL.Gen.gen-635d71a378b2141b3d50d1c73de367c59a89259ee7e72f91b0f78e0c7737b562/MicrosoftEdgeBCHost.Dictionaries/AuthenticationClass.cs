using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationClass()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceFilter()
	{
	}
}
