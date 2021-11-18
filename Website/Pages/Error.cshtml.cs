/*
 * Error.cshtml.cs
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// NameSpace for the Pages of Website
/// </summary>
namespace Website.Pages
{
    /// <summary>
    /// Class for Error page
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        /// <summary>
        /// Stores RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Stores ShowRequestId
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        /// <summary>
        /// backing field for ErrorModel
        /// </summary>
        private readonly ILogger<ErrorModel> _logger;

        /// <summary>
        /// ErrorModel constructor
        /// </summary>
        /// <param name="logger">An ILogger object</param>
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes Error page
        /// </summary>
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
