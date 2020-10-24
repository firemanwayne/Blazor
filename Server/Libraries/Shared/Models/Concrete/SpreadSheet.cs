using Microsoft.AspNetCore.Components.Forms;
using Shared.Models.Abstract;
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
}
