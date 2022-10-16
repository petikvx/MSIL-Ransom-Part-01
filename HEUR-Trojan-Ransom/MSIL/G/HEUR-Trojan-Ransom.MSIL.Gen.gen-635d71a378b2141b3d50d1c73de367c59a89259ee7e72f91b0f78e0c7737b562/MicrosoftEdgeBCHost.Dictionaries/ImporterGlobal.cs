using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceComparator()
	{
	}
}
