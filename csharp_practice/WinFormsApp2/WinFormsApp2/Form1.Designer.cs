// Це приблизний код, який зазвичай лежить у файлі Designer.cs
private void InitializeComponent()
{
    this.comboBox1 = new System.Windows.Forms.ComboBox(); // Вибір категорії (зверху)
    this.textBoxInput = new System.Windows.Forms.TextBox(); // Ввід числа (зліва зверху)
    this.labelResult = new System.Windows.Forms.Label(); // Результат (зліва знизу)
    this.comboBoxFrom = new System.Windows.Forms.ComboBox(); // Одиниця "З" (справа зверху)
    this.comboBoxTo = new System.Windows.Forms.ComboBox(); // Одиниця "В" (справа знизу)

    // Розміри та позиції (приклад)
    this.comboBox1.Location = new System.Drawing.Point(100, 20);
    this.comboBox1.Size = new System.Drawing.Size(300, 25);

    this.textBoxInput.Location = new System.Drawing.Point(50, 80);
    this.labelResult.Location = new System.Drawing.Point(50, 130);

    this.comboBoxFrom.Location = new System.Drawing.Point(250, 80);
    this.comboBoxTo.Location = new System.Drawing.Point(250, 130);

    // Додаємо подію, щоб при зміні категорії мінялися одиниці
    this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
}