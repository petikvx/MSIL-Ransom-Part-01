using System;
using System.IO;
using System.Reflection;
using Jurassic;
using Yahoo.Yui.Compressor;

namespace HandlebarsHelper;

public class HandlebarsCompiler
{
	private ScriptEngine Engine;

	private JavaScriptCompressor Compressor;

	public HandlebarsCompiler()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		Engine = new ScriptEngine();
		Assembly assembly = typeof(HandlebarsCompiler).Assembly;
		Engine.Execute("var exports = {};");
		Engine.Execute("var module = {};");
		Engine.Execute(GetEmbeddedResource("HandlebarsHelper.Scripts.handlebars-v2.0.0.js", assembly));
		Engine.Execute(GetEmbeddedResource("HandlebarsHelper.Scripts.ember-template-compiler.js", assembly));
		Engine.Execute("var precompile = exports.precompile;");
		Compressor = new JavaScriptCompressor();
	}

	public string Precompile(string template, bool compress)
	{
		ScriptEngine engine = Engine;
		object[] array = new object[Convert.ToInt32(1.0 + Math.Abs(1.0))];
		array[0] = template;
		array[1] = false;
		string text = engine.CallGlobalFunction<string>("precompile", array);
		if (compress)
		{
			text = ((Compressor)Compressor).Compress(text);
		}
		return text;
	}

	public string GetEmbeddedResource(string resource, Assembly ass)
	{
		using StreamReader streamReader = new StreamReader(ass.GetManifestResourceStream(resource));
		return streamReader.ReadToEnd();
	}
}
