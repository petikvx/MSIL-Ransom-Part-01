using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class6 : IDisposable
{
	private string string_0;

	private string string_1;

	private string string_2;

	public string String_0
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = Class45.smethod_0(37);
				while (true)
				{
					switch (num ^ Class45.smethod_0(88))
					{
					case 27:
						result = string_0;
						num = 10;
						continue;
					case 26:
						num = 12;
						continue;
					case 28:
					case 29:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = Class40.smethod_1(19);
				while (true)
				{
					switch (num ^ Class45.smethod_0(42))
					{
					case -26:
						num = -5;
						continue;
					case -27:
						result = string_1;
						num = Class40.smethod_1(9);
						continue;
					case -28:
					case -25:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			string_1 = value;
		}
	}

	public string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = Class45.smethod_0(9);
				while (true)
				{
					switch (num ^ Class45.smethod_0(88))
					{
					case 21:
						num = 3;
						continue;
					case 20:
						result = string_2;
						num = 0;
						continue;
					case 22:
					case 23:
						return result;
					}
					break;
				}
			}
		}
		private set
		{
			string_2 = value;
		}
	}

	internal DialogResult method_0(IWin32Window iwin32Window_0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		DialogResult result = default(DialogResult);
		if (((Environment.OSVersion.Version.Major < Class45.smethod_0(2)) ? 1 : 0) == Class45.smethod_0(0) || 1 == 0)
		{
			result = Delegate21.smethod_0(this, iwin32Window_0);
		}
		else
		{
			while (true)
			{
				int num = Class33.smethod_1(29);
				int num2 = Class45.smethod_0(37);
				while (true)
				{
					num2 ^= Class45.smethod_0(44);
					while (true)
					{
						int num3 = Class45.smethod_0(16);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(42))
							{
							case 27:
								num3 = 6;
								continue;
							case 26:
								break;
							case 25:
								goto IL_008e;
							default:
								goto end_IL_0099;
							case 28:
								goto end_IL_00bf;
							}
							switch (num2)
							{
							case 23:
								goto IL_005a;
							case 25:
								goto IL_0084;
							case 24:
								goto IL_00ce;
							case 22:
								goto end_IL_00d1;
							}
							num3 = 4;
							continue;
							IL_0084:
							num ^= Class45.smethod_0(88);
							goto IL_008e;
							IL_00ce:
							num2 = 12;
							goto end_IL_00bf;
							IL_005a:
							switch (num)
							{
							case -24:
								break;
							case -23:
								goto IL_0082;
							default:
								goto IL_00ca;
							case -22:
							case -21:
								goto end_IL_00dd;
							}
							result = Delegate22.smethod_0(this, iwin32Window_0);
							num = -4;
							goto IL_0084;
							IL_00ca:
							num2 = 2;
							goto end_IL_00bf;
							IL_0082:
							num = -1;
							goto IL_0084;
							IL_008e:
							num2 = Class45.smethod_0(14);
							num3 = 1;
							continue;
							end_IL_0099:
							break;
						}
						continue;
						end_IL_00bf:
						break;
					}
					continue;
					end_IL_00d1:
					break;
				}
				continue;
				end_IL_00dd:
				break;
			}
		}
		return result;
	}

	public static byte[] smethod_0(byte[] byte_0, int int_0 = 16)
	{
		return (byte[])Class26.smethod_0(4098880, null, byte_0, int_0);
	}

	private DialogResult method_1(IWin32Window iwin32Window_0)
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		Class7.Interface0 object_ = default(Class7.Interface0);
		uint uint_ = default(uint);
		bool flag = default(bool);
		Class7.Interface1 interface1_3 = default(Class7.Interface1);
		Class7.Interface1 interface1_ = default(Class7.Interface1);
		Class7.Interface1 interface1_2 = default(Class7.Interface1);
		IntPtr intptr_ = default(IntPtr);
		DialogResult result = default(DialogResult);
		while (true)
		{
			int num = Class45.smethod_0(53);
			while (true)
			{
				switch (num ^ Class45.smethod_0(44))
				{
				case 29:
					Delegate25.smethod_0(object_, uint_);
					num = 13;
					continue;
				case 28:
					uint_ = uint_ | (uint)Class45.smethod_0(3) | (uint)Class45.smethod_0(4) | (uint)Class45.smethod_0(5) | (uint)Class45.smethod_0(6) | (uint)Class45.smethod_0(7);
					num = 9;
					continue;
				case 27:
					Delegate24.smethod_0(object_, ref uint_);
					num = 8;
					continue;
				case 26:
					if (flag)
					{
						num = Class45.smethod_0(17);
						continue;
					}
					if (1 == 0)
					{
						goto case 30;
					}
					goto IL_010b;
				case 25:
					flag = Delegate26.smethod_0(this) != null;
					num = 14;
					continue;
				case 24:
					object_ = (Class7.Interface0)Delegate23.smethod_0();
					num = 15;
					continue;
				case 23:
					num = 3;
					continue;
				case 30:
					{
						Guid guid_2 = new Guid(Class47.smethod_0("\ue163\ue164\ue16f\ue165\ue161\ue113\ue166\ue112\ue17a\ue112\ue160\ue166\ue16f\ue17a\ue163\ue165\ue112\ue112\ue17a\ue115\ue114\ue162\ue162\ue17a\ue116\ue166\ue112\ue165\ue161\ue166\ue114\ue164\ue160\ue115\ue111\ue112", 57668));
						if ((long)Delegate27.smethod_0(Delegate26.smethod_0(this), IntPtr.Zero, ref guid_2, ref interface1_3) == Class45.smethod_0(0) || 1 == 0)
						{
							Delegate28.smethod_0(object_, interface1_3);
						}
						goto IL_010b;
					}
					IL_010b:
					if (Delegate29.smethod_0(this) != null || 1 == 0)
					{
						Guid guid_ = new Guid(Class47.smethod_0("\ue163\ue164\ue16f\ue165\ue161\ue113\ue166\ue112\ue17a\ue112\ue160\ue166\ue16f\ue17a\ue163\ue165\ue112\ue112\ue17a\ue115\ue114\ue162\ue162\ue17a\ue116\ue166\ue112\ue165\ue161\ue166\ue114\ue164\ue160\ue115\ue111\ue112", 57668));
						if ((long)Delegate27.smethod_0(Delegate29.smethod_0(this), IntPtr.Zero, ref guid_, ref interface1_) == Class45.smethod_0(0) || 1 == 0)
						{
							Delegate30.smethod_0(object_, interface1_);
						}
					}
					if ((Delegate31.smethod_0(object_, iwin32Window_0.get_Handle()) == (uint)Class45.smethod_0(0) || 1 == 0) && (Delegate32.smethod_0(object_, ref interface1_2) == (uint)Class45.smethod_0(0) || 1 == 0) && (Delegate33.smethod_0(interface1_2, (uint)Class45.smethod_0(8), ref intptr_) == (uint)Class45.smethod_0(0) || 1 == 0) && (intptr_ != IntPtr.Zero || 1 == 0))
					{
						try
						{
							Delegate34.smethod_0(this, Marshal.PtrToStringAuto(intptr_));
							while (true)
							{
								int num2 = Class45.smethod_0(18);
								int num3 = 9;
								while (true)
								{
									num3 ^= Class45.smethod_0(95);
									while (true)
									{
										int num4 = Class33.smethod_1(27);
										int num5 = -62;
										while (true)
										{
											switch (num5 ^ Class45.smethod_0(77))
											{
											case -27:
												break;
											default:
												goto IL_01f1;
											case -28:
												goto IL_01ff;
											case -29:
												num5 = Class1.Class2.smethod_1(38);
												continue;
											case -30:
												goto end_IL_02aa;
											}
											goto IL_01e5;
											IL_01ff:
											switch (num4)
											{
											case -21:
												goto IL_0222;
											case -19:
												goto IL_022d;
											case -20:
												goto IL_028f;
											case -18:
												goto end_IL_02d5;
											}
											num5 = -59;
											continue;
											IL_022d:
											switch (num3)
											{
											case 27:
												goto IL_024d;
											case 28:
												goto IL_0283;
											case 25:
												goto IL_02e4;
											case 26:
												goto end_IL_02f3;
											}
											num4 = -11;
											goto IL_01e5;
											IL_02e4:
											num3 = Class45.smethod_0(53);
											goto end_IL_02d5;
											IL_024d:
											switch (num2)
											{
											case 19:
												break;
											case 20:
												goto IL_0272;
											case 21:
												goto IL_0278;
											default:
												goto IL_02ef;
											case 22:
												return result;
											}
											num2 = 15;
											goto IL_0283;
											IL_02ef:
											num3 = 15;
											goto end_IL_02d5;
											IL_0278:
											result = (DialogResult)Class45.smethod_0(1);
											num2 = 12;
											goto IL_0283;
											IL_0272:
											num2 = 14;
											goto IL_0283;
											IL_01f1:
											num5 = Class1.Class2.smethod_1(39);
											continue;
											IL_0283:
											num2 ^= Class45.smethod_0(91);
											goto IL_028f;
											IL_028f:
											num3 = Class45.smethod_0(65);
											num4 = -9;
											goto IL_01e5;
											IL_01e5:
											num4 ^= Class45.smethod_0(82);
											goto IL_01f1;
											IL_0222:
											num4 = Class1.Class2.smethod_1(26);
											goto IL_01e5;
											continue;
											end_IL_02aa:
											break;
										}
										continue;
										end_IL_02d5:
										break;
									}
									continue;
									end_IL_02f3:
									break;
								}
							}
						}
						finally
						{
							Marshal.FreeCoTaskMem(intptr_);
						}
					}
					return (DialogResult)Class45.smethod_0(9);
				}
				break;
			}
		}
	}

	public static byte[] smethod_1(Bitmap bitmap_0)
	{
		return (byte[])Class26.smethod_0(4098774, null, bitmap_0);
	}

	private DialogResult method_2(IWin32Window iwin32Window_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between Unknown and I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		try
		{
			((FileDialog)val).set_CheckFileExists((byte)Class45.smethod_0(0) != 0);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = Class47.smethod_2(34);
				while (true)
				{
					switch (num ^ Class45.smethod_0(42))
					{
					case -22:
						num = -9;
						continue;
					case -23:
					{
						string text = Class47.smethod_0("\uf14a", 61734);
						Guid empty = Guid.Empty;
						((FileDialog)val).set_Filter(text + empty);
						num = -7;
						continue;
					}
					case -24:
						num = -2;
						continue;
					case -25:
						if (flag)
						{
							num = -10;
							continue;
						}
						if (1 == 0)
						{
							goto case -21;
						}
						goto IL_02cb;
					case -26:
						val.set_CreatePrompt((byte)Class45.smethod_0(0) != 0);
						num = -8;
						continue;
					case -27:
						num = -12;
						continue;
					case -28:
						num = -1;
						continue;
					case -29:
						((FileDialog)val).set_CheckPathExists((byte)Class45.smethod_0(1) != 0);
						num = -4;
						continue;
					case -30:
						((FileDialog)val).set_FileName(Class47.smethod_0("\uef0c\uef03\uef14", 61197));
						num = -3;
						continue;
					case -31:
						num = -5;
						continue;
					case -32:
						num = -62;
						continue;
					case -33:
						flag = Delegate26.smethod_0(this) != null;
						num = -6;
						continue;
					case -21:
						{
							((FileDialog)val).set_InitialDirectory(Delegate26.smethod_0(this));
							goto IL_02cb;
						}
						IL_02cb:
						while (true)
						{
							int num2 = Class47.smethod_2(37);
							int num3 = 1;
							while (true)
							{
								num3 ^= Class45.smethod_0(100);
								while (true)
								{
									int num4 = Class33.smethod_1(29);
									int num5 = 30;
									while (true)
									{
										switch (num5 ^ Class45.smethod_0(12))
										{
										case 46:
											break;
										default:
											goto IL_0144;
										case 44:
											goto IL_0152;
										case 43:
											num5 = Class45.smethod_0(87);
											continue;
										case 45:
											goto end_IL_027b;
										}
										goto IL_0138;
										IL_0152:
										switch (num4)
										{
										case -41:
											goto IL_0175;
										case -39:
											goto IL_017b;
										case -40:
											goto IL_025b;
										case -38:
											goto end_IL_02a6;
										}
										num5 = 29;
										continue;
										IL_017b:
										switch (num3)
										{
										case 43:
											goto IL_019a;
										case 46:
											goto IL_024f;
										case 44:
											goto IL_02ba;
										case 45:
											goto end_IL_02bd;
										}
										num4 = -1;
										goto IL_0138;
										IL_02ba:
										num3 = 3;
										goto end_IL_02a6;
										IL_019a:
										switch (num2)
										{
										case -29:
											break;
										case -28:
											goto IL_01de;
										case -27:
											goto IL_01f0;
										case -26:
											goto IL_020b;
										case -25:
											goto IL_0227;
										case -24:
											goto IL_022d;
										case -23:
											goto IL_0233;
										case -22:
											goto IL_0245;
										case -21:
											goto IL_024b;
										default:
											goto IL_02b5;
										case -20:
											goto IL_02df;
										}
										if (flag2)
										{
											num2 = -55;
											goto IL_024f;
										}
										if (true)
										{
											return (DialogResult)Class45.smethod_0(9);
										}
										goto IL_02df;
										IL_02b5:
										num3 = 2;
										goto end_IL_02a6;
										IL_024b:
										num2 = -64;
										goto IL_024f;
										IL_0245:
										num2 = -61;
										goto IL_024f;
										IL_0233:
										val.set_OverwritePrompt((byte)Class45.smethod_0(0) != 0);
										num2 = -50;
										goto IL_024f;
										IL_022d:
										num2 = -63;
										goto IL_024f;
										IL_0227:
										num2 = -62;
										goto IL_024f;
										IL_020b:
										flag2 = (int)((CommonDialog)val).ShowDialog(iwin32Window_0) == Class45.smethod_0(1);
										num2 = Class1.Class2.smethod_1(35);
										goto IL_024f;
										IL_01f0:
										((FileDialog)val).set_Title(Class47.smethod_0("\ue920\ue916\ue91f\ue916\ue910\ue907\ue953\ue935\ue91c\ue91f\ue917\ue916\ue901", 59712));
										num2 = -51;
										goto IL_024f;
										IL_01de:
										((FileDialog)val).set_ValidateNames((byte)Class45.smethod_0(0) != 0);
										num2 = -49;
										goto IL_024f;
										IL_0175:
										num4 = -16;
										goto IL_0138;
										IL_0144:
										num5 = Class45.smethod_0(85);
										continue;
										IL_024f:
										num2 ^= Class45.smethod_0(57);
										goto IL_025b;
										IL_025b:
										num3 = Class45.smethod_0(11);
										num4 = Class33.smethod_1(22);
										goto IL_0138;
										IL_0138:
										num4 ^= Class45.smethod_0(77);
										goto IL_0144;
										IL_02df:
										Delegate34.smethod_0(this, Path.GetDirectoryName(((FileDialog)val).get_FileName()));
										return (DialogResult)Class45.smethod_0(1);
										continue;
										end_IL_027b:
										break;
									}
									continue;
									end_IL_02a6:
									break;
								}
								continue;
								end_IL_02bd:
								break;
							}
						}
					}
					break;
				}
			}
		}
		finally
		{
			if (val != null || 1 == 0)
			{
				((IDisposable)val).Dispose();
			}
		}
	}

	public void method_3()
	{
	}

	private void IDisposable_Dispose()
	{
		throw new NotImplementedException();
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in IDisposable_Dispose
		this.IDisposable_Dispose();
	}
}
