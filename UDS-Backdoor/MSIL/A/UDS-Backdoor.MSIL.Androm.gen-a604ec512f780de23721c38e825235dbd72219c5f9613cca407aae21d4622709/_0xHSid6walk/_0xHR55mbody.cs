using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using Microsoft.VisualStudio.WindowsAzure.ComponentModel;
using _0xHOctav6;

namespace _0xHSid6walk;

internal class _0xHR55mbody<ItemType, WrapperType> : ObservableObject, IList<WrapperType>, ICollection<WrapperType>, IEnumerable<WrapperType>, INotifyCollectionChanged, IDisposable, IEnumerable, IList, ICollection
{
	private IEnumerable<ItemType> _0xHT88nies;

	private Func<ItemType, WrapperType> _0xHW8tans;

	private bool _0xHWhi7ey;

	private IList<WrapperType> _0xHInterlining7;

	private _0xHUn8eemline88e8 _0xHBo1s;

	public int Count => this._wrappers.Count;

	public bool IsReadOnly => true;

	public WrapperType this[int index]
	{
		get
		{
			return this._wrappers[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool IsFixedSize => false;

	object IList.this[int index]
	{
		get
		{
			return this._wrappers[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public event NotifyCollectionChangedEventHandler CollectionChanged;

	public _0xHR55mbody(IEnumerable<ItemType> wrappedItems, Func<ItemType, WrapperType> wrapperFunc)
		: this(wrappedItems, wrapperFunc, ownWrappers: false)
	{
	}

	public _0xHR55mbody(IEnumerable<ItemType> wrappedItems, Func<ItemType, WrapperType> wrapperFunc, bool ownWrappers)
	{
		this._wrappers = new List<WrapperType>();
		((ObservableObject)this)._002Ector();
		if (wrappedItems == null)
		{
			throw new ArgumentNullException("wrappedItems");
		}
		if (wrapperFunc == null)
		{
			throw new ArgumentNullException("wrapperFunc");
		}
		this._wrappedItems = wrappedItems;
		this._wrapperFunc = wrapperFunc;
		this._ownWrappers = ownWrappers;
		this.Refresh();
		if (wrappedItems is INotifyPropertyChanged notifyPropertyChanged)
		{
			notifyPropertyChanged.PropertyChanged += this.OnWrappedItemsPropertyChanged;
		}
		if (wrappedItems is INotifyCollectionChanged source)
		{
			this._listener = new _0xHUn8eemline88e8(source);
			this._listener.CollectionChanged += this.OnCollectionChanged;
		}
	}

	public IEnumerator<WrapperType> _0xH5lasnost()
	{
		return this._wrappers.GetEnumerator();
	}

	private IEnumerator _0xH2lattering()
	{
		return this._wrappers.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xH2lattering
		return this._0xH2lattering();
	}

	public void _0xH2ack(WrapperType _0xHJa44er)
	{
		throw new NotSupportedException();
	}

	public void _0xHCr3pt()
	{
		throw new NotSupportedException();
	}

	public bool _0xHRag6ut(WrapperType _0xHMorbidi6ies)
	{
		return this._wrappers.Contains(_0xHMorbidi6ies);
	}

	public void _0xHGass5r(WrapperType[] _0xHPolemi6ize, int _0xHF7stinat7ly)
	{
		this._wrappers.CopyTo(_0xHPolemi6ize, _0xHF7stinat7ly);
	}

	public bool _0xHPyrogenici4y(WrapperType _0xHBas5njis)
	{
		throw new NotSupportedException();
	}

	public int _0xHCollectivi8t8(WrapperType _0xHCo66les)
	{
		return this._wrappers.IndexOf(_0xHCo66les);
	}

	public void _0xHSuperhe0vy(int _0xH2attles, WrapperType _0xHCr6ollos)
	{
		throw new NotSupportedException();
	}

	public void _0xHU5trapped(int _0xH3eentsier)
	{
		throw new NotSupportedException();
	}

	public int _0xHWoma3isi3g(object _0xHLab3uring)
	{
		throw new NotSupportedException();
	}

	private void _0xHLumines7ed()
	{
		throw new NotSupportedException();
	}

	void IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xHLumines7ed
		this._0xHLumines7ed();
	}

	public bool _0xHW0impers(object _0xHSam5el)
	{
		if (_0xHSam5el is WrapperType)
		{
			return this.Contains((WrapperType)_0xHSam5el);
		}
		return false;
	}

	public void _0xHSn1rter(object _0xHZido8udine)
	{
		throw new NotSupportedException();
	}

	private void _0xHMi55esi5gers(int _0xH3ooses)
	{
		throw new NotSupportedException();
	}

	void IList.RemoveAt(int _0xH3ooses)
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xHMi55esi5gers
		this._0xHMi55esi5gers(_0xH3ooses);
	}

	public int _0xHAuthoriz6rs(object _0xHT3norists)
	{
		if (_0xHT3norists is WrapperType)
		{
			return this._wrappers.IndexOf((WrapperType)_0xHT3norists);
		}
		return -1;
	}

	public void _0xHCo4panionways(int _0xHMortu1ry, object _0xHExp8icates)
	{
		throw new NotSupportedException();
	}

	public void _0xHE8purgatorial(Array _0xHDrau7htsmen, int _0xHC7coethes)
	{
		((IList)this._wrappers).CopyTo(_0xHDrau7htsmen, _0xHC7coethes);
	}

	public void _0xHMonishe4()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (this._listener != null)
			{
				this._listener._0xHOverdosi6g();
				this._listener = null;
			}
			if (this._wrappers != null)
			{
				this.ClearWrappers();
				this._wrappers = null;
			}
			if (this._wrappedItems is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= this.OnWrappedItemsPropertyChanged;
			}
			this._wrappedItems = null;
			this._wrapperFunc = null;
		}
	}

	private void _0xHLime8aters(object sender, NotifyCollectionChangedEventArgs e)
	{
		switch (e.Action)
		{
		case NotifyCollectionChangedAction.Add:
		{
			int num = e.NewStartingIndex;
			if (num >= 0 && num <= this._wrappers.Count)
			{
				int num2 = 0;
				while (num2 < e.NewItems!.Count)
				{
					this._wrappers.Insert(num, this._wrapperFunc((ItemType)e.NewItems![num2]));
					num2++;
					num++;
				}
				this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, this._wrappers.Skip(e.NewStartingIndex).Take(e.NewItems!.Count).ToList(), e.NewStartingIndex));
			}
			else
			{
				this.Refresh();
			}
			break;
		}
		case NotifyCollectionChangedAction.Remove:
			if (e.OldStartingIndex >= 0)
			{
				List<WrapperType> changedItems = this._wrappers.Skip(e.OldStartingIndex).Take(e.OldItems!.Count).ToList();
				for (int k = 0; k < e.OldItems!.Count; k++)
				{
					this.RemoveWrapper(e.OldStartingIndex);
				}
				this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changedItems, e.OldStartingIndex));
			}
			else
			{
				this.Refresh();
			}
			break;
		case NotifyCollectionChangedAction.Move:
			if (e.OldStartingIndex >= 0 && e.NewStartingIndex >= 0)
			{
				for (int i = 0; i < e.OldItems!.Count; i++)
				{
					this.RemoveWrapper(e.OldStartingIndex);
				}
				for (int j = 0; j < e.NewItems!.Count; j++)
				{
					this._wrappers.Insert(e.NewStartingIndex + j, this._wrapperFunc((ItemType)e.NewItems![j]));
				}
				this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move, e.OldItems, e.NewStartingIndex, e.OldStartingIndex));
			}
			else
			{
				this.Refresh();
			}
			break;
		case NotifyCollectionChangedAction.Reset:
			this.Refresh();
			break;
		case NotifyCollectionChangedAction.Replace:
			break;
		}
	}

	private void _0xH8ulldogger(object sender, PropertyChangedEventArgs e)
	{
		((ObservableObject)this).NotifyPropertyChanged(e.PropertyName);
	}

	private void _0xHUnrecogni1ably()
	{
		this.ClearWrappers();
		foreach (ItemType wrappedItem in this._wrappedItems)
		{
			this._wrappers.Add(this._wrapperFunc(wrappedItem));
		}
		this.NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	private void _0xHUn4ndurabl4(int _0xHPh6sphids)
	{
		WrapperType val = this._wrappers[_0xHPh6sphids];
		this._wrappers.RemoveAt(_0xHPh6sphids);
		if (this._ownWrappers && (object)val is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}

	private void _0xHOb5ervation5()
	{
		if (this._ownWrappers)
		{
			foreach (IDisposable item in this._wrappers.OfType<IDisposable>())
			{
				item.Dispose();
			}
		}
		this._wrappers.Clear();
	}

	private void _0xHT2nch(NotifyCollectionChangedEventArgs _0xHSubjecti6ists)
	{
		this.CollectionChanged?.Invoke(this, _0xHSubjecti6ists);
	}
}
