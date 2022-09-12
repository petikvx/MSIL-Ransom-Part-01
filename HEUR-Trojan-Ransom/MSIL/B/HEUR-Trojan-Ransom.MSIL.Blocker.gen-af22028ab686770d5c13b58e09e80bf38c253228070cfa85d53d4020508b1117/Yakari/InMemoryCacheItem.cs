using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace Yakari;

public class InMemoryCacheItem
{
	private long _hitCount;

	public bool Slidable { get; set; }

	public dynamic ValueObject { get; set; }

	public DateTime ExpireDateUtc { get; set; }

	public DateTime CreatedDateUtc { get; set; }

	public long HitCount => Interlocked.Read(ref _hitCount);

	public bool IsExpired => DateTime.UtcNow > ExpireDateUtc;

	public TimeSpan ExpiresAtTimeSpan => ExpireDateUtc.Subtract(DateTime.UtcNow);

	public InMemoryCacheItem()
	{
	}

	private InMemoryCacheItem(bool slidable)
	{
		CreatedDateUtc = DateTime.UtcNow;
		Slidable = slidable;
	}

	public InMemoryCacheItem(dynamic valueObject, DateTime expiresAt, bool slidable = false)
		: this(slidable)
	{
		ValueObject = (object)valueObject;
		ExpireDateUtc = expiresAt;
	}

	public InMemoryCacheItem(dynamic valueObject, TimeSpan expiresAfter, bool slidable = false)
		: this(slidable)
	{
		ValueObject = (object)valueObject;
		ExpireDateUtc = CreatedDateUtc.Add(expiresAfter);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is InMemoryCacheItem inMemoryCacheItem))
		{
			return false;
		}
		if (_003C_003Eo__23._003C_003Ep__0 == null)
		{
			int operation = Convert.ToInt32(13.0);
			Type typeFromHandle = typeof(InMemoryCacheItem);
			CSharpArgumentInfo[] array = new CSharpArgumentInfo[Convert.ToInt32(2.0 - Math.Log10(1.0))];
			array[0] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
			array[1] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
			_003C_003Eo__23._003C_003Ep__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, (ExpressionType)operation, typeFromHandle, array));
		}
		return (dynamic)_003C_003Eo__23._003C_003Ep__0.Target(_003C_003Eo__23._003C_003Ep__0, (object)ValueObject, (object)inMemoryCacheItem.ValueObject);
	}

	public override int GetHashCode()
	{
		return ValueObject.GetHashCode();
	}

	public void Hit()
	{
		Interlocked.Increment(ref _hitCount);
	}

	public void Slide(TimeSpan slideFor)
	{
		ExpireDateUtc = DateTime.UtcNow.Add(slideFor);
	}

	public bool WillBeExpired(TimeSpan after)
	{
		return DateTime.UtcNow.Add(after) > ExpireDateUtc;
	}

	public bool WillBeExpired(DateTime at)
	{
		return at > ExpireDateUtc;
	}
}
