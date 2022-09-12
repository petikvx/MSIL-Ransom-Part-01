using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class ShellStream : Stream
{
	private const string CrLf = "\r\n";

	private readonly ISession _session;

	private readonly Encoding _encoding;

	private readonly int _bufferSize;

	private readonly Queue<byte> _incoming;

	private readonly Queue<byte> _outgoing;

	private IChannelSession _channel;

	private AutoResetEvent _dataReceived = new AutoResetEvent(initialState: false);

	private bool _isDisposed;

	public bool DataAvailable
	{
		get
		{
			lock (_incoming)
			{
				return _incoming.Count > 0;
			}
		}
	}

	internal int BufferSize => _bufferSize;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length
	{
		get
		{
			lock (_incoming)
			{
				return _incoming.Count;
			}
		}
	}

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public event EventHandler<ShellDataEventArgs> DataReceived;

	public event EventHandler<ExceptionEventArgs> ErrorOccurred;

	internal ShellStream(ISession session, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues, int bufferSize)
	{
		_encoding = session.ConnectionInfo.Encoding;
		_session = session;
		_bufferSize = bufferSize;
		_incoming = new Queue<byte>();
		_outgoing = new Queue<byte>();
		_channel = _session.CreateChannelSession();
		_channel.DataReceived += Channel_DataReceived;
		_channel.Closed += Channel_Closed;
		_session.Disconnected += Session_Disconnected;
		_session.ErrorOccured += Session_ErrorOccured;
		try
		{
			_channel.Open();
			if (!_channel.SendPseudoTerminalRequest(terminalName, columns, rows, width, height, terminalModeValues))
			{
				throw new SshException("The pseudo-terminal request was not accepted by the server. Consult the server log for more information.");
			}
			if (!_channel.SendShellRequest())
			{
				throw new SshException("The request to start a shell was not accepted by the server. Consult the server log for more information.");
			}
		}
		catch
		{
			UnsubscribeFromSessionEvents(session);
			_channel.Dispose();
			throw;
		}
	}

	public override void Flush()
	{
		if (_channel == null)
		{
			throw new ObjectDisposedException("ShellStream");
		}
		if (_outgoing.Count > 0)
		{
			_channel.SendData(_outgoing.ToArray());
			_outgoing.Clear();
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		lock (_incoming)
		{
			while (true)
			{
				if (num < count)
				{
					if (_incoming.Count > 0)
					{
						buffer[offset + num] = _incoming.Dequeue();
						num++;
						continue;
					}
					break;
				}
				return num;
			}
			return num;
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		byte[] array = buffer.Take(offset, count);
		foreach (byte item in array)
		{
			if (_outgoing.Count == _bufferSize)
			{
				Flush();
			}
			_outgoing.Enqueue(item);
		}
	}

	public void Expect(params ExpectAction[] expectActions)
	{
		Expect(TimeSpan.Zero, expectActions);
	}

	public void Expect(TimeSpan timeout, params ExpectAction[] expectActions)
	{
		bool flag = false;
		string text = string.Empty;
		do
		{
			lock (_incoming)
			{
				if (_incoming.Count > 0)
				{
					text = _encoding.GetString(_incoming.ToArray(), 0, _incoming.Count);
				}
				if (text.Length > 0)
				{
					foreach (ExpectAction expectAction in expectActions)
					{
						Match match = expectAction.Expect.Match(text);
						if (!match.Success)
						{
							continue;
						}
						string obj = text.Substring(0, match.Index + match.Length);
						for (int j = 0; j < match.Index + match.Length; j++)
						{
							if (_incoming.Count <= 0)
							{
								break;
							}
							_incoming.Dequeue();
						}
						expectAction.Action(obj);
						flag = true;
					}
				}
			}
			if (flag)
			{
				continue;
			}
			if (timeout.Ticks > 0L)
			{
				if (!_dataReceived.WaitOne(timeout))
				{
					break;
				}
			}
			else
			{
				_dataReceived.WaitOne();
			}
		}
		while (!flag);
	}

	public IAsyncResult BeginExpect(params ExpectAction[] expectActions)
	{
		return BeginExpect(TimeSpan.Zero, null, null, expectActions);
	}

	public IAsyncResult BeginExpect(AsyncCallback callback, params ExpectAction[] expectActions)
	{
		return BeginExpect(TimeSpan.Zero, callback, null, expectActions);
	}

	public IAsyncResult BeginExpect(AsyncCallback callback, object state, params ExpectAction[] expectActions)
	{
		return BeginExpect(TimeSpan.Zero, callback, state, expectActions);
	}

	public IAsyncResult BeginExpect(TimeSpan timeout, AsyncCallback callback, object state, params ExpectAction[] expectActions)
	{
		string text = string.Empty;
		ExpectAsyncResult asyncResult = new ExpectAsyncResult(callback, state);
		ThreadAbstraction.ExecuteThread(delegate
		{
			string text2 = null;
			try
			{
				while (true)
				{
					lock (_incoming)
					{
						if (_incoming.Count > 0)
						{
							text = _encoding.GetString(_incoming.ToArray(), 0, _incoming.Count);
						}
						if (text.Length > 0)
						{
							ExpectAction[] array = expectActions;
							foreach (ExpectAction expectAction in array)
							{
								Match match = expectAction.Expect.Match(text);
								if (match.Success)
								{
									string text3 = text.Substring(0, match.Index + match.Length);
									for (int j = 0; j < match.Index + match.Length; j++)
									{
										if (_incoming.Count <= 0)
										{
											break;
										}
										_incoming.Dequeue();
									}
									expectAction.Action(text3);
									if (callback != null)
									{
										callback(asyncResult);
									}
									text2 = text3;
								}
							}
						}
					}
					if (text2 != null)
					{
						break;
					}
					if (timeout.Ticks > 0L)
					{
						if (!_dataReceived.WaitOne(timeout))
						{
							if (callback != null)
							{
								callback(asyncResult);
							}
							break;
						}
					}
					else
					{
						_dataReceived.WaitOne();
					}
				}
				asyncResult.SetAsCompleted(text2, completedSynchronously: true);
			}
			catch (Exception exception)
			{
				asyncResult.SetAsCompleted(exception, completedSynchronously: true);
			}
		});
		return asyncResult;
	}

	public string EndExpect(IAsyncResult asyncResult)
	{
		if (!(asyncResult is ExpectAsyncResult expectAsyncResult) || expectAsyncResult.EndInvokeCalled)
		{
			throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or EndExecute was called multiple times with the same IAsyncResult.");
		}
		return expectAsyncResult.EndInvoke();
	}

	public string Expect(string text)
	{
		return Expect(new Regex(Regex.Escape(text)), Session.InfiniteTimeSpan);
	}

	public string Expect(string text, TimeSpan timeout)
	{
		return Expect(new Regex(Regex.Escape(text)), timeout);
	}

	public string Expect(Regex regex)
	{
		return Expect(regex, TimeSpan.Zero);
	}

	public string Expect(Regex regex, TimeSpan timeout)
	{
		string text = string.Empty;
		while (true)
		{
			lock (_incoming)
			{
				if (_incoming.Count > 0)
				{
					text = _encoding.GetString(_incoming.ToArray(), 0, _incoming.Count);
				}
				Match match = regex.Match(text);
				if (match.Success)
				{
					int num = 0;
					while (true)
					{
						if (num < match.Index + match.Length)
						{
							if (_incoming.Count > 0)
							{
								_incoming.Dequeue();
								num++;
								continue;
							}
							break;
						}
						return text;
					}
					return text;
				}
			}
			if (timeout.Ticks > 0L)
			{
				if (!_dataReceived.WaitOne(timeout))
				{
					break;
				}
			}
			else
			{
				_dataReceived.WaitOne();
			}
		}
		return null;
	}

	public string ReadLine()
	{
		return ReadLine(TimeSpan.Zero);
	}

	public string ReadLine(TimeSpan timeout)
	{
		string text = string.Empty;
		while (true)
		{
			lock (_incoming)
			{
				if (_incoming.Count > 0)
				{
					text = _encoding.GetString(_incoming.ToArray(), 0, _incoming.Count);
				}
				int num = text.IndexOf("\r\n", StringComparison.Ordinal);
				if (num >= 0)
				{
					text = text.Substring(0, num);
					int byteCount = _encoding.GetByteCount(text + "\r\n");
					for (int i = 0; i < byteCount; i++)
					{
						_incoming.Dequeue();
					}
					return text;
				}
			}
			if (timeout.Ticks > 0L)
			{
				if (!_dataReceived.WaitOne(timeout))
				{
					break;
				}
			}
			else
			{
				_dataReceived.WaitOne();
			}
		}
		return null;
	}

	public string Read()
	{
		lock (_incoming)
		{
			string @string = _encoding.GetString(_incoming.ToArray(), 0, _incoming.Count);
			_incoming.Clear();
			return @string;
		}
	}

	public void Write(string text)
	{
		if (text != null)
		{
			if (_channel == null)
			{
				throw new ObjectDisposedException("ShellStream");
			}
			byte[] bytes = _encoding.GetBytes(text);
			_channel.SendData(bytes);
		}
	}

	public void WriteLine(string line)
	{
		Write(line + "\r");
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (_isDisposed)
		{
			return;
		}
		if (disposing)
		{
			UnsubscribeFromSessionEvents(_session);
			if (_channel != null)
			{
				_channel.DataReceived -= Channel_DataReceived;
				_channel.Closed -= Channel_Closed;
				_channel.Dispose();
				_channel = null;
			}
			if (_dataReceived != null)
			{
				_dataReceived.Dispose();
				_dataReceived = null;
			}
			_isDisposed = true;
		}
		else
		{
			UnsubscribeFromSessionEvents(_session);
		}
	}

	private void UnsubscribeFromSessionEvents(ISession session)
	{
		if (session != null)
		{
			session.Disconnected -= Session_Disconnected;
			session.ErrorOccured -= Session_ErrorOccured;
		}
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		OnRaiseError(e);
	}

	private void Session_Disconnected(object sender, EventArgs e)
	{
		if (_channel != null)
		{
			_channel.Dispose();
		}
	}

	private void Channel_Closed(object sender, ChannelEventArgs e)
	{
		Dispose();
	}

	private void Channel_DataReceived(object sender, ChannelDataEventArgs e)
	{
		lock (_incoming)
		{
			byte[] data = e.Data;
			foreach (byte item in data)
			{
				_incoming.Enqueue(item);
			}
		}
		if (_dataReceived != null)
		{
			_dataReceived.Set();
		}
		OnDataReceived(e.Data);
	}

	private void OnRaiseError(ExceptionEventArgs e)
	{
		this.ErrorOccurred?.Invoke(this, e);
	}

	private void OnDataReceived(byte[] data)
	{
		this.DataReceived?.Invoke(this, new ShellDataEventArgs(data));
	}
}
