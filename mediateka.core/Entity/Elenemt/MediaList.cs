using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity
{
    public class MediaList : IMediaList
    {
        public string Name { get; set; }
        
        public TimeSpan Duration { get; }
        public ICollection<IElement> elements { get;set;}
        public bool IsExecuting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IElement currentElement {get;set;}

        
        public MediaList(ICollection<IElement> elements):this(name:"Default",elements:elements)
        {
           
        }

        public MediaList(String name,ICollection<IElement> elements)
        {
            Name = name;
            this.elements = elements;
        }
        public void Execute()
        {
            foreach (IElement element in elements)
            {
               currentElement=element;
                currentElement.Execute();
            }
        }
    }
}
