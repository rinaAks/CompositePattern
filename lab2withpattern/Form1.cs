namespace lab2withpattern;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    MenuComponent initialMenus = new Menu("����������� ����");
    bool initialMenusFlag = true;
    MenuComponent newMenus = new Menu("����� ����");
    int valueNewMenus = 0;

    private void createExistingMenus()
    {
        MenuComponent pancakeMenu = new Menu("Pancake House Menu");
        MenuComponent pancakeDesertMenu = new Menu("Pancake House DESERT Menu");
        MenuComponent sandwichMenu = new Menu("Sandwich House Menu");

        initialMenus.add(pancakeMenu);
        initialMenus.add(sandwichMenu);

        pancakeMenu.add(new MenuItem("���� � �������", 70));
        pancakeMenu.add(new MenuItem("���� � �����", 100));
        pancakeMenu.add(new MenuItem("���� � �����", 60));

        pancakeDesertMenu.add(new MenuItem("���� � ������", 60));
        pancakeDesertMenu.add(new MenuItem("��������", 80));

        pancakeMenu.add(pancakeDesertMenu);


        sandwichMenu.add(new MenuItem("������� � �������", 50));
        sandwichMenu.add(new MenuItem("������� � ��������", 40));
    }
    private void printExistingMenus(Waitress waitress) //����� �� ������ show ��������, �� � create
    {
        tbOutput.Text = waitress.printMenu();
    }

    private void btStart_Click(object sender, EventArgs e)
    {
        tbOutput.Clear();
        Waitress waitress = new Waitress(initialMenus);
        if (initialMenusFlag) createExistingMenus();
        initialMenusFlag = false;
        tbOutput.Text += waitress.printMenu();

        Waitress waitressNewMenus = new Waitress(newMenus);
        tbOutput.Text += waitressNewMenus.printMenu();
    }

    private void btAddMenu_Click(object sender, EventArgs e)
    {
        MenuComponent newMenu = new Menu(tbAddMenu.Text);
        newMenus.add(newMenu);
        tbAddMenu.Clear();
        lbAddMenu.Text = "���� " + newMenu.getName() + "\n���������";

        ComboboxItem item = new ComboboxItem();
        item.Text = newMenu.getName();
        item.Value = valueNewMenus;
        valueNewMenus += 1;
        cbMenus.Items.Add(item);
    }

    private void tbAddMenu_MouseClick(object sender, EventArgs e)
    {
        tbAddMenu.Clear(); //���� ������ �������� � ��������, �� �� �������
    }

    private void tbAddItem_MouseClick(object sender, EventArgs e)
    {
        tbAddItem.Clear(); //���� ������ �������� � ��������, �� �� �������
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    } //��� ���������� ����� ���� � ComboBox

    private void btAddItem_Click(object sender, EventArgs e)
    {
        //tbAddItem.Clear();

        MenuComponent menuItem = new MenuItem(tbAddItem.Text, (int)numPrice.Value);
        for (int i = 0; i < valueNewMenus; i++)
        {
            if(cbMenus.SelectedItem.ToString() == newMenus.getChild(i).getName())
            {
                newMenus.getChild(i).add(menuItem);
            }
        }
        //newMenus.add(menuItem);
        lbAddItem.Text = "����� " + menuItem.getName() + "\n���������";

    }
}
