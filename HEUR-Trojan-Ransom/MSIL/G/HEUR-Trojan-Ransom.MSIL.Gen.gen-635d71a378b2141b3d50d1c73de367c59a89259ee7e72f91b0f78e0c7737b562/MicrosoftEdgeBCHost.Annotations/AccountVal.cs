using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AccountVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountVal()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRequest()
	{
	}
}
