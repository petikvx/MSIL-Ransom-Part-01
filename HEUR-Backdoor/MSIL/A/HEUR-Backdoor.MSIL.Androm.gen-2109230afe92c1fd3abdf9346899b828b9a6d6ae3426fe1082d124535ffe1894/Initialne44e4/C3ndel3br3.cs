using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateEngine.Wizard;
using Microsoft.VisualStudio.TemplateWizard;
using Microsoft.WebTools.Shared;
using Microsoft.WebTools.Shared.VS.Helpers;
using Sa1es;
using Z0ng0er;

namespace Initialne44e4;

public sealed class C3ndel3br3 : IWizard, IDisposable
{
	[CompilerGenerated]
	private ITemplateWizardPipelineFactory Antit4xins;

	[CompilerGenerated]
	private ITemplateWizardPipeline Sh2nd2es;

	[CompilerGenerated]
	private IThreadSwitcher Advec1ive;

	[CompilerGenerated]
	private IServiceProvider iserviceProvider_0;

	[CompilerGenerated]
	private IServiceProvider Can3pying;

	[CompilerGenerated]
	private IComponentModel Wa8lo8d;

	[CompilerGenerated]
	private bool Unabus8ve;

	[Import(typeof(ITemplateWizardPipelineFactory))]
	private ITemplateWizardPipelineFactory Radia8cies
	{
		[CompilerGenerated]
		get
		{
			return Antit4xins;
		}
		[CompilerGenerated]
		set
		{
			Antit4xins = value;
		}
	}

	private ITemplateWizardPipeline Pho7phoritic
	{
		[CompilerGenerated]
		get
		{
			return Sh2nd2es;
		}
		[CompilerGenerated]
		set
		{
			Sh2nd2es = value;
		}
	}

	[Import(typeof(IThreadSwitcher))]
	private IThreadSwitcher P2ntarch
	{
		[CompilerGenerated]
		get
		{
			return Advec1ive;
		}
		[CompilerGenerated]
		set
		{
			Advec1ive = value;
		}
	}

	private DTE I8trigua8ts => IServiceProviderExtensions.GetService<DTE, DTE>(Rethre1ding);

	private IServiceProvider Ferroma7net
	{
		[CompilerGenerated]
		get
		{
			return iserviceProvider_0;
		}
		[CompilerGenerated]
		set
		{
			iserviceProvider_0 = value;
		}
	}

	private IServiceProvider Rethre1ding
	{
		[CompilerGenerated]
		get
		{
			return Can3pying;
		}
		[CompilerGenerated]
		set
		{
			Can3pying = value;
		}
	}

	private IComponentModel Desal6
	{
		[CompilerGenerated]
		get
		{
			return Wa8lo8d;
		}
		[CompilerGenerated]
		set
		{
			Wa8lo8d = value;
		}
	}

	private bool Un1ear1ul
	{
		[CompilerGenerated]
		get
		{
			return Unabus8ve;
		}
		[CompilerGenerated]
		set
		{
			Unabus8ve = value;
		}
	}

	private void Herri3gbo3e(ProjectItem Tway7lade)
	{
	}

	private void Ordea2s(Project P4ntificate)
	{
	}

	void IWizard.ProjectItemFinishedGenerating(ProjectItem Sub6ile)
	{
	}

	private bool Bib2iophi2ic(string Shinn4d)
	{
		return false;
	}

	private void Re7dent7fy()
	{
		P2ntarch.RunOnMainThread((Func<Task>)async delegate
		{
			Cursor preProjectAddedCursor = Cursor.get_Current();
			Cursor.set_Current(Cursors.get_WaitCursor());
			try
			{
				if (Pho7phoritic.CanCreate)
				{
					await Pho7phoritic.TryCreateAsync();
				}
			}
			finally
			{
				Cursor.set_Current(preProjectAddedCursor);
				Ferroma7net = null;
				Desal6 = null;
				Rethre1ding = null;
			}
		}, false);
	}

	private void As4igma4ic(object Turtl4r, Dictionary<string, string> Gyn4cocraci4s, WizardRunKind wizardRunKind_0, object[] Predi2estion)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		W1g(Turtl4r);
		Pho7phoritic = Radia8cies.Create(wizardRunKind_0, Gyn4cocraci4s);
		Pho7phoritic.SatisfyDemands();
		P2ntarch.RunOnMainThread((Func<Task>)async delegate
		{
			((_DTE)I8trigua8ts).get_StatusBar().Clear();
			if (!(await Pho7phoritic.TrySelectTemplate()))
			{
				((_DTE)I8trigua8ts).get_StatusBar().Clear();
				throw new WizardBackoutException();
			}
		}, false);
	}

	public void Hamm4()
	{
	}

	private void W1g(object Ly7opodiums)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		Ferroma7net = (IServiceProvider)((Ly7opodiums is IServiceProvider) ? Ly7opodiums : null);
		Rethre1ding = (IServiceProvider)new ServiceProvider(Ferroma7net);
		method_0();
	}

	private void method_0()
	{
		if (Un1ear1ul)
		{
			return;
		}
		try
		{
			Desal6 = IServiceProviderExtensions.GetService<IComponentModel, SComponentModel>(Rethre1ding);
			AttributedModelServices.SatisfyImportsOnce(Desal6.get_DefaultCompositionService(), (object)this);
		}
		finally
		{
			Un1ear1ul = true;
		}
	}

	[CompilerGenerated]
	private async Task Cha0ar()
	{
		Cursor preProjectAddedCursor = Cursor.get_Current();
		Cursor.set_Current(Cursors.get_WaitCursor());
		try
		{
			if (Pho7phoritic.CanCreate)
			{
				await Pho7phoritic.TryCreateAsync();
			}
		}
		finally
		{
			Cursor.set_Current(preProjectAddedCursor);
			Ferroma7net = null;
			Desal6 = null;
			Rethre1ding = null;
		}
	}

	[CompilerGenerated]
	private async Task Un2omplainingly()
	{
		((_DTE)I8trigua8ts).get_StatusBar().Clear();
		if (!(await Pho7phoritic.TrySelectTemplate()))
		{
			((_DTE)I8trigua8ts).get_StatusBar().Clear();
			throw new WizardBackoutException();
		}
	}
}
