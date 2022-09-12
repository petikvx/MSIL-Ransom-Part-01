using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class DividendsWindow : Window, IComponentConnector
{
	private bool _contentLoaded;

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

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("NewDividend")]
	internal virtual MenuItem NewDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EditDividend"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual MenuItem EditDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RemoveDividend"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual MenuItem RemoveDividend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("Monthly")]
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

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("Cumulative")]
	internal virtual Chart Cumulative
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public DividendsWindow()
	{
		((FrameworkElement)this).set_DataContext((object)new DividendViewModel());
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/dividends.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			lvDividends = (ListView)target;
			break;
		case 2:
			mnuDividends = (ContextMenu)target;
			break;
		case 3:
			NewDividend = (MenuItem)target;
			break;
		case 4:
			EditDividend = (MenuItem)target;
			break;
		case 5:
			RemoveDividend = (MenuItem)target;
			break;
		case 6:
			Monthly = (Chart)target;
			break;
		case 7:
			LastYearsRevenue = (Chart)target;
			break;
		case 8:
			Cumulative = (Chart)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
