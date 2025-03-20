using System;

public class InventoryItem
{
    // Приватное поле для хранения количества товара
    private int quantity;

    // Свойство для получения и установки названия товара
    public string ItemName { get; set; }

    // Конструктор класса, который инициализирует название товара и устанавливает количество в 0
    public InventoryItem(string itemName)
    {
        ItemName = itemName;
        quantity = 0;
    }

    // Метод для добавления товара на склад
    public void AddStock(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Отрицательное количество недопустимо.");

        quantity += amount;
    }

    // Метод для удаления товара со склада
    public void RemoveStock(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Отрицательное количество недопустимо.");

        if (quantity >= amount)
        {
            quantity -= amount;
        }
        else
        {
            throw new InvalidOperationException("На складе недостаточно товара.");
        }
    }

    // Метод для получения текущего количества товара
    public int GetQuantity()
    {
        return quantity;
    }

    // Переопределение ToString() для отображения наименования и количества товара
    public override string ToString()
    {
        return $"{ItemName} - {quantity} шт.";
    }
}
