using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;
using Microsoft.VisualBasic.ApplicationServices;

namespace LivePortfolio;

public class Application : Application
{
	private bool _contentLoaded;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal AssemblyInfo Info
	{
		[DebuggerHidden]
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			return new AssemblyInfo(Assembly.GetExecutingAssembly());
		}
	}

	public Application()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), (PropertyMetadata)new FrameworkPropertyMetadata((object)XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			((Application)this).set_StartupUri(new Uri("View\\Bartleby.xaml", UriKind.Relative));
			Uri uri = new Uri("/LivePortfolio;component/application.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[STAThread]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static void Main()
	{
		Application application = new Application();
		application.InitializeComponent();
		((Application)application).Run();
	}
}
