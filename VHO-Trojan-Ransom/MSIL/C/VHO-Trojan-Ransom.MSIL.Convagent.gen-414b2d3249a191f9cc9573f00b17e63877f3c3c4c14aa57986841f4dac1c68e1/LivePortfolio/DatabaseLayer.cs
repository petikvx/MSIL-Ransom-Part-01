#define DEBUG
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class DatabaseLayer
{
	private DatabasePrimitives db;

	public DatabaseLayer()
	{
		db = new DatabasePrimitives();
	}

	public void UpdateAsset(int Id, string Ticker, string Name, string AssetType, decimal Bid, decimal Offer, decimal Dividend, decimal PriceEarnings)
	{
		string text = "'" + Strings.Format((object)DateAndTime.get_Today(), "yyyy-MM-dd") + "'";
		string sQL = "Update Asset SET Ticker='" + Ticker + "',\r\n                                        [Name]='" + Name + "',\r\n                                        AssetType='" + AssetType + "'\r\n                                        BidPrice=" + Conversions.ToString(Bid) + ",\r\n                                        OfferPrice=" + Conversions.ToString(Offer) + ",  \r\n                                        Dividend=" + Conversions.ToString(Dividend) + ",\r\n                                        PriceEarnings=" + Conversions.ToString(PriceEarnings) + ",\r\n                                        Updated=" + text + "\r\n                                        WHERE Id = " + Conversions.ToString(Id);
		db.ExecuteNonQuery(sQL);
		sQL = "INSERT OR REPLACE INTO PriceHistory(AssetId, [Date], Price)  VALUES (" + Id + "," + text + "," + Offer + ")";
		db.ExecuteNonQuery(sQL);
	}

	public void UpdateAsset(int Id, decimal Offer)
	{
		string text = "'" + Strings.Format((object)DateAndTime.get_Today(), "yyyy-MM-dd") + "'";
		string text2 = "Update Asset SET         OfferPrice=" + Conversions.ToString(Offer) + ",\r\n                                        Updated=Date(" + text + ") \r\n                                        WHERE Id = " + Conversions.ToString(Id);
		Debug.Print(text2);
		db.ExecuteNonQuery(text2);
		text2 = "INSERT OR REPLACE INTO PriceHistory(AssetId, [Date], Price)  VALUES (" + Id + "," + text + "," + Offer + ")";
		db.ExecuteNonQuery(text2);
	}

	public void UpdateCash(int PortfolioId, decimal Amount)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		stringBuilder.Append("UPDATE Portfolio ");
		stringBuilder.Append("SET    Cash = " + Amount + " ");
		stringBuilder.Append("WHERE  Id = " + PortfolioId);
		int num = db.ExecuteNonQuery(stringBuilder.ToString());
		if (num != 1)
		{
			Interaction.MsgBox((object)("Cash Update Failed. Rows Affected=" + Conversions.ToString(num)), (MsgBoxStyle)0, (object)null);
		}
	}

	public void AssetPurchase(int PortfolioID, int AssetID, decimal Units)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		stringBuilder.Append("SELECT COALESCE(Holding,0) ");
		stringBuilder.Append("       FROM Holding ");
		stringBuilder.Append("WHERE  PortfolioId = " + Conversions.ToString(PortfolioID) + " ");
		stringBuilder.Append("AND    AssetID = " + Conversions.ToString(AssetID) + " ");
		decimal d = Conversions.ToDecimal(db.ExecuteScalar(stringBuilder.ToString()));
		stringBuilder.Clear();
		if (decimal.Compare(d, 0m) == 0)
		{
			stringBuilder.Append("INSERT INTO Holding(AssetID,PortfolioID,Holding) ");
			stringBuilder.Append("VALUES (" + Conversions.ToString(AssetID) + "," + Conversions.ToString(PortfolioID) + "," + Conversions.ToString(Units) + ")");
		}
		else
		{
			stringBuilder.Append("UPDATE Holding ");
			stringBuilder.Append("SET Holding = Holding + " + Conversions.ToString(Units) + " ");
			stringBuilder.Append("WHERE  PortfolioId = " + Conversions.ToString(PortfolioID) + " ");
			stringBuilder.Append("AND    AssetID = " + Conversions.ToString(AssetID) + " ");
		}
		db.ExecuteScalar(stringBuilder.ToString());
	}

	public void AssetSale(int PortfolioID, int AssetID, decimal Units)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		stringBuilder.Append("SELECT Holding FROM HOLDING WHERE AssetId=" + AssetID + " AND PortfolioId=" + PortfolioID);
		decimal d = Conversions.ToDecimal(db.ExecuteScalar(stringBuilder.ToString()));
		stringBuilder.Clear();
		if (decimal.Compare(Units, d) == 0)
		{
			stringBuilder.Append("DELETE FROM HOLDING WHERE AssetId=" + AssetID + " AND PortfolioId=" + PortfolioID);
		}
		else
		{
			stringBuilder.Append("UPDATE Holding ");
			stringBuilder.Append("SET Holding = Holding - " + Conversions.ToString(Units) + " ");
			stringBuilder.Append("WHERE  PortfolioId = " + Conversions.ToString(PortfolioID) + " ");
			stringBuilder.Append("AND AssetID = " + Conversions.ToString(AssetID) + " ");
		}
		db.ExecuteNonQuery(stringBuilder.ToString());
	}

	public DataTable GetAssets()
	{
		string sQL = "SELECT Id,\r\n       Name,\r\n       Ticker,\r\n       AssetType,\r\n       BidPrice,\r\n       OfferPrice,\r\n       Dividend,\r\n       PriceEarnings,\r\n       Updated,\r\n       CASE WHEN EXISTS (\r\n               SELECT 'X'\r\n                 FROM HOLDING H\r\n                WHERE H.AssetId = A.Id\r\n           )\r\n       THEN 1 ELSE 0 END AS InPortfolio\r\n  FROM Asset A\r\n ORDER BY Ticker;";
		return db.ExecuteQuery(sQL);
	}

	public void AddTransaction(Transaction NewTransaction)
	{
		Transaction transaction = NewTransaction;
		AddTransaction(transaction.Transaction_Date, transaction.PortfolioId, transaction.AssetId, transaction.Units, 0m, transaction.Amount, 0m, 0m, transaction.Type, transaction.Remarks);
		transaction = null;
	}

	public void AddTransaction(DateTime TransactionDate, int PortfolioID, int AssetID, decimal Units, decimal Amount, string Type, string Remarks)
	{
		AddTransaction(TransactionDate, PortfolioID, AssetID, Units, 0m, Amount, 0m, 0m, Type, Remarks);
	}

	public void AddTransaction(DateTime TransactionDate, int PortfolioID, int AssetID, decimal Units, decimal UnitPrice, decimal Amount, decimal StampDuty, decimal Commission, string Type, string Remarks)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		StringBuilder stringBuilder2 = stringBuilder;
		stringBuilder2.Append("INSERT INTO [Transaction] ([PortfolioId],[AssetId],[Date],[Type],[Amount],[Units],[UnitPrice],[Commission],[StampDuty],[Remarks]) ");
		stringBuilder2.Append("VALUES (");
		stringBuilder2.Append(PortfolioID + ",");
		stringBuilder2.Append(AssetID + ",");
		stringBuilder2.Append("'" + Strings.Format((object)TransactionDate, "yyyy-MM-dd") + "',");
		stringBuilder2.Append("'" + Type + "',");
		stringBuilder2.Append(Amount + ",");
		stringBuilder2.Append(Units + ",");
		stringBuilder2.Append(UnitPrice + ",");
		stringBuilder2.Append(Commission + ",");
		stringBuilder2.Append(StampDuty + ",");
		stringBuilder2.Append("'" + Remarks + "'");
		stringBuilder2.Append(")");
		stringBuilder2 = null;
		db.ExecuteScalar(stringBuilder.ToString());
		Debug.Print("Transaction SQL \r\n" + stringBuilder.ToString());
	}

	public decimal GetCashHolding(int PortfolioId)
	{
		string sQL = "SELECT Cash FROM Portfolio P \r\n               WHERE        P.Id=" + PortfolioId + ";";
		object objectValue = RuntimeHelpers.GetObjectValue(db.ExecuteScalar(sQL));
		return Conversions.ToDecimal(objectValue);
	}

	public void SetCashHolding(int PortfolioId, decimal NewCash)
	{
		decimal cashHolding = GetCashHolding(PortfolioId);
		decimal num = decimal.Subtract(NewCash, cashHolding);
		decimal d = num;
		string type = default(string);
		if (decimal.Compare(d, 0m) > 0)
		{
			type = "Deposit";
		}
		else if (decimal.Compare(d, 0m) < 0)
		{
			type = "Withdrawal";
		}
		else if (decimal.Compare(d, 0m) == 0)
		{
			return;
		}
		string sQL = "UPDATE Portfolio  \r\n               SET Cash = " + NewCash + " WHERE Id=" + PortfolioId;
		db.ExecuteNonQuery(sQL);
		AddTransaction(DateAndTime.get_Today(), PortfolioId, -1, 0m, num, type, "");
	}

	public decimal ValuePortfolio(int PortfolioId)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		stringBuilder.Append("Select SUM(H.Holding * A.OfferPrice) As PortfolioValue ");
		stringBuilder.Append("From Holding H, ");
		stringBuilder.Append("From Asset A, ");
		stringBuilder.Append("Where H.AssetId = A.Id ");
		stringBuilder.Append("And H.PortfolioId = " + Conversions.ToString(PortfolioId));
		object objectValue = RuntimeHelpers.GetObjectValue(db.ExecuteScalar(stringBuilder.ToString()));
		return Conversions.ToDecimal(objectValue);
	}

	public string GetReferenceValue(string Type, string Key)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		stringBuilder2.Clear();
		stringBuilder2.Append("SELECT VALUE ");
		stringBuilder2.Append("FROM Reference ");
		stringBuilder2.Append("WHERE Type = '" + Strings.Trim(Type) + "' ");
		stringBuilder2.Append("AND Key = '" + Strings.Trim(Key) + "'");
		stringBuilder2 = null;
		object objectValue = RuntimeHelpers.GetObjectValue(db.ExecuteScalar(stringBuilder.ToString()));
		return objectValue.ToString();
	}

	public void PutReferenceValue(string Type, string Key, string Value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		stringBuilder2.Clear();
		stringBuilder2.Append("INSERT OR REPLACE INTO Reference(Type, Key,Value,Updated) ");
		stringBuilder2.Append("Values ('" + Strings.Trim(Type) + "','" + Strings.Trim(Key) + "','" + Strings.Trim(Value) + "','" + Strings.Format((object)DateAndTime.get_Today(), "yyyy-MM-dd") + "')");
		stringBuilder2 = null;
		db.ExecuteScalar(stringBuilder.ToString());
	}

	public DataTable GetAssetList()
	{
		StringBuilder stringBuilder = new StringBuilder();
		DataTable dataTable = new DataTable();
		stringBuilder.Clear();
		stringBuilder.Append("SELECT A.Id, ");
		stringBuilder.Append("       A.Ticker, ");
		stringBuilder.Append("       A.Name ");
		stringBuilder.Append("FROM   Asset A ");
		stringBuilder.Append("JOIN   HOLDING H ON H.AssetId = A.id ");
		stringBuilder.Append("ORDER BY Ticker ");
		return db.ExecuteQuery(stringBuilder.ToString());
	}

	public decimal GetAssetPrice(string AssetId)
	{
		string sQL = "SELECT A.OfferPrice\r\n               FROM Asset A\r\n               WHERE A.Id = " + AssetId + ";";
		return Conversions.ToDecimal(db.ExecuteScalar(sQL));
	}

	public object GetHolding(string PortfolioId, string AssetId)
	{
		string sQL = "SELECT H.Holding\r\n              From Holding H\r\n              Where H.AssetId = " + AssetId + " And \r\n              H.PortfolioId = " + PortfolioId + ";";
		decimal num = Conversions.ToDecimal(db.ExecuteScalar(sQL));
		return num;
	}

	public void AdjustCashPosition(int PortfolioId, decimal Amount)
	{
		decimal cashHolding = GetCashHolding(PortfolioId);
		SetCashHolding(PortfolioId, decimal.Add(cashHolding, Amount));
	}

	public object GetAssetIdFromName(string AssetName)
	{
		string sQL = "SELECT COALESCE(Id,-1)\r\n                             FROM Asset \r\n                             WHERE Name = '" + AssetName.ToUpper() + "'";
		int num = Conversions.ToInteger(db.ExecuteScalar(sQL));
		return num;
	}

	public void DeleteDividend(int DividendId)
	{
		string sQL = "DELETE FROM Dividend WHERE Id =" + DividendId;
		db.ExecuteNonQuery(sQL);
	}

	public void ReplacePriceHistory(List<AssetPrice> NewPrices)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int assetID = NewPrices[0].AssetID;
		stringBuilder.Clear();
		foreach (AssetPrice NewPrice in NewPrices)
		{
			stringBuilder.Append("INSERT OR REPLACE INTO PriceHistory(AssetId,[Date],Price) VALUES (" + NewPrice.AssetID + ",'" + Strings.Format((object)NewPrice.PriceDate, "yyyy-MM-dd") + "'," + NewPrice.Price + ");");
		}
		db.ExecuteNonQuery(stringBuilder.ToString());
		UpdateAssetPriceFromHistory(assetID);
	}

	public void UpdateAssetPriceFromHistory(int AssetID)
	{
		string sQL = "UPDATE Asset\r\n               SET OfferPrice = (\r\n                   Select Price\r\n                   From   PriceHistory PH1\r\n                   Where AssetID = " + AssetID + " And\r\n                  Date = (\r\n                             Select MAX(Date)\r\n                             From PriceHistory PH2\r\n                             Where PH2.AssetId = " + AssetID + "\r\n                         )\r\n                       )\r\n               WHERE Id = " + AssetID;
		db.ExecuteNonQuery(sQL);
	}

	~DatabaseLayer()
	{
		base.Finalize();
	}
}
