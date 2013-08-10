using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
  internal class PropertyGrid : System.Windows.Forms.PropertyGrid
  {
    #region Members

    public GridItem FindItem(string itemLabel)
    {
      // http://www.vb-helper.com/howto_net_select_propertygrid_item.html

      GridItem rootItem;
      GridItem matchingItem;
      List<GridItem> searchItems;

      matchingItem = null;

      // Find the GridItem root.
      rootItem = this.SelectedGridItem;
      while (rootItem.Parent != null)
        rootItem = rootItem.Parent;

      // Search the tree.
      searchItems = new List<GridItem>();
      searchItems.Add(rootItem);

      while (searchItems.Count != 0 || matchingItem == null)
      {
        GridItem checkItem;

        checkItem = searchItems[0];
        searchItems.RemoveAt(0);
        if (checkItem.Label == itemLabel)
          matchingItem = checkItem;

        searchItems.AddRange(checkItem.GridItems.Cast<GridItem>());
      }

      return matchingItem;
    }

    public void SelectItem(string itemLabel)
    {
      GridItem selection;

      selection = this.FindItem(itemLabel);
      if (selection != null)
      {
        try
        {
          this.SelectedGridItem = selection;
        }
        catch
        {
          // ignore
        }
      }
    }

    #endregion
  }
}
