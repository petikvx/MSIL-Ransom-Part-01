#define DEBUG
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class AssetViewModel : ViewModelBase, INotifyPropertyChanged
{
	private bool Loading;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChangedEvent;

	private DatabasePrimitives db;

	private virtual AssetCollection _Assets
	{
		[CompilerGenerated]
		get
		{
			return __Assets;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			AssetCollection.ItemPropertyChangedEventHandler value2 = Asset_ItemPropertyChanged;
			NotifyCollectionChangedEventHandler value3 = AssetCollectionChanged;
			AssetCollection assetCollection = __Assets;
			if (assetCollection != null)
			{
				assetCollection.ItemPropertyChanged -= value2;
				assetCollection.CollectionChanged -= value3;
			}
			__Assets = value;
			assetCollection = __Assets;
			if (assetCollection != null)
			{
				assetCollection.ItemPropertyChanged += value2;
				assetCollection.CollectionChanged += value3;
			}
		}
	}

	public AssetCollection Assets
	{
		get
		{
			return _Assets;
		}
		set
		{
			_Assets = value;
		}
	}

	public new event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = PropertyChangedEvent;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref PropertyChangedEvent, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = PropertyChangedEvent;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref PropertyChangedEvent, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public AssetViewModel()
	{
		Loading = false;
		db = new DatabasePrimitives();
		DataTable dataTable = new DataTable();
		StringBuilder stringBuilder = new StringBuilder();
		_Assets = new AssetCollection();
		stringBuilder.Clear();
		stringBuilder.Append(" SELECT  [Id], ");
		stringBuilder.Append("         [Name], ");
		stringBuilder.Append("         [Ticker], ");
		stringBuilder.Append("         [AssetType], ");
		stringBuilder.Append("         [BidPrice], ");
		stringBuilder.Append("         [OfferPrice], ");
		stringBuilder.Append("         [Dividend], ");
		stringBuilder.Append("         [PriceEarnings], ");
		stringBuilder.Append("         [Updated], ");
		stringBuilder.Append("         CASE WHEN EXISTS (SELECT 'X' ");
		stringBuilder.Append("                   From HOLDING H ");
		stringBuilder.Append("                   WHERE H.AssetId = A.Id) Then 1 ");
		stringBuilder.Append("                   Else   0 ");
		stringBuilder.Append("         END As InPortfolio ");
		stringBuilder.Append("FROM     [Asset] A ");
		stringBuilder.Append("Order By Ticker ");
		dataTable = db.ExecuteQuery(stringBuilder.ToString());
		Loading = true;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Asset item = new Asset(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]), Conversions.ToString(dataRow["Assettype"]), Conversions.ToDecimal(dataRow["Bidprice"]), Conversions.ToDecimal(dataRow["OfferPrice"]), Conversions.ToDecimal(dataRow["Dividend"]), Conversions.ToDecimal(dataRow["PriceEarnings"]), Conversions.ToDate(dataRow["Updated"]), Conversions.ToBoolean(dataRow["InPortfolio"]));
				_Assets.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		Loading = false;
	}

	private void Asset_ItemPropertyChanged(Asset Sender, PropertyChangedEventArgs e)
	{
		string text = "'" + Strings.Format((object)DateAndTime.get_Today(), "yyyy-MM-dd") + "'";
		_ = Sender.Id;
		string sQL = "Update Asset SET Ticker='" + Sender.Ticker + "',\r\n                                        [Name]='" + Sender.Name + "',\r\n                                        AssetType='" + Sender.AssetType + "'\r\n                                        BidPrice=" + Conversions.ToString(Sender.Bid) + "\r\n                                        OfferPrice=" + Conversions.ToString(Sender.Offer) + "  \r\n                                        Dividend=" + Conversions.ToString(Sender.Dividend) + "\r\n                                        PriceEarnings=" + Conversions.ToString(Sender.PriceEarnings) + "\r\n                                        Updated=" + text + "\r\n                                        WHERE Id = " + Conversions.ToString(Sender.Id);
		db.ExecuteNonQuery(sQL);
	}

	private void AssetCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		switch (e.Action)
		{
		default:
			Interaction.MsgBox((object)("Collection Change Detected " + Conversions.ToString((int)e.Action)), (MsgBoxStyle)0, (object)null);
			break;
		case NotifyCollectionChangedAction.Remove:
			Interaction.MsgBox((object)"Row Delete Detected ", (MsgBoxStyle)0, (object)null);
			break;
		case NotifyCollectionChangedAction.Add:
			if (!Loading)
			{
				Debug.Print("New Row Detected");
			}
			break;
		}
	}

	private void AssetRowInserted(object sender, DataTableNewRowEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Row Change Detected \r\nAction was \r\nTicker: ", e.Row["Ticker"]), (object)e.GetType().ToString()), (MsgBoxStyle)0, (object)null);
	}
}
