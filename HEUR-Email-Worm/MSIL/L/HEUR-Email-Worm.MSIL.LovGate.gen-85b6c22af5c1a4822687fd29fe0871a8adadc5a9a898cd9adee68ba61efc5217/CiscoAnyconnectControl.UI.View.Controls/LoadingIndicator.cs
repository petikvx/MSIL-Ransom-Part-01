using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace CiscoAnyconnectControl.UI.View.Controls;

[TemplatePart(Name = "Border", Type = typeof(Border))]
public class LoadingIndicator : Control
{
	public static readonly DependencyProperty SpeedRatioProperty = LoadingIndicator.smethod_17("SpeedRatio", LoadingIndicator.smethod_15(typeof(double).TypeHandle), LoadingIndicator.smethod_15(typeof(LoadingIndicator).TypeHandle), LoadingIndicator.smethod_16((object)1.0, (PropertyChangedCallback)delegate(DependencyObject o, DependencyPropertyChangedEventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		LoadingIndicator loadingIndicator2 = (LoadingIndicator)(object)o;
		if (loadingIndicator2.PART_Border != null && loadingIndicator2.IsActive)
		{
			IEnumerator enumerator3 = _003C_003Ec.smethod_1((IEnumerable)_003C_003Ec.smethod_0((FrameworkElement)(object)loadingIndicator2.PART_Border));
			try
			{
				while (_003C_003Ec.smethod_9(enumerator3))
				{
					VisualStateGroup visualStateGroup_2 = (VisualStateGroup)_003C_003Ec.smethod_2(enumerator3);
					if (_003C_003Ec.smethod_4(_003C_003Ec.smethod_3(visualStateGroup_2), "ActiveStates"))
					{
						IEnumerator enumerator4 = _003C_003Ec.smethod_1((IEnumerable)_003C_003Ec.smethod_5(visualStateGroup_2));
						try
						{
							while (_003C_003Ec.smethod_9(enumerator4))
							{
								VisualState visualState_2 = (VisualState)_003C_003Ec.smethod_2(enumerator4);
								if (_003C_003Ec.smethod_4(_003C_003Ec.smethod_6(visualState_2), "Active"))
								{
									_003C_003Ec.smethod_8(_003C_003Ec.smethod_7(visualState_2), (FrameworkElement)(object)loadingIndicator2.PART_Border, (double)((DependencyPropertyChangedEventArgs)(ref e)).get_NewValue());
								}
							}
						}
						finally
						{
							if (enumerator4 is IDisposable idisposable_3)
							{
								_003C_003Ec.smethod_10(idisposable_3);
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator3 is IDisposable idisposable_4)
				{
					_003C_003Ec.smethod_10(idisposable_4);
				}
			}
		}
	}));

	public static readonly DependencyProperty IsActiveProperty = LoadingIndicator.smethod_17("IsActive", LoadingIndicator.smethod_15(typeof(bool).TypeHandle), LoadingIndicator.smethod_15(typeof(LoadingIndicator).TypeHandle), LoadingIndicator.smethod_16((object)true, (PropertyChangedCallback)delegate(DependencyObject o, DependencyPropertyChangedEventArgs e)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		LoadingIndicator loadingIndicator = (LoadingIndicator)(object)o;
		if (loadingIndicator.PART_Border != null)
		{
			if ((bool)((DependencyPropertyChangedEventArgs)(ref e)).get_NewValue())
			{
				_003C_003Ec.smethod_11((FrameworkElement)(object)loadingIndicator.PART_Border, "Active", bool_0: false);
				_003C_003Ec.smethod_12((UIElement)(object)loadingIndicator.PART_Border, (Visibility)0);
				IEnumerator enumerator = _003C_003Ec.smethod_1((IEnumerable)_003C_003Ec.smethod_0((FrameworkElement)(object)loadingIndicator.PART_Border));
				try
				{
					while (_003C_003Ec.smethod_9(enumerator))
					{
						VisualStateGroup visualStateGroup_ = (VisualStateGroup)_003C_003Ec.smethod_2(enumerator);
						if (_003C_003Ec.smethod_4(_003C_003Ec.smethod_3(visualStateGroup_), "ActiveStates"))
						{
							IEnumerator enumerator2 = _003C_003Ec.smethod_1((IEnumerable)_003C_003Ec.smethod_5(visualStateGroup_));
							try
							{
								while (_003C_003Ec.smethod_9(enumerator2))
								{
									VisualState visualState_ = (VisualState)_003C_003Ec.smethod_2(enumerator2);
									if (_003C_003Ec.smethod_4(_003C_003Ec.smethod_6(visualState_), "Active"))
									{
										_003C_003Ec.smethod_8(_003C_003Ec.smethod_7(visualState_), (FrameworkElement)(object)loadingIndicator.PART_Border, loadingIndicator.SpeedRatio);
									}
								}
							}
							finally
							{
								if (enumerator2 is IDisposable idisposable_)
								{
									_003C_003Ec.smethod_10(idisposable_);
								}
							}
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable idisposable_2)
					{
						_003C_003Ec.smethod_10(idisposable_2);
					}
				}
			}
			_003C_003Ec.smethod_11((FrameworkElement)(object)loadingIndicator.PART_Border, "Inactive", bool_0: false);
			_003C_003Ec.smethod_12((UIElement)(object)loadingIndicator.PART_Border, (Visibility)2);
		}
	}));

	protected Border PART_Border;

	public double SpeedRatio
	{
		get
		{
			return (double)LoadingIndicator.smethod_0((DependencyObject)(object)this, SpeedRatioProperty);
		}
		set
		{
			LoadingIndicator.smethod_1((DependencyObject)(object)this, SpeedRatioProperty, (object)value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)LoadingIndicator.smethod_0((DependencyObject)(object)this, IsActiveProperty);
		}
		set
		{
			LoadingIndicator.smethod_1((DependencyObject)(object)this, IsActiveProperty, (object)value);
		}
	}

	public override void OnApplyTemplate()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		this.method_0();
		PART_Border = (Border)((FrameworkElement)this).GetTemplateChild("PART_Border");
		if (PART_Border == null)
		{
			return;
		}
		LoadingIndicator.smethod_2((FrameworkElement)(object)PART_Border, IsActive ? "Active" : "Inactive", bool_0: false);
		IEnumerator enumerator = LoadingIndicator.smethod_4((IEnumerable)LoadingIndicator.smethod_3((FrameworkElement)(object)PART_Border));
		try
		{
			while (LoadingIndicator.smethod_12(enumerator))
			{
				VisualStateGroup visualStateGroup_ = (VisualStateGroup)LoadingIndicator.smethod_5(enumerator);
				if (!LoadingIndicator.smethod_7(LoadingIndicator.smethod_6(visualStateGroup_), "ActiveStates"))
				{
					continue;
				}
				IEnumerator enumerator2 = LoadingIndicator.smethod_4((IEnumerable)LoadingIndicator.smethod_8(visualStateGroup_));
				try
				{
					while (LoadingIndicator.smethod_12(enumerator2))
					{
						VisualState visualState_ = (VisualState)LoadingIndicator.smethod_5(enumerator2);
						if (LoadingIndicator.smethod_7(LoadingIndicator.smethod_9(visualState_), "Active"))
						{
							LoadingIndicator.smethod_11(LoadingIndicator.smethod_10(visualState_), (FrameworkElement)(object)PART_Border, SpeedRatio);
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable idisposable_)
					{
						LoadingIndicator.smethod_13(idisposable_);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable idisposable_2)
			{
				LoadingIndicator.smethod_13(idisposable_2);
			}
		}
		LoadingIndicator.smethod_14((UIElement)(object)PART_Border, (Visibility)((!IsActive) ? 2 : 0));
	}

	static object smethod_0(DependencyObject dependencyObject_0, DependencyProperty dependencyProperty_0)
	{
		return dependencyObject_0.GetValue(dependencyProperty_0);
	}

	static void smethod_1(DependencyObject dependencyObject_0, DependencyProperty dependencyProperty_0, object object_0)
	{
		dependencyObject_0.SetValue(dependencyProperty_0, object_0);
	}

	void method_0()
	{
		((FrameworkElement)this).OnApplyTemplate();
	}

	static bool smethod_2(FrameworkElement frameworkElement_0, string string_0, bool bool_0)
	{
		return VisualStateManager.GoToElementState(frameworkElement_0, string_0, bool_0);
	}

	static IList smethod_3(FrameworkElement frameworkElement_0)
	{
		return VisualStateManager.GetVisualStateGroups(frameworkElement_0);
	}

	static IEnumerator smethod_4(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	static object smethod_5(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static string smethod_6(VisualStateGroup visualStateGroup_0)
	{
		return visualStateGroup_0.get_Name();
	}

	static bool smethod_7(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static IList smethod_8(VisualStateGroup visualStateGroup_0)
	{
		return visualStateGroup_0.get_States();
	}

	static string smethod_9(VisualState visualState_0)
	{
		return visualState_0.get_Name();
	}

	static Storyboard smethod_10(VisualState visualState_0)
	{
		return visualState_0.get_Storyboard();
	}

	static void smethod_11(Storyboard storyboard_0, FrameworkElement frameworkElement_0, double double_0)
	{
		storyboard_0.SetSpeedRatio(frameworkElement_0, double_0);
	}

	static bool smethod_12(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_13(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_14(UIElement uielement_0, Visibility visibility_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		uielement_0.set_Visibility(visibility_0);
	}

	static Type smethod_15(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static PropertyMetadata smethod_16(object object_0, PropertyChangedCallback propertyChangedCallback_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new PropertyMetadata(object_0, propertyChangedCallback_0);
	}

	static DependencyProperty smethod_17(string string_0, Type type_0, Type type_1, PropertyMetadata propertyMetadata_0)
	{
		return DependencyProperty.Register(string_0, type_0, type_1, propertyMetadata_0);
	}
}
