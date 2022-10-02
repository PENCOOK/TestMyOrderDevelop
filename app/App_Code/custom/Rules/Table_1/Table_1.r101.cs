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
        /// with a command name that matches "Update".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(Table_1Model instance)
        {
            instance.UpdateDate = DateTime.Now;
        }
    }
}
