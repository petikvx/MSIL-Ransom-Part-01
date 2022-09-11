using System;
using System.Runtime.CompilerServices;
using System.Xml;

internal abstract class Class27 : IDisposable
{
	[CompilerGenerated]
	private GClass16 gclass16_0;

	public GClass16 GClass16_0
	{
		[CompilerGenerated]
		get
		{
			return gclass16_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass16_0 = value;
		}
	}

	public XmlNodeType XmlNodeType_0 => Delegate286.smethod_0(this).NodeType;

	public string String_0 => Delegate286.smethod_0(this).NamespaceURI;

	public string String_1 => Delegate286.smethod_0(this).LocalName;

	public bool Boolean_0 => Delegate286.smethod_0(this).IsEmptyElement;

	public int Int32_0 => Delegate286.smethod_0(this).Depth;

	public string String_2 => Delegate286.smethod_0(this).Value;

	internal abstract XmlReader XmlReader_0 { get; }

	public abstract bool vmethod_0(Enum10 enum10_0);

	protected Class27(GClass16 gclass16_1)
	{
		Delegate287.smethod_0(this, gclass16_1);
	}

	public virtual void Dispose()
	{
	}

	public bool method_0()
	{
		if (Delegate288.smethod_0(this) == XmlNodeType.Element)
		{
			return Delegate289.smethod_0(this) == "http://winscp.net/schema/session/1.0";
		}
		return false;
	}

	public bool method_1(string string_0)
	{
		if (Delegate290.smethod_0(this) || 1 == 0)
		{
			return Delegate291.smethod_0(this) == string_0;
		}
		return false;
	}

	public bool method_2(string string_0)
	{
		if (Delegate292.smethod_0(this, string_0) || 1 == 0)
		{
			return !Delegate293.smethod_0(this);
		}
		return false;
	}

	public bool method_3(string string_0, out string string_1)
	{
		bool result;
		if ((result = (Delegate292.smethod_0(this, string_0) || 1 == 0) && Delegate293.smethod_0(this)) || 1 == 0)
		{
			while (true)
			{
				int num = 62;
				int num2 = 6;
				while (true)
				{
					num2 ^= 0x5A;
					while (true)
					{
						int num3 = Class8.smethod_0(38);
						int num4 = 58;
						while (true)
						{
							num4 ^= 0x61;
							while (true)
							{
								int num5 = Class8.smethod_0(37);
								int num6 = 55;
								while (true)
								{
									num6 ^= 0x57;
									while (true)
									{
										int num7 = 2;
										int num8 = -16;
										while (true)
										{
											IL_01eb:
											num8 ^= 0x57;
											int num9 = Class8.smethod_0(48);
											while (true)
											{
												switch (num9 ^ 0x58)
												{
												default:
													num9 = Class8.smethod_0(48);
													continue;
												case -94:
													break;
												case -93:
													goto IL_01da;
												case -91:
													goto IL_01eb;
												case -92:
													while (true)
													{
														num9 = -4;
														num9 = -92;
													}
												}
												break;
											}
											switch (num8)
											{
											case -91:
												goto IL_007d;
											case -90:
												goto IL_01ba;
											case -89:
												goto IL_01c0;
											case -92:
												goto end_IL_01eb;
											}
											num9 = -5;
											num9 = -93;
											goto IL_01da;
											IL_019e:
											num4 = 56;
											num5 = -14;
											goto IL_01a6;
											IL_01c0:
											num7 ^= 0x5A;
											num8 = GEventArgs2.smethod_0(44);
											num9 = -3;
											num9 = -91;
											continue;
											IL_01ba:
											num8 = -15;
											continue;
											IL_007d:
											switch (num7)
											{
											case 88:
												goto IL_00a5;
											case 89:
												goto IL_01ad;
											case 90:
												goto IL_01b5;
											case 91:
												goto end_IL_0200;
											}
											num8 = Class8.smethod_0(58);
											continue;
											IL_01b5:
											num7 = 0;
											goto IL_01c0;
											IL_00a5:
											switch (num6)
											{
											case 95:
												goto IL_00c7;
											case 96:
												goto IL_01a6;
											case 94:
												goto IL_0209;
											case 93:
												goto end_IL_0213;
											}
											num7 = 3;
											goto IL_01c0;
											IL_0209:
											num6 = 9;
											goto end_IL_0200;
											IL_00c7:
											switch (num5)
											{
											case -88:
												break;
											case -87:
												goto IL_00ef;
											case -86:
												goto IL_019e;
											default:
												goto IL_020f;
											case -85:
												goto end_IL_021c;
											}
											num5 = -15;
											goto IL_01a6;
											IL_020f:
											num6 = 10;
											goto end_IL_0200;
											IL_00ef:
											switch (num4)
											{
											case 89:
												goto IL_0112;
											case 91:
												goto IL_0199;
											case 90:
												goto IL_0231;
											case 88:
												goto end_IL_0235;
											}
											num5 = -13;
											goto IL_01a6;
											IL_0231:
											num4 = 59;
											goto end_IL_021c;
											IL_0112:
											switch (num3)
											{
											case -96:
												break;
											case -95:
												goto IL_0190;
											case -94:
												goto IL_0196;
											default:
												goto IL_022b;
											case -93:
												goto end_IL_023e;
											}
											switch (num2)
											{
											case 90:
												goto IL_014e;
											case 92:
												goto IL_018b;
											case 91:
												goto IL_0250;
											case 89:
												goto end_IL_0252;
											}
											num3 = -3;
											goto IL_0199;
											IL_022b:
											num4 = 57;
											goto end_IL_021c;
											IL_0196:
											num3 = -2;
											goto IL_0199;
											IL_01a6:
											num5 ^= 0x59;
											goto IL_01ad;
											IL_0250:
											num2 = 1;
											goto end_IL_023e;
											IL_014e:
											switch (num)
											{
											case 95:
												break;
											case 96:
												goto IL_0170;
											case 97:
												goto IL_017b;
											default:
												goto IL_024c;
											case 98:
												goto end_IL_0259;
											}
											num = 0;
											goto IL_018b;
											IL_024c:
											num2 = 3;
											goto end_IL_023e;
											IL_017b:
											string_1 = Delegate294.smethod_0(this, "value");
											num = 63;
											goto IL_018b;
											IL_0170:
											result = string_1 != null;
											num = 61;
											goto IL_018b;
											IL_01da:
											num8 = GEventArgs2.smethod_0(44);
											num9 = -3;
											num9 = -91;
											continue;
											IL_018b:
											num ^= 0x5F;
											goto IL_0190;
											IL_0190:
											num2 = 0;
											num3 = -1;
											goto IL_0199;
											IL_01ad:
											num6 = 8;
											num7 = 1;
											goto IL_01c0;
											IL_0199:
											num3 ^= 0x5C;
											goto IL_019e;
											continue;
											end_IL_01eb:
											break;
										}
										continue;
										end_IL_0200:
										break;
									}
									continue;
									end_IL_0213:
									break;
								}
								continue;
								end_IL_021c:
								break;
							}
							continue;
							end_IL_0235:
							break;
						}
						continue;
						end_IL_023e:
						break;
					}
					continue;
					end_IL_0252:
					break;
				}
				continue;
				end_IL_0259:
				break;
			}
		}
		else
		{
			string_1 = null;
		}
		return result;
	}

	public bool method_4(string string_0)
	{
		if (Delegate288.smethod_0(this) == XmlNodeType.EndElement && (Delegate289.smethod_0(this) == "http://winscp.net/schema/session/1.0" || 1 == 0))
		{
			return Delegate291.smethod_0(this) == string_0;
		}
		return false;
	}

	public bool method_5(string string_0, Enum10 enum10_0)
	{
		bool flag = false;
		while (!flag && 0 == 0 && (Delegate43.smethod_0(this, enum10_0) ? true : false))
		{
			if (Delegate295.smethod_0(this, string_0) || 1 == 0)
			{
				flag = true;
			}
		}
		return flag;
	}

	public void method_6(string string_0, Enum10 enum10_0)
	{
		if (!Delegate296.smethod_0(this, string_0, enum10_0) && 0 == 0)
		{
			throw Delegate297.smethod_0(Delegate173.smethod_0(this), string_0);
		}
	}

	public bool method_7(string string_0, Enum10 enum10_0)
	{
		bool flag = false;
		while (!flag && 0 == 0 && (Delegate43.smethod_0(this, enum10_0) ? true : false))
		{
			if ((Delegate292.smethod_0(this, string_0) || 1 == 0) && (Delegate293.smethod_0(this) || 1 == 0))
			{
				flag = true;
			}
		}
		return flag;
	}

	public Class28 method_8()
	{
		return Delegate35.smethod_0(this);
	}

	public Class28 method_9(string string_0, Enum10 enum10_0)
	{
		Delegate298.smethod_0(this, string_0, enum10_0);
		return Delegate299.smethod_0(this);
	}

	public Class28 method_10()
	{
		return Delegate300.smethod_0(this, "group", Enum10.flag_0);
	}

	public string method_11(string string_0)
	{
		return Delegate286.smethod_0(this).GetAttribute(string_0);
	}
}
