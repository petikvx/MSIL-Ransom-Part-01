using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AuthenticationFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceCode()
	{
	}
}
