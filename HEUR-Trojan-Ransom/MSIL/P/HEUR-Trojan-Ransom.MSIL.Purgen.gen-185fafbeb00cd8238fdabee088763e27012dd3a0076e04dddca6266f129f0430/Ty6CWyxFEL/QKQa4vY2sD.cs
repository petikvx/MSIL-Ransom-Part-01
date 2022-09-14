using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace Ty6CWyxFEL;

public class QKQa4vY2sD : Window, IComponentConnector
{
	private Regex jtT5cTCblN;

	private static RegexOptions wyBf3co1gz = RegexOptions.Singleline;

	private bool dhaUmchKBx = true;

	internal Label _8RbfE5eSfa;

	internal Button VQtamLlr91;

	internal Button Swn6hF9Tmy;

	internal Button cnvgG2aWSI;

	internal Button knoDlmPnzl;

	internal Label k2LSE5DpNP;

	internal TextBox Eef2umn9o9;

	internal Button zU4SC19max;

	internal Label CPDAv8NT2Z;

	internal RichTextBox hFYT2Eho2K;

	private bool EK6TGtHUMa;

	public QKQa4vY2sD()
	{
		MFxI51zbd9();
		jtT5cTCblN = new Regex(Eef2umn9o9.get_Text(), wyBf3co1gz);
		G6P1fIa2U6();
	}

	private void FiHoEM8fJu(object bCdaFLQ1LY, MouseButtonEventArgs d3bWDK4Rsg)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (d3bWDK4Rsg.get_ButtonState() == ((MouseEventArgs)d3bWDK4Rsg).get_LeftButton())
		{
			((Window)this).DragMove();
		}
	}

	private void zt32iiPUhJ(object ji9NMfpcJR, RoutedEventArgs dAdJly4O2R)
	{
		((Window)this).Close();
	}

	private void NcryiQjDpC(object W9msP3PnIx, RoutedEventArgs L4CcHelKqf)
	{
		((Window)this).set_WindowState((WindowState)1);
	}

	private void LjIQB6FM3n(object _6tZKechh64, KeyEventArgs VbgKQSm67d)
	{
		if (dhaUmchKBx)
		{
			G6P1fIa2U6();
		}
	}

	private void G6P1fIa2U6()
	{
		((DispatcherObject)this).get_Dispatcher().Invoke((DispatcherPriority)9, (Delegate)(ThreadStart)delegate
		{
			s8k7E3iomR();
		});
	}

	private void s8k7E3iomR()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		TextRange val = new TextRange(hFYT2Eho2K.get_Document().get_ContentStart(), hFYT2Eho2K.get_Document().get_ContentEnd());
		val.ApplyPropertyValue(TextElement.ForegroundProperty, (object)Brushes.get_White());
		string input = "\n\n" + val.get_Text().Replace("\r\n", "\n\n");
		TextPointer val2 = hFYT2Eho2K.get_Document().get_ContentStart();
		int num = 0;
		foreach (Match item in Regex.Matches(input, jtT5cTCblN.ToString()))
		{
			if (item.Success)
			{
				TextPointer positionAtOffset = val2.GetPositionAtOffset(item.Index - num);
				TextPointer positionAtOffset2 = positionAtOffset.GetPositionAtOffset(item.Length);
				TextRange val3 = new TextRange(positionAtOffset.GetInsertionPosition((LogicalDirection)1), positionAtOffset2);
				val3.ApplyPropertyValue(TextElement.ForegroundProperty, (object)"#569CD6");
				val2 = positionAtOffset2;
				num = item.Index + item.Length - 2;
			}
		}
	}

	private void ZuviF8DsCu(object gfm6UdGZhT, RoutedEventArgs PHYRwwBKUs)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			jtT5cTCblN = new Regex(Eef2umn9o9.get_Text(), wyBf3co1gz);
		}
		catch (ArgumentException)
		{
			MessageBox.Show("Your regex has some problems.");
			dhaUmchKBx = false;
			return;
		}
		dhaUmchKBx = true;
		G6P1fIa2U6();
	}

	private void gk3ysvyKeF(object _5NDsRDqbV3, RoutedEventArgs NS8Q77vQqC)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("暂时只支持单行匹配，所以不要按回车键\n当然你按了我也阻止不了你不信你试试\nAutohr: LzxHahaha\nEmail: lzxglhf@live.com", "说明", (MessageBoxButton)0);
	}

	private void RWxImjAHMH(object XyWgm2aIyz, RoutedEventArgs TV7cRq71vy)
	{
		Process.Start("http://zh.wikipedia.org/wiki/%E6%AD%A3%E5%88%99%E8%A1%A8%E8%BE%BE%E5%BC%8F");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void MFxI51zbd9()
	{
		if (!EK6TGtHUMa)
		{
			EK6TGtHUMa = true;
			Uri uri = new Uri("/Ty6CWyxFEL;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void ykHT9HhPBL(int gYGKUvG3Su, object v7P3rqTSrg)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		switch (gYGKUvG3Su)
		{
		case 1:
			((UIElement)(QKQa4vY2sD)v7P3rqTSrg).add_MouseDown(new MouseButtonEventHandler(FiHoEM8fJu));
			break;
		case 2:
			_8RbfE5eSfa = (Label)v7P3rqTSrg;
			break;
		case 3:
			VQtamLlr91 = (Button)v7P3rqTSrg;
			((ButtonBase)VQtamLlr91).add_Click(new RoutedEventHandler(zt32iiPUhJ));
			break;
		case 4:
			Swn6hF9Tmy = (Button)v7P3rqTSrg;
			((ButtonBase)Swn6hF9Tmy).add_Click(new RoutedEventHandler(NcryiQjDpC));
			break;
		case 5:
			cnvgG2aWSI = (Button)v7P3rqTSrg;
			((ButtonBase)cnvgG2aWSI).add_Click(new RoutedEventHandler(RWxImjAHMH));
			break;
		case 6:
			knoDlmPnzl = (Button)v7P3rqTSrg;
			((ButtonBase)knoDlmPnzl).add_Click(new RoutedEventHandler(gk3ysvyKeF));
			break;
		case 7:
			k2LSE5DpNP = (Label)v7P3rqTSrg;
			break;
		case 8:
			Eef2umn9o9 = (TextBox)v7P3rqTSrg;
			break;
		case 9:
			zU4SC19max = (Button)v7P3rqTSrg;
			((ButtonBase)zU4SC19max).add_Click(new RoutedEventHandler(ZuviF8DsCu));
			break;
		case 10:
			CPDAv8NT2Z = (Label)v7P3rqTSrg;
			break;
		case 11:
			hFYT2Eho2K = (RichTextBox)v7P3rqTSrg;
			((UIElement)hFYT2Eho2K).add_KeyUp(new KeyEventHandler(LjIQB6FM3n));
			break;
		default:
			EK6TGtHUMa = true;
			break;
		}
	}

	[CompilerGenerated]
	private void k5pF0NhsEV()
	{
		s8k7E3iomR();
	}
}
