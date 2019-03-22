using System;
using System.Collections;
using System.Text;


namespace vjezba_1
{
    public class Automobili : CollectionBase
    {
        public int Add(Automobil automobil)
        {
            return InnerList.Add(automobil);
        }
        public void Remove(Automobil automobil)
        {
            InnerList.Remove(automobil);
        }
        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }
        }
    }
}