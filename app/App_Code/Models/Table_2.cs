using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
    public enum Table_2DataField
    {

        Id,

        trackingNo,

        fkcourier,

        fkcourierTitle,

        status,

        currentStatus,
    }

    public partial class Table_2Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _trackingNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _fkcourier;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fkcourierTitle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currentStatus;

        public Table_2Model()
        {
        }

        public Table_2Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                UpdateFieldValue("Id", value);
            }
        }

        public string trackingNo
        {
            get
            {
                return _trackingNo;
            }
            set
            {
                _trackingNo = value;
                UpdateFieldValue("trackingNo", value);
            }
        }

        public int? fkcourier
        {
            get
            {
                return _fkcourier;
            }
            set
            {
                _fkcourier = value;
                UpdateFieldValue("fkcourier", value);
            }
        }

        public string fkcourierTitle
        {
            get
            {
                return _fkcourierTitle;
            }
            set
            {
                _fkcourierTitle = value;
                UpdateFieldValue("fkcourierTitle", value);
            }
        }

        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                UpdateFieldValue("status", value);
            }
        }

        public string currentStatus
        {
            get
            {
                return _currentStatus;
            }
            set
            {
                _currentStatus = value;
                UpdateFieldValue("currentStatus", value);
            }
        }

        public FieldValue this[Table_2DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Table_2 : Table_2Model
    {

        public static List<MyCompany.Models.Table_2> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new Table_2Factory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<MyCompany.Models.Table_2> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new Table_2Factory().Select(filter, sort, Table_2Factory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<MyCompany.Models.Table_2> Select(string filter, params System.Object[] parameters)
        {
            return new Table_2Factory().Select(filter, null, Table_2Factory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static MyCompany.Models.Table_2 SelectSingle(string filter, params System.Object[] parameters)
        {
            return new Table_2Factory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static MyCompany.Models.Table_2 SelectSingle(int? id)
        {
            return new Table_2Factory().SelectSingle(id);
        }

        public int Insert()
        {
            return new Table_2Factory().Insert(this);
        }

        public int Update()
        {
            return new Table_2Factory().Update(this);
        }

        public int Delete()
        {
            return new Table_2Factory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("Id: {0}", this.Id);
        }

        public static MyCompany.Models.Table_2 SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<MyCompany.Models.Table_2> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<MyCompany.Models.Table_2> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<MyCompany.Models.Table_2> Select(object filter)
        {
            return Select(filter, null);
        }

        public static MyCompany.Models.Table_2 Insert(object initializer)
        {
            var instance = CreateInstance<MyCompany.Models.Table_2>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<MyCompany.Models.Table_2> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<MyCompany.Models.Table_2> SelectAll(string sort)
        {
            return new MyCompany.Models.Table_2Factory().Select(null, sort, MyCompany.Models.Table_2Factory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class Table_2Factory
    {

        public Table_2Factory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Table_2");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Table_2");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Table_2");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Table_2");
            }
        }

        public static Table_2Factory Create()
        {
            return new Table_2Factory();
        }

        public List<MyCompany.Models.Table_2> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<MyCompany.Models.Table_2> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<MyCompany.Models.Table_2> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            var request = new PageRequest(0, Int32.MaxValue, sort, new string[0])
            {
                RequiresMetaData = true,
                MetadataFilter = new string[] {
                    "fields"}
            };
            var c = ControllerFactory.CreateDataController();
            var bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            var page = c.GetPage("Table_2", dataView, request);
            return page.ToList<MyCompany.Models.Table_2>();
        }

        public MyCompany.Models.Table_2 SelectSingle(int? id)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = id;
            return SelectSingle(string.Format("Id={0}objpk0", parameterMarker), paramValues);
        }

        public MyCompany.Models.Table_2 SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(MyCompany.Models.Table_2 theTable_2, MyCompany.Models.Table_2 original_Table_2)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("Id", original_Table_2.Id, theTable_2.Id, true));
            values.Add(new FieldValue("trackingNo", original_Table_2.trackingNo, theTable_2.trackingNo));
            values.Add(new FieldValue("fkcourier", original_Table_2.fkcourier, theTable_2.fkcourier));
            values.Add(new FieldValue("fkcourierTitle", original_Table_2.fkcourierTitle, theTable_2.fkcourierTitle, true));
            values.Add(new FieldValue("status", original_Table_2.status, theTable_2.status));
            values.Add(new FieldValue("currentStatus", original_Table_2.currentStatus, theTable_2.currentStatus));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(MyCompany.Models.Table_2 theTable_2, MyCompany.Models.Table_2 original_Table_2, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Table_2",
                View = dataView,
                Values = CreateFieldValues(theTable_2, original_Table_2),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Table_2", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theTable_2);
            return result.RowsAffected;
        }

        public virtual int Update(MyCompany.Models.Table_2 theTable_2, MyCompany.Models.Table_2 original_Table_2)
        {
            return ExecuteAction(theTable_2, original_Table_2, "Edit", "Update", UpdateView);
        }

        public virtual int Update(MyCompany.Models.Table_2 theTable_2)
        {
            return Update(theTable_2, SelectSingle(theTable_2.Id));
        }

        public virtual int Insert(MyCompany.Models.Table_2 theTable_2)
        {
            return ExecuteAction(theTable_2, new Table_2(), "New", "Insert", InsertView);
        }

        public virtual int Delete(MyCompany.Models.Table_2 theTable_2)
        {
            return ExecuteAction(theTable_2, theTable_2, "Select", "Delete", DeleteView);
        }
    }
}
