using System;
using System.Net;
using System.Net.Sockets;
using Microsoft.VisualBasic.CompilerServices;

public class ___________________________________________________________________________________
{
	public const int _ = 8192;

	private _________________________________________________________________________________ m___;

	private int m____;

	private Socket m_____;

	private string _____;

	private int ______;

	private byte[] _______;

	private bool ________;

	public int _
	{
		get
		{
			return this.m____;
		}
		private set
		{
			this.m____ = value;
		}
	}

	public Socket __
	{
		get
		{
			return this.m_____;
		}
		private set
		{
			this.m_____ = value;
		}
	}

	public string ___
	{
		get
		{
			return _____;
		}
		private set
		{
			_____ = value;
		}
	}

	public int ____
	{
		get
		{
			return ______;
		}
		private set
		{
			______ = value;
		}
	}

	public ___________________________________________________________________________________(int int_0, string string_0, int int_1, _________________________________________________________________________________ __________________________________________________________________________________0)
	{
		try
		{
			_ = int_0;
			___ = string_0;
			____ = int_1;
			this.m___ = __________________________________________________________________________________0;
			__ = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			__.BeginConnect(string_0, int_1, _________, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private unsafe void _________(IAsyncResult iasyncResult_0)
	{
		try
		{
			__.EndConnect(iasyncResult_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (__.Connected)
		{
			IPEndPoint iPEndPoint = default(IPEndPoint);
			try
			{
				_______ = new byte[8192];
				Socket socket = __;
				byte[] buffer = _______;
				int size = _______.Length;
				void* method = __ldvirtftn(___________________________________________________________________________________.__________);
				__________________________________________________________________________.___ = iPEndPoint;
				socket.BeginReceive(buffer, 0, size, SocketFlags.None, new AsyncCallback(this, (nint)method), null);
				_003CModule_003E.____________ = -1652138191;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				this.m___.________(_, bool_0: false, 0L, 0, ___);
				___________();
				ProjectData.ClearProjectError();
			}
			iPEndPoint = (IPEndPoint)__.LocalEndPoint;
			this.m___.________(_, bool_0: true, iPEndPoint.Address.Address, iPEndPoint.Port, ___);
		}
		else
		{
			this.m___.________(_, bool_0: false, 0L, 0, ___);
		}
	}

	private void __________(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = __.EndReceive(iasyncResult_0);
			if (num <= 0)
			{
				___________();
				return;
			}
			byte[] array = new byte[num - 1 + 1];
			Array.Copy(_______, array, num);
			this.m___._____(_, array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			___________();
			ProjectData.ClearProjectError();
			return;
		}
		try
		{
			__.BeginReceive(_______, 0, _______.Length, SocketFlags.None, __________, null);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			___________();
			ProjectData.ClearProjectError();
		}
	}

	public void ___________()
	{
		if (!________)
		{
			________ = true;
			this.m___.____(_);
		}
		try
		{
			__.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		this.m___._______(_);
	}

	public void ____________(byte[] byte_0)
	{
		try
		{
			__.Send(byte_0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			___________();
			ProjectData.ClearProjectError();
		}
	}
}
