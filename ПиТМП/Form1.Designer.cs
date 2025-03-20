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
        txtItemName = new TextBox();
        txtAmount = new TextBox();
        btnAdd = new Button();
        btnRemove = new Button();
        btnClear = new Button();
        lstInventory = new ListBox();
        lblItemName = new Label();
        lblAmount = new Label();
        SuspendLayout();
        // 
        // txtItemName
        // 
        txtItemName.Location = new Point(242, 62);
        txtItemName.Name = "txtItemName";
        txtItemName.Size = new Size(200, 39);
        txtItemName.TabIndex = 1;
        // 
        // txtAmount
        // 
        txtAmount.Location = new Point(242, 131);
        txtAmount.Name = "txtAmount";
        txtAmount.Size = new Size(200, 39);
        txtAmount.TabIndex = 3;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(20, 201);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(163, 78);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Добавить";
        btnAdd.Click += btnAdd_Click;
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(189, 201);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(131, 78);
        btnRemove.TabIndex = 5;
        btnRemove.Text = "Удалить";
        btnRemove.Click += btnRemove_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(326, 201);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(231, 78);
        btnClear.TabIndex = 6;
        btnClear.Text = "Очистить список";
        btnClear.Click += btnClear_Click;
        // 
        // lstInventory
        // 
        lstInventory.ItemHeight = 32;
        lstInventory.Location = new Point(20, 297);
        lstInventory.Name = "lstInventory";
        lstInventory.Size = new Size(756, 260);
        lstInventory.TabIndex = 7;
        // 
        // lblItemName
        // 
        lblItemName.Location = new Point(20, 62);
        lblItemName.Name = "lblItemName";
        lblItemName.Size = new Size(216, 51);
        lblItemName.TabIndex = 0;
        lblItemName.Text = "Название товара:";
        // 
        // lblAmount
        // 
        lblAmount.Location = new Point(20, 131);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(172, 44);
        lblAmount.TabIndex = 2;
        lblAmount.Text = "Количество:";
        // 
        // Form1
        // 
        ClientSize = new Size(788, 589);
        Controls.Add(lblItemName);
        Controls.Add(txtItemName);
        Controls.Add(lblAmount);
        Controls.Add(txtAmount);
        Controls.Add(btnAdd);
        Controls.Add(btnRemove);
        Controls.Add(btnClear);
        Controls.Add(lstInventory);
        Name = "Form1";
        Text = "Учет запасов на складе";
        ResumeLayout(false);
        PerformLayout();
    }
}
