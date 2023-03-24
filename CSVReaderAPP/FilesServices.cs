using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace CSVReaderAPP
{
    public class FilesServices
    {

        public static List<DataModel> ReadCsvFile()
        {
            try
            {
                var fileDecript = new CsvFileDescription()
                {
                    FirstLineHasColumnNames = true,
                    IgnoreUnknownColumns = true,
                    SeparatorChar = ',',
                    UseFieldIndexForReadingData = false
                };

                var fileContext = new CsvContext();
                var dataList = fileContext.Read<DataModel>(@"C:\Users\DELL\Documents\interviews\interview2\CSVReader\CSVReaderAPP\Data.csv", fileDecript);

                return dataList.ToList();
            }
            catch (Exception )
            {
                throw;
            }
           
        }

        public static List<string> firstDscOrder()  
        {
            var list = ReadCsvFile();

            var srt = new List<string>();

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach ( var item in list)
            {
                srt.Add(item.FirstName); srt.Add(item.LastName);
            }

            foreach(var name in srt)
            {
                if (map.ContainsKey(name))
                {
                    map[name] += 1;
                }
                else
                {
                    map.Add(name, 1);
                }
            }

            var Keys = new HashSet<string>(map.Keys);
            List<string> ord = new List<string>();
           
            foreach (var key in Keys)
            {
                 
               string[] print = {$"{key} {map[key]}"};

               foreach(var it in print)
               {
                    ord.Add($"{it}");    
               }

            }

                return  ord.OrderByDescending(x => x.Substring(x.IndexOf(' '),2)).ToList();

        }

        public static List<string> secondAlphabeticalOrder() {

            var list = ReadCsvFile();

            var srt = new List<string>();

            foreach (var item in list)
            {
                srt.Add(item.Address); 
            }

           
            return  srt.OrderBy(y=>y.Substring(y.IndexOf(' '),2)).ToList();
            
        }


    }
}
