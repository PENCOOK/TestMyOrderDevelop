using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;
using MyCompany.Models;

namespace MyCompany.Rules
{
    public partial class Table_1BusinessRules : MyCompany.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view for an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Table_1Model instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
