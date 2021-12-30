using CarSelling.Local.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarSelling.Local.Helper
{
    public class SellingCarListBuilder
    {
        private readonly string _fileList;

        internal static SellingCarListBuilder Build()
        {
            return new SellingCarListBuilder("CarSelling.SellingList.json");
        }

        protected SellingCarListBuilder(string fileList)
        {
            _fileList = fileList;
        }

        public List<Car> ToList()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = _fileList;

            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new(stream);
            string result = reader.ReadToEnd();
            return JsonSerializer.Deserialize<List<Car>>(result);
        }
    }
}
