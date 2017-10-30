using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickWebGridGenerator
{
    public class WebGridData
    {
        public bool EnablePaging { get; set; }
        public int RowsPerPage { get; set; }
        public bool FillEmptyRows { get; set; }
        public string PagingMode { get; set; }
        public bool AddRowFunctionality { get; set; }

        public string HeaderBackColor { get; set; }
        public string HeaderForeColor { get; set; }

        public string RowBackColor { get; set; }
        public string AlternativeRowColor { get; set; }
        public string ForeColor { get; set; }

        public string FooterBackColor { get; set; }
        public string FooterForeColor { get; set; }

        public string GridWidth { get; set; }

        public List<ColumnRequirement> ColumnsInformation { get; set; }
    }

    public class ColumnRequirement
    {
        public string ColumnName { get; set; }
        public string RowId { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSortable { get; set; }
        public bool DefaultSortCoulmn { get; set; }
        public bool IsColumnHeader { get; set; }
        public string CoumnHeader { get; set; }
        public string DataType { get; set; }
        public string PrimaryKeyColumn { get; set; }
        public string ColumnWidth { get; set; }

    }
}
