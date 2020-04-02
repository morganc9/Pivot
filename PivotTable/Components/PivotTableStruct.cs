using Microsoft.AspNetCore.Components;
using PivotTable.Service;
using System.Linq;

namespace PivotTable.Components
{
    public class PivotTableStruct
    {

        public string[] ColumnsFields { get; }
        public string[] RowFilds { get; }

        public InfoData[] Data { get; }

        public PivotTableStruct(string[] rowFilds, InfoData[] data)
        {
            RowFilds = rowFilds;
            Data = data;
        }


        public MarkupString ToHtml() => (MarkupString)Write(Data, RowFilds, true);

        private string Write(InfoData[] initialData, string[] rowFilds, bool isFirst)
        {


            var field = rowFilds.First();
            var groupedData = initialData.GroupBy(c => typeof(InfoData).GetProperty(field).GetValue(c, null));
            var result = "<table>";
            foreach (var data in groupedData)
            {
                if (isFirst)
                    result += "<tr>";

                result += $"<th colspan=\"{data.Count()}\">{data.Key}<th>";
                var nextRows = rowFilds.Skip(1);
                if (nextRows.Any())
                {
                    result += Write(data.ToArray(), nextRows.ToArray(), false);
                }
                else
                {
                    result += $"<th>{data.Sum(x => x.Value)}<th>";
                }
                if (isFirst)
                    result += "</tr>";
            }
            result += "</table>";
            return result;
        }






        //




    }
}
