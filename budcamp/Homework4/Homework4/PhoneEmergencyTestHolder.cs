using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class PhoneEmergencyTestHolder : IEnumerable
    {
        private List<IPhone> _phones;

        public PhoneEmergencyTestHolder(IEnumerable<IPhone> phones)
        {
            this._phones = new List<IPhone>(phones);
        }

        public void AddPhone(IPhone phone)
        {
            _phones.Add(phone);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _phones.GetEnumerator();
        }
    }
}
