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
    public partial class Table_2BusinessRules : MyCompany.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view for an action
        /// with a command name that matches "Custom".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Table_2Model instance)
        {            
            var list = Table_2.SelectAll();
            foreach (var item in list)
            {
                Table_2 obj = new Table_2();
                obj.trackingNo = item.trackingNo;
                obj.fkcourierTitle = item.fkcourierTitle;
                var res = Fresh(obj);
                item.status = res.Data.Status;
                item.currentStatus = res.Data.CurrentStatus;
                item.Update();
            }
        }
    }
}
