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

namespace ꅃꅾꅉꅅꆁꅘꅅꅗꅉꅴꅅꅉꅇꅱꅄ;

public class _264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649 : Window, IComponentConnector
{
	public static PointCollection ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ = new PointCollection();

	public static Canvas _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD;

	internal Grid 蜪蜨蜪蝄蜛蜖蜓蜖蝆蝄蜦蜲蜓蜛蜳;

	internal Canvas _29AB_2977_297E_2997_2998_297A_2977_297C_29B9_29AD_29A8_297B_29AA_297B_297C;

	internal ImageBrush 덣뎌덜덣뎛덢뎅뎐덟뎍뎐뎖덜뎁덜;

	internal ImageBrush _0CD0೪_0CC9_0CFB_0CD0_0CCB_0CE5_0CC9_0CD0_0CFD_0CD1೫_0CFC_0CC9_0CC9;

	internal ComboBox 턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛;

	internal ComboBoxItem 䪓䪲䪽䪌䪣䪐䪑䫀䪔䫇䫀䪎䫐䪐䪦;

	internal ComboBoxItem 廗廈廎廆廼廆廌廻廇廆廆廜廌建廻;

	internal ComboBoxItem 鐩鐟鐖鐜鐠鏥鐙鐚鏪鏭鏥鏪鏹鐚鏭;

	internal ComboBoxItem 䎀䍌䎏䍎䍌䍋䍎䍹䍌䍹䍬䍍䍌䎆䍻;

	internal ComboBoxItem _E384_E385_E389_E383_E384_E382_E389_E3B5_E380_E39C_E386_E3B2_E3B1_E392_E3B6;

	internal ComboBoxItem 䖰䖪䗛䗛䖱䗣䗓䖳䖭䗜䖰䗠䗠䖬䗜;

	internal ComboBoxItem 볩볧볥볺벶볖볔벼벶볨벶벻본벵벷;

	internal TextBox 镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢;

	internal Label ŭŖŵśŘƋœŖŜƈŤŔœŘŨ;

	internal TextBox 熇熎熗熈熍熤熉熷熻熷燃熉熎熏熆;

	internal Label 诓诌论诰详诩讵诙诅诇讼讹讹诨讵;

	internal TextBox ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ;

	internal StackPanel _3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ;

	internal StackPanel ﰪﰳﰫﰰﱳﰲﱯﱠﱛﱜﱀﱜﱜﰭﱞ;

	internal StackPanel 㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉;

	internal Button _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD;

	internal Button ﹼ_FE51_FE5C_FE50_FE4Cﹿ_FE4Bﹽﹽ_FE6E_FE53_FE4E_FE6A_FE53_FE4F;

	internal Button ᨲᨯ_1A69ᨳ_1A5C_1A5Bᨬᨾᨲᨭᨱᨱᨯ_1A5Eᨳ;

	internal TextBox 殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿;

	internal TextBox 䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂;

	internal TextBox 죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐;

	internal TextBox 퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥;

	internal TextBox 鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖;

	internal TextBox ጮጂዾጮጅጅዾዽጆጁጿጄጅጅጀ;

	internal TextBox 倫降律﨔倫倫行律輻凞祥溺率行行;

	internal TextBox ǧȘȕȟȁȗǥȍȕǬȂǫǤȘȘ;

	internal TextBox 叠叨厳厬叝叞叞叢厬参叒厲厳厴厬;

	internal TextBox _F241_F281_F273_F26F_F261_F275_F23E_F25A_F256_F23E_F240_F26F_F243_F257_F23B;

	internal TextBox 鞮音鞴韞鞵鞲韞鞰韩鞴鞶鞲韤韦韞;

	internal Label 돞돼됎됁돔돽돿됋됀돍돒돿돍돒돽;

	internal Label ⶉⶸⶈⷃ_2DB7_2D9Dⶵⶇⶊⶇⶋⶸⶵ_2DB7_2DB7;

	internal Label _4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗;

	private bool 窓窒窙竃窒窖窙窵窘竅窙竅窔窘竅;

	private bool 聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶 = true;

	private bool 琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓 = true;

	public _264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		Console.WriteLine();
		ﻚﻒﻚ_FF07_FF06ﻬ_FF08３ﻑﻖﻖ_FF0Dﻗ_FF03ﻑ();
		_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = _29AB_2977_297E_2997_2998_297A_2977_297C_29B9_29AD_29A8_297B_29AA_297B_297C;
		軝軌躕軈軜躚躗躛躕躘躔軅躛躨車(25, "#555555");
		Polygon val = new Polygon();
		val.set_FillRule((FillRule)1);
		((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
		val.set_Points(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ);
		((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
	}

	public void 믶믷밊밐밃믳믺믲믺믳밦밣믲받믻(int 漭潯潋漫漹漧潭潦漼潛漩潣潛漫潗, int 卥卥匰匶占卥卧匰占卣匷升卮匰危, int 댸댽덧덧댸덹댵댽덱덩댽댸덫댺댼, int 쟆쟈잷잌임잌잊잹잸잍잍잇잋잣잶, string _F3A4_F3A2_F3AA_F374_F375_F38B_F371_F375_F3A2_F38A_F37F_F36E_F375_F36E_F3A6, int 톆톞톏톬톷톏톽톉톼퇉톷톋톌톏톟)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Line val = new Line();
		val.set_X1((double)漭潯潋漫漹漧潭潦漼潛漩潣潛漫潗);
		val.set_X2((double)댸댽덧덧댸덹댵댽덱덩댽댸덫댺댼);
		val.set_Y1((double)卥卥匰匶占卥卧匰占卣匷升卮匰危);
		val.set_Y2((double)쟆쟈잷잌임잌잊잹잸잍잍잇잋잣잶);
		((Shape)val).set_StrokeThickness((double)톆톞톏톬톷톏톽톉톼퇉톷톋톌톏톟);
		((Shape)val).set_Stroke((Brush)((TypeConverter)new BrushConverter()).ConvertFromString(_F3A4_F3A2_F3AA_F374_F375_F38B_F371_F375_F3A2_F38A_F37F_F36E_F375_F36E_F3A6));
		((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
	}

	public void 軝軌躕軈軜躚躗躛躕躘躔軅躛躨車(int ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ, string 聥肔肒聩聡肋聢聼聢肒聢肖肣聦聦)
	{
		for (int i = 0; i < 250 - ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ; i++)
		{
			믶믷밊밐밃믳믺믲믺믳밦밣믲받믻(ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ * i, 0, ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ * i, 250, 聥肔肒聩聡肋聢聼聢肒聢肖肣聦聦, 1);
			믶믷밊밐밃믳믺믲믺믳밦밣믲받믻(0, ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ * i, 250, ڋڋڅڸڇډڕڇڶډڋڷڶۂۋ * i, 聥肔肒聩聡肋聢聼聢肒聢肖肣聦聦, 1);
		}
		믶믷밊밐밃믳믺믲믺믳밦밣믲받믻(0, 125, 250, 125, "#ededed", 1);
		믶믷밊밐밃믳믺믲믺믳밦밣믲받믻(125, 0, 125, 250, "#ededed", 1);
	}

	private void ᣵᢶᢲᢴᢳᣄᢶᣪᢸᢵᣤᢶᣌᣊᣧ(double _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD, double _꘢꘢_A635Ꙋꙏꙣ_A634_A62Cꘜꘚꘝꙛꙋꙕꘞ, string 숤술숆쇷숏술숣쇷쇲술쇯숩쇵쇲숣, Color _3398_33C5_3398_33DB_33BD_3398_3399_33B8_33C5_33B7_33C9_3397_33B5_3398_3397)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		TextBlock val = new TextBlock();
		val.set_Text(숤술숆쇷숏술숣쇷쇲술쇯숩쇵쇲숣);
		val.set_Foreground((Brush)new SolidColorBrush(_3398_33C5_3398_33DB_33BD_3398_3399_33B8_33C5_33B7_33C9_3397_33B5_3398_3397));
		Canvas.SetLeft((UIElement)(object)val, _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD);
		Canvas.SetTop((UIElement)(object)val, _꘢꘢_A635Ꙋꙏꙣ_A634_A62Cꘜꘚꘝꙛꙋꙕꘞ);
		((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
	}

	public Point 捽捾掘捬据探捭捯掛掃掛掎捪掚捦()
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
		Point position = Mouse.GetPosition((IInputElement)(object)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD);
		bool flag = false;
		if (((Point)(ref position)).get_X() > 0.0 && ((Point)(ref position)).get_Y() > 0.0)
		{
			ᣵᢶᢲᢴᢳᣄᢶᣪᢸᢵᣤᢶᣌᣊᣧ(((Point)(ref position)).get_X(), ((Point)(ref position)).get_Y(), "(" + (((Point)(ref position)).get_X() - 125.0) + _003CModule_003E.ꃺꃡꃉꃢꃊꃌꃐꃹꃏꃋꃽꃾꃽꃺꃰ() + (((Point)(ref position)).get_Y() - 125.0) + ")", Colors.get_Red());
			ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.Add(position);
			flag = true;
		}
		if (((Panel)_3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ).get_Children().get_Count() < 10 && flag)
		{
			Button val = new Button();
			((ButtonBase)val).add_Click(new RoutedEventHandler(button_Click));
			((ContentControl)val).set_Content((object)_003CModule_003E.쑉쐙쑅쑃쑎쐪쐱쑄쑇쑈쐗쑏쐒쐙쑃());
			((FrameworkElement)val).set_Name(_003CModule_003E._1B5Cᮆᮈ_1B7D_1B5C᭕ᮅ_1B5Aᮉ_1B5Aᮎᮝᮅᮕᮝ() + ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.IndexOf(position));
			((Panel)_3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ).get_Children().Add((UIElement)(object)val);
			TextBox val2 = new TextBox();
			((FrameworkElement)val2).set_Name(_003CModule_003E.䭟䭰䬼䬿䭂䭠䭅䮅䭯䭲䭂䭮䭓䭾䭭() + ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.IndexOf(position));
			val2.set_Text((((Point)(ref position)).get_X() - 125.0).ToString());
			val2.set_MaxLength(4);
			val2.set_MaxLines(1);
			((Panel)ﰪﰳﰫﰰﱳﰲﱯﱠﱛﱜﱀﱜﱜﰭﱞ).get_Children().Add((UIElement)(object)val2);
			TextBox val3 = new TextBox();
			((FrameworkElement)val3).set_Name(_003CModule_003E.ッんニ_3098ッゔゑッテゕゴんをゖグ() + ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.IndexOf(position));
			val3.set_Text((((Point)(ref position)).get_Y() - 125.0).ToString());
			val3.set_MaxLength(4);
			val3.set_MaxLines(1);
			((Panel)㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉).get_Children().Add((UIElement)(object)val3);
		}
		return new Point(((Point)(ref position)).get_X(), ((Point)(ref position)).get_Y());
	}

	protected void button_Click(object sender, RoutedEventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button)((sender is Button) ? sender : null);
		int num = ((Panel)_3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ).get_Children().IndexOf((UIElement)((sender is Button) ? sender : null));
		_003F val2 = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ;
		double num2 = double.Parse(((TextBox)/*isinst with value type is only supported in some contexts*/).get_Text()) + 125.0;
		UIElement obj = ((Panel)㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉).get_Children().get_Item(num);
		((PointCollection)val2).set_Item(num, new Point(num2, double.Parse(((TextBox)((obj is TextBox) ? obj : null)).get_Text()) + 125.0));
		ﷃ_FDDAﷃﷀﷱﷶﷁﷅﷅ_FDE2ﷶ_FDD5ﷱﷷ_FDC8();
	}

	public void _2816_2815_2853_284D_2811_2813_2844_2843_2815_282E_2816_282B_283F_2810_2832()
	{
		ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.Clear();
		List<TextBlock> list = ((IEnumerable)((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children()).OfType<TextBlock>().ToList();
		foreach (TextBlock item in list)
		{
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Remove((UIElement)(object)item);
		}
		((Panel)ﰪﰳﰫﰰﱳﰲﱯﱠﱛﱜﱀﱜﱜﰭﱞ).get_Children().Clear();
		((Panel)㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉).get_Children().Clear();
		((Panel)_3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ).get_Children().Clear();
	}

	public static void ᘼᙍᘼᘾᘼᘑᘬᘉᘽᘏᘼᘎᘐᘺᘐ(object _061Cآפע_0615ער_0613תע_0613רסײ_0605, TextCompositionEventArgs 缚缼缌缪缹缌缎缇缜缦缈缼缆罊缎)
	{
		Regex regex = new Regex("[^0-9,]+");
		((RoutedEventArgs)缚缼缌缪缹缌缎缇缜缦缈缼缆罊缎).set_Handled(regex.IsMatch(缚缼缌缪缹缌缎缇缜缦缈缼缆罊缎.get_Text()));
	}

	public void 샊샇샻생샥샌샯샎샏샤샹샇섌샎샱(ref Label 僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂, TextBox 掦掰捺控捸捶捸捺掦捸掗掦捺捲推)
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
		string text = 掦掰捺控捸捶捸捺掦捸掗掦捺捲推.get_Text();
		if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
		{
			((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E.覧覠覨覨覧覩覠觔觇覨覾覧觩覶覧());
			((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#ededed"));
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
				((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E._0F14_0F11_0EE0_0F10_0EE7_0F04_0EE3_0F1D_0EF9_0F11_0EE7ໟ_0F10ໟ_0F17());
				((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
				break;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				if (string.IsNullOrWhiteSpace(array2[j]) || string.IsNullOrEmpty(array2[j]))
				{
					((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E.ឮ_17DA_17DD_17C3ឫឬ_17DDឬឱ_17D2ឨ_17B9_17D9_17DDឫ());
					((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
					break;
				}
				((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E.姐姤姲妯妭妬姒姮妴姀姍姏姜妯妫());
				((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#2ecc71"));
			}
		}
		if (!((string)((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).get_Content() == _003CModule_003E.팯팩팩팝팾틽팥틺팚팼팑틸틹판패()))
		{
			return;
		}
		try
		{
			Console.WriteLine(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.籧粕籤籽籧粄籪籬籸粘粛籧粥粮籧(text).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E.얈양앺얀앳앟앦얐얓애앥얨얖앧앟());
			((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#2ecc71"));
		}
		catch
		{
			((ContentControl)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Content((object)_003CModule_003E._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD());
			((Control)僚儁僮僟僂僸傾僛傺僫傾僁僀僂儂).set_Foreground((Brush)((TypeConverter)new BrushConverter()).ConvertFromString("#e74c3c"));
		}
	}

	private void 凍凁冾冑冈冊冎冾凂冱冐凉冹冊冽(object 㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞, TextChangedEventArgs 䞚䝦䝦䞄䞙䝧䞗䞗䞊䝮䞘䞮䞃䞘䞗)
	{
		if (((FrameworkElement)((㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 is TextBox) ? 㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 : null)).get_Name() == _003CModule_003E.뜮뜃뜵뜿뜬뜀뜑뜃뜖뜍띁뜮뛿뜹뛻())
		{
			샊샇샻생샥샌샯샎샏샤샹샇섌샎샱(ref ŭŖŵśŘƋœŖŜƈŤŔœŘŨ, (TextBox)((㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 is TextBox) ? 㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 : null));
		}
		else
		{
			샊샇샻생샥샌샯샎샏샤샹샇섌샎샱(ref 诓诌论诰详诩讵诙诅诇讼讹讹诨讵, (TextBox)((㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 is TextBox) ? 㑞㒓㑢㑞㒏㑣㒏㑡㑭㑯㑶㑴㑛㒠㑞 : null));
		}
	}

	private void 헄햗햒햘햸햙햔햙햺햙햑헃햲헅햗(object _25A6_25A8_25DA_25EC_25AB_25D8_25AA_25D7_25AE_25E2_25AE_25D7_25C7_25A9_25A9, RoutedEventArgs _3217ㇷ_322C_3224_3205_3226_3228_321Cㇷㇹ_3225_320D_3211ㇴㇹ)
	{
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj = _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.籧粕籤籽籧粄籪籬籸粘粛籧粥粮籧(镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢.get_Text());
		_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1 obj2 = _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.籧粕籤籽籧粄籪籬籸粘粛籧粥粮籧(熇熎熗熈熍熤熉熷熻熷燃熉熎熏熆.get_Text());
		bool flag = obj.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 == obj2.睪眹眸睪眽睬睨睪眷睉眻睨睈眽睌 && obj.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎 == obj2.炖烂炖炔炠炕炖炔烐炑烀烍炓炐炎;
		((ContentControl)_4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗).set_Content((object)_003CModule_003E.륡뤲륟뤲뤱륩륤뤳륞륝률뤫뤳뤳륒());
		if (!((string)((ContentControl)ŭŖŵśŘƋœŖŜƈŤŔœŘŨ).get_Content() == _003CModule_003E.ΌΊ_036DΈΒ_0357_035A_038BΞ_0387_0359_035E_035E_035A_0375()) || (!((string)((ContentControl)诓诌论诰详诩讵诙诅诇讼讹讹诨讵).get_Content() == _003CModule_003E._EE20_EE33_EE34_EDED_EE12_EDED_EE2A_EE0C_EDED_EE2E_EDEA_EE1C_EDEB_EDEB_EDF2()) && !(턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛.get_Text() == _003CModule_003E._A9DBꧡ_A9DEꦰꧠ_A9DF_A9DCꧦ_A9DEꦰꦩ_A9DFꧭꧩ_A9DB()) && !(턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛.get_Text() == _003CModule_003E.矰矔瞽矍矂矿矁矿矣矋矁矮矤矕瞿()) && !(턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛.get_Text() == _003CModule_003E._F15B_F153_F154_F175_F19A_F188_F185_F195_F184_F154_F157_F185_F19D_F188_F187())))
		{
			return;
		}
		string text = 턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛.get_Text();
		string text2 = text;
		switch (횔횖홪횘황횁홤홻횘홪횓홢횫황횝._1316ጁጳጃገጀጶጁፅፆጧጴጠጁጱ(text2))
		{
		case 1071174216u:
			if (!(text2 == _003CModule_003E.扅戓戬戍成戫扏扆所我扃戎扊戳扂()))
			{
				break;
			}
			if (flag)
			{
				ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.䘴䙒䘳䘮䙰䙟䙂䙡䙅䙢䘴䘱䘯䙟䘾(obj, obj2).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			}
			else
			{
				((ContentControl)_4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗).set_Content((object)"Both must be the same size to do this operation!");
			}
			return;
		case 357949441u:
			if (!(text2 == _003CModule_003E.驎騞騠騢驒騱騞騡騞驐騢騠驤驓驓()))
			{
				break;
			}
			if (flag)
			{
				ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.ﯘ_FBB4ﮪ_FBCAﯔﮢﮣﯖﮣ_FBC4ﯛ_FBBAﯗﮪﯓ(obj, obj2).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			}
			else
			{
				((ContentControl)_4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗).set_Content((object)"Both must be the same size to do this operation!");
			}
			return;
		case 1062367507u:
			if (!(text2 == _003CModule_003E.瓰瓢甏瓜瓛瓝瓛瓛瓛瓯瓚甌瓣甋甌()))
			{
				break;
			}
			if (flag)
			{
				ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1._F2C8_F2BA_F2B9_F2CB_F2A1_F290_F290_F2C1_F28F_F2B9_F2C3_F28F_F28D_F290_F2A4(obj, obj2).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			}
			else
			{
				((ContentControl)_4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗).set_Content((object)"First Matrix's collumns number must be equal to\rsecond Matrix's rows number!");
			}
			return;
		case 4185424761u:
			if (!(text2 == _003CModule_003E.툠퉊툡툜툡툜퉍퉍툡퉢퉍퉊툯툠툙()))
			{
				break;
			}
			try
			{
				ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.ᐨᑚᑢᑈᑝᑂᑀᑛᐮᑜᑛᑛᑀᐰᐫ(double.Parse(镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢.get_Text()), obj2, _003CModule_003E.队陕阠陓阧阠阨阧阹陓阧陕陧阦队()).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
				return;
			}
			catch
			{
				ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text("Invalid scalar value!");
				return;
			}
		case 1661157472u:
			if (!(text2 == _003CModule_003E.댤덐덍댶댻댢댬댠덂덄덢덌덒덞댤()))
			{
				break;
			}
			ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.맓맗맮맘먈맘맛맔먇맛맰먅맗매맛(obj).ToString());
			return;
		case 3378387235u:
			if (!(text2 == _003CModule_003E.吝呎吗呋呞吟吠呉呡吟吸呍呓吘呁()))
			{
				break;
			}
			ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.躣蹴躣蹴躣躅躓蹲蹸躧蹹躬躧躍躬(obj).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			return;
		case 1924786016u:
			if (!(text2 == _003CModule_003E.䉻䊭䊬䊭䊱䊀䊱䉿䉻䋀䋄䊯䊬䊑䊬()))
			{
				break;
			}
			ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ.set_Text(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.籧粕籤籽籧粄籪籬籸粘粛籧粥粮籧(镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢.get_Text()).ᕮᕓᕏᕎᕒᕬᕋᕵᖀᖀᕌᕐᕋᖀᖀ().䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
			return;
		}
		Console.WriteLine("Exception @ matrixOperation!");
	}

	public void ﷃ_FDDAﷃﷀﷱﷶﷁﷅﷅ_FDE2ﷶ_FDD5ﷱﷷ_FDC8()
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
			List<TextBlock> list = ((IEnumerable)((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children()).OfType<TextBlock>().ToList();
			foreach (TextBlock item in list)
			{
				((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Remove((UIElement)(object)item);
			}
			for (int i = 0; i < ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Count(); i++)
			{
				UIElement obj = ((Panel)ﰪﰳﰫﰰﱳﰲﱯﱠﱛﱜﱀﱜﱜﰭﱞ).get_Children().get_Item(i);
				UIElement obj2 = ((obj is TextBox) ? obj : null);
				Point val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				((TextBox)obj2).set_Text((((Point)(ref val)).get_X() - 125.0).ToString());
				UIElement obj3 = ((Panel)㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉).get_Children().get_Item(i);
				UIElement obj4 = ((obj3 is TextBox) ? obj3 : null);
				val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				((TextBox)obj4).set_Text((((Point)(ref val)).get_Y() - 125.0).ToString());
				val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				double x = ((Point)(ref val)).get_X();
				val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				double y = ((Point)(ref val)).get_Y();
				string[] obj5 = new string[5] { "(", null, null, null, null };
				val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				obj5[1] = (((Point)(ref val)).get_X() - 125.0).ToString();
				obj5[2] = _003CModule_003E._086F_086Fࡏ_086D_083F_086E_0874_086F_0882_086B_083Cࡁ_083E_083F_0839();
				val = ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ.get_Item(i);
				obj5[3] = (((Point)(ref val)).get_Y() - 125.0).ToString();
				obj5[4] = ")";
				ᣵᢶᢲᢴᢳᣄᢶᣪᢸᢵᣤᢶᣌᣊᣧ(x, y, string.Concat(obj5), Colors.get_Red());
			}
		}
		catch
		{
		}
	}

	private void 户戅戲戙戆戃扁戮戲扅戀戮戯戯戀(object _2889_2887_28B8_288B_2899_28B5_28B5_28A6_2885_2884_28BD_2885_288C_2887_28B6, RoutedEventArgs _A6E6_A6EEꛇꛥꛞꛛꛏꚴꚵꚼꛓ_A6E8ꚴꛥꚺ)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.set_Text(Regex.Replace(殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.get_Text(), "[^0-9,]+", _003CModule_003E.猻猊猢猵猈猆猋猈猌猈猖猅猶獇猸(), RegexOptions.Compiled));
		殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.set_Text((string.IsNullOrEmpty(殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.get_Text()) || string.IsNullOrWhiteSpace(殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.get_Text())) ? _003CModule_003E.굯굑굳굄굢굑굆궇괽굸군굢굁굄굅() : 殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.get_Text());
		try
		{
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Clear();
			軝軌躕軈軜躚躗躛躕躘躔軅躛躨車(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ = _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.묣묲묲묳묆묧뭇뫿뭂묂묳묇묄묂묲(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.䛽䜱䛾䜶䜺䜅䜃䜄䜯䜂䜳䜮䜆䛽䜿(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.졅졺졮졯졭조졭젿조졭졥조졶족졃(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ, -125.0, -125.0), double.Parse(殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿.get_Text())), 125.0, 125.0);
			val.set_Points(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ);
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
			ﷃ_FDDAﷃﷀﷱﷶﷁﷅﷅ_FDE2ﷶ_FDD5ﷱﷷ_FDC8();
		}
		catch
		{
		}
	}

	private void 쏣쏌쏀쎶쏥쎷쎶쎵쎲쏨쎶쏀쎳쏣쎶(object 㼌㼌㼏㼏㼐㼣㼏㼋㼐㼾㼊㼾㼺㼹㼹, RoutedEventArgs 畆畊畨畃畳畋畂畿畸畂畴畫畵畉畔)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.set_Text(Regex.Replace(䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.get_Text(), "[^0-9,-]+", _003CModule_003E.퍸퍧퍋퍆퍌퍹퍴퍬퍷퍝퍊퍊퍝펅퍆(), RegexOptions.Compiled));
		䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.set_Text((string.IsNullOrEmpty(䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.get_Text()) || string.IsNullOrWhiteSpace(䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.get_Text())) ? _003CModule_003E._1DCE_1DCC_1DC8Ḅḋ_1DCA_1DCF_1DC8_1DCB_1DCF_1DFB_1DCF_1DFAḋ_1DFC() : 䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.get_Text());
		죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.set_Text(Regex.Replace(죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.get_Text(), "[^0-9,-]+", _003CModule_003E.㡉㢆㡅㡅㡵㡙㡹㡪㢁㡋㢋㡖㡶㡠㢋(), RegexOptions.Compiled));
		죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.set_Text((string.IsNullOrEmpty(죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.get_Text()) || string.IsNullOrWhiteSpace(죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.get_Text())) ? _003CModule_003E.橺橆橋橇橇橡橍橊橸橬橫橸橹橌橻() : 죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.get_Text());
		try
		{
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Clear();
			軝軌躕軈軜躚躗躛躕躘躔軅躛躨車(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ = _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.묣묲묲묳묆묧뭇뫿뭂묂묳묇묄묂묲(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.곪곪괨곫괘괩곪곫곬괙곤곤곤곤괕(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.졅졺졮졯졭조졭젿조졭졥조졶족졃(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ, 0.0, 0.0), double.Parse(䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂.get_Text()), double.Parse(죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐.get_Text())), 0.0, 0.0);
			val.set_Points(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ);
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
			ﷃ_FDDAﷃﷀﷱﷶﷁﷅﷅ_FDE2ﷶ_FDD5ﷱﷷ_FDC8();
		}
		catch
		{
		}
	}

	private void ゾヮゾセズゾレペ_3102ロワゾヸヰソ(object _FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD, RoutedEventArgs ߔߓ_07BC_07EBߞߪߧ_07BC_07F6_07B8_07BD_07BD_07FF_07BAߧ)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.set_Text(Regex.Replace(퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.get_Text(), "[^0-9,]+", _003CModule_003E._E282_E254_E290_E274_E28D_E28B_E28D_E252_E284_E254_E27E_E27E_E26D_E27E_E280(), RegexOptions.Compiled));
		퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.set_Text((string.IsNullOrEmpty(퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.get_Text()) || string.IsNullOrWhiteSpace(퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.get_Text())) ? _003CModule_003E.湘溗湯湐湏湖湓湏満湕溁溊湔湘溁() : 퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.get_Text());
		鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.set_Text(Regex.Replace(鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.get_Text(), "[^0-9,]+", _003CModule_003E._20FA_2129_20F8ℳ_20F7ℭℸ_2100_20FD_20FAℷ_20FF_20FDℷℴ(), RegexOptions.Compiled));
		鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.set_Text((string.IsNullOrEmpty(鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.get_Text()) || string.IsNullOrWhiteSpace(鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.get_Text())) ? _003CModule_003E.ⵘⵓⵖⵓⶕⵕⵚⶌⵒⵚⶒⶃⶆ_2D72ⵗ() : 鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.get_Text());
		try
		{
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Clear();
			軝軌躕軈軜躚躗躛躕躘躔軅躛躨車(25, "#555555");
			Polygon val = new Polygon();
			((Shape)val).set_Fill((Brush)new SolidColorBrush(Colors.get_DarkOrchid()));
			ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ = _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.묣묲묲묳묆묧뭇뫿뭂묂묳묇묄묂묲(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1._᪁_1AAD᪁_1A7B_1AAC᪃᪃᪃_1AB8_1AB0_1AAC_1AAD_1A7E᪀_1A7E(_EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1.졅졺졮졯졭조졭젿조졭졥조졶족졃(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ, -125.0, -125.0), double.Parse(퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥.get_Text()), double.Parse(鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖.get_Text())), 125.0, 125.0);
			val.set_Points(ꤘꥂꤒꤡꤣꤖꥅꤓ_A92Aꤗꤔꤕꥅꤔꥂ);
			((Panel)_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649._FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).get_Children().Add((UIElement)(object)val);
			ﷃ_FDDAﷃﷀﷱﷶﷁﷅﷅ_FDE2ﷶ_FDD5ﷱﷷ_FDC8();
		}
		catch
		{
		}
	}

	private void 걛겏걗겝겆건걓겉걸게걜걚걛걖겇(object 畻疑疃疂疯疱疭疑疮疃疬疯疱疭疡, MouseButtonEventArgs 쩫쩧쪝쩧쪚쩫쪅쪜쩭쪁쪘쩽쩫쪚쩩)
	{
		_2816_2815_2853_284D_2811_2813_2844_2843_2815_282E_2816_282B_283F_2810_2832();
	}

	public void 䤘䥈䤙䤜䤜䥕䥆䥞䤝䤘䥏䤖䤙䥈䥅(ref TextBox 馐饙馅饖饚馄饺饓饴饚饽饙饛饖馅, ref TextBox _27C4_27CB_27B3_27BB_27B3_27E6_27F7_27C8_27CC_27C9_27E7_27B2_27CE_27E3_27B9, ref TextBox _228E_2288_228E_228D_22D0_22BA_228F_22A9_2290_228F_22B9_22BE_22C9_229F_22BA, ref TextBox ꏮꐞꐯꏮꐆꐈꐂꏭꐟꐳꏲꏵꏶꐮꐢ, int ռ_058B_05A2_05AD_05AE_05BE_05BAռս_05AAչ_05B9_0593_05AFպ)
	{
		try
		{
			if (int.Parse(馐饙馅饖饚馄饺饓饴饚饽饙饛饖馅.get_Text()) <= 10 && int.Parse(_27C4_27CB_27B3_27BB_27B3_27E6_27F7_27C8_27CC_27C9_27E7_27B2_27CE_27E3_27B9.get_Text()) <= 10)
			{
				ꏮꐞꐯꏮꐆꐈꐂꏭꐟꐳꏲꏵꏶꐮꐢ.set_Text(new _EAD4_EABD_EAA7_EAA7_EAA3_EAA8_EABC_EAB4_EADE_EAD5_EAD6_EAA8_EABB_EAE5_EAC1(int.Parse(馐饙馅饖饚馄饺饓饴饚饽饙饛饖馅.get_Text()), int.Parse(_27C4_27CB_27B3_27BB_27B3_27E6_27F7_27C8_27CC_27C9_27E7_27B2_27CE_27E3_27B9.get_Text()), _228E_2288_228E_228D_22D0_22BA_228F_22A9_2290_228F_22B9_22BE_22C9_229F_22BA.get_Text()).䭲䭓䭔䭙䮚䮄䮇䮈䭻䭰䮃䭳䭙䮄䭕());
				switch (ռ_058B_05A2_05AD_05AE_05BE_05BAռս_05AAչ_05B9_0593_05AFպ)
				{
				case 1:
					((ContentControl)돞돼됎됁돔돽돿됋됀돍돒돿돍돒돽).set_Content((object)_003CModule_003E.鵶鶒鶤鵷鶡鵱鵳鶖鶎鶍鶥鶳鶢鵵鵰());
					break;
				case 2:
					((ContentControl)ⶉⶸⶈⷃ_2DB7_2D9Dⶵⶇⶊⶇⶋⶸⶵ_2DB7_2DB7).set_Content((object)_003CModule_003E.䴶䴦䵆䴨䴶䴫䵍䴫䴧䴥䵖䵬䵕䵚䴪());
					break;
				}
			}
			else
			{
				switch (ռ_058B_05A2_05AD_05AE_05BE_05BAռս_05AAչ_05B9_0593_05AFպ)
				{
				case 1:
					((ContentControl)돞돼됎됁돔돽돿됋됀돍돒돿돍돒돽).set_Content((object)_003CModule_003E.녓녧넪녗녓넧넨녕넶녖넳녂넾넸넩());
					break;
				case 2:
					((ContentControl)ⶉⶸⶈⷃ_2DB7_2D9Dⶵⶇⶊⶇⶋⶸⶵ_2DB7_2DB7).set_Content((object)_003CModule_003E.ᝃ_1778_1776ច_177Bឋᝅ_1774_1773ᝂ_1774ᝊᝉ_1776ᝆ());
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void 詄詃詠詤詃詇詳詄詳訿詵詂詵詆詇(object ᏟᏜᏏᏐᎲᎪᏡᏏᏬᏮᎭᎫᏱᏯᎽ, RoutedEventArgs _2A58_2A22_2A16_2A1A_2A11_2A34_2A43_2A15_2A4D_2A25_2A47_2A54_2A43_2A1A_2A55)
	{
		䤘䥈䤙䤜䤜䥕䥆䥞䤝䤘䥏䤖䤙䥈䥅(ref 叠叨厳厬叝叞叞叢厬参叒厲厳厴厬, ref ǧȘȕȟȁȗǥȍȕǬȂǫǤȘȘ, ref ጮጂዾጮጅጅዾዽጆጁጿጄጅጅጀ, ref 镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢, 1);
	}

	private void _A499ꑰꑔꒉꑪꑜꑗ_A48Eꑹꑓꑗꒉꒅ_A48Eꒅ(object 䲮䲪䳡䳟䳨䲲䳟䳠䳍䳠䳤䲱䲱䲪䳟, RoutedEventArgs ǉǷǈǝǍǎǥǸȄǻǋǯǈȀȄ)
	{
		䤘䥈䤙䤜䤜䥕䥆䥞䤝䤘䥏䤖䤙䥈䥅(ref 鞮音鞴韞鞵鞲韞鞰韩鞴鞶鞲韤韦韞, ref _F241_F281_F273_F26F_F261_F275_F23E_F25A_F256_F23E_F240_F26F_F243_F257_F23B, ref 倫降律﨔倫倫行律輻凞祥溺率行行, ref 熇熎熗熈熍熤熉熷熻熷燃熉熎熏熆, 2);
	}

	private void 쭨쭣쮐쮓쮢쭡쭦쭠쮑쭲쭥쭦쭧쮝쭟(object 㣞㣉㣤㣼㤁㣏㣈㣢㣍㣏㣼㣏㣼㣼㣈, MouseButtonEventArgs ŰŪŲŶłŢĹŬņĴţĳŗĹĲ)
	{
		((Window)this).DragMove();
	}

	private void 爩牒爨牗物爨牗牕爩爨爼牠牕牖爥(object 봾봂봰봄봣봄봞봿봭볻봄봄봃봃봚, RoutedEventArgs 놚놑녣놄녩놣녨놑놖녨녦녨녢놝놖)
	{
		((Window)this).Close();
	}

	private void _ED42_ED7B_ED4E_ED3E_ED66_ED3F_ED45_ED78_ED44_ED43_ED6E_ED42_ED83_ED3E_ED55(object _EEB1_EEDD_EEDE_EEEE_EEDE_EEB0_EEB0_EED3_EECD_EEA9_EEDD_EEAF_EEDD_EEAE_EEA9, RoutedEventArgs 䣳䤀䣵䤞䤢䤞䤨䤠䤢䣱䣲䤱䣬䤪䤞)
	{
		((Window)this).set_WindowState((WindowState)1);
	}

	private void 뙏똾똦똕뙅뙃똔똕똟똕뙓똔뙃똓뙖(object 鑉鑩鑣鑃鑲鑵鑳鑶鑞鑶鑝鑉鑷钆鑳, RoutedEventArgs 뇌놯뇪놵뇡뇠뇍뇝뇠놲뇁놲뇌뇣뇟)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		捽捾掘捬据探捭捯掛掃掛掎捪掚捦();
	}

	private void அ_0B49_0B7Eஈ_0B4F_0B50_0B49_0B4A_0B7B_0B7A_0B8D_0B79_0B48_0B62_0B64(object 㖽㖑㖑㖊㗑㖽㖐㖿㖎㖉㖎㖌㖍㖎㖍, RoutedEventArgs 㛨㛣㛳㚷㛥㚷㛍㛥㛣㛠㛖㛘㛠㚲㛨)
	{
		_2816_2815_2853_284D_2811_2813_2844_2843_2815_282E_2816_282B_283F_2810_2832();
	}

	private void _23C6_23DD_2397_23CB_23CA_239A_23AC_239D_23BB_2399_23CD_239B_23C7_23C7_23DE(object 殩毑殧殨殩毒毠毕毒殠毒殨殠殦殦, RoutedEventArgs _26A5_26C1_2694_2694_268F_26CD_26B1_26C0_26BD_268C_268F_268C_26C3_26A3_2692)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if (聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶)
		{
			덣뎌덜덣뎛덢뎅뎐덟뎍뎐뎖덜뎁덜.set_ImageSource((ImageSource)new BitmapImage(new Uri(_003CModule_003E.읪읖일읦윷윶읏읛읋읦윷윷읨윽윺(), UriKind.Relative)));
			聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶 = !聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶;
		}
		else
		{
			덣뎌덜덣뎛덢뎅뎐덟뎍뎐뎖덜뎁덜.set_ImageSource((ImageSource)new BitmapImage(new Uri(_003CModule_003E.푦퐷푪퐼푛푦푪푏푔퐴푥퐸푈퐻푪(), UriKind.Relative)));
			聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶 = !聦聁聕聇聁聂聈聻聈聢聪聉聶聈聶;
		}
	}

	private void 潆潇漕漤潔漓潓漓漕漕漕漭潄漘潄(object 란랓랇랅랱랳랂랄랱랅띿띿랆랝랴, RoutedEventArgs 竈窆窇窹窽窈窇窸窇窺窆窷窶窄窉)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if (琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓)
		{
			_0CD0೪_0CC9_0CFB_0CD0_0CCB_0CE5_0CC9_0CD0_0CFD_0CD1೫_0CFC_0CC9_0CC9.set_ImageSource((ImageSource)new BitmapImage(new Uri(_003CModule_003E.뮶믪믵뮲뮶믠믇믪믑믠믠뮮믕뮴뮶(), UriKind.Relative)));
			琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓 = !琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓;
		}
		else
		{
			_0CD0೪_0CC9_0CFB_0CD0_0CCB_0CE5_0CC9_0CD0_0CFD_0CD1೫_0CFC_0CC9_0CC9.set_ImageSource((ImageSource)new BitmapImage(new Uri(_003CModule_003E.啎啁啁唥唔啈唔啁唕唐啁唎唔啌唍(), UriKind.Relative)));
			琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓 = !琣琣瑓琤琦琪瑔琣瑖琩琣瑦瑓琢瑓;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void ﻚﻒﻚ_FF07_FF06ﻬ_FF08３ﻑﻖﻖ_FF0Dﻗ_FF03ﻑ()
	{
		if (!窓窒窙竃窒窖窙窵窘竅窙竅窔窘竅)
		{
			窓窒窙竃窒窖窙窵窘竅窙竅窔窘竅 = true;
			Uri uri = new Uri(_003CModule_003E.ꁍꁐꁮꁭꁍꁌꁒꂂꁾꁢꁻꂂꁭꁿꁊ(), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void 囕嚦嚤団嚠嚨因嚢囜嚧囑嚡嚡嚧囔(int 㧗㧟㦣㧒㦪㦤㦻㦪㧄㦢㦢㧝㦺㧗㦾, object _0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A)
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
		switch (㧗㧟㦣㧒㦪㦤㦻㦪㧄㦢㦢㧝㦺㧗㦾)
		{
		case 1:
			((UIElement)(_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseLeftButtonDown(new MouseButtonEventHandler(뙏똾똦똕뙅뙃똔똕똟똕뙓똔뙃똓뙖));
			((UIElement)(_264B_264E_266F_2678_2690_264B_266E_264E_266A_2678_264C_264C_264E_267B_2649)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseRightButtonDown(new MouseButtonEventHandler(அ_0B49_0B7Eஈ_0B4F_0B50_0B49_0B4A_0B7B_0B7A_0B8D_0B79_0B48_0B62_0B64));
			break;
		case 2:
			蜪蜨蜪蝄蜛蜖蜓蜖蝆蝄蜦蜲蜓蜛蜳 = (Grid)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 3:
			((UIElement)(Rectangle)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseLeftButtonDown(new MouseButtonEventHandler(쭨쭣쮐쮓쮢쭡쭦쭠쮑쭲쭥쭦쭧쮝쭟));
			break;
		case 4:
			_29AB_2977_297E_2997_2998_297A_2977_297C_29B9_29AD_29A8_297B_29AA_297B_297C = (Canvas)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((UIElement)_29AB_2977_297E_2997_2998_297A_2977_297C_29B9_29AD_29A8_297B_29AA_297B_297C).add_MouseRightButtonDown(new MouseButtonEventHandler(걛겏걗겝겆건걓겉걸게걜걚걛걖겇));
			break;
		case 5:
			((UIElement)(Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseLeftButtonDown(new MouseButtonEventHandler(쭨쭣쮐쮓쮢쭡쭦쭠쮑쭲쭥쭦쭧쮝쭟));
			break;
		case 6:
			((ButtonBase)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_Click(new RoutedEventHandler(爩牒爨牗物爨牗牕爩爨爼牠牕牖爥));
			((UIElement)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseEnter(new MouseEventHandler(_23C6_23DD_2397_23CB_23CA_239A_23AC_239D_23BB_2399_23CD_239B_23C7_23C7_23DE));
			((UIElement)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseLeave(new MouseEventHandler(_23C6_23DD_2397_23CB_23CA_239A_23AC_239D_23BB_2399_23CD_239B_23C7_23C7_23DE));
			break;
		case 7:
			덣뎌덜덣뎛덢뎅뎐덟뎍뎐뎖덜뎁덜 = (ImageBrush)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 8:
			((ButtonBase)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_Click(new RoutedEventHandler(_ED42_ED7B_ED4E_ED3E_ED66_ED3F_ED45_ED78_ED44_ED43_ED6E_ED42_ED83_ED3E_ED55));
			((UIElement)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseEnter(new MouseEventHandler(潆潇漕漤潔漓潓漓漕漕漕漭潄漘潄));
			((UIElement)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_MouseLeave(new MouseEventHandler(潆潇漕漤潔漓潓漓漕漕漕漭潄漘潄));
			break;
		case 9:
			_0CD0೪_0CC9_0CFB_0CD0_0CCB_0CE5_0CC9_0CD0_0CFD_0CD1೫_0CFC_0CC9_0CC9 = (ImageBrush)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 10:
			턈턇탘턖턈턉턒턜탕탗턄턅턇탪탛 = (ComboBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 11:
			䪓䪲䪽䪌䪣䪐䪑䫀䪔䫇䫀䪎䫐䪐䪦 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 12:
			廗廈廎廆廼廆廌廻廇廆廆廜廌建廻 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 13:
			鐩鐟鐖鐜鐠鏥鐙鐚鏪鏭鏥鏪鏹鐚鏭 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 14:
			䎀䍌䎏䍎䍌䍋䍎䍹䍌䍹䍬䍍䍌䎆䍻 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 15:
			_E384_E385_E389_E383_E384_E382_E389_E3B5_E380_E39C_E386_E3B2_E3B1_E392_E3B6 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 16:
			䖰䖪䗛䗛䖱䗣䗓䖳䖭䗜䖰䗠䗠䖬䗜 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 17:
			볩볧볥볺벶볖볔벼벶볨벶벻본벵벷 = (ComboBoxItem)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 18:
			镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((TextBoxBase)镣锱镤锱锴锸镄锳锳锳锷镦锳镥镢).add_TextChanged(new TextChangedEventHandler(凍凁冾冑冈冊冎冾凂冱冐凉冹冊冽));
			break;
		case 19:
			ŭŖŵśŘƋœŖŜƈŤŔœŘŨ = (Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 20:
			熇熎熗熈熍熤熉熷熻熷燃熉熎熏熆 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((TextBoxBase)熇熎熗熈熍熤熉熷熻熷燃熉熎熏熆).add_TextChanged(new TextChangedEventHandler(凍凁冾冑冈冊冎冾凂冱冐凉冹冊冽));
			break;
		case 21:
			诓诌论诰详诩讵诙诅诇讼讹讹诨讵 = (Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 22:
			((ButtonBase)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_Click(new RoutedEventHandler(헄햗햒햘햸햙햔햙햺햙햑헃햲헅햗));
			break;
		case 23:
			ƦżƩŽŵŻŵƜŶƼƌŹƚŷƊ = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 24:
			_3200ㇾ_322Cㇸ_3218_3200ㇽ_3228_3228_320Dㇾㇼㇸㇿㇻ = (StackPanel)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 25:
			ﰪﰳﰫﰰﱳﰲﱯﱠﱛﱜﱀﱜﱜﰭﱞ = (StackPanel)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 26:
			㫿㬘㫺㬭㬡㬩㫾㫾㬨㫻㫾㬹㫹㬩㬉 = (StackPanel)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 27:
			_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD = (Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((ButtonBase)_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD_FFFD).add_Click(new RoutedEventHandler(户戅戲戙戆戃扁戮戲扅戀戮戯戯戀));
			break;
		case 28:
			ﹼ_FE51_FE5C_FE50_FE4Cﹿ_FE4Bﹽﹽ_FE6E_FE53_FE4E_FE6A_FE53_FE4F = (Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((ButtonBase)ﹼ_FE51_FE5C_FE50_FE4Cﹿ_FE4Bﹽﹽ_FE6E_FE53_FE4E_FE6A_FE53_FE4F).add_Click(new RoutedEventHandler(쏣쏌쏀쎶쏥쎷쎶쎵쎲쏨쎶쏀쎳쏣쎶));
			break;
		case 29:
			ᨲᨯ_1A69ᨳ_1A5C_1A5Bᨬᨾᨲᨭᨱᨱᨯ_1A5Eᨳ = (Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			((ButtonBase)ᨲᨯ_1A69ᨳ_1A5C_1A5Bᨬᨾᨲᨭᨱᨱᨯ_1A5Eᨳ).add_Click(new RoutedEventHandler(ゾヮゾセズゾレペ_3102ロワゾヸヰソ));
			break;
		case 30:
			殌殿殐殓毋殽毐殏殿殎殑殝殏毒殿 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 31:
			䦅䥗䥖䦗䦄䥑䥒䥘䥗䥷䥑䥘䥦䥑䦂 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 32:
			죯죆죆좿죆죲죴죐죯죆좿죆죯죯죐 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 33:
			퀎퀗쿹쿴쿱쿴쿸쿮퀒퀎퀠퀑쿞퀎퀥 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 34:
			鉗銁銂鉑銍鉖銁鉙鉓鉵銘銊鉓鉑鉖 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 35:
			ጮጂዾጮጅጅዾዽጆጁጿጄጅጅጀ = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 36:
			倫降律﨔倫倫行律輻凞祥溺率行行 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 37:
			ǧȘȕȟȁȗǥȍȕǬȂǫǤȘȘ = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 38:
			叠叨厳厬叝叞叞叢厬参叒厲厳厴厬 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 39:
			((ButtonBase)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_Click(new RoutedEventHandler(詄詃詠詤詃詇詳詄詳訿詵詂詵詆詇));
			break;
		case 40:
			_F241_F281_F273_F26F_F261_F275_F23E_F25A_F256_F23E_F240_F26F_F243_F257_F23B = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 41:
			鞮音鞴韞鞵鞲韞鞰韩鞴鞶鞲韤韦韞 = (TextBox)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 42:
			((ButtonBase)(Button)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A).add_Click(new RoutedEventHandler(_A499ꑰꑔꒉꑪꑜꑗ_A48Eꑹꑓꑗꒉꒅ_A48Eꒅ));
			break;
		case 43:
			돞돼됎됁돔돽돿됋됀돍돒돿돍돒돽 = (Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 44:
			ⶉⶸⶈⷃ_2DB7_2D9Dⶵⶇⶊⶇⶋⶸⶵ_2DB7_2DB7 = (Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		case 45:
			_4DE1_4DE3_4DDB_4DF7_4DE4_4DED_4DDF_4DDC东_4DDC专_4DF1丏_4DF6丗 = (Label)_0EF1_0F1D_0F32_0F11ༀ_0F1E_0EF0༠_0F1F_0EE9༠_0F07_0F12_0EF1_0F1A;
			break;
		default:
			窓窒窙竃窒窖窙窵窘竅窙竅窔窘竅 = true;
			break;
		}
	}
}
