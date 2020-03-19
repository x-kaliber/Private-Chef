using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector
{
    [Header("Assets")]
    public int Gcoins;      // Our total Gold coins
    public int Ccoins;      // Our total Copper Coins
    public int xpAvaliable; // Our total XP

    [Header("Warehouse")]
    public int[] InventoryList; // An Array of Id where our obtained Food items will be displayed
    public int[] EquipmentList; // An Array of Id where our Equipment Will be dispayed

    [Header("Recipe")]
    public int[] RecipeId; 
    public string[] RecipeParchmentId; // An Array for all the Recipe Parchment id. Including the ones for the Events

    [Header("Assistants")]
    public int[] AdvertiserId;           // An Array of random created Permanent Advertisers
    public int ActiveAdvertiserId;       // The Id of your one Active Advertiser. (in order to run Checks of who is your active Advertiser) 
    public int[] ChefId;                 // An Array of all our chef Id , names , cost and duration
    public int[] NumberOfAvailableChefs; // An Array of all The Available to hire Chefs
    public int[] NumberOfActiveChefs;    // An Array of all of our Active Chefs
    public int[] NumberOfInactiveChefs;  // An Array of all the hired but not active Chefs

    [Header("Premium")]
    public int[] PremiumItemId;    // Here we will store wich Premium Item you have Purchased and the amount of the said Item you have in your account. (When an item is used it will be passed in another Array)
    public int[] UsedPremiumItem;  // Here we have a list of the Premium Items you Used. In order to help us create better offers.
    public int[] PremiumGcoinsId;  // Here we a list with the Gcoin Bundles you have purchased. (It will help us identify the Best Bundle for Coins. Also it will help to create future events in order to give rewards to players)

    [Header("TempBonuses")]
    public int[] LocationId;          // An array where we will store the Locations Where you will be able to buy/rent bussinesses 
    public int[] BussinessTypeId;     // An Array with the avaliable bussiness types in said location
    public int[] BussinessList;       // An Array with the bussiness Names and types you own in said location
    public int[] BussinessActiveList; // An Array of your active bussinesses.(this array will be used to calculate the total bonus you will get every hour from your Bussinesses)
    public int BussinessTotalBonus;   // Here  will be stored the total amount of bonusses you own(so that it will be easier to use  in other parts of the code if it's needed)

    [Header("Character Sheet")]
    public string Name;        // This is the Selected Name of your Character
    public float Strength;     // This  float will describe how strong your character is. Allowing him to use havier food items/quantities and his stamina(affect the speed bonus).
    public float Dexterity;    // This float will describe  how dexterous is your character when is handling food (afffects the speed bonus). Allows you to learn more advanced recipes.
    public float Speed;        // This float number will describe how fast your character opperates in a kitchen.()
    public float Inteligence;  // This float number will describe how intelligently your character operates in a kitchen (affects Speed and Wisdom bonus). allows you to unlock more advanced recipes.
    public float Wisdom;       // This float number will describe the Wisdom your Character has in a Kitchen . Allows you to earn more often parchments.
    public int[] KnowledgeId;  // An array of ID's that will allow us to connect into notes regarding food health and safety(regulations) and notes regarding notes for Specific food items. 
    public int[] CuisineId;    // An array of Cuisines you have unlocked in your recipes(Actual recipes).
    public int[] RecipeLevel;  /* An array of the level you have reached each recipe. It gets affected by (Dexterity,Speed, Inteligence, Wisdom) 
                                  (Example: You get +1% from Dexterity and Speed. When you play the HotDog Stand you will earn +1% more experience in your selected recipe level that is 
                                  associeted with the HotDog Stand.  When you reach the level of Master it will allow you to learn an associeted non owned recipe)
                                  Levels 1) House Cook, 2) Amateur, 3) Intermediate, 4)Proffesional, 5) Experienced, 6) Expert, 7) Master */
    public int[] CuisineLevel; /* This array will display the Cuisines your character has recipes for and his total level. 
                                  (Example : Your Character has recipes for Indian, Greek and Jamaican cuisine. but in the game we have 100 recipes for each cuisine and your character has 5 ,50 and 60 recipes.
                                  His Recipe Levels are Master in all the  Indian recipes amateur in all the Greek Recipes  and professional in 40 of the Jamaican Recipes. 
                                  This character he can be a Masdter when has an Indian Food Stand , a professional in a Food cart, and an amateur in a fine dining.
                                  These titles will Provide Various Bonus and opportunities to unlock new recipes for your character and obtain (Actual)Recipes for you. */
    public int CharLevel;      /* A numeric representetion of the total Level your character has Reached. In order to increase your Level you have to Spend your XP either to evolve your Character Stats,
                                  Run bussinesses or by exchanging XP to buy actuall Recipes. */

    [Header("Character Values")]
    public int SexId;            // The sex you want your Character to have
    public int HairStyleId;      // The Id that correspond to your chosen Chibi Hairstyle
    public string HairColor;     // The ID that correspond to your chosen Hair color
    public int FaceId;           // The Id that correspond to your chosen Chibi Face  (!!!Does not Change!!!)
    public int BodyStyleId;      // The Id that Correspond to your chosen Chibi Body  (!!!Does not Change!!!)
    public string BodyColor;     // The body color affects the color of both the body and the face (!!!Does not Change!!!)
    public int UniformId;        // The Id that corrispond in your active Uniform (Possible to add and access multiple uniforms in the future. The Uniforms have 4 components)
    public string UniforColorA;  // Main color of your character uniform
    public string UniforColorB;  // Secondary color of your character uniform
    public string[] UniformList; // An Array of all your Uniforms with their assosiated colours
    public int[] AccessoriesId;  // An Array of 4 Id that correspond to 4 possible accessories your Character might have.(Rosette Star , Michelline Star, Kitchen Items, Pen or Spoon)

}