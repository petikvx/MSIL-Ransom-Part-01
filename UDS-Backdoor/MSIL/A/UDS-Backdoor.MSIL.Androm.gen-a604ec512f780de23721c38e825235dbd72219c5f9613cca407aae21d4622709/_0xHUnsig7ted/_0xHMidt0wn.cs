using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using _0xHDrople4s;

namespace _0xHUnsig7ted;

public static class _0xHMidt0wn
{
	public static readonly DependencyProperty _0xHAlea2ory = DependencyProperty.RegisterAttached("CanUserSortColumnsWithValidationErrors", typeof(bool), typeof(_0xHMidt0wn), (PropertyMetadata)new UIPropertyMetadata((object)true, new PropertyChangedCallback(_0xHIka2)));

	public static readonly DependencyProperty _0xH8nviolateness = DependencyProperty.RegisterAttached("SingleClickEditing", typeof(bool), typeof(_0xHMidt0wn), (PropertyMetadata)new UIPropertyMetadata((object)false, new PropertyChangedCallback(_0xHPro2ona2ed)));

	internal static bool _0xHPa66ia6(this DataGridCell _0xHReana7yzing)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		if (_0xHReana7yzing != null && !_0xHReana7yzing.get_IsEditing() && !_0xHReana7yzing.get_IsReadOnly())
		{
			if (!((UIElement)_0xHReana7yzing).get_IsFocused())
			{
				((UIElement)_0xHReana7yzing).Focus();
			}
			DataGrid val = ((DependencyObject)(object)_0xHReana7yzing)._0xH0ppers<DataGrid>();
			if (val != null)
			{
				if ((int)val.get_SelectionUnit() != 1)
				{
					if (!_0xHReana7yzing.get_IsSelected())
					{
						_0xHReana7yzing.set_IsSelected(true);
					}
				}
				else
				{
					DataGridRow val2 = ((DependencyObject)(object)_0xHReana7yzing)._0xH0ppers<DataGridRow>();
					if (val2 != null && !val2.get_IsSelected())
					{
						val2.set_IsSelected(true);
					}
				}
			}
			return true;
		}
		return false;
	}

	internal static DataGridRow _0xHCa7so(this DataGrid _0xH8arcasses, object _0xH6nselected)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (_0xH8arcasses == null)
		{
			throw new ArgumentNullException("ownerGrid", "You must pass in the owner datagrid.");
		}
		DataGridRow val = (DataGridRow)((ItemsControl)_0xH8arcasses).get_ItemContainerGenerator().ContainerFromItem(_0xH6nselected);
		if (val == null)
		{
			_0xH8arcasses.ScrollIntoView(_0xH6nselected);
			val = (DataGridRow)((ItemsControl)_0xH8arcasses).get_ItemContainerGenerator().ContainerFromItem(_0xH6nselected);
		}
		return val;
	}

	internal static DataGridCell _0xHBee1hes(this DataGrid _0xHR7stl7ss, DataGridCellInfo _0xHNa5elles)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		if (_0xHR7stl7ss == null)
		{
			throw new ArgumentNullException("ownerGrid", "You must pass in the owner datagrid.");
		}
		if (((DataGridCellInfo)(ref _0xHNa5elles)).get_IsValid())
		{
			DataGridRow val = _0xHR7stl7ss._0xHCa7so(((DataGridCellInfo)(ref _0xHNa5elles)).get_Item());
			if (val != null)
			{
				DataGridCellsPresenter val2 = ((DependencyObject)(object)val)._0xHUnbe5r5ble<DataGridCellsPresenter>();
				int displayIndex = ((DataGridCellInfo)(ref _0xHNa5elles)).get_Column().get_DisplayIndex();
				DataGridCell val3 = (DataGridCell)((ItemsControl)val2).get_ItemContainerGenerator().ContainerFromIndex(displayIndex);
				if (val3 == null)
				{
					_0xHR7stl7ss.ScrollIntoView((object)val, _0xHR7stl7ss.get_Columns()[displayIndex]);
					val3 = (DataGridCell)((ItemsControl)val2).get_ItemContainerGenerator().ContainerFromIndex(displayIndex);
				}
				return val3;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1011", Justification = "Only intended for use with DataGrid")]
	public static bool _0xHS7ulling(this DataGrid _0xHZipp3r3d)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		int num = 0;
		while (true)
		{
			if (num < ((CollectionView)((ItemsControl)_0xHZipp3r3d).get_Items()).get_Count())
			{
				if (Validation.GetHasError((DependencyObject)(DataGridRow)((ItemsControl)_0xHZipp3r3d).get_ItemContainerGenerator().ContainerFromIndex(num)))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[SuppressMessage("Microsoft.Design", "CA1011", Justification = "Only intended for use with DataGrid")]
	public static bool _0xHCo77ence7ent(DataGrid _0xHGen7typical)
	{
		return (bool)((DependencyObject)_0xHGen7typical).GetValue(_0xHAlea2ory);
	}

	[SuppressMessage("Microsoft.Design", "CA1011", Justification = "Only intended for use with DataGrid")]
	public static void _0xHVa4(DataGrid _0xHNe3tly, bool _0xH8kellums)
	{
		((DependencyObject)_0xHNe3tly).SetValue(_0xHAlea2ory, (object)_0xH8kellums);
	}

	private static void _0xHIka2(DependencyObject _0xH8ummerbunds, DependencyPropertyChangedEventArgs _0xHCrawfis4ed)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		DataGrid val = (DataGrid)(object)((_0xH8ummerbunds is DataGrid) ? _0xH8ummerbunds : null);
		if (val != null)
		{
			if (!(bool)((DependencyPropertyChangedEventArgs)(ref _0xHCrawfis4ed)).get_NewValue())
			{
				val.add_Sorting(new DataGridSortingEventHandler(_0xH1eriums));
			}
			else
			{
				val.remove_Sorting(new DataGridSortingEventHandler(_0xH1eriums));
			}
		}
	}

	private static void _0xH1eriums(object sender, DataGridSortingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		if (_0xHS7ulling((DataGrid)sender))
		{
			e.set_Handled(true);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011", Justification = "Only intended for use with DataGridCell")]
	public static bool _0xHKebbuck7(DataGridCell _0xHCub7id)
	{
		return (bool)((DependencyObject)_0xHCub7id).GetValue(_0xH8nviolateness);
	}

	[SuppressMessage("Microsoft.Design", "CA1011", Justification = "Only intended for use with DataGridCell")]
	public static void _0xH6elvet(DataGridCell _0xHP6eluso6y, bool _0xHMalath2on)
	{
		((DependencyObject)_0xHP6eluso6y).SetValue(_0xH8nviolateness, (object)_0xHMalath2on);
	}

	private static void _0xHPro2ona2ed(DependencyObject _0xHMo4geri4g, DependencyPropertyChangedEventArgs _0xHJocundit4)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		DataGridCell val = (DataGridCell)(object)((_0xHMo4geri4g is DataGridCell) ? _0xHMo4geri4g : null);
		if (val != null)
		{
			if ((bool)((DependencyPropertyChangedEventArgs)(ref _0xHJocundit4)).get_NewValue())
			{
				((UIElement)val).add_PreviewMouseLeftButtonDown(new MouseButtonEventHandler(_0xHF1ign1r));
				((UIElement)val).add_PreviewTextInput(new TextCompositionEventHandler(_0xHHor0ele00));
			}
			else
			{
				((UIElement)val).remove_PreviewMouseLeftButtonDown(new MouseButtonEventHandler(_0xHF1ign1r));
				((UIElement)val).remove_PreviewTextInput(new TextCompositionEventHandler(_0xHHor0ele00));
			}
		}
	}

	private static void _0xHF1ign1r(object sender, MouseButtonEventArgs e)
	{
		_0xHDith5ists((DataGridCell)((sender is DataGridCell) ? sender : null), (RoutedEventArgs)(object)e);
	}

	private static void _0xHHor0ele00(object sender, TextCompositionEventArgs e)
	{
		_0xHDith5ists((DataGridCell)((sender is DataGridCell) ? sender : null), (RoutedEventArgs)(object)e);
	}

	private static void _0xHDith5ists(DataGridCell _0xHRoc2ed, RoutedEventArgs _0xHTran5mitting)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		if (_0xHRoc2ed == null || _0xHRoc2ed.get_IsEditing() || _0xHRoc2ed.get_IsReadOnly())
		{
			return;
		}
		DataGrid val = ((DependencyObject)(object)_0xHRoc2ed)._0xH0ppers<DataGrid>();
		if (val == null)
		{
			return;
		}
		if (!((UIElement)_0xHRoc2ed).get_IsFocused())
		{
			((UIElement)_0xHRoc2ed).Focus();
		}
		if (((ContentControl)_0xHRoc2ed).get_Content() is ComboBox)
		{
			ComboBox val2 = (ComboBox)((ContentControl)_0xHRoc2ed).get_Content();
			val.BeginEdit(_0xHTran5mitting);
			((DispatcherObject)_0xHRoc2ed).get_Dispatcher().Invoke((DispatcherPriority)4, (Delegate)(Action)delegate
			{
			});
			val2.set_IsDropDownOpen(true);
			return;
		}
		((DispatcherObject)_0xHRoc2ed).get_Dispatcher().Invoke((DispatcherPriority)4, (Delegate)(Action)delegate
		{
		});
		if ((int)val.get_SelectionUnit() != 1)
		{
			if (!_0xHRoc2ed.get_IsSelected())
			{
				_0xHRoc2ed.set_IsSelected(true);
			}
		}
		else
		{
			DataGridRow val3 = ((DependencyObject)(object)_0xHRoc2ed)._0xH0ppers<DataGridRow>();
			if (val3 != null && !val3.get_IsSelected())
			{
				if ((int)val.get_SelectionMode() == 1)
				{
					((MultiSelector)val).get_SelectedItems().Clear();
				}
				val3.set_IsSelected(true);
			}
		}
		if (((ContentControl)_0xHRoc2ed).get_Content() is CheckBox)
		{
			try
			{
				val.BeginEdit(_0xHTran5mitting);
			}
			catch (NullReferenceException)
			{
			}
			_0xHTran5mitting.set_Handled(true);
		}
	}
}
