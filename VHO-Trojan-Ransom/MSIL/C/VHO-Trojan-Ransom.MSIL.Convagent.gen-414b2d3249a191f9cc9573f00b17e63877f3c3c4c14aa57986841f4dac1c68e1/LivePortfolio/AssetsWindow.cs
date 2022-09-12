using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class AssetsWindow : Window, IComponentConnector
{
	private bool _contentLoaded;

	public AssetsWindow()
	{
		((FrameworkElement)this).set_DataContext((object)new AssetViewModel());
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/assetswindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		_contentLoaded = true;
	}
}
