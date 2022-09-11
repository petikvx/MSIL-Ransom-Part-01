using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;
using Yahoo.Yui.Compressor;

namespace HandlebarsHelper;

public class HandlebarsTransformer : IBundleTransform
{
	private ITemplateNamer namer;

	public HandlebarsTransformer()
	{
		namer = new TemplateNamer();
	}

	public HandlebarsTransformer(ITemplateNamer templateNamer)
	{
		namer = templateNamer;
	}

	public void Process(BundleContext context, BundleResponse response)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		HandlebarsCompiler handlebarsCompiler = new HandlebarsCompiler();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		HttpServerUtilityBase server = context.get_HttpContext().get_Server();
		foreach (BundleFile file in response.get_Files())
		{
			string text = server.MapPath(((VirtualFileBase)file.get_VirtualFile()).get_VirtualPath());
			string relativePath = GetRelativePath(server, file, text);
			string key = namer.GenerateName(relativePath, ((VirtualFileBase)file.get_VirtualFile()).get_Name());
			string template = File.ReadAllText(text);
			string text3 = (dictionary[key] = handlebarsCompiler.Precompile(template, compress: false));
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string key2 in dictionary.Keys)
		{
			stringBuilder.AppendFormat("Ember.TEMPLATES['{0}']=", key2);
			stringBuilder.AppendFormat("Ember.Handlebars.template({0});", dictionary[key2]);
		}
		JavaScriptCompressor val = new JavaScriptCompressor();
		string content = ((Compressor)val).Compress(stringBuilder.ToString());
		response.set_ContentType("text/javascript");
		response.set_Cacheability((HttpCacheability)Convert.ToInt32(4.693147180559945 - Math.Log(2.0)));
		response.set_Content(content);
	}

	private string GetRelativePath(HttpServerUtilityBase server, BundleFile bundleFile, string filePath)
	{
		string text = bundleFile.get_IncludedVirtualPath().Remove(bundleFile.get_IncludedVirtualPath().IndexOf("\\"));
		string directory = server.MapPath(text);
		return FileToolkit.PathDifference(filePath, directory);
	}
}
