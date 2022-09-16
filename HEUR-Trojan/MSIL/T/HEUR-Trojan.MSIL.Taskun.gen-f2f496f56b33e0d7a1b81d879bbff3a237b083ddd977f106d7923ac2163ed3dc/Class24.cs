using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class24
{
	public enum Enum1
	{

	}

	public enum Enum2
	{
		Happiness,
		Health,
		Employment,
		Intelligence,
		Creativity,
		Mobility,
		Drunkenness,
		Criminality,
		EnumEnd
	}

	public enum Enum3
	{

	}

	public enum Enum4
	{

	}

	public enum Enum5
	{
		Parking_Tickets,
		Traffic_Tickets,
		Robbery,
		Vandalism,
		Arson,
		Murder,
		Unknown,
		EnumEnd
	}

	public enum Enum6
	{
		Plain,
		Dirt,
		Forest,
		Mountain,
		Lake,
		Swamp,
		Township,
		Desert,
		EndEnum
	}

	public enum Enum7
	{

	}

	public enum Enum8
	{

	}

	public enum Enum9
	{
		Population,
		Coordinates,
		Order,
		Terrain,
		Buildings,
		Roads,
		Jobs_Total,
		Jobs_Filled,
		Jobs_Unfilled,
		Jobs_Needed,
		Minors,
		Elderly,
		Employed,
		Self_Employed,
		Unemployed_Adults,
		Unemployed_Total,
		Average_Age,
		Average_Lifespan,
		Oldest_Person,
		Average_Happiness,
		Average_Health,
		Average_Employment,
		Average_Intelligence,
		Average_Creativity,
		Average_Mobility,
		Average_Drunkenness,
		Average_Criminality,
		Average_Adult_Happiness,
		Average_Adult_Health,
		Average_Adult_Employment,
		Average_Adult_Intelligence,
		Average_Adult_Creativity,
		Average_Adult_Mobility,
		Average_Adult_Drunkenness,
		Average_Adult_Criminality,
		Revenue_This_Turn,
		Total_Revenue,
		Upkeep_This_Turn,
		Total_Upkeep,
		Parking_Tickets,
		Traffic_Tickets,
		Robberies,
		Vandalisms,
		Arsons,
		Murders,
		Deaths_by_Natural_Causes,
		Deaths_by_Illness,
		Deaths_by_Traffic_Accident,
		Deaths_by_Murder,
		Deaths_by_Resisting_Arrest,
		Deaths_by_Nuclear_Meltdown,
		Buildings_owned_by_current_player,
		Buildings_owned_by_other_players,
		Buildings_owned_by_Player_1,
		Buildings_owned_by_Player_2,
		Buildings_owned_by_Player_3,
		Buildings_owned_by_Player_4,
		Buildings_Created,
		Buildings_Founded_by_Citizens,
		Buildings_Closed,
		Athletic_Buildings,
		Coffee_Buildings,
		Commerce_Buildings,
		Criminal_Buildings,
		Culture_Buildings,
		Entertainment_Buildings,
		Food_Buildings,
		Franchise_Buildings,
		Government_Buildings,
		Manufacturing_Buildings,
		Medical_Buildings,
		Monument_Buildings,
		Nature_Buildings,
		Power_Buildings,
		Science_Buildings,
		Security_Buildings,
		Transport_Buildings,
		Travel_Buildings,
		EndEnum
	}

	public enum Enum10
	{

	}

	public enum Enum11
	{

	}

	public static GClass7 gclass7_0 = new GClass7();

	public static int int_0 = 1;

	public static int int_1 = 0;

	public static string string_0 = string.Empty;

	public static int int_2 = 0;

	public static GClass97[,] gclass97_0 = new GClass97[12, 12];

	public static int int_3 = 1;

	public static List<GClass93> list_0 = new List<GClass93>();

	public static GClass93 gclass93_0 = null;

	public static GClass9[] gclass9_0 = new GClass9[5];

	public static GClass6 gclass6_0 = new GClass6();

	public static int int_4 = 3;

	public static int int_5 = 5;

	public static GClass4 gclass4_0 = new GClass4();

	public static GClass8 gclass8_0 = new GClass8();

	public static GClass90 gclass90_0 = new GClass90();

	public static bool bool_0 = false;

	public static Color color_0 = Color.Red;

	public static Color color_1 = Color.DarkViolet;

	public static Color color_2 = Color.DarkOrange;

	public static Color color_3 = Color.DeepPink;

	public static Color color_4 = Color.Aqua;

	public static Color color_5 = Color.PaleGreen;

	public static Color color_6 = Color.LightSlateGray;

	public static Color color_7 = Color.Tan;

	public static Color color_8 = Color.DarkSeaGreen;

	public static Color color_9 = Color.GreenYellow;

	public static Color color_10 = Color.GhostWhite;

	public static Color color_11 = Color.PaleGoldenrod;

	public static Color color_12 = Color.Gold;

	public static Color color_13 = Color.White;

	public static bool bool_1 = false;

	public static Font font_0 = new Font(Class16.smethod_0(-561805928), 18f, (FontStyle)0);

	public static Font font_1 = new Font(Class16.smethod_0(-561805928), 14f, (FontStyle)0);

	public static Font font_2 = new Font(Class16.smethod_0(-561805928), 12f, (FontStyle)0);

	public static int smethod_0(int int_6, int int_7)
	{
		VBMath.Randomize((double)DateTime.Now.Millisecond);
		checked
		{
			int_7++;
			return (int)Conversion.Int((float)int_6 + VBMath.Rnd() * (float)(int_7 - int_6));
		}
	}

	public static double smethod_1(double double_0, double double_1)
	{
		if (double_0 == 0.0 || double_1 == 0.0)
		{
			return 0.0;
		}
		return double_0 / double_1;
	}

	public static GClass97 smethod_2(int int_6, int int_7)
	{
		if (int_6 < 0 || int_6 > 11 || int_7 < 0 || int_7 > 11)
		{
			return null;
		}
		return gclass97_0[int_6, int_7];
	}

	public static string smethod_3(int int_6)
	{
		Enum2 @enum = (Enum2)int_6;
		string text = @enum.ToString();
		return text.Replace('_', ' ');
	}

	public static string smethod_4(int int_6)
	{
		Enum5 @enum = (Enum5)int_6;
		string text = @enum.ToString();
		return text.Replace('_', ' ');
	}

	public static string smethod_5(int int_6, bool bool_2)
	{
		Enum6 @enum = (Enum6)int_6;
		string text = @enum.ToString();
		return text.Replace('_', ' ');
	}

	public static string smethod_6(int int_6)
	{
		Enum9 @enum = (Enum9)int_6;
		string text = @enum.ToString();
		return text.Replace('_', ' ');
	}
}
