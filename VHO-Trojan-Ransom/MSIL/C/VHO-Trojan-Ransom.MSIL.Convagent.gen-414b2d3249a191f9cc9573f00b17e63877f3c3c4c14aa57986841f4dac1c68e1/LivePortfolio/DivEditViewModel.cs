using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

public class DivEditViewModel : ViewModelBase
{
	private ListDividend _SelectedDividend;

	private Collection _Assets;

	private Asset _SelectedAsset;

	private SVCCommand _Commit;

	private List<ComboItem> _DividendStatuses;

	private List<ComboItem> _DividendTypes;

	private ComboItem _DividendType;

	private ComboItem _DividendStatus;

	public SVCCommand Commit => _Commit;

	public ListDividend SelectedDividend
	{
		get
		{
			return _SelectedDividend;
		}
		set
		{
			_SelectedDividend = value;
			NotifyPropertyChanged("SelectedDividend");
		}
	}

	public Collection Assets => _Assets;

	public Asset SelectedAsset
	{
		get
		{
			return _SelectedAsset;
		}
		set
		{
			_SelectedAsset = value;
		}
	}

	public List<ComboItem> DividendStatuses => _DividendStatuses;

	public List<ComboItem> DividendTypes => _DividendTypes;

	public ComboItem DividendType
	{
		get
		{
			return _DividendType;
		}
		set
		{
			_DividendType = value;
		}
	}

	public ComboItem DividendStatus
	{
		get
		{
			return _DividendStatus;
		}
		set
		{
			_DividendStatus = value;
		}
	}

	public DivEditViewModel(ListDividend D)
	{
		_Commit = new SVCCommand(CommitData);
		_DividendStatuses = new List<ComboItem>();
		_DividendTypes = new List<ComboItem>();
		_SelectedDividend = D;
		PopulateAssets();
		PopulateLists();
		_SelectedAsset = (Asset)_Assets.get_Item(D.AssetId.ToString());
	}

	private void PopulateLists()
	{
		_DividendStatuses.Clear();
		List<ComboItem> dividendStatuses = _DividendStatuses;
		dividendStatuses.Add(new ComboItem("Estimate"));
		dividendStatuses.Add(new ComboItem("Actual"));
		dividendStatuses = null;
		_DividendStatus = _DividendStatuses[0];
		_DividendTypes.Clear();
		List<ComboItem> dividendTypes = _DividendTypes;
		dividendTypes.Add(new ComboItem("Final"));
		dividendTypes.Add(new ComboItem("Interim"));
		dividendTypes.Add(new ComboItem("Special"));
		dividendTypes.Add(new ComboItem("Other"));
		dividendTypes = null;
		_DividendType = DividendTypes[0];
	}

	private void PopulateAssets()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		new StringBuilder();
		_Assets = new Collection();
		DatabaseLayer databaseLayer = new DatabaseLayer();
		DataTable dataTable = new DataTable();
		dataTable = databaseLayer.GetAssetList();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				Asset asset = new Asset(Conversions.ToInteger(dataRow["Id"]), Conversions.ToString(dataRow["Ticker"]), Conversions.ToString(dataRow["Name"]));
				_Assets.Add((object)asset, dataRow["Id"].ToString(), (object)null, (object)null);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		_SelectedAsset = (Asset)_Assets.get_Item(1);
		NotifyPropertyChanged("SelectedAsset");
		NotifyPropertyChanged("Assets");
	}

	private void CommitData()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		DatabasePrimitives databasePrimitives = new DatabasePrimitives();
		string text = "INSERT OR REPLACE INTO Dividend(Payment,ExDividend,AssetId,Amount,Type,Status) Values ('" + Strings.Format((object)SelectedDividend.Payment, "yyyy-MM-dd") + "','" + Strings.Format((object)SelectedDividend.ExDividend, "yyyy-MM-dd") + "'," + Conversions.ToString(SelectedAsset.Id) + "," + Conversions.ToString(SelectedDividend.Amount) + ",'" + _DividendType.ItemText + "','" + _DividendStatus.ItemText + "');";
		Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
		databasePrimitives.ExecuteScalar(text);
	}
}
