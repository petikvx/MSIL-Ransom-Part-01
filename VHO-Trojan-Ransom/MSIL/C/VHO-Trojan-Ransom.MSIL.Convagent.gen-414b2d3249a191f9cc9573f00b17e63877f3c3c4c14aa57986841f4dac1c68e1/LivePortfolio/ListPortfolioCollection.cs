using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace LivePortfolio;

public class ListPortfolioCollection : ObservableCollection<ListPortfolio>
{
	public delegate void ItemPropertyChangedEventHandler(ListPortfolio sender, PropertyChangedEventArgs e);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ItemPropertyChangedEventHandler ItemPropertyChangedEvent;

	public event ItemPropertyChangedEventHandler ItemPropertyChanged
	{
		[CompilerGenerated]
		add
		{
			ItemPropertyChangedEventHandler itemPropertyChangedEventHandler = ItemPropertyChangedEvent;
			ItemPropertyChangedEventHandler itemPropertyChangedEventHandler2;
			do
			{
				itemPropertyChangedEventHandler2 = itemPropertyChangedEventHandler;
				ItemPropertyChangedEventHandler value2 = (ItemPropertyChangedEventHandler)Delegate.Combine(itemPropertyChangedEventHandler2, value);
				itemPropertyChangedEventHandler = Interlocked.CompareExchange(ref ItemPropertyChangedEvent, value2, itemPropertyChangedEventHandler2);
			}
			while ((object)itemPropertyChangedEventHandler != itemPropertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ItemPropertyChangedEventHandler itemPropertyChangedEventHandler = ItemPropertyChangedEvent;
			ItemPropertyChangedEventHandler itemPropertyChangedEventHandler2;
			do
			{
				itemPropertyChangedEventHandler2 = itemPropertyChangedEventHandler;
				ItemPropertyChangedEventHandler value2 = (ItemPropertyChangedEventHandler)Delegate.Remove(itemPropertyChangedEventHandler2, value);
				itemPropertyChangedEventHandler = Interlocked.CompareExchange(ref ItemPropertyChangedEvent, value2, itemPropertyChangedEventHandler2);
			}
			while ((object)itemPropertyChangedEventHandler != itemPropertyChangedEventHandler2);
		}
	}

	protected override void InsertItem(int index, ListPortfolio Item)
	{
		Item.PropertyChanged += Item_PropertyChanged;
		base.InsertItem(index, Item);
	}

	protected override void RemoveItem(int index)
	{
		base[index].PropertyChanged -= Item_PropertyChanged;
		base.RemoveItem(index);
	}

	public void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		ItemPropertyChangedEvent?.Invoke((ListPortfolio)sender, e);
	}
}
