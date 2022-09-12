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
public class PropertiesDialog : Window, IComponentConnector
{
	private PropertiesViewModel MyViewModel;

	private bool _contentLoaded;

	[field: AccessedThroughProperty("gridAssets"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual DataGrid gridAssets
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public PropertiesDialog(Portfolio P)
	{
		PropertiesViewModel dataContext = new PropertiesViewModel(P);
		InitializeComponent();
		((FrameworkElement)this).set_DataContext((object)dataContext);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/properties.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (connectionId == 1)
		{
			gridAssets = (DataGrid)target;
		}
		else
		{
			_contentLoaded = true;
		}
	}
}
