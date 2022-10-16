using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeAuthentication()
	{
	}
}
