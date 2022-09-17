using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.View;

public class SelectGroupModalWindow : Window, IComponentConnector
{
	private readonly ComboBox _cbGroups;

	internal ComboBox CbGroups;

	private bool _contentLoaded;

	public string SelectedGroup { get; private set; }

	public int SelectedGroupIndex { get; private set; }

	public ICommand OkCommand { get; set; }

	public ICommand CancelCommand { get; set; }

	public SelectGroupModalWindow(IEnumerable<string> options)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitCommands();
		InitializeComponent();
		_cbGroups = (ComboBox)SelectGroupModalWindow.smethod_0((FrameworkElement)(object)this, "CbGroups");
		if (_cbGroups == null)
		{
			throw SelectGroupModalWindow.smethod_1("Error initializing window, CbGroups not found.");
		}
		SelectGroupModalWindow.smethod_2((ItemsControl)(object)_cbGroups, (IEnumerable)options);
	}

	public SelectGroupModalWindow()
		: this(new List<string> { "ExampleItem" })
	{
	}

	private void InitCommands()
	{
		OkCommand = new RelayCommand(() => true, delegate
		{
			SelectGroupModalWindow.smethod_5((Window)(object)this, (bool?)true);
			SelectedGroup = (string)SelectGroupModalWindow.smethod_6((Selector)(object)_cbGroups);
			SelectedGroupIndex = SelectGroupModalWindow.smethod_7((Selector)(object)_cbGroups);
			SelectGroupModalWindow.smethod_8((Window)(object)this);
		});
		CancelCommand = new RelayCommand(() => true, delegate
		{
			SelectGroupModalWindow.smethod_5((Window)(object)this, (bool?)false);
			SelectedGroup = null;
			SelectGroupModalWindow.smethod_8((Window)(object)this);
		});
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri_ = SelectGroupModalWindow.smethod_3("/Int32ArrayTypeI;component/view/selectgroupmodalwindow.xaml", UriKind.Relative);
			SelectGroupModalWindow.smethod_4((object)this, uri_);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (connectionId != 1)
		{
			_contentLoaded = true;
		}
		else
		{
			CbGroups = (ComboBox)target;
		}
	}

	static object smethod_0(FrameworkElement frameworkElement_0, string string_0)
	{
		return frameworkElement_0.FindName(string_0);
	}

	static Exception smethod_1(string string_0)
	{
		return new Exception(string_0);
	}

	static void smethod_2(ItemsControl itemsControl_0, IEnumerable ienumerable_0)
	{
		itemsControl_0.set_ItemsSource(ienumerable_0);
	}

	static Uri smethod_3(string string_0, UriKind uriKind_0)
	{
		return new Uri(string_0, uriKind_0);
	}

	static void smethod_4(object object_0, Uri uri_0)
	{
		Application.LoadComponent(object_0, uri_0);
	}

	static void smethod_5(Window window_0, bool? nullable_0)
	{
		window_0.set_DialogResult(nullable_0);
	}

	static object smethod_6(Selector selector_0)
	{
		return selector_0.get_SelectedItem();
	}

	static int smethod_7(Selector selector_0)
	{
		return selector_0.get_SelectedIndex();
	}

	static void smethod_8(Window window_0)
	{
		window_0.Close();
	}
}
