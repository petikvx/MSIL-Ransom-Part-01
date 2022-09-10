using System;
using System.ComponentModel;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RpcCryptoContext : IDisposable
{
	private string m_portName;

	private string m_contextKey;

	private IntPtr m_idlHandle;

	private object m_syncRoot;

	private bool m_open;

	private bool m_disposed;

	public string ContextKey => m_contextKey;

	public IntPtr InterfaceHandle => m_idlHandle;

	public bool IsOpen => m_open;

	public RpcCryptoContext(string portName, string contextKey)
	{
		m_portName = portName;
		m_contextKey = contextKey;
		m_syncRoot = new object();
		m_disposed = false;
	}

	~RpcCryptoContext()
	{
		if (!m_disposed)
		{
			((IDisposable)this).Dispose();
		}
	}

	public void Open()
	{
		ThrowIfDisposed();
		if (!m_open)
		{
			try
			{
				m_idlHandle = NativeMcppMethods.RpcCryptoOpen(m_portName);
			}
			catch (Win32Exception inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(null, inner));
			}
			m_open = true;
		}
	}

	public void Close()
	{
		if (m_open)
		{
			try
			{
				NativeMcppMethods.RpcCryptoClose(m_idlHandle, m_contextKey);
			}
			catch (Win32Exception inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(null, inner));
			}
			m_idlHandle = IntPtr.Zero;
			m_open = false;
		}
	}

	void IDisposable.Dispose()
	{
		if (m_disposed)
		{
			return;
		}
		lock (m_syncRoot)
		{
			if (!m_disposed)
			{
				m_disposed = true;
				try
				{
					Close();
				}
				catch (CommunicationException ex)
				{
					_ = ((Exception)(object)ex).Message;
				}
				m_portName = null;
				m_contextKey = null;
				m_idlHandle = IntPtr.Zero;
				GC.SuppressFinalize(this);
			}
		}
	}

	private void ThrowIfDisposed()
	{
		if (m_disposed)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("RpcCryptoContext"));
		}
	}
}
