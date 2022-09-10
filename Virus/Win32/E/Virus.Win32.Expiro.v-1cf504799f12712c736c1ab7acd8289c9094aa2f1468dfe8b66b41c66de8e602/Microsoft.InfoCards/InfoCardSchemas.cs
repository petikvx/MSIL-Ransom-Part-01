using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardSchemas
{
	private class LocalCachingResolver : XmlUrlResolver
	{
		private Dictionary<Uri, XmlSchema> m_table;

		public LocalCachingResolver()
		{
			m_table = new Dictionary<Uri, XmlSchema>();
		}

		public void AddLocalSchema(Uri location, XmlSchema schema)
		{
			m_table.Add(location, schema);
		}

		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return base.ResolveUri(baseUri, relativeUri);
		}

		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			return m_table[absoluteUri];
		}
	}

	private class SchemaLocationResourceMapping
	{
		private string m_resourceName;

		private string m_schemaLocation;

		public string ResourceName => m_resourceName;

		public string SchemaLocation => m_schemaLocation;

		public SchemaLocationResourceMapping(string resourceName, string schemaLocation)
		{
			m_resourceName = resourceName;
			m_schemaLocation = schemaLocation;
		}
	}

	private static readonly string[] s_primarySchemas = new string[2] { "identity.xsd", "ws-identity-2007.xsd" };

	private static readonly SchemaLocationResourceMapping[] s_supportingSchemas = new SchemaLocationResourceMapping[13]
	{
		new SchemaLocationResourceMapping("addressing.xsd", "http://www.w3.org/2005/08/addressing/addressing.xsd"),
		new SchemaLocationResourceMapping("addressing04.xsd", "http://schemas.xmlsoap.org/ws/2004/08/addressing/"),
		new SchemaLocationResourceMapping("xmldsig-core-schema.xsd", "http://www.w3.org/TR/xmldsig-core/xmldsig-core-schema.xsd"),
		new SchemaLocationResourceMapping("xml.xsd", "http://www.w3.org/2001/xml.xsd"),
		new SchemaLocationResourceMapping("xenc-schema.xsd", "http://www.w3.org/TR/xmlenc-core/xenc-schema.xsd"),
		new SchemaLocationResourceMapping("oasis-200401-wss-wssecurity-secext-1.0.xsd", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"),
		new SchemaLocationResourceMapping("oasis-200401-wss-wssecurity-utility-1.0.xsd", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"),
		new SchemaLocationResourceMapping(XmlNames.WSPolicyXmlSoap2004.Instance.LocalSchemaLocation, XmlNames.WSPolicyXmlSoap2004.Instance.SchemaLocation),
		new SchemaLocationResourceMapping(XmlNames.WSPolicyW32007.Instance.LocalSchemaLocation, XmlNames.WSPolicyW32007.Instance.SchemaLocation),
		new SchemaLocationResourceMapping(XmlNames.WSSecurityPolicyXmlSoap2005.Instance.LocalSchemaLocation, XmlNames.WSSecurityPolicyXmlSoap2005.Instance.SchemaLocation),
		new SchemaLocationResourceMapping(XmlNames.WSSecurityPolicyOasis2007.Instance.LocalSchemaLocation, XmlNames.WSSecurityPolicyOasis2007.Instance.SchemaLocation),
		new SchemaLocationResourceMapping(XmlNames.WSTrustXmlSoap2005.Instance.LocalSchemaLocation, XmlNames.WSTrustXmlSoap2005.Instance.SchemaLocation),
		new SchemaLocationResourceMapping(XmlNames.WSTrustOasis2007.Instance.LocalSchemaLocation, XmlNames.WSTrustOasis2007.Instance.SchemaLocation)
	};

	private static InfoCardSchemas s_current = new InfoCardSchemas(Assembly.GetExecutingAssembly());

	private LocalCachingResolver m_resolver;

	private Assembly m_assembly;

	private XmlSchemaSet m_schemas;

	private object m_sync;

	private InfoCardSchemas(Assembly sourceAssembly)
	{
		m_sync = new object();
		m_resolver = new LocalCachingResolver();
		m_assembly = sourceAssembly;
	}

	public static XmlSchemaSet GetSchemaSet()
	{
		if (s_current.m_schemas == null)
		{
			lock (s_current.m_sync)
			{
				if (s_current.m_schemas == null)
				{
					s_current.InitializeSchemas();
				}
			}
		}
		return s_current.m_schemas;
	}

	public static XmlReader CreateReader(string fragment)
	{
		return CreateReader(Utility.CreateReaderWithQuotas(fragment));
	}

	public static XmlReader CreateReader(Stream stream, XmlReaderSettings settings)
	{
		return CreateReader(Utility.CreateReaderWithQuotas(stream), settings);
	}

	public static XmlReader CreateReader(XmlDictionaryReader reader, XmlReaderSettings settings)
	{
		return XmlReader.Create((XmlReader)(object)reader, settings);
	}

	public static XmlReader CreateReader(XmlDictionaryReader reader)
	{
		XmlReaderSettings settings = CreateDefaultReaderSettings();
		return XmlReader.Create((XmlReader)(object)reader, settings);
	}

	public static XmlReaderSettings CreateDefaultReaderSettings()
	{
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.CloseInput = false;
		xmlReaderSettings.ValidationType = ValidationType.Schema;
		xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings;
		xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
		xmlReaderSettings.Schemas = GetSchemaSet();
		xmlReaderSettings.ValidationEventHandler += ErrorHandler;
		xmlReaderSettings.XmlResolver = s_current.m_resolver;
		xmlReaderSettings.IgnoreComments = true;
		xmlReaderSettings.IgnoreWhitespace = true;
		xmlReaderSettings.IgnoreProcessingInstructions = true;
		return xmlReaderSettings;
	}

	private void InitializeSchemas()
	{
		XmlSchema xmlSchema = null;
		XmlSchemaSet xmlSchemaSet = null;
		LocalCachingResolver localCachingResolver = null;
		Stream stream = null;
		Uri uri = null;
		localCachingResolver = new LocalCachingResolver();
		for (int i = 0; i < s_supportingSchemas.Length; i++)
		{
			uri = new Uri(s_supportingSchemas[i].SchemaLocation);
			stream = m_assembly.GetManifestResourceStream(s_supportingSchemas[i].ResourceName);
			xmlSchema = XmlSchema.Read(stream, ErrorHandler);
			localCachingResolver.AddLocalSchema(uri, xmlSchema);
		}
		xmlSchemaSet = new XmlSchemaSet();
		xmlSchemaSet.XmlResolver = localCachingResolver;
		for (int j = 0; j < s_primarySchemas.Length; j++)
		{
			stream = m_assembly.GetManifestResourceStream(s_primarySchemas[j]);
			xmlSchema = XmlSchema.Read(stream, ErrorHandler);
			xmlSchemaSet.Add(xmlSchema);
		}
		xmlSchemaSet.ValidationEventHandler += ErrorHandler;
		xmlSchemaSet.Compile();
		m_resolver = localCachingResolver;
		m_schemas = xmlSchemaSet;
	}

	private static void ErrorHandler(object sender, ValidationEventArgs e)
	{
		if (e.Severity == XmlSeverityType.Error)
		{
			throw InfoCardTrace.ThrowHelperCritical((Exception)new XmlSchemaValidationException(SR.GetString("SchemaValidationError", new object[1] { e.Exception.Message }), e.Exception));
		}
	}
}
