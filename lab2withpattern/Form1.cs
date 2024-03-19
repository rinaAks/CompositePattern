namespace lab2withpattern;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btStart_Click(object sender, EventArgs e)
    {
        MenuComponent pancakeMenu = new Menu("Pancake House Menu");
        MenuComponent pancakeDesertMenu = new Menu("Pancake House DESERT Menu");
        MenuComponent sandwichMenu = new Menu("Sandwich House Menu");

        MenuComponent allMenus = new Menu("��� ����");
        allMenus.add(pancakeMenu);
        allMenus.add(sandwichMenu);

        pancakeMenu.add(new MenuItem("���� � �������"));
        pancakeMenu.add(new MenuItem("���� � �����"));
        pancakeMenu.add(new MenuItem("���� � �����"));

        pancakeDesertMenu.add(new MenuItem("���� � ������"));
        pancakeDesertMenu.add(new MenuItem("��������"));

        pancakeMenu.add(pancakeDesertMenu);


        sandwichMenu.add(new MenuItem("������� � �������"));
        sandwichMenu.add(new MenuItem("������� � ��������"));

        Waitress waitress = new Waitress(allMenus);
        tbOutput.Text = waitress.printMenu();
        //tbOutput.Text = allMenus.menuComponents;
    }
}
