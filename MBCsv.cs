using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTranslationTool
{
    public class MBCsv
    {
        private string fileName;
        public string FileName { get { return fileName; } }
        public List<MBCsvLine> Lines { get; set; }
        
        public MBCsv(string fileName)
        {
            Lines = new List<MBCsvLine>();
            this.fileName = fileName;
        }
    }

    public class MBCsvLine
    {
        public string ID { get; set; }
        public string Value { get; set; }
    }

    public class MBCsvLoader
    {
        public MBCsv Read(string mbCsvFile)
        {
            MBCsv csv = new MBCsv(mbCsvFile);

            StreamReader reader = new StreamReader(mbCsvFile);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                try
                {
                    string[] tokens = line.Split('|');
                    MBCsvLine csvLine = new MBCsvLine();
                    csvLine.ID = tokens[0];
                    csvLine.Value = tokens[1];
                    csv.Lines.Add(csvLine);
                }
                catch { }
            }
            reader.Close();

            return csv;
        }

        public void Save(MBCsv csv, string mbCsvFile)
        {
            StreamWriter writer = new StreamWriter(mbCsvFile);
            foreach (var csvLine in csv.Lines)
            {
                writer.WriteLine(string.Format("{0}|{1}", csvLine.ID, csvLine.Value));
            }
            writer.Close();
        }
    }
}
