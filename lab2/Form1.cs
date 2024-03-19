using System.Collections;

namespace lab2
{
    public class Menu
    {
        public ArrayList menuComponents = new ArrayList();
        public ArrayList menuComponents2 = new ArrayList();
        public Menu(string name)
        {
            this.name = name;
        }
        string name;
        public void add(Menu menu) { menuComponents.Add(menu); }
        public string getName() { return name; }

        public void print()
        {
            textBoxAccess.textReturn += "\n" + getName();
            textBoxAccess.textReturn += "\n-------------------------\n";
        }
    }

    public class MenuItem
    {
        string name;
        int price;
        public MenuItem(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName() { return name; }
        public void print()
        {
            textBoxAccess.textReturn += "\n    ---" + getName() + "     " + price + " рублей\n";

        }
    }


    public static class textBoxAccess
    {
        static public string textReturn;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Menu initialMenus = new Menu("Изначальные меню");
            Menu pancakeMenu = new Menu("Pancake House Menu");
            Menu pancakeDesertMenu = new Menu("Pancake House DESERT Menu");
            Menu sandwichMenu = new Menu("Sandwich House Menu");

            initialMenus.add(pancakeMenu);
            initialMenus.add(sandwichMenu);

            pancakeMenu.menuComponents2.Add(new MenuItem("Блин с грибами", 70));
            pancakeMenu.menuComponents2.Add(new MenuItem("Блин с мясом", 100));
            // pancakeMenu.menuComponents.Add(new MenuItem("Блин с сыром", 60));

            pancakeDesertMenu.menuComponents2.Add(new MenuItem("Блин с вишней", 60));
            // pancakeDesertMenu.menuComponents.Add(new MenuItem("Тирамису", 80));

            pancakeMenu.add(pancakeDesertMenu);

            sandwichMenu.menuComponents2.Add(new MenuItem("Сэндвич с курицей", 50));
            //sandwichMenu.menuComponents.Add(new MenuItem("Сэндвич с ветчиной", 40));
            pancakeMenu.print();
            foreach (MenuItem my in pancakeMenu.menuComponents2)
                textBoxAccess.textReturn += my.getName() + "\n";
            pancakeDesertMenu.print();
            foreach (MenuItem my in pancakeDesertMenu.menuComponents2)
                textBoxAccess.textReturn += my.getName() + "\n";
            sandwichMenu.print();
            foreach (MenuItem my in sandwichMenu.menuComponents2)
                textBoxAccess.textReturn += my.getName() + "\n";
            //tbOutput.Text = (MenuItem)(pancakeMenu.menuComponents[0]).getName();
            tbOutput.Text += textBoxAccess.textReturn;
        }
    }
}
