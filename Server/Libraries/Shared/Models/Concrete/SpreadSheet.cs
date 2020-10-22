using Microsoft.AspNetCore.Components.Forms;
using Shared.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.Concrete
{
    public class SpreadSheet : ImportDocument
    {
        private readonly IList<SheetRow> rows = new List<SheetRow>();

        public SpreadSheet() { }
        public SpreadSheet(IBrowserFile file)
        {
            Size = file.Size;
            FileName = file.Name;
            ContentType = file.ContentType;
        }

        public int RowCount { get => rows.Count; }
        public ICollection<SheetRow> DataRows { get => rows; }
        public void AddRow(object Value)
        {
            rows.Add(new SheetRow(RowCount, Value));
        }
        public void AddRow(SheetRow row)
        {
            rows.Add(row);
        }
    }

    public class SheetRow
    {
        readonly IList<SheetColumn> columns = new List<SheetColumn>();

        public SheetRow(int index, object value)
        {
            Index = index;

            if (value is string s)
            {
                var stringValues = s.Split(',');

                if (stringValues != null)
                    foreach (var item in stringValues)
                    {
                        var columnIndex = Array.BinarySearch(stringValues, item);

                        if (columnIndex > -1)
                            columns.Add(new SheetColumn(Index, columnIndex, item));
                    }
            }
        }

        public int Index { get; }
        public int ColumnCount { get => columns.Count; }
        public ICollection<SheetColumn> Columns { get => columns; }
    }

    public class SheetColumn
    {
        public SheetColumn(int RowIndex, int ColumnIndex, object Value)
        {
            this.RowIndex = RowIndex;
            this.ColumnIndex = ColumnIndex;
            this.Value = Value;
        }
        public int RowIndex { get;}
        public int ColumnIndex { get; }
        public object Value { get; }
    }
}
