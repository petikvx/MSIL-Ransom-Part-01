using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class RefreshDataDialogue : Window, IComponentConnector
{
	private bool _contentLoaded;

	public RefreshDataDialogue()
	{
		((Window)this).add_Closed((EventHandler)Closing);
		((FrameworkElement)this).set_DataContext((object)new PriceDialogueViewModel());
		InitializeComponent();
	}

	public void Onloaded()
	{
		NewLateBinding.LateCall(((FrameworkElement)this).get_DataContext(), (Type)null, "refreshprices", new object[0], (string[])null, (Type[])null, (bool[])null, true);
	}

	public void Closing(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(NewLateBinding.LateGet(((FrameworkElement)this).get_DataContext(), (Type)null, "IsBusy", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			Interaction.MsgBox((object)"Cannot Close at this time", (MsgBoxStyle)0, (object)null);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/refreshdatadialogue.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		if (connectionId == 1)
		{
			((FrameworkElement)(RefreshDataDialogue)target).add_Loaded((RoutedEventHandler)delegate
			{
				Onloaded();
			});
		}
		else
		{
			_contentLoaded = true;
		}
	}
}
