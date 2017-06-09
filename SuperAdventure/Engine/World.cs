using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_RUSTY_KEY = 11;
        public const int ITEM_ID_SMALL_KEY = 12;
        public const int ITEM_ID_POISON = 13;
        public const int ITEM_ID_FLOWER = 14;
        public const int ITEM_ID_DAGGER = 15;
        public const int ITEM_ID_MAP = 16;
        public const int ITEM_ID_SWORD = 17;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_SMALL_SPIDER = 4;
        public const int MONSTER_ID_RAVEN = 5;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_DARKNESS = 1;
        public const int LOCATION_ID_BEFORE_TREE = 2;
        public const int LOCATION_ID_FOREST = 3;
        public const int LOCATION_ID_FOREST_TREE_STUMP = 4;
        public const int LOCATION_ID_FOREST_PATH = 5;
        public const int LOCATION_ID_PATH = 6;
        public const int LOCATION_ID_VILLAGE_ENTRY = 7;
        public const int LOCATION_ID_VILLAGE_SQUARE = 8;
        public const int LOCATION_ID_FARM = 9;
        public const int LOCATION_ID_SMITHY = 10;
        public const int LOCATION_ID_BRIDGE = 11;
        public const int LOCATION_ID_MILL = 12;
        public const int LOCATION_ID_MARKET = 13;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(new Item(ITEM_ID_RUSTY_KEY, "A small rusty key", "Rusty keys"));
            Items.Add(new Item(ITEM_ID_SMALL_KEY, "A small key", "Small keys"));
            Items.Add(new Item(ITEM_ID_POISON, "Poison", "Poisons"));
            Items.Add(new Item(ITEM_ID_FLOWER, "Flower", "Flowers"));
            Items.Add(new Item(ITEM_ID_DAGGER, "Dagger", "Daggers"));
            Items.Add(new Item(ITEM_ID_MAP, "Map", "Mapss"));
            Items.Add(new Item(ITEM_ID_SWORD, "Sowrd", "Swords"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location start = new Location(LOCATION_ID_DARKNESS, "Darkness", 
                "Slowly you wake up, blinking there is only darkness around you. Your hands touch cool earth and bark around you. As you orientate yourself you see a small point of light ahead.");

            Location beforeTree = new Location(LOCATION_ID_BEFORE_TREE, "Before the Tree", 
                "You crawled out of a hole beneath a massive, giant tree's roots. Above you the leaves whisper of age and time, while you realise that you have nothing on you besides a shirt and trousers. Worse, you can't remember who you are and why you are here... and where here is. Around you are only trees and the song of birds.");

            Location forest = new Location(LOCATION_ID_FOREST, "Forest", 
                "You walked into the forest, strange noises are all around you. After a while you come to a glade, with soft green grass below you. You here a hiss - duck!");
            forest.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location stump = new Location(LOCATION_ID_FOREST_TREE_STUMP, "Forest tree stump",
                "A massive tree stump lies in front of you, having fallen in a recent storm. It's thicker than you are high. You hear a shuffling and a giant spider races towards you across the stump.");
            stump.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location forestPath = new Location(LOCATION_ID_FOREST_PATH, "Forest path",
                "You stumple out of the forest onto a small path, leading to somewhere.");

            Location path = new Location(LOCATION_ID_PATH, "Path",
                "You are following the path outside the forest. There are small fields around you and a blue sky above you. Climbing a small hill, you see a village.");

            Location villageEntrance = new Location(LOCATION_ID_VILLAGE_ENTRY, "Village entrance",
                "You reached the village, it seems quite peaceful with several buildings, a small stream and a mill far off.");

            Location village = new Location(LOCATION_ID_VILLAGE_SQUARE, "Village square",
                "You have entered the village and see a lively market ahead. On the right you see a smithy, on the left a farm. There is a fountain in front of you, and a woman laboring to get some water out.");


            // Link the locations together
            start.LocationToNorth = beforeTree;
            beforeTree.LocationToNorth = forest;
            forest.LocationToEast = forestPath;
            forest.LocationToWest = stump;
            forestPath.LocationToNorth = path;
            path.LocationToNorth = villageEntrance;
            villageEntrance.LocationToNorth = village;

            // Add the locations to the static list
            Locations.Add(start);
            Locations.Add(beforeTree);
            Locations.Add(forest);
            Locations.Add(forestPath);
            Locations.Add(path);
            Locations.Add(villageEntrance);
            Locations.Add(village);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
