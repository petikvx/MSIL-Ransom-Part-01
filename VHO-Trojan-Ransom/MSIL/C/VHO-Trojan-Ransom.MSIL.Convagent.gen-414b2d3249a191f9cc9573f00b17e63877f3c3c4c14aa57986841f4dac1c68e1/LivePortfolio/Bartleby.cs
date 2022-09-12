using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class Bartleby : Window, IComponentConnector
{
	private bool _contentLoaded;

	internal virtual ListView lvPortfolios
	{
		[CompilerGenerated]
		get
		{
			return _lvPortfolios;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			SelectionChangedEventHandler val = new SelectionChangedEventHandler(lvPortfolios_SelectionChanged);
			ListView val2 = _lvPortfolios;
			if (val2 != null)
			{
				((Selector)val2).remove_SelectionChanged(val);
			}
			_lvPortfolios = value;
			val2 = _lvPortfolios;
			if (val2 != null)
			{
				((Selector)val2).add_SelectionChanged(val);
			}
		}
	}

	[field: AccessedThroughProperty("lvHoldings"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual ListView lvHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lvDividends"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual ListView lvDividends
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mnuDividends"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual ContextMenu mnuDividends
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NewDividend"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual MenuItem NewDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("EditDividend")]
	internal virtual MenuItem EditDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("RemoveDividend")]
	internal virtual MenuItem RemoveDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Monthly"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual Chart Monthly
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("LastYearsRevenue")]
	internal virtual Chart LastYearsRevenue
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Cumulative"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual Chart Cumulative
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Bartleby()
	{
		((FrameworkElement)this).set_DataContext((object)new MainViewModel());
		InitializeComponent();
	}

	private void ExitApp()
	{
		((Window)this).Close();
	}

	private void WIP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Under Construction!", (MsgBoxStyle)0, (object)null);
	}

	private void ShowDividends()
	{
		DividendsWindow dividendsWindow = new DividendsWindow();
		((Window)dividendsWindow).ShowDialog();
	}

	private void ShowSettings()
	{
		SettingsWindow settingsWindow = new SettingsWindow();
		((Window)settingsWindow).ShowDialog();
	}

	private void ShowPriceDialogue()
	{
		RefreshDataDialogue refreshDataDialogue = new RefreshDataDialogue();
		((Window)refreshDataDialogue).ShowDialog();
	}

	private void ShowImportMenu(object sender, RoutedEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		ContextMenu val = (ContextMenu)((FrameworkElement)this).FindResource((object)"ImportMenu");
		ContextMenu val2 = val;
		val2.set_PlacementTarget((UIElement)sender);
		val2.set_IsOpen(true);
		val2 = null;
	}

	private void lvPortfolios_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/bartleby.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			((MenuItem)target).add_Click((RoutedEventHandler)delegate
			{
				ShowPriceDialogue();
			});
			break;
		case 2:
			((ButtonBase)(Button)target).add_Click(new RoutedEventHandler(ShowImportMenu));
			break;
		case 3:
			((ButtonBase)(Button)target).add_Click((RoutedEventHandler)delegate
			{
				ShowSettings();
			});
			break;
		case 4:
			lvPortfolios = (ListView)target;
			break;
		case 5:
			lvHoldings = (ListView)target;
			break;
		case 6:
			((Selector)(ListView)target).add_SelectionChanged(new SelectionChangedEventHandler(ListView_SelectionChanged));
			break;
		case 7:
			lvDividends = (ListView)target;
			break;
		case 8:
			mnuDividends = (ContextMenu)target;
			break;
		case 9:
			NewDividend = (MenuItem)target;
			break;
		case 10:
			EditDividend = (MenuItem)target;
			break;
		case 11:
			RemoveDividend = (MenuItem)target;
			break;
		case 12:
			Monthly = (Chart)target;
			break;
		case 13:
			LastYearsRevenue = (Chart)target;
			break;
		case 14:
			Cumulative = (Chart)target;
			break;
		case 15:
			((Selector)(ComboBox)target).add_SelectionChanged(new SelectionChangedEventHandler(ComboBox_SelectionChanged));
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
