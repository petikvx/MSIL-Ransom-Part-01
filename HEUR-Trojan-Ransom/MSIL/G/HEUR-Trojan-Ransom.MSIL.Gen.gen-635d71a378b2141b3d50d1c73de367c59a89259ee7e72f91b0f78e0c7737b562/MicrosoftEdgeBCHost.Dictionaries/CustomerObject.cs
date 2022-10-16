using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerObject()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralComparator()
	{
	}
}
