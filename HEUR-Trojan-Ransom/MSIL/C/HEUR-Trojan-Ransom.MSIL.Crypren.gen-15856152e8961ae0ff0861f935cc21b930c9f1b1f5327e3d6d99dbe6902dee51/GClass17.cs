using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("2D4EF368-EE80-4C15-AE77-D12AEAF4B00A")]
public sealed class GClass17
{
	[CompilerGenerated]
	private GEnum9 genum9_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private SecureString secureString_0;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private GEnum10 genum10_0;

	[CompilerGenerated]
	private GEnum11 genum11_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private Dictionary<string, string> dictionary_0;

	private string string_5;

	private string string_6;

	private TimeSpan timeSpan_0;

	private int int_0;

	private string string_7;

	private const string string_8 = "{0}(;{0})*";

	private const string string_9 = "((ssh-rsa|ssh-dss|ssh-ed25519|ecdsa-sha2-nistp(256|384|521))( |-))?(\\d+ )?([0-9a-f]{2}(:|-)){15}[0-9a-f]{2}";

	private static readonly Regex regex_0 = new Regex(string.Format(CultureInfo.InvariantCulture, "{0}(;{0})*", new object[1] { "((ssh-rsa|ssh-dss|ssh-ed25519|ecdsa-sha2-nistp(256|384|521))( |-))?(\\d+ )?([0-9a-f]{2}(:|-)){15}[0-9a-f]{2}" }));

	private const string string_10 = "([0-9a-f]{2}:){19}[0-9a-f]{2}";

	private static readonly Regex regex_1 = new Regex(string.Format(CultureInfo.InvariantCulture, "{0}(;{0})*", new object[1] { "([0-9a-f]{2}:){19}[0-9a-f]{2}" }));

	public GEnum9 GEnum9_0
	{
		[CompilerGenerated]
		get
		{
			return genum9_0;
		}
		[CompilerGenerated]
		set
		{
			genum9_0 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			Delegate493.smethod_0(this, value);
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string String_2
	{
		get
		{
			return Delegate494.smethod_0(this);
		}
		set
		{
			Delegate495.smethod_0(this, value);
		}
	}

	public SecureString SecureString_0
	{
		[CompilerGenerated]
		get
		{
			return secureString_0;
		}
		[CompilerGenerated]
		set
		{
			secureString_0 = value;
		}
	}

	public TimeSpan TimeSpan_0
	{
		get
		{
			return timeSpan_0;
		}
		set
		{
			Delegate496.smethod_0(this, value);
		}
	}

	public int Int32_1
	{
		get
		{
			return Delegate324.smethod_0(Delegate497.smethod_0(this));
		}
		set
		{
			Delegate491.smethod_0(this, Delegate325.smethod_0(value));
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string String_4
	{
		get
		{
			return string_5;
		}
		set
		{
			Delegate498.smethod_0(this, value);
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public string String_5
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	[Obsolete("Use PrivateKeyPassphrase")]
	public string String_6
	{
		get
		{
			return Delegate499.smethod_0(this);
		}
		set
		{
			Delegate500.smethod_0(this, value);
		}
	}

	public GEnum10 GEnum10_0
	{
		[CompilerGenerated]
		get
		{
			return genum10_0;
		}
		[CompilerGenerated]
		set
		{
			genum10_0 = value;
		}
	}

	public GEnum11 GEnum11_0
	{
		[CompilerGenerated]
		get
		{
			return genum11_0;
		}
		[CompilerGenerated]
		set
		{
			genum11_0 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public string String_7
	{
		get
		{
			return string_7;
		}
		set
		{
			Delegate501.smethod_0(this, value);
		}
	}

	public string String_8
	{
		get
		{
			return string_6;
		}
		set
		{
			Delegate502.smethod_0(this, value);
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public string String_9
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	internal Dictionary<string, string> Dictionary_0
	{
		[CompilerGenerated]
		get
		{
			return dictionary_0;
		}
		[CompilerGenerated]
		private set
		{
			dictionary_0 = value;
		}
	}

	internal bool Boolean_3
	{
		get
		{
			if (Delegate507.smethod_0(this) != 0 || 1 == 0)
			{
				return Delegate507.smethod_0(this) == GEnum9.const_1;
			}
			return true;
		}
	}

	internal bool Boolean_4 => Delegate522.smethod_0(this);

	public GClass17()
	{
		Delegate491.smethod_0(this, new TimeSpan(0, 0, 15));
		Delegate492.smethod_0(this, new Dictionary<string, string>());
	}

	public void method_0(string string_11, string string_12)
	{
		Delegate503.smethod_0(this).Add(string_11, string_12);
	}

	public void method_1(string string_11)
	{
		if (string_11 == null && 0 == 0)
		{
			throw new ArgumentNullException("url");
		}
		string_11 = string_11.Trim();
		string value = default(string);
		string text2 = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = Class8.smethod_0(58);
			int num2 = -2;
			while (true)
			{
				IL_00f2:
				num2 ^= 0x65;
				int num3;
				while (true)
				{
					num3 = Class8.smethod_0(48);
					switch (num3 ^ 0x67)
					{
					case -99:
						goto end_IL_0024;
					case -98:
						goto IL_00e1;
					case -96:
						goto IL_00f2;
					case -97:
						while (true)
						{
							num3 = -8;
							num3 = -97;
						}
					}
					continue;
					end_IL_0024:
					break;
				}
				switch (num2)
				{
				case -103:
					goto IL_0074;
				case -102:
					goto IL_00bc;
				case -101:
					goto IL_00c7;
				case -104:
					goto end_IL_00f2;
				}
				num3 = -7;
				num3 = -98;
				goto IL_00e1;
				IL_00c7:
				num ^= 0x65;
				num2 = Class8.smethod_0(38);
				num3 = -57;
				num3 = -96;
				continue;
				IL_00e1:
				num2 = Class8.smethod_0(38);
				num3 = -57;
				num3 = -96;
				continue;
				IL_00bc:
				num2 = Class8.smethod_0(39);
				continue;
				IL_0074:
				switch (num)
				{
				default:
					num2 = -3;
					continue;
				case -106:
					num4 = string_11.IndexOf("://", StringComparison.OrdinalIgnoreCase);
					num = -14;
					break;
				case -105:
				{
					if (num4 < 0)
					{
						num = -4;
						break;
					}
					string text = string_11.Substring(0, num4).Trim();
					if (!Delegate504.smethod_0(this, text) && 0 == 0)
					{
						throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Unknown protocol {0}", new object[1] { text }), "url");
					}
					string_11 = string_11.Substring(num4 + "://".Length).Trim();
					while (true)
					{
						int num5 = GEventArgs2.smethod_0(44);
						while (true)
						{
							string text4;
							string value2;
							string text3;
							switch (num5 ^ 0x6C)
							{
							case -96:
								if (num4 >= 0)
								{
									num5 = -13;
									num5 = -97;
									goto IL_017a;
								}
								goto IL_02d6;
							case -97:
								goto IL_017a;
							case -98:
								num4 = string_11.IndexOf('/');
								num5 = -16;
								num5 = -100;
								goto case -100;
							case -100:
								Delegate505.smethod_0(this, null);
								num5 = -52;
								num5 = -96;
								goto case -96;
							case -99:
								while (true)
								{
									num5 = -15;
									num5 = -99;
								}
							case -95:
								{
									while (true)
									{
										int num6 = GEventArgs2.smethod_0(44);
										while (true)
										{
											switch (num6 ^ 0x68)
											{
											case -102:
												string_11 = string_11.Substring(0, num4).Trim();
												num6 = -1;
												num6 = -105;
												goto case -105;
											case -105:
												value = text2;
												num6 = -2;
												num6 = -106;
												goto case -106;
											case -106:
												text2 = Delegate506.smethod_0(ref value, ';');
												num6 = Class8.smethod_0(37);
												continue;
											case -104:
												goto IL_025f;
											case -103:
												while (true)
												{
													num6 = -15;
													num6 = -103;
												}
											case -101:
												goto end_IL_0254;
											}
											break;
										}
										continue;
										IL_025f:
										if (string.IsNullOrEmpty(text2))
										{
											num6 = -13;
											num6 = -101;
											break;
										}
										if (false || ((!(text2 != "/")) ? true : false))
										{
											break;
										}
										if (Delegate507.smethod_0(this) != GEnum9.const_3)
										{
											throw new ArgumentException("Root folder can be specified for WebDAV protocol only", "url");
										}
										Delegate505.smethod_0(this, text2);
										break;
										continue;
										end_IL_0254:
										break;
									}
									if (!string.IsNullOrEmpty(value) && 0 == 0)
									{
										throw new ArgumentException("No session parameters are supported", "url");
									}
									goto IL_02d6;
								}
								IL_02d6:
								num4 = string_11.LastIndexOf('@');
								text3 = null;
								if (num4 >= 0)
								{
									text3 = string_11.Substring(0, num4).Trim();
									text4 = string_11.Substring(num4 + 1).Trim();
								}
								else
								{
									text4 = string_11;
								}
								Delegate508.smethod_0(this, 0);
								value2 = null;
								if (text4.Length >= 2 && text4[0] == '[' && (num4 = text4.IndexOf(']')) > 0)
								{
									Delegate509.smethod_0(this, text4.Substring(1, num4 - 1).Trim());
									text4 = text4.Substring(num4 + 1).Trim();
									if (text4.Length > 0)
									{
										if (text4[0] != ':')
										{
											throw new ArgumentException("Unexpected syntax after ]", "url");
										}
										value2 = text4.Substring(1);
									}
								}
								else
								{
									Delegate509.smethod_0(this, Delegate510.smethod_0(Delegate506.smethod_0(ref text4, ':')));
									value2 = text4;
								}
								if (string.IsNullOrEmpty(Delegate511.smethod_0(this)) || 1 == 0)
								{
									throw new ArgumentException("No host name", "url");
								}
								if (string.IsNullOrEmpty(value2) || 1 == 0)
								{
									Delegate508.smethod_0(this, 0);
								}
								else
								{
									value2 = Delegate510.smethod_0(value2);
									if (!int.TryParse(value2, NumberStyles.None, CultureInfo.InvariantCulture, out var result) && 0 == 0)
									{
										throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "{0} is not a valid port number", new object[1] { value2 }), "url");
									}
									Delegate508.smethod_0(this, result);
								}
								Delegate512.smethod_0(this, null);
								while (true)
								{
									int num7 = Class9.smethod_0(87);
									switch (num7 ^ 0x66)
									{
									default:
										continue;
									case -95:
										Delegate513.smethod_0(this, null);
										num7 = -8;
										num7 = -98;
										goto case -98;
									case -98:
										Delegate514.smethod_0(this, null);
										num7 = -58;
										num7 = -96;
										goto case -96;
									case -96:
										Delegate515.smethod_0(this, bool_0: false);
										num7 = -7;
										num7 = -97;
										goto case -97;
									case -97:
										Delegate516.smethod_0(this, null);
										num7 = -5;
										num7 = -99;
										goto case -99;
									case -99:
										Delegate517.smethod_0(this, bool_0: false);
										num7 = -6;
										num7 = -100;
										goto case -100;
									case -100:
										if (string.IsNullOrEmpty(text3))
										{
											num7 = -59;
											num7 = -93;
										}
										else
										{
											if (false)
											{
												return;
											}
											string value3 = text3;
											text3 = Delegate506.smethod_0(ref value3, ';');
											Delegate512.smethod_0(this, Delegate518.smethod_0(Delegate510.smethod_0(Delegate506.smethod_0(ref text3, ':'))));
											Delegate513.smethod_0(this, Delegate518.smethod_0(Delegate510.smethod_0(text3)));
											while ((!string.IsNullOrEmpty(value3)) ? true : false)
											{
												string text5 = Delegate506.smethod_0(ref value3, ';');
												string text6 = Delegate506.smethod_0(ref text5, '=');
												if (text6.Equals("fingerprint", StringComparison.OrdinalIgnoreCase) || 1 == 0)
												{
													Delegate514.smethod_0(this, text5);
													continue;
												}
												throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Unsupported connection parameter {0}", new object[1] { text6 }), "url");
											}
										}
										return;
									case -94:
										break;
									case -93:
										return;
									}
									while (true)
									{
										num7 = -60;
										num7 = -94;
									}
								}
							}
							break;
							IL_017a:
							text2 = string_11.Substring(num4).Trim();
							num5 = Class9.smethod_0(106);
						}
					}
				}
				case -104:
					num = Class8.smethod_0(41);
					break;
				case -103:
					throw new ArgumentException("Protocol not specified", "url");
				}
				goto IL_00c7;
				continue;
				end_IL_00f2:
				break;
			}
		}
	}

	private bool method_2(string string_11)
	{
		bool result = true;
		Delegate519.smethod_0(this, GEnum11.const_0);
		if (string_11.Equals("sftp", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_0);
		}
		else if (string_11.Equals("scp", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_1);
		}
		else if (string_11.Equals("ftp", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_2);
		}
		else if (string_11.Equals("ftps", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			while (true)
			{
				int num = 10;
				int num2 = 12;
				while (true)
				{
					num2 ^= 0x63;
					while (true)
					{
						int num3 = GEventArgs2.smethod_0(49);
						int num4 = 2;
						while (true)
						{
							num4 ^= 0x69;
							while (true)
							{
								int num5 = Class8.smethod_0(47);
								int num6 = 9;
								while (true)
								{
									num6 ^= 0x6D;
									while (true)
									{
										int num7 = 9;
										int num8 = Class55.smethod_1(72);
										while (true)
										{
											num8 ^= 0x67;
											int num9 = Class8.smethod_0(39);
											while (true)
											{
												switch (num9 ^ 0x69)
												{
												case -106:
													break;
												case -107:
													goto IL_01ec;
												default:
													num9 = Class8.smethod_0(39);
													continue;
												case -104:
													goto end_IL_0209;
												case -105:
													while (true)
													{
														num9 = -2;
														num9 = -105;
													}
												}
												switch (num8)
												{
												case -108:
													goto IL_00ac;
												case -106:
													goto IL_01e5;
												case -109:
													goto IL_022c;
												case -107:
													goto end_IL_0236;
												}
												num9 = -4;
												num9 = -107;
												goto IL_01ec;
												IL_01d7:
												num5 ^= 0x6D;
												goto IL_01de;
												IL_022c:
												num8 = -12;
												break;
												IL_00ac:
												switch (num7)
												{
												case 106:
													break;
												case 108:
													goto IL_00d4;
												case 107:
													goto IL_01de;
												default:
													goto IL_0232;
												case 109:
													goto end_IL_0248;
												}
												num7 = 15;
												goto IL_01e5;
												IL_0232:
												num8 = -14;
												break;
												IL_00d4:
												switch (num6)
												{
												case 99:
													goto IL_00f7;
												case 100:
													goto IL_01d7;
												case 97:
													goto IL_0257;
												case 98:
													goto end_IL_0261;
												}
												num7 = 14;
												goto IL_01e5;
												IL_0257:
												num6 = 12;
												goto end_IL_0248;
												IL_00f7:
												switch (num5)
												{
												case -107:
													break;
												case -106:
													goto IL_011f;
												case -108:
													goto IL_01cb;
												default:
													goto IL_025d;
												case -105:
													goto end_IL_026a;
												}
												num5 = -8;
												goto IL_01d7;
												IL_025d:
												num6 = 15;
												goto end_IL_0248;
												IL_011f:
												switch (num4)
												{
												case 104:
													goto IL_0142;
												case 107:
													goto IL_01c6;
												case 105:
													goto IL_027e;
												case 106:
													goto end_IL_0281;
												}
												num5 = -7;
												goto IL_01d7;
												IL_027e:
												num4 = 0;
												goto end_IL_026a;
												IL_0142:
												switch (num3)
												{
												case -102:
													break;
												case -101:
													goto IL_01bb;
												case -100:
													goto IL_01c3;
												default:
													goto IL_0279;
												case -99:
													goto end_IL_028a;
												}
												switch (num2)
												{
												case 110:
													goto IL_017e;
												case 111:
													goto IL_01b6;
												case 109:
													goto IL_0297;
												case 108:
													goto end_IL_029f;
												}
												num3 = -9;
												goto IL_01c6;
												IL_0279:
												num4 = 3;
												goto end_IL_026a;
												IL_01c3:
												num3 = -16;
												goto IL_01c6;
												IL_01e5:
												num7 ^= 0x65;
												goto IL_01ec;
												IL_0297:
												num2 = 14;
												goto end_IL_028a;
												IL_017e:
												switch (num)
												{
												case 97:
													break;
												case 98:
													goto IL_01a8;
												case 99:
													goto IL_01ad;
												default:
													goto IL_029c;
												case 100:
													goto end_IL_02a6;
												}
												Delegate519.smethod_0(this, GEnum11.const_1);
												num = 13;
												goto IL_01b6;
												IL_029c:
												num2 = 15;
												goto end_IL_028a;
												IL_01ad:
												Delegate520.smethod_0(this, GEnum9.const_2);
												num = 8;
												goto IL_01b6;
												IL_01a8:
												num = 11;
												goto IL_01b6;
												IL_01ec:
												num8 = Class8.smethod_0(58);
												num9 = Class55.smethod_1(72);
												continue;
												IL_01b6:
												num ^= 0x69;
												goto IL_01bb;
												IL_01bb:
												num2 = 13;
												num3 = -15;
												goto IL_01c6;
												IL_01de:
												num6 = 14;
												num7 = 8;
												goto IL_01e5;
												IL_01c6:
												num3 ^= 0x6C;
												goto IL_01cb;
												IL_01cb:
												num4 = 1;
												num5 = Class8.smethod_0(48);
												goto IL_01d7;
												continue;
												end_IL_0209:
												break;
											}
											continue;
											end_IL_0236:
											break;
										}
										continue;
										end_IL_0248:
										break;
									}
									continue;
									end_IL_0261:
									break;
								}
								continue;
								end_IL_026a:
								break;
							}
							continue;
							end_IL_0281:
							break;
						}
						continue;
						end_IL_028a:
						break;
					}
					continue;
					end_IL_029f:
					break;
				}
				continue;
				end_IL_02a6:
				break;
			}
		}
		else if (string_11.Equals("ftpes", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_2);
			Delegate519.smethod_0(this, GEnum11.const_2);
		}
		else if (string_11.Equals("http", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_3);
		}
		else if (string_11.Equals("https", StringComparison.OrdinalIgnoreCase) || 1 == 0)
		{
			Delegate520.smethod_0(this, GEnum9.const_3);
			Delegate521.smethod_0(this, bool_0: true);
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static string smethod_0(string string_11)
	{
		if (string.IsNullOrEmpty(string_11) || 1 == 0)
		{
			return null;
		}
		return string_11;
	}

	private static string smethod_1(string string_11)
	{
		return Uri.UnescapeDataString(string_11);
	}

	private static string smethod_2(ref string string_11, char char_0)
	{
		int num = string_11.IndexOf(char_0);
		string result = default(string);
		while (true)
		{
			int num2 = 0;
			int num3 = 7;
			while (true)
			{
				num3 ^= 0x6C;
				while (true)
				{
					int num4 = 15;
					int num5 = 6;
					while (true)
					{
						num5 ^= 0x6B;
						while (true)
						{
							int num6 = Class8.smethod_0(38);
							int num7 = 2;
							while (true)
							{
								num7 ^= 0x6C;
								while (true)
								{
									int num8 = 4;
									int num9 = 10;
									while (true)
									{
										num9 ^= 0x6C;
										int num10 = 4;
										int num11 = -7;
										num11 = -98;
										while (true)
										{
											IL_0207:
											num10 ^= 0x67;
											while (true)
											{
												num11 = Class8.smethod_0(47);
												while (true)
												{
													switch (num11 ^ 0x67)
													{
													case -101:
														num11 = Class8.smethod_0(38);
														continue;
													case -100:
														goto end_IL_0038;
													case -99:
														goto IL_01fc;
													case -98:
														goto IL_0207;
													}
													break;
												}
												continue;
												end_IL_0038:
												break;
											}
											switch (num10)
											{
											case 99:
												goto IL_006a;
											case 98:
												goto IL_01ee;
											case 100:
												goto IL_01f7;
											case 101:
												goto end_IL_0207;
											}
											num11 = -6;
											num11 = -99;
											goto IL_01fc;
											IL_01cc:
											num5 = 7;
											num6 = -14;
											goto IL_01d3;
											IL_01ee:
											num9 = 9;
											num10 = 2;
											continue;
											IL_01f7:
											num10 = 3;
											continue;
											IL_006a:
											switch (num9)
											{
											case 101:
												goto IL_008c;
											case 102:
												goto IL_01e7;
											case 99:
												goto IL_0213;
											case 100:
												goto end_IL_021c;
											}
											num10 = 5;
											continue;
											IL_0213:
											num9 = 15;
											break;
											IL_008c:
											switch (num8)
											{
											case 108:
												break;
											case 109:
												goto IL_01dc;
											case 110:
												goto IL_01e1;
											default:
												goto IL_0219;
											case 111:
												goto end_IL_0230;
											}
											switch (num7)
											{
											case 107:
												goto IL_00cd;
											case 110:
												goto IL_01d3;
											case 109:
												goto IL_023e;
											case 108:
												goto end_IL_0241;
											}
											num8 = 6;
											goto IL_01e7;
											IL_0219:
											num9 = 8;
											break;
											IL_01dc:
											num8 = 5;
											goto IL_01e7;
											IL_01e1:
											num7 = 7;
											num8 = 7;
											goto IL_01e7;
											IL_023e:
											num7 = 1;
											goto end_IL_0230;
											IL_00cd:
											switch (num6)
											{
											case -107:
												break;
											case -106:
												goto IL_00f4;
											case -105:
												goto IL_01cc;
											default:
												goto IL_0239;
											case -104:
												goto end_IL_024a;
											}
											num6 = -1;
											goto IL_01d3;
											IL_0239:
											num7 = 0;
											goto end_IL_0230;
											IL_00f4:
											switch (num5)
											{
											case 108:
												goto IL_011c;
											case 109:
												goto IL_01c5;
											case 107:
												goto IL_0258;
											case 106:
												goto end_IL_0260;
											}
											num6 = Class8.smethod_0(41);
											goto IL_01d3;
											IL_0258:
											num5 = 0;
											goto end_IL_024a;
											IL_011c:
											switch (num4)
											{
											case 101:
												break;
											case 102:
												goto IL_0144;
											case 100:
												goto IL_01bf;
											default:
												goto IL_025d;
											case 103:
												goto end_IL_0269;
											}
											num4 = 12;
											goto IL_01c5;
											IL_025d:
											num5 = 1;
											goto end_IL_024a;
											IL_0144:
											switch (num3)
											{
											case 105:
												goto IL_0163;
											case 107:
												goto IL_01ba;
											case 104:
												goto IL_0272;
											case 106:
												goto end_IL_0278;
											}
											num4 = 13;
											goto IL_01c5;
											IL_0272:
											num3 = 4;
											goto end_IL_0269;
											IL_0163:
											switch (num2)
											{
											case 98:
												break;
											case 99:
												if (num >= 0)
												{
													goto IL_01a1;
												}
												result = string_11;
												string_11 = string.Empty;
												goto case 102;
											case 100:
												goto IL_01a5;
											case 101:
												goto IL_01a9;
											default:
												goto IL_0276;
											case 102:
												return result;
											}
											string_11 = string_11.Substring(num + 1).Trim();
											num2 = 5;
											goto IL_01ba;
											IL_0276:
											num3 = 6;
											goto end_IL_0269;
											IL_01a9:
											result = string_11.Substring(0, num).Trim();
											num2 = 1;
											goto IL_01ba;
											IL_01a5:
											num2 = 7;
											goto IL_01ba;
											IL_01a1:
											num2 = 6;
											goto IL_01ba;
											IL_01fc:
											num10 = 4;
											num11 = -7;
											num11 = -98;
											continue;
											IL_01ba:
											num2 ^= 0x63;
											goto IL_01bf;
											IL_01bf:
											num3 = 5;
											num4 = 14;
											goto IL_01c5;
											IL_01e7:
											num8 ^= 0x68;
											goto IL_01ee;
											IL_01d3:
											num6 ^= 0x6A;
											goto IL_01e1;
											IL_01c5:
											num4 ^= 0x69;
											goto IL_01cc;
											continue;
											end_IL_0207:
											break;
										}
										continue;
										end_IL_021c:
										break;
									}
									continue;
									end_IL_0230:
									break;
								}
								continue;
								end_IL_0241:
								break;
							}
							continue;
							end_IL_024a:
							break;
						}
						continue;
						end_IL_0260:
						break;
					}
					continue;
					end_IL_0269:
					break;
				}
				continue;
				end_IL_0278:
				break;
			}
		}
	}

	private bool method_3()
	{
		if (Delegate507.smethod_0(this) == GEnum9.const_2 && ((Delegate523.smethod_0(this) != 0) ? true : false))
		{
			return true;
		}
		if (Delegate507.smethod_0(this) == GEnum9.const_3)
		{
			return Delegate524.smethod_0(this);
		}
		return false;
	}

	private void method_4(string string_11)
	{
		if (string_11 != null || 1 == 0)
		{
			Match match = regex_0.Match(string_11);
			if (((!match.Success) ? true : false) || match.Length != string_11.Length)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "SSH host key fingerprint \"{0}\" does not match pattern /{1}/", new object[2] { string_11, regex_0 }));
			}
		}
		string_5 = string_11;
	}

	private void method_5(string string_11)
	{
		if (string_11 != null || 1 == 0)
		{
			Match match = regex_1.Match(string_11);
			if (((!match.Success) ? true : false) || match.Length != string_11.Length)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "TLS host certificate fingerprint \"{0}\" does not match pattern /{1}/", new object[2] { string_11, regex_1 }));
			}
		}
		string_6 = string_11;
	}

	private void method_6(TimeSpan timeSpan_1)
	{
		if (timeSpan_1 <= TimeSpan.Zero || 1 == 0)
		{
			throw new ArgumentException("Timeout has to be positive non-zero value");
		}
		timeSpan_0 = timeSpan_1;
	}

	private void method_7(int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentException("Port number cannot be negative");
		}
		int_0 = int_1;
	}

	private void method_8(string string_11)
	{
		if (!string.IsNullOrEmpty(string_11) && 0 == 0 && string_11[0] != '/')
		{
			throw new ArgumentException("WebDAV root path has to start with slash");
		}
		string_7 = string_11;
	}

	private void method_9(string string_11)
	{
		if (string_11 == null && 0 == 0)
		{
			Delegate525.smethod_0(this, null);
			return;
		}
		Delegate525.smethod_0(this, new SecureString());
		int num10 = default(int);
		char c = default(char);
		string text = default(string);
		while (true)
		{
			int num = Class55.smethod_1(72);
			int num2 = Class8.smethod_0(39);
			while (true)
			{
				num2 ^= 0x63;
				while (true)
				{
					int num3 = Class8.smethod_0(38);
					int num4 = -2;
					while (true)
					{
						num4 ^= 0x65;
						while (true)
						{
							int num5 = Class8.smethod_0(57);
							int num6 = -49;
							while (true)
							{
								num6 ^= 0x6D;
								while (true)
								{
									int num7 = 14;
									int num8 = 27;
									while (true)
									{
										IL_0237:
										num8 ^= 0x6B;
										int num9 = Class8.smethod_0(47);
										while (true)
										{
											switch (num9 ^ 0x62)
											{
											case -102:
												num9 = GEventArgs2.smethod_0(43);
												continue;
											default:
												num9 = Class8.smethod_0(47);
												continue;
											case -103:
												break;
											case -101:
												goto IL_022c;
											case -100:
												goto IL_0237;
											}
											break;
										}
										switch (num8)
										{
										case 109:
											goto IL_007f;
										case 111:
											goto IL_0213;
										case 112:
											goto IL_0218;
										case 110:
											goto end_IL_0237;
										}
										num9 = -7;
										num9 = -101;
										goto IL_022c;
										IL_01d9:
										num3 ^= 0x65;
										goto IL_01e8;
										IL_01e8:
										num4 = Class8.smethod_0(39);
										num5 = -58;
										goto IL_01f5;
										IL_0213:
										num8 = 4;
										continue;
										IL_007f:
										switch (num7)
										{
										case 98:
											goto IL_00a1;
										case 99:
											goto IL_01fe;
										case 100:
											goto IL_0204;
										case 101:
											goto end_IL_024c;
										}
										num8 = 5;
										continue;
										IL_01fe:
										num7 = 15;
										goto IL_0218;
										IL_00a1:
										switch (num6)
										{
										case -96:
											goto IL_00c3;
										case -94:
											goto IL_01f5;
										case -95:
											goto IL_025c;
										case -97:
											goto end_IL_0265;
										}
										num7 = 8;
										goto IL_0218;
										IL_025c:
										num6 = Class9.smethod_0(101);
										goto end_IL_024c;
										IL_00c3:
										switch (num5)
										{
										case -98:
											break;
										case -97:
											goto IL_01e2;
										case -96:
											goto IL_01e8;
										default:
											goto IL_0256;
										case -95:
											goto end_IL_026e;
										}
										switch (num4)
										{
										case -102:
											goto IL_010a;
										case -101:
											goto IL_01d9;
										case -104:
											goto IL_027d;
										case -103:
											goto end_IL_0287;
										}
										num5 = Class9.smethod_0(87);
										goto IL_01f5;
										IL_0256:
										num6 = -14;
										goto end_IL_024c;
										IL_01e2:
										num5 = -8;
										goto IL_01f5;
										IL_0204:
										num6 = Class9.smethod_0(106);
										num7 = 9;
										goto IL_0218;
										IL_027d:
										num4 = -3;
										goto end_IL_026e;
										IL_010a:
										switch (num3)
										{
										case -103:
											break;
										case -102:
											goto IL_01c6;
										case -101:
											goto IL_01d5;
										default:
											goto IL_0283;
										case -100:
											goto end_IL_0290;
										}
										switch (num2)
										{
										case -101:
											goto IL_014b;
										case -100:
											goto IL_01c1;
										case -103:
											goto IL_029f;
										case -102:
											goto end_IL_02a9;
										}
										num3 = -1;
										goto IL_01d9;
										IL_0283:
										num4 = -4;
										goto end_IL_026e;
										IL_01d5:
										num3 = -2;
										goto IL_01d9;
										IL_01f5:
										num5 ^= 0x67;
										goto IL_0204;
										IL_029f:
										num2 = -6;
										goto end_IL_0290;
										IL_014b:
										switch (num)
										{
										case -102:
											break;
										case -101:
											goto IL_017a;
										case -100:
											goto IL_0181;
										case -98:
											goto IL_0188;
										case -97:
											if (num10 == 0)
											{
												goto IL_01aa;
											}
											num = -9;
											goto IL_01c1;
										case -96:
											num10++;
											goto IL_01aa;
										case -99:
											c = text[num10];
											num = -12;
											goto IL_01c1;
										default:
											goto IL_02a5;
											IL_01aa:
											if (num10 >= text.Length)
											{
												return;
											}
											goto case -99;
										}
										num = -16;
										goto IL_01c1;
										IL_02a5:
										num2 = -7;
										goto end_IL_0290;
										IL_0188:
										Delegate526.smethod_0(this).AppendChar(c);
										num = Class10.smethod_0(94);
										goto IL_01c1;
										IL_0181:
										num10 = 0;
										num = -11;
										goto IL_01c1;
										IL_017a:
										text = string_11;
										num = -10;
										goto IL_01c1;
										IL_022c:
										num8 = 6;
										num9 = -2;
										num9 = -100;
										continue;
										IL_01c1:
										num ^= 0x6A;
										goto IL_01c6;
										IL_01c6:
										num2 = GEventArgs2.smethod_0(43);
										num3 = -7;
										goto IL_01d9;
										IL_0218:
										num7 ^= 0x6C;
										num8 = 6;
										num9 = -2;
										num9 = -100;
										continue;
										end_IL_0237:
										break;
									}
									continue;
									end_IL_024c:
									break;
								}
								continue;
								end_IL_0265:
								break;
							}
							continue;
							end_IL_026e:
							break;
						}
						continue;
						end_IL_0287:
						break;
					}
					continue;
					end_IL_0290:
					break;
				}
				continue;
				end_IL_02a9:
				break;
			}
		}
	}

	private string method_10()
	{
		if (Delegate526.smethod_0(this) == null && 0 == 0)
		{
			return null;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.SecureStringToGlobalAllocUnicode(Delegate526.smethod_0(this));
			return Marshal.PtrToStringUni(intPtr);
		}
		finally
		{
			Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
		}
	}
}
