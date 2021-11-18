/*
 * Register.cs
 * Modified by: Adam Duvendack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Drinks;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;

/// <summary>
/// Namespace for IMenuItem, Order, Entrees, Drinks, Sides, etc.
/// </summary>
namespace GyroScope.Data
{
    /// <summary>
    /// Class for a static Menu object
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Static property that gets a list of all entrees
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();
                LeoLambGyro leoLamb = new LeoLambGyro();
                ScorpioSpicyGyro scorpioSpicy = new ScorpioSpicyGyro();
                VirgoClassicGyro virgoClassic = new VirgoClassicGyro();
                PiscesFishDish piscesFish = new PiscesFishDish();
                list.Add(leoLamb);
                list.Add(scorpioSpicy);
                list.Add(virgoClassic);
                list.Add(piscesFish);
                return list;
            }
        }

        /// <summary>
        /// Static property that gets a list of all sides in all sizes
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();
                AriesFries smallFries = new AriesFries();
                AriesFries mediumFries = new AriesFries();
                AriesFries largeFries = new AriesFries();
                smallFries.Size = Enums.Size.Small;
                mediumFries.Size = Enums.Size.Medium;
                largeFries.Size = Enums.Size.Large;

                GeminiStuffedGrapeLeaves leavesSmall = new GeminiStuffedGrapeLeaves();
                GeminiStuffedGrapeLeaves leavesMedium = new GeminiStuffedGrapeLeaves();
                GeminiStuffedGrapeLeaves leavesLarge = new GeminiStuffedGrapeLeaves();
                leavesSmall.Size = Enums.Size.Small;
                leavesMedium.Size = Enums.Size.Medium;
                leavesLarge.Size = Enums.Size.Large;

                SagittariusGreekSalad saladSmall = new SagittariusGreekSalad();
                SagittariusGreekSalad saladMedium = new SagittariusGreekSalad();
                SagittariusGreekSalad saladLarge = new SagittariusGreekSalad();
                saladSmall.Size = Enums.Size.Small;
                saladMedium.Size = Enums.Size.Medium;
                saladLarge.Size = Enums.Size.Large;

                TaurusTabuleh tabulehSmall = new TaurusTabuleh();
                TaurusTabuleh tabulehMedium = new TaurusTabuleh();
                TaurusTabuleh tabulehLarge = new TaurusTabuleh();
                tabulehSmall.Size = Enums.Size.Small;
                tabulehMedium.Size = Enums.Size.Medium;
                tabulehLarge.Size = Enums.Size.Large;

                list.Add(smallFries);
                list.Add(mediumFries);
                list.Add(largeFries);

                list.Add(leavesSmall);
                list.Add(leavesMedium);
                list.Add(leavesLarge);

                list.Add(saladSmall);
                list.Add(saladMedium);
                list.Add(saladLarge);

                list.Add(tabulehSmall);
                list.Add(tabulehMedium);
                list.Add(tabulehLarge);

                return list;
            }
        }

        /// <summary>
        /// Static property that gets a list of all flavors of all drinks
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();
                CapricornMountainTea tea = new CapricornMountainTea();
                LibraLibation orangeade = new LibraLibation();
                LibraLibation sourCherry = new LibraLibation();
                LibraLibation biral = new LibraLibation();
                LibraLibation pinkLemonada = new LibraLibation();
                orangeade.Flavor = Enums.LibraLibationFlavor.Orangeade;
                sourCherry.Flavor = Enums.LibraLibationFlavor.SourCherry;
                biral.Flavor = Enums.LibraLibationFlavor.Biral;
                pinkLemonada.Flavor = Enums.LibraLibationFlavor.PinkLemonada;

                list.Add(tea);
                list.Add(orangeade);
                list.Add(sourCherry);
                list.Add(biral);
                list.Add(pinkLemonada);
                return list;
            }
        }

        /// <summary>
        /// Static property that gets a list of all sizes and flavors of all treats
        /// </summary>
        public static IEnumerable<IMenuItem> Treats
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();

                AquariusIce smallLemon = new AquariusIce();
                AquariusIce mediumLemon = new AquariusIce();
                AquariusIce largeLemon = new AquariusIce();

                AquariusIce smallOrange = new AquariusIce();
                AquariusIce mediumOrange = new AquariusIce();
                AquariusIce largeOrange = new AquariusIce();

                AquariusIce smallMango = new AquariusIce();
                AquariusIce mediumMango = new AquariusIce();
                AquariusIce largeMango = new AquariusIce();

                AquariusIce smallWatermellon = new AquariusIce();
                AquariusIce mediumWatermellon = new AquariusIce();
                AquariusIce largeWatermellon = new AquariusIce();

                AquariusIce smallBlueRazz = new AquariusIce();
                AquariusIce mediumBlueRazz = new AquariusIce();
                AquariusIce largeBlueRazz = new AquariusIce();

                AquariusIce smallStrawberry = new AquariusIce();
                AquariusIce mediumStrawberry = new AquariusIce();
                AquariusIce largeStrawberry = new AquariusIce();

                smallLemon.Size = Enums.Size.Small;
                smallLemon.Flavor = Enums.AquariusIceFlavor.Lemon;
                mediumLemon.Size = Enums.Size.Medium;
                mediumLemon.Flavor = Enums.AquariusIceFlavor.Lemon;
                largeLemon.Size = Enums.Size.Large;
                largeLemon.Flavor = Enums.AquariusIceFlavor.Lemon;

                smallOrange.Size = Enums.Size.Small;
                smallOrange.Flavor = Enums.AquariusIceFlavor.Orange;
                mediumOrange.Size = Enums.Size.Medium;
                mediumOrange.Flavor = Enums.AquariusIceFlavor.Orange;
                largeOrange.Size = Enums.Size.Large;
                largeOrange.Flavor = Enums.AquariusIceFlavor.Orange;

                smallMango.Size = Enums.Size.Small;
                smallMango.Flavor = Enums.AquariusIceFlavor.Mango;
                mediumMango.Size = Enums.Size.Medium;
                mediumMango.Flavor = Enums.AquariusIceFlavor.Mango;
                largeMango.Size = Enums.Size.Large;
                largeMango.Flavor = Enums.AquariusIceFlavor.Mango;

                smallWatermellon.Size = Enums.Size.Small;
                smallWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;
                mediumWatermellon.Size = Enums.Size.Medium;
                mediumWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;
                largeWatermellon.Size = Enums.Size.Large;
                largeWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;

                smallBlueRazz.Size = Enums.Size.Small;
                smallBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;
                mediumBlueRazz.Size = Enums.Size.Medium;
                mediumBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;
                largeBlueRazz.Size = Enums.Size.Large;
                largeBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;

                smallStrawberry.Size = Enums.Size.Small;
                smallStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;
                mediumStrawberry.Size = Enums.Size.Medium;
                mediumStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;
                largeStrawberry.Size = Enums.Size.Large;
                largeStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;

                CancerHalvaCake cancerCake = new CancerHalvaCake();

                list.Add(smallLemon);
                list.Add(mediumLemon);
                list.Add(largeLemon);

                list.Add(smallOrange);
                list.Add(mediumOrange);
                list.Add(largeOrange);

                list.Add(smallMango);
                list.Add(mediumMango);
                list.Add(largeMango);

                list.Add(smallWatermellon);
                list.Add(mediumWatermellon);
                list.Add(largeWatermellon);

                list.Add(smallBlueRazz);
                list.Add(mediumBlueRazz);
                list.Add(largeBlueRazz);

                list.Add(smallStrawberry);
                list.Add(mediumStrawberry);
                list.Add(largeStrawberry);

                list.Add(cancerCake);

                return list;
            }
        }

        /// <summary>
        /// Static property that gets a list of all flavors and sizes of all food and drinks
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();

                LeoLambGyro leoLamb = new LeoLambGyro();
                ScorpioSpicyGyro scorpioSpicy = new ScorpioSpicyGyro();
                VirgoClassicGyro virgoClassic = new VirgoClassicGyro();
                PiscesFishDish piscesFish = new PiscesFishDish();
                list.Add(leoLamb);
                list.Add(scorpioSpicy);
                list.Add(virgoClassic);
                list.Add(piscesFish);

                AriesFries smallFries = new AriesFries();
                AriesFries mediumFries = new AriesFries();
                AriesFries largeFries = new AriesFries();
                smallFries.Size = Enums.Size.Small;
                mediumFries.Size = Enums.Size.Medium;
                largeFries.Size = Enums.Size.Large;

                GeminiStuffedGrapeLeaves leavesSmall = new GeminiStuffedGrapeLeaves();
                GeminiStuffedGrapeLeaves leavesMedium = new GeminiStuffedGrapeLeaves();
                GeminiStuffedGrapeLeaves leavesLarge = new GeminiStuffedGrapeLeaves();
                leavesSmall.Size = Enums.Size.Small;
                leavesMedium.Size = Enums.Size.Medium;
                leavesLarge.Size = Enums.Size.Large;

                SagittariusGreekSalad saladSmall = new SagittariusGreekSalad();
                SagittariusGreekSalad saladMedium = new SagittariusGreekSalad();
                SagittariusGreekSalad saladLarge = new SagittariusGreekSalad();
                saladSmall.Size = Enums.Size.Small;
                saladMedium.Size = Enums.Size.Medium;
                saladLarge.Size = Enums.Size.Large;

                TaurusTabuleh tabulehSmall = new TaurusTabuleh();
                TaurusTabuleh tabulehMedium = new TaurusTabuleh();
                TaurusTabuleh tabulehLarge = new TaurusTabuleh();
                tabulehSmall.Size = Enums.Size.Small;
                tabulehMedium.Size = Enums.Size.Medium;
                tabulehLarge.Size = Enums.Size.Large;

                list.Add(smallFries);
                list.Add(mediumFries);
                list.Add(largeFries);

                list.Add(leavesSmall);
                list.Add(leavesMedium);
                list.Add(leavesLarge);

                list.Add(saladSmall);
                list.Add(saladMedium);
                list.Add(saladLarge);

                list.Add(tabulehSmall);
                list.Add(tabulehMedium);
                list.Add(tabulehLarge);

                CapricornMountainTea tea = new CapricornMountainTea();
                LibraLibation orangeade = new LibraLibation();
                LibraLibation sourCherry = new LibraLibation();
                LibraLibation biral = new LibraLibation();
                LibraLibation pinkLemonada = new LibraLibation();
                orangeade.Flavor = Enums.LibraLibationFlavor.Orangeade;
                sourCherry.Flavor = Enums.LibraLibationFlavor.SourCherry;
                biral.Flavor = Enums.LibraLibationFlavor.Biral;
                pinkLemonada.Flavor = Enums.LibraLibationFlavor.PinkLemonada;

                list.Add(tea);
                list.Add(orangeade);
                list.Add(sourCherry);
                list.Add(biral);
                list.Add(pinkLemonada);

                AquariusIce smallLemon = new AquariusIce();
                AquariusIce mediumLemon = new AquariusIce();
                AquariusIce largeLemon = new AquariusIce();

                AquariusIce smallOrange = new AquariusIce();
                AquariusIce mediumOrange = new AquariusIce();
                AquariusIce largeOrange = new AquariusIce();

                AquariusIce smallMango = new AquariusIce();
                AquariusIce mediumMango = new AquariusIce();
                AquariusIce largeMango = new AquariusIce();

                AquariusIce smallWatermellon = new AquariusIce();
                AquariusIce mediumWatermellon = new AquariusIce();
                AquariusIce largeWatermellon = new AquariusIce();

                AquariusIce smallBlueRazz = new AquariusIce();
                AquariusIce mediumBlueRazz = new AquariusIce();
                AquariusIce largeBlueRazz = new AquariusIce();

                AquariusIce smallStrawberry = new AquariusIce();
                AquariusIce mediumStrawberry = new AquariusIce();
                AquariusIce largeStrawberry = new AquariusIce();

                smallLemon.Size = Enums.Size.Small;
                smallLemon.Flavor = Enums.AquariusIceFlavor.Lemon;
                mediumLemon.Size = Enums.Size.Medium;
                mediumLemon.Flavor = Enums.AquariusIceFlavor.Lemon;
                largeLemon.Size = Enums.Size.Large;
                largeLemon.Flavor = Enums.AquariusIceFlavor.Lemon;

                smallOrange.Size = Enums.Size.Small;
                smallOrange.Flavor = Enums.AquariusIceFlavor.Orange;
                mediumOrange.Size = Enums.Size.Medium;
                mediumOrange.Flavor = Enums.AquariusIceFlavor.Orange;
                largeOrange.Size = Enums.Size.Large;
                largeOrange.Flavor = Enums.AquariusIceFlavor.Orange;

                smallMango.Size = Enums.Size.Small;
                smallMango.Flavor = Enums.AquariusIceFlavor.Mango;
                mediumMango.Size = Enums.Size.Medium;
                mediumMango.Flavor = Enums.AquariusIceFlavor.Mango;
                largeMango.Size = Enums.Size.Large;
                largeMango.Flavor = Enums.AquariusIceFlavor.Mango;

                smallWatermellon.Size = Enums.Size.Small;
                smallWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;
                mediumWatermellon.Size = Enums.Size.Medium;
                mediumWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;
                largeWatermellon.Size = Enums.Size.Large;
                largeWatermellon.Flavor = Enums.AquariusIceFlavor.Watermellon;

                smallBlueRazz.Size = Enums.Size.Small;
                smallBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;
                mediumBlueRazz.Size = Enums.Size.Medium;
                mediumBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;
                largeBlueRazz.Size = Enums.Size.Large;
                largeBlueRazz.Flavor = Enums.AquariusIceFlavor.BlueRaspberry;

                smallStrawberry.Size = Enums.Size.Small;
                smallStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;
                mediumStrawberry.Size = Enums.Size.Medium;
                mediumStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;
                largeStrawberry.Size = Enums.Size.Large;
                largeStrawberry.Flavor = Enums.AquariusIceFlavor.Strawberry;

                CancerHalvaCake cancerCake = new CancerHalvaCake();

                list.Add(smallLemon);
                list.Add(mediumLemon);
                list.Add(largeLemon);

                list.Add(smallOrange);
                list.Add(mediumOrange);
                list.Add(largeOrange);

                list.Add(smallMango);
                list.Add(mediumMango);
                list.Add(largeMango);

                list.Add(smallWatermellon);
                list.Add(mediumWatermellon);
                list.Add(largeWatermellon);

                list.Add(smallBlueRazz);
                list.Add(mediumBlueRazz);
                list.Add(largeBlueRazz);

                list.Add(smallStrawberry);
                list.Add(mediumStrawberry);
                list.Add(largeStrawberry);

                list.Add(cancerCake);

                return list;
            }
        }
    }
}
