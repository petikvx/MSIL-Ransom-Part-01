using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class PortFolioWindow : Window, IComponentConnector
{
	private bool _contentLoaded;

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("lvPortfolios")]
	internal virtual ListView lvPortfolios
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gridDashboard"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual Grid gridDashboard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("lvHoldings")]
	internal virtual ListView lvHoldings
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public PortFolioWindow()
	{
		((FrameworkElement)this).set_DataContext((object)new PortfoliosViewModel());
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/portfolios.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			lvPortfolios = (ListView)target;
			break;
		case 2:
			gridDashboard = (Grid)target;
			break;
		case 3:
			lvHoldings = (ListView)target;
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
