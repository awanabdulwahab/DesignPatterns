using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
