using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcProperty()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceRole()
	{
	}
}
