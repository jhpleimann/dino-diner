using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This represents the menu class and all of the contents in it.
    /// </summary>
    public class Menu
    {

        /// <summary>
        /// This is a list of all the ingredients
        /// that are available in the menu
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                JurrasicJava java = new JurrasicJava();
                List<IMenuItem> ingredients = new List<IMenuItem>() { java };
                Sodasaurus soda = new Sodasaurus();
                ingredients.Add(soda);
                Tyrannotea tea = new Tyrannotea();
                ingredients.Add(tea);
                Water water = new Water();
                ingredients.Add(water);
                Brontowurst bron = new Brontowurst();
                ingredients.Add(bron);
                DinoNuggets nug = new DinoNuggets();
                ingredients.Add(nug);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                ingredients.Add(pbj);
                PterodactylWings pWings = new PterodactylWings();
                ingredients.Add(pWings);
                SteakosaurusBurger sBurger = new SteakosaurusBurger();
                ingredients.Add(sBurger);
                TRexKingBurger tBurger = new TRexKingBurger();
                ingredients.Add(tBurger);
                VelociWrap wrap = new VelociWrap();
                ingredients.Add(wrap);
                Fryceritops fry = new Fryceritops();
                ingredients.Add(fry);
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                ingredients.Add(mac);
                MezzorellaSticks mezSticks = new MezzorellaSticks();
                ingredients.Add(mezSticks);
                Triceritots tots = new Triceritots();
                ingredients.Add(tots);
                return ingredients;
            }
        }

        /// <summary>
        /// This is a list of all the options
        /// that are available in the entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                Brontowurst bron = new Brontowurst();
                List<IMenuItem> ingredients = new List<IMenuItem>() { bron };
                DinoNuggets nug = new DinoNuggets();
                ingredients.Add(nug);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                ingredients.Add(pbj);
                PterodactylWings pWings = new PterodactylWings();
                ingredients.Add(pWings);
                SteakosaurusBurger sBurger = new SteakosaurusBurger();
                ingredients.Add(sBurger);
                TRexKingBurger tBurger = new TRexKingBurger();
                ingredients.Add(tBurger);
                VelociWrap wrap = new VelociWrap();
                ingredients.Add(wrap);
                return ingredients;
            }
        }

        /// <summary>
        /// This is a list of all the options
        /// that are available in the sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                Fryceritops fry = new Fryceritops();
                List<IMenuItem> ingredients = new List<IMenuItem>() { fry };
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                ingredients.Add(mac);
                MezzorellaSticks mezSticks = new MezzorellaSticks();
                ingredients.Add(mezSticks);
                Triceritots tots = new Triceritots();
                ingredients.Add(tots);
                return ingredients;
            }
        }

        /// <summary>
        /// This is a list of all the options
        /// that are available in the drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                JurrasicJava java = new JurrasicJava();
                List<IMenuItem> ingredients = new List<IMenuItem>() { java };
                Sodasaurus soda = new Sodasaurus();
                ingredients.Add(soda);
                Tyrannotea tea = new Tyrannotea();
                ingredients.Add(tea);
                Water water = new Water();
                ingredients.Add(water);
                return ingredients;
            }
        }

        /// <summary>
        /// This is a list of all the options
        /// that are available in the combos menu
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                Brontowurst bron = new Brontowurst();
                CretaceousCombo comboBron = new CretaceousCombo(bron);
                List<IMenuItem> ingredients = new List<IMenuItem>() { comboBron };
                DinoNuggets nug = new DinoNuggets();
                CretaceousCombo comboNug = new CretaceousCombo(nug);
                ingredients.Add(comboNug);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                CretaceousCombo comboPbj = new CretaceousCombo(pbj);
                ingredients.Add(comboPbj);
                PterodactylWings pWings = new PterodactylWings();
                CretaceousCombo comboPWings = new CretaceousCombo(pWings);
                ingredients.Add(comboPWings);
                SteakosaurusBurger sBurger = new SteakosaurusBurger();
                CretaceousCombo comboSBurger = new CretaceousCombo(sBurger);
                ingredients.Add(comboSBurger);
                TRexKingBurger tBurger = new TRexKingBurger();
                CretaceousCombo comboTBurger = new CretaceousCombo(tBurger);
                ingredients.Add(comboTBurger);
                VelociWrap wrap = new VelociWrap();
                CretaceousCombo comboWrap = new CretaceousCombo(wrap);
                ingredients.Add(comboWrap);
                return ingredients;
            }
        }

        /// <summary>
        /// Returns the contents of the menu
        /// </summary>
        /// <returns>The menu</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(List<IMenuItem> l in AvailableMenuItems)
            {
                bool inEntree = false;
                foreach (List<IMenuItem> opt in AvailableEntrees)
                {
                    if(l == opt)
                    {
                        inEntree = true;
                    }
                }
                if (inEntree)
                {
                    sb.Append(l.ToString() + "\n");
                }
                else
                {
                    sb.Append(l.ToString().Substring(6) + "\n");
                }
            }
            return  sb.ToString();
        }
    }
}
