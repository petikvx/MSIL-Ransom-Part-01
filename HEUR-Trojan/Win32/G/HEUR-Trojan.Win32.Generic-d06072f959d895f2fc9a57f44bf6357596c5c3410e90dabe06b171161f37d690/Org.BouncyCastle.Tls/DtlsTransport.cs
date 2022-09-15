using System;
using System.IO;
using System.Net.Sockets;

namespace Org.BouncyCastle.Tls;

public class DtlsTransport : DatagramReceiver, DatagramSender, DatagramTransport, TlsCloseable
{
	private readonly DtlsRecordLayer m_recordLayer;

	internal DtlsTransport(DtlsRecordLayer recordLayer)
	{
		m_recordLayer = recordLayer;
	}

	public virtual int GetReceiveLimit()
	{
		return m_recordLayer.GetReceiveLimit();
	}

	public virtual int GetSendLimit()
	{
		return m_recordLayer.GetSendLimit();
	}

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (off >= 0 && off < buf.Length)
		{
			if (len >= 0 && len <= buf.Length - off)
			{
				if (waitMillis < 0)
				{
					throw new ArgumentException("cannot be negative", "waitMillis");
				}
				try
				{
					return m_recordLayer.Receive(buf, off, len, waitMillis);
				}
				catch (TlsFatalAlert tlsFatalAlert)
				{
					m_recordLayer.Fail(tlsFatalAlert.AlertDescription);
					throw tlsFatalAlert;
				}
				catch (TlsTimeoutException ex)
				{
					throw ex;
				}
				catch (SocketException ex2)
				{
					if (TlsUtilities.IsTimeout(ex2))
					{
						throw ex2;
					}
					m_recordLayer.Fail(80);
					throw new TlsFatalAlert(80, ex2);
				}
				catch (IOException ex3)
				{
					m_recordLayer.Fail(80);
					throw ex3;
				}
				catch (Exception alertCause)
				{
					m_recordLayer.Fail(80);
					throw new TlsFatalAlert(80, alertCause);
				}
			}
			throw new ArgumentException("invalid length: " + len, "len");
		}
		throw new ArgumentException("invalid offset: " + off, "off");
	}

	public virtual void Send(byte[] buf, int off, int len)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (off >= 0 && off < buf.Length)
		{
			if (len >= 0 && len <= buf.Length - off)
			{
				try
				{
					m_recordLayer.Send(buf, off, len);
					return;
				}
				catch (TlsFatalAlert tlsFatalAlert)
				{
					m_recordLayer.Fail(tlsFatalAlert.AlertDescription);
					throw tlsFatalAlert;
				}
				catch (TlsTimeoutException ex)
				{
					throw ex;
				}
				catch (SocketException ex2)
				{
					if (TlsUtilities.IsTimeout(ex2))
					{
						throw ex2;
					}
					m_recordLayer.Fail(80);
					throw new TlsFatalAlert(80, ex2);
				}
				catch (IOException ex3)
				{
					m_recordLayer.Fail(80);
					throw ex3;
				}
				catch (Exception alertCause)
				{
					m_recordLayer.Fail(80);
					throw new TlsFatalAlert(80, alertCause);
				}
			}
			throw new ArgumentException("invalid length: " + len, "len");
		}
		throw new ArgumentException("invalid offset: " + off, "off");
	}

	public virtual void Close()
	{
		m_recordLayer.Close();
	}
}
