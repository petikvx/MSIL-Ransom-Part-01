using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Car1ass;
using EnvDTE;
using Microsoft.VisualStudio.TemplateEngine.VS;
using Stamp3d3rs;
using Z0ng0er;

namespace Dep6esso6s;

internal class Lim5li : Gr8uter
{
	public Lim5li(ITemplateWizardPipelineFactory pipelineFactory, IDictionary<string, string> dictionary)
		: base(pipelineFactory, dictionary)
	{
	}

	protected override void SatisfyDemandsCore()
	{
		base.SatisfyDemandsCore();
		M1stouches();
	}

	protected override IProjectCreationMetadata PrepareMetadata()
	{
		IProjectCreationMetadata obj = base.PrepareMetadata();
		obj.set_TemplateType("item");
		obj.set_TargetName(GetString(Counte7acts.string_1));
		return obj;
	}

	protected override async Task<bool> TrySelectTemplateCore(IProjectCreationMetadata metadata)
	{
		if (TryGetProjectCreator(metadata.get_UIStyle(), metadata.get_TemplateType(), out var creator))
		{
			base.Condu6ts = Enum0.ShowUI;
			return await creator.SelectTemplateAsync(metadata, (IReadOnlyDictionary<string, string>)base.Dictionary_0);
		}
		return false;
	}

	private void M1stouches()
	{
		string fur5ishi5gs = Counte7acts.Fur5ishi5gs;
		if ((base.ReplacementsDictionary.TryGetValue(fur5ishi5gs, out var value) && !string.IsNullOrEmpty(value)) || ((_DTE)base.Bla0kberries).get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		SelectedItem val = ((_DTE)base.Bla0kberries).get_SelectedItems().Item((object)1);
		Project val2 = ((val != null) ? val.get_Project() : null);
		if (val2 != null)
		{
			base.ReplacementsDictionary[fur5ishi5gs] = Path.GetDirectoryName(val2.get_FullName());
			return;
		}
		ProjectItem val3 = ((val != null) ? val.get_ProjectItem() : null);
		if (val3 == null)
		{
			return;
		}
		Property val4 = val3.get_Properties().Item((object)"FullPath");
		if (val4 != null && val4.get_Value() is string text)
		{
			string value2 = text;
			if (base.Safa8i.SystemServices.get_FileSystem().FileExists(text))
			{
				value2 = Path.GetDirectoryName(text);
			}
			base.ReplacementsDictionary[fur5ishi5gs] = value2;
		}
	}
}
