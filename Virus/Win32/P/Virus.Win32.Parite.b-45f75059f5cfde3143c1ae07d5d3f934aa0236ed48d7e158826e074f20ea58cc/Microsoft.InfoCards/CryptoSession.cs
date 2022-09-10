using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class CryptoSession
{
	private class CryptoSessionDictionary : HandleDictionary<CryptoSession>
	{
	}

	protected enum SessionType
	{
		Asymmetric = 1,
		Symmetric,
		Transfrom,
		Hash
	}

	private const int m_MaxSessionCount = 1073741823;

	public static readonly TimeSpan MaxSessionLifetime = new TimeSpan(1, 0, 0);

	private static CryptoSessionDictionary s_sessionCollection = new CryptoSessionDictionary();

	private static object s_syncRoot = new object();

	private Process m_process;

	private int m_sessionid;

	private EventHandler m_processExitHandler;

	private EventHandler m_serviceStoppingHandler;

	private Timer m_timer;

	private bool m_isDisposed;

	private object m_syncRoot;

	private WindowsIdentity m_identity;

	private DateTime m_expiration;

	private SessionType m_type;

	protected uint ProcessId => (uint)m_process.Id;

	protected Process ProcessObj => m_process;

	protected WindowsIdentity Identity => m_identity;

	protected SecurityIdentifier ClientSid => m_identity.User;

	protected DateTime Expiration => m_expiration;

	protected CryptoSession(Process process, DateTime expiration, WindowsIdentity identity, object key, SessionType type)
	{
		InfoCardTrace.Assert(null != key, "null key passed in to CryptoSession ctor", new object[0]);
		try
		{
			m_process = ProcessMonitor.GetProcessById(process.Id);
		}
		catch (ArgumentException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ProcessExitedException(SR.GetString("ServiceClientProcessExited", new object[1] { process.Id }), inner));
		}
		m_syncRoot = new object();
		m_identity = identity;
		m_expiration = expiration;
		m_type = type;
		lock (s_syncRoot)
		{
			int newHandle;
			try
			{
				newHandle = s_sessionCollection.GetNewHandle();
			}
			catch (IndexOutOfRangeException inner2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ServiceBusyException(SR.GetString("ServiceTooManyCryptoSessions", new object[1] { s_sessionCollection.MaxSize }), inner2));
			}
			bool flag = false;
			try
			{
				m_processExitHandler = OnProcessExit;
				m_process.Exited += m_processExitHandler;
				if (!process.HasExited && !m_process.HasExited)
				{
					TimeSpan timeSpan = expiration - DateTime.UtcNow;
					if (timeSpan > MaxSessionLifetime)
					{
						timeSpan = MaxSessionLifetime;
					}
					m_timer = new Timer(InfoCardTrace.ThunkCallback((TimerCallback)OnTimeout), null, timeSpan, new TimeSpan(0, 0, 0, 0, -1));
					m_serviceStoppingHandler = OnServiceStopping;
					InfoCardService.Stopping += m_serviceStoppingHandler;
					s_sessionCollection[newHandle] = this;
					m_sessionid = newHandle;
					flag = true;
					return;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ProcessExitedException(SR.GetString("ServiceProcessHasExited")));
			}
			finally
			{
				if (!flag)
				{
					s_sessionCollection.Remove(newHandle);
				}
			}
		}
	}

	public void Write(BinaryWriter bwriter)
	{
		bwriter.Write((int)m_type);
		bwriter.Write(m_sessionid);
		bwriter.Write(m_expiration.ToFileTime());
		OnWrite(bwriter);
	}

	private void OnTimeout(object state)
	{
		Dispose();
	}

	private void OnProcessExit(object sender, EventArgs e)
	{
		DisposeAsClient();
	}

	private void OnServiceStopping(object sender, EventArgs e)
	{
		DisposeAsClient();
	}

	private void DisposeAsClient()
	{
		try
		{
			WindowsImpersonationContext val = m_identity.Impersonate();
			try
			{
				Dispose();
			}
			finally
			{
				val.Undo();
			}
		}
		catch (Exception)
		{
			throw;
		}
	}

	protected void ThrowIfDisposed()
	{
		if (m_isDisposed)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("CryptoSession " + m_sessionid));
		}
	}

	protected virtual void OnDispose()
	{
	}

	protected virtual void OnWrite(BinaryWriter bwriter)
	{
	}

	public void Dispose()
	{
		bool flag = false;
		lock (m_syncRoot)
		{
			if (!m_isDisposed)
			{
				m_isDisposed = true;
				flag = true;
				if (m_serviceStoppingHandler != null)
				{
					InfoCardService.Stopping -= m_serviceStoppingHandler;
					m_serviceStoppingHandler = null;
				}
				if (m_process != null)
				{
					if (m_processExitHandler != null)
					{
						m_process.Exited -= m_processExitHandler;
						m_processExitHandler = null;
					}
					m_process = null;
				}
				if (m_timer != null)
				{
					m_timer.Dispose();
					m_timer = null;
				}
				OnDispose();
			}
		}
		if (flag)
		{
			lock (s_syncRoot)
			{
				s_sessionCollection.Remove(m_sessionid);
			}
		}
	}

	public static CryptoSession Create(Process process, DateTime expiration, WindowsIdentity identity, RSACryptoServiceProvider key)
	{
		return new AsymmetricCryptoSession(process, expiration, identity, key);
	}

	public static CryptoSession Create(Process process, DateTime expiration, WindowsIdentity identity, byte[] key)
	{
		return new SymmetricCryptoSession(process, expiration, identity, key);
	}

	public static CryptoSession Find(int sessionId, uint processId, SecurityIdentifier clientSid)
	{
		lock (s_syncRoot)
		{
			if (s_sessionCollection.ContainsHandle(sessionId))
			{
				CryptoSession cryptoSession = s_sessionCollection[sessionId];
				if (cryptoSession.ProcessId != processId)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceUnknownCryptoSessionId")));
				}
				if (cryptoSession.ClientSid != clientSid)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceUnknownCryptoSessionId")));
				}
				return cryptoSession;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceUnknownCryptoSessionId")));
		}
	}
}
