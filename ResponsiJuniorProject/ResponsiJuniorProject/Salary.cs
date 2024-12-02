using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJuniorProject
{
    internal class Salary
    {
        private string nama_jabatan;
        private string id;
        private string salary;

        // Encapsulation
        public string NamaJabatan { get { return nama_jabatan; } set { nama_jabatan = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string SalaryJabatan { get { return salary; } set { salary = value; } }
    }
}
