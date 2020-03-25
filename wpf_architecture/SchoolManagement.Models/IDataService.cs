using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Models
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
