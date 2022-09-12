using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Caliburn.Micro;
using ServiceStack.DataAnnotations;

namespace xbot_wpf.Models;

public class Item : PropertyChangedBase, IEntity<int>, IEntity
{
	private bool bool_0;

	private ItemsType itemsType_0;

	private int int_0;

	private int int_1;

	private ItemsSelect itemsSelect_0;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private float float_1;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[AutoIncrement]
	[PrimaryKey]
	public int Id
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public string Link
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string ProfitabilityMessageText
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public ItemsType Profitability
	{
		get
		{
			return itemsType_0;
		}
		set
		{
			itemsType_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<ItemsType>((Expression<Func<ItemsType>>)(() => Profitability));
		}
	}

	public ItemsSelect Selection
	{
		get
		{
			return itemsSelect_0;
		}
		set
		{
			itemsSelect_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<ItemsSelect>((Expression<Func<ItemsSelect>>)(() => Selection));
		}
	}

	public bool Analytics
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => Analytics));
		}
	}

	public int CountOfSells
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountOfSells));
		}
	}

	public int CountOfBuys
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountOfBuys));
		}
	}

	public float MaxOrderThreshold
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
		[CompilerGenerated]
		set
		{
			float_0 = value;
		}
	}

	public float MinOrderThreshold
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
		[CompilerGenerated]
		set
		{
			float_1 = value;
		}
	}

	public long ClassId
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

	public long InstanceId
	{
		[CompilerGenerated]
		get
		{
			return long_1;
		}
		[CompilerGenerated]
		set
		{
			long_1 = value;
		}
	}

	public bool TitleClick
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	[NotMapped]
	public override bool IsNotifying
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public Item()
	{
		Class24.nhQmSIPz7n4eU();
		((PropertyChangedBase)this)._002Ector();
	}
}
