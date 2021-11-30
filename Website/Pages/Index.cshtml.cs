/*
 * Index.cshtml.cs
 * Modified by: Adam Duvendack
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GyroScope.Data;

/// <summary>
/// NameSpace for the Pages of Website
/// </summary>
namespace Website.Pages
{
    /// <summary>
    /// Class for Index page
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// ErrorModel constructor
        /// </summary>
        public IndexModel()
        {
            
        }

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IMenuItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] MenuItemCategories, double? CaloriesMin, double? CaloriesMax, decimal? PriceMin, decimal? PriceMax)
        {
            this.SearchTerms = SearchTerms;
            this.MenuItemCategories = MenuItemCategories;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            
            Items = Menu.FullMenu;
            List<IMenuItem> list = new List<IMenuItem>();

            if (SearchTerms != null)
            {
                string[] SearchBarTerms = SearchTerms.Trim().Split();

                foreach (string term in SearchBarTerms)
                {
                    IEnumerable<IMenuItem> temp = Menu.FullMenu;
                    var itemsByTerm = temp.Where(IMenuItem => IMenuItem.Name.Contains(term, StringComparison.InvariantCultureIgnoreCase) || IMenuItem.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase));

                    foreach (var food in itemsByTerm)
                    {
                        list.Add(food);
                        
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (list[i].Name == list[j].Name)
                                {
                                    list.Remove(food);
                                }
                            }
                        }
                    }
                }

                Items = list;
            }
            
            if (MenuItemCategories != null && MenuItemCategories.Length != 0)
            {
                Items = Items.Where(IMenuItem => MenuItemCategories.Contains(IMenuItem.ItemType));
            }

            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Calories <= CaloriesMax);
            }
            else if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Calories >= CaloriesMin);
            }
            else if (CaloriesMax != null && CaloriesMin != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Calories >= CaloriesMin && IMenuItem.Calories <= CaloriesMax);
            }

            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Price <= PriceMax);
            }
            else if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Price >= PriceMin);
            }
            else if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(IMenuItem => IMenuItem.Price >= PriceMin && IMenuItem.Price <= PriceMax);
            }
        }

        /// <summary>
        /// Gets the possible Menu Item Categories
        /// </summary>
        public string[] PossibleCategories
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks",
            "Treats",
            };
        }

        /// <summary>
        /// The filtered Menu Item Categories
        /// </summary>
        public string[] MenuItemCategories { get; set; }

        /// <summary>
        /// The filtered Calories minimum
        /// </summary>
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// The filtered Calories maximum
        /// </summary>
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// The filtered Price minimum
        /// </summary>
        public decimal? PriceMin { get; set; }

        /// <summary>
        /// The filtered Price maximum
        /// </summary>
        public decimal? PriceMax { get; set; }
    }
}
