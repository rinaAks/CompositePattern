namespace lab2withpattern;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    MenuComponent initialMenus = new Menu("Изначальное меню");
    bool initialMenusFlag = true;
    MenuComponent newMenus = new Menu("Новое меню");
    int valueNewMenus = 0;

    private void showExistingMenus() //здесь не только show делается, но и create
    {
        Waitress waitress = new Waitress(initialMenus);

        MenuComponent pancakeMenu = new Menu("Pancake House Menu");
        MenuComponent pancakeDesertMenu = new Menu("Pancake House DESERT Menu");
        MenuComponent sandwichMenu = new Menu("Sandwich House Menu");

        initialMenus.add(pancakeMenu);
        initialMenus.add(sandwichMenu);

        pancakeMenu.add(new MenuItem("Блин с грибами", 70));
        pancakeMenu.add(new MenuItem("Блин с мясом", 100));
        pancakeMenu.add(new MenuItem("Блин с сыром", 60));

        pancakeDesertMenu.add(new MenuItem("Блин с вишней", 60));
        pancakeDesertMenu.add(new MenuItem("Тирамису", 80));

        pancakeMenu.add(pancakeDesertMenu);


        sandwichMenu.add(new MenuItem("Сэндвич с курицей", 50));
        sandwichMenu.add(new MenuItem("Сэндвич с ветчиной", 40));

        tbOutput.Text = waitress.printMenu();
    }

    private void btStart_Click(object sender, EventArgs e)
    {
        if (initialMenusFlag) showExistingMenus();
        initialMenusFlag = false;

        Waitress waitressNewMenus = new Waitress(newMenus);
        tbOutput.Text = waitressNewMenus.printMenu();
    }

    private void btAddMenu_Click(object sender, EventArgs e)
    {
        MenuComponent newMenu = new Menu(tbAddMenu.Text);
        newMenus.add(newMenu);
        tbAddMenu.Clear();
        lbAddMenu.Text = "Меню " + newMenu.getName() + "\nдобавлено";

        ComboboxItem item = new ComboboxItem();
        item.Text = newMenu.getName();
        item.Value = valueNewMenus;
        valueNewMenus += 1;
        cbMenus.Items.Add(item);
    }

    private void tbAddMenu_MouseClick(object sender, EventArgs e)
    {
        tbAddMenu.Clear(); //если начать печатать и кликнуть, то всё пропадёт
    }

    private void tbAddItem_MouseClick(object sender, EventArgs e)
    {
        tbAddItem.Clear(); //если начать печатать и кликнуть, то всё пропадёт
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    } //для добавления новых меню в ComboBox

    private void btAddItem_Click(object sender, EventArgs e)
    {
        //tbAddItem.Clear();

        MenuComponent menuItem = new MenuItem(tbAddItem.Text, (int)numPrice.Value);
        /*for (int i = 0; i < valueNewMenus - 2; i++)
        {
            if((string)cbMenus.SelectedItem == newMenus.getChild(i).getName())
            {
                newMenus.getChild(i).add(menuItem);
            }
        }*/
        newMenus.add(menuItem);
        lbAddItem.Text = "Блюдо " + menuItem.getName() + "\nдобавлено";

    }
}
