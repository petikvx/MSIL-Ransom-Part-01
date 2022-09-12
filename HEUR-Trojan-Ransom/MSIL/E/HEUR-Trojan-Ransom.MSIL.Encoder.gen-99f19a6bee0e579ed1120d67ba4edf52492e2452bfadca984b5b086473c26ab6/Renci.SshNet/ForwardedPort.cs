using System;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public abstract class ForwardedPort : IForwardedPort
{
	internal ISession Session { get; set; }

	public abstract bool IsStarted { get; }

	internal event EventHandler Closing;

	event EventHandler IForwardedPort.Closing
	{
		add
		{
			Closing += value;
		}
		remove
		{
			Closing -= value;
		}
	}

	public event EventHandler<ExceptionEventArgs> Exception;

	public event EventHandler<PortForwardEventArgs> RequestReceived;

	public virtual void Start()
	{
		CheckDisposed();
		if (IsStarted)
		{
			throw new InvalidOperationException("Forwarded port is already started.");
		}
		if (Session == null)
		{
			throw new InvalidOperationException("Forwarded port is not added to a client.");
		}
		if (!Session.IsConnected)
		{
			throw new SshConnectionException("Client not connected.");
		}
		Session.ErrorOccured += Session_ErrorOccured;
		StartPort();
	}

	public virtual void Stop()
	{
		if (IsStarted)
		{
			StopPort(Session.ConnectionInfo.Timeout);
		}
	}

	protected abstract void StartPort();

	protected virtual void StopPort(TimeSpan timeout)
	{
		RaiseClosing();
		ISession session = Session;
		if (session != null)
		{
			session.ErrorOccured -= Session_ErrorOccured;
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			ISession session = Session;
			if (session != null)
			{
				StopPort(session.ConnectionInfo.Timeout);
				Session = null;
			}
		}
	}

	protected abstract void CheckDisposed();

	protected void RaiseExceptionEvent(Exception exception)
	{
		this.Exception?.Invoke(this, new ExceptionEventArgs(exception));
	}

	protected void RaiseRequestReceived(string host, uint port)
	{
		this.RequestReceived?.Invoke(this, new PortForwardEventArgs(host, port));
	}

	private void RaiseClosing()
	{
		this.Closing?.Invoke(this, EventArgs.Empty);
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		RaiseExceptionEvent(e.Exception);
	}
}
