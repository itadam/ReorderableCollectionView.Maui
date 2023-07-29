using System;
using AndroidX.RecyclerView.Widget;
using Microsoft.Maui.Controls.Handlers.Items;

namespace ReorderableCollectionView.Maui
{
	public partial class ReorderableCollectionViewHandler : GroupableItemsViewHandler<ReorderableCollectionView>
	{
		new protected ReorderableCollectionViewAdapter<ReorderableCollectionView, IGroupableItemsViewSource> CreateAdapter() => new(VirtualView);

		protected override RecyclerView CreatePlatformView() =>
			new ReorderableMauiRecyclerView<ReorderableCollectionView, ReorderableCollectionViewAdapter<ReorderableCollectionView, IGroupableItemsViewSource>, IGroupableItemsViewSource>(Context, GetItemsLayout, CreateAdapter);

        public static void MapCanReorderItems(ReorderableCollectionViewHandler handler, ReorderableCollectionView itemsView)
		{
			(handler.PlatformView as IReorderableMauiRecyclerView<ReorderableCollectionView>)?.UpdateCanReorderItems();
		}
	}
}