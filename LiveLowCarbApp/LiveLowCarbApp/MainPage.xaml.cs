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
            string[] food = new string[126];
            double[] calories = new double[126];
            double[] fat = new double[126];
            double[] Carbs = new double[126];
            double[] Protein = new double[126];
        public MainPage()
            {
                InitializeComponent();
                llenar();
                AutoCompletar();
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
            //lista de alimentos
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

        }
        private void Button1_Click_1(object sender, RoutedEventArgs e)
{ 
         
            String comida;
            comida = acBox.Text;
            String Escaneo;
            Double Cal;
            Double Fa;
            Double car;
            Double Pro;

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
                for (int i = 0; i < 125; i++)
                {
                    Escaneo = food[i];
                    if (Escaneo.ToLower() == comida.ToLower())
                    {
                        txt1.Text = food[i];
                        txt2.Text = "Calories " + calories[i] + " Kcal";
                        Cal = calories[i];
                        txt3.Text = "Fat " + fat[i] + " g";
                        Fa = fat[i];
                        txt4.Text = "Carbs " + Carbs[i] + " g";
                        car = Carbs[i];
                        txt5.Text = "Protein " + Protein[i] + " g";
                        Pro = Protein[i];
                        i = 125;
                        acBox.Text = "";
                    }
                    else
                    {
                        txt1.Text ="The food is not in our database";
                        txt2.Text ="";
                        txt3.Text ="";
                        txt4.Text ="";
                        txt5.Text = "";
                    }
                }
            }
        }
    }
}