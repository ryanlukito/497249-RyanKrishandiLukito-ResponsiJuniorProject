﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJuniorProject
{
    public class Employee
    {
        private string nama;
        private string id;
        private string departemen;

        // Encapsulation
        public string Nama { get { return nama; } set {  nama = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Departemen { get {  return departemen; } set {  departemen = value; } }
    }
}
