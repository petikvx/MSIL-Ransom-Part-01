using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;
using Wheels;

public class GClass1 : DispatcherObject
{
	public delegate void GDelegate0(string str, bool forced = false, int colorCode = 0);

	public delegate void GDelegate1(Games game);

	[CompilerGenerated]
	private bool bool_0;

	private DispatcherTimer dispatcherTimer_0;

	private AppSettings appSettings_0;

	private AppSettings appSettings_1;

	private GClass2 gclass2_0;

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private static GDelegate0 gdelegate0_0;

	private GameDataHanlder gameDataHanlder_0;

	private DispatcherTimer dispatcherTimer_1;

	private double double_0;

	private bool bool_1;

	private Tuple<int, int> tuple_0;

	private bool bool_2;

	private Tuple<int, int> tuple_1;

	private bool bool_3;

	private bool bool_4;

	private Tuple<int, int> tuple_2;

	private bool bool_5;

	private Tuple<int, int> tuple_3;

	private DispatcherTimer dispatcherTimer_2;

	private double double_1;

	private double double_2;

	private Effects effects_0;

	private bool bool_6;

	private Tuple<int, int> tuple_4;

	private bool bool_7;

	private bool bool_8;

	private Tuple<int, int> tuple_5;

	private Tuple<int, int> tuple_6;

	private float float_0;

	private bool bool_9;

	private bool bool_10;

	private Tuple<int, int> tuple_7;

	private Tuple<int, int> tuple_8;

	private float float_1;

	private bool bool_11;

	private Tuple<int, int> tuple_9;

	private bool bool_12;

	private Tuple<int, int> tuple_10;

	private bool bool_13;

	private Tuple<int, int> tuple_11;

	private bool bool_14;

	private Tuple<int, int> tuple_12;

	private Tuple<int, int> tuple_13 = new Tuple<int, int>(0, 0);

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

	public JSdeviceState JSdeviceState_0
	{
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			if (gclass2_0 != null)
			{
				return gclass2_0.JSdeviceState_0;
			}
			return (JSdeviceState)10;
		}
	}

	public static event GDelegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)GClass1.smethod_17((Delegate)gDelegate2, (Delegate)value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)GClass1.smethod_18((Delegate)gDelegate2, (Delegate)value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public GClass1(AppSettings appSettings_2, AppSettings appSettings_3)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		appSettings_0 = appSettings_2;
		appSettings_1 = appSettings_3;
		GClass2.Event_0 += new TransferString(method_6);
		dispatcherTimer_1 = GClass1.smethod_0();
		GClass1.smethod_1(dispatcherTimer_1, TimeSpan.FromMilliseconds(100.0));
		GClass1.smethod_2(dispatcherTimer_1, (EventHandler)method_10);
		GClass1.smethod_3(dispatcherTimer_1, (object)"");
		dispatcherTimer_2 = GClass1.smethod_0();
		GClass1.smethod_1(dispatcherTimer_2, TimeSpan.FromMilliseconds(50.0));
		GClass1.smethod_2(dispatcherTimer_2, (EventHandler)method_18);
		GClass1.smethod_4(dispatcherTimer_2, bool_15: false);
		dispatcherTimer_0 = GClass1.smethod_0();
		GClass1.smethod_1(dispatcherTimer_0, TimeSpan.FromMilliseconds(1000.0));
		GClass1.smethod_2(dispatcherTimer_0, (EventHandler)method_1);
		GClass1.smethod_4(dispatcherTimer_0, bool_15: true);
		GClass1.smethod_5(new TransferString(method_6));
		GClass1.smethod_6(new TransferString(method_6));
		GClass1.smethod_7(new TransferString(method_6));
		GClass1.smethod_8(new TransferString(method_6));
		GClass1.smethod_9(new TransferString(method_6));
		GClass1.smethod_10(new TransferString(method_6));
		GClass1.smethod_11(new TransferString(method_6));
	}

	public void method_0()
	{
		if (gclass2_0 != null)
		{
			gclass2_0.method_5();
			gclass2_0 = null;
		}
		gclass2_0 = new GClass2(appSettings_1, appSettings_0);
	}

	private void method_1(object sender, EventArgs e)
	{
		if (gameDataHanlder_0 != null && GClass1.smethod_12(gameDataHanlder_0))
		{
			GClass1.smethod_13(gameDataHanlder_0, bool_15: false);
			method_2();
			GClass1.smethod_14(gameDataHanlder_0);
			method_6("Effects forced stop due to inactivity timer. Data reset");
		}
	}

	public void method_2()
	{
		if (GClass1.smethod_15(dispatcherTimer_1))
		{
			GClass1.smethod_16(dispatcherTimer_1);
		}
		if (gameDataHanlder_0 != null)
		{
			method_25((Effects)1, "7", ref bool_1);
			method_25((Effects)1, "17", ref bool_2);
			method_25((Effects)4, "8", ref bool_4);
			method_25((Effects)4, "9", ref bool_5);
			method_25((Effects)7, "2", ref bool_6);
			method_25((Effects)14, "12", ref bool_7);
			method_25((Effects)13, "11", ref bool_8);
			method_25((Effects)11, "15", ref bool_9);
			method_25((Effects)11, "14", ref bool_10);
			method_25((Effects)15, "l-front-wear", ref bool_11);
			method_25((Effects)15, "r-front-wear", ref bool_12);
			method_25((Effects)15, "l-rear-wear", ref bool_13);
			method_25((Effects)15, "r-rear-wear", ref bool_14);
		}
	}

	public void method_3(Games games_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Invalid comparison between Unknown and I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between Unknown and I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Invalid comparison between Unknown and I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		appSettings_0.CurrentGame = games_0;
		float_0 = 0.1f;
		float_1 = 0.1f;
		if ((int)games_0 == 2)
		{
			gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_19(appSettings_0);
		}
		else if ((int)games_0 == 3)
		{
			gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_20(appSettings_0);
			if (GClass1.smethod_21(appSettings_0))
			{
				GClass1.smethod_22(dispatcherTimer_2);
			}
		}
		else if ((int)games_0 == 4)
		{
			if (GClass1.smethod_23(appSettings_1))
			{
				gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_24(appSettings_0);
			}
			else
			{
				gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_20(appSettings_0);
			}
			if (GClass1.smethod_21(appSettings_0))
			{
				GClass1.smethod_22(dispatcherTimer_2);
			}
		}
		else if ((int)games_0 == 8 || (int)games_0 == 9)
		{
			gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_25(appSettings_0);
			float_0 = 0.3f;
			float_1 = 0.3f;
		}
		else if ((int)games_0 != 13)
		{
			if ((int)games_0 != 14)
			{
				if ((int)games_0 != 16)
				{
					if ((int)games_0 == 17)
					{
						gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_26(appSettings_0);
					}
					else if ((int)games_0 != 18)
					{
						if ((int)games_0 == 15)
						{
							gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_26(appSettings_0);
						}
						else if ((int)games_0 != 11)
						{
							if ((int)games_0 == 1)
							{
								gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_28(appSettings_0);
								if (GClass1.smethod_29(appSettings_0))
								{
									GClass1.smethod_22(dispatcherTimer_2);
								}
							}
							else if ((int)games_0 != 7)
							{
								if ((int)games_0 != 5 && (int)games_0 != 6)
								{
									if ((int)games_0 == 10)
									{
										gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_28(appSettings_0);
										if (GClass1.smethod_31(appSettings_0))
										{
											GClass1.smethod_22(dispatcherTimer_2);
										}
									}
									else if ((int)games_0 == 12)
									{
										gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_28(appSettings_0);
										if (GClass1.smethod_31(appSettings_0))
										{
											GClass1.smethod_22(dispatcherTimer_2);
										}
									}
								}
								else
								{
									gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_32(appSettings_0);
									if ((int)games_0 == 6)
									{
										int_1 = 1;
									}
								}
							}
							else
							{
								gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_30(appSettings_0);
								if (GClass1.smethod_31(appSettings_0))
								{
									GClass1.smethod_22(dispatcherTimer_2);
								}
							}
						}
						else
						{
							gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_28(appSettings_0);
							if (GClass1.smethod_29(appSettings_0))
							{
								GClass1.smethod_22(dispatcherTimer_2);
							}
						}
					}
					else
					{
						gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_27(appSettings_0);
					}
				}
				else
				{
					gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_26(appSettings_0);
				}
			}
			else
			{
				gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_26(appSettings_0);
			}
		}
		else
		{
			gameDataHanlder_0 = (GameDataHanlder)(object)GClass1.smethod_26(appSettings_0);
		}
		method_19();
		GClass1.smethod_33(gameDataHanlder_0);
		GClass1.smethod_34(gameDataHanlder_0, new RiseEvent(method_7));
	}

	public void method_4()
	{
		GClass1.smethod_16(dispatcherTimer_2);
		if (gameDataHanlder_0 != null)
		{
			GClass1.smethod_35(gameDataHanlder_0);
		}
	}

	public void method_5()
	{
		if (gclass2_0 != null)
		{
			gclass2_0.method_5();
		}
	}

	private void method_6(string string_0, bool bool_15 = false, int int_2 = 0)
	{
		gdelegate0_0(string_0, bool_15, int_2);
	}

	private void method_7()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		method_8(appSettings_0.CurrentGame);
		int_0 = GClass1.smethod_36(gameDataHanlder_0);
	}

	private void method_8(Games games_0)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		if (!GClass1.smethod_37(gameDataHanlder_0))
		{
			return;
		}
		if (GClass1.smethod_39(GClass1.smethod_38((DispatcherObject)(object)this)))
		{
			if (GClass1.smethod_12(gameDataHanlder_0) && !Boolean_0)
			{
				if (GClass1.smethod_41(appSettings_0))
				{
					method_9();
				}
				if (GClass1.smethod_42(appSettings_0))
				{
					method_11((EffectMode)0);
				}
				if (GClass1.smethod_43(appSettings_0))
				{
					method_12();
				}
				if (GClass1.smethod_44(appSettings_0))
				{
					method_13();
				}
				if (GClass1.smethod_45(appSettings_0))
				{
					method_14();
				}
				if (GClass1.smethod_46(appSettings_0))
				{
					method_15();
				}
				if (GClass1.smethod_47(appSettings_0))
				{
					method_20();
				}
				method_21();
				if (GClass1.smethod_48(appSettings_0))
				{
					method_22();
				}
				if (GClass1.smethod_49(appSettings_0))
				{
					method_23();
				}
			}
			else
			{
				method_2();
			}
			if (GClass1.smethod_15(dispatcherTimer_0))
			{
				GClass1.smethod_16(dispatcherTimer_0);
				GClass1.smethod_22(dispatcherTimer_0);
			}
		}
		else
		{
			GClass1.smethod_40(GClass1.smethod_38((DispatcherObject)(object)this), (Delegate)new GDelegate1(method_8), new object[1] { games_0 });
		}
	}

	private void method_9()
	{
		if (GClass1.smethod_50(gameDataHanlder_0) <= 0f)
		{
			GClass1.smethod_51(gameDataHanlder_0, 9000f);
			if (!bool_3)
			{
				gdelegate0_0(GClass1.smethod_52("Could not obtain this car Max RPM value from the game, using default value {0}.Engine Beat effect may be affected", (object)GClass1.smethod_50(gameDataHanlder_0)), forced: true);
				bool_3 = true;
			}
		}
		else
		{
			bool_3 = false;
		}
		float num = GClass1.smethod_53(gameDataHanlder_0) / GClass1.smethod_50(gameDataHanlder_0);
		if (num > 1f)
		{
			num = 1f;
		}
		float num2 = GClass1.smethod_55(GClass1.smethod_54(appSettings_0) / 100.0);
		float num3 = GClass1.smethod_55(GClass1.smethod_56(appSettings_0) / 100.0);
		float num4 = 1f;
		if ((double)num2 <= 0.0)
		{
			if ((double)num2 != 0.0)
			{
				return;
			}
			if (GClass1.smethod_53(gameDataHanlder_0) <= 0f)
			{
				if (GClass1.smethod_15(dispatcherTimer_1))
				{
					GClass1.smethod_16(dispatcherTimer_1);
				}
				return;
			}
			double_0 = GClass1.smethod_61(100f * GClass1.smethod_50(gameDataHanlder_0) / GClass1.smethod_53(gameDataHanlder_0) - 20f);
			double_0 = ((double_0 > 1000.0) ? 100.0 : double_0);
			double_0 = ((double_0 <= 0.0) ? 100.0 : double_0);
			if (!GClass1.smethod_15(dispatcherTimer_1))
			{
				GClass1.smethod_22(dispatcherTimer_1);
			}
			return;
		}
		if (num2 == 1f)
		{
			num2 = 0.99f;
		}
		num4 = 0.05f + (num - num2) / (1f - num2);
		if (num >= num2)
		{
			method_24((Effects)1, "7", ref bool_1, ref tuple_0, method_26((Effects)1, num4), GClass1.smethod_58(new object[7]
			{
				"RPM ratio=",
				GClass1.smethod_53(gameDataHanlder_0),
				"/",
				GClass1.smethod_50(gameDataHanlder_0),
				"=",
				GClass1.smethod_57((double)(num * 100f)),
				"%"
			}));
		}
		else
		{
			method_25((Effects)1, "7", ref bool_1);
		}
		if (num >= num3 && GClass1.smethod_59(appSettings_0))
		{
			method_24((Effects)1, "17", ref bool_2, ref tuple_1, method_26((Effects)1, num4), GClass1.smethod_60((object)"RPM ratio=", (object)GClass1.smethod_57((double)(num * 100f)), (object)"%"));
		}
		else
		{
			method_25((Effects)1, "17", ref bool_2);
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		GClass1.smethod_1(dispatcherTimer_1, TimeSpan.FromMilliseconds(double_0));
		gclass2_0.method_4((EffectActions)1, "3", method_26((Effects)1, 1f));
		if (!GClass1.smethod_12(gameDataHanlder_0) || !GClass1.smethod_41(appSettings_0))
		{
			GClass1.smethod_16(dispatcherTimer_1);
		}
	}

	public void method_11(EffectMode effectMode_0 = 0)
	{
		if (GClass1.smethod_36(gameDataHanlder_0) != int_0 && GClass1.smethod_36(gameDataHanlder_0) != int_1 && GClass1.smethod_53(gameDataHanlder_0) > 100f)
		{
			gdelegate0_0("Gear shift detected. Call sample 1");
			gclass2_0.method_4((EffectActions)1, "1", method_26((Effects)2, 1f));
		}
	}

	private void method_12()
	{
		float num = 0f;
		if (GClass1.smethod_62(gameDataHanlder_0) > num)
		{
			float float_ = ((GClass1.smethod_62(gameDataHanlder_0) <= 1f) ? GClass1.smethod_62(gameDataHanlder_0) : 1f);
			Tuple<int, int> tuple = method_26((Effects)3, float_);
			if (tuple.Item1 > 1 || tuple.Item2 > 1)
			{
				gclass2_0.method_4((EffectActions)1, "10", tuple, 2);
				gdelegate0_0(GClass1.smethod_52("Damage detected. Value ={0,5:N} Call sample 10", (object)GClass1.smethod_62(gameDataHanlder_0)));
			}
		}
	}

	private void method_13()
	{
		float num = GClass1.smethod_55(GClass1.smethod_63(appSettings_0));
		if (GClass1.smethod_64(gameDataHanlder_0) <= num)
		{
			method_25((Effects)4, "8", ref bool_4);
		}
		else
		{
			method_24((Effects)4, "8", ref bool_4, ref tuple_2, method_26((Effects)4, GClass1.smethod_64(gameDataHanlder_0) / 50f));
		}
		if (GClass1.smethod_65(gameDataHanlder_0) > num)
		{
			method_24((Effects)4, "9", ref bool_5, ref tuple_3, method_26((Effects)4, GClass1.smethod_65(gameDataHanlder_0) / 50f));
		}
		else
		{
			method_25((Effects)4, "9", ref bool_5);
		}
	}

	private void method_14()
	{
		float num = GClass1.smethod_55(GClass1.smethod_66(appSettings_0));
		if (GClass1.smethod_67(gameDataHanlder_0) > num)
		{
			gdelegate0_0(GClass1.smethod_52("Bump detected. Value ={0,5:N} Call sample 6", (object)GClass1.smethod_67(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "6", method_26((Effects)5, GClass1.smethod_67(gameDataHanlder_0) / 50f));
		}
		if (GClass1.smethod_68(gameDataHanlder_0) > num)
		{
			gdelegate0_0(GClass1.smethod_52("Left Side Bump detected. Value ={0,5:N} Call sample 4", (object)GClass1.smethod_68(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "4", method_26((Effects)5, GClass1.smethod_68(gameDataHanlder_0) / 50f));
		}
		if (GClass1.smethod_69(gameDataHanlder_0) > num)
		{
			gdelegate0_0(GClass1.smethod_52("Right Side Bump detected. Value ={0,5:N} Call sample 5", (object)GClass1.smethod_69(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "5", method_26((Effects)5, GClass1.smethod_69(gameDataHanlder_0) / 50f));
		}
	}

	private void method_15()
	{
		float num = GClass1.smethod_55(GClass1.smethod_70(appSettings_0));
		float num2 = GClass1.smethod_55(GClass1.smethod_66(appSettings_0));
		if (GClass1.smethod_67(gameDataHanlder_0) > num && GClass1.smethod_67(gameDataHanlder_0) <= num2)
		{
			gdelegate0_0(GClass1.smethod_52("Road Surface Bump detected. Value ={0,5:N} Call sample 20", (object)GClass1.smethod_67(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "20", method_26((Effects)6, GClass1.smethod_67(gameDataHanlder_0) / 50f));
		}
		if (GClass1.smethod_68(gameDataHanlder_0) > num && GClass1.smethod_68(gameDataHanlder_0) <= num2)
		{
			gdelegate0_0(GClass1.smethod_52("Road Surface Left Side Bump detected. Value ={0,5:N} Call sample 18", (object)GClass1.smethod_68(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "18", method_26((Effects)6, GClass1.smethod_68(gameDataHanlder_0) / 50f));
		}
		if (GClass1.smethod_69(gameDataHanlder_0) > num && GClass1.smethod_69(gameDataHanlder_0) <= num2)
		{
			gdelegate0_0(GClass1.smethod_52("Road Surface Right Side Bump detected. Value ={0,5:N} Call sample 19", (object)GClass1.smethod_69(gameDataHanlder_0)));
			gclass2_0.method_4((EffectActions)1, "19", method_26((Effects)6, GClass1.smethod_69(gameDataHanlder_0) / 50f));
		}
	}

	public void method_16()
	{
		if (!GClass1.smethod_15(dispatcherTimer_2))
		{
			GClass1.smethod_22(dispatcherTimer_2);
		}
	}

	public void method_17()
	{
		if (GClass1.smethod_15(dispatcherTimer_2))
		{
			GClass1.smethod_16(dispatcherTimer_2);
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		float num = GClass1.smethod_72(GClass1.smethod_71(gameDataHanlder_0));
		if (num > 0.1f && GClass1.smethod_12(gameDataHanlder_0))
		{
			double num2 = 1666.6000366210938 / (double)num;
			if (num2 > 1000.0)
			{
				num2 = 1000.0;
			}
			GClass1.smethod_1(dispatcherTimer_2, TimeSpan.FromMilliseconds(num2));
			if (GClass1.smethod_73(gameDataHanlder_0))
			{
				gclass2_0.method_4((EffectActions)1, "4", method_26(effects_0, GClass1.smethod_74(gameDataHanlder_0)));
				gdelegate0_0(GClass1.smethod_52("Left Side Bumpy Terrain type of {0}. Call sample 4", (object)GClass1.smethod_75(gameDataHanlder_0)));
			}
			if (GClass1.smethod_76(gameDataHanlder_0))
			{
				gclass2_0.method_4((EffectActions)1, "5", method_26(effects_0, GClass1.smethod_77(gameDataHanlder_0)));
				gdelegate0_0(GClass1.smethod_52("Right Side Bumpy Terrain type of {0}. Call sample 5", (object)GClass1.smethod_78(gameDataHanlder_0)));
			}
		}
		else
		{
			GClass1.smethod_1(dispatcherTimer_2, TimeSpan.FromMilliseconds(50.0));
		}
	}

	private void method_19()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		if ((int)appSettings_0.CurrentGame != 3 && (int)appSettings_0.CurrentGame != 4)
		{
			if ((int)appSettings_0.CurrentGame != 11 && (int)appSettings_0.CurrentGame != 1 && (int)appSettings_0.CurrentGame != 10 && (int)appSettings_0.CurrentGame != 12)
			{
				if ((int)appSettings_0.CurrentGame != 7)
				{
					double_1 = 0.0;
					double_2 = 0.0;
					effects_0 = (Effects)0;
				}
				else
				{
					double_1 = GClass1.smethod_83(appSettings_0);
					double_2 = GClass1.smethod_84(appSettings_0);
					effects_0 = (Effects)10;
				}
			}
			else
			{
				double_1 = GClass1.smethod_81(appSettings_0);
				double_2 = GClass1.smethod_82(appSettings_0);
				effects_0 = (Effects)9;
			}
		}
		else
		{
			double_1 = GClass1.smethod_79(appSettings_0);
			double_2 = GClass1.smethod_80(appSettings_0);
			effects_0 = (Effects)8;
		}
	}

	private void method_20()
	{
		if (GClass1.smethod_85(gameDataHanlder_0))
		{
			method_24((Effects)7, "2", ref bool_6, ref tuple_4, method_26((Effects)7, 1f));
		}
		else
		{
			method_25((Effects)7, "2", ref bool_6);
		}
	}

	private void method_21()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		float num = 0.1f;
		if ((int)appSettings_0.CurrentGame == 16 || (int)appSettings_0.CurrentGame == 17)
		{
			num *= 10f;
		}
		if (GClass1.smethod_86(appSettings_0) && GClass1.smethod_87(gameDataHanlder_0) < 0f - num)
		{
			float float_ = (0f - float_0) * GClass1.smethod_87(gameDataHanlder_0);
			method_24((Effects)13, "11", ref bool_8, ref tuple_6, method_26((Effects)13, float_));
		}
		else if (GClass1.smethod_88(appSettings_0) && GClass1.smethod_87(gameDataHanlder_0) > num)
		{
			float float_2 = float_0 * GClass1.smethod_87(gameDataHanlder_0);
			method_24((Effects)13, "12", ref bool_7, ref tuple_5, method_26((Effects)14, float_2));
		}
		else
		{
			method_25((Effects)14, "12", ref bool_7);
			method_25((Effects)13, "11", ref bool_8);
		}
	}

	private void method_22()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		float num = 0.1f;
		if ((int)appSettings_0.CurrentGame == 16 || (int)appSettings_0.CurrentGame == 17)
		{
			num *= 10f;
		}
		if (GClass1.smethod_89(gameDataHanlder_0) <= num)
		{
			if (GClass1.smethod_89(gameDataHanlder_0) < 0f - num)
			{
				float float_ = (0f - float_1) * GClass1.smethod_89(gameDataHanlder_0);
				method_24((Effects)11, "14", ref bool_10, ref tuple_8, method_26((Effects)11, float_));
			}
			else
			{
				method_25((Effects)11, "15", ref bool_9);
				method_25((Effects)11, "14", ref bool_10);
			}
		}
		else
		{
			float float_2 = float_1 * GClass1.smethod_89(gameDataHanlder_0);
			method_24((Effects)11, "15", ref bool_9, ref tuple_7, method_26((Effects)11, float_2));
		}
	}

	private void method_23()
	{
		float num = GClass1.smethod_55(GClass1.smethod_90(appSettings_0));
		if (GClass1.smethod_91(gameDataHanlder_0) > num)
		{
			method_24((Effects)15, "l-front-wear", ref bool_11, ref tuple_9, method_26((Effects)15, GClass1.smethod_91(gameDataHanlder_0)));
		}
		else
		{
			method_25((Effects)15, "l-front-wear", ref bool_11);
		}
		if (GClass1.smethod_92(gameDataHanlder_0) > num)
		{
			method_24((Effects)15, "r-front-wear", ref bool_12, ref tuple_10, method_26((Effects)15, GClass1.smethod_92(gameDataHanlder_0)));
		}
		else
		{
			method_25((Effects)15, "r-front-wear", ref bool_12);
		}
		if (GClass1.smethod_93(gameDataHanlder_0) > num)
		{
			method_24((Effects)15, "l-rear-wear", ref bool_13, ref tuple_11, method_26((Effects)15, GClass1.smethod_93(gameDataHanlder_0)));
		}
		else
		{
			method_25((Effects)15, "l-rear-wear", ref bool_13);
		}
		if (GClass1.smethod_94(gameDataHanlder_0) > num)
		{
			method_24((Effects)15, "r-rear-wear", ref bool_14, ref tuple_12, method_26((Effects)15, GClass1.smethod_94(gameDataHanlder_0)));
		}
		else
		{
			method_25((Effects)15, "r-rear-wear", ref bool_14);
		}
	}

	private void method_24(Effects effects_1, string string_0, ref bool bool_15, ref Tuple<int, int> tuple_14, Tuple<int, int> tuple_15, string string_1 = "")
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_15 && !GClass1.smethod_95((object)tuple_15, (object)tuple_13))
		{
			gclass2_0.method_4((EffectActions)1, string_0, tuple_15, 1000000);
			bool_15 = true;
			tuple_14 = tuple_15;
			gdelegate0_0(GClass1.smethod_96("{0} start vibe. JS gain={1}, BS gain ={2}. Sample name={3}. {4}", new object[5] { effects_1, tuple_15.Item1, tuple_15.Item2, string_0, string_1 }));
		}
		else if (bool_15 && !GClass1.smethod_95((object)tuple_14, (object)tuple_15))
		{
			if (GClass1.smethod_95((object)tuple_15, (object)tuple_13))
			{
				method_25(effects_1, string_0, ref bool_15);
				return;
			}
			gclass2_0.method_4((EffectActions)4, string_0, tuple_15);
			tuple_14 = tuple_15;
			gdelegate0_0(GClass1.smethod_96("{0} set gain for {1}. JS gain={2}, BS gain ={3}. {4}", new object[5] { effects_1, string_0, tuple_15.Item1, tuple_15.Item2, string_1 }));
		}
	}

	private void method_25(Effects effects_1, string string_0, ref bool bool_15)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (bool_15)
		{
			gclass2_0.method_4((EffectActions)0, string_0, new Tuple<int, int>(0, 0));
			bool_15 = false;
			gdelegate0_0(GClass1.smethod_97("{0} {1} vibe stop.", (object)effects_1, (object)string_0));
		}
	}

	private Tuple<int, int> method_26(Effects effects_1, float float_2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (float_2 > 500f)
		{
			float_2 = 500f;
		}
		int num = 0;
		try
		{
			num = GClass1.smethod_98((double)float_2 * method_27(effects_1));
			if (num > 100)
			{
				num = 100;
			}
		}
		catch (OverflowException)
		{
			gdelegate0_0(GClass1.smethod_97("Overflow in JS {0}, input gain = {1}", (object)effects_1, (object)float_2), forced: true, 1);
			num = 100;
		}
		catch (Exception exception_)
		{
			gdelegate0_0(GClass1.smethod_99(exception_), forced: true, 1);
		}
		int num2 = 0;
		try
		{
			num2 = GClass1.smethod_98((double)float_2 * method_28(effects_1));
			if (num2 > 100)
			{
				num2 = 100;
			}
		}
		catch (OverflowException)
		{
			gdelegate0_0(GClass1.smethod_97("Overflow in BS {0}, input gain = {1}", (object)effects_1, (object)float_2), forced: true, 1);
			num2 = 100;
		}
		catch (Exception exception_2)
		{
			gdelegate0_0(GClass1.smethod_99(exception_2), forced: true, 1);
		}
		return new Tuple<int, int>(num, num2);
	}

	private double method_27(Effects effects_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		double num = 51.0;
		return (effects_1 - 1) switch
		{
			0 => GClass1.smethod_100(appSettings_0), 
			1 => GClass1.smethod_101(appSettings_0), 
			2 => GClass1.smethod_102(appSettings_0), 
			3 => GClass1.smethod_103(appSettings_0), 
			4 => GClass1.smethod_104(appSettings_0), 
			5 => GClass1.smethod_105(appSettings_0), 
			6 => GClass1.smethod_106(appSettings_0), 
			7 => GClass1.smethod_79(appSettings_0), 
			8 => GClass1.smethod_81(appSettings_0), 
			9 => GClass1.smethod_83(appSettings_0), 
			10 => GClass1.smethod_109(appSettings_0), 
			12 => GClass1.smethod_107(appSettings_0), 
			13 => GClass1.smethod_108(appSettings_0), 
			14 => GClass1.smethod_110(appSettings_0), 
			_ => 52.0, 
		};
	}

	private double method_28(Effects effects_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		double num = 51.0;
		return (effects_1 - 1) switch
		{
			0 => GClass1.smethod_111(appSettings_0), 
			1 => GClass1.smethod_112(appSettings_0), 
			2 => GClass1.smethod_113(appSettings_0), 
			3 => GClass1.smethod_114(appSettings_0), 
			4 => GClass1.smethod_115(appSettings_0), 
			5 => GClass1.smethod_116(appSettings_0), 
			6 => GClass1.smethod_117(appSettings_0), 
			7 => GClass1.smethod_80(appSettings_0), 
			8 => GClass1.smethod_82(appSettings_0), 
			9 => GClass1.smethod_84(appSettings_0), 
			10 => GClass1.smethod_120(appSettings_0), 
			12 => GClass1.smethod_118(appSettings_0), 
			13 => GClass1.smethod_119(appSettings_0), 
			14 => GClass1.smethod_121(appSettings_0), 
			_ => 52.0, 
		};
	}

	public void method_29(int int_2)
	{
		switch (int_2)
		{
		case 0:
			gclass2_0.method_4((EffectActions)1, "test", new Tuple<int, int>(100, 0));
			break;
		case 1:
			gclass2_0.method_4((EffectActions)1, "test", new Tuple<int, int>(0, 100));
			break;
		}
	}

	static DispatcherTimer smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new DispatcherTimer();
	}

	static void smethod_1(DispatcherTimer dispatcherTimer_3, TimeSpan timeSpan_0)
	{
		dispatcherTimer_3.set_Interval(timeSpan_0);
	}

	static void smethod_2(DispatcherTimer dispatcherTimer_3, EventHandler eventHandler_0)
	{
		dispatcherTimer_3.add_Tick(eventHandler_0);
	}

	static void smethod_3(DispatcherTimer dispatcherTimer_3, object object_0)
	{
		dispatcherTimer_3.set_Tag(object_0);
	}

	static void smethod_4(DispatcherTimer dispatcherTimer_3, bool bool_15)
	{
		dispatcherTimer_3.set_IsEnabled(bool_15);
	}

	static void smethod_5(TransferString transferString_0)
	{
		R3eMemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_6(TransferString transferString_0)
	{
		PCarsMemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_7(TransferString transferString_0)
	{
		PCars2MemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_8(TransferString transferString_0)
	{
		Ets2MemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_9(TransferString transferString_0)
	{
		UDP_RX.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_10(TransferString transferString_0)
	{
		IRmemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static void smethod_11(TransferString transferString_0)
	{
		ACmemoryReader.add_AddToLog_GDH(transferString_0);
	}

	static bool smethod_12(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_EffectsAllowed();
	}

	static void smethod_13(GameDataHanlder gameDataHanlder_1, bool bool_15)
	{
		gameDataHanlder_1.set_EffectsAllowed(bool_15);
	}

	static void smethod_14(GameDataHanlder gameDataHanlder_1)
	{
		gameDataHanlder_1.ResetData();
	}

	static bool smethod_15(DispatcherTimer dispatcherTimer_3)
	{
		return dispatcherTimer_3.get_IsEnabled();
	}

	static void smethod_16(DispatcherTimer dispatcherTimer_3)
	{
		dispatcherTimer_3.Stop();
	}

	static Delegate smethod_17(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_18(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static R3eMemoryReader smethod_19(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new R3eMemoryReader(appSettings_2);
	}

	static PCarsMemoryReader smethod_20(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new PCarsMemoryReader(appSettings_2);
	}

	static bool smethod_21(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxPCARSenabled1();
	}

	static void smethod_22(DispatcherTimer dispatcherTimer_3)
	{
		dispatcherTimer_3.Start();
	}

	static bool smethod_23(AppSettings appSettings_2)
	{
		return appSettings_2.get_PCARScbox2();
	}

	static PCars2MemoryReader smethod_24(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new PCars2MemoryReader(appSettings_2);
	}

	static Ets2MemoryReader smethod_25(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Ets2MemoryReader(appSettings_2);
	}

	static CodeMastersDataRx smethod_26(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new CodeMastersDataRx(appSettings_2);
	}

	static F1_2018_DataRx_Legacy smethod_27(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new F1_2018_DataRx_Legacy(appSettings_2);
	}

	static RF2andAMSdataRx smethod_28(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new RF2andAMSdataRx(appSettings_2);
	}

	static bool smethod_29(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxRF2enabled1();
	}

	static IRmemoryReader smethod_30(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new IRmemoryReader(appSettings_2);
	}

	static bool smethod_31(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxIRenabled2();
	}

	static ACmemoryReader smethod_32(AppSettings appSettings_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ACmemoryReader(appSettings_2);
	}

	static void smethod_33(GameDataHanlder gameDataHanlder_1)
	{
		gameDataHanlder_1.Run();
	}

	static void smethod_34(GameDataHanlder gameDataHanlder_1, RiseEvent riseEvent_0)
	{
		gameDataHanlder_1.add_GameDataUpdated(riseEvent_0);
	}

	static void smethod_35(GameDataHanlder gameDataHanlder_1)
	{
		gameDataHanlder_1.Stop();
	}

	static int smethod_36(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_Gear();
	}

	static bool smethod_37(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_EffectsAllowedPrev();
	}

	static Dispatcher smethod_38(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static bool smethod_39(Dispatcher dispatcher_0)
	{
		return dispatcher_0.CheckAccess();
	}

	static object smethod_40(Dispatcher dispatcher_0, Delegate delegate_0, object[] object_0)
	{
		return dispatcher_0.Invoke(delegate_0, object_0);
	}

	static bool smethod_41(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled1();
	}

	static bool smethod_42(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled2();
	}

	static bool smethod_43(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled3();
	}

	static bool smethod_44(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled4();
	}

	static bool smethod_45(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled5();
	}

	static bool smethod_46(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled14();
	}

	static bool smethod_47(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxIRenabled1();
	}

	static bool smethod_48(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled12();
	}

	static bool smethod_49(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled15();
	}

	static float smethod_50(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_MaxRPM();
	}

	static void smethod_51(GameDataHanlder gameDataHanlder_1, float float_2)
	{
		gameDataHanlder_1.set_MaxRPM(float_2);
	}

	static string smethod_52(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static float smethod_53(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_RPM();
	}

	static double smethod_54(AppSettings appSettings_2)
	{
		return appSettings_2.get_EngineBeatStart();
	}

	static float smethod_55(double double_3)
	{
		return Convert.ToSingle(double_3);
	}

	static double smethod_56(AppSettings appSettings_2)
	{
		return appSettings_2.get_EngineBeatStartExtra();
	}

	static double smethod_57(double double_3)
	{
		return Math.Round(double_3);
	}

	static string smethod_58(object[] object_0)
	{
		return string.Concat(object_0);
	}

	static bool smethod_59(AppSettings appSettings_2)
	{
		return appSettings_2.get_EngineBeatExtraTone();
	}

	static string smethod_60(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	static double smethod_61(float float_2)
	{
		return Convert.ToDouble(float_2);
	}

	static float smethod_62(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_DeltaDamage();
	}

	static double smethod_63(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_3();
	}

	static float smethod_64(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_LeftSideSlip();
	}

	static float smethod_65(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_RightSideSlip();
	}

	static double smethod_66(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_3();
	}

	static float smethod_67(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_Bump();
	}

	static float smethod_68(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_LeftSideBump();
	}

	static float smethod_69(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_RightSideBump();
	}

	static double smethod_70(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_3();
	}

	static float smethod_71(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_Speed_mps();
	}

	static float smethod_72(float float_2)
	{
		return Math.Abs(float_2);
	}

	static bool smethod_73(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_L_BumpyTerrain();
	}

	static float smethod_74(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_L_TerrainTypeGain();
	}

	static string smethod_75(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_L_TerrainTypeName();
	}

	static bool smethod_76(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_R_BumpyTerrain();
	}

	static float smethod_77(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_R_TerrainTypeGain();
	}

	static string smethod_78(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_R_TerrainTypeName();
	}

	static double smethod_79(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_pCARS_1_1();
	}

	static double smethod_80(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_pCARS_1_2();
	}

	static double smethod_81(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_rF2_1_1();
	}

	static double smethod_82(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_rF2_1_2();
	}

	static double smethod_83(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_2_1();
	}

	static double smethod_84(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_2_2();
	}

	static bool smethod_85(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_TyresLock();
	}

	static bool smethod_86(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled10();
	}

	static float smethod_87(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_AccZ_ms2();
	}

	static bool smethod_88(AppSettings appSettings_2)
	{
		return appSettings_2.get_FxEnabled11();
	}

	static float smethod_89(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_AccX_ms2();
	}

	static double smethod_90(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_3();
	}

	static float smethod_91(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_LeftFrontTireWearDelta();
	}

	static float smethod_92(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_RightFrontTireWearDelta();
	}

	static float smethod_93(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_LeftRearTireWearDelta();
	}

	static float smethod_94(GameDataHanlder gameDataHanlder_1)
	{
		return gameDataHanlder_1.get_RightRearTireWearDelta();
	}

	static bool smethod_95(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	static string smethod_96(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static string smethod_97(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static int smethod_98(double double_3)
	{
		return Convert.ToInt32(double_3);
	}

	static string smethod_99(Exception exception_0)
	{
		return exception_0.Message;
	}

	static double smethod_100(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_1_1();
	}

	static double smethod_101(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_2_1();
	}

	static double smethod_102(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_3_1();
	}

	static double smethod_103(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_1();
	}

	static double smethod_104(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_1();
	}

	static double smethod_105(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_1();
	}

	static double smethod_106(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_1_1();
	}

	static double smethod_107(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_10_1();
	}

	static double smethod_108(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_11_1();
	}

	static double smethod_109(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_12_1();
	}

	static double smethod_110(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_1();
	}

	static double smethod_111(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_1_2();
	}

	static double smethod_112(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_2_2();
	}

	static double smethod_113(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_3_2();
	}

	static double smethod_114(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_4_2();
	}

	static double smethod_115(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_5_2();
	}

	static double smethod_116(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_14_2();
	}

	static double smethod_117(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_iR_1_2();
	}

	static double smethod_118(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_10_2();
	}

	static double smethod_119(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_11_2();
	}

	static double smethod_120(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_12_2();
	}

	static double smethod_121(AppSettings appSettings_2)
	{
		return appSettings_2.get_Slider_15_2();
	}
}
