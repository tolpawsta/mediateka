
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.Entity
{
    public class MediaList:ICollection<BaseElement>
    {

        ICollection<BaseElement> elements;

        public MediaList(ICollection<BaseElement> elements)
        {
            this.elements = elements;
        }
        public BaseElement currentElement {get;set;}

        public ICollection<BaseElement> GetElements()
        {
            return elements;
        }
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(BaseElement item)
        {
            elements.Add(item);
            
        }

        public void Clear()
        {
            elements.Clear();
        }

        public bool Contains(BaseElement item)
        {
           return elements.Contains(item);
        }

        public void CopyTo(BaseElement[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        public IEnumerator<BaseElement> GetEnumerator()
        {
           return elements.GetEnumerator();
        }

        public bool Remove(BaseElement item)
        {
           return elements.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) elements;
        }
        public void Sort(ElementCompareType compareType)
        {
            switch (compareType)
            {
                case ElementCompareType.Name: elements = elements.OrderBy(x => x.Name).ToList(); break;
                default: throw new ArgumentException("unexpected compare type"); 
            }
            
           // elements.OrderBy((x)=>x.Name==compareType.ToString(), new BaseElementComparer(compareType));
        }
    }
}
