namespace Sword_and_flame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            //assemblyLocation += ;
            //assemblyLocation.Substring(2);
            GameGlobalData.final_project_location = assemblyLocation.Substring(8, assemblyLocation.Length - 27) + "Resourses/";
            if (GameGlobalData.game_global_data_creation_count == 0)
            {
                // // // // // DATA IS NOT STATIC!!! IT WILL BE SET AS A PROJECT LOCATION // // // // //
                // I NEED FINISH ALL LOOT AND LEVEL DEVELOPMENT AND SET A PROJECT LOCATION FOLDER AS A FILE LOAD FOLDER

                //// LOOT PROPERTIES
                {
                    // РУКА
                    Loot eqp001 = new Loot("1", "Тренувальний меч", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 1, 1, 1, 0, 0, 20, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp002 = new Loot("2", "Довгий меч", "Рука", "Воїн, Паладін", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 0, 1, 1, 0, 0, 35, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp003 = new Loot("3", "Меч короля Артура", "Рука", "Воїн", 10, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 5, 1, 0, 2, 0, 0, 70, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp004 = new Loot("4", "Зачарований меч", "Рука", "Паладін, Чарівник", 4, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 2, 1, 2, 0, 0, 50, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp005 = new Loot("5", "Важка сокира", "Рука", "Воїн", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 4, 0, 0, 0, -1, 0, 30, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp006 = new Loot("6", "Зламаний клинок", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 2, 0, 0, 0, 0, 10, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp007 = new Loot("7", "Заточений кінжал", "Рука", "Воїн, Паладін, Лучник, Чарівник", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 1, 0, 0, 0, 0, 15, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp008 = new Loot("8", "Шпага", "Рука", "Воїн, Лучник", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 3, 0, 0, 0, 0, 25, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp009 = new Loot("9", "Сокира лісоруба", "Рука", "Воїн, Паладін", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 1, 0, 0, 0, 0, 25, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));

                    Loot eqp011 = new Loot("10", "Магічний тризуб", "Рука", "Паладін, Лучник, Чарівник", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 2, 0, 0, 0, 1, 25, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp012 = new Loot("11", "Меч темного лицаря", "Рука", "Воїн, Паладін", 10, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 4, 2, 0, 0, 0, 0, 60, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp013 = new Loot("12", "Саморобний ніж", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 1, 0, 0, 0, 0, 5, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp014 = new Loot("13", "Срібна алебарда", "Рука", "Паладін", 4, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 4, 0, 0, 0, 0, 0, 40, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp015 = new Loot("14", "Звичайна булава", "Рука", "Воїн, Паладін", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 3, 2, 0, 0, 0, -1, 30, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp016 = new Loot("15", "Широкий меч", "Рука", "Воїн, Паладін", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 0, 2, 0, 0, 0, 40, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp017 = new Loot("16", "Кровавий кинжал", "Рука", "Воїн, Лучник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 4, 0, 0, 0, 0, 20, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp018 = new Loot("17", "Кам'яний меч", "Рука", "Воїн, Паладін", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 1, 0, 0, 0, -1, 15, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp019 = new Loot("18", "Булава відлюдника", "Рука", "Воїн, Паладін", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 6, 0, 0, 0, 0, 30, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));

                    Loot eqp021 = new Loot("19", "Походна палиця", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 1, 0, 1, 0, 1, 20, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp022 = new Loot("20", "Варварський меч", "Рука", "Воїн, Паладін, Лучник", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 1, 1, 1, 0, 0, 30, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp023 = new Loot("21", "Дубина", "Рука", "Воїн, Паладін", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 4, 0, 0, 0, 0, 20, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp024 = new Loot("22", "Сарацинський меч", "Рука", "Воїн, Паладін, Лучник", 3, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 1, 0, 1, 0, 0, 30, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp025 = new Loot("23", "Важка кувалда", "Рука", "Паладін", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 5, 0, 0, 0, -1, 15, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp026 = new Loot("24", "Посох сенсея", "Рука", "Лучник, Чарівник", 2, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 0, 1, 1, 3, 0, 1, 40, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp027 = new Loot("25", "Тонкий меч", "Рука", "Воїн, Паладін, Лучник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 0, 1, 0, 0, 0, 20, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp028 = new Loot("26", "Саморобний спис", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 1, 2, 0, 1, 0, 0, 25, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp029 = new Loot("27", "Титановий гладіус", "Рука", "Воїн, Паладін, Лучник, Чарівник", 7, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 3, 3, 0, 0, 0, 0, 45, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    Loot eqp030 = new Loot("28", "Вогняний палаш", "Рука", "Паладін, Чарівник", 5, LifeObject.generate_random_X(), LifeObject.generate_random_Y(), 2, 2, 0, 3, 0, 0, 45, Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"), Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/FINAL_MAP.png"));
                    //Loot eqp031 = new Loot("Заточена секіра", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LevelObjects.generate_random_X(), LevelObjects.generate_random_Y(), 0, 1, 0, 0, 0, 0, 5);
                    //Loot eqp032 = new Loot("Саморобний ніж", "Рука", "Воїн, Паладін, Лучник, Чарівник", 1, LevelObjects.generate_random_X(), LevelObjects.generate_random_Y(), 0, 1, 0, 0, 0, 0, 5);


                    // ТУЛУБ
                    //Loot eqp08 = new Loot("Накидка мандрівника", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp06 = new Loot("Прості обладунки", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp07 = new Loot("", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp08 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp09 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp10 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp11 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp12 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp13 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);
                    //Loot eqp14 = new Loot("Зачарований меч", "Паладін, Чарівник", 5, 9, 9, 2, 2, 0, 0, 20);

                    //l.Notify += turn();
                    // НОГИ

                    // ГОЛОВА

                    // СУМКА


                    Loot.LootList.Add(eqp001);
                    Loot.LootList.Add(eqp002);
                    Loot.LootList.Add(eqp003);
                    Loot.LootList.Add(eqp004);
                    Loot.LootList.Add(eqp005);
                    Loot.LootList.Add(eqp006);
                    Loot.LootList.Add(eqp007);
                    Loot.LootList.Add(eqp008);
                    Loot.LootList.Add(eqp009);
                    //Loot.LootList.Add(eqp010);
                    Loot.LootList.Add(eqp011);
                    Loot.LootList.Add(eqp012);
                    Loot.LootList.Add(eqp013);
                    Loot.LootList.Add(eqp014);
                    Loot.LootList.Add(eqp015);
                    Loot.LootList.Add(eqp016);
                    Loot.LootList.Add(eqp017);
                    Loot.LootList.Add(eqp018);
                    Loot.LootList.Add(eqp019);
                    //Loot.LootList.Add(eqp020);
                    Loot.LootList.Add(eqp021);
                    Loot.LootList.Add(eqp022);
                    Loot.LootList.Add(eqp023);
                    Loot.LootList.Add(eqp024);
                    Loot.LootList.Add(eqp025);
                    Loot.LootList.Add(eqp026);
                    Loot.LootList.Add(eqp027);
                    Loot.LootList.Add(eqp028);
                    Loot.LootList.Add(eqp029);
                    Loot.LootList.Add(eqp030);
                    //Loot.LootList.Add(eqp031);
                }
                //// LEVEL PROPERTIES
                {
                    LevelProperties LP_level_obj1 = new LevelProperties("1", 1, "Початок великої подорожі", "story", false, "Грабіжник", 1, "Вбивця", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/1 19 20 23.jpg"));
                    LevelProperties LP_level_obj2 = new LevelProperties("2", 1, "Там, де закінчується трава", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/2.jpg"));
                    LevelProperties LP_level_obj3 = new LevelProperties("3", 1, "Жито та млини", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/3 5.jpg"));
                    LevelProperties LP_level_obj4 = new LevelProperties("4", 1, "Золоті пагорби", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/4 21.jpg"));
                    LevelProperties LP_level_obj5 = new LevelProperties("5", 1, "level_5", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/3 5.jpg"));
                    LevelProperties LP_level_obj6 = new LevelProperties("6", 1, "level_6", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/6 24.jpg"));
                    LevelProperties LP_level_obj7 = new LevelProperties("7", 1, "level_7", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/7.jpg"));
                    LevelProperties LP_level_obj8 = new LevelProperties("8", 2, "level_8", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/8.jpg"));
                    LevelProperties LP_level_obj9 = new LevelProperties("9", 2, "level_9", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/9.jpg"));
                    LevelProperties LP_level_obj10 = new LevelProperties("10", 2, "level_10", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/10.jpg"));
                    LevelProperties LP_level_obj11 = new LevelProperties("11", 2, "level_11", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/11 12.jpg"));
                    LevelProperties LP_level_obj12 = new LevelProperties("12", 2, "level_12", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/11 12.jpg"));
                    LevelProperties LP_level_obj13 = new LevelProperties("13", 2, "level_13", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/13.jpg"));
                    LevelProperties LP_level_obj14 = new LevelProperties("14", 2, "level_14", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/14 22.jpg"));
                    LevelProperties LP_level_obj15 = new LevelProperties("15", 2, "level_15", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/15 17.jpg"));
                    LevelProperties LP_level_obj16 = new LevelProperties("16", 2, "level_16", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/16.jpg"));
                    LevelProperties LP_level_obj17 = new LevelProperties("17", 3, "level_17", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/15 17.jpg"));
                    LevelProperties LP_level_obj18 = new LevelProperties("18", 3, "level_18", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/18.jpg"));
                    LevelProperties LP_level_obj19 = new LevelProperties("19", 3, "level_19", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/1 19 20 23.jpg"));
                    LevelProperties LP_level_obj20 = new LevelProperties("20", 3, "level_20", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/1 19 20 23.jpg"));
                    LevelProperties LP_level_obj21 = new LevelProperties("21", 3, "level_21", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/4 21.jpg"));
                    LevelProperties LP_level_obj22 = new LevelProperties("22", 3, "level_22", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/14 22.jpg"));
                    LevelProperties LP_level_obj23 = new LevelProperties("23", 3, "level_23", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/1 19 20 23.jpg"));
                    LevelProperties LP_level_obj24 = new LevelProperties("24", 3, "level_24", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/6 24.jpg"));
                    LevelProperties LP_level_obj25 = new LevelProperties("25", 3, "level_25", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/25.jpg"));
                    LevelProperties LP_level_obj26 = new LevelProperties("26", 3, "level_26", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/26.jpg"));
                    LevelProperties LP_level_obj27 = new LevelProperties("27", 3, "level_27", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/27.jpg"));
                    LevelProperties LP_level_obj28 = new LevelProperties("28", 4, "level_28", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/28.jpg"));
                    LevelProperties LP_level_obj29 = new LevelProperties("29", 4, "level_29", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/29 30.jpg"));
                    LevelProperties LP_level_obj30 = new LevelProperties("30", 4, "level_30", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/29 30.jpg"));
                    LevelProperties LP_level_obj31 = new LevelProperties("31", 4, "level_31", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/31.jpg"));
                    LevelProperties LP_level_obj32 = new LevelProperties("32", 4, "level_32", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/32.jpg"));
                    LevelProperties LP_level_obj33 = new LevelProperties("33", 4, "level_33", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/33.jpg"));
                    LevelProperties LP_level_obj34 = new LevelProperties("34", 4, "level_34", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/34.jpg"));
                    LevelProperties LP_level_obj35 = new LevelProperties("35", 4, "level_35", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/35.jpg"));
                    LevelProperties LP_level_obj36 = new LevelProperties("36", 4, "level_36", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/36 38.jpg"));
                    LevelProperties LP_level_obj37 = new LevelProperties("37", 4, "level_37", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/37.jpg"));
                    LevelProperties LP_level_obj38 = new LevelProperties("38", 5, "level_38", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/36 38.jpg"));
                    LevelProperties LP_level_obj39 = new LevelProperties("39", 5, "level_39", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/39.jpg"));
                    LevelProperties LP_level_obj40 = new LevelProperties("40", 5, "level_40", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/40.jpg"));
                    LevelProperties LP_level_obj41 = new LevelProperties("41", 5, "level_41", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/41 42.jpg"));
                    LevelProperties LP_level_obj42 = new LevelProperties("42", 5, "level_42", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/41 42.jpg"));
                    LevelProperties LP_level_obj43 = new LevelProperties("43", 5, "level_43", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/43 44.jpg"));
                    LevelProperties LP_level_obj44 = new LevelProperties("44", 5, "level_44", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Levels/43 44.jpg"));
                    LevelProperties LP_city_obj1 = new LevelProperties("45", 0, "Вістред", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/wistred.jpg"));
                    LevelProperties LP_city_obj2 = new LevelProperties("46", 0, "Кверат", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/wistred.jpg")); //////
                    LevelProperties LP_city_obj3 = new LevelProperties("47", 0, "Данкірм", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/dankirm.jpg"));
                    LevelProperties LP_city_obj4 = new LevelProperties("48", 0, "Тайрен", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/tiren.jpg"));
                    LevelProperties LP_city_obj5 = new LevelProperties("49", 0, "Еквінсет", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/equinset.jpg"));
                    LevelProperties LP_city_obj6 = new LevelProperties("50", 0, "Асемель", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/asemel.jpg"));
                    LevelProperties LP_city_obj7 = new LevelProperties("51", 0, "Розенест", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/rosennest.jpg"));
                    LevelProperties LP_city_obj8 = new LevelProperties("52", 0, "Аурефорт", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/aurefort.jpg"));
                    LevelProperties LP_city_obj9 = new LevelProperties("53", 0, "Ауреаструм", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/aureastrum.jpg"));
                    LevelProperties LP_city_obj10 = new LevelProperties("54", 0, "Арбінат", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/arbinat.jpg"));
                    LevelProperties LP_city_obj11 = new LevelProperties("55", 0, "Кевервуд", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/keverwood.jpg"));
                    LevelProperties LP_city_obj12 = new LevelProperties("56", 0, "Акарейн", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/akarayn.jpg"));
                    LevelProperties LP_city_obj13 = new LevelProperties("57", 0, "Талобейн", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/talobane.jpg"));
                    LevelProperties LP_city_obj14 = new LevelProperties("58", 0, "Мгнхагат", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/mgnhagat.jpg"));
                    LevelProperties LP_city_obj15 = new LevelProperties("59", 0, "Драглок", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/draglock.jpg"));
                    LevelProperties LP_city_obj16 = new LevelProperties("60", 0, "Рівенпорт", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/rivenport.jpg"));
                    LevelProperties LP_city_obj17 = new LevelProperties("61", 0, "Тальде", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/talde.jpg"));
                    // ??? WHAT DO WE HAVE HERE ???
                    LevelProperties LP_obj_obj1 = new LevelProperties("62", -1, "Руїни рілотського лісу", "story", false, "bm", 1, "sm", Image.FromFile("D:/Dmitry/Саморозвиток/Прорамування/Мої проекти/Sword and flame/Зображення/Wallpaper/Рівні/Cities/wistred.jpg"));
                    LevelProperties LP_obj_obj2 = new LevelProperties("63", -1, "Самотня гора", "story", false, "bm", 1, "sm", Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/main_flag_test.png"));
                    LevelProperties LP_obj_obj3 = new LevelProperties("64", -1, "Квіткодрево", "story", false, "bm", 1, "sm", Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/main_flag_test.png"));
                    LevelProperties LP_obj_obj4 = new LevelProperties("65", -1, "Рівенспік", "story", false, "bm", 1, "sm", Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/main_flag_test.png"));
                    LevelProperties LP_obj_obj5 = new LevelProperties("66", -1, "name", "story", false, "bm", 1, "sm", Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/main_flag_test.png"));
                    LevelProperties LP_obj_obj6 = new LevelProperties("67", -1, "name", "story", false, "bm", 1, "sm", Image.FromFile("C:/Users/Dmitry/source/repos/Castle Crushers/Castle Crushers/Resources/main_flag_test.png"));

                    LevelProperties.level_list.Add(LP_level_obj1);
                    LevelProperties.level_list.Add(LP_level_obj2);
                    LevelProperties.level_list.Add(LP_level_obj3);
                    LevelProperties.level_list.Add(LP_level_obj4);
                    LevelProperties.level_list.Add(LP_level_obj5);
                    LevelProperties.level_list.Add(LP_level_obj6);
                    LevelProperties.level_list.Add(LP_level_obj7);
                    LevelProperties.level_list.Add(LP_level_obj8);
                    LevelProperties.level_list.Add(LP_level_obj9);
                    LevelProperties.level_list.Add(LP_level_obj10);
                    LevelProperties.level_list.Add(LP_level_obj11);
                    LevelProperties.level_list.Add(LP_level_obj12);
                    LevelProperties.level_list.Add(LP_level_obj13);
                    LevelProperties.level_list.Add(LP_level_obj14);
                    LevelProperties.level_list.Add(LP_level_obj15);
                    LevelProperties.level_list.Add(LP_level_obj16);
                    LevelProperties.level_list.Add(LP_level_obj17);
                    LevelProperties.level_list.Add(LP_level_obj18);
                    LevelProperties.level_list.Add(LP_level_obj19);
                    LevelProperties.level_list.Add(LP_level_obj20);
                    LevelProperties.level_list.Add(LP_level_obj21);
                    LevelProperties.level_list.Add(LP_level_obj22);
                    LevelProperties.level_list.Add(LP_level_obj23);
                    LevelProperties.level_list.Add(LP_level_obj24);
                    LevelProperties.level_list.Add(LP_level_obj25);
                    LevelProperties.level_list.Add(LP_level_obj26);
                    LevelProperties.level_list.Add(LP_level_obj27);
                    LevelProperties.level_list.Add(LP_level_obj28);
                    LevelProperties.level_list.Add(LP_level_obj29);
                    LevelProperties.level_list.Add(LP_level_obj30);
                    LevelProperties.level_list.Add(LP_level_obj31);
                    LevelProperties.level_list.Add(LP_level_obj32);
                    LevelProperties.level_list.Add(LP_level_obj33);
                    LevelProperties.level_list.Add(LP_level_obj34);
                    LevelProperties.level_list.Add(LP_level_obj35);
                    LevelProperties.level_list.Add(LP_level_obj36);
                    LevelProperties.level_list.Add(LP_level_obj37);
                    LevelProperties.level_list.Add(LP_level_obj38);
                    LevelProperties.level_list.Add(LP_level_obj39);
                    LevelProperties.level_list.Add(LP_level_obj40);
                    LevelProperties.level_list.Add(LP_level_obj41);
                    LevelProperties.level_list.Add(LP_level_obj42);
                    LevelProperties.level_list.Add(LP_level_obj43);
                    LevelProperties.level_list.Add(LP_level_obj44);
                    LevelProperties.level_list.Add(LP_city_obj1);
                    LevelProperties.level_list.Add(LP_city_obj2);
                    LevelProperties.level_list.Add(LP_city_obj3);
                    LevelProperties.level_list.Add(LP_city_obj4);
                    LevelProperties.level_list.Add(LP_city_obj5);
                    LevelProperties.level_list.Add(LP_city_obj6);
                    LevelProperties.level_list.Add(LP_city_obj7);
                    LevelProperties.level_list.Add(LP_city_obj8);
                    LevelProperties.level_list.Add(LP_city_obj9);
                    LevelProperties.level_list.Add(LP_city_obj10);
                    LevelProperties.level_list.Add(LP_city_obj11);
                    LevelProperties.level_list.Add(LP_city_obj12);
                    LevelProperties.level_list.Add(LP_city_obj13);
                    LevelProperties.level_list.Add(LP_city_obj14);
                    LevelProperties.level_list.Add(LP_city_obj15);
                    LevelProperties.level_list.Add(LP_city_obj16);
                    LevelProperties.level_list.Add(LP_city_obj17);
                    LevelProperties.level_list.Add(LP_obj_obj1);
                    LevelProperties.level_list.Add(LP_obj_obj2);
                    LevelProperties.level_list.Add(LP_obj_obj3);
                    LevelProperties.level_list.Add(LP_obj_obj4);
                    LevelProperties.level_list.Add(LP_obj_obj5);
                    LevelProperties.level_list.Add(LP_obj_obj6);

                    GameGlobalData.game_global_data_creation_count += 1;

                    
                }
               
            }
        }

        private void MM_NG_btn_Click(object sender, EventArgs e)
        {
            Hide();
            NGGlobalDetails NGGlobalDetails_obj = new NGGlobalDetails();
            NGGlobalDetails_obj.Show();
        }
        
        private void MM_LG_btn_Click(object sender, EventArgs e)
        {
            string path = "Название файла, которое пользователь вводит в TB с формы сохранения ИИИИИ .txt";
            string variable_level = null;
            string variable_XP = null;
            string variable_count_of_gold = null;
            string variable_level_strength_bonus = null;
            string variable_level_random_strength_bonus = null;
            string variable_level_defense_bonus = null;
            string variable_level_random_defense_bonus = null;
            string variable_level_health_bonus = null;
            string variable_level_speed_bonus = null;

            int equipped_loot_head_index = 0;
            int equipped_loot_righthand_index = 0;
            int equipped_loot_lefthand_index = 0;
            int equipped_loot_torso_index = 0;
            int equipped_loot_legs_index = 0;
            int start_inventory_index = 0;
            //File f = new File;

            string[] load_hash = new string[110];

            //Сохранение - присвоение
            {
                load_hash[0] = "1";
                load_hash[1] = "2";
                load_hash[2] = "3";
                load_hash[3] = "4";
                load_hash[4] = "1";
                load_hash[5] = "2";
                load_hash[6] = "3";
                load_hash[7] = "4";
                load_hash[8] = "1";
                load_hash[9] = "2";
                load_hash[10] = "3";
                load_hash[11] = "4";
                load_hash[12] = "1";
                load_hash[13] = "2";
                load_hash[14] = "3";
                load_hash[15] = "4";
                load_hash[16] = "1";
                load_hash[17] = "2";
                load_hash[18] = "3";
                load_hash[19] = "4";
                load_hash[20] = "1";
                load_hash[21] = "2";
                load_hash[22] = "3";
                load_hash[23] = "4";
                load_hash[24] = "1";
                load_hash[25] = "2";
                load_hash[26] = "3";
                load_hash[27] = "4";
                load_hash[28] = "1";
                load_hash[29] = "2";
                load_hash[30] = "3";
                load_hash[31] = "4";
                load_hash[32] = "1";
                load_hash[33] = "2";
                load_hash[34] = "3";
                load_hash[35] = "4";
                load_hash[36] = "1";
                load_hash[37] = "2";
                load_hash[38] = "3";
                load_hash[39] = "4";
                load_hash[40] = "1";
                load_hash[41] = "2";
                load_hash[42] = "3";
                load_hash[43] = "4";
                load_hash[44] = "1";
                load_hash[45] = "2";
                load_hash[46] = "3";
                load_hash[47] = "4";
                load_hash[48] = "1";
                load_hash[49] = "2";
                load_hash[50] = "3";
                load_hash[51] = "4";
                load_hash[52] = "1";
                load_hash[53] = "2";
                load_hash[54] = "3";
                load_hash[55] = "4";
                load_hash[56] = "1";
                load_hash[57] = "2";
                load_hash[58] = "3";
                load_hash[59] = "4";
                load_hash[60] = "1";
                load_hash[61] = "2";
                load_hash[62] = "3";
                load_hash[63] = "4";
                load_hash[64] = "1";
                load_hash[65] = "2";
                load_hash[66] = "3";
                load_hash[67] = "4";
                load_hash[68] = "1";
                load_hash[69] = "2";
                load_hash[70] = "3";
                load_hash[71] = "4";
                load_hash[72] = "1";
                load_hash[73] = "2";
                load_hash[74] = "3";
                load_hash[75] = "4";
                load_hash[76] = "1";
                load_hash[77] = "2";
                load_hash[78] = "3";
                load_hash[79] = "4";
                load_hash[80] = "1";
                load_hash[81] = "2";
                load_hash[82] = "3";
                load_hash[83] = "4";
                load_hash[84] = "1";
                load_hash[85] = "2";
                load_hash[86] = "3";
                load_hash[87] = "4";
                load_hash[88] = "1";
                load_hash[89] = "2";
                load_hash[90] = "3";
                load_hash[91] = "4";
                load_hash[92] = "1";
                load_hash[93] = "2";
                load_hash[94] = "3";
                load_hash[95] = "4";
                load_hash[96] = "1";
                load_hash[97] = "2";
                load_hash[97] = "3";
                load_hash[98] = "4";
                load_hash[99] = "1";
                load_hash[100] = "2";
                load_hash[101] = "3";
                load_hash[102] = "4";
                load_hash[103] = "1";
                load_hash[104] = "2";
                load_hash[105] = "3";
                load_hash[106] = "4";
                load_hash[107] = "1";
                load_hash[108] = "2";
                load_hash[109] = "3";
                load_hash[110] = "4";
            }
            
            List<Loot> some_inventory = new List<Loot>() { };
            List<Loot> some_equipped = new List<Loot>() { };


            for (int i = 0; i < load_hash.Length; i++)
            {
                if (load_hash[18] == "0" && load_hash[36] == "0" && load_hash[54] == "0")
                {
                    GameGlobalData.count_of_players = 1;
                }
                else if (load_hash[36] == "0" && load_hash[54] == "0")
                {
                    GameGlobalData.count_of_players = 2;
                }
                else if (load_hash[54] == "0")
                {
                    GameGlobalData.count_of_players = 3;
                }
                else
                {
                    GameGlobalData.count_of_players = 4;
                }
            }               
            for (int i = 1; i < GameGlobalData.count_of_players + 1; i++)
            {
                switch (i)
                {                    
                    case 1:
                        variable_level = load_hash[2];
                        variable_XP = load_hash[3];
                        variable_count_of_gold = load_hash[4];
                        variable_level_strength_bonus = load_hash[12];
                        variable_level_random_strength_bonus = load_hash[13];
                        variable_level_defense_bonus = load_hash[14];
                        variable_level_random_defense_bonus = load_hash[15];
                        variable_level_health_bonus = load_hash[16];
                        variable_level_speed_bonus = load_hash[17];
                        equipped_loot_head_index = 5;
                        equipped_loot_torso_index = 6;
                        equipped_loot_righthand_index = 7;
                        equipped_loot_lefthand_index = 8;                      
                        equipped_loot_legs_index = 9;
                        start_inventory_index = 10;                       
                        break;
                    case 2:
                        variable_level = load_hash[20];
                        variable_XP = load_hash[21];
                        variable_count_of_gold = load_hash[22];
                        variable_level_strength_bonus = load_hash[30];
                        variable_level_random_strength_bonus = load_hash[31];
                        variable_level_defense_bonus = load_hash[32];
                        variable_level_random_defense_bonus = load_hash[33];
                        variable_level_health_bonus = load_hash[34];
                        variable_level_speed_bonus = load_hash[35];                       
                        equipped_loot_head_index = 23;
                        equipped_loot_torso_index = 24;
                        equipped_loot_righthand_index = 25;
                        equipped_loot_lefthand_index = 26;                        
                        equipped_loot_legs_index = 27;
                        start_inventory_index = 28;
                        break;
                    case 3:
                        variable_level = load_hash[38];
                        variable_XP = load_hash[39];
                        variable_count_of_gold = load_hash[40];
                        variable_level_strength_bonus = load_hash[48];
                        variable_level_random_strength_bonus = load_hash[49];
                        variable_level_defense_bonus = load_hash[50];
                        variable_level_random_defense_bonus = load_hash[51];
                        variable_level_health_bonus = load_hash[52];
                        variable_level_speed_bonus = load_hash[53];
                        equipped_loot_head_index = 41;
                        equipped_loot_torso_index = 42;
                        equipped_loot_righthand_index = 43;
                        equipped_loot_lefthand_index = 44;                        
                        equipped_loot_legs_index = 45;
                        start_inventory_index = 46;
                        break;
                    case 4:
                        variable_level = load_hash[56];
                        variable_XP = load_hash[57];
                        variable_count_of_gold = load_hash[58];
                        variable_level_strength_bonus = load_hash[66];
                        variable_level_random_strength_bonus = load_hash[67];
                        variable_level_defense_bonus = load_hash[68];
                        variable_level_random_defense_bonus = load_hash[69];
                        variable_level_health_bonus = load_hash[70];
                        variable_level_speed_bonus = load_hash[71];                                              
                        equipped_loot_head_index = 59;
                        equipped_loot_torso_index = 60;
                        equipped_loot_righthand_index = 61;
                        equipped_loot_lefthand_index = 62;                       
                        equipped_loot_legs_index = 63;
                        start_inventory_index = 64;
                        break;
                }
                for (int j = 0; j < Loot.LootList.Count; j++)
                {
                    if (load_hash[start_inventory_index] == Loot.LootList[j].loot_index)
                    {
                        some_inventory.Add(Loot.LootList[j]);
                        start_inventory_index++;
                    }                   
                    if (load_hash[equipped_loot_head_index] == Loot.LootList[j].loot_index)
                    {
                        some_equipped.Add(Loot.LootList[j]);
                    }
                    if (load_hash[equipped_loot_torso_index] == Loot.LootList[j].loot_index)
                    {
                        some_equipped.Add(Loot.LootList[j]);
                    }
                    if (load_hash[equipped_loot_righthand_index] == Loot.LootList[j].loot_index)
                    {
                        some_equipped.Add(Loot.LootList[j]);
                    }
                    if (load_hash[equipped_loot_lefthand_index] == Loot.LootList[j].loot_index)
                    {
                        some_equipped.Add(Loot.LootList[j]);
                    }                   
                    if (load_hash[equipped_loot_legs_index] == Loot.LootList[j].loot_index)
                    {
                        some_equipped.Add(Loot.LootList[j]);
                    }
                }
                Hero.generate_players(i, load_hash[0], load_hash[1], load_hash[18], load_hash[19], load_hash[36], load_hash[37], load_hash[54], load_hash[55], int.Parse(variable_level), int.Parse(variable_XP), int.Parse(variable_count_of_gold), int.Parse(variable_level_strength_bonus), int.Parse(variable_level_random_strength_bonus), int.Parse(variable_level_defense_bonus), int.Parse(variable_level_random_defense_bonus), int.Parse(variable_level_health_bonus), int.Parse(variable_level_speed_bonus), some_inventory, some_equipped);                
            }
            LevelProperties.journey_map_current_level_position = LevelProperties.level_list[int.Parse(load_hash[72])-1];
            //text[ 0] = ;

            Console.WriteLine(load_hash);
            // полная перезапись файла 
            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    await writer.WriteLineAsync(text);
            //}

            //  ОБИРАЄМО ФАЙЛ ЗАВАНТАЖЕННЯ
            //string text = "";
            //text = Console.ReadLine();
            //File.AppendAllText("D:\\new_file.txt", text);
            //FileStream file = new FileStream("D:\\new_file.txt", FileMode.Open);
            //StreamWriter writer = new StreamWriter(file);
            //StreamReader reader = new StreamReader(file);

            ////writer.Write(text);

            //Console.WriteLine(reader.ReadToEnd());
            //string stroka = ////////////////////////////////////////////////сюда
            //writer.Close();
            //reader.Close();
            
            //LevelProperties.level_list[0].is_passed = 
            //return null;
        }

        private void MM_EG_btn_Click(object sender, EventArgs e)
        {
            ShowMessage_ChooseFrom2 sw_msgF2_obj = new ShowMessage_ChooseFrom2(this);
            sw_msgF2_obj.ShowDialog();
            //    ;            ExitSure exitsure_obj = new ExitSure();
            //exitsure_obj.ShowDialog();
        }

        private void MM_main_lbl_Click(object sender, EventArgs e)
        {

        }

        private void MM_main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
