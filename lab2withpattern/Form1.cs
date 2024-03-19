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

        MenuComponent allMenus = new Menu("Все меню");
        allMenus.add(pancakeMenu);
        allMenus.add(sandwichMenu);

        pancakeMenu.add(new MenuItem("Блин с грибами"));
        pancakeMenu.add(new MenuItem("Блин с мясом"));
        pancakeMenu.add(new MenuItem("Блин с сыром"));

        pancakeDesertMenu.add(new MenuItem("Блин с вишней"));
        pancakeDesertMenu.add(new MenuItem("Тирамису"));

        pancakeMenu.add(pancakeDesertMenu);


        sandwichMenu.add(new MenuItem("Сэндвич с курицей"));
        sandwichMenu.add(new MenuItem("Сэндвич с ветчиной"));

        Waitress waitress = new Waitress(allMenus);
        tbOutput.Text = waitress.printMenu();
        //tbOutput.Text = allMenus.menuComponents;
    }
}
