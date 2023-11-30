using System.Collections;
using Microsoft.Maui.Controls.Handlers.Items;

namespace ReorderableCollectionView.Maui
{
	public interface IGroupedItemsViewSource : IGroupableItemsViewSource
	{
        new (int, int) GetGroupAndIndex(int position);
        new object GetGroup(int groupIndex);
        new IItemsViewSource GetGroupItemsViewSource(int groupIndex);
	}
}