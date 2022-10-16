using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReponseProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseProperty()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceCustomer()
	{
	}
}
