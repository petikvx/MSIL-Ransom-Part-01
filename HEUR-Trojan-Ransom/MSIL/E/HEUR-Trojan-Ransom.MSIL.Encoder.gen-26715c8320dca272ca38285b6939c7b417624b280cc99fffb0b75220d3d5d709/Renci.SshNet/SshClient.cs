using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class SshClient : BaseClient
{
	private readonly List<ForwardedPort> _forwardedPorts;

	private bool _isDisposed;

	private Stream _inputStream;

	public IEnumerable<ForwardedPort> ForwardedPorts => _forwardedPorts.AsReadOnly();

	public SshClient(ConnectionInfo connectionInfo)
		: this(connectionInfo, ownsConnectionInfo: false)
	{
	}

	public SshClient(string host, int port, string username, string password)
		: this(new PasswordConnectionInfo(host, port, username, password), ownsConnectionInfo: true)
	{
	}

	public SshClient(string host, string username, string password)
		: this(host, ConnectionInfo.DefaultPort, username, password)
	{
	}

	public SshClient(string host, int port, string username, params PrivateKeyFile[] keyFiles)
		: this(new PrivateKeyConnectionInfo(host, port, username, keyFiles), ownsConnectionInfo: true)
	{
	}

	public SshClient(string host, string username, params PrivateKeyFile[] keyFiles)
		: this(host, ConnectionInfo.DefaultPort, username, keyFiles)
	{
	}

	private SshClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo)
		: this(connectionInfo, ownsConnectionInfo, new ServiceFactory())
	{
	}

	internal SshClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo, IServiceFactory serviceFactory)
		: base(connectionInfo, ownsConnectionInfo, serviceFactory)
	{
		_forwardedPorts = new List<ForwardedPort>();
	}

	protected override void OnDisconnecting()
	{
		base.OnDisconnecting();
		foreach (ForwardedPort forwardedPort in _forwardedPorts)
		{
			forwardedPort.Stop();
		}
	}

	public void AddForwardedPort(ForwardedPort port)
	{
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		EnsureSessionIsOpen();
		AttachForwardedPort(port);
		_forwardedPorts.Add(port);
	}

	public void RemoveForwardedPort(ForwardedPort port)
	{
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		port.Stop();
		DetachForwardedPort(port);
		_forwardedPorts.Remove(port);
	}

	private void AttachForwardedPort(ForwardedPort port)
	{
		if (port.Session != null && port.Session != base.Session)
		{
			throw new InvalidOperationException("Forwarded port is already added to a different client.");
		}
		port.Session = base.Session;
	}

	private static void DetachForwardedPort(ForwardedPort port)
	{
		port.Session = null;
	}

	public SshCommand CreateCommand(string commandText)
	{
		return CreateCommand(commandText, base.ConnectionInfo.Encoding);
	}

	public SshCommand CreateCommand(string commandText, Encoding encoding)
	{
		EnsureSessionIsOpen();
		base.ConnectionInfo.Encoding = encoding;
		return new SshCommand(base.Session, commandText, encoding);
	}

	public SshCommand RunCommand(string commandText)
	{
		SshCommand sshCommand = CreateCommand(commandText);
		sshCommand.Execute();
		return sshCommand;
	}

	public Shell CreateShell(Stream input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes, int bufferSize)
	{
		EnsureSessionIsOpen();
		return new Shell(base.Session, input, output, extendedOutput, terminalName, columns, rows, width, height, terminalModes, bufferSize);
	}

	public Shell CreateShell(Stream input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes)
	{
		return CreateShell(input, output, extendedOutput, terminalName, columns, rows, width, height, terminalModes, 1024);
	}

	public Shell CreateShell(Stream input, Stream output, Stream extendedOutput)
	{
		return CreateShell(input, output, extendedOutput, string.Empty, 0u, 0u, 0u, 0u, null, 1024);
	}

	public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes, int bufferSize)
	{
		_inputStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(_inputStream, encoding);
		streamWriter.Write(input);
		streamWriter.Flush();
		_inputStream.Seek(0L, SeekOrigin.Begin);
		return CreateShell(_inputStream, output, extendedOutput, terminalName, columns, rows, width, height, terminalModes, bufferSize);
	}

	public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes)
	{
		return CreateShell(encoding, input, output, extendedOutput, terminalName, columns, rows, width, height, terminalModes, 1024);
	}

	public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput)
	{
		return CreateShell(encoding, input, output, extendedOutput, string.Empty, 0u, 0u, 0u, 0u, null, 1024);
	}

	public ShellStream CreateShellStream(string terminalName, uint columns, uint rows, uint width, uint height, int bufferSize)
	{
		return CreateShellStream(terminalName, columns, rows, width, height, bufferSize, null);
	}

	public ShellStream CreateShellStream(string terminalName, uint columns, uint rows, uint width, uint height, int bufferSize, IDictionary<TerminalModes, uint> terminalModeValues)
	{
		EnsureSessionIsOpen();
		return base.ServiceFactory.CreateShellStream(base.Session, terminalName, columns, rows, width, height, terminalModeValues, bufferSize);
	}

	protected override void OnDisconnected()
	{
		base.OnDisconnected();
		for (int num = _forwardedPorts.Count - 1; num >= 0; num--)
		{
			DetachForwardedPort(_forwardedPorts[num]);
			_forwardedPorts.RemoveAt(num);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!_isDisposed && disposing)
		{
			if (_inputStream != null)
			{
				_inputStream.Dispose();
				_inputStream = null;
			}
			_isDisposed = true;
		}
	}

	private void EnsureSessionIsOpen()
	{
		if (base.Session == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
	}
}
