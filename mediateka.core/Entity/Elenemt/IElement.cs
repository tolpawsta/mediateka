using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediateka.core.Entity
{
    public interface IElement
    {
        /// <summary>
        /// Property Name of element
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Property Duration of element
        ///<return>Return TimeSpan</return>
        /// </summary>
        TimeSpan Duration { get; }

        /// <summary>
        /// Method Execute element
        /// </summary>
        void Execute();
        bool IsExecuting { get; set; }
    }
}
