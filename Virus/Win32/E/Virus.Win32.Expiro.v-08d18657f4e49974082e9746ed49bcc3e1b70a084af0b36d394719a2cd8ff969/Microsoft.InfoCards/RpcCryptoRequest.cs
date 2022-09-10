using System;
using System.ComponentModel;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class RpcCryptoRequest
{
	private RpcCryptoContext m_context;

	public abstract string Name { get; }

	protected RpcCryptoRequest(RpcCryptoContext context)
	{
		m_context = context;
	}

	public void Process()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		MemoryStream memoryStream = new MemoryStream();
		MarshalOutArgs(memoryStream);
		byte[] buffer = memoryStream.GetBuffer();
		byte[] array = null;
		try
		{
			array = NativeMcppMethods.RpcCryptoDispatchRequest(m_context.InterfaceHandle, m_context.ContextKey, Name, buffer, 0, Convert.ToInt32(memoryStream.Length));
		}
		catch (Win32Exception ex)
		{
			if (ex.NativeErrorCode == -2146434962)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException((string)null, (Exception)ex));
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(null, ex));
		}
		memoryStream = new MemoryStream(array);
		MarshalReturnArgs(memoryStream);
	}

	protected abstract void MarshalOutArgs(Stream stream);

	protected abstract void MarshalReturnArgs(Stream stream);
}
