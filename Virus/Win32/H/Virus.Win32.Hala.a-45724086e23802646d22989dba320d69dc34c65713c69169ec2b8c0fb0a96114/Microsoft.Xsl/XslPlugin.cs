using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using Microsoft.XmlEditor;

namespace Microsoft.Xsl;

public class XslPlugin : MarshalByRefObject, IXslPlugin, IDisposable
{
	internal XslCompiledTransform cmd;

	internal MySafeResolver xslResolver;

	internal MySafeResolver xmlResolver;

	internal IMarshallableResolver mres;

	public IMarshallableResolver XslResolver
	{
		get
		{
			return mres;
		}
		set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			mres = value;
			xslResolver = new MySafeResolver(mres);
		}
	}

	public IMarshallableResolver XmlResolver
	{
		get
		{
			return mres;
		}
		set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			mres = value;
			xmlResolver = new MySafeResolver(mres);
		}
	}

	public void Dispose()
	{
		cmd = null;
		xslResolver = null;
		xmlResolver = null;
		mres = null;
	}

	public virtual void Compile(string xsl, bool enableDebugging, out string encoding, out XmlOutputMethod method, out List<string> tmpFiles)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		XslCompiler val = new XslCompiler(mres);
		cmd = val.Compile(xsl, (XmlResolver)(object)xslResolver, enableDebugging, ref tmpFiles);
		XmlWriterSettings outputSettings = cmd.OutputSettings;
		encoding = ((outputSettings.Encoding != null) ? outputSettings.Encoding.WebName : "");
		method = outputSettings.OutputMethod;
	}

	public virtual XsltArgumentList GetArguments()
	{
		return null;
	}

	public virtual XmlWriter CreateWriter(Stream output, XmlWriterSettings settings)
	{
		return XmlWriter.Create(output, settings);
	}

	public virtual void Execute(string xml, Stream output)
	{
		if (cmd == null)
		{
			throw new InvalidOperationException();
		}
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.IgnoreWhitespace = false;
		xmlReaderSettings.XmlResolver = (XmlResolver?)(object)xmlResolver;
		xmlReaderSettings.ProhibitDtd = false;
		using XmlReader input = XmlReader.Create(xml, xmlReaderSettings);
		using XmlWriter results = CreateWriter(output, cmd.OutputSettings);
		cmd.Transform(input, GetArguments(), results, (XmlResolver?)(object)xslResolver);
	}
}
