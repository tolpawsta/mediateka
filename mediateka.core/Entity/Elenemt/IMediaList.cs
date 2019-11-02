using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity
{
    interface IMediaList : IElement
    {
        IElement currentElement { get; set; }
        ICollection<IElement> elements { get; set; }
    }
}
