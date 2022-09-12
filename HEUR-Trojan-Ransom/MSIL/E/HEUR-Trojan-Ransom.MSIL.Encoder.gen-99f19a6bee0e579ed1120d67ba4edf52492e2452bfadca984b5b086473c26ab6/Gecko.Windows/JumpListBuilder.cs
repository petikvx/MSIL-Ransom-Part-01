using Gecko.Collections;

namespace Gecko.Windows;

public sealed class JumpListBuilder
{
	private readonly nsIJumpListBuilder _jumpListBuilder;

	public short Available => _jumpListBuilder.GetAvailableAttribute();

	public bool IsListCommitted => _jumpListBuilder.GetIsListCommittedAttribute();

	public short tMaxListItems => _jumpListBuilder.GetMaxListItemsAttribute();

	internal JumpListBuilder(nsIJumpListBuilder jumpListBuilder)
	{
		_jumpListBuilder = jumpListBuilder;
	}

	public void AbortListBuild()
	{
		_jumpListBuilder.AbortListBuild();
	}

	public bool AddListToBuild(short aCatType, JumpListItem[] items, string catName)
	{
		nsIMutableArray array = GeckoCollectionsHelper.CreateArray();
		for (int i = 0; i < items.Length; i++)
		{
		}
		return nsString.Pass((nsAString x) => _jumpListBuilder.AddListToBuild(aCatType, array, x), catName);
	}

	public bool CommitListBuild()
	{
		return _jumpListBuilder.CommitListBuild();
	}

	public bool DeleteActiveList()
	{
		return _jumpListBuilder.DeleteActiveList();
	}

	public bool InitListBuild(out JumpListItem[] removedItems)
	{
		nsIMutableArray nsIMutableArray = GeckoCollectionsHelper.CreateArray();
		bool flag = _jumpListBuilder.InitListBuild(nsIMutableArray);
		removedItems = null;
		if (flag)
		{
			removedItems = new JumpListItem[nsIMutableArray.GetLengthAttribute()];
			for (int i = 0; i < removedItems.Length; i++)
			{
				removedItems[i] = new JumpListItem(nsIMutableArray.GetElementAs<nsIJumpListItem>(i));
			}
		}
		return flag;
	}
}
