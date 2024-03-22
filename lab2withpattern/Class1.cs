using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2withpattern
{
    internal class Class1
    {
    }
    public abstract class MenuComponent
    {
        //public string textReturn;
        //public string textReturn = "empty";
        // базовое поведение в случае, если подкласс не будет
        // реализовывать метод по-своему.
        // например, у листьев (leafes) нет add, remove и getChild
        virtual public void add(MenuComponent menuComponent) { throw new NotImplementedException(); }
        virtual public void remove(MenuComponent menuComponent) { throw new NotImplementedException(); }
        virtual public MenuComponent getChild(int i) { throw new NotImplementedException(); }
        virtual public string getName() { throw new NotImplementedException(); }
        virtual public void print() { throw new NotImplementedException(); }

    }
    
    public class MenuItem : MenuComponent
    {
        string name;
        int price;
        public MenuItem(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public override string getName() { return name; }
        public override void print() { 
            textBoxAccess.textReturn += "\n    ---" + getName() + "     " + price + " рублей\n";

        }
    }

    public class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        public Menu(string name)
        {
            this.name = name;
        }
        public override void add(MenuComponent menuComponent) { menuComponents.Add(menuComponent); }
        public override void remove(MenuComponent menuComponent) { menuComponents.Remove(menuComponent); }
        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }
        public override string getName() { return name; }
        public override void print()
        {
            textBoxAccess.textReturn += "\n" + getName();
            textBoxAccess.textReturn += "\n-------------------------"; 
            foreach (MenuComponent component in menuComponents)
            {
                if (component != null)
                {
                    component.print();
                }
            }
        }
    }
    
    public class Waitress
    {
        //allMenus содержит все меню, это сааамый верхний 
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public string printMenu()
        {
            textBoxAccess.textReturn = " ";
            allMenus.print();
            return textBoxAccess.textReturn;
        }

        public void clearMenus()
        {
            allMenus.remove(allMenus);
        }
        // public void printMenu() { allMenus.print(); }
        

    }

    public static class textBoxAccess
    {
        static public string textReturn;
    }
}
