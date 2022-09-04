using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CalcMatriz;

namespace 搐揢搔搞搙搎搘搦搒搠搑揽揤揟握;

public class 蓱蓤蓍蒳蒱蓈蓢蓄蒳蒰蒰蓥蒯蒷蓗 : Window, IComponentConnector
{
	public static PointCollection 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖 = new PointCollection();

	public static Canvas 䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳;

	internal Grid 瓎璡璠瓍瓑璮瓎璶璹瓡璱璝璢璞瓗;

	internal Canvas 埛培埋埅埍埶埶埌埬埋域埋埶培培;

	internal ImageBrush _08C9ࣇ_08CD_08FA_08CCࣄ_08CAࣇ_08E2_08DD_08F8_08EDࣅ_08C8ࣄ;

	internal ImageBrush _E196_E17C_E169_E161_E164_E166_E162_E185_E168_E18A_E197_E195_E185_E193_E19F;

	internal ComboBox _E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727;

	internal ComboBoxItem _2109ℨ_20F7ℹ_2129ℐ_20F6Ω_20F8_20F6_20F6ℏℼ_20FA_20FD;

	internal ComboBoxItem _17C9ឝ_17C6មផប_17DBរ_17BEឩវ_17B8_17C7_17C5_17BB;

	internal ComboBoxItem 竗窓窛窓窖窗竄窖竉窙窥窦竇窙竈;

	internal ComboBoxItem _21CE_21D1_21CE_21D0_21D6_21D1_21D6_21CE_21FE_2202_2212_21D5_21D3_21D5_21D1;

	internal ComboBoxItem ꑪꑨ_A497ꑫ_A496_A4ACꑮꑭꒄꑫ_A496ꑥ_A49Aꒊ_A4A6;

	internal ComboBoxItem 꺅꺟꺃꺇꺶꺻꺖꺲꺕껄꺦꺂꺂꺈꺈;

	internal ComboBoxItem 沛泑沜泘沜沞沟泑没沚泎泑泍沚沝;

	internal TextBox _EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0;

	internal Label ⰠⱋⰰⱇⰎⰐⰈⰢⰛⰍⰼⰈⰺⱌⱐ;

	internal TextBox 婗婮媅婗婖媕婙媛婖婚婙婙婕媘婜;

	internal Label 츯츬츇췹췹츯췶츶췼츫췼췺칀췸츛;

	internal TextBox ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7;

	internal StackPanel 쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶;

	internal StackPanel 鴧鴷鴫鴸鴩鵙鴪鴥鴶鵠鴫鴭鴮鵖鴪;

	internal StackPanel ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E;

	internal Button ﰹﱢﱭﱌﰱﱥﰲﱢﱧﰵﰳﰲﱢﱧﰳ;

	internal Button 䃸䃵䄥䄰䄐䄉䄜䃶䃹䃷䄍䄽䄥䃵䃸;

	internal Button _E42F_E417_E3FE_E431_E43A_E402_E42F_E3FC_E42F_E431_E42F_E434_E41B_E3FD_E432;

	internal TextBox 쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃;

	internal TextBox 愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦;

	internal TextBox 陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖;

	internal TextBox 澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌;

	internal TextBox ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ;

	internal TextBox 孬宨客孬定孮孯宙孿宗宙孮宯孪孩;

	internal TextBox ᲣᲢᲢ_1CD5ᲦᲶᲤᲦ_1CD6_1CC8_1CD4_1CD3ᲨᲢᲩ;

	internal TextBox 廬廚弊弌廚廹式廝廷廛廵弌弊廛弍;

	internal TextBox 釦鈑釡鈑釤鈔鈛鈒釟鈒釲釡鈏釼釤;

	internal TextBox 訣訤訜訥訟訣詗詍訥訶詝訟訿証訝;

	internal TextBox ņėĖŃĕĎŋĿģĿŃŃĒŃœ;

	internal Label 垺坼垩垦坵垨型垧垅垯坺坼坺垩垯;

	internal Label ⰳⰲⰴⰱⱻⱸⱦⱪⱩⱙⰷⱥⱺⰴⰵ;

	internal Label 厷台厸厯古古反厷厶厲古厲厸厳厵;

	private bool 垡坾坮垨坪坮垛垓垯垛垎坮垠坻垦;

	private bool 濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗 = true;

	private bool 羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼 = true;

	public 蓱蓤蓍蒳蒱蓈蓢蓄蒳蒰蒰蓥蒯蒷蓗()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		Console.WriteLine();
		ꚱꚢꚱꚶꚇꚲꛈꚴꛆꚖꚈꚂꚢꚦꚀ();
		䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳 = 埛培埋埅埍埶埶埌埬埋域埋埶培培;
		쳻촏쳱쳎쳐쳑촅쳍쳞쳍쳈쳎촐쳋쳚(25, "#555555");
		Polygon val = new Polygon();
		val.set_FillRule((FillRule)1);
		((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
		val.set_Points(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖);
		((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
	}

	public void 쳓쳐쳔쳓쳀첷첦쳙첲쳐첢첟첟첨첥(int 굑괹굵괰괸괷괸괴괶굄굥괱괱굡굡, int 글귳귒궾귁귱귃귔귃귭귭귣귭긂귫, int ⶼⶔⷈⶨ_2D9Dⷅⶔⶵ_2DC7ⷈⷍ_2D99ⷈⶰⶕ, int 픪픕픾픶픆픊픶플픈픞픅픟픉픵픊, string 姏委姘娃姏娀姒娅姘姰姢姏姸姕娆, int 硯硒硘硕硖碑硔硧碍硭硦碑硛碃硕)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Line val = new Line();
		val.set_X1((double)굑괹굵괰괸괷괸괴괶굄굥괱괱굡굡);
		val.set_X2((double)ⶼⶔⷈⶨ_2D9Dⷅⶔⶵ_2DC7ⷈⷍ_2D99ⷈⶰⶕ);
		val.set_Y1((double)글귳귒궾귁귱귃귔귃귭귭귣귭긂귫);
		val.set_Y2((double)픪픕픾픶픆픊픶플픈픞픅픟픉픵픊);
		((Shape)val).set_StrokeThickness((double)硯硒硘硕硖碑硔硧碍硭硦碑硛碃硕);
		((Shape)val).set_Stroke((Brush)((TypeConverter)new BrushConverter()).ConvertFromString(姏委姘娃姏娀姒娅姘姰姢姏姸姕娆));
		((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
	}

	public void 쳻촏쳱쳎쳐쳑촅쳍쳞쳍쳈쳎촐쳋쳚(int 窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍, string 顐顑顏顐顎顪顼顮顾顼顋顑顩顰须)
	{
		for (int i = 0; i < 250 - 窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍; i++)
		{
			쳓쳐쳔쳓쳀첷첦쳙첲쳐첢첟첟첨첥(窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍 * i, 0, 窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍 * i, 250, 顐顑顏顐顎顪顼顮顾顼顋顑顩顰须, 1);
			쳓쳐쳔쳓쳀첷첦쳙첲쳐첢첟첟첨첥(0, 窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍 * i, 250, 窋窺窘窍窷窅窎窷窶窽窷窍窹窌窍 * i, 顐顑顏顐顎顪顼顮顾顼顋顑顩顰须, 1);
		}
		쳓쳐쳔쳓쳀첷첦쳙첲쳐첢첟첟첨첥(0, 125, 250, 125, "#ededed", 1);
		쳓쳐쳔쳓쳀첷첦쳙첲쳐첢첟첟첨첥(125, 0, 125, 250, "#ededed", 1);
	}

	private void ﮉﭙﭶﮘﭙﮉﭘﭚﮊﭴﭝﭗﭘﭾﭚ(double 좭좗좞존좗좃좋존졭졮종졮좠졮좢, double ҋѿҎҢљҋџќҖѠўғҟќј, string _F003_EFDF_EFD0_EFED_F003_EFBC_EFED_EFEC_EFEA_EFEA_EFBC_EFB9_F001_EFEA_EFBD, Color 㥶㥸㥵㥰㦃㥱㦯㥳㥶㥹㥶㦡㥶㦤㥷)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		TextBlock val = new TextBlock();
		val.set_Text(_F003_EFDF_EFD0_EFED_F003_EFBC_EFED_EFEC_EFEA_EFEA_EFBC_EFB9_F001_EFEA_EFBD);
		val.set_Foreground((Brush)new SolidColorBrush(㥶㥸㥵㥰㦃㥱㦯㥳㥶㥹㥶㦡㥶㦤㥷));
		Canvas.SetLeft((UIElement)(object)val, 좭좗좞존좗좃좋존졭졮종졮좠졮좢);
		Canvas.SetTop((UIElement)(object)val, ҋѿҎҢљҋџќҖѠўғҟќј);
		((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
	}

	public Point 諸視_FAED_FAE9贈謹諸視請_FAEE𥳐_FAED_FAEC諸頋()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		Point position = Mouse.GetPosition((IInputElement)(object)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳);
		bool flag = false;
		if (((Point)(ref position)).get_X() > 0.0 && ((Point)(ref position)).get_Y() > 0.0)
		{
			ﮉﭙﭶﮘﭙﮉﭘﭚﮊﭴﭝﭗﭘﭾﭚ(((Point)(ref position)).get_X(), ((Point)(ref position)).get_Y(), "(" + (((Point)(ref position)).get_X() - 125.0) + ":" + (((Point)(ref position)).get_Y() - 125.0) + ")", Colors.get_Red());
			丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.Add(position);
			flag = true;
		}
		if (((Panel)쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶).get_Children().get_Count() < 10 && flag)
		{
			Button val = new Button();
			((ButtonBase)val).add_Click(new RoutedEventHandler(button_Click));
			((ContentControl)val).set_Content((object)"Change");
			((FrameworkElement)val).set_Name("Button" + 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.IndexOf(position));
			((Panel)쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶).get_Children().Add((UIElement)(object)val);
			TextBox val2 = new TextBox();
			((FrameworkElement)val2).set_Name("X" + 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.IndexOf(position));
			val2.set_Text((((Point)(ref position)).get_X() - 125.0).ToString());
			val2.set_MaxLength(4);
			val2.set_MaxLines(1);
			((Panel)鴧鴷鴫鴸鴩鵙鴪鴥鴶鵠鴫鴭鴮鵖鴪).get_Children().Add((UIElement)(object)val2);
			TextBox val3 = new TextBox();
			((FrameworkElement)val3).set_Name("Y" + 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.IndexOf(position));
			val3.set_Text((((Point)(ref position)).get_Y() - 125.0).ToString());
			val3.set_MaxLength(4);
			val3.set_MaxLines(1);
			((Panel)ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E).get_Children().Add((UIElement)(object)val3);
		}
		return new Point(((Point)(ref position)).get_X(), ((Point)(ref position)).get_Y());
	}

	protected void button_Click(object sender, RoutedEventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)((sender is Button) ? sender : null);
		int num = ((Panel)쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶).get_Children().IndexOf((UIElement)((sender is Button) ? sender : null));
		_003F val2 = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖;
		double num2 = double.Parse(((TextBox)/*isinst with value type is only supported in some contexts*/).get_Text()) + 125.0;
		UIElement obj = ((Panel)ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E).get_Children().get_Item(num);
		((PointCollection)val2).set_Item(num, new Point(num2, double.Parse(((TextBox)((obj is TextBox) ? obj : null)).get_Text()) + 125.0));
		燽燿爄爺爱爣爤爰爮爵爄爄燾燽燻();
	}

	public void 扆扨扴扫打扇扬扢扚扥扷抄承扉扸()
	{
		丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.Clear();
		List<TextBlock> list = ((IEnumerable)((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children()).OfType<TextBlock>().ToList();
		foreach (TextBlock item in list)
		{
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Remove((UIElement)(object)item);
		}
		((Panel)鴧鴷鴫鴸鴩鵙鴪鴥鴶鵠鴫鴭鴮鵖鴪).get_Children().Clear();
		((Panel)ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E).get_Children().Clear();
		((Panel)쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶).get_Children().Clear();
	}

	public static void _2ADF_2AE3_2AE3_2ADB_2AE2_2ADA_2B0F_2ADC_2ADD_2AF2_2AE1_2AF3_2B0E_2AF6_2AE1(object ԻլլԻՓԼՋՂԹԻխՖկՀպ, TextCompositionEventArgs 怩恌恛怪怪怬怯怪怮恠性怹恊恛怨)
	{
		Regex regex = new Regex("[^0-9,]+");
		((RoutedEventArgs)怩恌恛怪怪怬怯怪怮恠性怹恊恛怨).set_Handled(regex.IsMatch(怩恌恛怪怪怬怯怪怮恠性怹恊恛怨.get_Text()));
	}

	public void ⴥ_2CFB_2CFB_2CFB_2CF6_2CFCⴤⴚ_2CF5_2CFBⴧⴤ_2CF5ⴜ_2CF7(ref Label 貏貈貺貇貊貐貈貐資貛貏賑貽貈貺, TextBox 씧앛앜씶씦앖앒씨앖씣씡씧앉압씢)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		string text = 씧앛앜씶씦앖앒씨앖씣씡씧앉압씢.get_Text();
		if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
		{
			((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"No matrix");
			((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#ededed"));
			return;
		}
		string[] array = text.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[1] { ' ' });
			if (i == 0)
			{
				num = array2.Length;
			}
			else if (num != array2.Length)
			{
				((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"Error");
				((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
				break;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				if (string.IsNullOrWhiteSpace(array2[j]) || string.IsNullOrEmpty(array2[j]))
				{
					((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"Error");
					((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
					break;
				}
				((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"Valid");
				((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#2ecc71"));
			}
		}
		if (!((string)((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).get_Content() == "Valid"))
		{
			return;
		}
		try
		{
			Console.WriteLine(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.穚穋稫穗稫稪種稥穃穖穙稫稥稨穋(text).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"Valid");
			((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#2ecc71"));
		}
		catch
		{
			((ContentControl)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Content((object)"Error");
			((Control)貏貈貺貇貊貐貈貐資貛貏賑貽貈貺).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
		}
	}

	private void 쭎쬣쭑쭑쬤쬝쬿쭏쬾쭢쭛쬻쬼쬢쭐(object 㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵, TextChangedEventArgs _2510_24F1_24EB_24FB_2506_2520_24EA_24E9_24EB_250F_24ED_251F_24EF_24EC_24F1)
	{
		if (((FrameworkElement)((㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 is TextBox) ? 㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 : null)).get_Name() == "matrixInput1")
		{
			ⴥ_2CFB_2CFB_2CFB_2CF6_2CFCⴤⴚ_2CF5_2CFBⴧⴤ_2CF5ⴜ_2CF7(ref ⰠⱋⰰⱇⰎⰐⰈⰢⰛⰍⰼⰈⰺⱌⱐ, (TextBox)((㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 is TextBox) ? 㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 : null));
		}
		else
		{
			ⴥ_2CFB_2CFB_2CFB_2CF6_2CFCⴤⴚ_2CF5_2CFBⴧⴤ_2CF5ⴜ_2CF7(ref 츯츬츇췹췹츯췶츶췼츫췼췺칀췸츛, (TextBox)((㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 is TextBox) ? 㠨㠧㟺㟶㟺㟶㠤㟹㠨㠧㠧㠱㟼㟸㟵 : null));
		}
	}

	private void 퓯퓵픓픮퓸퓷픇픘프픖퓸픠퓯퓷픵(object 癳癞療癁癱癁癴癉癀癄癨癆癳癆癁, RoutedEventArgs _20AF_20B4_20B2_20E3_20E3_20CA_20B6_20B3_20AE_20E1_20B0_20E2_20AD_20B6_20AE)
	{
		跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧 = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.穚穋稫穗稫稪種稥穃穖穙稫稥稨穋(_EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0.get_Text());
		跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2 = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.穚穋稫穗稫稪種稥穃穖穙稫稥稨穋(婗婮媅婗婖媕婙媛婖婚婙婙婕媘婜.get_Text());
		bool flag = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._32DC_32DE_32D9_32E4_32AD_32DD_32C3_32DB_32D9_32AC_32A8_32DC_32AD_32C9_32BE == 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2._32DC_32DE_32D9_32E4_32AD_32DD_32C3_32DB_32D9_32AC_32A8_32DC_32AD_32C9_32BE && 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.䰎䰏䰏䱁䱐䰥䰔䰽䰍䰩䱀䰕䰍䱀䰕 == 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2.䰎䰏䰏䱁䱐䰥䰔䰽䰍䰩䱀䰕䰍䱀䰕;
		((ContentControl)厷台厸厯古古反厷厶厲古厲厸厳厵).set_Content((object)"");
		if (!((string)((ContentControl)ⰠⱋⰰⱇⰎⰐⰈⰢⰛⰍⰼⰈⰺⱌⱐ).get_Content() == "Valid") || (!((string)((ContentControl)츯츬츇췹췹츯췶츶췼츫췼췺칀췸츛).get_Content() == "Valid") && !(_E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727.get_Text() == "Determinant") && !(_E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727.get_Text() == "Inverse") && !(_E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727.get_Text() == "Transpose")))
		{
			return;
		}
		string text = _E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727.get_Text();
		string text2 = text;
		switch (㼖㼴㼈㼉㼆㼃㼅㼴㼦㼀㼵㽂㼈㼡㼟.ﾃﾋﾆﾈﾗﾶￊﾡﾄﾆﾸﾆﾳﾷￌ(text2))
		{
		case 1071174216u:
			if (!(text2 == "Sum"))
			{
				break;
			}
			if (flag)
			{
				ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.乽乻亥亱什乿乿亮乾亄亂京乾亠亯(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧, 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			}
			else
			{
				((ContentControl)厷台厸厯古古反厷厶厲古厲厸厳厵).set_Content((object)"Both must be the same size to do this operation!");
			}
			return;
		case 357949441u:
			if (!(text2 == "Subtraction"))
			{
				break;
			}
			if (flag)
			{
				ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.ᨱ_19FEᨁᩁᨱᨮᨦᨁᨹᨑᨃᨮᨁᨲᨲ(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧, 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			}
			else
			{
				((ContentControl)厷台厸厯古古反厷厶厲古厲厸厳厵).set_Content((object)"Both must be the same size to do this operation!");
			}
			return;
		case 1062367507u:
			if (!(text2 == "Multiplication"))
			{
				break;
			}
			if (flag)
			{
				ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.贏賤賢賷賹贜賛賡賳賤賿贏賤賞贐(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧, 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			}
			else
			{
				((ContentControl)厷台厸厯古古反厷厶厲古厲厸厳厵).set_Content((object)"First Matrix's collumns number must be equal to\rsecond Matrix's rows number!");
			}
			return;
		case 4185424761u:
			if (!(text2 == "Scalar Multiplication"))
			{
				break;
			}
			try
			{
				ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._2670_2660_2650_264E_2654_2685_268E_264E_2688_2654_266B_2653_2663_264D_2681(double.Parse(_EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0.get_Text()), 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧2, "mul").笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
				return;
			}
			catch
			{
				ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text("Invalid scalar value!");
				return;
			}
		case 1661157472u:
			if (!(text2 == "Determinant"))
			{
				break;
			}
			ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.塄塧塷塅塸塉塇塈塇塊塪塊塇塼塌(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧).ToString());
			return;
		case 3378387235u:
			if (!(text2 == "Inverse"))
			{
				break;
			}
			ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.뤒뤘뤓뤘뤘뤔뤘뤚륅뤓륐뤖뤕륅뤒(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			return;
		case 1924786016u:
			if (!(text2 == "Transpose"))
			{
				break;
			}
			ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7.set_Text(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.穚穋稫穗稫稪種稥穃穖穙稫稥稨穋(_EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0.get_Text()).ȦȼɏȉȊȾɑȏɀȹȜȻɇɂȈ().笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
			return;
		}
		Console.WriteLine("Exception @ matrixOperation!");
	}

	public void 燽燿爄爺爱爣爤爰爮爵爄爄燾燽燻()
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			List<TextBlock> list = ((IEnumerable)((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children()).OfType<TextBlock>().ToList();
			foreach (TextBlock item in list)
			{
				((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Remove((UIElement)(object)item);
			}
			for (int i = 0; i < 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Count(); i++)
			{
				UIElement obj = ((Panel)鴧鴷鴫鴸鴩鵙鴪鴥鴶鵠鴫鴭鴮鵖鴪).get_Children().get_Item(i);
				UIElement obj2 = ((obj is TextBox) ? obj : null);
				Point val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				((TextBox)obj2).set_Text((((Point)(ref val)).get_X() - 125.0).ToString());
				UIElement obj3 = ((Panel)ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E).get_Children().get_Item(i);
				UIElement obj4 = ((obj3 is TextBox) ? obj3 : null);
				val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				((TextBox)obj4).set_Text((((Point)(ref val)).get_Y() - 125.0).ToString());
				val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				double x = ((Point)(ref val)).get_X();
				val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				double y = ((Point)(ref val)).get_Y();
				string[] obj5 = new string[5] { "(", null, null, null, null };
				val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				obj5[1] = (((Point)(ref val)).get_X() - 125.0).ToString();
				obj5[2] = ",";
				val = 丣丠乒乐丢丨乐乔丵丣乓乗乕両乖.get_Item(i);
				obj5[3] = (((Point)(ref val)).get_Y() - 125.0).ToString();
				obj5[4] = ")";
				ﮉﭙﭶﮘﭙﮉﭘﭚﮊﭴﭝﭗﭘﭾﭚ(x, y, string.Concat(obj5), Colors.get_Red());
			}
		}
		catch
		{
		}
	}

	private void 蓾蔩蓿蔚蔶蔮蓾蓷蔫蔊蔹蔊蓺蓹蔨(object 敟斐散斛斏斡敟敤敟斑敢敹敢敟敞, RoutedEventArgs 왪왰왩욇왩욍왯왮왪왬욟욝욄왰욛)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.set_Text(Regex.Replace(쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.get_Text(), "[^0-9,]+", "", RegexOptions.Compiled));
		쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.set_Text((string.IsNullOrEmpty(쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.get_Text()) || string.IsNullOrWhiteSpace(쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.get_Text())) ? "0" : 쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.get_Text());
		try
		{
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Clear();
			쳻촏쳱쳎쳐쳑촅쳍쳞쳍쳈쳎촐쳋쳚(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			丣丠乒乐丢丨乐乔丵丣乓乗乕両乖 = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._F6E3_F70A_F6E6_F719_F714_F6E0_F704_F714_F6E5_F715_F6E5_F701_F6E4_F6FD_F6E4(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._2A4E_2A6A_2A56_2A51_2A95_2A4E_2A4F_2A50_2A5F_2A80_2A4F_2A82_2A75_2A8E_2A82(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._FAEA𢡊_FAEB謁覆_FAF3_FAE6覆_FAF7請諭諸諸謁_FADD(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖, -125.0, -125.0), double.Parse(쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃.get_Text())), 125.0, 125.0);
			val.set_Points(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖);
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
			燽燿爄爺爱爣爤爰爮爵爄爄燾燽燻();
		}
		catch
		{
		}
	}

	private void 霶靡霮靲靡靔面霯露霷靡靨霵靬霶(object 㱨㱔㲕㱖㱗㲇㱱㱙㱙㲌㱴㱔㱸㱴㲅, RoutedEventArgs 휬휽흘흤흭흎휰흝흈휬휨흜휩휮흛)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.set_Text(Regex.Replace(愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.get_Text(), "[^0-9,-]+", "", RegexOptions.Compiled));
		愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.set_Text((string.IsNullOrEmpty(愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.get_Text()) || string.IsNullOrWhiteSpace(愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.get_Text())) ? "0" : 愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.get_Text());
		陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.set_Text(Regex.Replace(陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.get_Text(), "[^0-9,-]+", "", RegexOptions.Compiled));
		陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.set_Text((string.IsNullOrEmpty(陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.get_Text()) || string.IsNullOrWhiteSpace(陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.get_Text())) ? "0" : 陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.get_Text());
		try
		{
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Clear();
			쳻촏쳱쳎쳐쳑촅쳍쳞쳍쳈쳎촐쳋쳚(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			丣丠乒乐丢丨乐乔丵丣乓乗乕両乖 = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._F6E3_F70A_F6E6_F719_F714_F6E0_F704_F714_F6E5_F715_F6E5_F701_F6E4_F6FD_F6E4(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.큆큇큇큌큊큛큪클킇큠큋큹큷큻큆(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._FAEA𢡊_FAEB謁覆_FAF3_FAE6覆_FAF7請諭諸諸謁_FADD(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖, 0.0, 0.0), double.Parse(愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦.get_Text()), double.Parse(陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖.get_Text())), 0.0, 0.0);
			val.set_Points(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖);
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
			燽燿爄爺爱爣爤爰爮爵爄爄燾燽燻();
		}
		catch
		{
		}
	}

	private void 겘곈곐곍겗곙겲곋겚곍겻겚결겚곈(object _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD, RoutedEventArgs _200B_2029_2020_1FFD_2031ῲ_1FFE_201F_1FED_201B_201E_2022_1FED_2024_2028)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.set_Text(Regex.Replace(澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.get_Text(), "[^0-9,]+", "", RegexOptions.Compiled));
		澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.set_Text((string.IsNullOrEmpty(澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.get_Text()) || string.IsNullOrWhiteSpace(澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.get_Text())) ? "1" : 澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.get_Text());
		ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.set_Text(Regex.Replace(ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.get_Text(), "[^0-9,]+", "", RegexOptions.Compiled));
		ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.set_Text((string.IsNullOrEmpty(ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.get_Text()) || string.IsNullOrWhiteSpace(ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.get_Text())) ? "1" : ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.get_Text());
		try
		{
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Clear();
			쳻촏쳱쳎쳐쳑촅쳍쳞쳍쳈쳎촐쳋쳚(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			丣丠乒乐丢丨乐乔丵丣乓乗乕両乖 = 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._F6E3_F70A_F6E6_F719_F714_F6E0_F704_F714_F6E5_F715_F6E5_F701_F6E4_F6FD_F6E4(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧.䠕䠹䠺䡇䡑䡄䠒䡆䡇䡈䡄䡇䠔䡄䠚(跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧._FAEA𢡊_FAEB謁覆_FAF3_FAE6覆_FAF7請諭諸諸謁_FADD(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖, -125.0, -125.0), double.Parse(澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌.get_Text()), double.Parse(ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ.get_Text())), 125.0, 125.0);
			val.set_Points(丣丠乒乐丢丨乐乔丵丣乓乗乕両乖);
			((Panel)䓆䓀䒍䓑䒴䓑䒓䒍䒑䒒䒑䒾䒿䒔䒳).get_Children().Add((UIElement)(object)val);
			燽燿爄爺爱爣爤爰爮爵爄爄燾燽燻();
		}
		catch
		{
		}
	}

	private void 蠑衃衇蠘蠑衃蠥蠔蠗街衆蠑蠕蠥蠮(object 귲긝귳긖귴긠긞귳긢귯긢긒귮긡귮, MouseButtonEventArgs 䣘䢨䢥䢬䣛䢨䣭䢩䣃䣚䣋䣄䢮䣣䢦)
	{
		扆扨扴扫打扇扬扢扚扥扷抄承扉扸();
	}

	public void 㙤㙆㙫㙺㙈㙬㙎㙯㙋㙺㙈㙫㙞㙣㚍(ref TextBox 쨓짘짢쨀짒쨄쨇쨊짔쨅짓짔쨄쨅쨙, ref TextBox 癇癉癅癶癷癷癸癊癴癊癋癋癴癴癷, ref TextBox _F836_F86C_F83A_F837_F839_F87D_F83D_F838_F83D_F87A_F846_F834_F868_F83C_F87B, ref TextBox _22C5_2292_228F_22A0_22D1_22C5_2291_2298_2290_22C2_2298_2291_22D3_2291_2292, int 硫梨了廉僚連連列烈硫連劣廉咽料)
	{
		try
		{
			if (int.Parse(쨓짘짢쨀짒쨄쨇쨊짔쨅짓짔쨄쨅쨙.get_Text()) <= 10 && int.Parse(癇癉癅癶癷癷癸癊癴癊癋癋癴癴癷.get_Text()) <= 10)
			{
				_22C5_2292_228F_22A0_22D1_22C5_2291_2298_2290_22C2_2298_2291_22D3_2291_2292.set_Text(new 跒趖跅趔趬趙跅跆趑趘跃跉趓趥趧(int.Parse(쨓짘짢쨀짒쨄쨇쨊짔쨅짓짔쨄쨅쨙.get_Text()), int.Parse(癇癉癅癶癷癷癸癊癴癊癋癋癴癴癷.get_Text()), _F836_F86C_F83A_F837_F839_F87D_F83D_F838_F83D_F87A_F846_F834_F868_F83C_F87B.get_Text()).笀竌竆竄笄竷竊立竊竸竴竹立竸竃());
				switch (硫梨了廉僚連連列烈硫連劣廉咽料)
				{
				case 1:
					((ContentControl)垺坼垩垦坵垨型垧垅垯坺坼坺垩垯).set_Content((object)"");
					break;
				case 2:
					((ContentControl)ⰳⰲⰴⰱⱻⱸⱦⱪⱩⱙⰷⱥⱺⰴⰵ).set_Content((object)"");
					break;
				}
			}
			else
			{
				switch (硫梨了廉僚連連列烈硫連劣廉咽料)
				{
				case 1:
					((ContentControl)垺坼垩垦坵垨型垧垅垯坺坼坺垩垯).set_Content((object)"Max 10x10");
					break;
				case 2:
					((ContentControl)ⰳⰲⰴⰱⱻⱸⱦⱪⱩⱙⰷⱥⱺⰴⰵ).set_Content((object)"Max 10x10");
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void 㼽㼕㻽㼨㻹㻶㼥㻶㻺㼧㻷㼥㼅㼧㼨(object ⷘⷚⶭⶽⶭⶨⶥⶨⶪⶪ_2DE4ⶬⷃⶬⶦ, RoutedEventArgs 㙥㚙㙩㙤㙩㚥㚘㚕㚓㙤㚗㙫㚘㚗㙤)
	{
		㙤㙆㙫㙺㙈㙬㙎㙯㙋㙺㙈㙫㙞㙣㚍(ref 釦鈑釡鈑釤鈔鈛鈒釟鈒釲釡鈏釼釤, ref 廬廚弊弌廚廹式廝廷廛廵弌弊廛弍, ref 孬宨客孬定孮孯宙孿宗宙孮宯孪孩, ref _EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0, 1);
	}

	private void _262D_2607_2604_262A_2605_2604_262A_2609_2634_262C_2647_2608_260A_2635_2603(object 峼峚崇峔峥峻崅峕峒崈崆崆崄峙崚, RoutedEventArgs ힸힺힻퟣퟧힸퟭퟬힸힹힻퟛힵퟵힲ)
	{
		㙤㙆㙫㙺㙈㙬㙎㙯㙋㙺㙈㙫㙞㙣㚍(ref ņėĖŃĕĎŋĿģĿŃŃĒŃœ, ref 訣訤訜訥訟訣詗詍訥訶詝訟訿証訝, ref ᲣᲢᲢ_1CD5ᲦᲶᲤᲦ_1CD6_1CC8_1CD4_1CD3ᲨᲢᲩ, ref 婗婮媅婗婖媕婙媛婖婚婙婙婕媘婜, 2);
	}

	private void 圹圎场圸坋國圈圻圈圶圙圹圗圈圝(object 芢芴芁芁芐花苃芁芄艼芬艻芿艼苀, MouseButtonEventArgs 喥喢喖啭啭啭啲喡啭啮啬啯啮啵善)
	{
		((Window)this).DragMove();
	}

	private void _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD(object 뮏뮍뮾뮓뮖믆뮐뮾믕믁믃믁뮍뮐믗, RoutedEventArgs ꯡ_ABE5_ABE6ꮯꮲ_ABE7ꯐꮵꮬꯠꮭꮭꯟꮮꯂ)
	{
		((Window)this).Close();
	}

	private void _E6E9_E6B7_E6F9_E6E8_E6B7_E6B4_E6B8_E6BB_E6B6_E6B3_E6D6_E6E6_E6B4_E6B3_E6B4(object 瞘瞑瞙瞤矎瞴瞣瞑矁矆瞘瞭瞒瞸矖, RoutedEventArgs _2191_21C4_21B5_21C2_21C3_2193_2190_21A5_2195_2198_2197_2190_21D2_21C4_21C4)
	{
		((Window)this).set_WindowState((WindowState)1);
	}

	private void 膯膳膸臊臢膲臋臡臱臣臬臥臂膷臀(object Ꮭ_139AᏋᏌᏈ_1399Ꭰ_1398ᏋᏝ_1398ᏊᎶᎠᏡ, RoutedEventArgs 礍礌礆礌礹礟祆礍礋礗礞礆礜礌礇)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		諸視_FAED_FAE9贈謹諸視請_FAEE𥳐_FAED_FAEC諸頋();
	}

	private void 嘚嘗嘖嘗嘛噙噅噜噆嘼嘧嘬噘嘔噉(object 띳랢랅랢랢띺랕랍램랕띸띳랦램띸, RoutedEventArgs 铽银销铂铋铮铝钹铁铫钽铪钿铔铪)
	{
		扆扨扴扫打扇扬扢扚扥扷抄承扉扸();
	}

	private void 旋旳旸旅旵旅昇旛旳时旸旄旵旸旉(object 쿇쿉쿌쿍퀁퀈쿊퀎쿿쿐쿙쿱쿐쿐쿛, RoutedEventArgs 靬靤鞃靥靪鞖鞘靦鞆鞂靵鞔鞆鞨鞝)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if (濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗)
		{
			_08C9ࣇ_08CD_08FA_08CCࣄ_08CAࣇ_08E2_08DD_08F8_08EDࣅ_08C8ࣄ.set_ImageSource((ImageSource)new BitmapImage(new Uri("..\\..\\Images\\x_hover.png", UriKind.Relative)));
			濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗 = !濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗;
		}
		else
		{
			_08C9ࣇ_08CD_08FA_08CCࣄ_08CAࣇ_08E2_08DD_08F8_08EDࣅ_08C8ࣄ.set_ImageSource((ImageSource)new BitmapImage(new Uri("..\\..\\Images\\x.png", UriKind.Relative)));
			濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗 = !濫瀖濧瀞瀘瀖濦濢濪瀫瀉濫濩瀘瀗;
		}
	}

	private void _E9D6_EA06_E9FC_E9F6_E9FB_E9ED_EA0E_E9FA_E9E0_EA08_E9CD_EA0B_E9E5_E9CD_E9DA(object _26BC_268E_268E_26A5_268E_26A8_26AF_26AD_26B8_26BA_26B9_2688_269C_26BA_268A, RoutedEventArgs 볏볽볊볿볒볽볓병볜볒볏병볏볿볭)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if (羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼)
		{
			_E196_E17C_E169_E161_E164_E166_E162_E185_E168_E18A_E197_E195_E185_E193_E19F.set_ImageSource((ImageSource)new BitmapImage(new Uri("..\\..\\Images\\m_hover.png", UriKind.Relative)));
			羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼 = !羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼;
		}
		else
		{
			_E196_E17C_E169_E161_E164_E166_E162_E185_E168_E18A_E197_E195_E185_E193_E19F.set_ImageSource((ImageSource)new BitmapImage(new Uri("..\\..\\Images\\m.png", UriKind.Relative)));
			羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼 = !羸羝羜羽羘翑羚羘羡羘翟翋翋翎羼;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void ꚱꚢꚱꚶꚇꚲꛈꚴꛆꚖꚈꚂꚢꚦꚀ()
	{
		if (!垡坾坮垨坪坮垛垓垯垛垎坮垠坻垦)
		{
			垡坾坮垨坪坮垛垓垯垛垎坮垠坻垦 = true;
			Uri uri = new Uri("/WPFlindao;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void 痑瘑痍痌瘑痡瘔痥痌痠痒痌痎痻痍(int _੯સ੯ੳ_0A76ડયણ੯ગટ_0A77_0A75ત_0A75, object 伟伣佑伤伣住伤住伣佂伤传佐位伞)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		switch (_੯સ੯ੳ_0A76ડયણ੯ગટ_0A77_0A75ત_0A75)
		{
		case 1:
			((UIElement)(蓱蓤蓍蒳蒱蓈蓢蓄蒳蒰蒰蓥蒯蒷蓗)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseLeftButtonDown(new MouseButtonEventHandler(膯膳膸臊臢膲臋臡臱臣臬臥臂膷臀));
			((UIElement)(蓱蓤蓍蒳蒱蓈蓢蓄蒳蒰蒰蓥蒯蒷蓗)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseRightButtonDown(new MouseButtonEventHandler(嘚嘗嘖嘗嘛噙噅噜噆嘼嘧嘬噘嘔噉));
			break;
		case 2:
			瓎璡璠瓍瓑璮瓎璶璹瓡璱璝璢璞瓗 = (Grid)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 3:
			((UIElement)(Rectangle)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseLeftButtonDown(new MouseButtonEventHandler(圹圎场圸坋國圈圻圈圶圙圹圗圈圝));
			break;
		case 4:
			埛培埋埅埍埶埶埌埬埋域埋埶培培 = (Canvas)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((UIElement)埛培埋埅埍埶埶埌埬埋域埋埶培培).add_MouseRightButtonDown(new MouseButtonEventHandler(蠑衃衇蠘蠑衃蠥蠔蠗街衆蠑蠕蠥蠮));
			break;
		case 5:
			((UIElement)(Label)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseLeftButtonDown(new MouseButtonEventHandler(圹圎场圸坋國圈圻圈圶圙圹圗圈圝));
			break;
		case 6:
			((ButtonBase)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_Click(new RoutedEventHandler(_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD));
			((UIElement)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseEnter(new MouseEventHandler(旋旳旸旅旵旅昇旛旳时旸旄旵旸旉));
			((UIElement)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseLeave(new MouseEventHandler(旋旳旸旅旵旅昇旛旳时旸旄旵旸旉));
			break;
		case 7:
			_08C9ࣇ_08CD_08FA_08CCࣄ_08CAࣇ_08E2_08DD_08F8_08EDࣅ_08C8ࣄ = (ImageBrush)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 8:
			((ButtonBase)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_Click(new RoutedEventHandler(_E6E9_E6B7_E6F9_E6E8_E6B7_E6B4_E6B8_E6BB_E6B6_E6B3_E6D6_E6E6_E6B4_E6B3_E6B4));
			((UIElement)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseEnter(new MouseEventHandler(_E9D6_EA06_E9FC_E9F6_E9FB_E9ED_EA0E_E9FA_E9E0_EA08_E9CD_EA0B_E9E5_E9CD_E9DA));
			((UIElement)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_MouseLeave(new MouseEventHandler(_E9D6_EA06_E9FC_E9F6_E9FB_E9ED_EA0E_E9FA_E9E0_EA08_E9CD_EA0B_E9E5_E9CD_E9DA));
			break;
		case 9:
			_E196_E17C_E169_E161_E164_E166_E162_E185_E168_E18A_E197_E195_E185_E193_E19F = (ImageBrush)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 10:
			_E710_E73F_E70E_E70C_E70E_E73F_E71F_E713_E710_E73E_E73E_E73B_E73D_E726_E727 = (ComboBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 11:
			_2109ℨ_20F7ℹ_2129ℐ_20F6Ω_20F8_20F6_20F6ℏℼ_20FA_20FD = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 12:
			_17C9ឝ_17C6មផប_17DBរ_17BEឩវ_17B8_17C7_17C5_17BB = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 13:
			竗窓窛窓窖窗竄窖竉窙窥窦竇窙竈 = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 14:
			_21CE_21D1_21CE_21D0_21D6_21D1_21D6_21CE_21FE_2202_2212_21D5_21D3_21D5_21D1 = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 15:
			ꑪꑨ_A497ꑫ_A496_A4ACꑮꑭꒄꑫ_A496ꑥ_A49Aꒊ_A4A6 = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 16:
			꺅꺟꺃꺇꺶꺻꺖꺲꺕껄꺦꺂꺂꺈꺈 = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 17:
			沛泑沜泘沜沞沟泑没沚泎泑泍沚沝 = (ComboBoxItem)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 18:
			_EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((TextBoxBase)_EEEA_EEFB_EEF0_EF02_EEEC_EF02_EF05_EEED_EEEA_EEF0_EEF1_EEFA_EEEC_EF31_EEF0).add_TextChanged(new TextChangedEventHandler(쭎쬣쭑쭑쬤쬝쬿쭏쬾쭢쭛쬻쬼쬢쭐));
			break;
		case 19:
			ⰠⱋⰰⱇⰎⰐⰈⰢⰛⰍⰼⰈⰺⱌⱐ = (Label)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 20:
			婗婮媅婗婖媕婙媛婖婚婙婙婕媘婜 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((TextBoxBase)婗婮媅婗婖媕婙媛婖婚婙婙婕媘婜).add_TextChanged(new TextChangedEventHandler(쭎쬣쭑쭑쬤쬝쬿쭏쬾쭢쭛쬻쬼쬢쭐));
			break;
		case 21:
			츯츬츇췹췹츯췶츶췼츫췼췺칀췸츛 = (Label)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 22:
			((ButtonBase)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_Click(new RoutedEventHandler(퓯퓵픓픮퓸퓷픇픘프픖퓸픠퓯퓷픵));
			break;
		case 23:
			ฉ_0DFAสฬฮษ_0DF7_0DFF_0E00_0DF9_0DFFฑำธ_0DF7 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 24:
			쬐쭄쭁쬑쬱쬔쭂쭋쬐쬓쬬쭖쭈쭁쬶 = (StackPanel)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 25:
			鴧鴷鴫鴸鴩鵙鴪鴥鴶鵠鴫鴭鴮鵖鴪 = (StackPanel)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 26:
			ᬝᭅᬜᬢ_1B61_1B4Cᬭ_1B4F_1B3Fᬛ_1B34_1B4E᭐᭑_1B4E = (StackPanel)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 27:
			ﰹﱢﱭﱌﰱﱥﰲﱢﱧﰵﰳﰲﱢﱧﰳ = (Button)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((ButtonBase)ﰹﱢﱭﱌﰱﱥﰲﱢﱧﰵﰳﰲﱢﱧﰳ).add_Click(new RoutedEventHandler(蓾蔩蓿蔚蔶蔮蓾蓷蔫蔊蔹蔊蓺蓹蔨));
			break;
		case 28:
			䃸䃵䄥䄰䄐䄉䄜䃶䃹䃷䄍䄽䄥䃵䃸 = (Button)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((ButtonBase)䃸䃵䄥䄰䄐䄉䄜䃶䃹䃷䄍䄽䄥䃵䃸).add_Click(new RoutedEventHandler(霶靡霮靲靡靔面霯露霷靡靨霵靬霶));
			break;
		case 29:
			_E42F_E417_E3FE_E431_E43A_E402_E42F_E3FC_E42F_E431_E42F_E434_E41B_E3FD_E432 = (Button)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			((ButtonBase)_E42F_E417_E3FE_E431_E43A_E402_E42F_E3FC_E42F_E431_E42F_E434_E41B_E3FD_E432).add_Click(new RoutedEventHandler(겘곈곐곍겗곙겲곋겚곍겻겚결겚곈));
			break;
		case 30:
			쯍쮶쯐쮰쮸쮜쯎쮤쯏쮢쮶쯐쯠쯟쯃 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 31:
			愹愸慄愸慳慏愳愵慦愻慥慼慹愻慦 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 32:
			陏陓隅隂隃陿陖隌隅陷陧陓陏陑陖 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 33:
			澑澒澿澿濊澽澻澾澼澚濄澾澒澏澌 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 34:
			ἥἤἦὦἥ_1F5AὒἩἤἩὁὤἦἨὉ = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 35:
			孬宨客孬定孮孯宙孿宗宙孮宯孪孩 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 36:
			ᲣᲢᲢ_1CD5ᲦᲶᲤᲦ_1CD6_1CC8_1CD4_1CD3ᲨᲢᲩ = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 37:
			廬廚弊弌廚廹式廝廷廛廵弌弊廛弍 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 38:
			釦鈑釡鈑釤鈔鈛鈒釟鈒釲釡鈏釼釤 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 39:
			((ButtonBase)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_Click(new RoutedEventHandler(㼽㼕㻽㼨㻹㻶㼥㻶㻺㼧㻷㼥㼅㼧㼨));
			break;
		case 40:
			訣訤訜訥訟訣詗詍訥訶詝訟訿証訝 = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 41:
			ņėĖŃĕĎŋĿģĿŃŃĒŃœ = (TextBox)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 42:
			((ButtonBase)(Button)伟伣佑伤伣住伤住伣佂伤传佐位伞).add_Click(new RoutedEventHandler(_262D_2607_2604_262A_2605_2604_262A_2609_2634_262C_2647_2608_260A_2635_2603));
			break;
		case 43:
			垺坼垩垦坵垨型垧垅垯坺坼坺垩垯 = (Label)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 44:
			ⰳⰲⰴⰱⱻⱸⱦⱪⱩⱙⰷⱥⱺⰴⰵ = (Label)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		case 45:
			厷台厸厯古古反厷厶厲古厲厸厳厵 = (Label)伟伣佑伤伣住伤住伣佂伤传佐位伞;
			break;
		default:
			垡坾坮垨坪坮垛垓垯垛垎坮垠坻垦 = true;
			break;
		}
	}
}
