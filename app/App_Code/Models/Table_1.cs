using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
    public enum Table_1DataField
    {

        Id,

        LongUrl,

        Title,

        Hash,

        ShortUrl,

        CreateDate,

        UpdateDate,
    }

    public partial class Table_1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _longUrl;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _title;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hash;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _shortUrl;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updateDate;

        public Table_1Model()
        {
        }

        public Table_1Model(BusinessRules r) :
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

        public string LongUrl
        {
            get
            {
                return _longUrl;
            }
            set
            {
                _longUrl = value;
                UpdateFieldValue("LongUrl", value);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                UpdateFieldValue("Title", value);
            }
        }

        public string Hash
        {
            get
            {
                return _hash;
            }
            set
            {
                _hash = value;
                UpdateFieldValue("Hash", value);
            }
        }

        public string ShortUrl
        {
            get
            {
                return _shortUrl;
            }
            set
            {
                _shortUrl = value;
                UpdateFieldValue("ShortUrl", value);
            }
        }

        public DateTime? CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                _createDate = value;
                UpdateFieldValue("CreateDate", value);
            }
        }

        public DateTime? UpdateDate
        {
            get
            {
                return _updateDate;
            }
            set
            {
                _updateDate = value;
                UpdateFieldValue("UpdateDate", value);
            }
        }

        public FieldValue this[Table_1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
