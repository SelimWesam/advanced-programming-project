using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moodle1
{
    interface dict
    {
        int Length();
        void sort();
        bool IsEmpty(string key);
        void Add(string key, string value, string fname);
        bool find(string key);
        void edit(string key, string value, string fname);
        void delete(string key, string value);
        void findLect(string key,string value);
        void OpenPdfFile(string filepath);
    }
}
