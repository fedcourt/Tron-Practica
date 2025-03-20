partial class Form1
{

    private System.Windows.Forms.TextBox txtItemName;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.ListBox lstInventory;
    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.Label lblAmount;

    private void InitializeComponent()
    {
        this.txtItemName = new System.Windows.Forms.TextBox();
        this.txtAmount = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnRemove = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.lstInventory = new System.Windows.Forms.ListBox();
        this.lblItemName = new System.Windows.Forms.Label();
        this.lblAmount = new System.Windows.Forms.Label();

        // Название товара
        this.lblItemName.Text = "Название товара:";
        this.lblItemName.Location = new System.Drawing.Point(20, 20);

        this.txtItemName.Location = new System.Drawing.Point(150, 20);
        this.txtItemName.Width = 200;

        // Количество
        this.lblAmount.Text = "Количество:";
        this.lblAmount.Location = new System.Drawing.Point(20, 60);

        this.txtAmount.Location = new System.Drawing.Point(150, 60);
        this.txtAmount.Width = 100;

        // Кнопки
        this.btnAdd.Text = "Добавить";
        this.btnAdd.Location = new System.Drawing.Point(20, 100);
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        this.btnRemove.Text = "Удалить";
        this.btnRemove.Location = new System.Drawing.Point(120, 100);
        this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

        this.btnClear.Text = "Очистить список";
        this.btnClear.Location = new System.Drawing.Point(220, 100);
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

        // Список товаров
        this.lstInventory.Location = new System.Drawing.Point(20, 140);
        this.lstInventory.Size = new System.Drawing.Size(330, 150);

        // Добавляем элементы на форму
        this.Controls.Add(this.lblItemName);
        this.Controls.Add(this.txtItemName);
        this.Controls.Add(this.lblAmount);
        this.Controls.Add(this.txtAmount);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnRemove);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.lstInventory);

        // Настройки формы
        this.Text = "Учет запасов на складе";
        this.Size = new System.Drawing.Size(400, 350);
    }

}
