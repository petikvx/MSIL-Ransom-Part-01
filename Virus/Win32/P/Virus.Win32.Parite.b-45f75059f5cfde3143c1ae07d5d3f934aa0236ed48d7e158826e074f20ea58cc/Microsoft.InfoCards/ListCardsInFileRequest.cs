using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ListCardsInFileRequest : UIAgentRequest
{
	private InfoCardPolicy m_policy;

	private RoamingStoreFile m_roamingFile;

	private string m_filename;

	private string m_passphrase;

	public ListCardsInFileRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		m_roamingFile = new RoamingStoreFile();
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
		m_policy = GetPolicy();
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_filename = Utility.DeserializeString(reader);
		m_passphrase = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		Cleanup(clearPwd: false, clearRoamingFile: true);
		try
		{
			try
			{
				using FileStream stream = new FileStream(m_filename, FileMode.Open, FileAccess.Read, FileShare.Read);
				XmlReaderSettings xmlReaderSettings = InfoCardSchemas.CreateDefaultReaderSettings();
				xmlReaderSettings.IgnoreWhitespace = false;
				using XmlReader reader = InfoCardSchemas.CreateReader((Stream)stream, xmlReaderSettings);
				m_roamingFile.ReadFrom(m_passphrase, reader);
				base.ParentRequest.SetContext(m_roamingFile);
			}
			catch (ImportException)
			{
				throw;
			}
			catch (CryptographicException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PasswordValidationException(SR.GetString("InvalidImportFile"), inner));
			}
			catch (XmlSchemaValidationException inner2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("SchemaValidationFailed"), inner2));
			}
			catch (UnauthorizedAccessException inner3)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("ImportInaccesibleFile"), inner3));
			}
			catch (IOException inner4)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner4));
			}
			catch (XmlException inner5)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner5));
			}
		}
		catch (ImportException ex2)
		{
			Cleanup(clearPwd: false, clearRoamingFile: true);
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportStoreException(((Exception)(object)ex2).Message));
		}
		finally
		{
			Cleanup(clearPwd: true, clearRoamingFile: false);
		}
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		BinaryWriter binaryWriter = new BinaryWriter(outArgs);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			if (m_roamingFile != null && m_roamingFile.Cards.Count != 0)
			{
				try
				{
					binaryWriter.Write(m_roamingFile.Cards.Count);
					for (int i = 0; i < m_roamingFile.Cards.Count; i++)
					{
						binaryWriter.Flush();
						m_roamingFile.Cards[i].AgentSerialize(outArgs, base.ParentRequest is GetTokenRequest, m_policy, connection, new CultureInfo(base.ParentRequest.UserLanguage));
					}
					return;
				}
				catch (Exception ex)
				{
					Cleanup(clearPwd: true, clearRoamingFile: true);
					if (InfoCardTrace.IsFatal(ex))
					{
						throw;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportStoreException(SR.GetString("InvalidImportFile"), ex));
				}
			}
			binaryWriter.Write(0);
		}
		finally
		{
			connection.Close();
		}
	}

	private void Cleanup(bool clearPwd, bool clearRoamingFile)
	{
		if (clearRoamingFile)
		{
			if (m_roamingFile != null)
			{
				m_roamingFile.Clear();
			}
			if (base.ParentRequest != null)
			{
				base.ParentRequest.ClearContext<RoamingStoreFile>();
			}
		}
		if (clearPwd)
		{
			m_passphrase = null;
		}
	}
}
