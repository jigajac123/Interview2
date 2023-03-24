using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReaderAPP
{
    public interface IServices
    {
        List<DataModel> ReadCsvFile();
        List<string> firstDscOrder();

        List<string> secondAlphabeticalOrder();
    }
}
