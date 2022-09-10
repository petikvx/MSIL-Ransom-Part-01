using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public class GForm1 : Form
{
	private object object_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("picZoom")]
	private PictureBox pictureBox_0;

	[CompilerGenerated]
	[AccessedThroughProperty("tZoom")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TrackBar trackBar_0;

	private Rectangle rectangle_0;

	private object object_1;

	private object object_2;

	private Color color_0;

	private object object_3;

	private bool bool_0;

	public static object object_4;

	private DateTime dateTime_0;

	private DateTime dateTime_1;

	private int int_0;

	private int int_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timer")]
	[CompilerGenerated]
	private Timer timer_0;

	private int int_2;

	private bool bool_4;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	internal virtual PictureBox picZoom
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual TrackBar tZoom
	{
		[CompilerGenerated]
		get
		{
			return trackBar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			int num = 0;
			if (!smethod_2())
			{
				goto IL_003e;
			}
			goto IL_0075;
			IL_0075:
			TrackBar val = default(TrackBar);
			EventHandler object_ = default(EventHandler);
			while (true)
			{
				switch (num)
				{
				case 9:
					if (val != null)
					{
						goto case 8;
					}
					goto case 4;
				case 8:
					smethod_40(val, object_);
					goto case 4;
				case 4:
					trackBar_0 = value;
					goto default;
				default:
					val = trackBar_0;
					num = 6;
					if (smethod_3())
					{
					}
					continue;
				case 1:
				case 7:
					val = trackBar_0;
					goto case 9;
				case 6:
					break;
				case 3:
					goto IL_0041;
				case 0:
					object_ = method_10;
					smethod_2();
					if (!smethod_3())
					{
						goto case 1;
					}
					goto default;
				case 10:
					return;
				}
				break;
			}
			goto IL_003e;
			IL_003e:
			if (val == null)
			{
				return;
			}
			goto IL_0041;
			IL_0041:
			smethod_41(val, object_);
			num = 10;
			if (smethod_3())
			{
			}
			goto IL_0075;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = disposing && object_0 != null;
			if (false || !flag)
			{
				return;
			}
			_ = 0;
			if (!smethod_2())
			{
				return;
			}
			if (smethod_2())
			{
				switch (2)
				{
				default:
					return;
				case 0:
				case 2:
					break;
				}
			}
			smethod_0(object_0);
		}
		finally
		{
			smethod_1(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		while (true)
		{
			ComponentResourceManager object_ = new ComponentResourceManager(smethod_4(typeof(GForm1).TypeHandle));
			while (true)
			{
				smethod_5(this, (object)new TrackBar());
				while (true)
				{
					smethod_6(this, (object)new PictureBox());
					while (true)
					{
						smethod_8(smethod_7(this));
						while (true)
						{
							smethod_8(smethod_9(this));
							while (true)
							{
								smethod_10(this);
								while (true)
								{
									smethod_11(smethod_7(this), new Point(120, 0));
									while (true)
									{
										smethod_12(smethod_7(this), 3);
										while (true)
										{
											smethod_13(smethod_7(this), 1);
											while (true)
											{
												smethod_14(smethod_7(this), "tZoom");
												while (true)
												{
													smethod_15(smethod_7(this), new Size(187, 45));
													int num = 30;
													if (!smethod_3())
													{
													}
													while (true)
													{
														switch (num)
														{
														case 35:
															smethod_32(this, bool_5: false);
															goto case 6;
														case 6:
															smethod_33(this, new Size(385, 274));
															num = 24;
															if (smethod_2())
															{
																continue;
															}
															goto case 15;
														case 34:
															smethod_36(this, "SPIRIT.NET - Magnifier");
															goto case 4;
														case 4:
															smethod_37(smethod_7(this));
															goto case 22;
														case 22:
															smethod_37(smethod_9(this));
															num = 5;
															if (smethod_2())
															{
																continue;
															}
															goto end_IL_0319;
														case 33:
															smethod_24(this, new SizeF(6f, 13f));
															goto case 3;
														case 3:
															smethod_25(this, (AutoScaleMode)1);
															goto case 18;
														case 18:
															smethod_26(this, new Size(440, 457));
															smethod_2();
															if (!smethod_3())
															{
																goto case 21;
															}
															goto case 14;
														case 21:
														case 25:
															smethod_28(smethod_27(this), smethod_7(this));
															goto case 20;
														case 20:
															smethod_28(smethod_27(this), smethod_9(this));
															goto case 10;
														case 10:
															smethod_30(this, (object)(Icon)smethod_29(object_, "$this.Icon"));
															goto case 14;
														case 14:
														case 28:
															smethod_31(this, bool_5: false);
															goto case 35;
														case 32:
															smethod_17(smethod_7(this), 1);
															goto case 13;
														case 13:
															smethod_18(smethod_7(this), bool_5: false);
															goto case 11;
														case 11:
															smethod_19(smethod_9(this), (ImageLayout)0);
															goto case 1;
														case 1:
															smethod_20(smethod_9(this), (DockStyle)5);
															goto case 19;
														case 19:
															smethod_11(smethod_9(this), new Point(0, 0));
															num = 12;
															if (smethod_2())
															{
																continue;
															}
															goto end_IL_027b;
														case 30:
															smethod_16(smethod_7(this), 2);
															goto case 32;
														case 24:
															smethod_34(this, "frmMagnifier");
															goto case 23;
														case 23:
															smethod_35(this, (FormStartPosition)0);
															num = 34;
															if (!smethod_3())
															{
																continue;
															}
															goto case 10;
														case 16:
															smethod_15(smethod_9(this), new Size(440, 457));
															goto case 7;
														case 7:
															smethod_21(smethod_9(this), (PictureBoxSizeMode)1);
															goto default;
														default:
															smethod_22(smethod_9(this), 0);
															goto case 8;
														case 8:
															smethod_23(smethod_9(this), bool_5: false);
															goto case 33;
														case 12:
															smethod_14(smethod_9(this), "picZoom");
															goto case 16;
														case 36:
															break;
														case 27:
															goto end_IL_027b;
														case 17:
															goto end_IL_02a7;
														case 26:
															goto end_IL_02b9;
														case 39:
															goto end_IL_02c7;
														case 37:
															goto end_IL_02d5;
														case 29:
															goto end_IL_02ea;
														case 0:
															goto end_IL_02f2;
														case 2:
															goto end_IL_02ff;
														case 31:
															goto end_IL_030c;
														case 38:
															goto end_IL_0319;
														case 5:
															smethod_38(this, bool_5: false);
															goto case 15;
														case 15:
															smethod_39(this);
															return;
														case 40:
															return;
														}
														break;
													}
													continue;
													end_IL_027b:
													break;
												}
												continue;
												end_IL_02a7:
												break;
											}
											continue;
											end_IL_02b9:
											break;
										}
										continue;
										end_IL_02c7:
										break;
									}
									continue;
									end_IL_02d5:
									break;
								}
								continue;
								end_IL_02ea:
								break;
							}
							continue;
							end_IL_02f2:
							break;
						}
						continue;
						end_IL_02ff:
						break;
					}
					continue;
					end_IL_030c:
					break;
				}
				continue;
				end_IL_0319:
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void vmethod_1(Timer timer_1)
	{
		while (true)
		{
			EventHandler object_ = method_7;
			while (true)
			{
				Timer val = timer_0;
				while (true)
				{
					if (val != null)
					{
						while (true)
						{
							smethod_42(val, object_);
							if (smethod_3())
							{
							}
							switch (0)
							{
							case 8:
								break;
							case 4:
								goto end_IL_0003;
							case 2:
								goto end_IL_0049;
							case 1:
								goto end_IL_004e;
							case 0:
								goto IL_0066;
							default:
								goto IL_006d;
							case 5:
							case 7:
								goto IL_007a;
							case 3:
							case 6:
								goto IL_0084;
							case 9:
								goto IL_0087;
							case 10:
								return;
							}
							continue;
							end_IL_0003:
							break;
						}
						continue;
					}
					goto IL_0066;
					IL_0087:
					smethod_43(val, object_);
					return;
					IL_0066:
					timer_0 = timer_1;
					goto IL_006d;
					IL_006d:
					smethod_3();
					if (smethod_2())
					{
						goto IL_007a;
					}
					goto IL_0084;
					IL_007a:
					val = timer_0;
					goto IL_0084;
					IL_0084:
					if (val == null)
					{
						return;
					}
					goto IL_0087;
					continue;
					end_IL_0049:
					break;
				}
				continue;
				end_IL_004e:
				break;
			}
		}
	}

	public GForm1(ref PictureBox pictureBox_1)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		PictureBox object_ = default(PictureBox);
		while (true)
		{
			smethod_44(this);
			while (true)
			{
				IL_0189:
				smethod_45(this, (object)new FormClosingEventHandler(method_9));
				int num = 1;
				if (!smethod_2())
				{
					goto IL_0006;
				}
				goto IL_011f;
				IL_011f:
				while (true)
				{
					switch (num)
					{
					case 14:
					case 22:
						break;
					case 16:
						goto IL_000d;
					case 13:
						goto IL_0014;
					case 9:
					case 17:
						goto IL_001b;
					case 21:
						this.object_2 = null;
						num = 18;
						if (smethod_2())
						{
							continue;
						}
						goto case 15;
					case 20:
						bool_2 = false;
						goto default;
					default:
						bool_3 = true;
						goto case 8;
					case 8:
						smethod_47(this, (object)new Timer());
						goto case 4;
					case 4:
						bool_4 = false;
						_ = 0;
						if (smethod_2())
						{
							num = 22;
							if (!smethod_3())
							{
								continue;
							}
							goto case 11;
						}
						num = 9;
						if (!smethod_3())
						{
							continue;
						}
						goto case 5;
					case 5:
						rectangle_0 = default(Rectangle);
						goto case 11;
					case 11:
						object_1 = null;
						goto case 21;
					case 15:
						bool_1 = false;
						goto case 20;
					case 18:
						color_0 = default(Color);
						goto case 3;
					case 3:
						object_3 = null;
						goto case 10;
					case 10:
						bool_0 = false;
						goto case 15;
					case 12:
						method_0();
						goto case 7;
					case 7:
						flag = (pictureBox_1 != null) & (smethod_48(pictureBox_1) != null);
						num = 0;
						if (smethod_2())
						{
							continue;
						}
						goto IL_000d;
					case 1:
						smethod_46(this, new EventHandler(method_11));
						num = 5;
						if (!smethod_3())
						{
							continue;
						}
						goto case 12;
					case 6:
						goto IL_0189;
					case 2:
						goto end_IL_0189;
					case 0:
						if (flag)
						{
							goto IL_01c2;
						}
						return;
					case 23:
						goto IL_01c2;
					}
					break;
				}
				goto IL_0006;
				IL_0006:
				int_3 = 0;
				goto IL_000d;
				IL_000d:
				int_4 = 0;
				goto IL_0014;
				IL_0014:
				int_5 = 0;
				goto IL_001b;
				IL_001b:
				int_6 = 0;
				num = 12;
				if (!smethod_3())
				{
					goto IL_011f;
				}
				goto IL_01c2;
				IL_01c2:
				try
				{
					object_3 = pictureBox_1;
					while (true)
					{
						object_1 = smethod_48(pictureBox_1);
						while (true)
						{
							IL_0270:
							object_4 = object_1;
							while (true)
							{
								rectangle_0 = new Rectangle(0, 0, checked(smethod_49(object_3) - 40), 100);
								int num2 = 8;
								if (smethod_3())
								{
									break;
								}
								while (true)
								{
									switch (num2)
									{
									case 8:
									{
										ref Rectangle reference = ref rectangle_0;
										Form form_ = (Form)(object)this;
										GClass25.smethod_5(ref reference, ref form_, ref bool_3);
										_ = 0;
										if (smethod_2())
										{
											num2 = 5;
											if (smethod_2())
											{
												continue;
											}
											goto case 14;
										}
										goto case 6;
									}
									case 10:
										break;
									case 0:
										goto IL_0270;
									case 9:
										goto end_IL_0245;
									case 4:
									case 5:
										smethod_50(object_3, (EventHandler)delegate(object sender, EventArgs e)
										{
											//IL_0008: Unknown result type (might be due to invalid IL or missing references)
											//IL_0012: Expected O, but got Unknown
											method_2(smethod_78(sender), (MouseEventArgs)e);
										});
										goto case 13;
									case 13:
										smethod_51(object_3, (object)new PaintEventHandler(method_8));
										goto default;
									default:
										smethod_52(object_3, (object)new MouseEventHandler(method_5));
										goto case 12;
									case 12:
										smethod_53(object_3, (object)new MouseEventHandler(method_4));
										goto case 1;
									case 1:
										smethod_54(object_3, (object)new MouseEventHandler(method_3));
										goto case 2;
									case 2:
										method_1();
										goto case 7;
									case 7:
										smethod_55(smethod_9(this));
										goto case 6;
									case 6:
									case 11:
									{
										ref object image_ = ref object_1;
										ref Rectangle reference2 = ref rectangle_0;
										ref object image_2 = ref this.object_2;
										int num3 = smethod_56(smethod_7(this));
										object_ = (PictureBox)smethod_9(this);
										GClass25.smethod_3(ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_), ref reference2, ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_2), num3, ref object_);
										goto case 14;
									}
									case 14:
										smethod_6(this, object_);
										return;
									}
									break;
								}
								continue;
								end_IL_0245:
								break;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					smethod_57(ex);
					Exception object_2 = ex;
					smethod_60(smethod_59("Error When Loading Magnifier - Please Restart Spirit Magnifier ", smethod_58(object_2)), (MsgBoxStyle)16, "Magnifier Error");
					smethod_61();
					return;
				}
				continue;
				end_IL_0189:
				break;
			}
		}
	}

	public GForm1()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		int num = 10;
		if (!smethod_2())
		{
			goto IL_0077;
		}
		goto IL_00db;
		IL_00db:
		switch (num)
		{
		case 14:
		case 20:
			break;
		default:
			goto IL_002d;
		case 4:
			goto IL_0044;
		case 9:
		case 13:
			goto IL_0058;
		case 18:
			object_2 = null;
			goto case 6;
		case 6:
			color_0 = default(Color);
			goto IL_0077;
		case 17:
			goto IL_0077;
		case 11:
			goto IL_007e;
		case 12:
			goto IL_0085;
		case 15:
			object_1 = null;
			goto case 18;
		case 10:
			smethod_44(this);
			goto case 7;
		case 7:
			smethod_45(this, (object)new FormClosingEventHandler(method_9));
			goto case 2;
		case 2:
			smethod_46(this, new EventHandler(method_11));
			goto case 0;
		case 0:
			rectangle_0 = default(Rectangle);
			goto case 15;
		case 1:
			bool_3 = true;
			goto IL_0044;
		case 8:
			int_4 = 0;
			goto case 16;
		case 16:
			int_5 = 0;
			goto case 3;
		case 3:
			int_6 = 0;
			goto case 5;
		case 5:
			method_0();
			return;
		case 21:
			return;
		}
		goto IL_0012;
		IL_007e:
		bool_0 = false;
		goto IL_0085;
		IL_0012:
		int_3 = 0;
		num = 8;
		if (smethod_3())
		{
		}
		goto IL_00db;
		IL_0058:
		bool_4 = false;
		goto IL_0012;
		IL_0077:
		object_3 = null;
		goto IL_007e;
		IL_0044:
		smethod_47(this, (object)new Timer());
		_ = 1;
		if (smethod_3())
		{
			goto IL_0012;
		}
		goto IL_0058;
		IL_002d:
		bool_2 = false;
		num = 1;
		if (!smethod_2())
		{
			goto IL_0044;
		}
		goto IL_00db;
		IL_0085:
		bool_1 = false;
		goto IL_002d;
	}

	private void method_1()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			object_2 = smethod_63(object_1, new Size(smethod_49(object_3), smethod_62(object_3)), (InterpolationMode)2);
			smethod_3();
			if (smethod_2())
			{
				goto IL_0043;
			}
			goto IL_004e;
			IL_004e:
			if (true)
			{
				return;
			}
			goto IL_0043;
			IL_0043:
			smethod_55(object_3);
			goto IL_004e;
		}
		catch (Exception ex)
		{
			smethod_57(ex);
			Exception object_ = ex;
			smethod_60(smethod_59("Error When Resizing Magnified Area - Please Restart Spirit Magnifier ", smethod_58(object_)), (MsgBoxStyle)16, "Magnifier Error");
			smethod_61();
		}
	}

	private void method_2(object sender, MouseEventArgs e)
	{
		checked
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			Point point = default(Point);
			float num2 = default(float);
			float num3 = default(float);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			while (true)
			{
				dateTime_1 = smethod_64();
				while (true)
				{
					TimeSpan timeSpan = dateTime_1.Subtract(dateTime_0);
					while (true)
					{
						int_2 = (int)smethod_65(timeSpan.TotalMilliseconds);
						smethod_3();
						if (!smethod_2())
						{
							goto IL_027f;
						}
						goto IL_0045;
						IL_0045:
						flag = (int_2 <= 399) & !method_12(rectangle_0);
						goto IL_0066;
						IL_0066:
						int num;
						if (flag)
						{
							num = 9;
							if (!smethod_3())
							{
							}
							goto IL_0078;
						}
						return;
						IL_011c:
						if (flag2)
						{
							goto IL_00ee;
						}
						return;
						IL_0078:
						switch (num)
						{
						case 7:
							break;
						case 3:
						case 8:
							goto IL_0045;
						case 4:
							goto IL_0066;
						case 12:
							goto IL_00ee;
						case 24:
							goto IL_011c;
						case 25:
							goto IL_0125;
						case 2:
							goto IL_0131;
						case 9:
							point = smethod_67(object_3, smethod_66());
							goto case 6;
						case 6:
							bool_1 = false;
							goto case 11;
						case 11:
							bool_4 = false;
							goto case 1;
						case 1:
							num2 = (float)((double)smethod_49(object_3) - (double)rectangle_0.Width / (double)smethod_56(smethod_7(this)));
							goto case 20;
						case 20:
							num3 = (float)((double)smethod_62(object_3) - (double)rectangle_0.Height / (double)smethod_56(smethod_7(this)));
							goto case 13;
						case 13:
							rectangle_0.X = (int)smethod_65((double)point.X - (double)rectangle_0.Width / (double)smethod_56(smethod_7(this)) / 2.0);
							goto case 21;
						case 21:
							rectangle_0.Y = (int)smethod_65((double)point.Y - (double)rectangle_0.Height / (double)smethod_56(smethod_7(this)) / 2.0);
							goto case 14;
						case 14:
							flag3 = rectangle_0.Left < 0;
							goto default;
						default:
							if (flag3)
							{
								goto case 19;
							}
							flag4 = (float)rectangle_0.X > num2;
							goto IL_027f;
						case 19:
							rectangle_0.X = 0;
							goto IL_0259;
						case 17:
						case 23:
							goto IL_0259;
						case 10:
						case 16:
							goto IL_027f;
						case 0:
							goto end_IL_0006;
						case 15:
							goto end_IL_028e;
						case 18:
							goto IL_02b2;
						case 5:
						case 26:
							return;
						}
						continue;
						IL_027f:
						if (flag4)
						{
							goto IL_0131;
						}
						goto IL_0259;
						IL_0131:
						rectangle_0.X = (int)smethod_65(num2 - 1f);
						goto IL_0259;
						IL_0259:
						flag5 = rectangle_0.Top < 0;
						goto IL_0125;
						IL_0125:
						if (!flag5)
						{
							flag2 = (float)rectangle_0.Y > num3;
							goto IL_011c;
						}
						goto IL_02b2;
						IL_02b2:
						rectangle_0.Y = 0;
						return;
						IL_00ee:
						rectangle_0.Y = (int)smethod_65(num3 - 1f);
						num = 26;
						if (smethod_3())
						{
						}
						goto IL_0078;
						continue;
						end_IL_0006:
						break;
					}
					continue;
					end_IL_028e:
					break;
				}
			}
		}
	}

	private void method_3(object sender, MouseEventArgs e)
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool_1 = false;
			_ = 1;
			if (!smethod_3())
			{
				goto IL_00b3;
			}
			goto IL_00ba;
			IL_00ba:
			while (true)
			{
				smethod_68(this);
				while (true)
				{
					IL_00a0:
					method_12(rectangle_0);
					while (true)
					{
						IL_0093:
						smethod_55(object_3);
						while (true)
						{
							ref object image_ = ref object_1;
							ref Rectangle reference = ref rectangle_0;
							ref object image_2 = ref this.object_2;
							int num = smethod_56(smethod_7(this));
							PictureBox object_ = (PictureBox)smethod_9(this);
							GClass25.smethod_3(ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_), ref reference, ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_2), num, ref object_);
							int num2 = 2;
							if (smethod_3())
							{
								break;
							}
							while (true)
							{
								switch (num2)
								{
								default:
									num2 = 7;
									if (!smethod_3())
									{
										continue;
									}
									goto end_IL_00ba;
								case 7:
									break;
								case 4:
									goto IL_0093;
								case 5:
									goto IL_00a0;
								case 0:
								case 6:
									goto end_IL_00ba;
								case 1:
								case 8:
									goto end_IL_005a;
								case 2:
									smethod_6(this, object_);
									goto case 3;
								case 3:
									smethod_69();
									return;
								case 9:
									return;
								}
								break;
							}
							continue;
							end_IL_005a:
							break;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_00ba:
				break;
			}
			goto IL_00b3;
			IL_00b3:
			bool_4 = false;
			goto IL_00ba;
		}
		catch (Exception ex)
		{
			smethod_57(ex);
			Exception object_2 = ex;
			smethod_60(smethod_59("Magnifier Error Detected - Please Restart Spirit Magnifier ", smethod_58(object_2)), (MsgBoxStyle)16, "Magnifier Error");
			smethod_61();
		}
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		int num = 6;
		checked
		{
			if (smethod_2())
			{
				bool flag = default(bool);
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				bool flag5 = default(bool);
				bool flag6 = default(bool);
				Point point = default(Point);
				bool flag2 = default(bool);
				while (true)
				{
					switch (num)
					{
					case 28:
						rectangle_0.X = int_3;
						goto case 21;
					case 21:
					case 24:
					case 26:
						flag = int_4 < int_6;
						num = 7;
						if (smethod_3())
						{
						}
						continue;
					case 27:
						flag3 = int_3 < int_5;
						num = 17;
						if (!smethod_3())
						{
							continue;
						}
						goto case 13;
					case 13:
						smethod_75(object_3, smethod_74());
						goto case 5;
					case 5:
					case 20:
						flag4 = bool_1;
						goto case 1;
					case 1:
						if (flag4)
						{
							goto case 0;
						}
						flag5 = int_2 > 400;
						goto case 15;
					case 0:
						bool_2 = true;
						num = 12;
						if (smethod_2())
						{
							continue;
						}
						goto case 15;
					case 15:
						if (!flag5)
						{
							return;
						}
						goto case 8;
					case 8:
						flag6 = !bool_4;
						goto case 4;
					case 4:
						if (flag6)
						{
							_ = 0;
							if (smethod_2())
							{
								num = 29;
								if (smethod_3())
								{
								}
								continue;
							}
							goto case 21;
						}
						point = smethod_67(object_3, smethod_66());
						goto default;
					default:
						int_5 = point.X;
						goto case 9;
					case 9:
						int_6 = point.Y;
						num = 27;
						if (smethod_3())
						{
						}
						continue;
					case 17:
						if (flag3)
						{
							goto case 28;
						}
						rectangle_0.X = int_5;
						goto case 21;
					case 6:
						flag2 = rectangle_0.Contains(smethod_70(e), smethod_71(e)) & smethod_73(smethod_72(this));
						goto case 2;
					case 2:
						if (flag2)
						{
							goto case 13;
						}
						smethod_75(object_3, smethod_76());
						num = 5;
						if (smethod_2())
						{
							continue;
						}
						goto case 12;
					case 7:
						if (!flag)
						{
							rectangle_0.Y = int_6;
							break;
						}
						goto case 25;
					case 12:
						rectangle_0.X = smethod_70(e) + int_0;
						goto case 3;
					case 3:
						rectangle_0.Y = smethod_71(e) + int_1;
						goto case 30;
					case 25:
						rectangle_0.Y = int_4;
						break;
					case 10:
					case 18:
						break;
					case 11:
						goto IL_026f;
					case 19:
						goto IL_028c;
					case 22:
						goto IL_02a9;
					case 30:
						method_6();
						return;
					case 14:
					case 16:
					case 29:
					case 31:
						return;
					}
					break;
				}
			}
			method_6();
			goto IL_026f;
		}
		IL_026f:
		rectangle_0.Width = smethod_77(checked(int_5 - int_3));
		goto IL_028c;
		IL_02a9:
		method_11(smethod_78(sender), (EventArgs)(object)e);
		return;
		IL_028c:
		rectangle_0.Height = smethod_77(checked(int_6 - int_4));
		goto IL_02a9;
	}

	private void method_5(object sender, MouseEventArgs e)
	{
		smethod_3();
		if (smethod_2())
		{
			int num = 8;
			bool flag2 = default(bool);
			if (!smethod_3())
			{
				bool flag = default(bool);
				while (true)
				{
					switch (num)
					{
					case 11:
						flag = rectangle_0.Contains(smethod_70(e), smethod_71(e));
						num = 6;
						if (!smethod_3())
						{
							continue;
						}
						goto IL_00e4;
					case 0:
					case 8:
						dateTime_0 = smethod_64();
						goto case 11;
					default:
						return;
					case 6:
						if (!flag)
						{
							flag2 = int_2 > 400;
							break;
						}
						goto case 2;
					case 2:
						bool_1 = true;
						goto case 10;
					case 4:
						break;
					case 9:
						goto IL_00b4;
					case 3:
						goto IL_00bb;
					case 10:
						int_0 = checked(rectangle_0.X - smethod_70(e));
						goto IL_00f3;
					case 12:
						goto IL_00e4;
					case 5:
					case 7:
						goto IL_00f3;
					case 1:
					case 13:
						return;
					}
					break;
				}
			}
			if (!flag2)
			{
				return;
			}
			goto IL_00b4;
		}
		goto IL_00f3;
		IL_00b4:
		bool_4 = true;
		goto IL_00bb;
		IL_00bb:
		int_3 = smethod_70(e);
		goto IL_00e4;
		IL_00f3:
		int_1 = checked(rectangle_0.Y - smethod_71(e));
		return;
		IL_00e4:
		int_4 = smethod_71(e);
	}

	public void method_6()
	{
		checked
		{
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				float num = (float)((double)smethod_49(object_3) - (double)rectangle_0.Width / (double)smethod_56(smethod_7(this)));
				while (true)
				{
					float num2 = (float)((double)smethod_62(object_3) - (double)rectangle_0.Height / (double)smethod_56(smethod_7(this)));
					while (true)
					{
						bool flag = rectangle_0.Left < 0;
						if (smethod_3())
						{
						}
						switch (13)
						{
						case 14:
							break;
						case 8:
							goto end_IL_0006;
						case 3:
							goto end_IL_006f;
						case 13:
							if (flag)
							{
								goto case 2;
							}
							flag2 = (float)rectangle_0.X > num;
							goto case 5;
						case 2:
							rectangle_0.X = 0;
							goto default;
						case 5:
							if (flag2)
							{
								goto case 11;
							}
							goto default;
						case 11:
							rectangle_0.X = (int)smethod_65(num - 1f);
							goto default;
						default:
							flag3 = rectangle_0.Top < 0;
							goto case 9;
						case 9:
							if (flag3)
							{
								smethod_2();
								if (!smethod_3())
								{
									goto case 10;
								}
							}
							else
							{
								flag4 = (float)rectangle_0.Y > num2;
							}
							goto case 7;
						case 7:
						case 12:
							if (!flag4)
							{
								return;
							}
							goto case 1;
						case 1:
							rectangle_0.Y = (int)smethod_65(num2 - 1f);
							return;
						case 10:
						case 15:
							rectangle_0.Y = 0;
							return;
						case 4:
						case 16:
							return;
						}
						continue;
						end_IL_0006:
						break;
					}
					continue;
					end_IL_006f:
					break;
				}
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		checked
		{
			int_2++;
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool flag = !bool_0;
			smethod_2();
			if (smethod_3() || (flag && object_1 != null))
			{
				GClass25.smethod_4(ref rectangle_0, smethod_56(smethod_7(this)), ref System.Runtime.CompilerServices.Unsafe.As<object, PictureBox>(ref object_3), ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref object_2));
			}
			smethod_69();
		}
		catch (Exception ex)
		{
			smethod_57(ex);
			Exception object_ = ex;
			smethod_60(smethod_59("Magnifier Error While adjusting area - Please Restart Spirit Magnifier ", smethod_58(object_)), (MsgBoxStyle)16, "Magnifier Error");
			smethod_61();
		}
	}

	private void method_9(object sender, FormClosingEventArgs e)
	{
		_ = 0;
		if (smethod_2())
		{
			smethod_79(rectangle_0, this, smethod_56(smethod_7(this)));
			bool_0 = true;
		}
		smethod_80(object_3, object_4);
		smethod_69();
		smethod_81(this);
	}

	private void method_10(object sender, EventArgs e)
	{
		_ = 0;
		PictureBox object_ = default(PictureBox);
		if (smethod_2())
		{
			smethod_55(object_3);
			ref object image_ = ref object_1;
			ref Rectangle reference = ref rectangle_0;
			ref object image_2 = ref object_2;
			int num = smethod_56(smethod_7(this));
			object_ = (PictureBox)smethod_9(this);
			GClass25.smethod_3(ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_), ref reference, ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_2), num, ref object_);
		}
		smethod_6(this, object_);
	}

	private void method_11(object sender, EventArgs e)
	{
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				bool flag = !bool_3;
				_ = 0;
				if (smethod_2())
				{
					PictureBox object_ = default(PictureBox);
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					while (true)
					{
						IL_0132:
						int num;
						if (flag)
						{
							num = 9;
							if (smethod_3())
							{
								goto IL_008b;
							}
							goto IL_00ea;
						}
						return;
						IL_0096:
						ref object image_ = ref object_1;
						ref Rectangle reference = ref rectangle_0;
						ref object image_2 = ref this.object_2;
						int num2 = smethod_56(smethod_7(this));
						object_ = (PictureBox)smethod_9(this);
						GClass25.smethod_3(ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_), ref reference, ref System.Runtime.CompilerServices.Unsafe.As<object, Image>(ref image_2), num2, ref object_);
						num = 8;
						if (!smethod_2())
						{
							continue;
						}
						goto IL_00ea;
						IL_00ea:
						while (true)
						{
							switch (num)
							{
							case 14:
								if (!flag2)
								{
									return;
								}
								goto case 13;
							case 13:
								flag3 = bool_4;
								goto case 5;
							case 5:
								if (!flag3)
								{
									rectangle_0.Width = (int)smethod_65((double)smethod_84(this) / 2.0);
									goto case 2;
								}
								goto case 3;
							case 2:
								rectangle_0.Height = (int)smethod_65((double)smethod_85(this) / 2.0);
								goto case 7;
							case 7:
								method_6();
								break;
							case 11:
								break;
							case 1:
								goto IL_0096;
							case 9:
								flag2 = rectangle_0.Width > 0;
								num = 14;
								if (!smethod_3())
								{
								}
								continue;
							default:
								return;
							case 0:
							case 10:
								goto IL_0132;
							case 8:
								smethod_6(this, object_);
								return;
							case 3:
								smethod_82(this, rectangle_0.Width * 2);
								goto end_IL_0132;
							case 6:
							case 12:
								goto end_IL_0132;
							case 4:
							case 15:
								return;
							}
							break;
						}
						goto IL_008b;
						IL_008b:
						smethod_55(object_3);
						goto IL_0096;
						continue;
						end_IL_0132:
						break;
					}
				}
				smethod_83(this, rectangle_0.Height * 2);
			}
			catch (Exception ex)
			{
				smethod_57(ex);
				Exception object_2 = ex;
				smethod_60(smethod_59("Magnifier Error While Resizing Window - Please Restart Spirit Magnifier ", smethod_58(object_2)), (MsgBoxStyle)16, "Magnifier Error");
				smethod_61();
			}
		}
	}

	public bool method_12(Rectangle rectangle_1)
	{
		smethod_2();
		if (smethod_3())
		{
			goto IL_001c;
		}
		int num = 3;
		if (smethod_3())
		{
		}
		goto IL_004d;
		IL_0075:
		method_13();
		goto IL_007b;
		IL_001c:
		bool flag = default(bool);
		if (flag)
		{
			num = 6;
			if (smethod_2())
			{
				goto IL_004d;
			}
			goto IL_0075;
		}
		return false;
		IL_007b:
		return true;
		IL_004d:
		switch (num)
		{
		case 1:
		case 5:
			break;
		case 0:
		case 3:
			flag = (rectangle_1.Width <= 50) | (rectangle_1.Height <= 20);
			break;
		case 6:
			goto IL_0075;
		default:
			goto IL_007b;
		case 2:
		case 7:
		{
			bool result = default(bool);
			return result;
		}
		}
		goto IL_001c;
	}

	public void method_13()
	{
		checked
		{
			rectangle_0.Width = (int)smethod_65((double)smethod_84(this) / 2.0);
			for (int num = 0; num == 0; num = 1)
			{
				rectangle_0.Height = (int)smethod_65((double)smethod_85(this) / 2.0);
			}
		}
	}

	internal static void smethod_0(object object_5)
	{
		((IDisposable)object_5).Dispose();
	}

	internal static void smethod_1(object object_5, bool bool_5)
	{
		((Form)object_5).Dispose(bool_5);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}

	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void smethod_5(object object_5, object object_6)
	{
		((GForm1)object_5).tZoom = (TrackBar)object_6;
	}

	internal static void smethod_6(object object_5, object object_6)
	{
		((GForm1)object_5).picZoom = (PictureBox)object_6;
	}

	internal static object smethod_7(object object_5)
	{
		return ((GForm1)object_5).tZoom;
	}

	internal static void smethod_8(object object_5)
	{
		((ISupportInitialize)object_5).BeginInit();
	}

	internal static object smethod_9(object object_5)
	{
		return ((GForm1)object_5).picZoom;
	}

	internal static void smethod_10(object object_5)
	{
		((Control)object_5).SuspendLayout();
	}

	internal static void smethod_11(object object_5, Point point_0)
	{
		((Control)object_5).set_Location(point_0);
	}

	internal static void smethod_12(object object_5, int int_7)
	{
		((TrackBar)object_5).set_Maximum(int_7);
	}

	internal static void smethod_13(object object_5, int int_7)
	{
		((TrackBar)object_5).set_Minimum(int_7);
	}

	internal static void smethod_14(object object_5, object object_6)
	{
		((Control)object_5).set_Name((string)object_6);
	}

	internal static void smethod_15(object object_5, Size size_0)
	{
		((Control)object_5).set_Size(size_0);
	}

	internal static void smethod_16(object object_5, int int_7)
	{
		((Control)object_5).set_TabIndex(int_7);
	}

	internal static void smethod_17(object object_5, int int_7)
	{
		((TrackBar)object_5).set_Value(int_7);
	}

	internal static void smethod_18(object object_5, bool bool_5)
	{
		((Control)object_5).set_Visible(bool_5);
	}

	internal static void smethod_19(object object_5, ImageLayout imageLayout_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_5).set_BackgroundImageLayout(imageLayout_0);
	}

	internal static void smethod_20(object object_5, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_5).set_Dock(dockStyle_0);
	}

	internal static void smethod_21(object object_5, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PictureBox)object_5).set_SizeMode(pictureBoxSizeMode_0);
	}

	internal static void smethod_22(object object_5, int int_7)
	{
		((PictureBox)object_5).set_TabIndex(int_7);
	}

	internal static void smethod_23(object object_5, bool bool_5)
	{
		((PictureBox)object_5).set_TabStop(bool_5);
	}

	internal static void smethod_24(object object_5, SizeF sizeF_0)
	{
		((ContainerControl)object_5).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void smethod_25(object object_5, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_5).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void smethod_26(object object_5, Size size_0)
	{
		((Form)object_5).set_ClientSize(size_0);
	}

	internal static object smethod_27(object object_5)
	{
		return ((Control)object_5).get_Controls();
	}

	internal static void smethod_28(object object_5, object object_6)
	{
		((ControlCollection)object_5).Add((Control)object_6);
	}

	internal static object smethod_29(object object_5, object object_6)
	{
		return ((ResourceManager)object_5).GetObject((string)object_6);
	}

	internal static void smethod_30(object object_5, object object_6)
	{
		((Form)object_5).set_Icon((Icon)object_6);
	}

	internal static void smethod_31(object object_5, bool bool_5)
	{
		((Form)object_5).set_MaximizeBox(bool_5);
	}

	internal static void smethod_32(object object_5, bool bool_5)
	{
		((Form)object_5).set_MinimizeBox(bool_5);
	}

	internal static void smethod_33(object object_5, Size size_0)
	{
		((Form)object_5).set_MinimumSize(size_0);
	}

	internal static void smethod_34(object object_5, object object_6)
	{
		((Control)object_5).set_Name((string)object_6);
	}

	internal static void smethod_35(object object_5, FormStartPosition formStartPosition_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Form)object_5).set_StartPosition(formStartPosition_0);
	}

	internal static void smethod_36(object object_5, object object_6)
	{
		((Form)object_5).set_Text((string)object_6);
	}

	internal static void smethod_37(object object_5)
	{
		((ISupportInitialize)object_5).EndInit();
	}

	internal static void smethod_38(object object_5, bool bool_5)
	{
		((Control)object_5).ResumeLayout(bool_5);
	}

	internal static void smethod_39(object object_5)
	{
		((Control)object_5).PerformLayout();
	}

	internal static void smethod_40(object object_5, object object_6)
	{
		((TrackBar)object_5).remove_Scroll((EventHandler)object_6);
	}

	internal static void smethod_41(object object_5, object object_6)
	{
		((TrackBar)object_5).add_Scroll((EventHandler)object_6);
	}

	internal static void smethod_42(object object_5, object object_6)
	{
		((Timer)object_5).remove_Tick((EventHandler)object_6);
	}

	internal static void smethod_43(object object_5, object object_6)
	{
		((Timer)object_5).add_Tick((EventHandler)object_6);
	}

	internal static void smethod_44(object object_5)
	{
		((Form)object_5)._002Ector();
	}

	internal static void smethod_45(object object_5, object object_6)
	{
		((Form)object_5).add_FormClosing((FormClosingEventHandler)object_6);
	}

	internal static void smethod_46(object object_5, object object_6)
	{
		((Control)object_5).add_Resize((EventHandler)object_6);
	}

	internal static void smethod_47(object object_5, object object_6)
	{
		((GForm1)object_5).vmethod_1((Timer)object_6);
	}

	internal static object smethod_48(object object_5)
	{
		return ((PictureBox)object_5).get_Image();
	}

	internal static int smethod_49(object object_5)
	{
		return ((Control)object_5).get_Width();
	}

	internal static void smethod_50(object object_5, object object_6)
	{
		((Control)object_5).add_Click((EventHandler)object_6);
	}

	internal static void smethod_51(object object_5, object object_6)
	{
		((Control)object_5).add_Paint((PaintEventHandler)object_6);
	}

	internal static void smethod_52(object object_5, object object_6)
	{
		((Control)object_5).add_MouseDown((MouseEventHandler)object_6);
	}

	internal static void smethod_53(object object_5, object object_6)
	{
		((Control)object_5).add_MouseMove((MouseEventHandler)object_6);
	}

	internal static void smethod_54(object object_5, object object_6)
	{
		((Control)object_5).add_MouseUp((MouseEventHandler)object_6);
	}

	internal static void smethod_55(object object_5)
	{
		((Control)object_5).Invalidate();
	}

	internal static int smethod_56(object object_5)
	{
		return ((TrackBar)object_5).get_Value();
	}

	internal static void smethod_57(object object_5)
	{
		ProjectData.SetProjectError((Exception)object_5);
	}

	internal static object smethod_58(object object_5)
	{
		return ((Exception)object_5).ToString();
	}

	internal static object smethod_59(object object_5, object object_6)
	{
		return (string?)object_5 + (string?)object_6;
	}

	internal static MsgBoxResult smethod_60(object object_5, MsgBoxStyle msgBoxStyle_0, object object_6)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return Interaction.MsgBox(object_5, msgBoxStyle_0, object_6);
	}

	internal static void smethod_61()
	{
		ProjectData.ClearProjectError();
	}

	internal static int smethod_62(object object_5)
	{
		return ((Control)object_5).get_Height();
	}

	internal static object smethod_63(object object_5, Size size_0, InterpolationMode interpolationMode_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return GClass25.smethod_0(object_5, size_0, interpolationMode_0);
	}

	internal static DateTime smethod_64()
	{
		return DateAndTime.get_Now();
	}

	internal static double smethod_65(double double_0)
	{
		return Math.Round(double_0);
	}

	internal static Point smethod_66()
	{
		return Cursor.get_Position();
	}

	internal static Point smethod_67(object object_5, Point point_0)
	{
		return ((Control)object_5).PointToClient(point_0);
	}

	internal static bool smethod_68(object object_5)
	{
		return ((Control)object_5).Focus();
	}

	internal static void smethod_69()
	{
		GC.Collect();
	}

	internal static int smethod_70(object object_5)
	{
		return ((MouseEventArgs)object_5).get_X();
	}

	internal static int smethod_71(object object_5)
	{
		return ((MouseEventArgs)object_5).get_Y();
	}

	internal static object smethod_72(object object_5)
	{
		return ((Form)object_5).get_Text();
	}

	internal static bool smethod_73(object object_5)
	{
		return GClass25.smethod_9(object_5);
	}

	internal static object smethod_74()
	{
		return Cursors.get_SizeAll();
	}

	internal static void smethod_75(object object_5, object object_6)
	{
		((Control)object_5).set_Cursor((Cursor)object_6);
	}

	internal static object smethod_76()
	{
		return Cursors.get_Default();
	}

	internal static int smethod_77(int int_7)
	{
		return Math.Abs(int_7);
	}

	internal static object smethod_78(object object_5)
	{
		return RuntimeHelpers.GetObjectValue(object_5);
	}

	internal static void smethod_79(Rectangle rectangle_1, object object_5, int int_7)
	{
		GClass25.smethod_8(rectangle_1, object_5, int_7);
	}

	internal static void smethod_80(object object_5, object object_6)
	{
		((PictureBox)object_5).set_Image((Image)object_6);
	}

	internal static void smethod_81(object object_5)
	{
		((Component)object_5).Dispose();
	}

	internal static void smethod_82(object object_5, int int_7)
	{
		((Control)object_5).set_Width(int_7);
	}

	internal static void smethod_83(object object_5, int int_7)
	{
		((Control)object_5).set_Height(int_7);
	}

	internal static int smethod_84(object object_5)
	{
		return ((Control)object_5).get_Width();
	}

	internal static int smethod_85(object object_5)
	{
		return ((Control)object_5).get_Height();
	}
}
