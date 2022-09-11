namespace HandlebarsHelper;

public interface ITemplateNamer
{
	string GenerateName(string bundleRelativePath, string fileName);
}
