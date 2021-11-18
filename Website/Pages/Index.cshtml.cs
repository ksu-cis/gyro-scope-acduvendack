/*
 * Index.cshtml.cs
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// backing field for ErrorModel
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// ErrorModel constructor
        /// </summary>
        /// <param name="logger">An ILogger object</param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes Index page
        /// </summary>
        public void OnGet()
        {

        }
    }
}
