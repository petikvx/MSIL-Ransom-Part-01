using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bowd4erizing;
using EnvDTE;
using Fec1ndate;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Microsoft.WebTools.Shared.Diagnostics;
using Microsoft.WebTools.Shared.Telemetry;
using Microsoft.WebTools.Shared.VS.Helpers;
using Microsoft.WebTools.Shared.VS.VisualStudio;
using Microsoft.WebTools.Shared.VS.VisualStudio.Wrappers;
using Mini1ies;
using Quai7ter;
using Reimplantati3n;
using Sa1es;
using Stamp3d3rs;
using Z0ng0er;

namespace Car1ass;

internal abstract class Gr8uter : ITemplateWizardPipeline
{
	protected enum Enum0
	{
		Initialize = 0,
		InvokeWizard = 10,
		VerifyUniqueProjectName = 20,
		ImportCreator = 30,
		ShowUI = 50,
		PreCreate = 60,
		Create = 70,
		PostCreate = 80
	}

	[CompilerGenerated]
	private readonly List<IProjectCreationHandler> list_0 = new List<IProjectCreationHandler>();

	[CompilerGenerated]
	private ITemplateWizardPipelineFactory Bi7mapped;

	[CompilerGenerated]
	private Exception Lumini2t2;

	[CompilerGenerated]
	private string T3chnics;

	[CompilerGenerated]
	private Enum0 Quac5ed;

	[CompilerGenerated]
	private IProjectCreationMetadata iprojectCreationMetadata_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private readonly IDictionary<string, string> idictionary_0;

	[CompilerGenerated]
	private Dictionary<string, string> Gelati2ous2ess;

	private List<IProjectCreationHandler> Pr5nomina
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	protected ITemplateWizardPipelineFactory Safa8i
	{
		[CompilerGenerated]
		get
		{
			return Bi7mapped;
		}
		[CompilerGenerated]
		private set
		{
			Bi7mapped = value;
		}
	}

	protected ICommonSystemServices Po2ices => Safa8i.SystemServices;

	protected IActivityLog Eldes4 => Safa8i.ActivityLog;

	protected ITelemetryProvider Limpingl7 => Safa8i.TelemetryProvider;

	protected Exception Juri0ic
	{
		[CompilerGenerated]
		get
		{
			return Lumini2t2;
		}
		[CompilerGenerated]
		set
		{
			Lumini2t2 = value;
		}
	}

	protected string String_0
	{
		[CompilerGenerated]
		get
		{
			return T3chnics;
		}
		[CompilerGenerated]
		set
		{
			T3chnics = value;
		}
	}

	protected Enum0 Condu6ts
	{
		[CompilerGenerated]
		get
		{
			return Quac5ed;
		}
		[CompilerGenerated]
		set
		{
			Quac5ed = value;
		}
	}

	protected IProjectCreationMetadata IProjectCreationMetadata_0
	{
		[CompilerGenerated]
		get
		{
			return iprojectCreationMetadata_0;
		}
		[CompilerGenerated]
		private set
		{
			iprojectCreationMetadata_0 = value;
		}
	}

	protected DTE Bla0kberries => IServiceProviderExtensions.GetService<DTE, DTE>(Safa8i.ServiceProvider);

	protected Solution Chrom7ng => ((_DTE)Bla0kberries).get_Solution();

	protected string Malk6n
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public IDictionary<string, string> ReplacementsDictionary
	{
		[CompilerGenerated]
		get
		{
			return idictionary_0;
		}
	}

	public Dictionary<string, string> Dictionary_0
	{
		[CompilerGenerated]
		get
		{
			return Gelati2ous2ess;
		}
		[CompilerGenerated]
		private set
		{
			Gelati2ous2ess = value;
		}
	}

	public bool CanCreate
	{
		get
		{
			IProjectCreationMetadata iProjectCreationMetadata_ = IProjectCreationMetadata_0;
			if (iProjectCreationMetadata_ == null)
			{
				return false;
			}
			return iProjectCreationMetadata_.get_CanCreate();
		}
	}

	protected Gr8uter(ITemplateWizardPipelineFactory pipelineFactory, IDictionary<string, string> dictionary)
	{
		Safa8i = pipelineFactory;
		idictionary_0 = dictionary;
		Init();
	}

	public void N4nacti4ns()
	{
		SatisfyDemandsCore();
	}

	public async Task<bool> Maz3lik3()
	{
		Condu6ts = Enum0.InvokeWizard;
		IProjectCreationMetadata_0 = PrepareMetadata();
		bool num = await TrySelectTemplateCore(IProjectCreationMetadata_0);
		bool result = num;
		if (!num)
		{
			string @string = GetString(Counte7acts.Fur5ishi5gs);
			string string2 = GetString(Counte7acts.Coura8to);
			try
			{
				if (Po2ices.get_FileSystem().DirectoryExists(@string))
				{
					Po2ices.get_FileSystem().RemoveDirectory(@string, false);
				}
				if (Po2ices.get_FileSystem().DirectoryExists(string2))
				{
					Po2ices.get_FileSystem().RemoveDirectory(string2, false);
					return result;
				}
				return result;
			}
			catch (IOException)
			{
				return result;
			}
		}
		return result;
	}

	protected void Init()
	{
		Dictionary_0 = new Dictionary<string, string>();
		ReplacementsDictionary[Counte7acts.Chimbl1ys] = GetString(Counte7acts.Hoopli4e);
		ReplacementsDictionary[Counte7acts.Nak6dn6ss] = GetString(Counte7acts.C4eeseclot4s);
		foreach (KeyValuePair<string, string> item in ReplacementsDictionary)
		{
			string text = item.Key.Trim(new char[1] { '$' });
			if (text.StartsWith(Counte7acts.Tuto4ered, StringComparison.OrdinalIgnoreCase))
			{
				Dictionary_0[text.Substring(Counte7acts.Tuto4ered.Length)] = item.Value;
			}
			else if (text.Equals(Counte7acts.Misgiv3s, StringComparison.OrdinalIgnoreCase))
			{
				Malk6n = item.Value;
			}
		}
	}

	protected virtual void PostTelemetryEvent(ITelemetryModel model, bool success)
	{
		TelemetryProviderExtensions.Send(Limpingl7.San2tary(model, success));
	}

	protected virtual IProjectCreationMetadata PrepareMetadata()
	{
		string text = GetString(Counte7acts.Pop6laces);
		if (text.Equals(Counte7acts.string_2, StringComparison.OrdinalIgnoreCase))
		{
			text = Counte7acts.Ae2ile;
		}
		return (IProjectCreationMetadata)(object)new Class0
		{
			String_2 = text,
			F2zz2est = GetString(Counte7acts.Rub6, Counte7acts.Exp7nded),
			Mycopla4mal = "templateengine",
			M5therh55d = GetString(Counte7acts.Lucer4e),
			String_1 = GetString(Counte7acts.Mul6is6ory),
			B4n4lized = GetString(Counte7acts.Ov0rp0dal0d),
			She44cracker = GetString(Counte7acts.Fur5ishi5gs),
			U6wept = GetString(Counte7acts.string_0),
			Bi6ocu6ar = Malk6n,
			Dis1ect = ReplacementsDictionary
		};
	}

	protected bool TryGetProjectCreator(string uiStyle, string templateType, out IProjectCreator creator)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		Condu6ts = Enum0.ImportCreator;
		creator = (from e in Safa8i.Providers
			where e.Metadata.get_UIStyle().Equals(uiStyle, StringComparison.OrdinalIgnoreCase)
			where e.Metadata.get_TemplateTypes().Contains(templateType)
			select e.Value).FirstOrDefault();
		if (creator == null)
		{
			IProjectCreationMetadata_0.set_TelemetryErrorDetail(string.Format(CultureInfo.InvariantCulture, Strings.UnableToImportProjectCreator, uiStyle, templateType));
			VsShellWrapper.get_Instance().ShowMessageBox(string.Format(CultureInfo.CurrentCulture, Strings.UnableToImportProjectCreator, uiStyle, templateType), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		return creator != null;
	}

	protected string GetString(string key, string defaultValue = "")
	{
		if (!ReplacementsDictionary.TryGetValue(key, out var value))
		{
			return defaultValue;
		}
		return value;
	}

	protected (string type, string subType) GetHealthProjectType()
	{
		string item = "Core";
		string value = null;
		if (string.Equals(IProjectCreationMetadata_0.get_UIStyle(), "oneaspnet", StringComparison.OrdinalIgnoreCase))
		{
			item = "ASP.NET Core";
		}
		else if (string.Equals(IProjectCreationMetadata_0.get_UIStyle(), "functionProject", StringComparison.OrdinalIgnoreCase))
		{
			item = "FunctionApp";
			if (!IProjectCreationMetadata_0.get_WizardParameters().TryGetValue("FunctionsItemTemplate", out value))
			{
				value = null;
			}
		}
		return (item, value);
	}

	public async Task<bool> Ult2asec2et()
	{
		bool result = false;
		if (CanCreate)
		{
			try
			{
				await Hil6();
				Condu6ts = Enum0.Create;
				if (TryGetProjectCreator(IProjectCreationMetadata_0.get_UIStyle(), IProjectCreationMetadata_0.get_TemplateType(), out var creator))
				{
					result = await creator.CreateAsync(Chrom7ng, IProjectCreationMetadata_0, (IReadOnlyDictionary<string, string>)Dictionary_0);
					if (result && !Rive6er() && !string.IsNullOrEmpty(((_Solution)Chrom7ng).get_FileName()))
					{
						((_Solution)Chrom7ng).SaveAs(((_Solution)Chrom7ng).get_FileName());
					}
				}
				if (!result)
				{
					if (string.IsNullOrEmpty(String_0))
					{
						String_0 = IProjectCreationMetadata_0.get_TelemetryErrorDetail();
					}
				}
				else
				{
					await L7pread();
				}
			}
			catch (Exception ex)
			{
				Eldes4.TryLogException(ex, "TemplateEngineWizard");
				Juri0ic = ex;
				throw;
			}
			finally
			{
				Bewra1t model = new Bewra1t(IProjectCreationMetadata_0, Cic2li2s(IProjectCreationMetadata_0.get_TargetName()));
				PostTelemetryEvent(model, result);
			}
		}
		return result;
	}

	private async Task Hil6()
	{
		Condu6ts = Enum0.PreCreate;
		foreach (IProjectCreationHandler handler in Safa8i.CreationHandlers)
		{
			if (await handler.BeforeCreate(IProjectCreationMetadata_0))
			{
				Pr5nomina.Add(handler);
			}
		}
	}

	private async Task L7pread()
	{
		Condu6ts = Enum0.PostCreate;
		IVsHierarchy hier = null;
		try
		{
			hier = Cic2li2s(IProjectCreationMetadata_0.get_TargetName());
			if (hier == null)
			{
				return;
			}
			IVsHierarchyExtensions.StartBatchOperation(hier);
			foreach (IProjectCreationHandler item in Pr5nomina)
			{
				try
				{
					await item.OnCreate(hier, IProjectCreationMetadata_0);
				}
				catch (Exception ex)
				{
					Exception ex3 = (Juri0ic = ex);
					Eldes4.TryLogException(ex3, "TemplateWizardPipelineBase - PostCreationHandler");
				}
			}
		}
		finally
		{
			IVsHierarchy obj = hier;
			if (obj != null)
			{
				IVsHierarchyExtensions.EndBatchOperation(obj);
			}
		}
	}

	private bool Rive6er()
	{
		return string.Equals(GetString(Counte7acts.F7hns), "True", StringComparison.OrdinalIgnoreCase);
	}

	private IVsHierarchy Cic2li2s(string S7bantarctic)
	{
		IVsProjectWrapper projectByName = Safa8i.WrappersFactory.GetVsSolutionWrapper().GetProjectByName(S7bantarctic);
		if (projectByName == null)
		{
			return null;
		}
		return projectByName.get_ProjectHierarchy();
	}

	protected abstract Task<bool> TrySelectTemplateCore(IProjectCreationMetadata metadata);

	protected virtual void SatisfyDemandsCore()
	{
	}
}
