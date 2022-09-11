using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace Secure.Messenger.WpfHost;

public class MainWindow : Window, IComponentConnector
{
	private bool _contentLoaded;

	public MainWindow()
	{
		new Secure1(new object[3]
		{
			OPk.St,
			OPk.Vr,
			"Secure.Messenger.WpfHost"
		});
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri_ = MainWindow.smethod_0("/VYGnq;component/mainwindow.xaml", UriKind.Relative);
			MainWindow.smethod_1((object)this, uri_);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		_contentLoaded = true;
	}

	static Uri smethod_0(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_1(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}
}
