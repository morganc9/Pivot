using PivotTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PivotTable.Components
{
    public class PivotTableService
    {

        public List<Field> Fields;


        public event Action StateHasChanged;

        public Field ActiveItem { get; set; }


        public PivotTableService()
        {
            Fields = new List<Field>()
            {
                {new Field
                {
                    Name = "Position",
                    Zone = Zone.Row
                } },
                {
                new Field
                {
                    Name = "ServiceName",
                    Zone = Zone.All
                } },
                {           new Field
                {
                    Name = "MetricName",
                    Zone = Zone.All
                } } ,
                {            new Field
                                            {
                                                Name = "MetricName",
                                                Zone = Zone.All
                                            } },
                {            new Field
                                            {
                                                Name = "Partition",
                                                Zone = Zone.All
                                            } },
                  {            new Field
                                            {
                                                Name = "Time",
                                                Zone = Zone.All
                                            } },

            };
        }

        public IEnumerable<Field> GetFields(Zone zone) => Fields.Where(x => x.Zone == zone);

        public void DropActiveItem(Zone zone)
        {
            if (ActiveItem.Zone == zone)
            {

            }
            else
            {
                ActiveItem.Zone = zone;
            }
            ActiveItem = null;
            StateHasChanged?.Invoke();
        }

        public void Swap(string overField)
        {
            if (ActiveItem == null)
                return;
            var index = Fields.FindIndex(x => x.Name == overField);
            Fields.Remove(ActiveItem);
            Fields.Insert(index, ActiveItem);
        }

    }
}
