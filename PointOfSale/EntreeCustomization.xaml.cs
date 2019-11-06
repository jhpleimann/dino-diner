/*  EntreeCustomization
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using System.ComponentModel;
using System.Collections.Specialized;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeCustomization.xaml
    /// </summary>
    public partial class EntreeCustomization : Page
    {
        private CretaceousCombo combo;
        /// <summary>
        /// The entree object
        /// </summary>
        private Entree entree;

        /// <summary>
        /// The constructor for the class
        /// </summary>
        public EntreeCustomization()
        {
            InitializeComponent();
            buttonBun.IsEnabled = false;
            buttonDressing.IsEnabled = false;
            buttonKetchup.IsEnabled = false;
            buttonJelly.IsEnabled = false;
            buttonLettuce.IsEnabled = false;
            buttonMayo.IsEnabled = false;
            buttonMustard.IsEnabled = false;
            buttonNuggets.IsEnabled = false;
            buttonOnion.IsEnabled = false;
            buttonPeanutButter.IsEnabled = false;
            buttonPeppers.IsEnabled = false;
            buttonPickle.IsEnabled = false;
            buttonTomato.IsEnabled = false;
            buttonCheese.IsEnabled = false;
            customName.Text = "Test";
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// The entree constructor for the class
        /// </summary>
        /// <param name="entree">The entree that is being modified</param>
        public EntreeCustomization(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
            buttonBun.IsEnabled = false;
            buttonDressing.IsEnabled = false;
            buttonKetchup.IsEnabled = false;
            buttonJelly.IsEnabled = false;
            buttonLettuce.IsEnabled = false;
            buttonMayo.IsEnabled = false;
            buttonMustard.IsEnabled = false;
            buttonNuggets.IsEnabled = false;
            buttonOnion.IsEnabled = false;
            buttonPeanutButter.IsEnabled = false;
            buttonPeppers.IsEnabled = false;
            buttonPickle.IsEnabled = false;
            buttonTomato.IsEnabled = false;
            buttonCheese.IsEnabled = false;
            if (entree is Brontowurst bron)
            {
                customName.Text = "Brontowurst";
                buttonBun.IsEnabled = true;
                buttonOnion.IsEnabled = true;
                buttonPeppers.IsEnabled = true;
                //bron.HoldBun();
                //bron.HoldOnion();
                //bron.HoldPeppers();
                entree = bron;
            }
            else if (entree is DinoNuggets nug)
            {
                customName.Text = "Dino-Nuggets";
                buttonNuggets.IsEnabled = true;
                //nug.AddNugget();
                entree = nug;
            }
            else if (entree is PrehistoricPBJ pbj)
            {
                customName.Text = "Prehistoric PB&J";
                buttonJelly.IsEnabled = true;
                buttonPeanutButter.IsEnabled = true;
                //pbj.HoldJelly();
                //pbj.HoldPeanutButter();
                entree = pbj;
            }
            else if (entree is PterodactylWings wings)
            {
                customName.Text = "Pterodactyl Wings";
                entree = wings;
            }
            else if (entree is SteakosaurusBurger sb)
            {
                customName.Text = "Steakosaurus Burger";
                buttonBun.IsEnabled = true;
                buttonKetchup.IsEnabled = true;
                buttonMustard.IsEnabled = true;
                buttonPickle.IsEnabled = true;
                //sb.HoldBun();
                //sb.HoldKetchup();
                //sb.HoldMustard();
                //sb.HoldPickle();
                entree = sb;
            }
            else if (entree is TRexKingBurger kb)
            {
                customName.Text = "T-Rex King Burger";
                buttonBun.IsEnabled = true;
                buttonKetchup.IsEnabled = true;
                buttonMustard.IsEnabled = true;
                buttonPickle.IsEnabled = true;
                buttonLettuce.IsEnabled = true;
                buttonMayo.IsEnabled = true;
                buttonOnion.IsEnabled = true;
                buttonTomato.IsEnabled = true;
                //kb.HoldBun();
                //kb.HoldKetchup();
                //kb.HoldLettuce();
                //kb.HoldMayo();
                //kb.HoldMustard();
                //kb.HoldOnion();
                //kb.HoldPickle();
                //kb.HoldTomato();
                entree = kb;
            }
            else if (entree is VelociWrap wrap)
            {
                customName.Text = "Veloci-Wrap";
                buttonCheese.IsEnabled = true;
                buttonDressing.IsEnabled = true;
                buttonLettuce.IsEnabled = true;
                //wrap.HoldCheese();
                //wrap.HoldDressing();
                //wrap.HoldLettuce();
                entree = wrap;
            }
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// The combo constructor for the class
        /// </summary>
        /// <param name="combo">The combo being mofified</param>
        public EntreeCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            buttonBun.IsEnabled = false;
            buttonDressing.IsEnabled = false;
            buttonKetchup.IsEnabled = false;
            buttonJelly.IsEnabled = false;
            buttonLettuce.IsEnabled = false;
            buttonMayo.IsEnabled = false;
            buttonMustard.IsEnabled = false;
            buttonNuggets.IsEnabled = false;
            buttonOnion.IsEnabled = false;
            buttonPeanutButter.IsEnabled = false;
            buttonPeppers.IsEnabled = false;
            buttonPickle.IsEnabled = false;
            buttonTomato.IsEnabled = false;
            buttonCheese.IsEnabled = false;
            if (combo.Entree is Brontowurst bron)
            {
                customName.Text = "Brontowurst";
                buttonBun.IsEnabled = true;
                buttonOnion.IsEnabled = true;
                buttonPeppers.IsEnabled = true;
                //bron.HoldBun();
                //bron.HoldOnion();
                //bron.HoldPeppers();
                entree = bron;
            }
            else if (combo.Entree is DinoNuggets nug)
            {
                customName.Text = "Dino-Nuggets";
                buttonNuggets.IsEnabled = true;
                //nug.AddNugget();
                entree = nug;
            }
            else if (combo.Entree is PrehistoricPBJ pbj)
            {
                customName.Text = "Prehistoric PB&J";
                buttonJelly.IsEnabled = true;
                buttonPeanutButter.IsEnabled = true;
                //pbj.HoldJelly();
                //pbj.HoldPeanutButter();
                entree = pbj;
            }
            else if (combo.Entree is PterodactylWings wings)
            {
                customName.Text = "Pterodactyl Wings";
                entree = wings;
            }
            else if (combo.Entree is SteakosaurusBurger sb)
            {
                customName.Text = "Steakosaurus Burger";
                buttonBun.IsEnabled = true;
                buttonKetchup.IsEnabled = true;
                buttonMustard.IsEnabled = true;
                buttonPickle.IsEnabled = true;
                //sb.HoldBun();
                //sb.HoldKetchup();
                //sb.HoldMustard();
                //sb.HoldPickle();
                entree = sb;
            }
            else if (combo.Entree is TRexKingBurger kb)
            {
                customName.Text = "T-Rex King Burger";
                buttonBun.IsEnabled = true;
                buttonKetchup.IsEnabled = true;
                buttonMustard.IsEnabled = true;
                buttonPickle.IsEnabled = true;
                buttonLettuce.IsEnabled = true;
                buttonMayo.IsEnabled = true;
                buttonOnion.IsEnabled = true;
                buttonTomato.IsEnabled = true;
                //kb.HoldBun();
                //kb.HoldKetchup();
                //kb.HoldLettuce();
                //kb.HoldMayo();
                //kb.HoldMustard();
                //kb.HoldOnion();
                //kb.HoldPickle();
                //kb.HoldTomato();
                entree = kb;
            }
            else if (combo.Entree is VelociWrap wrap)
            {
                customName.Text = "Veloci-Wrap";
                buttonCheese.IsEnabled = true;
                buttonDressing.IsEnabled = true;
                buttonLettuce.IsEnabled = true;
                //wrap.HoldCheese();
                //wrap.HoldDressing();
                //wrap.HoldLettuce();
                entree = wrap;
            }
            if (DataContext is Order order)
            {
                //CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += OnCurrentChanged;
            }
        }

        /// <summary>
        /// Used to hold the bun.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectBun(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if(combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldBun();
                    }
                    else if (entree is SteakosaurusBurger sb)
                    {
                        sb.HoldBun();
                    }
                    else if (entree is Brontowurst bron)
                    {
                        bron.HoldBun();
                        bron.HoldOnion();
                        bron.HoldPeppers();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldBun();
                    }
                    else if (combo.Entree is SteakosaurusBurger sb)
                    {
                        sb.HoldBun();
                    }
                    else if (combo.Entree is Brontowurst bron)
                    {
                        bron.HoldBun();
                        bron.HoldOnion();
                        bron.HoldPeppers();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the dressing
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDressing(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is VelociWrap wrap)
                    {
                        wrap.HoldDressing();
                    }
                }
                else
                {
                    if (combo.Entree is VelociWrap wrap)
                    {
                        wrap.HoldDressing();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the ketchup
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectKetchup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldKetchup();
                    }
                    else if (entree is SteakosaurusBurger sb)
                    {
                        sb.HoldKetchup();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldKetchup();
                    }
                    else if (combo.Entree is SteakosaurusBurger sb)
                    {
                        sb.HoldKetchup();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the Jelly
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectJelly(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is PrehistoricPBJ pbj)
                    {
                        pbj.HoldJelly();
                    }
                }
                else
                {
                    if (combo.Entree is PrehistoricPBJ pbj)
                    {
                        pbj.HoldJelly();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the lettuce
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectLettuce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is VelociWrap wrap)
                    {
                        wrap.HoldLettuce();
                    }
                    else if (entree is TRexKingBurger kb)
                    {
                        kb.HoldLettuce();
                    }
                }
                else
                {
                    if (combo.Entree is VelociWrap wrap)
                    {
                        wrap.HoldLettuce();
                    }
                    else if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldLettuce();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the mayo.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectMayo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldMayo();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldMayo();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the mustard
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectMustard(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldMustard();
                    }
                    else if (entree is SteakosaurusBurger sb)
                    {
                        sb.HoldMustard();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldMustard();
                    }
                    else if (combo.Entree is SteakosaurusBurger sb)
                    {
                        sb.HoldMustard();
                    }
                }
            }
        }

        /// <summary>
        /// Used to add nuggets
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is DinoNuggets nug)
                    {
                        nug.AddNugget();
                    }
                }
                else
                {
                    if (combo.Entree is DinoNuggets nug)
                    {
                        nug.AddNugget();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the onion.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectOnion(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldOnion();
                    }
                    else if (entree is Brontowurst bron)
                    {
                        bron.HoldOnion();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldOnion();
                    }
                    else if (combo.Entree is Brontowurst bron)
                    {
                        bron.HoldOnion();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the peanut butter
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectPeanutButter(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is PrehistoricPBJ pbj)
                    {
                        pbj.HoldPeanutButter();
                    }
                }
                else
                {
                    if (combo.Entree is PrehistoricPBJ pbj)
                    {
                        pbj.HoldPeanutButter();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the peppers
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectPeppers(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is Brontowurst bron)
                    {
                        bron.HoldPeppers();
                    }
                }
                else
                {
                    if (combo.Entree is Brontowurst bron)
                    {
                        bron.HoldPeppers();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the tomato
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectTomato(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldTomato();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldTomato();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the pickle
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectPickle(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is TRexKingBurger kb)
                    {
                        kb.HoldPickle();
                    }
                    else if (entree is SteakosaurusBurger sb)
                    {
                        sb.HoldPickle();
                    }
                }
                else
                {
                    if (combo.Entree is TRexKingBurger kb)
                    {
                        kb.HoldPickle();
                    }
                    else if (combo.Entree is SteakosaurusBurger sb)
                    {
                        sb.HoldPickle();
                    }
                }
            }
        }

        /// <summary>
        /// Used to hold the cheese
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
                if (combo == null)
                {
                    if (entree is VelociWrap wrap)
                    {
                        wrap.HoldCheese();
                    }
                }
                else
                {
                    if (combo.Entree is VelociWrap wrap)
                    {
                        wrap.HoldCheese();
                    }
                }
            }
        }

        /// <summary>
        /// Goes to the MenuCategorySelection page.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The RoutedEventArgs args</param>
        public void SelectDone(object sender, RoutedEventArgs args)
        {
            if(combo == null)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// Used when a menu option is changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="args">The args argument</param>
        public void OnCurrentChanged(object sender, EventArgs args)
        {
            if (DataContext is Order order)//side.Size = DinoDiner.Menu.Size.Large;
            {
            }
        }
    }
}
