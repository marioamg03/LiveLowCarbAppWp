using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LiveLowCarbApp.Resources;


namespace LiveLowCarbApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        //vectors
        string[] food = new string[252];
        double[] calories = new double[252];
        double[] fat = new double[252];
        double[] Carbs = new double[252];
        double[] Protein = new double[252];
        Double Calorias;
        Double Grasas;
        Double Carbohidratos;
        Double Proteinas;
        bool encontrado = false;
        bool gr = true;
        int cont = 0;

        Double Cal = 250;
        Double Fa;
        Double car;
        Double Pro;

        public MainPage()
            {
            InitializeComponent();
            llenar();
            AutoCompletar();
            rojo.Width = 0;
            amarillo.Width = 0;
            verde.Width = 0;
            slider.Visibility = Visibility.Collapsed;
            }
        private void AutoCompletar()
        {
            List<WP8Phone> dataSource = new List<WP8Phone>() 
    {
    new WP8Phone(){Name = "Abalone (Mixed Species)"},
    new WP8Phone(){Name = "Abalone (Mixed Species, Cooked, Fried)"},
    new WP8Phone(){Name = "Acerola (West Indian Cherry)"},
    new WP8Phone(){Name = "Acerola Juice"},
    new WP8Phone(){Name = "Abiyuch"},
    new WP8Phone(){Name = "Acorn Flour (Full Fat)"},
    new WP8Phone(){Name = "Babassu Vegetable Oil"},
    new WP8Phone(){Name = "Baby Carrots"},
    new WP8Phone(){Name = "Baby Lima Beans (Immature Seeds, Frozen)"},
    new WP8Phone(){Name = "Baby Lima Beans (Mature Seeds)"},
    new WP8Phone(){Name = "Baby Lima Beans (Mature Seeds, Without Salt, Cooked, Boiled)"},
    new WP8Phone(){Name = "Cabbage"},
    new WP8Phone(){Name = "Cabbage (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Cabbage (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Cabernet Sauvignon Wine"},
    new WP8Phone(){Name = "Cabernet Franc Wine"},
    new WP8Phone(){Name = "Daiquiri (Canned)"},
    new WP8Phone(){Name = "Daiquiri (From Recipe)"},
    new WP8Phone(){Name = "Dandelion Greens"},
    new WP8Phone(){Name = "Dandelion Greens (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Dandelion Greens (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Eastern Oyster (Canned)"},
    new WP8Phone(){Name = "Eastern Oyster (Cooked, Breaded And Fried)"},
    new WP8Phone(){Name = "Edam Cheese"},
    new WP8Phone(){Name = "Eel (Mixed Species)"},
    new WP8Phone(){Name = "Eel (Mixed Species, Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Falafel"},
    new WP8Phone(){Name = "Familia Cereals Ready-To-Eat"},
    new WP8Phone(){Name = "Farina Cereal (Dry, Enriched)"},
    new WP8Phone(){Name = "Farina Cereal (Without Salt, Cooked With Water, Enriched)"},
    new WP8Phone(){Name = "Farina Cereal (Dry, Unenriched)"},
    new WP8Phone(){Name = "Gamay Wine"},
    new WP8Phone(){Name = "Garden Cress"},
    new WP8Phone(){Name = "Garland Chrysanthemum (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Garden Cress (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Garland Chrysanthemum (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Haddock (Fish)"},
    new WP8Phone(){Name = "Haddock (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Ham (Boneless, Extra Lean (Approx 5% Fat), Cured, Roasted)"},
    new WP8Phone(){Name = "Ham (Boneless, Extra Lean And Regular, Cured)"},
    new WP8Phone(){Name = "Ham (Boneless, Extra Lean And Regular, Cured, Canned)"},
    new WP8Phone(){Name = "Ice Cream Cones (Cake Or Wafer Type)"},
    new WP8Phone(){Name = "Ice Cream Cones (Rolled Sugar Type)"},
    new WP8Phone(){Name = "Iceberg Lettuce (Includes Crisphead Types)"},
    new WP8Phone(){Name = "Iced Molasses Archway Home Style Cookies"},
    new WP8Phone(){Name = "Iced Oatmeal Archway Home Style Cookies"},
    new WP8Phone(){Name = "Jack Mackerel (Drained Solids, Canned)"},
    new WP8Phone(){Name = "Jackfruit"},
    new WP8Phone(){Name = "Jackfruit (Syrup Pack, Canned)"},
    new WP8Phone(){Name = "Jalapeno Peppers (Solids And Liquids, Canned)"},
    new WP8Phone(){Name = "Jalapeno Peppers"},
    new WP8Phone(){Name = "Kaboom General Mills Cereals Ready-To-Eat"},
    new WP8Phone(){Name = "Kale"},
    new WP8Phone(){Name = "Kale (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Kale (Frozen)"},
    new WP8Phone(){Name = "Kale (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "La Victoria Enchilada Sauce La Victoria Sauce"},
    new WP8Phone(){Name = "Ladyfinger Cookies (Without Lemon Juice And Rind)"},
    new WP8Phone(){Name = "Lamb (Trimmed To 1/4 Fat, Choice Grade)"},
    new WP8Phone(){Name = "Lamb (Lean Only, Trimmed To 1/4 Fat, Choice Grade)"},
    new WP8Phone(){Name = "Lamb (Lean Only, Trimmed To 1/4 Fat, Choice Grade, Cooked)"},
    new WP8Phone(){Name = "Macadamia Flavored Formulated Nuts (Without Salt, Wheat Based)"},
    new WP8Phone(){Name = "Macadamia Nuts"},
    new WP8Phone(){Name = "Macaroni (Enriched, Cooked)"},
    new WP8Phone(){Name = "Macaroni (Protein Fortified, Enriched)"},
    new WP8Phone(){Name = "Macaroni (Protein Fortified, Enriched, Cooked)"},
    new WP8Phone(){Name = "Nacho Flavor Corn Cones"},
    new WP8Phone(){Name = "Nacho Cheese Tortilla Chips (Low Fat, Made With Olestra)"},
    new WP8Phone(){Name = "Nacho Flavor Tortilla Chips"},
    new WP8Phone(){Name = "Nacho Flavor Cornnuts"},
    new WP8Phone(){Name = "Nacho Flavor Tortilla Chips (Reduced Fat)"},
    new WP8Phone(){Name = "Oat Bran"},
    new WP8Phone(){Name = "Oat Bran (Cooked)"},
    new WP8Phone(){Name = "Oat Bran Bagels"},
    new WP8Phone(){Name = "Oat Bran Bread"},
    new WP8Phone(){Name = "Oat Bran Bread (Reduced Calorie)"},
    new WP8Phone(){Name = "Pacific And Jack Mackerel (Mixed Species)"},
    new WP8Phone(){Name = "Pacific And Jack Mackerel (Mixed Species, Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Pacific Cod"},
    new WP8Phone(){Name = "Pacific Herring Fish"},
    new WP8Phone(){Name = "Pacific Cod (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Quail (Cooked)"},
    new WP8Phone(){Name = "Quail Egg"},
    new WP8Phone(){Name = "Quail Meat And Skin"},
    new WP8Phone(){Name = "Quail Meat"},
    new WP8Phone(){Name = "Queen Crab"},
    new WP8Phone(){Name = "Rabbit Meat"},
    new WP8Phone(){Name = "Rabbit Meat (Cooked, Roasted)"},
    new WP8Phone(){Name = "Radish Seeds (Sprouted)"},
    new WP8Phone(){Name = "Radicchio"},
    new WP8Phone(){Name = "Rabbit Meat (Cooked, Stewed)"},
    new WP8Phone(){Name = "Sablefish"},
    new WP8Phone(){Name = "Sablefish (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Saffron"},
    new WP8Phone(){Name = "Safflower And Soybean (Hydrogenated) Hard Regular Margarine"},
    new WP8Phone(){Name = "Safflower Vegetable Oil (Over 70% Linoleic)"},
    new WP8Phone(){Name = "Tabasco Sauce"},
    new WP8Phone(){Name = "Table Wine"},
    new WP8Phone(){Name = "Taco Flavor Tortilla Chips"},
    new WP8Phone(){Name = "Taco"},
    new WP8Phone(){Name = "Taco Salad"},
    new WP8Phone(){Name = "Ucuhuba Vegetable Oil Butter"},
    new WP8Phone(){Name = "Unblanched Dried Brazilnuts"},
    new WP8Phone(){Name = "Unblanched Honey Roasted Almonds"},
    new WP8Phone(){Name = "Uncle Sam Cereal Cereals Ready-To-Eat"},
    new WP8Phone(){Name = "Unheated Canned Extra Lean (Approximately 4% Fat) Ham Cured Pork"},
    new WP8Phone(){Name = "Valencia Peanuts"},
    new WP8Phone(){Name = "Valencias California Oranges"},
    new WP8Phone(){Name = "Vanilla Extract"},
    new WP8Phone(){Name = "Vanilla Extract (Imitation, Alcohol)"},
    new WP8Phone(){Name = "Vanilla Cream Pie"},
    new WP8Phone(){Name = "Waffelos Cereals Ready-To-Eat"},
    new WP8Phone(){Name = "Wakame Seaweed)"},
    new WP8Phone(){Name = "Walleye Pike (Fish)"},
    new WP8Phone(){Name = "Walleye Pollock (Fish)"},
    new WP8Phone(){Name = "Walleye Pollock (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Yachtwurst With Pistachio Nuts (Cooked)"},
    new WP8Phone(){Name = "Yam"},
    new WP8Phone(){Name = "Yam (Without Salt, Drained, Cooked, Boiled, Baked)"},
    new WP8Phone(){Name = "Yambean (Jicama)"},
    new WP8Phone(){Name = "Yam (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Zinfandel Wine"},
    new WP8Phone(){Name = "Zucchini"},
    new WP8Phone(){Name = "Zucchini Summer Squash (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Zucchini (Frozen)"},
    new WP8Phone(){Name = "Zucchini (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Adobo Fresco"},
    new WP8Phone(){Name = "Acorn Winter Squash"},
    new WP8Phone(){Name = "Acorn Winter Squash (Without Salt, Cooked, Baked)"},
    new WP8Phone(){Name = "Acorn Winter Squash (Without Salt, Mashed, Cooked, Boiled)"},
    new WP8Phone(){Name = "Acorn Winter Squash (With Salt, Cooked, Baked)"},
    new WP8Phone(){Name = "Acorn Winter Squash (With Salt, Mashed, Cooked, Boiled)"},
    new WP8Phone(){Name = "Baby Lima Beans (Mature Seeds, With Salt, Cooked, Boiled)"},
    new WP8Phone(){Name = "Bacon (Cured)"},
    new WP8Phone(){Name = "Bacon (Cured, Broiled, Pan-Fried Or Roasted, Cooked)"},
    new WP8Phone(){Name = "Bacon (Cured, Baked, Cooked)"},
    new WP8Phone(){Name = "Bacon (Cured, Microwaved, Cooked)"},
    new WP8Phone(){Name = "Caesar Salad Dressing"},
    new WP8Phone(){Name = "California Avocados"},
    new WP8Phone(){Name = "California And Arizona Pink And Red Grapefruit"},
    new WP8Phone(){Name = "Caesar Salad Dressing (Low Calorie)"},
    new WP8Phone(){Name = "California White Grapefruit"},
    new WP8Phone(){Name = "Dannon Fluoride To Go Non-Carbonated Bottled Water"},
    new WP8Phone(){Name = "Dannon Non-Carbonated Bottled Water"},
    new WP8Phone(){Name = "Dasani Non-Carbonated Bottled Water"},
    new WP8Phone(){Name = "Dark Molasses Archway Home Style Cookies"},
    new WP8Phone(){Name = "Dark Chocolate Powder Alsa Mousse Mix Cpc Desserts"},
    new WP8Phone(){Name = "Eastern Oyster (Farmed)"},
    new WP8Phone(){Name = "Egg (Whole)"},
    new WP8Phone(){Name = "Egg Bagels"},
    new WP8Phone(){Name = "Egg Bread"},
    new WP8Phone(){Name = "Egg And Onion Matzo"},
    new WP8Phone(){Name = "Farina Cereal (With Salt, Cooked With Water, Enriched)"},
    new WP8Phone(){Name = "Farmed Channel Catfish (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Farmed Atlantic Salmon (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Farmed Coho Salmon (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Farmed Rainbow Trout (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Garden Cress (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Garlic Powder"},
    new WP8Phone(){Name = "Gazpacho Soup (Canned)"},
    new WP8Phone(){Name = "Garlic"},
    new WP8Phone(){Name = "Gefiltefish (Commercial, Sweet Recipe)"},
    new WP8Phone(){Name = "Ham (Boneless, Extra Lean (Approx 5% Fat), Low Sodium, Cured, Roasted)"},
    new WP8Phone(){Name = "Ham (Boneless, Regular (Approx 11% Fat), Cured, Roasted)"},
    new WP8Phone(){Name = "Ham (Center Slice, Country-Style, Lean Only, Cured)"},
    new WP8Phone(){Name = "Ham (Center Slice, Cured)"},
    new WP8Phone(){Name = "Ham (Boneless, Extra Lean And Regular, Cured, Roasted)"},
    new WP8Phone(){Name = "Iced Ginger Snaps Archway Home Style Cookies"},
    new WP8Phone(){Name = "Imitation Sour Cream (Cultured)"},
    new WP8Phone(){Name = "Immature Green Chili Hot Peppers (Canned)"},
    new WP8Phone(){Name = "Imitation Alaska King Crab (Made From Surimi)"},
    new WP8Phone(){Name = "Imitation Scallop (Mixed Species, Made From Surimi)"},
    new WP8Phone(){Name = "Jams And Preserves"},
    new WP8Phone(){Name = "Jar Traditional Prego 100% Natural Spaghetti Sauce Sauce"},
    new WP8Phone(){Name = "Jar Traditional Ragu Old World Style Smooth Pasta Sauce Lipton Sauce"},
    new WP8Phone(){Name = "Java-Plum (Jambolan)"},
    new WP8Phone(){Name = "Japanese Persimmons"},
    new WP8Phone(){Name = "Kale (With Salt, Frozen, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Kale (Without Salt, Frozen, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Kanpyo (Dried Gourd Strips)"},
    new WP8Phone(){Name = "Kale Scotch"},
    new WP8Phone(){Name = "Keebler Chocolate Graham Selects Keebler"},
    new WP8Phone(){Name = "Ladyfingers Cookies (With Lemon Juice And Rind)"},
    new WP8Phone(){Name = "Lamb (Trimmed To 1/4 Fat, Choice Grade, Cooked)"},
    new WP8Phone(){Name = "Lamb Cubed For Stew Or Kabob (Lean Only, Trimmed To 1/4 Fat)"},
    new WP8Phone(){Name = "Lamb Cubed For Stew Or Kabob (Lean Only, Trimmed To 1/4 Fat, Cooked, Braised)"},
    new WP8Phone(){Name = "Lamb Brain"},
    new WP8Phone(){Name = "Macaroni (Cooked)"},
    new WP8Phone(){Name = "Mace (Ground)"},
    new WP8Phone(){Name = "Malabar Spinach (Cooked)"},
    new WP8Phone(){Name = "Malt Beverage"},
    new WP8Phone(){Name = "Malted Drink Powder Mix (Natural)"},
    new WP8Phone(){Name = "Nacho Flavor Tortilla Chips (With Enriched Masa Flour)"},
    new WP8Phone(){Name = "Nachos With Cheese"},
    new WP8Phone(){Name = "Nachos With Cheese And Jalapeno Peppers"},
    new WP8Phone(){Name = "Native Persimmons"},
    new WP8Phone(){Name = "Napa Cabbage (Cooked)"},
    new WP8Phone(){Name = "Oat Bran Dinner Rolls"},
    new WP8Phone(){Name = "Oat Vegetable Oil"},
    new WP8Phone(){Name = "Oatmeal Bread"},
    new WP8Phone(){Name = "Oatmeal Bread (Reduced Calorie)"},
    new WP8Phone(){Name = "Oatmeal Cookie Dough"},
    new WP8Phone(){Name = "Pacific Herring (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Palm Vegetable Oil"},
    new WP8Phone(){Name = "Palm Kernel Vegetable Oil"},
    new WP8Phone(){Name = "Pacific Rockfish (Mixed Species)"},
    new WP8Phone(){Name = "Pacific Rockfish (Mixed Species, Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Queen Crab (Cooked, Moist Heat)"},
    new WP8Phone(){Name = "Queso Anejo Cheese"},
    new WP8Phone(){Name = "Queso Asadero Cheese"},
    new WP8Phone(){Name = "Queso Chihuahua Cheese"},
    new WP8Phone(){Name = "Quinces"},
    new WP8Phone(){Name = "Raccoon Meat (Cooked, Roasted)"},
    new WP8Phone(){Name = "Radishes"},
    new WP8Phone(){Name = "Rainbow Smelt (Fish)"},
    new WP8Phone(){Name = "Rainbow Smelt (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Rainbow Trout (Farmed)"},
    new WP8Phone(){Name = "Safflower Vegetable Oil (Over 70% Oleic)"},
    new WP8Phone(){Name = "Sage (Ground)"},
    new WP8Phone(){Name = "Salad Dressing (Home Recipe)"},
    new WP8Phone(){Name = "Salmon Fish Oil"},
    new WP8Phone(){Name = "Salami, Pork And Beef Beerwurst"},
    new WP8Phone(){Name = "Tahitian Taro"},
    new WP8Phone(){Name = "Tahini Sesame Butter Seeds (From Roasted And Toasted Kernels)"},
    new WP8Phone(){Name = "Tahini Sesame Butter Seeds (From Unroasted Kernels)"},
    new WP8Phone(){Name = "Tahini Sesame Butter Seeds (From Raw And Stone Ground Kernels)"},
    new WP8Phone(){Name = "Tahini Sesame Butter Seeds"},
    new WP8Phone(){Name = "Unsweetened Tablets Rennin Desserts"},
    new WP8Phone(){Name = "Vanilla Chocolate Strawberry No Sugar Added Breyers Ice Creams"},
    new WP8Phone(){Name = "Vanilla Extract (Imitation, No Alcohol)"},
    new WP8Phone(){Name = "Vanilla Ice Creams"},
    new WP8Phone(){Name = "Vanilla Fudge Candies"},
    new WP8Phone(){Name = "Vanilla Fudge Candies (With Nuts)"},
    new WP8Phone(){Name = "Vanilla Frostings (Dry Mix)"},
    new WP8Phone(){Name = "Vanilla Frozen Yogurts (Soft Serve)"},
    new WP8Phone(){Name = "Vanilla Ice Creams (Fat Free)"},
    new WP8Phone(){Name = "Vanilla Fudge Twirl No Sugar Added Breyers Ice Creams"},
    new WP8Phone(){Name = "Walleye Pike (Fish) (Cooked, Dry Heat)"},
    new WP8Phone(){Name = "Walnut Vegetable Oil"},
    new WP8Phone(){Name = "Wasabi Root"},
    new WP8Phone(){Name = "Water"},
    new WP8Phone(){Name = "Walrus Meat (Alaska Native)"},
    new WP8Phone(){Name = "Yambean (Jicama) (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Yardlong Bean"},
    new WP8Phone(){Name = "Yardlong Beans (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Yambean (Jicama) (Without Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Yardlong Bean (With Salt, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Yautia (Tannier)"},
    new WP8Phone(){Name = "Yardlong Beans (Mature Seeds)"},
    new WP8Phone(){Name = "Zucchini Summer Squash (With Salt, Frozen, Drained, Cooked, Boiled)"},
    new WP8Phone(){Name = "Zwieback"},
    new WP8Phone(){Name = "Zucchini Summer Squash (Without Salt, Frozen, Drained, Cooked, Boiled)"},




   };

            this.acBox.ItemsSource = dataSource;
        }
        public class WP8Phone
        {
            public string Name
            {
                get;
                set;
            }
        }
        private void llenar()
        {
            //lista de alimentos 1
            // FOOD
            // A [Esta letra se mantendra con un campo más]
            food[0] = "Abalone (Mixed Species)";
            food[1] = "Abalone (Mixed Species, Cooked, Fried)";
            food[2] = "Acerola (West Indian Cherry)";
            food[3] = "Acerola Juice";
            food[4] = "Abiyuch";
            food[5] = "Acorn Flour (Full Fat)";
            // B
            food[6] = "Babassu Vegetable Oil";
            food[7] = "Baby Carrots";
            food[8] = "Baby Lima Beans (Immature Seeds, Frozen)";
            food[9] = "Baby Lima Beans (Mature Seeds)";
            food[10] = "Baby Lima Beans (Mature Seeds, Without Salt, Cooked, Boiled)";
            // C
            food[11] = "Cabbage";
            food[12] = "Cabbage (With Salt, Drained, Cooked, Boiled)";
            food[13] = "Cabbage (Without Salt, Drained, Cooked, Boiled)";
            food[14] = "Cabernet Sauvignon Wine";
            food[15] = "Cabernet Franc Wine";
            // D
            food[16] = "Daiquiri (Canned)";
            food[17] = "Daiquiri (From Recipe)";
            food[18] = "Dandelion Greens";
            food[19] = "Dandelion Greens (Without Salt, Drained, Cooked, Boiled)";
            food[20] = "Dandelion Greens (With Salt, Drained, Cooked, Boiled)";
            // E
            food[21] = "Eastern Oyster (Canned)";
            food[22] = "Eastern Oyster (Cooked, Breaded And Fried)";
            food[23] = "Edam Cheese";
            food[24] = "Eel (Mixed Species)";
            food[25] = "Eel (Mixed Species, Cooked, Dry Heat)";
            // F
            food[26] = "Falafel";
            food[27] = "Familia Cereals Ready-To-Eat";
            food[28] = "Farina Cereal (Dry, Enriched)";
            food[29] = "Farina Cereal (Without Salt, Cooked With Water, Enriched)";
            food[30] = "Farina Cereal (Dry, Unenriched)";
            // G
            food[31] = "Gamay Wine";
            food[32] = "Garden Cress";
            food[33] = "Garland Chrysanthemum (Without Salt, Drained, Cooked, Boiled)";
            food[34] = "Garden Cress (Without Salt, Drained, Cooked, Boiled)";
            food[35] = "Garland Chrysanthemum (With Salt, Drained, Cooked, Boiled)";
            // H
            food[36] = "Haddock (Fish)";
            food[37] = "Haddock (Fish) (Cooked, Dry Heat)";
            food[38] = "Ham (Boneless, Extra Lean (Approx 5% Fat), Cured, Roasted)";
            food[39] = "Ham (Boneless, Extra Lean And Regular, Cured)";
            food[40] = "Ham (Boneless, Extra Lean And Regular, Cured, Canned)";
            // I
            food[41] = "Ice Cream Cones (Cake Or Wafer Type)";
            food[42] = "Ice Cream Cones (Rolled Sugar Type)";
            food[43] = "Iceberg Lettuce (Includes Crisphead Types)";
            food[44] = "Iced Molasses Archway Home Style Cookies";
            food[45] = "Iced Oatmeal Archway Home Style Cookies";
            // J
            food[46] = "Jack Mackerel (Drained Solids, Canned)";
            food[47] = "Jackfruit";
            food[48] = "Jackfruit (Syrup Pack, Canned)";
            food[49] = "Jalapeno Peppers (Solids And Liquids, Canned)";
            food[50] = "Jalapeno Peppers";
            // K
            food[51] = "Kaboom General Mills Cereals Ready-To-Eat";
            food[52] = "Kale";
            food[53] = "Kale (Without Salt, Drained, Cooked, Boiled)";
            food[54] = "Kale (Frozen)";
            food[55] = "Kale (With Salt, Drained, Cooked, Boiled)";
            // L
            food[56] = "La Victoria Enchilada Sauce La Victoria Sauce";
            food[57] = "Ladyfinger Cookies (Without Lemon Juice And Rind)";
            food[58] = "Lamb (Trimmed To 1/4 Fat, Choice Grade)";
            food[59] = "Lamb (Lean Only, Trimmed To 1/4 Fat, Choice Grade)";
            food[60] = "Lamb (Lean Only, Trimmed To 1/4 Fat, Choice Grade, Cooked)";
            // M
            food[61] = "Macadamia Flavored Formulated Nuts (Without Salt, Wheat Based)";
            food[62] = "Macadamia Nuts";
            food[63] = "Macaroni (Enriched, Cooked)";
            food[64] = "Macaroni (Protein Fortified, Enriched)";
            food[65] = "Macaroni (Protein Fortified, Enriched, Cooked)";
            // N
            food[66] = "Nacho Flavor Corn Cones";
            food[67] = "Nacho Cheese Tortilla Chips (Low Fat, Made With Olestra)";
            food[68] = "Nacho Flavor Tortilla Chips";
            food[69] = "Nacho Flavor Cornnuts";
            food[70] = "Nacho Flavor Tortilla Chips (Reduced Fat)";
            // O
            food[71] = "Oat Bran";
            food[72] = "Oat Bran (Cooked)";
            food[73] = "Oat Bran Bagels";
            food[74] = "Oat Bran Bread";
            food[75] = "Oat Bran Bread (Reduced Calorie)";
            // P
            food[76] = "Pacific And Jack Mackerel (Mixed Species)";
            food[77] = "Pacific And Jack Mackerel (Mixed Species, Cooked, Dry Heat)";
            food[78] = "Pacific Cod";
            food[79] = "Pacific Herring Fish";
            food[80] = "Pacific Cod (Fish) (Cooked, Dry Heat)";
            // Q
            food[81] = "Quail (Cooked)";
            food[82] = "Quail Egg";
            food[83] = "Quail Meat And Skin";
            food[84] = "Quail Meat";
            food[85] = "Queen Crab";
            // R
            food[86] = "Rabbit Meat";
            food[87] = "Rabbit Meat (Cooked, Roasted)";
            food[88] = "Radish Seeds (Sprouted)";
            food[89] = "Radicchio";
            food[90] = "Rabbit Meat (Cooked, Stewed)";
            // S
            food[91] = "Sablefish";
            food[92] = "Sablefish (Cooked, Dry Heat)";
            food[93] = "Saffron";
            food[94] = "Safflower And Soybean (Hydrogenated) Hard Regular Margarine";
            food[95] = "Safflower Vegetable Oil (Over 70% Linoleic)";
            // T
            food[96] = "Tabasco Sauce";
            food[97] = "Table Wine";
            food[98] = "Taco Flavor Tortilla Chips";
            food[99] = "Taco";
            food[100] = "Taco Salad";
            // U
            food[101] = "Ucuhuba Vegetable Oil Butter";
            food[102] = "Unblanched Dried Brazilnuts";
            food[103] = "Unblanched Honey Roasted Almonds";
            food[104] = "Uncle Sam Cereal Cereals Ready-To-Eat";
            food[105] = "Unheated Canned Extra Lean (Approximately 4% Fat) Ham Cured Pork";
            // V
            food[106] = "Valencia Peanuts";
            food[107] = "Valencias California Oranges";
            food[108] = "Vanilla Extract";
            food[109] = "Vanilla Extract (Imitation, Alcohol)";
            food[110] = "Vanilla Cream Pie";
            // W
            food[111] = "Waffelos Cereals Ready-To-Eat";
            food[112] = "Wakame Seaweed";
            food[113] = "Walleye Pike (Fish)";
            food[114] = "Walleye Pollock (Fish)";
            food[115] = "Walleye Pollock (Fish) (Cooked, Dry Heat)";
            // X
            // Y
            food[116] = "Yachtwurst With Pistachio Nuts (Cooked)";
            food[117] = "Yam";
            food[118] = "Yam (Without Salt, Drained, Cooked, Boiled, Baked)";
            food[119] = "Yambean (Jicama)";
            food[120] = "Yam (With Salt, Drained, Cooked, Boiled)";
            // Z
            food[121] = "Zinfandel Wine";
            food[122] = "Zucchini";
            food[123] = "Zucchini Summer Squash (Without Salt, Drained, Cooked, Boiled)";
            food[124] = "Zucchini (Frozen)";
            food[125] = "Zucchini (With Salt, Drained, Cooked, Boiled)";
            // CALORIES
            // A [Esta letra se mantendra con un campo más]
            calories[0] = 105;
            calories[1] = 189;
            calories[2] = 32;
            calories[3] = 23;
            calories[4] = 69;
            calories[5] = 501;
            /// B
            calories[6] = 884;
            calories[7] = 35;
            calories[8] = 132;
            calories[9] = 335;
            calories[10] = 126;
            /// C
            calories[11] = 24;
            calories[12] = 22;
            calories[13] = 22;
            calories[14] = 84;
            calories[15] = 85;
            /// D
            calories[16] = 125;
            calories[17] = 186;
            calories[18] = 45;
            calories[19] = 33;
            calories[20] = 33;
            /// E
            calories[21] = 69;
            calories[22] = 197;
            calories[23] = 357;
            calories[24] = 184;
            calories[25] = 236;
            /// F
            calories[26] = 333;
            calories[27] = 388;
            calories[28] = 369;
            calories[29] = 48;
            calories[30] = 369;
            /// G
            calories[31] = 79;
            calories[32] = 32;
            calories[33] = 20;
            calories[34] = 23;
            calories[35] = 20;
            /// H
            calories[36] = 87;
            calories[37] = 112;
            calories[38] = 145;
            calories[39] = 162;
            calories[40] = 144;
            /// I
            calories[41] = 417;
            calories[42] = 402;
            calories[43] = 14;
            calories[44] = 407;
            calories[45] = 439;
            /// J
            calories[46] = 156;
            calories[47] = 94;
            calories[48] = 92;
            calories[49] = 27;
            calories[50] = 30;
            /// K
            calories[51] = 383;
            calories[52] = 50;
            calories[53] = 28;
            calories[54] = 28;
            calories[55] = 30;
            /// L
            calories[56] = 33;
            calories[57] = 365;
            calories[58] = 267;
            calories[59] = 134;
            calories[60] = 206;
            /// M
            calories[61] = 619;
            calories[62] = 718;
            calories[63] = 158;
            calories[64] = 375;
            calories[65] = 164;
            /// N
            calories[66] = 536;
            calories[67] = 320;
            calories[68] = 508;
            calories[69] = 438;
            calories[70] = 445;
            /// O
            calories[71] = 246;
            calories[72] = 40;
            calories[73] = 255;
            calories[74] = 236;
            calories[75] = 201;
            /// P
            calories[76] = 158;
            calories[77] = 201;
            calories[78] = 82;
            calories[79] = 195;
            calories[80] = 105;
            /// Q
            calories[81] = 234;
            calories[82] = 158;
            calories[83] = 192;
            calories[84] = 134;
            calories[85] = 90;
            /// R
            calories[86] = 136;
            calories[87] = 197;
            calories[88] = 43;
            calories[89] = 23;
            calories[90] = 206;
            /// S
            calories[91] = 195;
            calories[92] = 250;
            calories[93] = 310;
            calories[94] = 719;
            calories[95] = 884;
            /// T
            calories[96] = 12;
            calories[97] = 84;
            calories[98] = 480;
            calories[99] = 216;
            calories[100] = 141;
            /// U
            calories[101] = 884;
            calories[102] = 656;
            calories[103] = 594;
            calories[104] = 431;
            calories[105] = 120;
            /// V
            calories[106] = 570;
            calories[107] = 49;
            calories[108] = 288;
            calories[109] = 237;
            calories[110] = 278;
            /// W
            calories[111] = 405;
            calories[112] = 45;
            calories[113] = 93;
            calories[114] = 81;
            calories[115] = 113;
            /// X
            /// Y
            calories[116] = 268;
            calories[117] = 118;
            calories[118] = 116;
            calories[119] = 38;
            calories[120] = 116;
            /// Z
            calories[121] = 89;
            calories[122] = 16;
            calories[123] = 16;
            calories[124] = 17;
            calories[125] = 16;
            // FAT
            // A [Esta letra se mantendra con un campo más]
            fat[0] = 0.76;
            fat[1] = 6.78;
            fat[2] = 0.3;
            fat[3] = 0.3;
            fat[4] = 0.1;
            fat[5] = 30.17;
            /// B
            fat[6] = 100;
            fat[7] = 0.13;
            fat[8] = 0.44;
            fat[9] = 0.93;
            fat[10] = 0.38;
            /// C
            fat[11] = 0.12;
            fat[12] = 0.43;
            fat[13] = 0;
            fat[14] = 0;
            fat[15] = 57.7;
            /// D
            fat[16] = 0;
            fat[17] = 0.06;
            fat[18] = 0.7;
            fat[19] = 0.6;
            fat[20] = 0.6;
            /// E
            fat[21] = 2.47;
            fat[22] = 12.58;
            fat[23] = 27.8;
            fat[24] = 11.66;
            fat[25] = 14.95;
            /// F
            fat[26] = 17.8;
            fat[27] = 6.3;
            fat[28] = 0.5;
            fat[29] = 0.07;
            fat[30] = 0.5;
            /// G
            fat[31] = 0;
            fat[32] = 0.7;
            fat[33] = 0.09;
            fat[34] = 0.6;
            fat[35] = 0.09;
            /// H
            fat[36] = 0.72;
            fat[37] = 0.93;
            fat[38] = 5.53;
            fat[39] = 8.39;
            fat[40] = 7.46;
            /// I
            fat[41] = 6.9;
            fat[42] = 3.8;
            fat[43] = 0.14;
            fat[44] = 12.88;
            fat[45] = 17.36;
            /// J
            fat[46] = 6.3;
            fat[47] = 0.3;
            fat[48] = 0.14;
            fat[49] = 0.94;
            fat[50] = 0.62;
            /// K
            fat[51] = 3.7;
            fat[52] = 0.7;
            fat[53] = 0.4;
            fat[54] = 0.46;
            fat[55] = 0.4;
            /// L
            fat[56] = 1.45;
            fat[57] = 9.1;
            fat[58] = 21.59;
            fat[59] = 5.25;
            fat[60] = 9.25;
            /// M
            fat[61] = 56.5;
            fat[62] = 75.77;
            fat[63] = 0.93;
            fat[64] = 2.23;
            fat[65] = 0.21;
            /// N
            fat[66] = 10;
            fat[67] = 10.2;
            fat[68] = 22.9;
            fat[69] = 11.07;
            fat[70] = 11.23;
            /// O
            fat[71] = 7.03;
            fat[72] = 0.86;
            fat[73] = 1.2;
            fat[74] = 4.4;
            fat[75] = 3.2;
            /// P
            fat[76] = 7.89;
            fat[77] = 10.12;
            fat[78] = 0.63;
            fat[79] = 13.88;
            fat[80] = 0.81;
            /// Q
            fat[81] = 14.1;
            fat[82] = 11.09;
            fat[83] = 12.05;
            fat[84] = 4.53;
            fat[85] = 4.28;
            /// R
            fat[86] = 5.55;
            fat[87] = 8.05;
            fat[88] = 2.53;
            fat[89] = 0.25;
            fat[90] = 8.41;
            /// S
            fat[91] = 15.3;
            fat[92] = 19.62;
            fat[93] = 5.85;
            fat[94] = 80.5;
            fat[95] = 100;
            /// T
            fat[96] = 0.76;
            fat[97] = 0;
            fat[98] = 24.2;
            fat[99] = 12.02;
            fat[100] = 7.46;
            /// U
            fat[101] = 100;
            fat[102] = 5;
            fat[103] = 66.43;
            fat[104] = 49.9;
            fat[105] = 10.34;
            /// V
            fat[106] = 47.58;
            fat[107] = 0.3;
            fat[108] = 0.06;
            fat[109] = 0;
            fat[110] = 0;
            /// W
            fat[111] = 4.2;
            fat[112] = 0.64;
            fat[113] = 1.22;
            fat[114] = 0.8;
            fat[115] = 1.12;
            /// X
            /// Y
            fat[116] = 22.6;
            fat[117] = 0.17;
            fat[118] = 0.14;
            fat[119] = 0.09;
            fat[120] = 0.14;
            /// Z
            fat[121] = 0;
            fat[122] = 0.18;
            fat[123] = 0.05;
            fat[124] = 0.13;
            fat[125] = 0.05;
            // CARBS
            // A [Esta letra se mantendra con un campo más]
            Carbs[0] = 6.01;
            Carbs[1] = 11.05;
            Carbs[2] = 7.69;
            Carbs[3] = 4.8;
            Carbs[4] = 17.6;
            Carbs[5] = 54.65;
            /// B
            Carbs[6] = 0;
            Carbs[7] = 8.24;
            Carbs[8] = 25.13;
            Carbs[9] = 62.83;
            Carbs[10] = 23.31;
            /// C
            Carbs[11] = 5.58;
            Carbs[12] = 4.46;
            Carbs[13] = 4.46;
            Carbs[14] = 2.6;
            Carbs[15] = 2.45;
            /// D
            Carbs[16] = 15.7;
            Carbs[17] = 6.94;
            Carbs[18] = 9.2;
            Carbs[19] = 6.4;
            Carbs[20] = 6.4;
            /// E
            Carbs[21] = 3.91;
            Carbs[22] = 11.62;
            Carbs[23] = 1.43;
            Carbs[24] = 0;
            Carbs[25] = 0;
            /// F
            Carbs[26] = 31.84;
            Carbs[27] = 73.8;
            Carbs[28] = 78;
            Carbs[29] = 10.47;
            Carbs[30] = 78;
            /// G
            Carbs[31] = 2.38;
            Carbs[32] = 5.5;
            Carbs[33] = 4.31;
            Carbs[34] = 3.8;
            Carbs[35] = 4.31;
            /// H
            Carbs[36] = 0;
            Carbs[37] = 0;
            Carbs[38] = 1.5;
            Carbs[39] = 2.28;
            Carbs[40] = 0;
            /// I
            Carbs[41] = 79;
            Carbs[42] = 84.1;
            Carbs[43] = 2.97;
            Carbs[44] = 69.9;
            Carbs[45] = 65.99;
            /// J
            Carbs[46] = 0;
            Carbs[47] = 24.01;
            Carbs[48] = 23.94;
            Carbs[49] = 4.74;
            Carbs[50] = 5.91;
            /// K
            Carbs[51] = 81;
            Carbs[52] = 10.01;
            Carbs[53] = 5.63;
            Carbs[54] = 4.9;
            Carbs[55] = 5.63;
            /// L
            Carbs[56] = 4.62;
            Carbs[57] = 59.7;
            Carbs[58] = 0;
            Carbs[59] = 0;
            Carbs[60] = 0;
            /// M
            Carbs[61] = 27.91;
            Carbs[62] = 13.82;
            Carbs[63] = 30.86;
            Carbs[64] = 67.56;
            Carbs[65] = 31.66;
            /// N
            Carbs[66] = 76.2;
            Carbs[67] = 71.1;
            Carbs[68] = 64.2;
            Carbs[69] = 74.69;
            Carbs[70] = 69.85;
            /// O
            Carbs[71] = 66.22;
            Carbs[72] = 11.44;
            Carbs[73] = 53.3;
            Carbs[74] = 39.8;
            Carbs[75] = 41.3;
            /// P
            Carbs[76] = 0;
            Carbs[77] = 0;
            Carbs[78] = 0;
            Carbs[79] = 0;
            Carbs[80] = 0;
            /// Q
            Carbs[81] = 0;
            Carbs[82] = 0.41;
            Carbs[83] = 0;
            Carbs[84] = 0;
            Carbs[85] = 79.83;
            /// R
            Carbs[86] = 0;
            Carbs[87] = 0;
            Carbs[88] = 3.6;
            Carbs[89] = 4.48;
            Carbs[90] = 0;
            /// S
            Carbs[91] = 0;
            Carbs[92] = 0;
            Carbs[93] = 65.37;
            Carbs[94] = 0.9;
            Carbs[95] = 0;
            /// T
            Carbs[96] = 0.8;
            Carbs[97] = 2.72;
            Carbs[98] = 63.1;
            Carbs[99] = 15.63;
            Carbs[100] = 11.91;
            /// U
            Carbs[101] = 0;
            Carbs[102] = 18.88;
            Carbs[103] = 12.27;
            Carbs[104] = 27.9;
            Carbs[105] = 33.93;
            /// V
            Carbs[106] = 20.91;
            Carbs[107] = 11.89;
            Carbs[108] = 12.65;
            Carbs[109] = 2.41;
            Carbs[110] = 32.6;
            /// W
            Carbs[111] = 86.3;
            Carbs[112] = 9.14;
            Carbs[113] = 0;
            Carbs[114] = 0;
            Carbs[115] = 0;
            /// X
            /// Y
            Carbs[116] = 1.4;
            Carbs[117] = 27.88;
            Carbs[118] = 27.58;
            Carbs[119] = 8.82;
            Carbs[120] = 27.58;
            /// Z
            Carbs[121] = 2.86;
            Carbs[122] = 3.35;
            Carbs[123] = 3.93;
            Carbs[124] = 3.59;
            Carbs[125] = 3.93;
            // PROTEIN
            // A [Esta letra se mantendra con un campo más]
            Protein[0] = 17.1;
            Protein[1] = 19.63;
            Protein[2] = 0.4;
            Protein[3] = 0.4;
            Protein[4] = 1.5;
            Protein[5] = 7.49;
            /// B
            Protein[6] = 0;
            Protein[7] = 0.64;
            Protein[8] = 7.59;
            Protein[9] = 20.62;
            Protein[10] = 8.04;
            /// C
            Protein[11] = 1.44;
            Protein[12] = 1.02;
            Protein[13] = 1.02;
            Protein[14] = 0.07;
            Protein[15] = 0.07;
            /// D
            Protein[16] = 0;
            Protein[17] = 0.06;
            Protein[18] = 2.7;
            Protein[19] = 2;
            Protein[20] = 2;
            /// E
            Protein[21] = 7.06;
            Protein[22] = 8.77;
            Protein[23] = 24.99;
            Protein[24] = 18.44;
            Protein[25] = 23.65;
            /// F
            Protein[26] = 13.31;
            Protein[27] = 9.5;
            Protein[28] = 10.6;
            Protein[29] = 1.42;
            Protein[30] = 10.6;
            /// G
            Protein[31] = 0.07;
            Protein[32] = 2.6;
            Protein[33] = 1.64;
            Protein[34] = 1.9;
            Protein[35] = 1.64;
            /// H
            Protein[36] = 18.91;
            Protein[37] = 24.24;
            Protein[38] = 20.93;
            Protein[39] = 18.26;
            Protein[40] = 17.97;
            /// I
            Protein[41] = 8.1;
            Protein[42] = 7.9;
            Protein[43] = 0.9;
            Protein[44] = 3.72;
            Carbs[45] = 5.22;
            /// J
            Protein[46] = 23.19;
            Protein[47] = 1.47;
            Protein[48] = 0.36;
            Protein[49] = 0.92;
            Protein[50] = 1.35;
            /// K
            Protein[51] = 9;
            Protein[52] = 3.3;
            Protein[53] = 1.9;
            Protein[54] = 2.66;
            Protein[55] = 1.9;
            /// L
            Protein[56] = 0.32;
            Protein[57] = 10.6;
            Protein[58] = 16.88;
            Protein[59] = 20.29;
            Protein[60] = 28.22;
            /// M
            Protein[61] = 11.19;
            Protein[62] = 7.91;
            Protein[63] = 5.8;
            Protein[64] = 19.86;
            Protein[65] = 8.08;
            /// N
            Protein[66] = 6.99;
            Protein[67] = 10.9;
            Protein[68] = 7.2;
            Protein[69] = 9.26;
            Protein[70] = 4.5;
            /// O
            Protein[71] = 17.3;
            Protein[72] = 3.21;
            Protein[73] = 10.7;
            Protein[74] = 10.4;
            Protein[75] = 8;
            /// P
            Protein[76] = 20.07;
            Protein[77] = 25.73;
            Protein[78] = 17.9;
            Protein[79] = 16.39;
            Protein[80] = 22.95;
            /// Q
            Protein[81] = 25.1;
            Protein[82] = 13.05;
            Protein[83] = 19.63;
            Protein[84] = 21.76;
            Protein[85] = 10.11;
            /// R
            Protein[86] = 20.05;
            Protein[87] = 29.06;
            Protein[88] = 3.81;
            Protein[89] = 1.43;
            Protein[90] = 30.38;
            /// S
            Protein[91] = 13.41;
            Protein[92] = 17.19;
            Protein[93] = 11.43;
            Protein[94] = 0.9;
            Protein[95] = 0;
            /// T
            Protein[96] = 1.29;
            Protein[97] = 0.07;
            Protein[98] = 7.9;
            Protein[99] = 12.8;
            Protein[100] = 6.68;
            /// U
            Protein[101] = 0;
            Protein[102] = 14.73;
            Protein[103] = 14.32;
            Protein[104] = 18.17;
            Protein[105] = 11.36;
            /// V
            Protein[106] = 25.09;
            Protein[107] = 1.04;
            Protein[108] = 0.06;
            Protein[109] = 0.05;
            Protein[110] = 4.8;
            /// W
            Protein[111] = 5.6;
            Protein[112] = 3.03;
            Protein[113] = 19.14;
            Protein[114] = 17.18;
            Protein[115] = 23.51;
            /// X
            /// Y
            Protein[116] = 14.8;
            Protein[117] = 1.53;
            Protein[118] = 1.49;
            Protein[119] = 0.72;
            Protein[120] = 1.49;
            /// Z
            Protein[121] = 0.07;
            Protein[122] = 1.21;
            Protein[123] = 0.64;
            Protein[124] = 1.16;
            Protein[125] = 0.64;
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            //lista de alimentos 2
            // FOOD
            // A [Esta letra se mantendra con un campo más]
            food[126] = "Adobo Fresco";
            food[127] = "Acorn Winter Squash";
            food[128] = "Acorn Winter Squash (Without Salt, Cooked, Baked)";
            food[129] = "Acorn Winter Squash (Without Salt, Mashed, Cooked, Boiled)";
            food[130] = "Acorn Winter Squash (With Salt, Cooked, Baked)";
            food[131] = "Acorn Winter Squash (With Salt, Mashed, Cooked, Boiled)";
            // B
            food[132] = "Baby Lima Beans (Mature Seeds, With Salt, Cooked, Boiled)";
            food[133] = "Bacon (Cured)";
            food[134] = "Bacon (Cured, Broiled, Pan-Fried Or Roasted, Cooked)";
            food[135] = "Bacon (Cured, Baked, Cooked)";
            food[136] = "Bacon (Cured, Microwaved, Cooked)";
            // C
            food[137] = "Caesar Salad Dressing";
            food[138] = "California Avocados";
            food[139] = "California And Arizona Pink And Red Grapefruit";
            food[140] = "Caesar Salad Dressing (Low Calorie)";
            food[141] = "California White Grapefruit";
            // D
            food[142] = "Dannon Fluoride To Go Non-Carbonated Bottled Water";
            food[143] = "Dannon Non-Carbonated Bottled Water";
            food[144] = "Dasani Non-Carbonated Bottled Water";
            food[145] = "Dark Molasses Archway Home Style Cookies";
            food[146] = "Dark Chocolate Powder Alsa Mousse Mix Cpc Desserts";
            // E
            food[147] = "Eastern Oyster (Farmed)";
            food[148] = "Egg (Whole)";
            food[149] = "Egg Bagels";
            food[150] = "Egg Bread";
            food[151] = "Egg And Onion Matzo";
            // F
            food[152] = "Farina Cereal (With Salt, Cooked With Water, Enriched)";
            food[153] = "Farmed Channel Catfish (Cooked, Dry Heat)";
            food[154] = "Farmed Atlantic Salmon (Cooked, Dry Heat)";
            food[155] = "Farmed Coho Salmon (Cooked, Dry Heat)";
            food[156] = "Farmed Rainbow Trout (Cooked, Dry Heat)";
            // G
            food[157] = "Garden Cress (With Salt, Drained, Cooked, Boiled)";
            food[158] = "Garlic Powder";
            food[159] = "Gazpacho Soup (Canned)";
            food[160] = "Garlic";
            food[161] = "Gefiltefish (Commercial, Sweet Recipe)";
            // H
            food[162] = "Ham (Boneless, Extra Lean (Approx 5% Fat), Low Sodium, Cured, Roasted)";
            food[163] = "Ham (Boneless, Regular (Approx 11% Fat), Cured, Roasted)";
            food[164] = "Ham (Center Slice, Country-Style, Lean Only, Cured)";
            food[165] = "Ham (Center Slice, Cured)";
            food[166] = "Ham (Boneless, Extra Lean And Regular, Cured, Roasted)";
            // I
            food[167] = "Iced Ginger Snaps Archway Home Style Cookies";
            food[168] = "Imitation Sour Cream (Cultured)";
            food[169] = "Immature Green Chili Hot Peppers (Canned)";
            food[170] = "Imitation Alaska King Crab (Made From Surimi)";
            food[171] = "Imitation Scallop (Mixed Species, Made From Surimi)";
            // J
            food[172] = "Jams And Preserves";
            food[173] = "Jar Traditional Prego 100% Natural Spaghetti Sauce Sauce";
            food[174] = "Jar Traditional Ragu Old World Style Smooth Pasta Sauce Lipton Sauce";
            food[175] = "Java-Plum (Jambolan)";
            food[176] = "Japanese Persimmons";
            // K
            food[177] = "Kale (With Salt, Frozen, Drained, Cooked, Boiled)";
            food[178] = "Kale (Without Salt, Frozen, Drained, Cooked, Boiled)";
            food[179] = "Kanpyo (Dried Gourd Strips)";
            food[180] = "Kale Scotch";
            food[181] = "Keebler Chocolate Graham Selects Keebler";
            // L
            food[182] = "Ladyfingers Cookies (With Lemon Juice And Rind)";
            food[183] = "Lamb (Trimmed To 1/4 Fat, Choice Grade, Cooked)";
            food[184] = "Lamb Cubed For Stew Or Kabob (Lean Only, Trimmed To 1/4 Fat)";
            food[185] = "Lamb Cubed For Stew Or Kabob (Lean Only, Trimmed To 1/4 Fat, Cooked, Braised)";
            food[186] = "Lamb Brain";
            // M
            food[187] = "Macaroni (Cooked)";
            food[188] = "Mace (Ground)";
            food[189] = "Malabar Spinach (Cooked)";
            food[190] = "Malt Beverage";
            food[191] = "Malted Drink Powder Mix (Natural)";
            // N
            food[192] = "Nacho Flavor Tortilla Chips (With Enriched Masa Flour)";
            food[193] = "Nachos With Cheese";
            food[194] = "Nachos With Cheese And Jalapeno Peppers";
            food[195] = "Native Persimmons";
            food[196] = "Napa Cabbage (Cooked)";
            // O
            food[197] = "Oat Bran Dinner Rolls";
            food[198] = "Oat Vegetable Oil";
            food[199] = "Oatmeal Bread";
            food[200] = "Oatmeal Bread (Reduced Calorie)";
            food[201] = "Oatmeal Cookie Dough";
            // P
            food[202] = "Pacific Herring (Fish) (Cooked, Dry Heat)";
            food[203] = "Palm Vegetable Oil";
            food[204] = "Palm Kernel Vegetable Oil";
            food[205] = "Pacific Rockfish (Mixed Species)";
            food[206] = "Pacific Rockfish (Mixed Species, Cooked, Dry Heat)";
            // Q
            food[207] = "Queen Crab (Cooked, Moist Heat)";
            food[208] = "Queso Anejo Cheese";
            food[209] = "Queso Asadero Cheese";
            food[210] = "Queso Chihuahua Cheese";
            food[211] = "Quinces";
            // R
            food[212] = "Raccoon Meat (Cooked, Roasted)";
            food[213] = "Radishes";
            food[214] = "Rainbow Smelt (Fish)";
            food[215] = "Rainbow Smelt (Fish) (Cooked, Dry Heat)";
            food[216] = "Rainbow Trout (Farmed)";
            // S
            food[217] = "Safflower Vegetable Oil (Over 70% Oleic)";
            food[218] = "Sage (Ground)";
            food[219] = "Salad Dressing (Home Recipe)";
            food[220] = "Salmon Fish Oil";
            food[221] = "Salami, Pork And Beef Beerwurst";
            // T
            food[222] = "Tahitian Taro";
            food[223] = "Tahini Sesame Butter Seeds (From Roasted And Toasted Kernels)";
            food[224] = "Tahini Sesame Butter Seeds (From Unroasted Kernels)";
            food[225] = "Tahini Sesame Butter Seeds (From Raw And Stone Ground Kernels)";
            food[226] = "Tahini Sesame Butter Seeds";
            // U
            food[227] = "Unsweetened Tablets Rennin Desserts";
            // V
            food[228] = "Vanilla Chocolate Strawberry No Sugar Added Breyers Ice Creams";
            food[229] = "Vanilla Extract (Imitation, No Alcohol)";
            food[230] = "Vanilla Ice Creams";
            food[231] = "Vanilla Fudge Candies";
            food[232] = "Vanilla Fudge Candies (With Nuts)";
            food[233] = "Vanilla Frostings (Dry Mix)";
            food[234] = "Vanilla Frozen Yogurts (Soft Serve)";
            food[235] = "Vanilla Ice Creams (Fat Free)";
            food[236] = "Vanilla Fudge Twirl No Sugar Added Breyers Ice Creams";
            // W
            food[237] = "Walleye Pike (Fish) (Cooked, Dry Heat)";
            food[238] = "Walnut Vegetable Oil";
            food[239] = "Wasabi Root";
            food[240] = "Water";
            food[241] = "Walrus Meat (Alaska Native)";
            // X
            // Y
            food[242] = "Yambean (Jicama) (With Salt, Drained, Cooked, Boiled)";
            food[243] = "Yardlong Bean";
            food[244] = "Yardlong Beans (Without Salt, Drained, Cooked, Boiled)";
            food[245] = "Yambean (Jicama) (Without Salt, Drained, Cooked, Boiled)";
            food[246] = "Yardlong Bean (With Salt, Drained, Cooked, Boiled)";
            food[247] = "Yautia (Tannier)";
            food[248] = "Yardlong Beans (Mature Seeds)";
            // Z
            food[249] = "Zucchini Summer Squash (With Salt, Frozen, Drained, Cooked, Boiled)";
            food[250] = "Zwieback";
            food[251] = "Zucchini Summer Squash (Without Salt, Frozen, Drained, Cooked, Boiled)";
            // CALORIES
            // A [Esta letra se mantendra con un campo más]
            calories[126] = 226;
            calories[127] = 40;
            calories[128] = 56;
            calories[129] = 34;
            calories[130] = 56;
            calories[131] = 34;
            // B
            calories[132] = 126;
            calories[133] = 458;
            calories[134] = 541;
            calories[135] = 548;
            calories[136] = 505;
            // C
            calories[137] = 528;
            calories[138] = 167;
            calories[139] = 37;
            calories[140] = 65;
            calories[141] = 96;
            // D
            calories[142] = 0;
            calories[143] = 0;
            calories[144] = 0;
            calories[145] = 411;
            calories[146] = 501;
            // E
            calories[147] = 59;
            calories[148] = 147;
            calories[149] = 278;
            calories[150] = 283;
            calories[151] = 391;
            // F
            calories[152] = 48;
            calories[153] = 152;
            calories[154] = 206;
            calories[155] = 178;
            calories[156] = 169;
            // G
            calories[157] = 23;
            calories[158] = 332;
            calories[159] = 19;
            calories[160] = 149;
            calories[161] = 84;
            // H
            calories[162] = 145;
            calories[163] = 178;
            calories[164] = 195;
            calories[165] = 203;
            calories[166] = 165;
            // I
            calories[167] = 466;
            calories[168] = 208;
            calories[169] = 20;
            calories[170] = 102;
            calories[171] = 99;
            // J
            calories[172] = 278;
            calories[173] = 105;
            calories[174] = 64;
            calories[175] = 60;
            calories[176] = 70;
            // K
            calories[177] = 30;
            calories[178] = 30;
            calories[179] = 258;
            calories[180] = 42;
            calories[181] = 465;
            // L
            calories[182] = 365;
            calories[183] = 294;
            calories[184] = 134;
            calories[185] = 223;
            calories[186] = 122;
            // M
            calories[187] = 158;
            calories[188] = 475;
            calories[189] = 23;
            calories[190] = 37;
            calories[191] = 429;
            // N
            calories[192] = 498;
            calories[193] = 306;
            calories[194] = 298;
            calories[195] = 127;
            calories[196] = 12;
            // O
            calories[197] = 236;
            calories[198] = 884;
            calories[199] = 269;
            calories[200] = 210;
            calories[201] = 424;
            // P
            calories[202] = 250;
            calories[203] = 884;
            calories[204] = 862;
            calories[205] = 94;
            calories[206] = 121;
            // Q
            calories[207] = 115;
            calories[208] = 373;
            calories[209] = 356;
            calories[210] = 374;
            calories[211] = 57;
            // R
            calories[212] = 255;
            calories[213] = 16;
            calories[214] = 97;
            calories[215] = 124;
            calories[216] = 138;
            // S
            calories[217] = 884;
            calories[218] = 315;
            calories[219] = 157;
            calories[220] = 902;
            calories[221] = 277;
            // T
            calories[222] = 44;
            calories[223] = 595;
            calories[224] = 607;
            calories[225] = 570;
            calories[226] = 592;
            // U
            calories[227] = 84;
            // V
            calories[228] = 143;
            calories[229] = 56;
            calories[230] = 201;
            calories[231] = 384;
            calories[232] = 435;
            calories[233] = 410;
            calories[234] = 163;
            calories[235] = 138;
            calories[236] = 153;
            // W
            calories[237] = 119;
            calories[238] = 884;
            calories[239] = 109;
            calories[240] = 0;
            calories[241] = 199;
            // X
            // Y
            calories[242] = 38;
            calories[243] = 47;
            calories[244] = 47;
            calories[245] = 38;
            calories[246] = 47;
            calories[247] = 98;
            calories[248] = 347;
            // Z
            calories[249] = 17;
            calories[250] = 426;
            calories[251] = 17;
            
            // FAT
            // A [Esta letra se mantendra con un campo más]
            fat[126] = 20.9;
            fat[127] = 0.1;
            fat[128] = 0.14;
            fat[129] = 0.08;
            fat[130] = 0.14;
            fat[131] = 0.08;
            // B
            fat[132] = 0.38;
            fat[133] = 45.04;
            fat[134] = 41.78;
            fat[135] = 43.27;
            fat[136] = 37.27;
            // C
            fat[137] = 57.7;
            fat[138] = 15.41;
            fat[139] = 0.1;
            fat[140] = 4.4;
            fat[141] = 0.1;
            // D
            fat[142] = 0;
            fat[143] = 0;
            fat[144] = 0;
            fat[145] = 12.17;
            fat[146] = 24.26;
            // E
            fat[147] = 1.55;
            fat[148] = 9.94;
            fat[149] = 2.1;
            fat[150] = 6;
            fat[151] = 3.9;
            // F
            fat[152] = 0.07;
            fat[153] = 8.02;
            fat[154] = 12.35;
            fat[155] = 8.23;
            fat[156] = 7.2;
            // G
            fat[157] = 0.6;
            fat[158] = 0.76;
            fat[159] = 0.1;
            fat[160] = 0.5;
            fat[161] = 1.73;
            // H
            fat[162] = 5.5;
            fat[163] = 11.15;
            fat[164] = 9.02;
            fat[165] = 8.32;
            fat[166] = 12.9;
            // I
            fat[167] = 18.96;
            fat[168] = 19.52;
            fat[169] = 0.1;
            fat[170] = 1.31;
            fat[171] = 0.41;
            // J
            fat[172] = 0.07;
            fat[173] = 3.9;
            fat[174] = 2.1;
            fat[175] = 0.23;
            fat[176] = 0.19;
            // K
            fat[177] = 0.4;
            fat[178] = 0.49;
            fat[179] = 5.8;
            fat[180] = 4.7;
            fat[181] = 3.6;
            // L
            fat[182] = 9.1;
            fat[183] = 20.94;
            fat[184] = 5.28;
            fat[185] = 8.8;
            fat[186] = 8.58;
            // M
            fat[187] = 0.93;
            fat[188] = 32.38;
            fat[189] = 0.78;
            fat[190] = 0.12;
            fat[191] = 9.52;
            // N
            fat[192] = 25.6;
            fat[193] = 16.77;
            fat[194] = 16.74;
            fat[195] = 0.4;
            fat[196] = 0.17;
            // O
            fat[197] = 4.6;
            fat[198] = 100;
            fat[199] = 4.4;
            fat[200] = 3.5;
            fat[201] = 18.9;
            // P
            fat[202] = 17.79;
            fat[203] = 100;
            fat[204] = 100;
            fat[205] = 1.57;
            fat[206] = 2.01;
            // Q
            fat[207] = 1.51;
            fat[208] = 29.98;
            fat[209] = 28.26;
            fat[210] = 29.68;
            fat[211] = 0.1;
            // R
            fat[212] = 14.5;
            fat[213] = 0.1;
            fat[214] = 2.42;
            fat[215] = 3.1;
            fat[216] = 5.4;
            // S
            fat[217] = 100;
            fat[218] = 12.75;
            fat[219] = 9.5;
            fat[220] = 100;
            fat[221] = 22.53;
            // T
            fat[222] = 0.97;
            fat[223] = 53.76;
            fat[224] = 56.44;
            fat[225] = 48;
            fat[226] = 53.01;
            // U
            fat[227] = 0.1;
            // V
            fat[228] = 0;
            fat[229] = 11;
            fat[230] = 5.44;
            fat[231] = 13.68;
            fat[232] = 4.9;
            fat[233] = 5.6;
            fat[234] = 0;
            fat[235] = 5.68;
            fat[236] = 0.18;
            // W
            fat[237] = 1.12;
            fat[238] = 1.56;
            fat[239] = 100;
            fat[240] = 0.63;
            fat[241] = 0;
            // X
            // Y
            fat[242] = 0.09;
            fat[243] = 0.4;
            fat[244] = 0.1;
            fat[245] = 0.09;
            fat[246] = 0.1;
            fat[247] = 0.4;
            fat[248] = 1.31;
            // Z
            fat[249] = 0.13;
            fat[250] = 9.7;
            fat[251] = 0.13;
            
            // CARBS
            
            // A [Esta letra se mantendra con un campo más]
            Carbs[126] = 18.6;
            Carbs[127] = 10.42;
            Carbs[128] = 14.58;
            Carbs[129] = 8.79;
            Carbs[130] = 14.58;
            Carbs[131] = 8.79;
            // B
            Carbs[132] = 23.31;
            Carbs[133] = 0.66;
            Carbs[134] = 1.43;
            Carbs[135] = 1.35;
            Carbs[136] = 1.05;
            // C
            Carbs[137] = 3.1;
            Carbs[138] = 8.64;
            Carbs[139] = 9.69;
            Carbs[140] = 18.60;
            Carbs[141] = 9.09;
            // D
            Carbs[142] = 0.03;
            Carbs[143] = 0;
            Carbs[144] = 0;
            Carbs[145] = 71.68;
            Carbs[146] = 61.33;
            // E
            Carbs[147] = 5.53;
            Carbs[148] = 0.77;
            Carbs[149] = 53;
            Carbs[150] = 47.8;
            Carbs[151] = 77.1;
            // F
            Carbs[152] = 10.47;
            Carbs[153] = 0;
            Carbs[154] = 0;
            Carbs[155] = 0;
            Carbs[156] = 0;
            // G
            Carbs[157] = 3.8;
            Carbs[158] = 72.71;
            Carbs[159] = 1.8;
            Carbs[160] = 33.06;
            Carbs[161] = 7.41;
            // H
            Carbs[162] = 1.5;
            Carbs[163] = 3.65;
            Carbs[164] = 0;
            Carbs[165] = 0.3;
            Carbs[166] = 0.05;
            // I
            Carbs[167] = 70.85;
            Carbs[168] = 6.63;
            Carbs[169] = 5;
            Carbs[170] = 10.22;
            Carbs[171] = 10.62;
            // J
            Carbs[172] = 68.86;
            Carbs[173] = 16;
            Carbs[174] = 9.69;
            Carbs[175] = 15.56;
            Carbs[176] = 18.59;
            // K
            Carbs[177] = 5.63;
            Carbs[178] = 5.23;
            Carbs[179] = 67.9;
            Carbs[180] = 76;
            Carbs[181] = 81.8;
            // L
            Carbs[182] = 59.7;
            Carbs[183] = 0;
            Carbs[184] = 0;
            Carbs[185] = 0;
            Carbs[186] = 0;
            // M
            Carbs[187] = 30.86;
            Carbs[188] = 50.5;
            Carbs[189] = 2.71;
            Carbs[190] = 8.05;
            Carbs[191] = 71.43;
            // N
            Carbs[192] = 62.4;
            Carbs[193] = 32.15;
            Carbs[194] = 29.45;
            Carbs[195] = 33.5;
            Carbs[196] = 2.23;
            // O
            Carbs[197] = 40.2;
            Carbs[198] = 0;
            Carbs[199] = 48.5;
            Carbs[200] = 43.3;
            Carbs[201] = 59.1;
            // P
            Carbs[202] = 0;
            Carbs[203] = 0;
            Carbs[204] = 0;
            Carbs[205] = 0;
            Carbs[206] = 0;
            // Q
            Carbs[207] = 0;
            Carbs[208] = 4.63;
            Carbs[209] = 2.87;
            Carbs[210] = 5.56;
            Carbs[211] = 15.3;
            // R
            Carbs[212] = 0;
            Carbs[213] = 3.4;
            Carbs[214] = 0;
            Carbs[215] = 0;
            Carbs[216] = 0;
            // S
            Carbs[217] = 0;
            Carbs[218] = 60.73;
            Carbs[219] = 14.9;
            Carbs[220] = 0;
            Carbs[221] = 3.76;
            // T
            Carbs[222] = 6.91;
            Carbs[223] = 21.19;
            Carbs[224] = 17.89;
            Carbs[225] = 26.19;
            Carbs[226] = 21.5;
            // U
            Carbs[227] = 19.8;
            // V
            Carbs[228] = 14.4;
            Carbs[229] = 23.6;
            Carbs[230] = 82.28;
            Carbs[231] = 74.74; 
            Carbs[232] = 93.8;
            Carbs[233] = 24.2;
            Carbs[234] = 30.06;
            Carbs[235] = 25.63;
            Carbs[236] = 7.5;
            // W
            Carbs[237] = 0;
            Carbs[238] = 0;
            Carbs[239] = 0;
            Carbs[240] = 23.54;
            Carbs[241] = 0;
            // X
            // Y
            Carbs[242] = 8.32;
            Carbs[243] = 8.35;
            Carbs[244] = 9.18;
            Carbs[245] = 8.82;
            Carbs[246] = 9.17;
            Carbs[247] = 23.63;
            Carbs[248] = 61.91;
            // Z
            Carbs[249] = 3.56;
            Carbs[250] = 74.2;
            Carbs[251] = 3.56;
            
            // PROTEIN
        
            // A [Esta letra se mantendra con un campo más]
            Protein[126] = 2;
            Protein[127] = 0.8;
            Protein[128] = 1.12;
            Protein[129] = 0.67;
            Protein[130] = 1.12;
            Protein[131] = 0.67;
            // B
            Protein[132] = 8.04;
            Protein[133] = 11.6;
            Protein[134] = 37.04;
            Protein[135] = 35.73;
            Protein[136] = 38.72;
            // C
            Protein[137] = 1.2;
            Protein[138] = 1.96;
            Protein[139] = 0.5;
            Protein[140] = 0.3;
            Protein[141] = 0.88;
            // D
            Protein[142] = 0;
            Protein[143] = 0;
            Protein[144] = 0;
            Protein[145] = 4.23;
            Protein[146] = 9.43;
            // E
            Protein[147] = 5.22;
            Protein[148] = 12.58;
            Protein[149] = 10.6;
            Protein[150] = 9.5;
            Protein[151] = 10;
            // F
            Protein[152] = 1.42;
            Protein[153] = 18.72;
            Protein[154] = 22.1;
            Protein[155] = 24.3;
            Protein[156] = 24.27;
            // G
            Protein[157] = 1.9;
            Protein[158] = 16.8;
            Protein[159] = 2.9;
            Protein[160] = 6.36;
            Protein[161] = 9.07;
            // H
            Protein[162] = 20.9;
            Protein[163] = 16.3;
            Protein[164] = 22.62;
            Protein[165] = 27.8;
            Protein[166] = 20.17;
            // I
            Protein[167] = 3.66;
            Protein[168] = 2.4;
            Protein[169] = 0.7;
            Protein[170] = 12.02;
            Protein[171] = 12.77;
            // J
            Protein[172] = 0.37;
            Protein[173] = 1.7;
            Protein[174] = 1.5;
            Protein[175] = 0.72;
            Protein[176] = 0.58;
            // K
            Protein[177] = 1.9;
            Protein[178] = 2.84;
            Protein[179] = 17.5;
            Protein[180] = 12.6;
            Protein[181] = 9.4;
            // L
            Protein[182] = 10.6;
            Protein[183] = 24.52;
            Protein[184] = 20.21;
            Protein[185] = 33.69;
            Protein[186] = 10.40;
            // M
            Protein[187] = 5.8;
            Protein[188] = 6.71;
            Protein[189] = 2.98;
            Protein[190] = 0.21;
            Protein[191] = 14.29;
            // N
            Protein[192] = 7.8;
            Protein[193] = 8.05;
            Protein[194] = 8.24;
            Protein[195] = 0.8;
            Protein[196] = 1.1;
            // O
            Protein[197] = 9.5;
            Protein[198] = 0;
            Protein[199] = 8.4;
            Protein[200] = 7.6;
            Protein[201] = 5.4;
            // P
            Protein[202] = 21.01;
            Protein[203] = 0;
            Protein[204] = 0;
            Protein[205] = 18.75;
            Protein[206] = 24.04;
            // Q
            Protein[207] = 23.72;
            Protein[208] = 21.44;
            Protein[209] = 22.6;
            Protein[210] = 21.56;
            Protein[211] = 0.4;
            // R
            Protein[212] = 29.2;
            Protein[213] = 0.68;
            Protein[214] = 17.63;
            Protein[215] = 22.6;
            Protein[216] = 20.87;
            // S
            Protein[217] = 0;
            Protein[218] = 10.63;
            Protein[219] = 4.2;
            Protein[220] = 0;
            Protein[221] = 14;
            // T
            Protein[222] = 2.79;
            Protein[223] = 17;
            Protein[224] = 17.59;
            Protein[225] = 17.8;
            Protein[226] = 17.4;
            // U
            Protein[227] = 1;
            // V
            Protein[228] = 0.03;
            Protein[229] = 3.5;
            Protein[230] = 1.05;
            Protein[231] = 3;
            Protein[232] = 0.3;
            Protein[233] = 4;
            Protein[234] = 4.48;
            Protein[235] = 3.53;
            Protein[236] = 3.86;
            // W
            Protein[237] = 23.51;
            Protein[238] = 24.54;
            Protein[239] = 0;
            Protein[240] = 4.8;
            Protein[241] = 0;
            // X
            // Y
            Protein[242] = 0.72;
            Protein[243] = 2.8;
            Protein[244] = 2.53;
            Protein[245] = 0.72;
            Protein[246] = 2.53;
            Protein[247] = 1.46;
            Protein[248] = 24.33;
            // Z
            Protein[249] = 1.15;
            Protein[250] = 10.1;
            Protein[251] = 1.15;

        }
        private void tEventsChecked(object sender, RoutedEventArgs e)
        {
            tEvents.Content = "g";
            slider.Value = 90.001;
            if (encontrado == false)
            {
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
            }
                else
            {
                if (encontrado ==true)
                {
                    if (gr == true)
                    {
                        txt2.Text = Calorias + " Kcal";
                        txt3.Text = Grasas + " g";
                        txt4.Text = Carbohidratos + " g";
                        txt5.Text = Proteinas + " g";
                    }
                    else
                    {
                        if (gr == false)
                        {

                            txt2.Text = Calorias + " Kcal";
                            txt3.Text = Grasas + " g";
                            txt4.Text = Carbohidratos +" g";
                            txt5.Text = Proteinas + " g";
                            gr = true;
                        }
                    }
                }
            }
        }
        private void tEventsUnchecked(object sender, RoutedEventArgs e)
        {
            tEvents.Content = "oz";
            slider.Value = 90;

            if (encontrado == false)
            {
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
            }
            else
            {
                if (encontrado == true)
                {
                    if (gr == false)
                    {
                        txt2.Text = Calorias + " Kcal";
                        txt3.Text = Grasas + " oz";
                        txt4.Text = Carbohidratos + " oz";
                        txt5.Text = Proteinas + " oz";
        
              
                    }
                    else
                    {
                        if (gr == true)
                        {
                            txt2.Text = Calorias + " Kcal";
                            txt3.Text = Math.Round(Grasas / 28.35, 2) + " oz";
                            txt4.Text = Math.Round(Carbohidratos / 28.35, 2) + " oz";
                            txt5.Text = Math.Round(Proteinas / 28.35, 2) + "oz";
                            gr = false;
                        }
                    }
                }
            }






        }
        private void Button1_Click_1(object sender, RoutedEventArgs e)
{
            slider.Visibility = Visibility.Visible;
            slider.Value = 90.0001;
            String comida;
            comida = acBox.Text;
            String Escaneo;


            if (comida == "")
            {
                txt1.Text = "Please Fill the Fields";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
            }
            else
            {
                for (int i = 0; i < 251; i++)
                {
                    Escaneo = food[i];
                    if (Escaneo.ToLower() == comida.ToLower())
                    {
                        if (tEvents.IsChecked == true)
                        {
                            txt1.Text = food[i];
                            txt2.Text = calories[i] + " Kcal";
                            Cal = calories[i];
                            Calorias = Cal;
                            txt3.Text = fat[i] + " g";
                            Fa = fat[i];
                            Grasas = Fa;
                            txt4.Text = Carbs[i] + " g";
                            car = Carbs[i];
                            Carbohidratos = car; 
                            txt5.Text = Protein[i] + " g";
                            Pro = Protein[i];
                            Proteinas = Pro;
                            i = 251;
                            acBox.Text = "";
                            encontrado = true;

                            if (car <= 15)
                            {
                                bueno();
                            }

                            if (car > 15 && car < 30)
                            {
                                regular();
                            }

                            if (car >= 30)
                            {
                                malo();
                            }
                        }
                        else
                        {

                            if (tEvents.IsChecked == false )
                            {
                                txt1.Text = food[i];
                                txt2.Text = calories[i] + " Kcal";
                                Cal = calories[i];
                                Calorias = Cal;
                                txt3.Text = Math.Round(fat[i] / 28.35,2) + " oz";
                                Fa = fat[i];
                                Grasas = Fa;
                                txt4.Text = Math.Round(Carbs[i] / 28.35,2) + " oz";
                                car = Carbs[i];
                                Carbohidratos = car; 
                                txt5.Text = Math.Round(Protein[i] / 28.35,2) + "oz";
                                Pro = Protein[i];
                                Proteinas = Pro;
                                i = 251;
                                acBox.Text = "";
                                encontrado = true;

                                if (car <= 15)
                                {
                                    bueno();
                                }

                                if (car > 15 && car < 30)
                                {
                                    regular();
                                }

                                if (car >= 30)
                                {
                                    malo();
                                }
                            }
                        }
                    }
                    else
                    {
                        txt1.Text ="The food is not in our database";
                        txt2.Text ="";
                        txt3.Text ="";
                        txt4.Text ="";
                        txt5.Text = "";
                        encontrado = false;
                    }
                }
            }
        }
        private void malo()
        {
            rojo.Width = 480;
            
            if (cont == 0)
            {
                TextAlert.Text = "Not good For You!";
            }
            if (cont == 1)
            {
                TextAlert.Text = "Stop!";
            }
            if (cont == 2)
            {
                TextAlert.Text = "Caution!";
            }
            
            cont = cont + 1;

            if (cont == 3)
            {
                cont = 0;
            }
        }
        private void regular()
        {
            amarillo.Width = 480;
            if (cont == 0)
            {
                TextAlert.Text = "Are you sure?";
            }
            if (cont == 1)
            {
                TextAlert.Text = "Keep going.";
            }
            if (cont == 2)
            {
                TextAlert.Text = "Try Again";
            }
           
            cont = cont + 1;

            if (cont == 3)
            {
                cont = 0;
            }
        }
        private void bueno()
        {
            verde.Width = 480;
            if (cont == 0)
            {
                TextAlert.Text = "Super Good!";
            }
            if (cont == 1)
            {
                TextAlert.Text = "Good Choice";
            }
            if (cont == 2)
            {
                TextAlert.Text = "Sure";
            }
                cont = cont +1;

            if (cont == 3)
            {
                cont = 0;
            }





        }
        private void verde_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            verde.Width = 0;
            TextAlert.Text = "";
        }
        private void amarillo_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            amarillo.Width = 0;
            TextAlert.Text = "";
        }
        private void rojo_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            rojo.Width = 0;
            TextAlert.Text = "";
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            double Unidad;
            Unidad = (slider.Value) + 10;

            if (tEvents.IsChecked == true)
            {
                Based.Text = "Based on " + Convert.ToString (Math.Round(Unidad, 0)) + "g(" + Convert.ToString(Math.Round(Unidad * 0.035, 1)) + " oz)";
                txt2.Text = Math.Round(Calorias * Unidad/100 , 2) + " Kcal";
                txt3.Text = Math.Round(Grasas * Unidad/100 ,2) + " g";
                txt4.Text = Math.Round(Carbohidratos * Unidad/100 , 2) + " g";
                txt5.Text = Math.Round(Proteinas * Unidad/100 , 2) + " g";
            }

            if (tEvents.IsChecked == false)
            {
                Based.Text = "Based on " + Convert.ToString(Math.Round(Unidad * 0.035, 1)) + "oz(" + Convert.ToString(Math.Round(Unidad, 0)) + " gr)";
                txt2.Text = Math.Round(Calorias * ( Unidad / 100 ),1) + " Kcal";
                txt3.Text = Math.Round(Grasas * (Unidad / 100),1) + " oz";
                txt4.Text = Math.Round(Carbohidratos * (Unidad / 100),1) + " oz";
                txt5.Text = Math.Round(Proteinas * (Unidad / 100),1) + " oz";
            }

        }
    }
}