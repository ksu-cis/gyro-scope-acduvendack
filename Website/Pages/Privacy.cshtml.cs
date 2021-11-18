/*
 * Privacy.cshtml.cs
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
    /// Class for Privacy page
    /// </summary>
    public class PrivacyModel : PageModel
    {
        /// <summary>
        /// backing field for ErrorModel
        /// </summary>
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// ErrorModel constructor
        /// </summary>
        /// <param name="logger">An ILogger object</param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes Error page
        /// </summary>
        public void OnGet()
        {
        }
    }
}
