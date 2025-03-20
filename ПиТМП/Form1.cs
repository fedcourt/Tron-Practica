using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string itemName = txtItemName.Text.Trim();
        if (string.IsNullOrEmpty(itemName))
        {
            MessageBox.Show("Введите название товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
        {
            MessageBox.Show("Введите корректное количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var item = inventoryItems.Find(i => i.ItemName == itemName);
        if (item == null)
        {
            item = new InventoryItem(itemName);
            inventoryItems.Add(item);
        }

        item.AddStock(amount);
        UpdateInventoryList();
        // Сообщение при добавлении товара
        MessageBox.Show("Товар добавлен");
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        string itemName = txtItemName.Text.Trim();
        if (string.IsNullOrEmpty(itemName))
        {
            MessageBox.Show("Введите название товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
        {
            MessageBox.Show("Введите корректное количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var item = inventoryItems.Find(i => i.ItemName == itemName);
        if (item == null)
        {
            MessageBox.Show("Товар не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            item.RemoveStock(amount);
            UpdateInventoryList();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void btnClear_Click(object sender, EventArgs e)
    {
        inventoryItems.Clear();
        UpdateInventoryList();
        // Сообщение при очистке
        MessageBox.Show("Очистка успешна");
    }

    private void UpdateInventoryList()
    {
        lstInventory.Items.Clear();
        foreach (var item in inventoryItems)
        {
            lstInventory.Items.Add(item.ToString());
        }
    }
}
