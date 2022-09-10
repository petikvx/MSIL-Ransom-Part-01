using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ExportFileRequest : UIAgentRequest
{
	private string m_filename;

	private string m_passphrase;

	private string[] m_cardIds;

	public ExportFileRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_filename = Utility.DeserializeString(binaryReader);
		m_passphrase = Utility.DeserializeString(binaryReader);
		uint num = binaryReader.ReadUInt32();
		m_cardIds = new string[num];
		for (uint num2 = 0u; num2 < num; num2++)
		{
			m_cardIds[num2] = Utility.DeserializeString(binaryReader);
		}
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(!string.IsNullOrEmpty(m_filename), "No file name was specified", new object[0]);
		InfoCardTrace.Assert(!string.IsNullOrEmpty(m_passphrase), " No passphrase specified for the file", new object[0]);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			RoamingStoreFile roamingStoreFile = new RoamingStoreFile();
			try
			{
				for (int i = 0; i < m_cardIds.Length; i++)
				{
					InfoCard infoCard = new InfoCard(new Uri(m_cardIds[i]));
					infoCard.Get(connection);
					infoCard.GetMasterKey(connection);
					roamingStoreFile.Cards.Add(infoCard);
				}
				using FileStream fileStream = new FileStream(m_filename, FileMode.Create);
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.CloseOutput = false;
				using (XmlWriter xmlWriter = XmlWriter.Create(fileStream, xmlWriterSettings))
				{
					roamingStoreFile.WriteTo(m_passphrase, xmlWriter);
					xmlWriter.Flush();
				}
				fileStream.Flush();
			}
			finally
			{
				foreach (InfoCard card in roamingStoreFile.Cards)
				{
					card.ClearSensitiveData();
				}
			}
			AuditLog.AuditStoreExport();
		}
		catch (XmlSchemaValidationException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("SchemaValidationFailed"), inner));
		}
		catch (XmlException inner2)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("InvalidImportFile"), inner2));
		}
		catch (UnauthorizedAccessException inner3)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("ImportInaccesibleFile"), inner3));
		}
		catch (IOException inner4)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("InvalidImportFile"), inner4));
		}
		catch (ArgumentException inner5)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("ImportInaccesibleFile"), inner5));
		}
		catch (SerializationIncompleteException ex)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ExportException(SR.GetString("FailedToSerializeObject", new object[1] { ex.ObjectType }), ex));
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
