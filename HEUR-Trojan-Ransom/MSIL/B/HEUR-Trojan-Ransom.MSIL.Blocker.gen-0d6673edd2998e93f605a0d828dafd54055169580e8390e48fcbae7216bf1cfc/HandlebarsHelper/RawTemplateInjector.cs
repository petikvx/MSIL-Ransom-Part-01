using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace HandlebarsHelper;

public static class RawTemplateInjector
{
	public static IHtmlString InjectRawTemplates(string templatePath, string[] templateExtensions)
	{
		return GenerateTemplates(templatePath, templateExtensions, new TemplateNamer());
	}

	public static IHtmlString InjectRawTemplates(string templatePath, string[] templateExtensions, ITemplateNamer templateNamer)
	{
		return GenerateTemplates(templatePath, templateExtensions, templateNamer);
	}

	private static IHtmlString GenerateTemplates(string templatePath, string[] templateExtensions, ITemplateNamer templateNamer)
	{
		templatePath = HttpContext.get_Current().get_Request().MapPath(templatePath);
		List<string> files = FindFiles(templatePath, templatePath, templateExtensions);
		return BuildTemplates(templatePath, files, templateNamer);
	}

	private static IHtmlString BuildTemplates(string templatePath, List<string> files, ITemplateNamer templateNamer)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string file in files)
		{
			string bundleRelativePath = FileToolkit.PathDifference(file, templatePath);
			string arg = templateNamer.GenerateName(bundleRelativePath, Path.GetFileName(file));
			stringBuilder.AppendFormat("<script type='text/x-handlebars' data-template-name='{0}'>\n", arg);
			stringBuilder.AppendLine(File.ReadAllText(file));
			stringBuilder.AppendLine("</script>");
		}
		return (IHtmlString)new HtmlString(stringBuilder.ToString());
	}

	private static List<string> FindFiles(string searchPath, string templatePath, string[] templateExtensions)
	{
		List<string> list = new List<string>();
		string[] directories = Directory.GetDirectories(searchPath);
		foreach (string searchPath2 in directories)
		{
			list.AddRange(FindFiles(searchPath2, templatePath, templateExtensions));
		}
		list.AddRange(templateExtensions.SelectMany((string extension) => Directory.GetFiles(searchPath, extension)));
		return list;
	}
}
