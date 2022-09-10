using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace Egebimtes.EtiketBasimi;

internal class DBConn
{
	private OleDbConnection connDAL;

	private OleDbCommand cmdDAL;

	private OleDbDataAdapter daDAL;

	private string strCommand = "";

	public DBConn()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		connDAL = new OleDbConnection(Program.strConnString);
	}

	public DataTable BelgeKalemListele(string strBelgeNo, string strBelgeTipiGelen, bool blReceteGetir)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		new DataTable();
		try
		{
			switch (strBelgeTipiGelen)
			{
			case "9999":
				strCommand = "SELECT CONVERT(bit,0) as SEC, 1 AS [BASIM MIKTARI], STHAR.STOK_KODU AS [STOK KODU], STSABIT.STOK_ADI AS [STOK ADI], STHAR_GCMIK AS [MIKTARI], STHAR_TARIH AS [TARIH], INCKEYNO AS [INCKEY] FROM TBLSTHAR STHAR INNER JOIN TBLSTSABIT STSABIT ON STSABIT.STOK_KODU = STHAR.STOK_KODU WHERE STHAR.FISNO = ? AND STHAR.STHAR_GCKOD = 'G' AND STHAR.STHAR_HTUR = 'C'";
				cmdDAL = new OleDbCommand(strCommand, connDAL);
				cmdDAL.get_Parameters().Add("@FisNo", (OleDbType)200);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@FisNo")).Value = strBelgeNo;
				daDAL = new OleDbDataAdapter(cmdDAL);
				((DbDataAdapter)(object)daDAL).Fill(dataTable);
				break;
			case "6":
			case "7":
				strCommand = "SELECT CONVERT(bit,0) as SEC, 1 AS [BASIM MIKTARI], SP.INCKEYNO AS [INCKEY], SP.STOK_KODU AS [STOK KODU], ST.STOK_ADI AS [STOK ADI], SP.YAPKOD [ESNEK KOD], (SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD = SP.YAPKOD ) AS [ESNEK ACIKLAMA], ISNULL(CS.CARISTOK_KODU,'') [MUSTERI STOKKODU], ISNULL(CS.CARISTOKISMI,'') [MUSTERI STOKISMI], SP.STHAR_GCMIK AS [MIKTARI], ISNULL(EK.KULL8S,'') AS RECETEGETIR  FROM TBLSIPATRA SP WITH(NOLOCK)  INNER JOIN TBLSTSABIT ST WITH(NOLOCK) ON SP.STOK_KODU = ST.STOK_KODU  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON SP.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON SP.STOK_KODU = CS.STOK_KODU AND SP.STHAR_ACIKLAMA = CS.CARI_KOD  WHERE SP.STHAR_FTIRSIP ='" + strBelgeTipiGelen + "' AND SP.SUBE_KODU = ? AND SP.FISNO = ?";
				cmdDAL = new OleDbCommand(strCommand, connDAL);
				cmdDAL.get_Parameters().Add("@SubeKodu", (OleDbType)3);
				cmdDAL.get_Parameters().Add("@SiparisNo", (OleDbType)200);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@SubeKodu")).Value = Program.intSubeKodu;
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@SiparisNo")).Value = strBelgeNo;
				daDAL = new OleDbDataAdapter(cmdDAL);
				((DbDataAdapter)(object)daDAL).Fill(dataTable);
				break;
			case "1":
			case "2":
			case "3":
			case "4":
			case "8":
			case "9":
				strCommand = "SELECT CONVERT(bit,0) as SEC, 1 AS [BASIM MIKTARI] ,TS.INCKEYNO AS [INCKEY], TS.STOK_KODU AS [STOK KODU], ST.STOK_ADI AS [STOK ADI],  TS.YAPKOD [ESNEK KOD], (SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD = TS.YAPKOD ) AS [ESNEK ACIKLAMA], ISNULL(CS.CARISTOK_KODU,'') [MUSTERI STOKKODU], ISNULL(CS.CARISTOKISMI,'') [MUSTERI STOKISMI], TS.STHAR_GCMIK AS [MIKTARI], ISNULL(EK.KULL8S,'') AS RECETEGETIR, TS.STHAR_TARIH AS TARIH  FROM TBLSTHAR TS WITH(NOLOCK)  INNER JOIN TBLSTSABIT ST WITH(NOLOCK) ON TS.STOK_KODU = ST.STOK_KODU  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON TS.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON TS.STOK_KODU = CS.STOK_KODU AND TS.STHAR_ACIKLAMA = CS.CARI_KOD  WHERE TS.STHAR_FTIRSIP ='" + strBelgeTipiGelen + "' AND TS.SUBE_KODU = ? AND TS.FISNO = ?";
				if (strBelgeTipiGelen == "8" || strBelgeTipiGelen == "9")
				{
					strCommand += " AND TS.C_YEDEK6 = 'X'";
				}
				cmdDAL = new OleDbCommand(strCommand, connDAL);
				cmdDAL.get_Parameters().Add("@SubeKodu", (OleDbType)3);
				cmdDAL.get_Parameters().Add("@FisNo", (OleDbType)200);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@SubeKodu")).Value = Program.intSubeKodu;
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@FisNo")).Value = strBelgeNo;
				daDAL = new OleDbDataAdapter(cmdDAL);
				((DbDataAdapter)(object)daDAL).Fill(dataTable);
				break;
			}
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable BelgeKalemOku(int intIncKey)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT * FROM MOBILO_ETIKET_BELGEKALEM WHERE INCKEYNO=" + intIncKey;
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable StokBilgiOku(string strStokKodu)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT STSABIT.*, EK.KULL1N, EK.KULL2N, EK.KULL3N, EK.KULL4N, EK.KULL5N, EK.KULL6N, EK.KULL7N, EK.KULL8N, EK.KULL1S, EK.KULL2S, EK.KULL3S, EK.KULL4S, EK.KULL5S, EK.KULL6S, EK.KULL7S, EK.KULL8S, EK.INGISIM FROM TBLSTSABIT STSABIT INNER JOIN TBLSTSABITEK EK ON EK.STOK_KODU = STSABIT.STOK_KODU WHERE STSABIT.STOK_KODU = ?";
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			cmdDAL.get_Parameters().Add("@StokKodu", (OleDbType)200);
			((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKodu")).Value = strStokKodu;
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable StoklariGetir(string strStokKodu, string strStokAdi)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT STOK_KODU AS [STOK KODU], STOK_ADI AS [STOK ADI]FROM TBLSTSABIT ";
			cmdDAL = new OleDbCommand();
			cmdDAL.set_Connection(connDAL);
			if (strStokKodu != string.Empty || strStokAdi != string.Empty)
			{
				text += "WHERE ";
			}
			if (strStokKodu != string.Empty)
			{
				text += "STOK_KODU LIKE ?";
				cmdDAL.get_Parameters().Add("@StokKodu", (OleDbType)200);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKodu")).Value = '%' + strStokKodu + '%';
			}
			if (strStokAdi != string.Empty)
			{
				if (strStokKodu != string.Empty)
				{
					text += " AND";
				}
				text += " STOK_ADI LIKE ?";
				cmdDAL.get_Parameters().Add("@StokAdi", (OleDbType)200);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokAdi")).Value = '%' + strStokAdi + '%';
			}
			((DbCommand)(object)cmdDAL).CommandText = text;
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable SeriBilgiOku(int intIncKey)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT * FROM TBLSERITRA WITH(NOLOCK) WHERE STRA_INC = ?";
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			cmdDAL.get_Parameters().Add("@IncKey", (OleDbType)3);
			((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@IncKey")).Value = intIncKey;
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataRow StokHareketOku(int intIncKey)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT * FROM TBLSTHAR WITH(NOLOCK) WHERE INCKEYNO = ?";
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			cmdDAL.get_Parameters().Add("@IncKey", (OleDbType)3);
			((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@IncKey")).Value = intIncKey;
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable.Rows[0];
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable KalemBilgiOku(int intIncKey, string strBelgeTip)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = ((!(strBelgeTip == "SIP")) ? ("SELECT SP.STOK_KODU,SP.STHAR_GCMIK,SP.FISNO,SP.STHAR_TARIH, ST.STOK_ADI,ST.PAY_1,ST.PAYDA_1,ST.PAY2,ST.PAYDA2,ST.GRUP_KODU,ST.SATIS_FIAT1,ST.SATIS_FIAT2,ST.SATIS_FIAT3,ST.SATIS_FIAT4, ISNULL(CS.CARISTOK_KODU,'') CARISTOK_KODU, ISNULL(CS.CARISTOKISMI,'') CARISTOKISMI, ISNULL(SP.YAPKOD,'') YAPKOD, ISNULL((SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD = SP.YAPKOD),'') AS YAPACIK, ISNULL(EK.INGISIM,'') INGISIM, EK.KULL1N,EK.KULL2N,EK.KULL3N,EK.KULL4N,EK.KULL5N,EK.KULL6N,EK.KULL7N,EK.KULL8N,  EK.KULL1S, EK.KULL2S, EK.KULL3S, EK.KULL4S, EK.KULL5S, EK.KULL6S, EK.KULL7S, EK.KULL8S  FROM TBLSTHAR SP WITH(NOLOCK)  INNER JOIN TBLSTSABIT ST WITH(NOLOCK) ON SP.STOK_KODU = ST.STOK_KODU  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON SP.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON SP.STOK_KODU = CS.STOK_KODU AND SP.STHAR_ACIKLAMA = CS.CARI_KOD AND (SP.YAPKOD = CS.YAPKOD OR CS.YAPKOD IS NULL) WHERE SP.INCKEYNO = " + intIncKey) : ("SELECT SP.STOK_KODU,SP.STHAR_GCMIK,SP.FISNO,SP.STHAR_TARIH, ST.STOK_ADI,ST.PAY_1,ST.PAYDA_1,ST.PAY2,ST.PAYDA2,ST.GRUP_KODU,ST.SATIS_FIAT1,ST.SATIS_FIAT2,ST.SATIS_FIAT3,ST.SATIS_FIAT4, ISNULL(CS.CARISTOK_KODU,'') CARISTOK_KODU, ISNULL(CS.CARISTOKISMI,'') CARISTOKISMI, ISNULL(SP.YAPKOD,'') YAPKOD, ISNULL((SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD = SP.YAPKOD),'') AS YAPACIK, ISNULL(EK.INGISIM,'') INGISIM, EK.KULL1N,EK.KULL2N,EK.KULL3N,EK.KULL4N,EK.KULL5N,EK.KULL6N,EK.KULL7N,EK.KULL8N,  EK.KULL1S, EK.KULL2S, EK.KULL3S, EK.KULL4S, EK.KULL5S, EK.KULL6S, EK.KULL7S, EK.KULL8S  FROM TBLSIPATRA SP WITH(NOLOCK)  INNER JOIN TBLSTSABIT ST WITH(NOLOCK) ON SP.STOK_KODU = ST.STOK_KODU  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON SP.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON SP.STOK_KODU = CS.STOK_KODU AND SP.STHAR_ACIKLAMA = CS.CARI_KOD AND (SP.YAPKOD = CS.YAPKOD OR CS.YAPKOD IS NULL) WHERE SP.INCKEYNO = " + intIncKey));
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable BelgeUstOku(string strBelgeNo, string strFtirsip, string strSecBelgeCari)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			string text = "";
			text = "SELECT * FROM MOBILO_ETIKET_BELGEUST  WHERE FATIRS_NO='" + strBelgeNo + "' AND FTIRSIP='" + strFtirsip + "' AND SUBE_KODU=" + Program.intSubeKodu;
			if (strFtirsip == "2" || strFtirsip == "4")
			{
				text = text + " AND CARI_KODU='" + strSecBelgeCari + "'";
			}
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable("EtiketBelgeUst");
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable BilesenBilgiOku(int intIncKey, string strBelgeTip, string strStokKod, string strYapKod, string strCariKod)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		try
		{
			((DbConnection)(object)connDAL).Open();
			DataTable dataTable = new DataTable();
			string text = "";
			text = ((!(strBelgeTip == "SIP")) ? ("SELECT BIL.*,SIP.STHAR_GCMIK,SIP.FISNO,SIP.STHAR_TARIH FROM ( SELECT ST.STOK_KODU, ST.STOK_ADI,ST.PAY_1,ST.PAYDA_1,ST.PAY2,ST.PAYDA2,ST.GRUP_KODU,ST.SATIS_FIAT1,ST.SATIS_FIAT2,ST.SATIS_FIAT3,ST.SATIS_FIAT4, ISNULL(CS.CARISTOK_KODU,'') CARISTOK_KODU, ISNULL(CS.CARISTOKISMI,'') CARISTOKISMI,'" + strYapKod + "' as YAPKOD, ISNULL((SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD ='" + strYapKod + "'),'') AS YAPACIK, ISNULL(EK.INGISIM,'') INGISIM, EK.KULL1N,EK.KULL2N,EK.KULL3N,EK.KULL4N,EK.KULL5N,EK.KULL6N,EK.KULL7N,EK.KULL8N,  EK.KULL1S, EK.KULL2S, EK.KULL3S, EK.KULL4S, EK.KULL5S, EK.KULL6S, EK.KULL7S, EK.KULL8S  FROM TBLSTSABIT ST WITH(NOLOCK)  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON ST.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON ST.STOK_KODU = CS.STOK_KODU AND CS.CARI_KOD= ? AND (CS.YAPKOD= '" + strYapKod + "' OR CS.YAPKOD IS NULL) WHERE ST.STOK_KODU = ? ) BIL  INNER JOIN (SELECT * FROM TBLSTHAR WHERE INCKEYNO=" + intIncKey + " ) SIP ON 1=1 ") : ("SELECT BIL.*,SIP.STHAR_GCMIK,SIP.FISNO,SIP.STHAR_TARIH FROM ( SELECT ST.STOK_KODU, ST.STOK_ADI,ST.PAY_1,ST.PAYDA_1,ST.PAY2,ST.PAYDA2,ST.GRUP_KODU,ST.SATIS_FIAT1,ST.SATIS_FIAT2,ST.SATIS_FIAT3,ST.SATIS_FIAT4, ISNULL(CS.CARISTOK_KODU,'') CARISTOK_KODU, ISNULL(CS.CARISTOKISMI,'') CARISTOKISMI,'" + strYapKod + "' as YAPKOD, ISNULL((SELECT DBO.NSF_YAPACIK(YAPKOD,'A',YAPACIK) ACIKLAMA FROM TBLESNYAPMAS WITH(NOLOCK) WHERE  YAPKOD = '" + strYapKod + "'),'') AS YAPACIK, ISNULL(EK.INGISIM,'') INGISIM, EK.KULL1N,EK.KULL2N,EK.KULL3N,EK.KULL4N,EK.KULL5N,EK.KULL6N,EK.KULL7N,EK.KULL8N,  EK.KULL1S, EK.KULL2S, EK.KULL3S, EK.KULL4S, EK.KULL5S, EK.KULL6S, EK.KULL7S, EK.KULL8S  FROM TBLSTSABIT ST WITH(NOLOCK)  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON ST.STOK_KODU = EK.STOK_KODU  LEFT OUTER JOIN TBLCARISTOK CS ON ST.STOK_KODU = CS.STOK_KODU AND CS.CARI_KOD= ? AND (CS.YAPKOD= '" + strYapKod + "' OR CS.YAPKOD IS NULL) WHERE ST.STOK_KODU = ? ) BIL  INNER JOIN (SELECT * FROM TBLSIPATRA WHERE INCKEYNO=" + intIncKey + " ) SIP ON 1=1 "));
			cmdDAL = new OleDbCommand(text);
			cmdDAL.set_Connection(connDAL);
			OleDbParameter val = new OleDbParameter("@CARI_KODU", (OleDbType)200);
			((DbParameter)(object)val).Value = strCariKod;
			cmdDAL.get_Parameters().Add(val);
			val = null;
			val = new OleDbParameter("@STOK_KODU", (OleDbType)200);
			((DbParameter)(object)val).Value = strStokKod;
			cmdDAL.get_Parameters().Add(val);
			daDAL = new OleDbDataAdapter(cmdDAL);
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable BelgeListele(string strBelgeTipiGelen, string BelgeNo, string CariKodu, string CariAdi, DateTime Tarih)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		try
		{
			cmdDAL = new OleDbCommand();
			switch (strBelgeTipiGelen)
			{
			case "9999":
				strCommand = "SELECT  URETSON_FISNO AS [BELGE NO], URETSON_MAMUL AS [STOK KODU],S.STOK_ADI AS [STOK ADI], URETSON_TARIH AS [TARIH]FROM TBLSTOKURS U WITH(NOLOCK) INNER JOIN TBLSTSABIT S WITH(NOLOCK) ON S.STOK_KODU = U.URETSON_MAMUL ";
				if (BelgeNo != "")
				{
					strCommand += " WHERE URETSON_FISNO LIKE ?";
					cmdDAL.get_Parameters().Add("@FisNo", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@FisNo")).Value = BelgeNo;
				}
				if (Tarih != DateTime.MinValue)
				{
					strCommand += " AND URETSON_TARIH = ?";
					cmdDAL.get_Parameters().Add("@Tarih", (OleDbType)7);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@Tarih")).Value = Tarih.Date;
				}
				if (CariKodu != "")
				{
					strCommand += " AND S.STOK_KODU LIKE ?";
					cmdDAL.get_Parameters().Add("@StokKodu", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKodu")).Value = CariKodu;
				}
				if (CariAdi != "")
				{
					strCommand += " AND S.STOK_ADI LIKE ?";
					cmdDAL.get_Parameters().Add("@StokAdi", (OleDbType)200, 100);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokAdi")).Value = CariAdi;
				}
				break;
			case "6":
			case "7":
				strCommand = "SELECT SP.TARIH,SP.FATIRS_NO AS [BELGE NO],SP.CARI_KODU AS [CARI KODU],  CS.CARI_ISIM AS [CARI ADI]  FROM TBLSIPAMAS SP WITH(NOLOCK)  INNER JOIN TBLCASABIT CS WITH(NOLOCK) ON SP.CARI_KODU = CS.CARI_KOD  WHERE FTIRSIP = '" + strBelgeTipiGelen + "' AND SP.SUBE_KODU =" + Program.intSubeKodu;
				if (BelgeNo != "")
				{
					strCommand += " AND SP.FATIRS_NO LIKE ?";
					cmdDAL.get_Parameters().Add("@SiparisNo", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@SiparisNo")).Value = BelgeNo;
				}
				if (CariKodu != "")
				{
					strCommand += " AND SP.CARI_KODU LIKE ?";
					cmdDAL.get_Parameters().Add("@CariKodu", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@CariKodu")).Value = CariKodu;
				}
				if (CariAdi != "")
				{
					strCommand += " AND CS.CARI_ISIM LIKE ?";
					cmdDAL.get_Parameters().Add("@CariAdi", (OleDbType)200, 100);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@CariAdi")).Value = CariAdi;
				}
				if (Tarih != DateTime.MinValue)
				{
					strCommand += " AND SP.TARIH = ?";
					cmdDAL.get_Parameters().Add("@Tarih", (OleDbType)7);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@Tarih")).Value = Tarih.Date;
				}
				break;
			case "1":
			case "2":
			case "3":
			case "4":
			case "8":
			case "9":
				strCommand = "SELECT FI.TARIH,FI.FATIRS_NO AS [BELGE NO],FI.CARI_KODU AS [CARI KODU],  ISNULL(CS.CARI_ISIM,'') AS [CARI ADI]  FROM TBLFATUIRS FI WITH(NOLOCK)  LEFT OUTER JOIN TBLCASABIT CS WITH(NOLOCK) ON FI.CARI_KODU = CS.CARI_KOD  WHERE FTIRSIP = '" + strBelgeTipiGelen + "' AND FI.SUBE_KODU = " + Program.intSubeKodu;
				if (strBelgeTipiGelen == "8" || strBelgeTipiGelen == "9")
				{
					strCommand += " AND YEDEK='X'";
				}
				if (BelgeNo != "")
				{
					strCommand += " AND FI.FATIRS_NO LIKE ?";
					cmdDAL.get_Parameters().Add("@BelgeNo", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@BelgeNo")).Value = BelgeNo;
				}
				if (CariKodu != "")
				{
					strCommand += " AND FI.CARI_KODU LIKE ?";
					cmdDAL.get_Parameters().Add("@CariKodu", (OleDbType)200, 15);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@CariKodu")).Value = CariKodu;
				}
				if (CariAdi != "")
				{
					strCommand += " AND FI.CARI_ISIM LIKE ?";
					cmdDAL.get_Parameters().Add("@CariAdi", (OleDbType)200, 100);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@CariAdi")).Value = CariAdi;
				}
				if (Tarih != DateTime.MinValue)
				{
					strCommand += " AND FI.TARIH = ?";
					cmdDAL.get_Parameters().Add("@Tarih", (OleDbType)7);
					((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@Tarih")).Value = Tarih.Date;
				}
				break;
			}
			((DbCommand)(object)cmdDAL).CommandType = CommandType.Text;
			((DbCommand)(object)cmdDAL).CommandText = strCommand;
			cmdDAL.set_Connection(connDAL);
			if (((DbConnection)(object)connDAL).State != ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Open();
			}
			daDAL = new OleDbDataAdapter(cmdDAL);
			DataTable dataTable = new DataTable();
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			cmdDAL = null;
			if (dataTable != null)
			{
				return dataTable;
			}
			return null;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable StokKoduListele(string strStokAdi, string strStokKodu)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		try
		{
			((DbConnection)(object)connDAL).Open();
			strCommand = "SELECT ST.STOK_KODU AS [STOK KODU], ST.STOK_ADI AS [STOK ADI], ST.GRUP_KODU AS [GRUP KODU], ST.KOD_1 AS [KOD 1] FROM TBLSTSABIT ST WITH(NOLOCK)  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON ST.STOK_KODU = EK.STOK_KODU WHERE ST.STOK_KODU = EK.STOK_KODU ";
			cmdDAL = new OleDbCommand(strCommand, connDAL);
			if (strStokKodu != "")
			{
				strCommand += " AND ST.STOK_KODU = ?";
				cmdDAL.get_Parameters().Add("@StokKodu", (OleDbType)200, 15);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKodu")).Value = strStokKodu;
			}
			if (strStokAdi != "")
			{
				strCommand += " AND ST.STOK_ADI = ?";
				cmdDAL.get_Parameters().Add("@StokAdi", (OleDbType)200, 100);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokAdi")).Value = strStokAdi;
			}
			((DbCommand)(object)cmdDAL).CommandText = strCommand;
			daDAL = new OleDbDataAdapter(cmdDAL);
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable GrupKod1Listele(string strKod, string strGrupIsim, string strTabloAdi, string strAlanAdi)
	{
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		string text = "KOD 1";
		try
		{
			((DbConnection)(object)connDAL).Open();
			if (strTabloAdi == "TBLSTGRUP")
			{
				text = "GRUP KODU";
			}
			strCommand = "SELECT ST." + strAlanAdi + " AS [" + text + "], ST.GRUP_ISIM AS [GRUP ISIM] FROM " + strTabloAdi + " ST WITH(NOLOCK)";
			if (strKod != "" && strGrupIsim != "")
			{
				string text2 = strCommand;
				strCommand = text2 + " WHERE ST." + strAlanAdi + " = '" + strKod + "' AND ST.GRUP_ISIM = '" + strGrupIsim + "'";
			}
			else if (strKod != "")
			{
				string text3 = strCommand;
				strCommand = text3 + " WHERE ST." + strAlanAdi + " = '" + strKod + "'";
			}
			else if (strGrupIsim != "")
			{
				strCommand = strCommand + " WHERE ST.GRUP_ISIM = '" + strGrupIsim + "'";
			}
			cmdDAL = new OleDbCommand(strCommand, connDAL);
			((DbCommand)(object)cmdDAL).CommandText = strCommand;
			daDAL = new OleDbDataAdapter(cmdDAL);
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}

	public DataTable StokKartListele(string strStokKoduBasla, string strStokKoduBitis, string strGrupKoduBasla, string strGrupKoduBitis, string strKod1Basla, string strKod1Bitis)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		try
		{
			((DbConnection)(object)connDAL).Open();
			strCommand = "SELECT CONVERT(bit,0) as SEC, ST.STOK_KODU AS [STOK KODU], ST.STOK_ADI AS [STOK ADI],  0 AS [BASIM MIKTARI]  FROM TBLSTSABIT ST WITH(NOLOCK)  LEFT OUTER JOIN TBLSTSABITEK EK WITH(NOLOCK) ON ST.STOK_KODU = EK.STOK_KODU WHERE ST.STOK_KODU = EK.STOK_KODU ";
			cmdDAL = new OleDbCommand(strCommand, connDAL);
			if (strStokKoduBasla != "" && strStokKoduBitis != "")
			{
				strCommand += "AND ST.STOK_KODU BETWEEN ?  AND ?";
				cmdDAL.get_Parameters().Add("@StokKoduBasla", (OleDbType)200, 35);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKoduBasla")).Value = strStokKoduBasla;
				cmdDAL.get_Parameters().Add("@StokKoduBitis", (OleDbType)200, 35);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@StokKoduBitis")).Value = strStokKoduBitis;
			}
			if (strGrupKoduBasla != "" && strGrupKoduBitis != "")
			{
				strCommand += " AND ST.GRUP_KODU BETWEEN ? AND ? ";
				cmdDAL.get_Parameters().Add("@GrupKoduBasla", (OleDbType)200, 35);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@GrupKoduBasla")).Value = strGrupKoduBasla;
				cmdDAL.get_Parameters().Add("@GrupKoduBitis", (OleDbType)200, 35);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@GrupKoduBitis")).Value = strGrupKoduBitis;
			}
			if (strKod1Basla != "" && strKod1Bitis != "")
			{
				strCommand += " AND ST.KOD_1  BETWEEN ? AND ?";
				cmdDAL.get_Parameters().Add("@Kod1Basla", (OleDbType)200, 100);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@Kod1Basla")).Value = strKod1Basla;
				cmdDAL.get_Parameters().Add("@Kod1Bitis", (OleDbType)200, 100);
				((DbParameter)(object)cmdDAL.get_Parameters().get_Item("@Kod1Bitis")).Value = strKod1Bitis;
			}
			((DbCommand)(object)cmdDAL).CommandText = strCommand;
			daDAL = new OleDbDataAdapter(cmdDAL);
			((DbDataAdapter)(object)daDAL).Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			throw ex;
		}
		finally
		{
			if (((DbConnection)(object)connDAL).State == ConnectionState.Open)
			{
				((DbConnection)(object)connDAL).Close();
			}
		}
	}
}
