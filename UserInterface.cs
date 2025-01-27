﻿using Spectre.Console;

namespace CoffeeShop.PointOfSale.EntityFramework;

static internal class UserInterface
{
    internal static void ShowProduct(Product product)
    {
        var panel = new Panel($@"Id : {product.Id}
Name: {product.Name}");
        panel.Header = new PanelHeader("Product Info");
        panel.Padding = new Padding(2, 2, 2, 2);

        AnsiConsole.Write(panel);

        Console.WriteLine("Enter a key to go back to the main menu");
        Console.ReadLine();
        Console.Clear();
    }

    static internal void ShowProductTable(List<Product> products)
    {
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");

        foreach (var product in products)
        {
            table.AddRow(product.Id.ToString(), product.Name);
        }

        AnsiConsole.Write(table);

        Console.Write("Enter any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
}
