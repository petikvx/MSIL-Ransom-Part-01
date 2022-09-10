using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal abstract class AsyncParams
{
	private RpcAsyncResult m_asyncResult;

	public RpcAsyncResult AsyncResult => m_asyncResult;

	protected AsyncParams(ClientRequest request, string opType, SafeWaitHandle externEvent)
	{
		m_asyncResult = new RpcAsyncResult(request, opType, externEvent);
	}
}
