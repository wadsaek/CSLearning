namespace _08._12._2024;
public class ShoppingList{
    DynFixSizeArr items;
    string storeName;
    Date dateOfCreation;
    public ShoppingList(string storeName, Date dateOfCreation) {
        this.storeName = storeName;
        this.dateOfCreation = new Date(dateOfCreation);
        this.items = new DynFixSizeArr(10);
    }
    public string GetStoreName() {
        return storeName;
    }
    public Date GetDateOfCreation() {
        return new Date(dateOfCreation);
    }
    public Item? GetItem(int index) {
        Item? item = items.GetAt(index);
        if (item == null) {
            return null;
        }
        return new Item(item);
    }
    public void Append(Item item) {
        items.Append(item);
    }
    public void UpdateAt(int index, Item item) {
        items.UpdateAt(index, item);
    }
    public void DeleteAt(int index) {
        items.DeleteAt(index);
    }

    public override string ToString() {
        return $"{storeName} shopping list created at {dateOfCreation}\n{items}";
    }
} 
