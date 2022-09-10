using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class CheckStoreFileValidityRequest : UIAgentRequest
{
	private string m_filename;

	private bool m_valid = true;

	public CheckStoreFileValidityRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_filename = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		try
		{
			try
			{
				using FileStream stream = File.OpenRead(m_filename);
				XmlReaderSettings xmlReaderSettings = InfoCardSchemas.CreateDefaultReaderSettings();
				xmlReaderSettings.IgnoreWhitespace = false;
				using XmlReader xmlReader = InfoCardSchemas.CreateReader((Stream)stream, xmlReaderSettings);
				if (!xmlReader.IsStartElement("EncryptedStore", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					m_valid = false;
				}
			}
			catch (XmlSchemaValidationException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("SchemaValidationFailed"), inner));
			}
			catch (UnauthorizedAccessException inner2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("ImportInaccesibleFile"), inner2));
			}
			catch (IOException inner3)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner3));
			}
			catch (XmlException inner4)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner4));
			}
		}
		catch (ImportException)
		{
			m_valid = false;
		}
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter binaryWriter = new BinaryWriter(outArgs);
		binaryWriter.Write(m_valid);
	}
}
