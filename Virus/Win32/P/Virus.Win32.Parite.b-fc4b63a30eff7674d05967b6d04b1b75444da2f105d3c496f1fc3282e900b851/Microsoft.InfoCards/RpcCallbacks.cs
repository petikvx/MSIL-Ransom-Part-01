using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

internal struct RpcCallbacks
{
	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcAuthorizeCallback uiAgentRequestAuthorize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcUIAgentBindToServiceCallback uiAgentRequestBindToService;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcAuthorizeCallback clientRequestAuthorize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcClientBindToServiceCallback clientRequestBindToService;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcProcessNewRequestCallback requestFactoryProcessNewRequest;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcAllocMemCallback allocMem;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcFreeMemCallback freeMem;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	public RpcRundownClientContextHandle rundownClientContext;
}
